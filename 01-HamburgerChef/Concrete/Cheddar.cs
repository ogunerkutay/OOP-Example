using _01_HamburgerChef.Abstract;
using _01_HamburgerChef.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_HamburgerChef.Concrete
{
    class Cheddar:Ingredient,ISliceable
    {
        public override string Description { get { return "Cheddar"; } }
        public int SlicesToHave { get; set; } = 20;
    }
}
