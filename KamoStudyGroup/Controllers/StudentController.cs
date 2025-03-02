using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KamoStudyGroup.Models; // Add your model namespace here

namespace KamoStudyGroup.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            List<StudentDetails> students = new List<StudentDetails>  // Create a list of the students you wanna add
            {
                new StudentDetails      // Student details added in the list
                {
                    StudentNo = "22560646",
                    StudentName = "Kamo",
                    StudentSurname = "Motsoko",
                    StudentEmail = "u22560646@tuks.co.za",
                },

                new StudentDetails
                {
                    StudentNo = "23799448",
                    StudentName = "Ayola",
                    StudentSurname = "Gwampi",
                    StudentEmail = "u23799448@tuks.co.za",
                },

                new StudentDetails
                {
                    StudentNo = "23552311",
                    StudentName = "Unathi",
                    StudentSurname = "Mokgoetsi",
                    StudentEmail = "u23552311@tuks.co.za",
                },

                new StudentDetails
                {
                    StudentNo = "23671922",
                    StudentName = "Ntokoto",
                    StudentSurname = "Mongwe",
                    StudentEmail = "u23671922@tuks.co.za",
                },

                new StudentDetails
                {
                    StudentNo = "23533057",
                    StudentName = "Xolani",
                    StudentSurname = "Tobo",
                    StudentEmail = "u23533057@tuks.co.za",
                },
            };
            return View(students);  //Display list of students in the View
        }
    }
}