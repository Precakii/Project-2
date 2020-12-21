using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_zadanie2
{
    class Manager: Employee
    {

        private List<Employee> employees;
        private List<Employee> workers;
        private List<Employee> experts;

        public void PrintStatus()
        {  
            foreach (var employee in employees)  // за всички служители:
            { if (workertype == 'M')
                {
                    Console.WriteLine($"{employee.WorkerType}: {employee.Name}: успеваемост -{employee.SuccessRate} : {k}");
                }
                else { Console.WriteLine($"{employee.WorkerType}: {employee.Name}: успеваемост -{employee.SuccessRate}"); }
            }
            
        }
        public Manager(char workertype, string names, float successRate, int k) : base(workertype, name, float successRate, int k)
        {
            this.workertype = workertype;
            this.name = name;
            this.successRate = successRate;
            this.k = k;
            employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee) //добавя
        { if (workertype== 'E') 
            {
                experts.Add(employee);
            }
            if  (workertype == 'W')
            {
                workers.Add(employee);
            }
            employees.Add(employee);
            PrintStatus();
        }

        public void RemoveEmployee(string names) //премахва
        {
            int index = employees.FindIndex(x => x.Name == names);
            if (workertype == 'E')
            {
                experts.RemoveAt(index);
            }
            if (workertype == 'W')
            {
                workers.RemoveAt(index);
            }
            employees.RemoveAt(index);
            PrintStatus();
        }
        public override bool Execute()
        {
            if (successRate > 0)
            { return true; }
            else { return false; }
        }

        public override bool Success()
        {
                if (successRate > 0 && k > 0 && successRate < 1 && k < 1)
                {
                    return true;
                }
                else { return false; }
            
        }

    }
}
