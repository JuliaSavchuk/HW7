namespace HW7
{
    internal class Ukulele : MusicalInstrument
    {
        public string Size { get; private set; }

        public Ukulele(string name, string description, string history, string ukulesoun, string size) : base(name, description, history, ukulesoun)
        {
            Size = size;
        }

        public override void UniqueChar()
        {
            Console.WriteLine($"Size : {Size}");
        }
    }
}
