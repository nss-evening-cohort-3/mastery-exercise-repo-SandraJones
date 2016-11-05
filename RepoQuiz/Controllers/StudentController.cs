using RepoQuiz.DAL;
using RepoQuiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RepoQuiz.Controllers
{
    public class StudentController : Controller
    {
        //Generate random student:
        NameGenerator newGenerator = new NameGenerator();

        private StudentRepository repo = new StudentRepository();
        // GET: Student
        public ActionResult Index()
        {
            ViewBag.Students = repo.GetStudents();
            return View();
        }
        public ActionResult Student()
        {
            int j = 0;
            return View();
        }

        // GET: Student/Details/{id}
        public ActionResult Details(int id)
        {
            int StudentsCount = repo.GetStudents().Count;

            if (id > 0 && id <= StudentsCount)
            {
                ViewBag.ValidStudent = true;
                ViewBag.SpecificStudent = repo.FindStudentByStudentID(id);
                return View();
            }
            else
            {
                ViewBag.ValidStudent = false;
                    return View();
            }
               // return View();
            }
      }       
}
