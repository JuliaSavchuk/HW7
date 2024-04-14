namespace HW7
{
    internal class Trombone : MusicalInstrument
    {
        public string Type { get; set; }

        public Trombone(string name, string description, string history, string tromsound, string type) : base(name, description, history, tromsound)
        {
            Type = type;
        }

        public override void UniqueChar()
        {
            Console.WriteLine($"Type : {Type}");
        }
    }
}
