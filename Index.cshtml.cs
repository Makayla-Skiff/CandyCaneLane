using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CandyCaneLane1._1.Data;
using Microsoft.AspNetCore.Authorization;

namespace CandyCaneLane1._1.Pages.Order
{
    [Authorize(Roles="manger")]
    public class IndexModel : PageModel
    {
        private readonly CandyCaneLane1._1.Data.ApplicationDbContext _context;

        public IndexModel(CandyCaneLane1._1.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Orders> Orders { get;set; }

        public async Task OnGetAsync()
        {
            Orders = await _context.Orders.ToListAsync();
        }
    }
}
