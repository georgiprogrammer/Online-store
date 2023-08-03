using System;
using System.Collections.Generic;
using System.Text;

namespace Online_Shop_Inventory
{
    class Electronics : Product
    {
        
        private int yearofrelease;
        public int YearOfRelease
        {
            get { return yearofrelease; }
            set { this.yearofrelease = value; }
        }
        
        public Electronics(string name, double price, int yearofrelease) : base(name, price)
        {
            
            this.YearOfRelease = yearofrelease;
        }
    }
}
