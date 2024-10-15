namespace TehGM.Randominator
{
    public class UserSettings
    {
        public MenuSettings Menu { get; set; } = new MenuSettings();

        public class MenuSettings
        {
            // funny generators
            public bool ShowMobileGameNameGenerator { get; set; } = true;
            public bool ShowDareGenerator { get; set; } = true;
            public bool ShowProgrammingStandardsGenerator { get; set; } = true; 
            public bool ShowBookTitleGenerator { get; set; } = true; 
            // utility generators
            public bool ShowUniqueIdGenerator { get; set; } = true;
        }
    }
}
