using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Manager: Employee
    {
        //years of experince
        public int Vetek { get; set; }

        /// <summary>
        /// constructor to declare the properties of class Manager 
        /// </summary>
        /// <param name="nname"></param>
        /// <param name="iid"></param>
        /// <param name="salary"></param>
        /// <param name="vetek"></param>
        public Manager(string nname, string iid, double salary, int vetek) : base(nname, iid, salary)
        {
            Vetek = vetek;
        }
    }
}
