using System;
using day8.Models;
using day8.Proper_Model;
using System.Collections;
using System.Collections.Generic;
namespace day8
{
    class Program
    {
        static void Main(string[] args)
        {
            ContactList obj=new ContactList();
            //var temp=obj.createContact();   first way
           /*  foreach(var i in obj1)
            {
                Console.WriteLine(i.Id+" "+i.Name);
            }
             */
             int ch=0;
             while(ch>=0&&ch<4)
             {
                 System.Console.WriteLine("Which action you want to perform??\n");
                 System.Console.WriteLine("1.) Add\n 2.) Update\n 3.) Delete\n 4.) Exit");
                 switch(ch)
                 {
                 case 1:
                 System.Console.WriteLine("Enter the Id");
                 int id=Convert.ToInt32(Console.ReadLine());
                 obj.createContact(id);
                 break;
                 }
             }
             
        }
    }
}
