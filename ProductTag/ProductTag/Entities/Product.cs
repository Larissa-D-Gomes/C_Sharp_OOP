using System.Globalization;

namespace ProductTag.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        //Constructor

        /* 
         * @param string name, double price
         */
        public Product(string name, double price)
        {
            this.Name  = name;
            this.Price = price;
        }

        // Methods

        /* Tag String Builder 
         * @return string 
         */
        public virtual string PriceTag()
        {
            return this.Name + " $ " + this.Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
