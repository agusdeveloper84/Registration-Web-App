using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using registrationWebApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace registrationWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        
        List<Instructor> instructors = null;
        List<Student> students = null;
        List<Course> courses = null;

        // index method
        public IActionResult Index()
        {
            return View();
        }


        //Instructor action method
        public IActionResult Instructor()
        {
            ViewBag.Instructors = instructors;
            return View();
        }

        //Student action method
        public IActionResult Student()
        {
            ViewBag.Students = students;
            return View();
        }

        //Course action method
        public IActionResult Course()
        {
            ViewBag.Courses = courses;
            return View();
        }

        // method to get the students by course name
        public JsonResult GetStudentByCourse(string course)
        {
            var studentData = students.FindAll(s => s.Course == course).ToList();
            return Json(new { studentData });
        }
   
    public HomeController()
        {
            
            instructors = new List<Instructor>()
            {
            new Instructor()
            {
            InstructorId = 1,
            FirstName = "Agustin" ,
            LastName = "Rossi" ,
            Email = "agus@collegeisntructor.com" ,
            Course = "Full Stack  Web Developer" ,
            },
            new Instructor()
            {
            InstructorId = 2,
            FirstName = "Marin" ,
            LastName = "Sapo" ,
            Email = "msapo@collegeisntructor.com" ,
            Course = "Accounting & Payroll Administrator" ,
            },
            new Instructor()
            {
            InstructorId = 3,
            FirstName = "Victoria" ,
            LastName = "MacAllister" ,
            Email = "vimac@collegeisntructor.com" ,
            Course = "e-Commerce Professional Program" ,
            },
            new Instructor()
            {
            InstructorId = 4,
            FirstName = "Harry" ,
            LastName = "Potter" ,
            Email = "hpotter@collegeisntructor.com" ,
            Course = "Computer Support Technician" ,
            },
            new Instructor()
            {
            InstructorId = 5,
            FirstName = "Andrew" ,
            LastName = "Williams" ,
            Email = "andreww@collegeisntructor.com" ,
            Course = "Cyber & Cloud Security Program" ,
            }
            };
                        students = new List<Student>()
            {
            new Student()
            {
            StudentId = 10,
            FirstName = "Lionel",
            LastName = "Messi",
            Email = "leomessi@college.com",
            Phone = "431-846-2684",
            Course = "Full Stack Web Developer"
            },
            new Student()
            {
            StudentId = 11,
            FirstName = "Pato",
            LastName = "Nabais",
            Email = "pnabais@college.com",
            Phone = "905-407-5527",
            Course = "Full Stack Web Developer"
            },
            new Student()
            {
            StudentId = 12,
            FirstName = "Oscar",
            LastName = "Romero",
            Email = "romeroarquero@college.com",
            Phone = "905-123-2145",
            Course = "Cyber & Cloud Security Program"
            },
            new Student()
            {
            StudentId = 13,
            FirstName = "Elgordo",
            LastName = "Matraca",
            Email = "elgordis@college.com",
            Phone = "905-365-5563",
            Course = "e-Commerce Professional Program"
            },
            new Student()
            {
            StudentId = 14,
            FirstName = "Martin",
            LastName = "Delpotro",
            Email = "delpo@college.com",
            Phone = "416-469-7319",
            Course = "Computer Support Technician"
            },
            };
                        courses = new List<Course>()
            {
            new Course()
            {
            CourseId = 500,
            CourseName = "Full Stack Developer",
            CourseNumber = 600,
            Description = "Learn to use the latest development languages and platforms to build comprehensive web solutions.",

            },
            new Course()
            {
            CourseId = 501,
            CourseName = "Accounting & Payroll Administrator",
            CourseNumber = 601,
            Description = "Providing you with a basic understanding of office procedures, bookkeeping, Sage and Quickbooks computerized accounting, corporate and financial accounting, and payroll administration.",
            },
            new Course()
            {
            CourseId = 502,
            CourseName = "e-Commerce Professional Program",
            CourseNumber = 602,
            Description = "This program will prepare graduates to start their own e-business or become a valuable member of an already established e-business team.",
            },
            new Course()
            {
            CourseId = 503,
            CourseName = "Computer Support Technician",
            CourseNumber = 603,
            Description = "Provide expert IT support to your customers.",
            },
            new Course()
            {
            CourseId = 504,
            CourseName = "Cyber & Cloud Security Program",
            CourseNumber = 604,
            Description = "Providing you with the knowledge on how to keep cloud customers' and organizations' information secure by focusing on protecting valuable data and systems hosted in the Cloud.",
            }
            };
        }
    }
}
