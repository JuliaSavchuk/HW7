namespace HW7
{
    internal class Security : Worker
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Security(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void InfoWork()
        {
            Console.WriteLine($"Name: {Name}\nAge: {Age}");
        }
        public override void Print()
        {
            Console.WriteLine("Security: responsible for ensuring the safety and security of the premises.");
        }
    }
}
