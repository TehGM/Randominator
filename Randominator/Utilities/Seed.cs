namespace TehGM.Randominator
{
    public struct Seed : IEquatable<Seed>, IEquatable<int>
    {
        public int Value { get; }

        public Seed(int value)
        {
            this.Value = value;
        }

        public static implicit operator int(Seed seed)
            => seed.Value;
        public static implicit operator Seed(int seed)
            => new Seed(seed);
        public static explicit operator Seed(string seed)
            => FromString(seed, false);

        public static Seed FromString(string seed, bool caseInsensitive = false)
        {
            if (caseInsensitive)
                seed = seed.ToLowerInvariant();

            unchecked
            {
                int hash1 = (5381 << 16) + 5381;
                int hash2 = hash1;

                for (int i = 0; i < seed.Length; i += 2)
                {
                    hash1 = ((hash1 << 5) + hash1) ^ seed[i];
                    if (i == seed.Length - 1)
                        break;
                    hash2 = ((hash2 << 5) + hash2) ^ seed[i + 1];
                }

                return hash1 + (hash2 * 1566083941);
            }
        }

        public bool Equals(Seed other)
            => this.Equals(other.Value);
        public bool Equals(int other)
            => this.Value.Equals(other);
        public override bool Equals(object obj)
        {
            if (obj is Seed seed)
                return this.Equals(seed);
            if (obj is int value)
                return this.Equals(value);
            if (obj is string stringValue)
                return this.Equals(FromString(stringValue));
            return false;
        }

        public static bool operator ==(Seed left, Seed right)
            => left.Equals(right);
        public static bool operator !=(Seed left, Seed right)
            => !(left == right);

        public override int GetHashCode()
            => this.Value.GetHashCode();
        public override string ToString()
            => this.Value.ToString();
    }
}
