namespace HW7
{
    internal class Car : Device
    {
        public Car(string name) : base(name)
        {
        }

        public override void Sound()
        {
            Console.WriteLine($"Sound of {Name}: *vroom*");
        }

        public override void Desc()
        {
            Console.WriteLine($"Description of {Name}: A vehicle used for transportation.");
        }
    }
}
