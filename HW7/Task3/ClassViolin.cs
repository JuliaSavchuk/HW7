namespace HW7
{
    internal class Violin : MusicalInstrument
    {
        public string Material { get; set; }

        public Violin(string name, string description, string history, string viosound, string material) : base(name, description, history, viosound)
        {
            Material = material;
        }

        public override void UniqueChar()
        {
            Console.WriteLine($"Material : {Material}");
        }
    }
}
