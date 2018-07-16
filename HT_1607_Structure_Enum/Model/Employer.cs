using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT_1607_Structure_Enum.Model
{
    public enum prof { clerk, manager, teamLeader}
    public struct Employer:IEmployer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DateIn { get; set; }
        public prof Prof{get; set;}
        public int Salary { get; set; }

        public Employer (string Name, int Age, DateTime DateIn, prof Prof,int Salary)
        {
            this.Name = Name;
            this.Age = Age;
            this.DateIn = DateIn;
            this.Prof = Prof;
            this.Salary = Salary;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1}) - {2} ({3}) - {4}", Name, Age, Prof, DateIn, Salary);
          
        }
    }
}
