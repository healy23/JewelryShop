using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using JewelryShop.Data;
using JewelryShop.Models;

namespace JewelryShop.Pages.Reviews
{
    public class CreateModel : PageModel
    {
        private readonly JewelryShop.Data.JewerlyContext _context;

        public CreateModel(JewelryShop.Data.JewerlyContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CostumerID"] = new SelectList(_context.Costumers, "CostumerID", "CostumerID");
        ViewData["JewelryID"] = new SelectList(_context.Jewelrys, "JewelryID", "JewelryID");
            return Page();
        }

        [BindProperty]
        public Review Review { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Reviews.Add(Review);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
