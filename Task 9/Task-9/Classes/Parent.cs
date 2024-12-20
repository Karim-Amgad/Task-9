using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    internal class Parent
    {
        #region Property& Attribute
        private decimal parentsalary;

        public virtual decimal ParentSalary
        {
            get { return parentsalary; }
            set { parentsalary = value; }
        }
        #endregion

        #region Ctor
        public Parent(decimal _Salary) 
        {
            ParentSalary= _Salary;
        }
        #endregion

        #region Method
        public virtual void DisplaySalary()
        {
             Console.WriteLine($"The salary is {ParentSalary}");
        }
        #endregion

    }
}
