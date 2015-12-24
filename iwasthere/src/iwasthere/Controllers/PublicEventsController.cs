using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using iwasthere.Models;

namespace iwasthere.Controllers
{
    public class PublicEventsController : Controller
    {
        private ApplicationDbContext _context;

        public PublicEventsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: PublicEvents
        public IActionResult Index()
        {
            return View(_context.PublicEvent.ToList());
        }

        // GET: PublicEvents/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            PublicEvent publicEvent = _context.PublicEvent.Single(m => m.ID == id);
            if (publicEvent == null)
            {
                return HttpNotFound();
            }

            return View(publicEvent);
        }

        // GET: PublicEvents/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PublicEvents/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PublicEvent publicEvent)
        {
            if (ModelState.IsValid)
            {
                _context.PublicEvent.Add(publicEvent);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(publicEvent);
        }

        // GET: PublicEvents/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            PublicEvent publicEvent = _context.PublicEvent.Single(m => m.ID == id);
            if (publicEvent == null)
            {
                return HttpNotFound();
            }
            return View(publicEvent);
        }

        // POST: PublicEvents/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(PublicEvent publicEvent)
        {
            if (ModelState.IsValid)
            {
                _context.Update(publicEvent);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(publicEvent);
        }

        // GET: PublicEvents/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            PublicEvent publicEvent = _context.PublicEvent.Single(m => m.ID == id);
            if (publicEvent == null)
            {
                return HttpNotFound();
            }

            return View(publicEvent);
        }

        // POST: PublicEvents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            PublicEvent publicEvent = _context.PublicEvent.Single(m => m.ID == id);
            _context.PublicEvent.Remove(publicEvent);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
