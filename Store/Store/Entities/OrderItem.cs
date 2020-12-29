using System.Globalization;

namespace Store.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        //Constructor
        public OrderItem(int quantity, double price, Product product)
        {
            this.Quantity = quantity;
            this.Price = price;
            this.Product = product;
        }

        //Methods
        public double SubTotal()
        {
            return this.Price * this.Quantity;
        }
        public override string ToString()
        {
            return this.Product + ", Quantity: " + this.Quantity 
                + ", Subtotal: " + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
