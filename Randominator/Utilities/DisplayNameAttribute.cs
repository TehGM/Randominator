namespace TehGM.Randominator
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Enum 
        | AttributeTargets.Delegate | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Method | AttributeTargets.Property)]
    public class DisplayNameAttribute : Attribute
    {
        public string[] Values { get; }

        public string Name => this.Values[0];
        public string[] AlternativeNames => this.Values[1..];

        public DisplayNameAttribute(string name, params string[] alternativeNames)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Display names cannot be blank", nameof(name));
            if (alternativeNames.Any(value => value == null))
                throw new ArgumentNullException(nameof(alternativeNames));
            if (alternativeNames.Any(value => string.IsNullOrWhiteSpace(value)))
                throw new ArgumentException("Display names cannot be blank", nameof(alternativeNames));

            this.Values = new string[1 + alternativeNames.Length];
            this.Values[0] = name;
            Array.Copy(alternativeNames, 0, this.Values, 1, alternativeNames.Length);
        }
    }
}
