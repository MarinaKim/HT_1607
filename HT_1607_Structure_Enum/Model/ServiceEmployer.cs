using GeneratorName;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT_1607_Structure_Enum.Model
{
    public struct ServiceEmployer
    {
        public List<Employer> employers;
     
        public void CreateEmployer()
        {
            Random rnd = new Random();
            Generator gen = new Generator();

            employers = new List<Employer>();
            Console.Write("Enter count of people: ");
            int count = Int32.Parse(Console.ReadLine());
            for ( int i = 0; i < count; i++)
            {              
                Employer em = new Employer();
               em.Name= gen.GenerateDefault((Gender)rnd.Next(2))
                 .Replace("<center><b><font size=7>", "")
                 .Replace("</font></b></center>", "")
                 .Replace("\n", "")
                 .Substring(1);

                em.Prof = (prof)rnd.Next(3);
                em.Age = rnd.Next(19, 40);
                em.DateIn = DateTime.Now.AddMonths(rnd.Next(1, 50));
                em.Salary = rnd.Next(100000,500000);

                employers.Add(em);
            }
        }

        public List<Employer> FindManger(prof x)
        {
            int g=employers.Where(w => w.Prof == x).Sum(s=>s.Salary);

            int c = employers.Where(w => w.Prof == x).Count();

            double avg = g / c;

            List<Employer> managers =employers.Where(w => w.Prof == prof.manager && w.Salary > avg).ToList();

            return managers.OrderBy(o=>o.Name).ToList();//сортировка по имени
        }

    }
}
