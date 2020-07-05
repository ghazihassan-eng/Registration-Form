using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace registrationform_assignment_dbms.Controllers
{
    public class homeController : Controller
    {
        //
        // GET: /home/
        public ActionResult Index()
        {
           

            return View();
        }

        [HttpPost]
        public ActionResult index(string name,string email,string number,string cnic,string education,string province,string city,string accept)

        {
            if(name.Equals("")==true)
            {
                ModelState.AddModelError("name", "Name is required...");
            }
            if (email.Equals("") == true)
            {
                ModelState.AddModelError("email", "email is required...");
            }
            if (number.Equals("") == true)
            {
                ModelState.AddModelError("number", "Number is required...");
            }
            if (cnic.Equals("") == true)
            {
                ModelState.AddModelError("cnic", "Cnic is required...");
            }
            if (education.Equals("") == true)
            {
                ModelState.AddModelError("education", "Education status is required...");
            }
           
            if (province.Equals("") == true)
            {
                ModelState.AddModelError("province", "Province is required...");
            }
            if (city.Equals("") == true)
            {
                ModelState.AddModelError("city", "City is required...");
            }
            if (accept.Equals(unchecked(true)))
            {
                ModelState.AddModelError("accept", "Must check this...");
            }
            if(ModelState.IsValid==true)
            {
                ViewData["msg"] = "your data is send successfully";
            }

            return View();
        }
	}
}