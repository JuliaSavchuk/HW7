namespace HW7
{
    internal class Kettle : Device
    {
        public Kettle(string name) : base(name) 
        { 
        }


        public override void Sound()
        {
            Console.WriteLine($"Sound of {Name}: *whistle*");
        }

        public override void Desc()
        {
            Console.WriteLine($"Description of {Name}: A device used for boiling water.");
        }
    }
}
