using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    internal class Employee:Manager
    {
        private string _name;
        private string _employee;
        private float _salary;

        public float Salary
        {
            get => _salary;
            set => _salary = value;
        }

        public string Name 
        { 
            get=>_name;
            set=>_name=value;
        }

        public bool Check()
        {
            return true;
        }


    }
}
