using System;
using miscellaneous.IT;
namespace miscellaneous
{
    class Program
    {
        static void Main(string[] args)
        {
            var Sukhdev = new Taazaa(100, 10000);
            var Rakesh = new Taazaa(100, 5000);
            var Rahul = new Taazaa(100, 9000);
            var SalarySukhdev = Sukhdev.empSalary();
            Console.WriteLine(SalarySukhdev);

            var SalaryRahul = Rahul.empSalary();
            Console.WriteLine(SalaryRahul);

            var SalaryRakesh = Rakesh.empSalary();
            Console.WriteLine(SalaryRakesh);
            /*             var Cafetaria=Taazaa.CafeFun();
                        Console.WriteLine(Cafetaria);  1st way of getting value*/
            Console.WriteLine(Taazaa.CafeFun()); // 2nd way of getting value
        }
    }
}
