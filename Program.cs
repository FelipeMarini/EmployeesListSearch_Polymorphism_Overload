using System;
using EmployeesListSearch_Polymorphism_Overload.Classes;

namespace EmployeesListSearch_Polymorphism_Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee emp = new Employee();

            emp.Show();
            emp.Show("Carlos");
            emp.Show(2);

            Console.Beep(800,2000);

        }
    }
}
