using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    //Створити клас Employee. У тілі класу створити власний конструктор, який приймає два рядкові аргументи,
    //і ініціалізує поля, що відповідають прізвищу та імені співробітника.
    //Створити метод, що розраховує оклад співробітника (залежно від посади та стажу) та податковий збір.
    //Написати програму, яка виводить на екран інформацію про співробітника (прізвище, ім'я, посада),
    //оклад та податковий збір.
    internal class Employee
    {
        string name;
        string surname;
        string position;
        int experience;

        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public void Information()
        {
            //qa, software engineer, project manager, graphic designer,
            int salary = 350;
            double taxcollection = 0;

            Console.Write("Enter position(qa, software engineer, project manager, graphic designer): ");
            position = Console.ReadLine();
            Console.Write("Enter experience: ");
            experience = Int32.Parse(Console.ReadLine());

            if (position.Equals("qa"))
            {
                salary = 350;
            }
            else if (position.Equals("graphic designer"))
            {
                salary = 380;
            }
            else if (position.Equals("project manager"))
            {
                salary = 400;
            }
            else if (position.Equals("software engineer"))
            {
                salary = 450;
            }
            else
            {
                Console.WriteLine("Unknown position");
                return;
            }

            if (experience >= 1 && experience < 2)
            {
                salary += 100;
            }
            else if (experience >= 2 && experience < 3)
            {
                salary += 200;
            }
            else if (experience >= 3)
            {
                salary += 500;
            }

            taxcollection = salary * 0.05;
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Surname: " + surname);
            Console.WriteLine("Position: " + position);
            Console.WriteLine("Expirience: " + experience);
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("Taxcollection: " + taxcollection);
        }

    }
}