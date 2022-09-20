using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class Person
    {
        //name property
        public string Name { get; set; }

        //ID property
        public string ID { get; set; }


        /// <summary>
        /// ctor to initialize property values
        /// </summary>
        /// <param name="name">set to Name</param>
        /// <param name="iD">set as ID</param>
        public Person (string name, string iD)
        {
            Name = name;
            ID = iD;
        }

        /// <summary>
        /// to string method
        /// </summary>
        /// <returns>person's property values</returns>
        public override string ToString()
        {
            return $"name is: {Name}\n ID:{ID}";
        }
    }
}
