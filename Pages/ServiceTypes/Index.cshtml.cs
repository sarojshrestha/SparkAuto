using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SparkAuto.Data;
using SparkAuto.Model;

namespace SparkAuto
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public IList<ServiceType> ServiceTypes{ get; set; }
        public async Task<IActionResult> OnGet()
        {
            ServiceTypes = await _db.ServiceType.ToListAsync();
            return Page();
        }
    }
}