﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASP_Razor_Contoso.Data;
using ASP_Razor_Contoso.Models;

namespace ASP_Razor_Contoso.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly ASP_Razor_Contoso.Data.ApplicationDbContext _context;

        public IndexModel(ASP_Razor_Contoso.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Students.ToListAsync();
        }
    }
}
