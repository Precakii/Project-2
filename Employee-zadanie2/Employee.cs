using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_zadanie2
{
    public abstract class Employee
    {
        protected string name; //име на работника
        protected char workertype; //'М'-Manager; 'E'-Expert; 'W'-Worker
        protected int tasksCounter; //брой задачи
        protected float successRate; //успеваемост
        protected Employee managerOwner;
        protected int k;
        protected bool taskSucceeded;

        public Employee(string name, char Workertype, int k, float successRate, bool taskSucceeded, Employee ManagerOwner)
            {
            this.workertype = Workertype;
            this.name = name;
            this.successRate = 0;
            this.k = 0;
            this.taskSucceeded = taskSucceeded;
            this.managerOwner = ManagerOwner;
        }

        protected Employee(char workertype, string name, int k)
        {
            this.workertype = workertype;
            this.name = name;
            this.k = k;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public char WorkerType
        {
            get { return this.workertype; }
            set { this.workertype = value; }
        }

        public Employee managerOwner
        {
            get { return this.managerOwner; }
            set { this.managerOwner = value; }
        }

        public int TasksCounter
        {
            get { return this.tasksCounter; }
            set { this.tasksCounter = value; }
        }
        public float SuccessRate
        {
            get { return this.successRate; }
            set { this.successRate = value; }
        }
        public int K
        {
            get { return this.k; }
            set { this.k = value; }
        }

        public abstract bool Execute();
        public abstract bool Success();

    }
}
