using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Security.Claims;
using clinicafisioapp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Identity;
using clinicafisioapp.Models;
using Microsoft.AspNetCore.CookiePolicy;

namespace clinicafisioapp.Filters
{
    public class RequiredPatientProfileAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var httpContext = context.HttpContext;
            var userId = httpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (string.IsNullOrEmpty(userId))
                return;

            var dbContext = httpContext.RequestServices.GetService<ApplicationDbContext>();
            var userManager = httpContext.RequestServices.GetService<UserManager<ApplicationUser>>();

            var user = dbContext.Users
                .Include(x => x.Patient)
                .FirstOrDefault(x => x.Id == userId);

            if (user == null)
                return;

            var isPatient = userManager.IsInRoleAsync(user, "Patient").Result;

            if (isPatient && user.Patient == null)
            {
                context.Result = new RedirectToActionResult("CompleteProfile", "Patient", null);
            }
        }
    }
}




