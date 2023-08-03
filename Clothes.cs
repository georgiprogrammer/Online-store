using System;
using System.Collections.Generic;
using System.Text;

namespace Online_Shop_Inventory
{
    class Clothes : Product
    {
        
        private string material;
        private string size;
        private string color;
       


        public string Material
        {
            get { return material; }
            set { this.material = value; }
        } 
        public string Size
        {
            get { return size; }
            set { this.size = value; }
        }
        public string Color
        {
            get { return color; }
            set { this.color = value; }
        }
        public Clothes( string name,double price, string material, string color, string size) : base(name, price)
        {
            
            this.Material = material;
            this.Size = size;
            this.Color = color;
        }

    }
}
