using clinicafisioapp.Helpers.clinicafisioapp.Helpers;
using clinicafisioapp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace clinicafisioapp.Controllers
{
    [Authorize(Roles = "Patient")]
    public class PatientController : Controller
    {
        public IActionResult CompleteProfile()
        {
            ViewBag.States = StatesHelper.ListStates();
            return View();
        }

        [HttpPost]
        public IActionResult CompleteProfile(Patient model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Estados = StatesHelper.ListStates();
                return View(model);
            }

            return RedirectToAction("Index", "Home");
        }

    }
}
