using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes1.Repository;
using Classes1.Data;

namespace Classes1
{
    public class Student : Person, IStudentService
    {
        public Student(string name, DateTime birthday, string address, decimal salary, decimal payrate) : base(name, birthday, address, salary, payrate)
        {
        }
        private readonly IDictionary<string, int> CoursesGrades;
        public void setGrade(string course, int grade)
        {
            CoursesGrades[course] = grade;
        }
        public double CalcGPA()
        {
            int totalGrades = 0;
            int gradesCount = CoursesGrades.Count;
            double gpa;
            foreach(KeyValuePair<string, int> grade in CoursesGrades)
            {
                totalGrades += grade.Value;
            }
            gpa = totalGrades / gradesCount;
            return gpa;
        }

        public List<string> GetCourses()
        {
            List<string> courses = new List<string>();
            foreach (KeyValuePair<string, int> course in CoursesGrades)
            {
                courses.Add(course.Key);
            }
            return courses;
        }

        public IDictionary<string, int> GetGrades()
        {
            return CoursesGrades;
        }
    }
}
