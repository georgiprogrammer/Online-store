using System;
using System.Collections.Generic;
using System.Text;

namespace Online_Shop_Inventory
{
    public class Books : Product
    {
        private string genre;
        private int pages;
        public Books(string name, double price, string genre, int pages):base(name,price)
        {
            this.Genre = genre;
            this.Pages = pages;
        }
        public string Genre
        {
            get { return genre; }
            set { this.genre = value; }
        }
        public int Pages
        {
            get { return pages; }
            set { this.pages = value; }
        }
    }
}
