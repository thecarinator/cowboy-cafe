/* Author: Cari Miller
 * Class: Menu.cs
 * Purpose: Gets menu Items
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public static class Menu
    {
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
            List<IOrderItem> entrees = new List<IOrderItem>();
            entrees.Add(new BakedBeans());
            entrees.Add(new ChiliCheeseFries());
            entrees.Add(new CornDodgers());
            entrees.Add(new PanDeCampo());
            return entrees;
        }

        /// <summary>
        /// Gets Drink menu items
        /// </summary>
        /// <returns>returns drink menu items</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> entrees = new List<IOrderItem>();
            entrees.Add(new CowboyCoffee());
            entrees.Add(new JerkedSoda());
            entrees.Add(new TexasTea());
            entrees.Add(new Water());
            return entrees;
        }

        /// <summary>
        /// Gets all menu items
        /// </summary>
        /// <returns>returns all menu items</returns>
        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            List<IOrderItem> k = new List<IOrderItem>();
            foreach(IOrderItem i in Entrees())
            {
                k.Add(i);
            }
            foreach(IOrderItem i in Sides())
            {
                k.Add(i);
            }
            foreach(IOrderItem i in Drinks())
            {
                k.Add(i);
            }
            return k;
        }
    }
}
