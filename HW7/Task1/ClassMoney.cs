﻿namespace HW7
{
    internal class Money
    {
        public int Dollars { get; set; }
        public int Cents { get; set; }

        public Money(int dollars, int cents)
        {
            Dollars = dollars;
            Cents = cents;
        }

        public void DisplayAmount()
        {
            Console.WriteLine($"Сума: ${Dollars}.{Cents:D2}");
        }

        public void SetAmount(int dollars, int cents)
        {
            Dollars = dollars;
            Cents = cents;
        }
    }
}


