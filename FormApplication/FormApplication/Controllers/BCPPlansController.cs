using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FormApplication.Models;

namespace FormApplication.Controllers
{
    public class BCPPlansController : Controller
    {
        private readonly PlanContext _context;

        public BCPPlansController(PlanContext context)
        {
            _context = context;    
        }

        // GET: BCPPlans
        public async Task<IActionResult> Index()
        {
            return View(await _context.BCPPlan.ToListAsync());
        }

        // GET: BCPPlans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bCPPlan = await _context.BCPPlan
                .SingleOrDefaultAsync(m => m.Id == id);
            if (bCPPlan == null)
            {
                return NotFound();
            }

            return View(bCPPlan);
        }

        // GET: BCPPlans/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BCPPlans/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PlanName,Company,CustomerId,ThePlan")] BCPPlan bCPPlan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bCPPlan);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(bCPPlan);
        }

        // GET: BCPPlans/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bCPPlan = await _context.BCPPlan.SingleOrDefaultAsync(m => m.Id == id);
            if (bCPPlan == null)
            {
                return NotFound();
            }
            return View(bCPPlan);
        }

        // POST: BCPPlans/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PlanName,Company,CustomerId,ThePlan")] BCPPlan bCPPlan)
        {
            if (id != bCPPlan.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bCPPlan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BCPPlanExists(bCPPlan.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(bCPPlan);
        }

        // GET: BCPPlans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bCPPlan = await _context.BCPPlan
                .SingleOrDefaultAsync(m => m.Id == id);
            if (bCPPlan == null)
            {
                return NotFound();
            }

            return View(bCPPlan);
        }

        // POST: BCPPlans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bCPPlan = await _context.BCPPlan.SingleOrDefaultAsync(m => m.Id == id);
            _context.BCPPlan.Remove(bCPPlan);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool BCPPlanExists(int id)
        {
            return _context.BCPPlan.Any(e => e.Id == id);
        }
    }
}
