using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace zalupa_project
{
    internal class Program
    {
        public static Timer time;
        static void Main(string[] args)
        {
            Employee zalup = new Employee(null, 0, null);

            try
            {
                kkk(zalup);
            } catch {
                Console.Clear();
                Console.WriteLine("Бро, ошибка");
                Console.ReadKey();    
            }
        }

        static void kkk(Employee zalup)
        {
            Console.WriteLine("Введите ФИО:"); zalup.fio = Console.ReadLine();
            Console.WriteLine("Введите Зарплату:"); zalup.plata = int.Parse(Console.ReadLine());
            Console.WriteLine("Годовая зарплата? yes/no"); zalup.isYear = Console.ReadLine();

            zalup.Show();
        }

        class Employee {
            public string fio;
            public int plata;
            public string isYear;

            public Employee(string fio, int plata, string isYear) { 
                this.fio = fio;
                this.plata = plata;
                this.isYear = isYear;
            }

            public void Show()
            {
                Console.WriteLine("ФИО: " + fio);
                if (isYear == "yes" || isYear == "y") Console.WriteLine("Зарплата за год: " + plata * 12);
                else if (isYear == "no" || isYear == "n") Console.WriteLine("Зарплата месячная: " + plata);
                else Console.WriteLine("Неверно выбран ответ");
            }
        }

    }
}
