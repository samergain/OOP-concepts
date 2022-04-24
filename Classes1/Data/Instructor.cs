using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes1.Repository;

namespace Classes1
{
    public class Instructor : Person, IInstructorService
    {
        public Instructor(string name, DateTime birthday, string address, decimal salary, decimal payrate) : base(name, birthday, address, salary, payrate)
        {
        }
        public DateTime JoinedDate { get; set; }
        public int DepartmentID { get; set; }
        public decimal CalcBonus()
        {
            decimal bonus = 20 * CalcYrsOfExp();
            return bonus;
        }

        public int CalcYrsOfExp()
        {
            int yrsOfExp = DateTime.Now.Subtract(JoinedDate).Days;
            return yrsOfExp;
        }

        public string GetDepartment()
        {
            throw new NotImplementedException();
        }
    }
}
