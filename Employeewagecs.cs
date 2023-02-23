﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageUsingOops
{
    public class Employeewagecs
    {

        public void CheckEmployee()
        {
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int EMP_RATE_PER_HR = 20;

            int empHrs = 0, empWage = 0;

            Random random = new Random();
            int employeeCheck = random.Next(3);

            if (employeeCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Full Time Employee is present");
                empHrs = 8;
            }
            else if (employeeCheck == IS_PART_TIME)
            {
                Console.WriteLine("PartTime Employee is present");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                empHrs = 0;
            }

            empWage = empHrs * EMP_RATE_PER_HR;
            Console.WriteLine("Employee wage is : " + empWage); 

        }
    }
}
