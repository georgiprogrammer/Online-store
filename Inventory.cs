using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace Online_Shop_Inventory
{

    public class Inventory
    {

        private List<Product> products;

        private List<Product> Products
        {
            get { return products; }
            set { this.products = value; }
        }

        public Inventory()
        {

            Products = new List<Product>();
        }
        public void AddToInventory(Product x)
        {

            Products.Add(x);

        }
        //public void Remove(string name)
        //{
        //    string x = Console.ReadLine();
        //    foreach (var Product in Products)
        //    {
        //        if (Product.Name == x)
        //        {
        //            Products.Remove(Product);
        //        }
        //    }
        //}
        public void DisplayTheInventory()
        {
            if (Products.Count > 0)
            {

                foreach (Product product in products)
                {

                    Console.WriteLine("Name:" + product.Name);
                    if (product is Books)
                    {
                        Books book = (Books)product;
                        Console.WriteLine($"Price:{book.Price}\nGenre:{book.Genre}\nPages{book.Pages}");

                    }
                    else if (product is Clothes)
                    {
                        Clothes clothe = (Clothes)product;
                        Console.WriteLine($"Price:{clothe.Price}\nSize:{clothe.Size}\nMaterial:{clothe.Material}\nColor:{clothe.Color}");

                    }
                    else if (product is Electronics)
                    {
                        Electronics e = (Electronics)product;
                        Console.WriteLine($"Price:{e.Price}\nYor:{e.YearOfRelease}");

                    }
                    Console.WriteLine(" ");
                }
            }
            else
            {
                throw new Exception("Inventory is empty!");
            }
        }















        public void CalculateTotalPrice()
        {
            double x = 0;
            foreach (Product product in products)
            {
                x += product.Price;
            }
            Console.WriteLine("Total value of the Inventory is:" + x);
        }
        public void ByName(string neshto)
        {
            bool q = false;
            
            if (neshto == null)
            {
                Console.WriteLine("There is no such product!");
                q = false;
            }
            
            foreach (Product product in products)
            {
                if (product.Name == neshto)
                {
                    q = true;
                   
                    if (product is Books)
                    {
                        Console.WriteLine($"Product {product.Name} is avaliable.");
                        Books book = (Books)(product);
                        Console.WriteLine($"Price:{book.Price}\nGenre:{book.Genre}\nPages{book.Pages}");
                    }
                    else if ((product is Clothes))
                    {
                        Console.WriteLine($"Product {(product).Name} is avaliable.");
                        Clothes clothe = (Clothes)(product);
                        Console.WriteLine($"Price:{clothe.Price}\nSize:{clothe.Size}\nMaterial:{clothe.Material}\nColor:{clothe.Color}");
                    }
                    else if ((product) is Electronics)
                    {
                        Console.WriteLine($"Product {product.Name} is avaliable.");
                        Electronics e = (Electronics)(product);
                        Console.WriteLine($"Price:{e.Price}\nYor:{e.YearOfRelease}");
                    }
                    
                }

            }
            if (!q)
            {
                Console.WriteLine("Product is not avaliable!");
                q= false;
            }

        }
        public Product ReturnByName(string name)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (name==products.ElementAt(i).Name)
                {

                    return products.ElementAt(i);
                }
            }
          return null;
        }
        

    }
}

