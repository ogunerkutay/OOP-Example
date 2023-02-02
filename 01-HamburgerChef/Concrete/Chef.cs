using _01_HamburgerChef.Abstract;
using _01_HamburgerChef.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_HamburgerChef.Concrete
{
    class Chef
    {
        Stock stock;
        public Chef()
        {
            stock = new Stock();
        }

        public void BuyAndStock(int quantity, Market market, params IngredientTypes[] ingredientsToBuy)
        {
            foreach (var item in ingredientsToBuy)
            {
                for (int i = 0; i < quantity; i++)
                {
                    bool marketteVarMi = false;
                    for (int j = market.Products.Count - 1; j >= 0; j--)
                    {
                        Ingredient product = market.Products[j];
                        if (product.GetType().Name == item.ToString())
                        {
                            marketteVarMi = true;
                            if (product.IsFresh)
                            {
                                switch (product.Description)
                                {
                                    case "BBQ Sauce":
                                        stock.BarbequeSauces.Enqueue((BarbequeSauce)product);
                                        break;
                                    case "Bread":
                                        stock.Breads.Enqueue((Bread)product);
                                        break;
                                    case "Cheddar":
                                        stock.Cheddars.Enqueue((Cheddar)product);
                                        break;
                                    case "CheddarSlice":
                                        stock.CheddarSlices.Enqueue((CheddarSlice)product);
                                        break;
                                    case "Meatball":
                                        stock.Meatballs.Enqueue((Meatball)product);
                                        break;
                                }
                                Console.WriteLine($"Taze {product.Description}'ı aldık. Fiyatı da iyiydi.");
                                market.Products.Remove(product);
                                break; //malzemeyi buldun döngüyü kır
                            }
                            else
                            {
                                Console.WriteLine($"Bayat {product.Description}. Söyleyelim çöpe atsınlar.");
                                market.Products.Remove(product);
                            }
                        }
                    }
                    if (!marketteVarMi)
                    {
                        Console.WriteLine($"{item} markette kalmamış");
                    }
                }
            }
        }

        public Meatball GetMeatball()
        {
            Meatball meatball;
            do
            {
                if (stock.Meatballs.Count > 0)
                {
                    meatball = stock.Meatballs.Dequeue();
                }
                else
                {
                    Console.WriteLine("Meatball kalmamış");
                    return null;
                }
            } while (meatball.IsFresh == false);
            return meatball;
        }

        public void Cook(params Meatball[] meatballs)
        {
            foreach (var meatball in meatballs)
            {
                if (meatball != null)
                {
                    meatball.IsCooked = true;
                    Console.WriteLine("Köfteyi pişirdik");
                }
                else
                {
                    Console.WriteLine("Pişireyim de köfte nerede?!");
                }
            }
        }

        public Cheddar GetCheddar()
        {
            Cheddar cheddar;
            do
            {
                if (stock.Cheddars.Count > 0)
                {
                    cheddar = stock.Cheddars.Dequeue();
                }
                else
                {
                    Console.WriteLine("Cheddar kalmamış");
                    return null;
                }
            } while (cheddar.IsFresh == false);
            return cheddar;
        }

        public void SliceAndStock(ISliceable sliceableItem, int sliceQuantity)
        {
            if (sliceableItem != null)
            {
                if (sliceableItem.SlicesToHave >= sliceQuantity)
                {
                    switch (((Ingredient)sliceableItem).Description)
                    {
                        case "Cheddar":
                            for (int i = 0; i < sliceQuantity; i++)
                            {
                                CheddarSlice cheddarSlice = new CheddarSlice();
                                cheddarSlice.BestBeforeDate = ((Ingredient)sliceableItem).BestBeforeDate;
                                stock.CheddarSlices.Enqueue(cheddarSlice);
                                sliceableItem.SlicesToHave--;
                            }
                            break;
                    }
                    Console.WriteLine("Ne güzel doğradım, elime sağlık");
                }
                else
                {
                    Console.WriteLine($"Bu parçadan {sliceableItem.SlicesToHave} adet parça çıkabilir");
                }
            }
            else
            {
                Console.WriteLine("Neyi keseyim?");
            }
        }

        public CheddarSlice GetCheddarSlice()
        {
            CheddarSlice cheddarSlice;
            do
            {
                if (stock.CheddarSlices.Count > 0)
                {
                    cheddarSlice = stock.CheddarSlices.Dequeue();
                }
                else
                {
                    Console.WriteLine("CheddarSlice kalmamış");
                    return null;
                }
            } while (cheddarSlice.IsFresh == false);
            return cheddarSlice;
        }

        public BarbequeSauce GetBbqSauce()
        {
            BarbequeSauce barbequeSauce;
            do
            {
                if (stock.BarbequeSauces.Count > 0)
                {
                    barbequeSauce = stock.BarbequeSauces.Dequeue();
                }
                else
                {
                    Console.WriteLine("BBQ sos kalmamış");
                    return null;
                }
            } while (barbequeSauce.IsFresh == false);
            return barbequeSauce;
        }

        public Bread GetBread()
        {
            Bread bread;
            do
            {
                if (stock.Breads.Count > 0)
                {
                    bread = stock.Breads.Dequeue();
                }
                else
                {
                    Console.WriteLine("Bread kalmamış");
                    return null;
                }
            } while (bread.IsFresh == false);
            return bread;
        }

        public void SliceInHalf(Bread bread)
        {
            if (bread != null)
            {
                bread.IsSlicedInHalf = true;
                Console.WriteLine("Ekmek bölündü");
            }
            else
            {
                Console.WriteLine("Neyi böleceğiz? ekmek yoksa pasta?!!");
            }
        }

        public Hamburger PrepareBurger(Hamburger hamburger, params Ingredient[] ingredients)
        {
            bool control = true;
            foreach (var item in ingredients)
            {
                if (item != null)
                {
                    switch (item.GetType().Name)
                    {
                        case "Bread":
                            if (((Bread)item).IsSlicedInHalf && hamburger.BreadReady == false)
                            {
                                hamburger.BreadReady = true;
                                Console.WriteLine("Hamburger ekmeği hazır");
                            }
                            else
                            {
                                Console.WriteLine("Ekmeği böl de getir! Zaten hazır da olabilir");
                            }
                            break;

                        case "Meatball":
                            if (((Meatball)item).IsCooked)
                            {
                                if (hamburger.MaxMeatballCount > hamburger.Meatballs.Count)
                                {
                                    hamburger.Meatballs.Add(((Meatball)item));
                                    Console.WriteLine($"Hamburgere {item.Description} eklendi");
                                }
                                else
                                {
                                    Console.WriteLine($"{hamburger.Meatballs.Count} adetten fazla {item.Description} istenmiyor");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Çiğ mi yesin müşteri?!");
                            }
                            break;

                        case "CheddarSlice":
                            if (hamburger.MaxCheddarSliceCount > hamburger.CheddarSlices.Count)
                            {
                                hamburger.CheddarSlices.Add((CheddarSlice)item);
                                Console.WriteLine($"Hamburgere {item.Description} eklendi");
                            }
                            else
                            {
                                Console.WriteLine($"{hamburger.CheddarSlices.Count} adetten fazla {item.Description} istenmiyor");
                            }
                            break;

                        case "BarbequeSauce":
                            if (hamburger.HasBarbequeSouce == false)
                            {
                                hamburger.HasBarbequeSouce = true;
                                Console.WriteLine($"Hamburgere {item.Description} eklendi");
                            }
                            else
                            {
                                Console.WriteLine($"{item.Description} zaten eklenmiş. Fazlası zarar");
                            }
                            break;
                    }
                }
                else
                {
                    control = false;
                }
            }

            if (!control)
            {
                Console.WriteLine("Malzeme tedariğinde problem var !");
            }
            if (!hamburger.BreadReady)
            {
                control = false;
                Console.WriteLine("Bence ekmeksiz gönderme !");
            }
            if (hamburger.MaxMeatballCount != hamburger.Meatballs.Count)
            {
                control = false;
                Console.WriteLine("Köfte sayısında eksik var !!");
            }
            if (hamburger.MaxCheddarSliceCount != hamburger.CheddarSlices.Count)
            {
                control = false;
                Console.WriteLine("Cheddar sayısında eksik var !!");
            }
            if (!hamburger.HasBarbequeSouce)
            {
                control = false;
                Console.WriteLine("Müşteri bbq istemiş miydi? Koymadın da !!!");
            }
            if (control)
            {
                Console.WriteLine("Hamburger servise hazır");
            }
            return hamburger;
        }

        public Hamburger GetOrder(int meatballCount, int cheddarSliceCount)
        {
            Hamburger hamburger = new Hamburger(meatballCount, cheddarSliceCount);
            return hamburger;
        }
    }
}
