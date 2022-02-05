namespace TehGM.Randominator.UI.Pages
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class SitemapAttribute : Attribute
    {
        private float _priority;

        public string Location { get; }
        public string LastModified { get; init; }
        public SitemapChangeFrequency? ChangeFrequency { get; init; }
        public float Priority
        {
            get => this._priority;
            init
            {
                if (value < 0.0f || value > 1.0f)
                    throw new ArgumentException("Sitemap priority must be between 0.0 and 1.0");
                this._priority = value;
            }
        }

        public SitemapAttribute(string location)
        {
            this.Location = location;
            this.Priority = 0.5f;
            this.ChangeFrequency = null;
            this.LastModified = null;
        }

        public SitemapAttribute()
            : this(null) { }
    }
}
