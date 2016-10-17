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
        // GET: Student
        public ActionResult Index()
        {
            StudentRepository repo = new StudentRepository();
            ViewBag.Student = repo.GetStudents();
            return View();
        }

        // GET: Student/Details/
        public ActionResult Details(int id)
        {
            StudentRepository repo = new StudentRepository();
            int StudentsCount = repo.GetStudents().Count;

            if (id > 0 && id <= StudentsCount)
            {
                ViewBag.ValidStudent = true;
                ViewBag.SpecificStudent = repo.FindStudentByStudentID(int Student);
                return View();
            }
            else
            {
                ViewBag.ValidStudent = false;
                return View();
            }
            return View();
        }

    }
        
}
