namespace HW7
{
    internal class Engineer : Worker
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Engineer(string name, int age)
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
            Console.WriteLine("Engineer: designs, develops, and maintains systems or products.");
        }
    }
}
