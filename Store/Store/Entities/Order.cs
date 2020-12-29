using System;
using System.Text;
using System.Globalization;
using System.Collections.Generic;
using Store.Entities.Enums;

namespace Store.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Itens { get; set; } = new List<OrderItem>();

        //Constructor
        public Order(DateTime moment, OrderStatus status, Client client)
        {
            this.Moment = moment;
            this.Status = status;
            this.Client = client;
        }

        //Methods
        public void AddItem(OrderItem item)
        {
            Itens.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Itens.Remove(item);
        }

        public double Total()
        {
            double soma = 0.0;
            foreach (OrderItem i in Itens)
            {
                soma += i.SubTotal();
            }
            return soma;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\nORDER SUMMARY:");
            sb.AppendLine("Order moment: " + this.Moment);
            sb.AppendLine("Order status: " + this.Status);
            sb.AppendLine(this.Client.ToString());
            sb.AppendLine("Order items:");
            foreach (OrderItem i in this.Itens)
                sb.AppendLine(i.ToString());
            sb.AppendLine("Total price: " + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
