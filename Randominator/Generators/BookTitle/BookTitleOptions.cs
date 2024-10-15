namespace TehGM.Randominator.Generators.BookTitle
{
    public class BookTitleOptions
    {
        // List of words that follow "A"
        public ICollection<string> AWordSet { get; set; } = new string[]
        {
            "Song", "Court", "Dream", "Whisper", "Memory", "Battle",
            "Shadow", "Curse", "Vision", "Blade", "King", "Story", 
            "Legend", "Quest", "Kingdom", "Echo", "Fable", "Journey",
            "Saga", "Chronicle", "Hero", "Tale", "Legacy", "Prophecy",
            "Night", "Dawn", "Frost", "Glimmer", "Light", "Wanderer",
            "Bard", "Oath", "Dancer", "Heroine", "Beast", "Mystic",
            "Ballad", "House", "Child", "Queen", "Wraith", "Reaper",
            "Spark", "World", "Planet", "Plane", "Place", "Space"
        };

        // List of words that follow "An"
        public ICollection<string> AnWordSet { get; set; } = new string[]
        {
            "Echo", "Honor", "Empire", "Oath", "Adventure", "Allegory",
            "Invitation", "Eclipse", "Epic", "Artifact",
            "Oracle", "Endeavor", "Era", "Idyll", "Insight", "Infinity",
            "Anomaly", "Ambush", "Artifice", "Alliance", "Awakening",
            "Atmosphere", "Anthem", "Enigma", "Enlightenment", "Elysium",
            "Asylum", "Earth",            
        };

        // Shared word set for the second and third parts of the title
        public ICollection<string> SecondThirdWordSet { get; set; } = new string[]
        {
            "Fire", "Ice", "Thorns", "Roses", "Dreams", "Storms",
            "Shadows", "Seas", "Stars", "Chains", "Tides", "Sands",
            "Winds", "Bones", "Mysteries", "Legends", "Whispers", "Secrets",
            "Embers", "Echoes", "Visions", "Fires", "Legacies", "Fables",
            "Fury", "Hopes", "Dusk", "Dawn", "Desires", "Frost",
            "Sorrow", "Nights", "Dangers", "Wonders", "Myths",
            "Havens", "Hues", "Pathways", "Fates", "Mirrors",
            "Blood", "Light", "Tempests", "Voices", "Vices",
            "Mirages", "Tales"
        };
    }
}
