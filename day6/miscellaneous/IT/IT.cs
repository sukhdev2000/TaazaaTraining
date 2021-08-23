namespace miscellaneous.IT
{
    public class Taazaa
    {
        double Salary;//concerned with object
        readonly int Eid;//concerned with object
        static string Cafetaria;//common for all means for class
        public Taazaa(int Eid, double Sal)
        {
            Salary=Sal;
            this.Eid=Eid;
        }
        static Taazaa()
        {
            Cafetaria="100 Sqft";
        }
        public int EmployeeID()//memeber function
        {
            return Eid;
        }
        public static string CafeFun()
        {
            return Cafetaria;
        }
        public double empSalary()//memeber function
        {
            return Salary;
        }
    }
}