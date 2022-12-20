using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4
{
    public class Product
    {
        public string name;
        public double price;
        public int quantity;

        public Product (string name, double price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public string GetName()
        {
            return name;
        }

        public double GetPrice()
        {
            return price;
        }

        public int GetQuantity()
        {
            return quantity;
        }

        public void SetName(string newName)
        {
            this.name = newName;
        }

        public void SetPrice (double newPrice)
        {
            this.price = newPrice;
        }

        public void SetQuantity(int newQuantity)
        {
            this.quantity = newQuantity;
        }
    }
}
