using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    internal class Child : Parent
    
    {
        #region Atrribute & Property override
        private decimal childsalary;

        public override decimal ParentSalary
        { get { return childsalary; }
          set { childsalary = value; } }

        #endregion

        #region Ctor
        public  Child(decimal salary) : base(salary){}
        #endregion

        #region Method override
        public override void DisplaySalary()
        {
            base.DisplaySalary();
        }
        #endregion

    }
}
