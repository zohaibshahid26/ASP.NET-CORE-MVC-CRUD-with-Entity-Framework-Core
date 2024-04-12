using Microsoft.AspNetCore.Mvc;
using Lab3.Models;
using Lab3.Data;
using Microsoft.EntityFrameworkCore;
namespace Lab3.Controllers
{
    // User Controller
    public class UserController : Controller
    {

        private readonly ApplicationDbContext _context; // Database context

        // Constructor
        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: User
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Users.ToListAsync());
        }


        // GET: User/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            if (ModelState.IsValid)
            {
                await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: User/Update/id
        [HttpGet]
        public IActionResult Update(int id)
        {
            var user = _context.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }


        // POST: User/Update/id
        [HttpPost]
        public async Task<IActionResult> Update(User user)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Update(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }


        // GET: User/Delete/id
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var userToDelete = await _context.Users.FindAsync(id);  // Use FindAsync to directly retrieve and track the user

            if (userToDelete == null)
            {
                return NotFound();
            }

            _context.Users.Remove(userToDelete);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));  // Assuming 'Index' is your method to list users
        }


    }
}
