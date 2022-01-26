namespace TehGM.Randominator.UI.Components
{
    public class InputValidationResult : IEquatable<InputValidationResult>
    {
        public string Text { get; }
        public bool IsError { get; }

        public InputValidationResult(string text, bool isError)
        {
            this.Text = text;
            this.IsError = isError;
        }

        public static implicit operator InputValidationResult(string text)
            => new InputValidationResult(text, !string.IsNullOrWhiteSpace(text));

        public static bool operator ==(InputValidationResult left, InputValidationResult right)
            => EqualityComparer<InputValidationResult>.Default.Equals(left, right);

        public static bool operator !=(InputValidationResult left, InputValidationResult right)
            => !(left == right);

        public override bool Equals(object obj)
            => this.Equals(obj as InputValidationResult);

        public bool Equals(InputValidationResult other)
            => other != null &&
                   this.Text == other.Text &&
                   this.IsError == other.IsError;

        public override int GetHashCode()
            => HashCode.Combine(this.Text, this.IsError);
    }
}
