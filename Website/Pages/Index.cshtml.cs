/* Author: Cari Miller
 * Index.cshtml.cs
 * Purpose: The website page
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CowboyCafe.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        /// <summary>
        /// The meny items
        /// </summary>
        public IEnumerable<IOrderItem> MenuItems { get; protected set; }
        /// <summary>
        /// The terms being searched for
        /// </summary>
        [BindProperty]
        public string SearchTerms { get; set; } = "";
        
        /// <summary>
        /// The categories that have been selected
        /// </summary>
        [BindProperty]
        public string[] Categories { get; set; } = new string[0];
        
        /// <summary>
        /// Minimum amount the calories  can be
        /// </summary>
        [BindProperty]
        public int? CalMin { get; set; }

        /// <summary>
        /// The maximum amount the calories can be
        /// </summary>
        [BindProperty]
        public int? CalMax { get; set; }

        /// <summary>
        /// The miminum amount the price can be
        /// </summary>
        [BindProperty]
        public double? PriceMin { get; set; }
        
        /// <summary>
        /// The maximum amount the price can be
        /// </summary>
        [BindProperty]
        public double? PriceMax { get; set; }

        /// <summary>
        /// The string of other flavors jerked soda can be
        /// </summary>
        public string Flavors => "Orange Soda Sarsparilla Birch Beer Root Beer";

        /// <summary>
        /// Handles all of the filtering
        /// </summary>
        /// <param name="CalMin">Minimum amount the calories can be</param>
        /// <param name="CalMax">The maximum amount the calories can be</param>
        /// <param name="PriceMin">The miminum amount the price can be</param>
        /// <param name="PriceMax">The maximum amount the price can be</param>
        public void OnGet(int? CalMin, int? CalMax, double? PriceMin, double? PriceMax)
        {
            this.CalMin = CalMin;
            this.CalMax = CalMax;
            this.PriceMin = PriceMin;
            this.PriceMax = PriceMax;

            SearchTerms = Request.Query["SearchTerms"];
            this.Categories = Request.Query["Categories"];

            MenuItems = Menu.CompleteMenu();
            if (SearchTerms != null) MenuItems = MenuItems.Where(item => item.ItemName != null && (item.ItemName.Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase) || (item is JerkedSoda && Flavors.Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase))));
            if (Categories != null && Categories.Length != 0) MenuItems = MenuItems.Where(item => (item is Drink && Categories.Contains("Drink")) || (item is Entree && Categories.Contains("Entree")) || (item is Side && Categories.Contains("Side")));
            if (CalMin != null || CalMax != null) MenuItems = MenuItems.Where(item => (CalMin == null && item.Calories <= CalMax) || (CalMax == null && item.Calories >= CalMin) || (item.Calories >= CalMin && item.Calories <= CalMax));
            if (PriceMin != null || PriceMax != null) MenuItems = MenuItems.Where(item => (PriceMin == null && item.Price <= PriceMax) || (PriceMax == null && item.Price >= PriceMin) || (item.Price >= PriceMin && item.Price <= PriceMax));
        }


    }
}
