using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using JewelryShop.Data;
using JewelryShop.Models;

namespace JewelryShop.Pages.Costumers
{
    public class IndexModel : PageModel
    {
        private readonly JewelryShop.Data.JewerlyContext _context;

        public IndexModel(JewelryShop.Data.JewerlyContext context)
        {
            _context = context;
        }

        public IList<Costumer> Costumer { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Costumer = await _context.Costumers.ToListAsync();
        }
    }
}
