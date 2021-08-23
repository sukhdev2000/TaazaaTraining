using System;

namespace practice
{
    abstract class Taazaa
    {
        public abstract void discipline();
    }
    class Employee:Taazaa
    {
        public override void discipline()
        {
            System.Console.WriteLine("Discipline is very important");
        }
        public void hobby()
        {
            System.Console.WriteLine("Fond of Current affaris!!");
        }
    }
    class first
    {
        public static void Main(String[] args)
        {
            var obj=new Employee();
            obj.discipline();
            obj.hobby();
        }
    }
}
