using DataAccess;
using Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.ViewModels;

namespace Web.Controllers
{
    public class AuthController : Controller
    {
        private readonly UserManager<MebelanUser> usermanager;
        private readonly SignInManager<MebelanUser> _signInManager;
        private readonly ApplicationDbContext _context;


        public AuthController(UserManager<MebelanUser> userManager, SignInManager<MebelanUser> signInManager, ApplicationDbContext context)
        {
             usermanager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

        public IActionResult Registration()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Registration(RegisterVM registerVM)
        {
            if (!ModelState.IsValid)
            {
                return View(registerVM);
            }
            MebelanUser appUser = new MebelanUser()
            {
                UserName = registerVM.Email,
                Email = registerVM.Email,
                Firstname = registerVM.Firstname,
                PhoneNumber=registerVM.PhoneNumber
            };
            IdentityResult result = await usermanager.CreateAsync(appUser, registerVM.Password);
           
            if (result.Succeeded)
            {
                IdentityResult res = await usermanager.AddToRoleAsync(appUser, "User");
                
            }
            else
            {
                foreach(IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

            }
            return View("Login");


        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login( LoginVM loginVM)
        {
            if (!ModelState.IsValid)
            {
                return View(loginVM);
            }
            MebelanUser appUser = await usermanager.FindByEmailAsync(loginVM.Email);
            if(appUser == null)
            {
                ModelState.AddModelError("", "Email yanlişdır!");
                return View(loginVM);
            }
            Microsoft.AspNetCore.Identity.SignInResult result = await
                _signInManager.PasswordSignInAsync(appUser, loginVM.Password, loginVM.RememberMe, false);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Email yanlişdır!");
                return View(loginVM);
            }

            return RedirectToAction("Index","Home");
        }
    }
   
}
