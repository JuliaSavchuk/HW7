namespace HW7
{
    internal class Steamboat : Device
    {
        public Steamboat(string name) : base(name)
        {
        }

        public override void Sound()
        {
            Console.WriteLine($"Sound of {Name}: *chug chug*");
        }

        public override void Desc()
        {
            Console.WriteLine($"Description of {Name}: A boat powered by steam engines.");
        }
    }
}
