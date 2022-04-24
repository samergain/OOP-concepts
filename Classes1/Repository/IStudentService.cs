using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes1.Repository
{
    public interface IStudentService : IPersonService
    {
        List<string> GetCourses();
        double CalcGPA();
        IDictionary<string, int> GetGrades();
    }
}
