using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using Foundation.Areas.Identity.Data;
using Foundation.Models;
using System;
using System.Dynamic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace Foundation.Controllers
{

    [Authorize(Roles = "Authorized,Administrator")]

    public class AuthorizedController : Controller
    {

        private readonly IPersonService _personService;
        private readonly RoleManager<IdentityRole> roleManager;

        [ActivatorUtilitiesConstructor]
        public AuthorizedController(FoundationContext context, IPersonService personService)
        {
            _personService = personService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DeleteUser(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = _personService.FindBy(id);
            return person is null ? NotFound() : View(person);
        }

        [HttpPost, ActionName("DeleteUser")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            if (_personService.Delete(id))
            {
                return RedirectToAction(nameof(Index));
            }
            return Problem("Trying delete no existing person");
        }

        public IActionResult FindMatch()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Find(int form_value)
        {
            var person = _personService.FindAllByInterest(form_value);
            return person is null ? NotFound() : View(person);

        }

        public IActionResult DetailsUser(int? id)
        {
            var person = _personService.FindBy(id);
            return person is null ? NotFound() : View(person);
        }


    }
}


