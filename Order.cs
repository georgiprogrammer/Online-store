using System;
using System.Collections.Generic;
using System.Text;

namespace Online_Shop_Inventory
{
    class Order
    {
        
        private string customername;
        private string orderdate;
        
        private List<Product> products;

        public Order(string customername,string orderdate)
        {
            this.OrderDate = orderdate;
            this.CustomerName = customername;
           
            
        }
       
        private List<Product> Products
        {
            get { return products; }
            set { this.products = value; }
        }
        public string CustomerName
        {
            get { return customername; }
            set { this.customername = value; }
        }
        public string OrderDate
        {
            get { return orderdate; }
            set { this.orderdate = value; }
        }


        public void DetailOfOrder()
        {
            Console.WriteLine(($"Name:{this.CustomerName}\nDate of purchase:{this.OrderDate}.\n"));
            foreach (Product product in products)
            {
                Console.WriteLine($"Name:{product.Name}");
            if (product is Books)
            {
                Books book = (Books)product;
                Console.WriteLine($"Price:{book.Price}\nGenre:{book.Genre}\nPages{book.Pages}\n");
            }
            else if (product is Clothes)
            {
                Clothes clothe = (Clothes)product;
                Console.WriteLine($"Price:{clothe.Price}\nSize:{clothe.Size}\nMaterial:{clothe.Material}\nColor:{clothe.Color}\n");
            }
            else if (product is Electronics)
            {
                Electronics e = (Electronics)product;
                Console.WriteLine($"\nPrice:{e.Price}\nYor:{e.YearOfRelease}\n");
            } 
        }
            



        }
        public void AddToOrder(List<Product> cart)
        {
            this.products = cart;
        }
    }
}
