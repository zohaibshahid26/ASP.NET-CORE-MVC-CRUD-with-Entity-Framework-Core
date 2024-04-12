using Microsoft.AspNetCore.Mvc;
using Lab3.Models;
using Lab3.Data;
using Microsoft.EntityFrameworkCore;
namespace Lab3.Controllers
{
    // Sibscription Controller
    public class SubscriptionController : Controller
    {
        private readonly ApplicationDbContext _context;  // Database context

        public SubscriptionController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Subscription
        [HttpGet]
        public async Task<IActionResult> Index() // Get all subscriptions
        {
            return View(await _context.Subscriptions.ToListAsync());
        }

        // GET: Subscription/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Subscription/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Subscription subscription)
        {
            if (ModelState.IsValid)
            {
                _context.Add(subscription);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(subscription);
        }


        // GET: Subscription/Update/id
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var subscription = await _context.Subscriptions.FindAsync(id);
            if (subscription == null)
            {
                return NotFound();
            }
            return View(subscription);
        }


        // POST: Subscription/Update/id
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Subscription subscription)
        {
            if (ModelState.IsValid)
            {
                _context.Update(subscription);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(subscription);
        }

        // GET: Subscription/Delete/id
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id)
        {

            var subscription = await _context.Subscriptions.FindAsync(id);
            if (subscription == null)
            {
                return NotFound();
            }
            _context.Subscriptions.Remove(subscription);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
    }
}
