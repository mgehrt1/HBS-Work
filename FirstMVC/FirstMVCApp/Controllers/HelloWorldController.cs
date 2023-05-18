using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace FirstMVCApp.Controllers {
    public class HelloWorldController : Controller {

        private static List<DogViewModel> dogs = new();

        public IActionResult Index() {
            return View(dogs);
        }

        public IActionResult Create() {
            var dogVM = new DogViewModel();
            return View(dogVM);
        }

        public IActionResult CreateDog(DogViewModel dogViewModel) {
            // return View("Index");
            dogs.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Hello() {
            DogViewModel dog = new() { Name = "Pup", Age = 8 };
            return View(dog);
        }

    }
}
