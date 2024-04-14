namespace HW7
{
    internal class Microwave : Device
    {
        public Microwave(string name) : base(name)
        {
        }

        public override void Sound()
        {
            Console.WriteLine($"Sound of {Name}: *hum*");
        }

        public override void Desc()
        {
            Console.WriteLine($"Description of {Name}: A device used for heating food quickly.");
        }
    }
}
