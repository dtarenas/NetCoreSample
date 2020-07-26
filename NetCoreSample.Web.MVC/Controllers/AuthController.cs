

namespace NetCoreSample.Web.MVC.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using NetCoreSample.DAL.DAL;
    using NetCoreSample.Models.DTOs;
    using NetCoreSample.Models.Entities;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.Controller" />
    public class AuthController : Controller
    {
        /// <summary>
        /// The context
        /// </summary>
        private readonly DataContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthController"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public AuthController(DataContext context)
        {
            this._context = context;
        }

        /// <summary>
        /// Registers this instance.
        /// </summary>
        /// <returns>Register View</returns>
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(UsersRegisterDTO usersRegisterDTO)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest();
            }

            var user = new Users()
            {
                Email = usersRegisterDTO.Email,
                FullName = usersRegisterDTO.FullName,
                Password = usersRegisterDTO.Password
            };

            try
            {
                this._context.Add(user);
                this._context.SaveChanges();
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }

            return this.Ok("Todo salió Bien");
        }
    }
}
