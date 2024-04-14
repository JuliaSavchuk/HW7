namespace HW7
{
    internal class Product : Money
    {
        public string Name { get; set; }
        public Money Price { get; set; }

        public Product(int dol, int cen, string name, Money price): base(dol,cen)
        {
            Name = name;
            Price = price;
        }

        //зменшення ціни
        public void DecreasePrice(int dollars, int cents)
        {
            int newDollars = Price.Dollars - dollars;
            int newCents = Price.Cents - cents;

            if (newCents < 0)
            {
                newDollars -= 1;
                newCents += 100;
            }

            Price.SetAmount(newDollars, newCents);
        }
    }
}
