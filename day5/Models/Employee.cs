namespace day5.Models
{
    public class Employee
    {
        private int eid;
        private double salary;
        public int EmployeeId 
        //properties: by properties we can access private variables of class outside the class and we can achieve encapsulation by properties, get and set is accessor.
        {
            get   //access
            {
                return eid;
            }
            set   //assign
            {
                eid=value; //value is a keyword to assign the data to variable.
            }
        }
        public double EmployeeSalary
        {
            get
            {
                return salary;
            }
            set
            {
                salary=value;
            }
        }


    }
}   