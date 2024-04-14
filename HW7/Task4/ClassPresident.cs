namespace HW7
{
    internal class President : Worker
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public President(string name, int age)
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
            Console.WriteLine("President: oversees the company's overall operations and strategy.");
        }
    }
}
