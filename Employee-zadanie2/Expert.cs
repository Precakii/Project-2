using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_zadanie2
{
    class Expert:Employee
    {
        public Expert(char workertype, string names, int k) : base ( workertype, names, k)
        {
            this.name = name;
            this.workertype = workertype;
            k = 0;
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
