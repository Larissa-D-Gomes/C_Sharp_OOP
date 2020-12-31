using System;
using System.Globalization;

namespace ProductTag.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        //Constructor
        // @param string name, double price, double customsFee
        public ImportedProduct(string name, double price, double customsFee)
            : base(name, price)
        {
            this.CustomsFee = customsFee;
        }

        //Methods

        /* Return the Total Price 
         * return double Price + CustomsFee
         */
        public double TotalPrice()
        {
            return this.Price + this.CustomsFee;
        }

        /* Tag String Builder 
         * @return string 
         */
        public override string PriceTag()
        {
            return this.Name + " $ "
                   + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                   + " (Manufacture date: " + this.CustomsFee + ")";
        }
    }
}
