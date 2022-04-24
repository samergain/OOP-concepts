using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes1.Repository;
namespace Classes1
{
    public class Person : IPersonService
    {
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public string Address { get; set; }
        public decimal Salary { get; set; }
        public decimal PayRate { get; set; }

        public Person(string name, DateTime birthday, string address, decimal salary, decimal payrate)
        {
            Name = name; Birthdate = birthday; Address = address; Salary = salary; PayRate = payrate; 
        }
        public int CalcAge()
        {
            int age = DateTime.Now.Subtract(Birthdate).Days;
            return age;
        }

        public virtual decimal CalcSalary(int hours)
        {
            return PayRate * hours;
        }

    }
}
