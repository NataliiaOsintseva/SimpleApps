using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corporation
{
    public class Employee {

        private readonly string name, surname;
        private string position;
        private int experience;

        public string Name {
            get { return name; }
        }

        public string Surname {
            get { return surname; }
        }

        public string Position {
            set {
                if (value!= null)
                    position = value; }
            get {
                if (position == null)
                    return "Должность не указана";
                return position; }
        }

        public int Experience {
            set { experience = value; }
            get { return experience; }
        }

        public Employee(string name, string surname) {
            this.name = name;
            this.surname = surname;
        }

        public double SalaryCalc() {

            double salary;

            switch (position) {
                case "manager":
                    salary = 6000;
                    break;
                case "hr":
                    salary = 4000;
                    break;
                case "analyst":
                    salary = 8000;
                    break;
                default:
                    salary = 3000;
                    break;
            }

            switch (experience) {
                case 5:
                    salary *= 2.70;
                    break;
                case 4:
                    salary *= 2.40;
                    break;
                case 3:
                    salary *= 2;
                    break;
                case 2:
                    salary *= 1.6;
                    break;
                case 1:
                    salary *= 1.3;
                    break;
                case 0:
                    salary *= 1;
                    break;
                default:
                    salary *= 3.2;
                    break;
            }
            return salary;
        }

        public void WriteSalary() {
            Console.WriteLine("Зарплата: {0}, НДС: {1} ", SalaryCalc(), SalaryCalc()*0.18);
        }
    }
}
