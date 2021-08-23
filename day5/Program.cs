using System;
using day5.Models;
namespace day5
{
    class Program:Supplier
    {
        static void Main(string[] args)
        {
           var obj=new Employee();
           obj.EmployeeId=100;//(Encapsulation)set is working and value is going to value keyword
           Console.WriteLine(obj.EmployeeId);
           obj.EmployeeSalary=30000.45;
           Console.WriteLine(obj.EmployeeSalary);
           var obj1=new Program();
           // error (var obj2=new Supplier();)
           obj1.sid=200;
        }
    }
}
