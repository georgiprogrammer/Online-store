using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Online_Shop_Inventory
{
    internal class Cart
    {

        public List<Product> products;


        private List<Product> Products
        {
            get { return products; }
            set { this.products = value; }
        }

        public Cart()
        {

            this.Products = new List<Product>();
        }
        public void AddToCart(Product p)
        {
            products.Add(p);


        }
        public Product ReturnByName(string name)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (name == products.ElementAt(i).Name)
                {

                    return products.ElementAt(i);
                }
            }
            return null;
        }




        public void RemoveFromCart(Product p)
        {
            products.Remove(p);
        }
        public void RemoveAll()
        {
            products.Clear();
        }
        public void Display()
        {
            if (Products.Count>0)
            {

            
            foreach (Product product in Products)
            {
                Console.WriteLine("Name:" + product.Name);
                        if (product is Books)
                        {
                            Books book = (Books)product;
                            Console.WriteLine($"Price:{book.Price}\nGenre:{book.Genre}\nPages{book.Pages}");
                        Console.WriteLine(" ");
                        }
                        else if (product is Clothes)
                        {
                            Clothes clothe = (Clothes)product;
                            Console.WriteLine($"Price:{clothe.Price}\nSize:{clothe.Size}\nMaterial:{clothe.Material}\nColor:{clothe.Color}");
                        Console.WriteLine(" ");
                        }
                        else if (product is Electronics)
                        {
                            Electronics e = (Electronics)product;
                            Console.WriteLine($"Price:{e.Price}\nYor:{e.YearOfRelease}");
                        Console.WriteLine(" ");
                        }
                    
                }
            }
            else
            {
                Console.WriteLine("Cart is empty!");
            }
        }
      
        public void CalculateTotalPrice()
        {
            double x = 0;
            foreach (Product product in products)
            {
                x += product.Price;
            }
            Console.WriteLine("Total price of your cart is:"+x);
        }
        public Product ReturnP()
        {
            foreach (Product p in products)
            {


                return p;
                
            }
            return null;
        }

    }
}

