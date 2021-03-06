﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        public string SearchTerms { get; set; }

        public string[] ItemType { get; set; }

        public IEnumerable<IOrderItem> MenuItems { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(string SearchTerms, string[] ItemType, double? CaloriesMin, double? CaloriesMax, double? PriceMin, double? PriceMax)
        {
            MenuItems = Menu.Search(Menu.FullMenu(), SearchTerms, ItemType, CaloriesMin, CaloriesMax, PriceMin, PriceMax);
        }
    }
}
