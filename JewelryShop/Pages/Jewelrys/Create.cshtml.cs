using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using JewelryShop.Data;
using JewelryShop.Models;

namespace JewelryShop.Pages.Jewerly
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
            return Page();
        }

        [BindProperty]
        public Jewelry Jewelry { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Jewelrys.Add(Jewelry);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
