using RepoQuiz.Models;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;

namespace RepoQuiz.DAL
{
    public class StudentRepository
    {
        public object removed_student;

        public StudentContext Context { get; set; }
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
        public Student FindStudentByMajor(string major)
        {
            Student found_student = Context.Students.FirstOrDefault(a => a.Major.ToLower() == major.ToLower());
            return found_student;
        }

        public Student RemoveStudent(string major)
        {
            Student found_student = FindStudentByMajor(major);
            if (found_student != null)
            {
                Context.Students.Remove(found_student);
                Context.SaveChanges();
            }
            return found_student;
        }
    }
}