using RepoQuiz.Models;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;

namespace RepoQuiz.DAL
{
    public class StudentRepository
    {
        private string last_name;
        private string _major;
        private Student student_;
        private int studentID;
        private Student major;

        public StudentContext Context { get; set; }
        public string first_name { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Major { get; private set; }
        public int StudentID { get; private set; }

        public StudentRepository()
        {
            Context = new StudentContext();
        }
        public StudentRepository(StudentContext _context)
        {
            Context = _context;
        }
        public List<Student> GetStudents()
        {
            return Context.Students.ToList();
        }
        //public void AddStudent(StudentContext student_)
        //{
        //   // Student student_ = new Student { FirstName = first_name, LastName = last_name, StudentID = studentID, Major = _major };
        //    Context.Students.Add(this.student_);
        //    Context.SaveChanges();
        //}
        //public void AddStudent(string FirstName, string LastName)
        //{         
        //    Context.Students.Add(student_);
        //    Context.SaveChanges();
        //}

        public Student FindStudentByStudentID(int studentID)
        {
            Student found_student = Context.Students.FirstOrDefault(a => a.StudentID == studentID);
            return found_student;
        }

        //public void AddStudent(Student my_student)
        //{
        //    Context.Students.Add(my_student);
        //    Context.SaveChanges();
        //}


        //public void AddStudent(StudentContext student_)
        //{
        //    // Student student_ = new Student { FirstName = first_name, LastName = last_name, StudentID = studentID, Major = _major };
        //    Context.Students.Add(this.student_);
        //    Context.SaveChanges();
        //}

        public void RemoveStudent(StudentContext major)
        {

            Context.Students.Remove(this.major);
            Context.SaveChanges();
        }

        //public void AddStudent1(string v1, string v2, int v3, string v4)
        //{
        //    Context.Students.Add(FirstName = first_name, LastName = last_name, StudentID = studentID, Major = _major);
        //}
    }
}