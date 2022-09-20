using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Employee: Person
    {
        //property representing employee salary 
        public double Salary { get; set; }

        /// <summary>
        /// cot to declare employee properties
        /// </summary>
        /// <param name="nname">name of employee</param>
        /// <param name="iid">employee ID</param>
        /// <param name="salary">Employee salary</param>
        public Employee(string nname, string iid, double salary) : base(nname, iid)
        {
            Salary = salary;
        }
    }
}
