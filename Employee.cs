using System;
using System.Collections.Generic;
using System.Text;

namespace Homework18042022.Models
{
    class Employee
    {
        public static int id = 1;
        public string Fullname { get; set; }
        public int Salary { get; set; }
        public string Position { get; set; }
        public int No;
        public Employee(string fullname,int salary,string position)
        {
            No = id;
            id++;
            Fullname = fullname;
            Salary = salary;
            Position = position;
            
        }
    }
}
