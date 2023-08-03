using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Online_Shop_Inventory
{
    internal class OnlineStore
    {
        public Cart cart = new Cart();
        public Inventory inventory = new Inventory();
        public List<Order> orderHistory = new List<Order>();
        
       public void Preset()
        {
            Clothes shirts = new Clothes("shirt", 15, "cotton", "black", "M");
            Clothes skirts = new Clothes("skirt", 8, "satin", "white", "L");
            Clothes shorts = new Clothes("jorts", 20, "denim", "black", "M");
            Books b1 = new Books("The Hobbit", 26, "fantasy", 304);
            Books b2 = new Books("The Great Gatsby", 16, "tragedy", 208);
            Books b3 = new Books("The portrait of Dorian Gray", 20, "gothic fiction", 288);
            Electronics e1 = new Electronics("Iphone", 1700, 2023);
            Electronics e2 = new Electronics("Samsung", 1700,  2023);
            Electronics e3 = new Electronics("Xiaomi", 1100,  2023);
            inventory.AddToInventory(shirts);
            inventory.AddToInventory(skirts);
            inventory.AddToInventory(shorts);
            inventory.AddToInventory(b1);
            inventory.AddToInventory(b2);
            inventory.AddToInventory(b3);
            inventory.AddToInventory(e1);
            inventory.AddToInventory(e2);
            inventory.AddToInventory(e3);
            MainMenu();

        }
        
        public void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("WELCOME TO ONLINE STORE\n");
            Console.WriteLine(" ");
            Console.WriteLine("1 Browse products");//gotovo
            Console.WriteLine("2 Cart");//done
            Console.WriteLine("3 Check out");//done
            Console.WriteLine("4 Order history");//done
            Console.WriteLine("5 EXIT");//done
            int decision = int.Parse(Console.ReadLine());
            if (decision == 1)
            {
                Console.Clear();
                Console.WriteLine("1 Search item by name in inventory");
                Console.WriteLine("2 Display inventory");
                Console.WriteLine("3 Add item to inventory");
                Console.WriteLine("4 Return to Main Menu");
                int decision1 = int.Parse(Console.ReadLine());
                if (decision1 == 1)
                {
                    Console.Clear();
                    Console.WriteLine("What item are you looking for:");
                    string name = Console.ReadLine();
                    inventory.ByName(name);


                    Console.WriteLine(" ");
                    Console.WriteLine("1 to go bakc to Mein Menu");
                    int n = int.Parse(Console.ReadLine());
                    if (n == 1)
                    {
                        MainMenu();
                    }
                    else
                    {
                        Console.WriteLine("Invalid command!");
                        MainMenu();
                    }

                }
                else if (decision1 == 2)
                {
                    Console.Clear();

                    inventory.DisplayTheInventory();
                    Console.WriteLine();
                    Console.WriteLine("1 To add a product to your cart");
                    Console.WriteLine("2 Calculate total value of inventory");
                    Console.WriteLine("3 Return to Main Menu");


                    int choice = int.Parse(Console.ReadLine());
                    if (choice == 1)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Which item do you want to add?:");
                        string name = Console.ReadLine();

                        if (inventory.ReturnByName(name) != null)
                        {
                            cart.AddToCart(inventory.ReturnByName(name));
                            Console.WriteLine("Item was added to your cart!");

                            Console.WriteLine("1 to go back to Mein Menu");
                            int n = int.Parse(Console.ReadLine());
                            if (n == 1)
                            {
                                MainMenu();
                            }
                            else
                            {
                                Console.WriteLine("Invalid command!");
                                MainMenu();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input!");
                            MainMenu();
                        }



















                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine(" ");
                        inventory.CalculateTotalPrice();
                        Console.WriteLine(" ");
                        Console.WriteLine("1 To return to Main Menu:");
                        int choice1 = int.Parse(Console.ReadLine());
                        if (choice1 == 1)
                        {
                            MainMenu();
                        }
                        else
                        {
                            Console.WriteLine("Invalid command!");

                            MainMenu();

                        }
                    }
                    else if (choice == 3)
                    {
                        MainMenu();
                    }
                    else
                    {
                        Console.WriteLine("Invalid command!");

                        MainMenu();

                    }
                }
                else if (decision1 == 3)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Choose product type (Book, Clothing item, Electronic device)");
                    string ptype = Console.ReadLine();

                    if (ptype == "Book")
                    {
                        Console.WriteLine("Book title:");
                        string title = Console.ReadLine();
                        Console.WriteLine("Book price:");
                        int price = int.Parse(Console.ReadLine());
                        Console.WriteLine("Book genre:");
                        string genre = Console.ReadLine();
                        Console.WriteLine("Book amount of pages: ");
                        int pages = int.Parse(Console.ReadLine());
                        Books newb = new Books(title, price, genre, pages);
                        inventory.AddToInventory(newb); Console.WriteLine("Item added to inventory!");
                        Console.WriteLine("1 Return to Main Menu");
                        int a = int.Parse(Console.ReadLine());
                        if (a == 1)
                        {
                            MainMenu();
                        }
                        else
                        {
                            Console.WriteLine("Invalid command!");
                            Console.Clear();
                            MainMenu();

                        }
                    }
                    else if (ptype == "Clothing item")
                    {
                        Console.WriteLine("Type:");
                        string type = Console.ReadLine();
                        Console.WriteLine("Price:");
                        int price = int.Parse(Console.ReadLine());
                        Console.WriteLine("Material:");
                        string material = Console.ReadLine();
                        Console.WriteLine("Color: ");
                        string color = Console.ReadLine();
                        Console.WriteLine("Size: ");
                        string size = Console.ReadLine();
                        Clothes newb = new Clothes(type, price, material, color, size);
                        inventory.AddToInventory(newb); Console.WriteLine("Item added to inventory!");
                        Console.WriteLine("1 Return to Main Menu");
                        int a = int.Parse(Console.ReadLine());
                        if (a == 1)
                        {
                            MainMenu();
                        }
                        else
                        {
                            Console.WriteLine("Invalid command!");
                            Console.Clear();
                            MainMenu();

                        }
                    }
                    else if (ptype == "Electronic device")
                    {
                        Console.WriteLine("Name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Price:");
                        int price = int.Parse(Console.ReadLine());

                        Console.WriteLine("Year of release: ");
                        int year = int.Parse(Console.ReadLine());
                        Electronics newb = new Electronics(name, price, year);
                        inventory.AddToInventory(newb);
                        Console.WriteLine("Item added to inventory!");
                        Console.WriteLine("1 Return to Main Menu");
                        int a = int.Parse(Console.ReadLine());
                        if (a == 1)
                        {
                            MainMenu();
                        }
                        else
                        {
                            Console.WriteLine("Invalid command!");
                            Console.Clear();
                            MainMenu();

                        }
                    }
                    else
                    
                        {
                            Console.WriteLine("Invalid command!");
                            Console.Clear();
                            MainMenu();

                        }

                    
                }
                else if (decision1 == 4)
                {
                    MainMenu();
                }
                else
                {
                    MainMenu();
                }
                
                
            }
            else if (decision == 2)
            { Console.Clear();
                cart.Display();
                Console.WriteLine(" ");
               
                Console.WriteLine("1 Calculate total rpice of your cart");
                Console.WriteLine("2 Remove items from your cart");
                Console.WriteLine("3 Return to Main Menu");
                int pick = int.Parse(Console.ReadLine());
                
                
                    if (pick == 1)
                {
                    Console.WriteLine(" ");
                    cart.CalculateTotalPrice();
                    Console.WriteLine(" ");
                    Console.WriteLine("1 Return to Main Menu");
                    int a = int.Parse(Console.ReadLine());
                    if (a == 1)
                    {
                        MainMenu();
                    }
                    else
                    {
                        Console.WriteLine("Invalid command!");
                        Console.Clear();
                        MainMenu();

                 
 }
                }
                else if (pick==2)
                {
                    Console.Clear();
                   
                    
                    cart.Display();
                    Console.WriteLine("Name of the product you want to remove:");
                    string x = Console.ReadLine();
                    cart.ReturnByName(x);
                    cart.RemoveFromCart(cart.ReturnByName(x));
                    Console.WriteLine("Item was succesfully removed from you cart!");
                    Console.WriteLine("\n1 to go back to Main Menu");
                    int n = int.Parse(Console.ReadLine());
                    if (n==1)
                    {
                        MainMenu();
                    }
                    
                    else
                    {
                        Console.WriteLine("Invalid input!");
                        MainMenu();
                    }

                    
                }

                else if (pick == 3)
                {
                    MainMenu();
                }
                else
                {
                    Console.WriteLine("Invalid command!");
                    Console.Clear();
                    MainMenu();

                }

            }
            else if (decision == 3)
            {
                Console.Clear();
                cart.Display();
                cart.CalculateTotalPrice();
                
                
                Console.WriteLine("Are you sure you want to make an order?(y/n)");
                string a = Console.ReadLine();
                if (a == "y")
                {
                    Console.WriteLine("Your name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Todays date: ");
                    string n = Console.ReadLine();
                    List<Product> cartCopy = new List<Product>(cart.products);
                    cart.RemoveAll();
                    Order poruchka = new Order(name, n);
                    poruchka.AddToOrder(cartCopy);
                    orderHistory.Add(poruchka);
                    Console.WriteLine("Your order is ready!");
                    Console.WriteLine(" ");
                    Console.WriteLine("1 Return to Main Menu");
                    int a4 = int.Parse(Console.ReadLine());
                    if (a4 == 1)
                    {
                        MainMenu();
                    }
                    else
                    {
                        Console.WriteLine("Invalid command!");
                        Console.Clear();
                        MainMenu(); ;
                        
                    }
                }
                else if (a=="n")
                {
                    Console.Clear();
                    Console.WriteLine("Ok, continue browsing, them!");
                    Console.WriteLine(" ");
                    Console.WriteLine("1 Return to Main Menu");
                    int a3 = int.Parse(Console.ReadLine());
                    if (a3 == 1)
                    {
                        MainMenu();
                    }
                    else
                    {
                        Console.WriteLine("Invalid command!");
                        Console.Clear();
                        MainMenu();

                    }
                }
            }
            else if (decision==4)
            {
                if (orderHistory.Count > 0)
                {


                    Console.Clear();
                    int count = 1;
                    foreach (Order order in orderHistory)
                    {
                        if (orderHistory.Count > 0)
                        {

                            Console.WriteLine($"Orders: { count}");
                            Console.WriteLine(" ");
                            order.DetailOfOrder();
                            count++;
                        }
                        else
                        {
                            Console.WriteLine("No orders yet!");
                        }
                    }
                    Console.WriteLine("1 To go to MainMenu");
                    int input = int.Parse(Console.ReadLine());
                    if (input == 1)
                    {
                        MainMenu();
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                        MainMenu();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("There have not been made any orders, yet!"); Console.WriteLine("1 To go to MainMenu");
                    int input = int.Parse(Console.ReadLine());
                    if (input == 1)
                    {
                        MainMenu();
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                        MainMenu();
                    }
                }
            }
            else if (decision == 5)
            {
                Environment.Exit(1);
            }
                
            
            //Console.WriteLine("4","Search item by name in Inventory");
            //Console.WriteLine("5","Check my cart");
            //Console.WriteLine("6","Check my orders");
            //Console.WriteLine("7","EXIT");

            // if (decision==2)
            // {
            //     inventory.DisplayTheInventory();

            //     Console.WriteLine("Back -To return to Main Menu:");
            //     string choice = Console.ReadLine();

            //     else if (choice=="Back")
            //     {
            //         MainMenu();
            //     }
            //     else
            //     {
            //         Console.Clear();
            //         throw new ArgumentException("Invalid Argument!");
            //         string choice1 = Console.ReadLine();
            //     }
            // }
            // else if (decision==1)
            // {
            //     Console.WriteLine("1", "Add product to Cart");
            //     Console.WriteLine("2", "Browse for product");
            //     Console.WriteLine("3", "Add new items to Inventory");

            // }
            //else if (decision==3)
            // {
            //     Console.WriteLine("Choose product type (Book, Clothing item, Electronic device)");
            //     string ptype = Console.ReadLine();

            //     if (ptype == "Book")
            //     {
            //         Console.WriteLine("Book title:");
            //         string title = Console.ReadLine();
            //         Console.WriteLine("Book price:");
            //         int price = int.Parse(Console.ReadLine());
            //         Console.WriteLine("Book genre:");
            //         string genre = Console.ReadLine();
            //         Console.WriteLine("Book amount of pages: ");
            //         int pages = int.Parse(Console.ReadLine());
            //         Books newb = new Books(title, price, genre, pages);
            //         inventory.AddToInventory(newb);
            //     }
            //     else if(ptype=="Clothing item") 
            //     {
            //         Console.WriteLine("Type:");
            //         string type = Console.ReadLine();
            //         Console.WriteLine("Price:");
            //         int price = int.Parse(Console.ReadLine());
            //         Console.WriteLine("Material:");
            //         string material = Console.ReadLine();
            //         Console.WriteLine("Color: ");
            //         string color = Console.ReadLine();
            //         Console.WriteLine("Size: ");
            //         string size = Console.ReadLine();
            //         Clothes newb = new Clothes(type, price, material, color, size);
            //         inventory.AddToInventory(newb);
            //     }
            //     else if (ptype == "Electronic device") 
            //     {
            //         Console.WriteLine("Model:");
            //         string model = Console.ReadLine();
            //         Console.WriteLine("Price:");
            //         int price = int.Parse(Console.ReadLine());
            //         Console.WriteLine("Type:");
            //         string type = Console.ReadLine();
            //         Console.WriteLine("Year of release: ");
            //         int year = int.Parse(Console.ReadLine());
            //         Books newb = new Books(model, price, type, year);
            //         inventory.AddToInventory(newb);
            //     }
            //     Console.WriteLine("Item added to inventory!");

            // }
            // else if (decision==4)
            // {
            //     string lf = Console.ReadLine();
            //     inventory.SearchByName(lf);

            // }
            // else if(decision==5)
            // {
            //     cart.Display();

            // }
        }
        

    }
}
