using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    public class Manager
    {
        private float _salary;

        public float Salary 
        { 
            get=>_salary; 
            set=>_salary=value; 
        }

        protected void GetPromotion(Employee employee)
        {

        }
    }
}
