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

    [Authorize(Roles = "Administrator")]

    public class AdminController : Controller
    {

        private readonly IPersonService _personService;
        private readonly RoleManager<IdentityRole> roleManager;

        [ActivatorUtilitiesConstructor]
        public AdminController(FoundationContext context, IPersonService personService)
        {
            _personService = personService;
        }
        public IActionResult Index()
        {
            return View(_personService.FindAll());
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

        // POST: Book/Delete/5
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

        public IActionResult DetailsUser(int? id)
        {
            var person = _personService.FindBy(id);
            return person is null ? NotFound() : View(person);
        }

        public AdminController(RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
        }

        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRole_model model)
        {
            if (ModelState.IsValid)
            {
                // We just need to specify a unique role name to create a new role
                IdentityRole identityRole = new IdentityRole
                {
                    Name = model.RoleName
                };

                // Saves the role in the underlying AspNetRoles table
                IdentityResult result = await roleManager.CreateAsync(identityRole);

                if (result.Succeeded)
                {
                    return RedirectToAction("index", "admin");
                }

                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(model);

        }
    }
}


