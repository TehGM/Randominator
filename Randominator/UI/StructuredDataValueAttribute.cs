namespace TehGM.Randominator.UI
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class StructuredDataValueAttribute : Attribute
    {
        public string Value { get; }

        public StructuredDataValueAttribute(string value) : base()
        {
            this.Value = value;
        }
    }
}
