using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes1.Repository
{
    public interface IInstructorService : IPersonService
    {
        string GetDepartment();
        decimal CalcBonus();
        int CalcYrsOfExp();
    }
}
