using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CrudEntityFramwork.Models;
using CrudEntityFramwork.Data;
using Microsoft.EntityFrameworkCore;

namespace CrudEntityFramwork.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Usuarios.ToListAsync()); ;
        }
        [HttpGet]

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Usuario u)
        {
            if (ModelState.IsValid)
            {
                this._context.Usuarios.Add(u);
                await this._context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View();


        }

        [HttpGet]

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var u = this._context.Usuarios.Find(id);
            if (u == null) return NotFound();

            return View(u);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Usuario u)
        {
            if (ModelState.IsValid)
            {
                this._context.Usuarios.Update(u);
                await this._context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(u);


        }

        [HttpGet]

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var u = this._context.Usuarios.Find(id);
            if (u == null) return NotFound();

            return View(u);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var u = this._context.Usuarios.Find(id);
            if (u == null) return NotFound();

            this._context.Usuarios.Remove(u);
            await this._context.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
