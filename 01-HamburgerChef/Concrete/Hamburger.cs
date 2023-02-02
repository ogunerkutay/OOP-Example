using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_HamburgerChef.Concrete
{
    class Hamburger
    {
        public Hamburger(int maxMeatballCount, int maxCheddarSliceCount)
        {
            Meatballs = new List<Meatball>();
            CheddarSlices = new List<CheddarSlice>();
            MaxCheddarSliceCount = maxCheddarSliceCount;
            MaxMeatballCount = maxMeatballCount;
        }

        public bool BreadReady { get; set; } = false;
        public List<Meatball> Meatballs { get; set; }
        public int MaxMeatballCount { get; set; }
        public List<CheddarSlice> CheddarSlices { get; set; }
        public int MaxCheddarSliceCount { get; set; }
        public bool HasBarbequeSouce { get; set; } = false;
    }
}
