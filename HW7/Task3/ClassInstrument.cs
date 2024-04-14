namespace HW7
{
    internal class MusicalInstrument
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string History { get; set; }
        public string SoundInstr { get; set; }

        public MusicalInstrument(string name, string description, string history, string instrsoun)
        {
            Name = name;
            Description = description;
            History = history;
            SoundInstr = instrsoun;
        }

        public void Sound()
        {
            Console.WriteLine($"Sound {SoundInstr}");
        }

        public void Show()
        {
            Console.WriteLine($"Name: {Name}");
        }

        public void Desc()
        {
            Console.WriteLine($"Description: {Description}");
        }

        public void HistoryInfo()
        {
            Console.WriteLine($"History: {History}");
        }

        public virtual void UniqueChar()
        {
            Console.WriteLine("A unique characteristic : ");
        }
    }
}
