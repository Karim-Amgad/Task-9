using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Permissions;
using Task_9.Classes;

namespace Task_9
{
    #region Problem-1 Enum 
    enum Weekdays : byte
    {
        Monday=1,
        Tuesday=2,
        Wednesday=3,
        Thursday=4,
        Friday=5,
    }
    #endregion

    #region Problem-2 Enum
    enum Grades : short
    {
        A = 5,
        B = 4,
        C = 3,
        D = 2, 
        E = 1, 
        F = -1
    }
    #endregion

    #region Problem-7 Enum
    enum GenderDefault : int
    {
        Male = 1,
        Female
    }
    enum Gender : byte
    {
        Male = 254,
        Female
    }
    #endregion

   
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem-1
            //Console.WriteLine($"The day is {Weekdays.Monday} and the number is {(int)Weekdays.Monday}");
            //Console.WriteLine($"The day is {Weekdays.Tuesday} and the number is {(int)Weekdays.Tuesday}");
            //Console.WriteLine($"The day is {Weekdays.Wednesday} and the number is {(int)Weekdays.Wednesday}");
            //Console.WriteLine($"The day is {Weekdays.Thursday} and the number is {(int)Weekdays.Thursday}");
            //Console.WriteLine($"The day is {Weekdays.Friday} and the number is {(int)Weekdays.Friday}");    
            #endregion

            #region Question-1
            // because it helps to determine a specific number for each value in the enum that can make logic in any case instead of the default 
            // numbering. also when adding or deleting a value in the enum, this will change the number accompined to value unless it was entered manually,
            // then it will never be changed. this increases readability and applies more logic to the code.
            #endregion

            #region Problem-2
            //foreach (Grades grade in Enum.GetValues(typeof(Grades)))
            //{
            //    Console.WriteLine($"the grade is {grade} and the number is {(short)grade}");
            //}
            #endregion

            #region Question-2
            // it will make a compiler error and won't run and would say that the constant value can't be converted to this datatype
            #endregion

            #region Problem-3
            //Person P1 = new Person("HR");
            //Person P2 = new Person("Security");
            //Console.WriteLine(P1);
            //Console.WriteLine(P2);
            #endregion

            #region Question-3
            // it allows the property to be overriden in inherited classes which can change its functionality and performance with same name as a type of 
            // polymorphism.
            #endregion

            #region Problem-4
            //Parent Parent1 = new Parent(5588);
            //Child Child1 = new Child(6521);
            //Parent1.DisplaySalary();
            //Child1.DisplaySalary();
            #endregion

            #region Question-4
            // as word sealed prohibites any modification in inherited classes so the override can't be done.
            #endregion

            #region Problem-5
            //Console.WriteLine(Utility.RectanglePremiter(5,9));
            #endregion

            #region Question-5
            // static member: it can be called without instancing the class it's in it as they related to the class itself and doesn't do any variable procedure 
            // object member: it can't be called without instancing the class it's in it as they are related to an instance in the class.
            #endregion

            #region Problem-6
            //ComplexNumber Complex1 = new ComplexNumber() {Real = 6, Imag =3};
            //ComplexNumber Complex2 = new ComplexNumber() {Real = 2, Imag =5};  
            //Console.WriteLine($"The multiplication result is {Complex1*Complex2}");
            #endregion

            #region Question-6
            // we can't override all operators because there are restrictions on some operators and some can't logically be overriden
            // we can't override as it's logically won't make any sense to change the behaviour of assigning the RHS of it to LHS.  
            #endregion

            #region Problem-7
            ////Gender default uses 4 bytes in memory which can save 1024 values to store 2 values only: more used space for nothing
            //Console.WriteLine(Gender.Male);
            //Console.WriteLine(Gender.Female);
            ////Gender uses 1 bytes in memory which can save 256 values to store 2 values only: more optimum  
            //Console.WriteLine(GenderDefault.Male);
            //Console.WriteLine(GenderDefault.Female);
            #endregion

            #region Question-7
            // when the enum is used regurally and you want to save space in memory and increase performance in case os little number of values.
            // when the number of values is out of range of underlying type.
            #endregion

            #region Problem-8
            //Console.WriteLine(Utility.CelsiusToFahrenheit(10));
            #endregion

            #region Question-8
            // because we won't instance them as they are a container for static methods only, so why would we need a ctor.
            #endregion

            #region Problem-10
            //Department marketing = new Department("Marketing");
            //Department hr = new Department("HR");
            //Department pr = new Department("PR");
            //Employee[] employees = new Employee[]
            //{
            //new Employee(1, "Ali", 3456, 27,hr),
            //new Employee(2, "Omar", 5987, 30, pr),
            //new Employee(3, "Karim", 9878, 22, marketing)
            //};
            //Employee search = new Employee(2, "Omar", 5987, 30,pr);
            //int found = Helper2<Employee>.SearchArray(employees , search);
            //{ Console.WriteLine($"Found employee number: {found}"); }
            #endregion

            #region Question-10
            // override == :
            // for class, it checks reference as it checks if the two objects point to same object.
            //            it can be overriden to compare the content of the objects.
            // for struct,it compares the content of the two structs, it's a built-in overriden from system.valuetype .

            // override Equals:
            // for class, it checks reference as it checks if the two objects point to same object.
            //            It can be overridden to compare the content of objects.
            // for struct, it compares the content of two structs. it Can be overloaded to provide custom equality logic. 
            #endregion

            #region Question-11
            // It's used to change the behaviour of ToString from Namespace.Class into any behaviour I want that helps in the problem.
            #endregion

            #region Problem-12
            //int number1 = 10, number2 = 20;
            //Helper.Max<int>(number1,number2);
            //double number3 = 15.52, number4 = 10.75;
            //Helper.Max<double>(number3,number4);
            #endregion

            #region Question-12
            // it has constrains that determines the type of T used in the static function.
            // its syntax is { where T : class } { where T : interface } 
            #endregion

            #region Problem-13
            //int[] IntArr = { 1, 2, 3, 4, 5, 3, 6 };
            //Helper2<int>.ReplaceArray(ref IntArr, 3, 9);
            //string[] StringArr = { "Karim", "Omar", "Ali", "Othman" };
            //Helper2<string>.ReplaceArray(ref StringArr, "Omar","Moaaz");
            //Console.WriteLine(IntArr[2]);
            //Console.WriteLine(IntArr[5]);
            //Console.WriteLine(StringArr[1]);
            #endregion

            #region Question-13
            //Generic method: it is a method that is defined with type parameters. These type parameters allow the method to work with any data type.
            //                the general type is limited to the scope of method
            //Generic class : it is a class that can work with any data type, and the type parameter is specified when creating an instance of the class.
            //                the general type is limited to the scope of class, it can be used wherever in the class.
            #endregion

            #region Problem-14
            //Rectangle rect1 = new Rectangle(4, 5);
            //Rectangle rect2 = new Rectangle(7, 9);
            //Rectangle.Swap(ref rect1,ref rect2);
            //Console.WriteLine(rect1);
            //Console.WriteLine(rect2);
            #endregion

            #region Question-14
            // as genericity is prefered in any code design. This helps in reuseability and maintainability and reduces redundance and gives clean code.
            #endregion

            #region Problem-15
            //Department marketing = new Department("Marketing");
            //Department hr = new Department("HR");
            //Department pr = new Department("PR");
            //Employee[] employees = new Employee[]
            //{
            //new Employee(1, "Ali", 3456, 27, marketing),
            //new Employee(2, "Omar", 5987, 30, pr),
            //new Employee(3, "Karim", 9878, 22, hr)
            //};
            //Console.WriteLine(Helper2<Employee>.SearchArray(employees,pr));
            #endregion

            #region Question-15
            // it helps when I want to compare two Department objects (for example) for content rather than they are pointing for same object or not.
            // This helps greatly in correcting behaviour of it which enhances readability and comparison functionality.
            #endregion

            #region Problem-16
            //Circle circle1 = new Circle(3, "Red");
            //Circle circle2 = new Circle(7.2, "Green");
            //Circle circle3 = new Circle(3, "Red");
            //if (circle1.Equals(circle2)) Console.WriteLine("The circles are equal");
            //else Console.WriteLine("The circles aren't equal");
            //if (circle1.Equals(circle3)) Console.WriteLine("The circles are equal");
            //else Console.WriteLine("The circles aren't equal");
            //Console.WriteLine();
            //if(circle1==circle2) Console.WriteLine("The circles are equal");
            //else Console.WriteLine("The circles aren't equal");
            //if(circle1==circle3) Console.WriteLine("The circles are equal");
            //else Console.WriteLine("The circles aren't equal");
            //Console.WriteLine();
            //Console.WriteLine();
            //CircleClass circle4 = new CircleClass(3, "Red");
            //CircleClass circle5 = new CircleClass(7.2, "Green");
            //CircleClass circle6 = new CircleClass(3, "Red");
            //if (circle1.Equals(circle2)) Console.WriteLine("The circles are equal");
            //else Console.WriteLine("The circles aren't equal");
            //if (circle1.Equals(circle3)) Console.WriteLine("The circles are equal");
            //else Console.WriteLine("The circles aren't equal");
            //Console.WriteLine();
            //if (circle1 == circle2) Console.WriteLine("The circles are equal");
            //else Console.WriteLine("The circles aren't equal");
            //if (circle1 == circle3) Console.WriteLine("The circles are equal");
            //else Console.WriteLine("The circles aren't equal");
            #endregion

            #region Question-16
            // because structs are customized types, so it can compare between anything and store anytype of data inside of it.
            // so it must be implemented manually to determine what do you want from it to compare between.
            #endregion

            //------------------------------------------Part2-------------------------------------//
            #region Problem-1

            //int[] IntegerArray = { 1, 6, 8, 9, 2, 7 };
            //int[] ReversedInt = Part2.ReverseArray<int>(IntegerArray);
            //foreach (int i in ReversedInt) Console.Write($"{i} ");

            //Console.WriteLine();
            //Console.WriteLine();

            //string[] StringArray = { "Karim", "Ali", "Omar", "Abdo", "Othman" };
            //string[] ReversedString = Part2.ReverseArray<string>(StringArray);
            //foreach (string i in ReversedString) Console.Write($"{i} ");

            //Console.WriteLine();
            //Console.WriteLine();

            //Department marketing = new Department("Marketing");
            //Department hr = new Department("HR");
            //Department pr = new Department("PR");
            //Employee[] EmployeeArray = {new Employee(1, "Ali", 3456, 27, marketing),
            //new Employee(2, "Omar", 5987, 30, pr),
            //new Employee(3, "Karim", 9878, 22, hr) };
            //Employee[] ReversedEmployee = Part2.ReverseArray<Employee>(EmployeeArray);
            //foreach (Employee i in ReversedEmployee) Console.WriteLine($"{i} ");
            #endregion

            #region Problem-2
            //Stack<int> IntStack = new Stack<int>();
            //IntStack.Push(10);
            //IntStack.Push(20);
            //IntStack.Push(30);
            //Console.WriteLine($"Peek is {IntStack.Peek()}");
            //Console.WriteLine($"Pop is {IntStack.Pop()}");
            //Console.WriteLine($"Peek after pop is {IntStack.Peek()}");
            //Stack<string> StringStack = new Stack<string>();
            //StringStack.Push("Karim");
            //StringStack.Push("Abdo");
            //StringStack.Push("Omar");
            //Console.WriteLine($"Peek is {StringStack.Peek()}");
            //Console.WriteLine($"Pop is {StringStack.Pop()}");
            //Console.WriteLine($"Peek after pop is {StringStack.Peek()}");
            #endregion

            #region Problem-3
            //int[] IntArray = { 3, 9, 7, 2, 5, 6 };
            //Console.WriteLine($"The element number 2 is {IntArray[1]} and element number 5 is {IntArray[4]}");
            //Part2.Swap(IntArray,1,4);
            //Console.WriteLine($"The element number 2 is {IntArray[1]} and element number 5 is {IntArray[4]}");

            //string[] StArray = { "Karim", "Ali", "Omar", "Abdo", "Othman", "Moaaz" };
            //Console.WriteLine($"The element number 2 is {StArray[1]} and element number 5 is {StArray[4]}");
            //Part2.Swap(StArray, 1, 4);
            //Console.WriteLine($"The element number 2 is {StArray[1]} and element number 5 is {StArray[4]}");

            //Department marketing = new Department("Marketing");
            //Department hr = new Department("HR");
            //Department pr = new Department("PR");
            //Employee[] EmployeeArray = {new Employee(1, "Ali", 3456, 27, marketing),
            //new Employee(2, "Omar", 5987, 30, pr),
            //new Employee(3, "Karim", 9878, 22, hr) };
            //Console.WriteLine($"The element number 1 is {EmployeeArray[0]} and element number 2 is {EmployeeArray[1]}");
            //Part2.Swap(EmployeeArray, 0, 1);
            //Console.WriteLine($"The element number 1 is {EmployeeArray[0]} and element number 2 is {EmployeeArray[1]}");
            #endregion

            #region Problem-4
            //int[] IntArray = { 3, 9, 7, 2, 5, 6 };
            //string[] StArray = { "Karim", "Ali", "Omar", "Abdo", "Othman", "Moaaz" };
            //Console.WriteLine(Part2.FindMax(IntArray));
            //Console.WriteLine(Part2.FindMax(StArray));
            //// can't use Employee as it doesn't implement IComparable 
            #endregion
        }
    }
}
