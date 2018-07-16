using HT_1607_Structure_Enum.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT_1607_Structure_Enum
{
    public interface IEmployer
    {
        string Name { get; set; }
        int Age { get; set; }
       DateTime DateIn { get; set; }
        prof Prof { get; set; }
        int Salary { get; set; }
    }
}
