using System.Numerics;
using System.Security.Cryptography;

namespace TehGM.Randominator.Generators.UniqueID
{
    public class UniqueIdValue
    {
        public Guid Value { get; }

        public string StringValue { get; }
        public int HashCodeValue { get; }
        public BigInteger NumberValue { get; }
        public string Base64Value { get; }
        public string SHA1Value { get; }
        public string SHA256Value { get; }
        public string SHA384Value { get; }
        public string SHA512Value { get; }

        public UniqueIdValue(Guid value)
        {
            this.Value = value;
            byte[] bytes = value.ToByteArray();

            this.StringValue = this.Value.ToString();
            this.HashCodeValue = this.Value.GetHashCode();
            this.NumberValue = new BigInteger(bytes);
            using (SHA1 sha1 = SHA1.Create())
                this.SHA1Value = string.Concat(sha1.ComputeHash(bytes).Select(x => x.ToString("X2")));
            using (SHA256 sha256 = SHA256.Create())
                this.SHA256Value = string.Concat(sha256.ComputeHash(bytes).Select(x => x.ToString("X2")));
            using (SHA384 sha384 = SHA384.Create())
                this.SHA384Value = string.Concat(sha384.ComputeHash(bytes).Select(x => x.ToString("X2")));
            using (SHA512 sha512 = SHA512.Create())
                this.SHA512Value = string.Concat(sha512.ComputeHash(bytes).Select(x => x.ToString("X2")));
            this.Base64Value = Convert.ToBase64String(bytes);
        }
    }
}
