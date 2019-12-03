using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ReLearning1.Model;

namespace ReLearning1.Pages.ListGadget
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _db;

        public IndexModel(AppDbContext db)
        {
            _db = db;
        }

        public  IEnumerable<Gadget> Gadgets { get; set; }



        public async Task OnGet()
        {
            Gadgets = await _db.Gadget.ToListAsync();    
        }


    }
}