using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Corporation
{
    
    class Staff {

        Employee employee;
        Employee employee2 = new Employee("ss", "ffff") { Position = "manager", Experience = 5 };


        public void AssignFuckingNames()
        {
            this.employee = new Employee ("Valeriy", "Pirogov");
            this.employee2 = new Employee("Marianna", "Geldshtamdt");
            
            employee.Position = "analyst";
            employee.Experience = 4;           
            employee2.Experience = 7;
        }

        public void ShowFuckingInfo() {
            Console.WriteLine("Employee 1: {0} {1}\nPosition: {2}\n", employee.Name, employee.Surname, employee.Position);
            employee.WriteSalary();

            Console.WriteLine("\nEmployee 2: {0} {1}\nPosition: {2}\n", employee2.Name, employee2.Surname, employee2.Position);
            employee2.WriteSalary();
        }
    }
}
