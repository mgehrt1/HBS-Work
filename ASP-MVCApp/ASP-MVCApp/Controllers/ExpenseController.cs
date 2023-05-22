using ASP_MVCApp.Data;
using ASP_MVCApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace ASP_MVCApp.Controllers {
    public class ExpenseController : Controller {

        private readonly ApplicationDbContext _db;

        public ExpenseController(ApplicationDbContext db) {
            _db = db;
        }

        public IActionResult Index() {
            IEnumerable<Expense> objList = _db.Expenses;
            return View(objList);
        }

        // GET-Spend
        public IActionResult Spend() {
            return View();
        }

        // POST-Spend
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Spend(Expense obj) {
            if (ModelState.IsValid) {
                _db.Expenses.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET-Delete
        public IActionResult Delete(int? id) {
            if (id == null || id == 0) {
                return NotFound();
            }
            var obj = _db.Expenses.Find(id);
            if (obj == null) {
                return NotFound();
            }

            return View(obj);
        }

        //POST-Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id) {
            var obj = _db.Expenses.Find(id);
            if (obj == null) {
                return NotFound();
            }

            _db.Expenses.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //GET-Update
        public IActionResult Update(int? id) {
            if (id == null || id == 0) {
                return NotFound();
            }
            var obj = _db.Expenses.Find(id);
            if (obj == null) {
                return NotFound();
            }

            return View(obj);
        }

        // POST-Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Expense obj) {
            if (ModelState.IsValid) {
                _db.Expenses.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }


    }
}
