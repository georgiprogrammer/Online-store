using System;
using System.Collections.Generic;
using System.Text;

namespace Online_Shop_Inventory
{
    public class Product
    {
        protected string name;
        private double price;
        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
        public string Name
        {
            get { return name; }
            set { this.name = value; }
        } 
        public double Price
        {
            get { return price; }
            set { this.price = value; }
        }
        public void Printdetails()
        {
            Console.WriteLine( $"Product {this.Name} costs {this.Price:f2} leva.");
        }

    }
}
