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
        public IEnumerable<IOrderItem> MenuItems { get; protected set; }
        [BindProperty]
        public string SearchTerms { get; set; } = "";
        [BindProperty]
        public string[] Categories { get; set; } = new string[0];
        [BindProperty]
        public int? CalMin { get; set; }
        [BindProperty]
        public int? CalMax { get; set; }
        [BindProperty]
        public double? PriceMin { get; set; }
        [BindProperty]
        public double? PriceMax { get; set; }
        public string Flavors => "Orange Soda Sarsparilla Birch Beer Root Beer";
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
