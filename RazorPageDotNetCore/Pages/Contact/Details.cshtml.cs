using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPageDotNetCore.Data;
using RazorPageDotNetCore.Models;

namespace RazorPageDotNetCore
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPageDotNetCore.Data.DBContext _context;

        public DetailsModel(RazorPageDotNetCore.Data.DBContext context)
        {
            _context = context;
        }

        public Contact Contact { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Contact = await _context.Contact.FirstOrDefaultAsync(m => m.ID == id);

            if (Contact == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
