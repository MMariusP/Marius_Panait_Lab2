﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Marius_Panait_Lab2.Data;
using Marius_Panait_Lab2.Models;

namespace Marius_Panait_Lab2.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly Marius_Panait_Lab2.Data.Marius_Panait_Lab2Context _context;

        public IndexModel(Marius_Panait_Lab2.Data.Marius_Panait_Lab2Context context)
        {
            _context = context;
        }

        public IList<Author> Author { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Author != null)
            {
                Author = await _context.Author.ToListAsync();
            }
        }
    }
}
