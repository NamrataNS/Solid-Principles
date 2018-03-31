using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principles

{
# region ------------------------- starts (Existing Class) ----------------

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Employee() { }

        public Employee(int id, string name) { this.ID =id; this.Name = name; }
        public decimal CalBonus(decimal salary)
        {
            return salary * 0.5M;
        }

        //static void Main(string[] args)
        //{

        //    Employee emp1 = new Employee(1, "John");           
        //    emp1.ToString();
        //    decimal result=emp1.CalBonus(1000);
        //    Console.WriteLine("Bonus of John is :" +result );
        //    Console.ReadLine();
        //}
    //Commented above code  due to multiple Main method . Can be uncommented while running this section to view output

    }

    #endregion---------------------------ends------------------


 #region-----------starts (While getting new requirement)-------------------

    //Before Open closed Principle : If the rquirement is to add another employee which will be of Temporary Emp.


    public class Employee1
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string EmpType { get; set; }

        public Employee1() { }

        public Employee1(int id, string name, string emptype) { this.ID = id; this.Name = name; this.EmpType=emptype; }
        public decimal CalBonus1(decimal salary)
        
        {
            if(EmpType =="Permanent") 
            return salary * 0.5M;            
            else 
            return salary * 0.2M; 
        }

        //static void Main(string[] args)
        //{

        //    Employee1 emp1 = new Employee1(1, "John", "Permanent");
        //    Employee1 emp2 = new Employee1(2, "Stephen", "Temporary");
        //    emp1.ToString();        
        //    decimal result1=emp1.CalBonus1(1000);
        //    decimal result2 = emp2.CalBonus1(1000);
        //    Console.WriteLine("Bonus of John is :" +result1 );
        //    Console.WriteLine("Stephen :" + result2);
        //    Console.ReadLine();
        //}
        //Commented above code  due to multiple Main method usage in this Demo. Can be uncommented while running this section to view output

    }

    //if Open closed Principle not followed
    ///1. If a class or a function always allows the addition of new logic, as a developer we end up testing the entire functionality along with the requirement.

    ///2. Also, as a developer we need to ensure to communicate the scope of the changes to the Quality Assurance team in advance so that they can gear up for enhanced regression testing along with the feature testing.

    ///3. Step 2 above is a costly process to adapt for any organization 

    ///4. Not following the Open Closed Principle breaks the SRP since the class or function might end up doing multiple tasks.

    ///5. Also, if the changes are implemented on the same class, Maintenance of the class becomes difficult since the code of the class increases by thousands of unorganized lines./// <summary>
    /// 
    /// </summary>
    /// 


    #endregion------------Ends-----------------*/

   #region -------------------------Starts (Applying Open Closed Principle)----------*/

    //After Open and Colsed Principle

    //    Definition: In object-oriented programming, the open/closed principle states that "software entities such as classes, modules, functions, etc. should be open for extension, but closed for modification"

    //1. Which means, any new functionality should be implemented by adding new classes, attributes and methods, instead of changing the current ones or existing ones.

    //2. Bertrand Meyer is generally credited for having originated the term open/closed principle and This Principle is considered by Bob Martin as “the most important principle of object-oriented design”.

    //Implementation guidelines
    //1. The simplest way to apply OCP is to implement the new functionality on new derived(sub) classes that inherit the original class implementation.

    //2. Another way is to allow client to access the original class with an abstract interface, 

    //3. So, at any given point of time when there is a requirement change instead of touching the existing functionality it’s always suggested to create new classes and leave the original implementation untouched

    public abstract class Employee3
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Employee3()
        {
        }
        public Employee3(int id, string name)
        {
            this.ID = id; this.Name = name;
        }
        public abstract decimal CalculateBonus3(decimal salary);

        public override string ToString()
        {
            return string.Format("ID : {0} Name : {1}", this.ID, this.Name);
        }
    }

    public class PermanentEmployee : Employee3
    {
        public PermanentEmployee()
        { }

        public PermanentEmployee(int id, string name) : base(id, name)
        { }
        public override decimal CalculateBonus3(decimal salary)
        {
            return salary * .1M;
        }
    }

    public class TemporaryEmployee : Employee3
    {
        public TemporaryEmployee()
        { }

        public TemporaryEmployee(int id, string name) : base(id, name)
        { }
        public override decimal CalculateBonus3(decimal salary)
        {
            return salary * .05M;
        }
        static void Main(string[] args)
        {
            Employee3 emp1 = new PermanentEmployee(1, "John");
            Employee3 emp2 = new TemporaryEmployee(2, "Jason");

            Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
                emp1.ToString(),
                emp2.CalculateBonus3(100000).ToString()));
            Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
              emp1.ToString(),
              emp2.CalculateBonus3(150000).ToString()));
            Console.ReadLine();
        }
    }
    #endregion------------End------------
}
