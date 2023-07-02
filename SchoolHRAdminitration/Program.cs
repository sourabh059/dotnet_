// See https://aka.ms/new-console-template for more information


using HRAdministrationAPI;
using System;

namespace SchoolHRAdminitration
{
    class program
    {

        static void Main(string[] args)
        {

            decimal totalSalaries =0;
            List<IEmployee> employees = new List<IEmployee>();
            SeedData(employees);
            //foreach (IEmployee employee in employees)
            //{
            //    totalSalaries+=employee.Salary;
            //}

            //Console.WriteLine($"Total Annual Salaries (including bonus) : {totalSalaries}");
            Console.WriteLine($"Total Annual Salaries (including bonus) : {employees.Sum(e=>e.Salary)}");
            Console.ReadKey();
        }

        public static void SeedData(List<IEmployee> employees) 
        {
            IEmployee teacher1 = new Teacher
            {
               Id= 1,
               FirstName="sourabh",
               LastName = "patil",
               Salary = 25000
            };

            employees.Add(teacher1);

             IEmployee teacher2 = new Teacher
             {
                 Id = 2,
                 FirstName = "thunder",
                 LastName = "patil",
                 Salary = 40000
             };
            employees.Add(teacher2);

            IEmployee headOfDepartment = new HeadOfDepartment
            {
                Id = 3,
                FirstName = "clouud",
                LastName = "gk",
                Salary = 50000
            };

            employees.Add(headOfDepartment);

            IEmployee deputyHeadMaster = new DeputyHeadMaster
            {
                Id = 4,
                FirstName = "lighting",
                LastName = "gk",
                Salary = 60000
            };

            employees.Add(deputyHeadMaster);
        }
        
    }

    public class Teacher : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.02m);  }
    }

    public class HeadOfDepartment : EmployeeBase 
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.03m); }
    }

    public class DeputyHeadMaster : EmployeeBase
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.04m); }
    }

    public class HeadMaster : EmployeeBase 
    {
        public override decimal Salary { get => base.Salary + (base.Salary * 0.05m); }
    }
  
}


