using _01_HamburgerChef.Abstract;
using _01_HamburgerChef.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_HamburgerChef
{
    class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef();

            //Market Hazırla

            Market market = new Market(2);

            chef.BuyAndStock(2, market, IngredientTypes.Meatball, IngredientTypes.Cheddar, IngredientTypes.Bread, IngredientTypes.BarbequeSauce); //Alışveriş

            Console.WriteLine();

            Hamburger hamburger = chef.GetOrder(2, 2);  //Sipariş

            Bread breadForOrder = chef.GetBread();
            chef.SliceInHalf(breadForOrder);   //ekmek hazır

            Meatball meatball1ForOrder = chef.GetMeatball();
            Meatball meatball2ForOrder = chef.GetMeatball();

            chef.Cook(meatball1ForOrder, meatball2ForOrder);  //köfteleri pişir

            Cheddar cheddar = chef.GetCheddar();
            chef.SliceAndStock(cheddar, 2);    //rafa 2 dilim cheddar koyduk

            CheddarSlice cheddarSlice1ForOrder = chef.GetCheddarSlice();
            CheddarSlice cheddarSlice2ForOrder = chef.GetCheddarSlice();   //cheddar dilimlerini raftan al

            BarbequeSauce bbq = chef.GetBbqSauce();

            Hamburger hamburgerToServe = chef.PrepareBurger(hamburger, breadForOrder, meatball1ForOrder, meatball2ForOrder, cheddarSlice1ForOrder, cheddarSlice2ForOrder, bbq);     //Hamburger hazır

            Console.ReadLine();




        }
    }
}
