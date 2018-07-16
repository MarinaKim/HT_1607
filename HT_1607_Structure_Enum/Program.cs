using HT_1607_Structure_Enum.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT_1607_Structure_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter task num:");
            int num = Int32.Parse(Console.ReadLine());

            switch (num)
            {
                /* 1.	Создать массив сотрудников. Длина массива задается пользователем, заполнение массива производится им же. Выполнить следующее:
a.	вывести полную информацию обо всех сотрудниках;
b.	найти в массиве всех менеджеров, зарплата которых больше средней зарплаты всех клерков, вывести на экран полную информацию о таких менеджерах отсортированной по их фамилии.
c.	распечатать информацию обо всех сотрудниках, принятых на работу позже босса, отсортированную в алфавитном порядке по фамилии сотрудника.
*/
                case 1:
                    {
                        ServiceEmployer se=new ServiceEmployer();
                        se.CreateEmployer();
                        foreach (Employer item in se.employers)
                        {
                            Console.WriteLine(item);
                        }

                        Console.WriteLine("----------------------------------------------------");

                        foreach (Employer item in se.FindManger(prof.clerk))
                        {
                            Console.WriteLine(item);
                        }
                       


                    }break;

            }
        }
    }
}
