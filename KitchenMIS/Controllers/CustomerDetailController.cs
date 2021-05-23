using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KitchenMIS.Data;
using KitchenMIS.Models;

namespace KitchenMIS.Views
{
    public class CustomerDetailController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomerDetailController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CustomerDetail
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CustomerDetail.Include(c => c.Customer).Include(c => c.Dish);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CustomerDetail/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerDetail = await _context.CustomerDetail
                .Include(c => c.Customer)
                .Include(c => c.Dish)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customerDetail == null)
            {
                return NotFound();
            }

            return View(customerDetail);

        }

        // GET: CustomerDetail/Create
        public IActionResult Create()
        {
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "FullName");
            ViewData["DishId"] = new SelectList(_context.Dishes, "Id", "Description");
            return View();
        }

        // POST: CustomerDetail/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nationality,BirthDate,Faith,Spice,Protein,Sex,Status,DishId,CustomerId")] CustomerDetail customerDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customerDetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "FullName", customerDetail.CustomerId);
            ViewData["DishId"] = new SelectList(_context.Dishes, "Id", "Description", customerDetail.DishId);
            return View(customerDetail);
        }

        // GET: CustomerDetail/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerDetail = await _context.CustomerDetail.FindAsync(id);
            if (customerDetail == null)
            {
                return NotFound();
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "FullName", customerDetail.CustomerId);
            ViewData["DishId"] = new SelectList(_context.Dishes, "Id", "Description", customerDetail.DishId);
            return View(customerDetail);
        }

        // POST: CustomerDetail/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nationality,BirthDate,Faith,Spice,Protein,Sex,Status,DishId,CustomerId")] CustomerDetail customerDetail)
        {
            if (id != customerDetail.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customerDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerDetailExists(customerDetail.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                // return RedirectToAction(nameof(Index));
                ViewBag.Message = "Test";
                return RedirectToAction("Details", "Customer", new {id =  customerDetail.CustomerId });
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "FullName", customerDetail.CustomerId);
            ViewData["DishId"] = new SelectList(_context.Dishes, "Id", "Description", customerDetail.DishId);
            return View(customerDetail);
           //return RedirectToAction("Index", "Customer");
        }

        // GET: CustomerDetail/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerDetail = await _context.CustomerDetail
                .Include(c => c.Customer)
                .Include(c => c.Dish)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customerDetail == null)
            {
                return NotFound();
            }

            return View(customerDetail);
        }

        // POST: CustomerDetail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customerDetail = await _context.CustomerDetail.FindAsync(id);
            _context.CustomerDetail.Remove(customerDetail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerDetailExists(int id)
        {
            return _context.CustomerDetail.Any(e => e.Id == id);
        }


        
    }
}
