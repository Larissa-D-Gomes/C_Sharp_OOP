using System.Globalization;

namespace Store.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        //Constructor
        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        //Methods
        public override string ToString()
        {
            return this.Name + ", " + this.Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
