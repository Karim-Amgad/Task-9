using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    internal class Person
    {
        #region Property & Attribute
        public string Department { get; set; }
        #endregion

        #region Ctor
        public Person(string _Department)
        {
            Department = _Department;
        }
        #endregion

        #region Override String
        public override string ToString()
        {
            return ($"The department is {Department}");
        } 
        #endregion
    }
}
