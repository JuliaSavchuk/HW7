namespace HW7
{
    internal class Manager : Worker
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Manager(string name, int age)
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
            Console.WriteLine("Manager: supervises a team or department to achieve organizational goals.");
        }
    }
}
