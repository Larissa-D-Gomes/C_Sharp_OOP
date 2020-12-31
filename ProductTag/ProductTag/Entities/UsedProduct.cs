using System;
using System.Globalization;

namespace ProductTag.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        //Constructor 
        // @param string name, double price, DateTime manufactureDate
        public UsedProduct(string name, double price, DateTime manufactureDate) 
            : base(name, price)
        {
            this.ManufactureDate = manufactureDate;
        }

        //Methods
        /* Tag String Builder 
         * @return string 
         */
        public override string PriceTag()
        {
            return this.Name + "(used) $ " 
                   + this.Price.ToString("F2", CultureInfo.InvariantCulture) 
                   + " (Manufacture date: " + this.ManufactureDate.ToString("dd/MM/yyyy") +")" ;
        }

    }
}
