using _01_HamburgerChef.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_HamburgerChef.Concrete
{
    class Market
    {
        /// <summary>
        /// Rafları boş bir market oluşturur
        /// </summary>
        public Market()
        {
            Products = new List<Ingredient>();
        }

        /// <summary>
        /// Market oluşurken içinde kaçar adet ürün istediğinizi parametre olarak girebilirsiniz
        /// </summary>
        /// <param name="qty"></param>
        public Market(int qty)
        {
            Products = new List<Ingredient>();
            FillMarket(qty);
        }

        public List<Ingredient> Products { get; set; }

        public void FillMarket(int quantity) //ingredient parametresi alarak , tipine göre de alım yapılabilir
        {
            for (int i = 0; i < quantity; i++)
            {
                BarbequeSauce barbequeSauce = new BarbequeSauce();
                barbequeSauce.BestBeforeDate = DateTime.Now.AddYears(1);
                Products.Add(barbequeSauce);

                //Son kullanma tarihi geçmiş ürün
                BarbequeSauce barbequeSauce1 = new BarbequeSauce();
                barbequeSauce1.BestBeforeDate = DateTime.Now.AddYears(-2);
                Products.Add(barbequeSauce1);

                Bread bread = new Bread();
                bread.BestBeforeDate = DateTime.Now.AddDays(2);
                Products.Add(bread);

                Cheddar cheddar = new Cheddar();
                cheddar.BestBeforeDate = DateTime.Now.AddMonths(1);
                Products.Add(cheddar);

                CheddarSlice cheddarSlice = new CheddarSlice();
                cheddarSlice.BestBeforeDate = DateTime.Now.AddMonths(1);
                Products.Add(cheddarSlice);

                Meatball meatball = new Meatball();
                meatball.BestBeforeDate = DateTime.Now.AddDays(7);
                Products.Add(meatball);
            }
        }
    }
}
