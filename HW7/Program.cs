namespace HW7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n_____Task 1_____\n");
            Money price = new Money(10, 50);
            Product product = new Product(10, 50, "Book", price);

            Console.WriteLine("Початкова ціна товару:");
            product.Price.DisplayAmount();
            Console.WriteLine("\nЗменшимо ціну товару на $5.30:");
            product.DecreasePrice(5, 30);
            Console.WriteLine("\nОновлена ціна товару:");
            product.Price.DisplayAmount();


            Console.WriteLine("\n_____Task 2_____\n");
            Kettle kettle = new Kettle("Electric Kettle");
            Microwave microwave = new Microwave("Microwave Oven");
            Car car = new Car("Sedan Car");
            Steamboat steamboat = new Steamboat("Paddle Steamboat");

            Console.WriteLine("\nKettle");
            kettle.Show();
            kettle.Sound();
            kettle.Desc();
            Console.WriteLine("\nMicrowave");
            microwave.Show();
            microwave.Sound();
            microwave.Desc();
            Console.WriteLine("\nCar");
            car.Show();
            car.Sound();
            car.Desc();
            Console.WriteLine("\nSteamboat");
            steamboat.Show();
            steamboat.Sound();
            steamboat.Desc();


            Console.WriteLine("\n_____Task 3_____\n");
            Violin violin = new Violin("Violin", "Bow stringed musical instrument", "History of the creation of the violin", "The sound of the violin", "Wood");
            violin.Show();
            violin.Desc();
            violin.HistoryInfo();
            violin.Sound();
            violin.UniqueChar();

            Console.WriteLine("\n");
            Trombone trombone = new Trombone("Trombone", "Wind musical instrument with great distance", "History of creation of trombone", "Sound of trombone", "Bass");
            trombone.Show();
            trombone.Desc();
            trombone.HistoryInfo();
            trombone.Sound();
            trombone.UniqueChar();

            Console.WriteLine("\n");
            Ukulele ukulele = new Ukulele("Ukulele", "String musical instrument with four strings", "Ukulele history", "Ukulele sound", "Small");
            ukulele.Show();
            ukulele.Desc();
            ukulele.HistoryInfo();
            ukulele.Sound();
            ukulele.UniqueChar();

            Console.WriteLine("\n");
            Cello cello = new Cello("Cello", "Stringed musical instrument belonging to the group of violins", "History of the creation of the cello", "The sound of the cello", "Hunk");
            cello.Show();
            cello.Desc();
            cello.HistoryInfo();
            cello.Sound();
            cello.UniqueChar();

            Console.WriteLine("\n_____Task 4_____\n");
            President president = new President("Richard",47);
            Security security = new Security("Alex",27);
            Manager manager = new Manager("Sofia", 29);
            Engineer engineer = new Engineer("Anastasia",33);

            Console.WriteLine("Information about different workers:");
            Console.WriteLine("----------------------------------");

            Console.Write("President: ");
            president.InfoWork();
            president.Print();

            Console.Write("Security: ");
            security.InfoWork();
            security.Print();

            Console.Write("Manager: ");
            manager.InfoWork();
            manager.Print();

            Console.Write("Engineer: ");
            engineer.InfoWork();
            engineer.Print();
        }
    }
}