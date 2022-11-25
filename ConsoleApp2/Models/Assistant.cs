using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    internal class Assistant
    {
        private string _employee;
        private float _salary;

        public float Salary
        {
            get => _salary;
            set => _salary = value;
        }
        public void GetFeedBack(Employee employee)
        {
            bool result = true;

            if (employee)
            {
                return;
            }

        }
    }
}
