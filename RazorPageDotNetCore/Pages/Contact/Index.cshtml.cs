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
    public class IndexModel : PageModel
    {
        private readonly RazorPageDotNetCore.Data.DBContext _context;

        public IndexModel(RazorPageDotNetCore.Data.DBContext context)
        {
            _context = context;
        }

        public IList<Contact> Contact { get;set; }

        public async Task OnGetAsync()
        {
            Contact = await _context.Contact.ToListAsync();
        }
    }
}
