using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes1.Repository;


namespace Classes1.Data
{
    public class Department : IDepartmentService
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal GetBudget()
        {
            throw new NotImplementedException();
        }

        public string[] GetCourses()
        {
            throw new NotImplementedException();
        }
    }
}
