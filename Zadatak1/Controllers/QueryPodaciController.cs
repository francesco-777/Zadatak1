using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Zadatak1.Controllers
{
    public class QueryPodaciController : Controller
    {
        public ViewResult QueryPodaci() 
        {
            return View("Osoba");
        }
        [HttpPost]
        public ViewResult QueryPodaci(string ime_prezime)
        {
            string pozdrav = "Dobar dan, " + ime_prezime + "!";
            return View("Osoba", (object)pozdrav);
        }
    }
}