using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_9
{
    public class Employee
    {
        #region Properties & Attributes
        private int EmpID;
        private string EmpName;
        private decimal empsalary;
        public Department department { get; set; }
        public string GetName()
        {
            return EmpName;
        }
        public void SetName(string value)
        {
            EmpName = value.Length <= 20 ? value : value.Substring(0, 20);
        }

        public decimal Salary
        {
            get { return empsalary; }
            set { empsalary = value < 4000 ? 4000 : value; }
        }
        public int Age { get; set; } 
        #endregion
        public Employee(int _id, string _Name, decimal _salary, int _Age, Department _Department)
        {
            EmpID = _id;
            EmpName = _Name;
            empsalary = _salary;
            Age = _Age;
            department = _Department;
        }
        public override string ToString()
        {
            return $"Emp Id is {EmpID}, Name is {EmpName}, Salary is {empsalary}, Age is {Age}, Department is {department}";
        }
 
        public override bool Equals(object obj)
        {
            if (obj==null || GetType() != obj.GetType()) return false;    
            Employee otherEmployee = (Employee)obj;
            return EmpID == otherEmployee.EmpID && EmpName == otherEmployee.EmpName && empsalary == otherEmployee.empsalary && Age == otherEmployee.Age;
        }
    }
    
}

