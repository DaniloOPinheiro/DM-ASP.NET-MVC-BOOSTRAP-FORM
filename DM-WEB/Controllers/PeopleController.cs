using DM_WEB.Data;
using DM_WEB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace DM_WEB.Controllers
{
    public class PeopleController : Controller
    {
        private DMContext db = new DMContext();

        // [Route("People/Index")]
        public IActionResult Index()
        {
            return View();
        }

        public List<object> states = new List<object>
        {
                new {Initials = "AC", Name = "Acre" },
                new {Initials = "AL", Name = "Alagoas" },
                new {Initials = "AP", Name = "Amapa" },
                new {Initials = "AM", Name = "Amazonas" },
                new {Initials = "BA", Name = "Bahia" },
                new {Initials = "CE", Name = "Ceara" },
                new {Initials = "DF", Name = "Distrito Federal" },
                new {Initials = "ES", Name = "Espirito Santo" },
                new {Initials = "GO", Name = "Goias" },
                new {Initials = "MA", Name = "Maranhao" },
                new {Initials = "MT", Name = "Mato Grosso" },
                new {Initials = "MS", Name = "Mato Grosso do Sul" },
                new {Initials = "MG", Name = "Minas Gerais" },
                new {Initials = "PA", Name = "Para" },
                new {Initials = "PB", Name = "Paraiba" },
                new {Initials = "PR", Name = "Parana" },
                new {Initials = "PE", Name = "Pernambuco" },
                new {Initials = "PI", Name = "Piaui" },
                new {Initials = "RJ", Name = "Rio de Janeiro" },
                new {Initials = "RN", Name = "Rio Grande do Norte" },
                new {Initials = "RS", Name = "Rio Grande do Sul" },
                new {Initials = "RO", Name = "Rondonia" },
                new {Initials = "RR", Name = "Roraima" },
                new {Initials = "SC", Name = "Santa Catarina" },
                new {Initials = "SP", Name = "Sao Paulo" },
                new {Initials = "SE", Name = "Sergipe" },
                new {Initials = "TO", Name = "Tocantins" }
        };

        
        public IActionResult Register()
        {
            // ViewBag.States = new SelectList(states, "Initials", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult RegisterPerson(People people)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.States = new SelectList(states, "Initials", "Name");
                return View("Register", people);
            }

            db.People.Add(people);
            db.SaveChanges();

            return RedirectToAction("Success");
        }

        public IActionResult Success()
        {
            return View();
        }

        public JsonResult ValidateCPF(string cpf)
        {
            var people = db.People.Find(cpf);
            return Json(people == null);
        }
    }
}
