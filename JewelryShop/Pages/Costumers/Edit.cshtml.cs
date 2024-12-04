using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JewelryShop.Data;
using JewelryShop.Models;

namespace JewelryShop.Pages.Costumers
{
    public class EditModel : PageModel
    {
        private readonly JewelryShop.Data.JewerlyContext _context;

        public EditModel(JewelryShop.Data.JewerlyContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Costumer Costumer { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var costumer =  await _context.Costumers.FirstOrDefaultAsync(m => m.CostumerID == id);
            if (costumer == null)
            {
                return NotFound();
            }
            Costumer = costumer;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Costumer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CostumerExists(Costumer.CostumerID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CostumerExists(int id)
        {
            return _context.Costumers.Any(e => e.CostumerID == id);
        }
    }
}
