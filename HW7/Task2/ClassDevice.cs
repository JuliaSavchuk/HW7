namespace HW7
{
    internal class Device
    {
        public string Name { get; set; }

        public Device(string name)
        {
            Name = name;
        }

        public virtual void Sound()
        {
            Console.WriteLine($"Sound of {Name}: *beep* *beep*");
        }

        public void Show()
        {
            Console.WriteLine($"Device: {Name}");
        }

        public virtual void Desc()
        {
            Console.WriteLine($"Description of {Name}: Base device class.");
        }
    }
}
