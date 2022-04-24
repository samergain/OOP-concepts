using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes1.Repository;

namespace Classes1.Data 
{
    public class Course : ICourseService
    {
        public string CourseName { get; set; }
        public string[] GetStudents()
        {
            throw new NotImplementedException();
        }
    }
}
