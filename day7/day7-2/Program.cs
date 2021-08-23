using System;
using day7_2.Arithmetic;
delegate void ArithmeticDelegate(double N1,double N2);
namespace day7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //first way
            /* ArithmeticDelegate obj=new ArithmeticDelegate(ArithmeticOperation.Addition);
            obj.Invoke(5,4); */


            //Anonymous method(Second Way)
            /*ArithmeticDelegate obj=delegate(double d1,double d2)
           {
               Console.WriteLine("Multiply "+(d1*d2));
           };
           ArithmeticDelegate obj1=delegate(double d1,double d2)
           {
               Console.WriteLine("Division "+(d1/d2));
           }; */



           //Lambda method (third way)
           ArithmeticDelegate obj=(double d1,double d2)=>
           {
               Console.WriteLine("Multiply "+(d1*d2));
           };
           ArithmeticDelegate obj1=(double d1,double d2)=>
           {
               Console.WriteLine("Division "+(d1/d2));
           };
           
           obj(10,20);
           obj1(10,2);
        }
    }
}