using System.Collections.Generic;
using System.Web.Mvc;

namespace S1P01.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People

        public ActionResult ListPeople()
        {
            List<Models.PersonModel> people = new List<Models.PersonModel>();

            people.Add(new Models.PersonModel { FirstName = "Name 1", LastName = "Surname 1", StudentNumber = 1, EmailAddress = "Email Address" });
            people.Add(new Models.PersonModel { FirstName = "Name 2", LastName = "Surname 2", StudentNumber = 2, EmailAddress = "Email Address" });
            people.Add(new Models.PersonModel { FirstName = "Name 3", LastName = "Surname 3", StudentNumber = 3, EmailAddress = "Email Address" });
            people.Add(new Models.PersonModel { FirstName = "Name 4", LastName = "Surname 4", StudentNumber = 4, EmailAddress = "Email Address" });
            people.Add(new Models.PersonModel { FirstName = "Name 5", LastName = "Surname 5", StudentNumber = 5, EmailAddress = "Email Address" });

            return View(people);

        }
 
    }
}