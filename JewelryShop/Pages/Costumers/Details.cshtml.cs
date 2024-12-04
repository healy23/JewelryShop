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
    public class DetailsModel : PageModel
    {
        private readonly JewelryShop.Data.JewerlyContext _context;

        public DetailsModel(JewelryShop.Data.JewerlyContext context)
        {
            _context = context;
        }

        public Costumer Costumer { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var costumer = await _context.Costumers.FirstOrDefaultAsync(m => m.CostumerID == id);
            if (costumer == null)
            {
                return NotFound();
            }
            else
            {
                Costumer = costumer;
            }
            return Page();
        }
    }
}
