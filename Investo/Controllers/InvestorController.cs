using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Claims;
using System.Threading.Tasks;
using Investo.Interface.Services;
using Investo.Models.Entities;
using Investo.Models.ViewModel;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Hosting.Internal;

namespace Investo.Controllers
{
    public class InvestorController : Controller
    {
        private readonly IInvestorService _investorService;

        private readonly IWebHostEnvironment hostEnvironment;





        public InvestorController(IInvestorService investorService, IWebHostEnvironment hostEnvironment)
        {

            _investorService = investorService;
            this.hostEnvironment = hostEnvironment;
        }





        [HttpGet]
        public IActionResult Index()
        {
            return View(_investorService.GetAll());
        }


        public IActionResult Create()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Create(Investor investor)
        {
            if (ModelState.IsValid)
            {
                _investorService.AddInvestor(investor);

                return RedirectToAction(nameof(Index));
            }
            return View(investor);
        }


        //[HttpGet]
        //public IActionResult Register()
        //{
        //    return View();
        //}


        //[HttpPost]
        //public async Task<IActionResult> Register(RegisterViewModel model)
        //{

        //    if (ModelState.IsValid)
        //    {
        //        // Copy data from RegisterViewModel to IdentityUser
        //        var user = new IdentityUser
        //        {
        //            UserName = model.Email,
        //            Email = model.Email
        //        };

        //        // Store user data in AspNetUsers database table
        //        var result = await userManager.CreateAsync(user, model.Password);

        //        // If user is successfully created, sign-in the user using
        //        // SignInManager and redirect to index action of HomeController
        //        if (result.Succeeded)
        //        {
        //            await signInManager.SignInAsync(user, isPersistent: false);
        //            return RedirectToAction("index", "home");
        //        }

        //        // If there are any errors, add them to the ModelState object
        //        // which will be displayed by the validation summary tag helper
        //        foreach (var error in result.Errors)
        //        {
        //            ModelState.AddModelError(string.Empty, error.Description);
        //        }
        //    }


        //    return View();
        //}




        //[HttpPost]
        //public IActionResult Create(InvestorViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        string uniqueFileName = null;
        //        if (model.Photo != null)
        //        {
        //            string uploadsFolder = Path.Combine(hostEnvironment.WebRootPath, "images");

        //            uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
        //            string filePath = Path.Combine(uploadsFolder, uniqueFileName);

        //            model.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
        //        }

        //        Investor newInvestor = new Investor
        //        {
        //            FirstName = model.FirstName,
        //            Email = model.Email,

        //            Photo = uniqueFileName
        //        };

        //        _investorService.AddInvestor(newInvestor);

        //        return RedirectToAction("details", new { id = newInvestor.Id });

        //        //Investor newInvestor = _investorService.AddInvestor(investor);

        //    }
        //    return View();
        //}




        //public IActionResult Create(Investor investor)
        //{
        //    _investorService.AddInvestor(investor);
        //   // _investorService.SaveChanges();
        //    return RedirectToAction("Index");
        //}



        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }



        public IActionResult Login(string email, string password)
        {
            var investor = _investorService.Login(email, password);
            if (investor == null)
            {
                ViewBag.Message = "Invalid Username/Password";
                return View();
            }
            else
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, $"{investor.FirstName}"),
                    new Claim(ClaimTypes.GivenName, $"{investor.FirstName} {investor.LastName}"),
                    new Claim(ClaimTypes.NameIdentifier, investor.Id.ToString()),
                    new Claim(ClaimTypes.Email, investor.Email),
                    new Claim(ClaimTypes.Role, "Investor"),


                };
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var authenticationProperties = new AuthenticationProperties();
                var principal = new ClaimsPrincipal(claimsIdentity);
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, authenticationProperties);
                return RedirectToAction("Index", "Investor");
            }

        }




        [HttpGet]
        // [Authorize]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var investor = _investorService.GetInvestor(id.Value);
            if (investor == null)
            {
                return NotFound();
            }

            return View(investor);
        }



        [HttpPost]
        //[Authorize]
        public IActionResult Edit(int id, Investor investor)
        {
            if (id != investor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                _investorService.UpdateInvestor(investor);
                return RedirectToAction(nameof(Index));
            }

            return View(investor);
        }



        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var investor = _investorService.GetInvestor(id.Value);
            if (investor == null)
            {
                return NotFound();
            }

            return View(investor);
        }



        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _investorService.DeleteInvestor(id);
            return RedirectToAction(nameof(Index));
        }



        [HttpGet]
        public IActionResult Details(int? id)
        {
            return View(_investorService.GetDetails(id.Value));
        }




    }
}
