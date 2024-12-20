using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    public class Department
    {
        #region Property & Attribute
        public string Name { get; set; }
        #endregion

        #region Ctor
        public Department(string _Name)
        {
            Name = _Name;
        }
        #endregion


        #region Override ToString
        public override string ToString()
        {
            return Name;
        } 
        #endregion
    }
}
