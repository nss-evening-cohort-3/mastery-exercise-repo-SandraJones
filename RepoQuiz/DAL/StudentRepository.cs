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
        public object removed_student;

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

        public Student FindStudentByStudentID(int studentID)
        {
            Student found_student = Context.Students.FirstOrDefault(a => a.StudentID == studentID);
            return found_student;
        }

        public void AddStudent(Student my_student)
        {
            Context.Students.Add(my_student);
            Context.SaveChanges();
        }
        public void RemoveStudent(string major)
        {

            Context.Students.Remove(this.major);
            Context.SaveChanges();
        }
    }
}