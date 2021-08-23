using System;
using day7.Delegates;
delegate int customDelegate();
namespace day7
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj=new Person();
            customDelegate Cobj=new customDelegate(obj.PNumber);
            Console.WriteLine(Cobj.Invoke());
            Cobj-=obj.Walk;
            Console.WriteLine(Cobj.Invoke());
        }
    }
}
