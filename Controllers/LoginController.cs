using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project_Pilot_FreeJob.Models;

namespace Project_Pilot_FreeJob.Controllers
{
    public class LoginController : Controller
    {
        private readonly FreeJobDbContext _context;

        public LoginController(FreeJobDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Usuario usuario)
        {
            if(!string.IsNullOrEmpty(usuario.Senha) && !string.IsNullOrEmpty(usuario.Login))
            {
                var userBd = _context.Usuario.Where(x => x.Login == usuario.Login && x.Senha == usuario.Senha).FirstOrDefault();
                if(userBd != null)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return RedirectToAction("Contact", "Home");
                }
            }
            else
            {
                return RedirectToAction("Privacy", "Home");
            }

        }

        //String passaporte = null;
        //String login = null;

        //if (usuario.Senha != passaporte)
        //{

        //    return View();
        //}
        //usuario.Senha = passaporte;
        //usuario.Login = login;

    }


}
    
