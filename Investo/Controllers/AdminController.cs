//using System;
//using Investo.Interface.Services;
//using Microsoft.AspNetCore.Mvc;

//namespace Investo.Controllers
//{
//    public class AdminController : Controller
//    {


//            private readonly IAdminService _adminService;


//            public AdminController(IAdminService adminService)
//            {
//                _adminService = adminService;
//            }






//            [HttpGet]
//            public IActionResult Index()
//            {
//                return View(_adminService.GetAll());
//            }

//            public IActionResult Create()
//            {
//                return View();
//            }



//            [HttpPost]
//            public IActionResult Create(Admin admin)
//            {
//                if (ModelState.IsValid)
//                {
//                    _adminService.AddAdmin(admin);

//                    return RedirectToAction(nameof(Index));
//                }
//                return View(admin);
//            }


//            //public IActionResult Create(Investor investor)
//            //{
//            //    _investorService.AddInvestor(investor);
//            //   // _investorService.SaveChanges();
//            //    return RedirectToAction("Index");
//            //}



//            [HttpGet]
//            public IActionResult Login()
//            {
//                return View();
//            }



//            public IActionResult Login(string email, string password)
//            {
//                var admin = _adminService.Login(email, password);
//                if (admin == null)
//                {
//                    ViewBag.Message = "Invalid Username/Password";
//                    return View();
//                }
//                else
//                {
//                    var claims = new List<Claim>
//                {
//                    new Claim(ClaimTypes.Name, $"{admin.FirstName}"),
//                    new Claim(ClaimTypes.GivenName, $"{admin.FirstName} {admin.LastName}"),
//                    new Claim(ClaimTypes.NameIdentifier, admin.Id.ToString()),
//                    new Claim(ClaimTypes.Email, admin.Email),
//                    new Claim(ClaimTypes.Role, "Admin"),


//                };
//                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
//                    var authenticationProperties = new AuthenticationProperties();
//                    var principal = new ClaimsPrincipal(claimsIdentity);
//                    HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, authenticationProperties);
//                    return RedirectToAction("Index", "Admin");
//                }

//            }

//            [HttpGet]
//            public IActionResult Edit(int? id)
//            {
//                if (id == null)
//                {
//                    return NotFound();
//                }

//                var admin = _adminService.GetAdmin(id.Value);
//                if (admin == null)
//                {
//                    return NotFound();
//                }

//                return View(admin);
//            }



//            [HttpPost]
//            public IActionResult Edit(int id, Admin admin)
//            {
//                if (id != admin.Id)
//                {
//                    return NotFound();
//                }

//                if (ModelState.IsValid)
//                {

//                    _adminService.Update(admin);
//                    return RedirectToAction(nameof(Index));
//                }

//                return View(admin);
//            }



//            [HttpGet]
//            public IActionResult Delete(int? id)
//            {
//                if (id == null)
//                {
//                    return NotFound();
//                }

//                var admin = _adminService.GetAdmin(id.Value);
//                if (admin == null)
//                {
//                    return NotFound();
//                }

//                return View(admin);
//            }



//            [HttpPost, ActionName("Delete")]
//            public IActionResult DeleteConfirmed(int id)
//            {
//                _adminService.DeleteAdmin(id);
//                return RedirectToAction(nameof(Index));
//            }



//            //[HttpGet]
//            //public IActionResult Details(int? id)
//            //{
//            //    return View(_managerService.GetDetails(id.Value));
//            //}




















//            //[HttpGet]
//            //public IActionResult Index()
//            //{
//            //    return View(_managerService.GetAll());
//            //}

//            //public IActionResult Create()
//            //{
//            //    return View();
//            //}



//            //[HttpPost]
//            //public IActionResult Create(Manager manager)
//            //{
//            //    if (ModelState.IsValid)
//            //    {
//            //        _managerService.AddManager(manager);

//            //        return RedirectToAction(nameof(Index));
//            //    }
//            //    return View(manager);
//            //}


//            ////public IActionResult Create(Investor investor)
//            ////{
//            ////    _investorService.AddInvestor(investor);
//            ////   // _investorService.SaveChanges();
//            ////    return RedirectToAction("Index");
//            ////}



//            //[HttpGet]
//            //public IActionResult Login()
//            //{
//            //    return View();
//            //}



//            //public IActionResult Login(string email, string password)
//            //{
//            //    var manager = _managerService.Login(email, password);
//            //    if (manager == null)
//            //    {
//            //        ViewBag.Message = "Invalid Username/Password";
//            //        return View();
//            //    }
//            //    else
//            //    {
//            //        var claims = new List<Claim>
//            //        {
//            //            new Claim(ClaimTypes.Name, $"{manager.FirstName}"),
//            //            new Claim(ClaimTypes.GivenName, $"{manager.FirstName} {manager.LastName}"),
//            //            new Claim(ClaimTypes.NameIdentifier, manager.Id.ToString()),
//            //            new Claim(ClaimTypes.Email, manager.Email),
//            //            new Claim(ClaimTypes.Role, "Manager"),


//            //        };
//            //        var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
//            //        var authenticationProperties = new AuthenticationProperties();
//            //        var principal = new ClaimsPrincipal(claimsIdentity);
//            //        HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, authenticationProperties);
//            //        return RedirectToAction("Index", "Manager");
//            //    }

//            //}

//            //[HttpGet]
//            //public IActionResult Edit(int? id)
//            //{
//            //    if (id == null)
//            //    {
//            //        return NotFound();
//            //    }

//            //    var manager = _managerService.GetManager(id.Value);
//            //    if (manager == null)
//            //    {
//            //        return NotFound();
//            //    }

//            //    return View(manager);
//            //}



//            //[HttpPost]
//            //public IActionResult Edit(int id, Manager manager)
//            //{
//            //    if (id != manager.Id)
//            //    {
//            //        return NotFound();
//            //    }

//            //    if (ModelState.IsValid)
//            //    {

//            //        _managerService.Update(manager);
//            //        return RedirectToAction(nameof(Index));
//            //    }

//            //    return View(manager);
//            //}



//            //[HttpGet]
//            //public IActionResult Delete(int? id)
//            //{
//            //    if (id == null)
//            //    {
//            //        return NotFound();
//            //    }

//            //    var manager = _managerService.GetManager(id.Value);
//            //    if (manager == null)
//            //    {
//            //        return NotFound();
//            //    }

//            //    return View(manager);
//            //}



//            //[HttpPost, ActionName("Delete")]
//            //public IActionResult DeleteConfirmed(int id)
//            //{
//            //    _managerService.DeleteManager(id);
//            //    return RedirectToAction(nameof(Index));
//            //}


//            //public async Task<IActionResult> Logout()
//            //{
//            //    await HttpContext.SignOutAsync();
//            //    return RedirectToAction("Login", "Manager");
//            //}




//        }
//    }


//}
//}
