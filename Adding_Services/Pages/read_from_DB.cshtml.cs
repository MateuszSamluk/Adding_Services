using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Adding_Services.Data;
using Adding_Services.Models;

namespace Adding_Services.Pages
{
    public class read_from_DBModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        readonly ProductContex _context;

        public read_from_DBModel(ILogger<IndexModel> logger, ProductContex context)
        {
            _logger = logger;
            _context = context;
        }

        public IList<Product_DB> Products { get; set; }
        public void OnGet()
        {
            Products = _context.Product_DB.ToList();
        }
    }
}
