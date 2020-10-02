using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrialReminder.Models;

namespace TrialReminder.Controllers
{
    public class TrialsController : Controller
    {
        private readonly TrialsDataContext _context;

        public TrialsController(TrialsDataContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var results = await _context.Trials.ToListAsync();
            return View(results);
        }
    }
}
