using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Website.Enums;
using Website.Drinks;
using Website.Entrees;
using Website.Sides;

namespace Website
{
    public class Menu
    {
        public static string[] Types
        {
            get => new string[]
            {
                "Entree",
                "Side",
                "Drink"
            };
        }

        /// <summary>
        /// Gathers each entree and returns them in a list
        /// </summary>
        /// <returns> a list of every entree </returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entrees = new List<IOrderItem>();
            BriarheartBurger br = new BriarheartBurger();
            entrees.Add(br);
            DoubleDraugr dd = new DoubleDraugr();
            entrees.Add(dd);
            GardenOrcOmelette goo = new GardenOrcOmelette();
            entrees.Add(goo);
            PhillyPoacher pp = new PhillyPoacher();
            entrees.Add(pp);
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            entrees.Add(ss);
            ThalmorTriple tt = new ThalmorTriple();
            entrees.Add(tt);
            ThugsTBone tbone = new ThugsTBone();
            entrees.Add(tbone);
            return entrees;
        }

        /// <summary>
        /// Gathers each side and returns them in a list
        /// </summary>
        /// <returns> a list of every side </returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();

            DragonbornWaffleFries dwf1 = new DragonbornWaffleFries();
            dwf1.Size = Enums.Size.Large;
            DragonbornWaffleFries dwf2 = new DragonbornWaffleFries();
            dwf2.Size = Enums.Size.Medium;
            DragonbornWaffleFries dwf3 = new DragonbornWaffleFries();
            dwf3.Size = Enums.Size.Small;

            sides.Add(dwf1);
            sides.Add(dwf2);
            sides.Add(dwf3);

            FriedMiraak fm1 = new FriedMiraak();
            fm1.Size = Enums.Size.Large;
            FriedMiraak fm2 = new FriedMiraak();
            fm2.Size = Enums.Size.Medium;
            FriedMiraak fm3 = new FriedMiraak();
            fm3.Size = Enums.Size.Small;

            sides.Add(fm1);
            sides.Add(fm2);
            sides.Add(fm3);

            MadOtarGrits mog1 = new MadOtarGrits();
            mog1.Size = Enums.Size.Large;
            MadOtarGrits mog2 = new MadOtarGrits();
            mog2.Size = Enums.Size.Medium;
            MadOtarGrits mog3 = new MadOtarGrits();
            mog3.Size = Enums.Size.Small;

            sides.Add(mog1);
            sides.Add(mog2);
            sides.Add(mog3);

            VokunSalad vs1 = new VokunSalad();
            vs1.Size = Enums.Size.Large;
            VokunSalad vs2 = new VokunSalad();
            vs2.Size = Enums.Size.Medium;
            VokunSalad vs3 = new VokunSalad();
            vs3.Size = Enums.Size.Small;

            sides.Add(vs1);
            sides.Add(vs2);
            sides.Add(vs3);

            return sides;
        }

        /// <summary>
        /// Gathers each drink and returns them in a list
        /// </summary>
        /// <returns> a list of every drink </returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();

            AretinoAppleJuice aj1 = new AretinoAppleJuice();
            aj1.Size = Enums.Size.Large;
            AretinoAppleJuice aj2 = new AretinoAppleJuice();
            aj2.Size = Enums.Size.Medium;
            AretinoAppleJuice aj3 = new AretinoAppleJuice();
            aj3.Size = Enums.Size.Small;

            drinks.Add(aj1);
            drinks.Add(aj2);
            drinks.Add(aj3);

            CandlehearthCoffee cc1 = new CandlehearthCoffee();
            cc1.Size = Enums.Size.Large;
            CandlehearthCoffee cc2 = new CandlehearthCoffee();
            cc2.Size = Enums.Size.Medium;
            CandlehearthCoffee cc3 = new CandlehearthCoffee();
            cc3.Size = Enums.Size.Small;

            drinks.Add(cc1);
            drinks.Add(cc2);
            drinks.Add(cc3);

            MarkarthMilk mm1 = new MarkarthMilk();
            mm1.Size = Enums.Size.Large;
            MarkarthMilk mm2 = new MarkarthMilk();
            mm2.Size = Enums.Size.Medium;
            MarkarthMilk mm3 = new MarkarthMilk();
            mm3.Size = Enums.Size.Small;

            drinks.Add(mm1);
            drinks.Add(mm2);
            drinks.Add(mm3);

            WarriorWater ww1 = new WarriorWater();
            ww1.Size = Enums.Size.Large;
            WarriorWater ww2 = new WarriorWater();
            ww2.Size = Enums.Size.Medium;
            WarriorWater ww3 = new WarriorWater();
            ww3.Size = Enums.Size.Small;

            drinks.Add(ww1);
            drinks.Add(ww2);
            drinks.Add(ww3);

            SailorSoda ss1_1 = new SailorSoda();
            ss1_1.Flavor = Enums.SodaFlavor.Blackberry;
            ss1_1.Size = Enums.Size.Large;
            SailorSoda ss1_2 = new SailorSoda();
            ss1_2.Flavor = Enums.SodaFlavor.Blackberry;
            ss1_2.Size = Enums.Size.Medium;
            SailorSoda ss1_3 = new SailorSoda();
            ss1_3.Flavor = Enums.SodaFlavor.Blackberry;
            ss1_3.Size = Enums.Size.Small;

            drinks.Add(ss1_1);
            drinks.Add(ss1_2);
            drinks.Add(ss1_3);

            SailorSoda ss2_1 = new SailorSoda();
            ss2_1.Flavor = Enums.SodaFlavor.Cherry;
            ss2_1.Size = Enums.Size.Large;
            SailorSoda ss2_2 = new SailorSoda();
            ss2_2.Flavor = Enums.SodaFlavor.Cherry;
            ss2_2.Size = Enums.Size.Medium;
            SailorSoda ss2_3 = new SailorSoda();
            ss2_3.Flavor = Enums.SodaFlavor.Cherry;
            ss2_3.Size = Enums.Size.Small;

            drinks.Add(ss2_1);
            drinks.Add(ss2_2);
            drinks.Add(ss2_3);

            SailorSoda ss3_1 = new SailorSoda();
            ss3_1.Flavor = Enums.SodaFlavor.Grapefruit;
            ss3_1.Size = Enums.Size.Large;
            SailorSoda ss3_2 = new SailorSoda();
            ss3_2.Flavor = Enums.SodaFlavor.Grapefruit;
            ss3_2.Size = Enums.Size.Medium;
            SailorSoda ss3_3 = new SailorSoda();
            ss3_3.Flavor = Enums.SodaFlavor.Grapefruit;
            ss3_3.Size = Enums.Size.Small;

            drinks.Add(ss3_1);
            drinks.Add(ss3_2);
            drinks.Add(ss3_3);

            SailorSoda ss4_1 = new SailorSoda();
            ss4_1.Flavor = Enums.SodaFlavor.Lemon;
            ss4_1.Size = Enums.Size.Large;
            SailorSoda ss4_2 = new SailorSoda();
            ss4_2.Flavor = Enums.SodaFlavor.Lemon;
            ss4_2.Size = Enums.Size.Medium;
            SailorSoda ss4_3 = new SailorSoda();
            ss4_3.Flavor = Enums.SodaFlavor.Lemon;
            ss4_3.Size = Enums.Size.Small;

            drinks.Add(ss4_1);
            drinks.Add(ss4_2);
            drinks.Add(ss4_3);

            SailorSoda ss5_1 = new SailorSoda();
            ss5_1.Flavor = Enums.SodaFlavor.Peach;
            ss5_1.Size = Enums.Size.Large;
            SailorSoda ss5_2 = new SailorSoda();
            ss5_2.Flavor = Enums.SodaFlavor.Peach;
            ss5_2.Size = Enums.Size.Medium;
            SailorSoda ss5_3 = new SailorSoda();
            ss5_3.Flavor = Enums.SodaFlavor.Peach;
            ss5_3.Size = Enums.Size.Small;

            drinks.Add(ss5_1);
            drinks.Add(ss5_2);
            drinks.Add(ss5_3);

            SailorSoda ss6_1 = new SailorSoda();
            ss6_1.Flavor = Enums.SodaFlavor.Watermelon;
            ss6_1.Size = Enums.Size.Large;
            SailorSoda ss6_2 = new SailorSoda();
            ss6_2.Flavor = Enums.SodaFlavor.Watermelon;
            ss6_2.Size = Enums.Size.Medium;
            SailorSoda ss6_3 = new SailorSoda();
            ss6_3.Flavor = Enums.SodaFlavor.Watermelon;
            ss6_3.Size = Enums.Size.Small;

            drinks.Add(ss6_1);
            drinks.Add(ss6_2);
            drinks.Add(ss6_3);

            return drinks;
        }

        /// <summary>
        /// Gathers each item and returns them in a list
        /// </summary>
        /// <returns> a list of every item </returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> menu = new List<IOrderItem>();

            IEnumerable<IOrderItem> drinks = Drinks();
            IEnumerable<IOrderItem> entrees = Entrees();
            IEnumerable<IOrderItem> sides = Sides();

            foreach (IOrderItem item in drinks)
            {
                menu.Add(item);
            }

            foreach (IOrderItem item in entrees)
            {
                menu.Add(item);
            }

            foreach (IOrderItem item in sides)
            {
                menu.Add(item);
            }

            return menu;
        }

        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> menu, string terms, string[] type, double? CaloriesMin, double? CaloriesMax, double? PriceMin, double? PriceMax)
        {
            IEnumerable<IOrderItem> results = menu;

            // null check
            if (terms != null)
            {
                results = menu.Where(item => item.ToString().Contains(terms, StringComparison.InvariantCultureIgnoreCase));
                results = results.Where(item => item.Description.Contains(terms, StringComparison.InvariantCultureIgnoreCase));
            }

            if(type != null && type.Length != 0)
            {
                results = results.Where(item => type.Contains(item.Type));
            }

            if (CaloriesMin != null || CaloriesMax != null)
            {
                if (CaloriesMin == null)
                {
                    results = results.Where(item => item.Calories <= CaloriesMax);
                }

                else if (CaloriesMax == null)
                {
                    results = results.Where(item => item.Calories >= CaloriesMin);
                }

                else
                {
                    results = results.Where(item => item.Calories >= CaloriesMin && item.Calories <= CaloriesMax);
                }
            }

            if (PriceMin != null || PriceMax != null)
            {
                if (PriceMin == null)
                {
                    results = results.Where(item => item.Price <= PriceMax);
                }

                else if (PriceMax == null)
                {
                    results = results.Where(item => item.Price >= PriceMin);
                }

                else
                {
                    results = results.Where(item => item.Price >= PriceMin && item.Price <= PriceMax);
                }
            }

            return results;
        }

        public static IEnumerable<IOrderItem> FilterByOrderType(IEnumerable<IOrderItem> menu, IEnumerable<string> types)
        {
            if (types == null || types.Count() == 0) return menu;

            List<IOrderItem> results = new List<IOrderItem>();

            foreach (IOrderItem item in menu)
            {
                if (item.Type != null && types.Contains(item.Type))
                {
                    results.Add(item);
                }
            }

            return results;
        }

        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> menu, double? min, double? max)
        {
            if (min == null && max == null) return menu;

            var results = new List<IOrderItem>();

            if (min == null)
            {
                foreach (IOrderItem item in menu)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }

            if (max == null)
            {
                foreach (IOrderItem item in menu)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }

            foreach (IOrderItem item in menu)
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> menu, double? min, double? max)
        {
            if (min == null && max == null) return menu;

            var results = new List<IOrderItem>();

            if (min == null)
            {
                foreach (IOrderItem item in menu)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }

            if (max == null)
            {
                foreach (IOrderItem item in menu)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }

            foreach (IOrderItem item in menu)
            {
                if (item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }
    }
}

