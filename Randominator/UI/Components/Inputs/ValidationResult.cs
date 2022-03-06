namespace TehGM.Randominator.UI.Components.Inputs
{
    public class ValidationResult : IEquatable<ValidationResult>
    {
        public string Text { get; }
        public bool IsError { get; }

        public ValidationResult(string text, bool isError)
        {
            this.Text = text;
            this.IsError = isError;
        }

        public static implicit operator ValidationResult(string text)
            => new ValidationResult(text, !string.IsNullOrWhiteSpace(text));

        public static bool operator ==(ValidationResult left, ValidationResult right)
            => EqualityComparer<ValidationResult>.Default.Equals(left, right);

        public static bool operator !=(ValidationResult left, ValidationResult right)
            => !(left == right);

        public override bool Equals(object obj)
            => this.Equals(obj as ValidationResult);

        public bool Equals(ValidationResult other)
            => other != null &&
                   this.Text == other.Text &&
                   this.IsError == other.IsError;

        public override int GetHashCode()
            => HashCode.Combine(this.Text, this.IsError);
    }
}
