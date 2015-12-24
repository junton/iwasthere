using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using iwasthere.Models;

namespace iwasthere.Controllers
{
    public class PlacesController : Controller
    {
        private ApplicationDbContext _context;

        public PlacesController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Places
        public IActionResult Index()
        {
            return View(_context.Place.ToList());
        }

        // GET: Places/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Place place = _context.Place.Single(m => m.ID == id);
            if (place == null)
            {
                return HttpNotFound();
            }

            return View(place);
        }

        // GET: Places/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Places/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Place place)
        {
            if (ModelState.IsValid)
            {
                _context.Place.Add(place);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(place);
        }

        // GET: Places/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Place place = _context.Place.Single(m => m.ID == id);
            if (place == null)
            {
                return HttpNotFound();
            }
            return View(place);
        }

        // POST: Places/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Place place)
        {
            if (ModelState.IsValid)
            {
                _context.Update(place);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(place);
        }

        // GET: Places/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Place place = _context.Place.Single(m => m.ID == id);
            if (place == null)
            {
                return HttpNotFound();
            }

            return View(place);
        }

        // POST: Places/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Place place = _context.Place.Single(m => m.ID == id);
            _context.Place.Remove(place);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
