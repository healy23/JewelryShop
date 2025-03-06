using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using JewelryShop.Data;
using JewelryShop.Models;

namespace JewelryShop.Pages.Jewerly
{
    public class IndexModel : PageModel
    {
        private readonly JewelryShop.Data.JewerlyContext _context;

        public IndexModel(JewelryShop.Data.JewerlyContext context)
        {
            _context = context;
        }

        public IList<Jewelry> Jewelry { get;set; } = default!;

        public async Task OnGetAsync(string SearchString)
        {
            IQueryable<Jewelry> JewelrysIQ = from s in _context.Jewelrys select s;
            if (!String.IsNullOrEmpty(SearchString))
            {
                JewelrysIQ = JewelrysIQ.Where(s => s.Material.Contains(SearchString));
            }

            Jewelry = await JewelrysIQ.ToListAsync();
            //Student = await _context.Students.ToListAsync();
            //Jewelry = await _context.Jewelrys.ToListAsync();
        }
    }
}
