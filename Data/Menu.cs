/* Author: Cari Miller
 * Class: Menu.cs
 * Purpose: Gets and filters menu Items
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Static class of menu items
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// An array of the other soda flavors
        /// </summary>
        public static string[] OtherFlavors
        {
            get => new string[]
            {
                "Orange Soda",
                "Sarsparilla",
                "Birch Beer",
                "Root Beer"
            };
        }

        /// <summary>
        /// An array of the category names
        /// </summary>
        public static string[] Category
        {
            get => new string[]
            {
                "Entrees",
                "Sides",
                "Drinks"
            };
        }

        /// <summary>
        /// Finds the menu items with the search term in its name, or if it's a jerked 
        /// soda, then it checks if the other soda flavors contains the search term
        /// </summary>
        /// <param name="items">Menu items being filtered through</param>
        /// <param name="terms">The term being searched</param>
        /// <returns>Returns the update menu item list</returns>
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> items, string terms)
        {
            if (terms == null) return items;
            List<IOrderItem> r = new List<IOrderItem>(); 
            foreach(IOrderItem i in items)
            {
                int c = 0;
                if (i is JerkedSoda)
                {
                    foreach(string s in OtherFlavors)
                    {
                        if (s.Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                        {
                            c++;
                            r.Add(i);
                            break;
                        }
                    }
                }
                if (c == 0 && i.ItemName.Contains(terms, StringComparison.InvariantCultureIgnoreCase)) r.Add(i);
            }
            return r;
        }

        /// <summary>
        /// Finds the items that match the one of the categories in the category list
        /// </summary>
        /// <param name="items">Menu items being filtered through</param>
        /// <param name="category">List of categories</param>
        /// <returns>Returns the updated menu item list</returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> items, IEnumerable<string> category)
        {
            if (category == null || category.Count() == 0) return items;
            var r = new List<IOrderItem>();
            bool ent = category.Contains("Entrees");
            bool side = category.Contains("Sides");
            bool dri = category.Contains("Drinks");
            foreach(IOrderItem i in items)
            {
                if (i is Entree && ent) r.Add(i);
                if (i is Side && side) r.Add(i);
                if (i is Drink && dri) r.Add(i);
            }
            return r;
        }

        /// <summary>
        /// Gets the menu items that have calories that are greater than or equal to min and 
        /// less than or equal to max 
        /// </summary>
        /// <param name="items">Menu items being filtered through</param>
        /// <param name="min">The smallest amount of calories that a menu item can have</param>
        /// <param name="max">The largest amount of calories that a menu item can have</param>
        /// <returns>Returns the updated menu item</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, int? min, int? max)
        {
            if (min == null && max == null) return items;
            var r = new List<IOrderItem>();
            if (min == null)
            {
                foreach(IOrderItem i in items) if (i.Calories <= max) r.Add(i);
                return r;
            }
            if (max == null)
            {
                foreach (IOrderItem i in items) if (i.Calories >= min) r.Add(i); 
                return r;
            }
            foreach(IOrderItem i in items) if (i.Calories >= min && i.Calories <= max) r.Add(i);
            return r;
        }

        /// <summary>
        /// Gets the menu items that have a price that is greater than or equal to min and 
        /// less than or equal to max 
        /// </summary>
        /// <param name="items">Menu items being filtered through</param>
        /// <param name="min">The lowest amount a menu item's price can be</param>
        /// <param name="max">The biggest amount a menu item's price can be</param>
        /// <returns>The updated menu items</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {

            if (min == null && max == null) return items;
            var r = new List<IOrderItem>();
            if (min == null)
            {
                foreach (IOrderItem i in items) if (i.Price <= max) r.Add(i);
                return r;
            }
            if (max == null)
            {
                foreach (IOrderItem i in items) if (i.Price >= min) r.Add(i);
                return r;
            }
            foreach (IOrderItem i in items) if (i.Price >= min && i.Price <= max) r.Add(i);
            return r;
        }
        /// <summary>
        /// Gets Entree menu items
        /// </summary>
        /// <returns> returns entree menu items</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entrees = new List<IOrderItem>();
            entrees.Add(new AngryChicken());
            entrees.Add(new CowpokeChili());
            entrees.Add(new DakotaDoubleBurger());
            entrees.Add(new PecosPulledPork());
            entrees.Add(new RustlersRibs());
            entrees.Add(new TexasTripleBurger());
            entrees.Add(new TrailBurger());
            return entrees;
        }



        /// <summary>
        /// Gets Side menu items
        /// </summary>
        /// <returns> returns side menu items</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();
            sides.Add(new BakedBeans(Size.Small));
            sides.Add(new BakedBeans(Size.Medium));
            sides.Add(new BakedBeans(Size.Large));
            sides.Add(new ChiliCheeseFries(Size.Small));
            sides.Add(new ChiliCheeseFries(Size.Medium));
            sides.Add(new ChiliCheeseFries(Size.Large));
            sides.Add(new CornDodgers(Size.Small));
            sides.Add(new CornDodgers(Size.Medium));
            sides.Add(new CornDodgers(Size.Large));
            sides.Add(new PanDeCampo(Size.Small));
            sides.Add(new PanDeCampo(Size.Medium));
            sides.Add(new PanDeCampo(Size.Large));
            return sides;
        }

        /// <summary>
        /// Gets Drink menu items
        /// </summary>
        /// <returns>returns drink menu items</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> entrees = new List<IOrderItem>();
            entrees.Add(new CowboyCoffee(Size.Small, true));
            entrees.Add(new CowboyCoffee(Size.Small, false));
            entrees.Add(new CowboyCoffee(Size.Medium, true));
            entrees.Add(new CowboyCoffee(Size.Medium, false));
            entrees.Add(new CowboyCoffee(Size.Large, true));
            entrees.Add(new CowboyCoffee(Size.Large, false));
            entrees.Add(new JerkedSoda(Size.Small));
            entrees.Add(new JerkedSoda(Size.Medium));
            entrees.Add(new JerkedSoda(Size.Large));
            entrees.Add(new TexasTea(Size.Small, true));
            entrees.Add(new TexasTea(Size.Medium, true));
            entrees.Add(new TexasTea(Size.Large, true));
            entrees.Add(new TexasTea(Size.Small, false));
            entrees.Add(new TexasTea(Size.Medium, false));
            entrees.Add(new TexasTea(Size.Large, false));
            entrees.Add(new Water(Size.Small));
            entrees.Add(new Water(Size.Medium));
            entrees.Add(new Water(Size.Large));
            return entrees;
        }

        /// <summary>
        /// Gets all menu items
        /// </summary>
        /// <returns>returns all menu items</returns>
        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            List<IOrderItem> k = new List<IOrderItem>();
            k.AddRange(Entrees());
            k.AddRange(Sides());
            k.AddRange(Drinks());
            return k;

        }
    }
}
