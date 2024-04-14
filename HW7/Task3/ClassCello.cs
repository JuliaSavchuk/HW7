namespace HW7
{
    internal class Cello : MusicalInstrument
    {
        public string Shape { get; private set; }

        public Cello(string name, string description, string history, string celsound, string shape) : base(name, description, history, celsound)
        {
            Shape = shape;
        }

        public override void UniqueChar()
        {
            Console.WriteLine($"Shape : {Shape}");
        }
    }
}
