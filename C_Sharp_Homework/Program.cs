using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Homework
{
    class Program
    {
        struct Employees
        {
            public string Name;
            public int Age;
            public string Male;
            public int Salary;

            public Employees(string Name, int Age, string Male, int Salary)
            {
                this.Name = Name;
                this.Age = Age;
                this.Male = Male;
                this.Salary = Salary;
            }

            public void Print()
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Имя: {Name}\nВозраст: {Age}\nПол: {Male}\nЗарплата: {Salary}");
            }

        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Введите количество сотрудников: ");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Employees[] employees = new Employees[size];

            for (int i = 0; i < employees.Length; i++)
            {
                Console.Write("Введите имя: ");
                employees[i].Name = Console.ReadLine();
                Console.Write("Введите возраст: ");
                employees[i].Age = int.Parse(Console.ReadLine());
                Console.Write("Введите пол: ");
                employees[i].Male = Console.ReadLine();
                Console.Write("Введите зарплату: ");
                employees[i].Salary = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            Console.WriteLine();

            //Menu
            Console.WriteLine("1. Отображение информации");
            Console.WriteLine("2. Средняя зарпата");
            Console.WriteLine("3. Список сотрудников которых больше средней зарплаты\n");

            int Choise = int.Parse(Console.ReadLine());

            int SumSalary = 0; //Сумма всех зарплат
            double AvgSalary;  //Средняя зарплата

            //Show employees
            if (Choise == 1)
            {
                for (int i = 0; i < employees.Length; i++)
                {
                    employees[i].Print();
                    Console.WriteLine();
                }
            }

            //Средняя зарплата
            if (Choise == 2)
            {
                for (int i = 0; i < employees.Length; i++)
                {
                    SumSalary += employees[i].Salary;
                }
                AvgSalary = SumSalary / employees.Length;
                Console.WriteLine("Средняя зарплата: {0}", AvgSalary);
            }

            //Список сотрудников которых больше средней зарплаты
            if (Choise == 3)
            {
                for (int i = 0; i < employees.Length; i++)
                {
                    SumSalary += employees[i].Salary;
                }
                AvgSalary = SumSalary / employees.Length;
                for (int i = 0; i < employees.Length; i++)
                {
                    if (employees[i].Salary > AvgSalary)
                    {
                        employees[i].Print();
                        Console.WriteLine();
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
