using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class mockemployee : employeeinterface
    {
        private List<employee>_employeelist;
        public mockemployee()
        {
            _employeelist = new List<employee>()
            {
                new employee(){ID=1,NAME="ram"},
                new employee(){ID=2,NAME="sky"},
            };

        }

        public IEnumerable<employee> Getall()
        {
            return _employeelist;
        }

        public employee Getemployee(int ID)
        {
            return _employeelist.FirstOrDefault(employee => employee.ID == ID);
        }
    }
}
