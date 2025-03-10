using System;
using System.Collections.Generic;
using System.Web.Mvc;
using u23784718_S1P01.Models;

namespace u23784718_S1P01.Controllers
{
    public class PeopleController : System.Web.Mvc.Controller
    {
        

        public ActionResult ListPeople()
        {
            List<Models.PersonModel> people = new List<Models.PersonModel>();

            people.Add(new Models.PersonModel { FirstName = "Tina", LastName = "Magqira", StudentNumber = 23784718, EmailAddress = "u23784718@tuks.co.za", MyLink ="~/HTML/Tina.html" });
            people.Add(new Models.PersonModel { FirstName = "Sivuyisile", LastName = "Ngalo", StudentNumber = 24979962, EmailAddress = "u24979962@tuks.co.za", MyLink = "~/HTML/Sivuyisile.html" });
            people.Add(new Models.PersonModel { FirstName = "Iviwe", LastName = "Vikwa", StudentNumber = 24683729, EmailAddress = "u24683729@tuks.co.za", MyLink = "~/HTML/Iviwe.html" });
            people.Add(new Models.PersonModel { FirstName = "Experience", LastName = "Milambo", StudentNumber = 24876519, EmailAddress = "u24876519@tuks.co.za", MyLink = "~/HTML/Experience.html" });
            people.Add(new Models.PersonModel { FirstName = "Chrystilla", LastName = "Asare", StudentNumber = 23679702, EmailAddress = "u23679702@tuks.co.za", MyLink = "~/HTML/Chrystilla.html" });

            return View(people);

        }

       
    }
}