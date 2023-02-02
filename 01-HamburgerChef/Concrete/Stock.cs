using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_HamburgerChef.Concrete
{
    class Stock
    {
        public Stock()
        {
            Meatballs = new Queue<Meatball>();
            Cheddars = new Queue<Cheddar>();
            CheddarSlices = new Queue<CheddarSlice>();
            BarbequeSauces = new Queue<BarbequeSauce>();
            Breads = new Queue<Bread>();
        }

        public Queue<Meatball> Meatballs { get; set; }
        public Queue<Cheddar> Cheddars { get; set; }
        public Queue<CheddarSlice> CheddarSlices { get; set; }
        public Queue<BarbequeSauce> BarbequeSauces { get; set; }
        public Queue<Bread> Breads { get; set; }
    }
}
