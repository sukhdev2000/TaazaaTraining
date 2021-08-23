using System;
namespace adv_training.Miscellaneous
{
    public class IT
    {
        //static constructor: which is special kind of constructor 
        //1. we can't pass parameters 
        //2. we can't define scope as like access modifier before the static contructor 3. this is so special kind of contructor which runs before the main function 4. we can initialize static variable and read only variable static contructor is mainly meant for initializing the static read only varaible.
        static IT()
        { }
        public static string companyAddress()
        {
            return "TaazaaNoida";
        }
    }
}