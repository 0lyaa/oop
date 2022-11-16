using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    //Створити клас User, що містить інформацію про користувача
    //(логін, ім'я, прізвище, вік, дату заповнення анкети).
    //Поле “дата заповнення анкети” має бути проініціалізоване лише один раз
    //(при створенні екземпляра цього класу) без можливості його подальшої зміни.
    //Реалізуйте виведення на екран інформації про користувача.

    internal class User
    {
        string name;
        string surname;
        string login;
        string password;
        int age;
        string date;

        public User(string date)
        {
            this.date = date;
        }
        public void Information()
        {
            Console.WriteLine("\nInformation about user:");
            Console.WriteLine("User: " + name + " " + surname + " (" + age + " years)");
            Console.WriteLine("Date of registration: " + date);
        }
        public void SetValues()
        {
            string name, surname, login, password;
            int age;
            Console.Write("Enter name: ");
            name = Console.ReadLine();

            while (name.Equals(""))
            {
                Console.WriteLine("Enter name again: ");
                name = Console.ReadLine();
            }

            Console.Write("Enter surname: ");
            surname = Console.ReadLine();

            while (surname.Equals(""))
            {
                Console.Write("Enter surname again: ");
                surname = Console.ReadLine();
            }

            Console.Write("Enter login: ");
            login = Console.ReadLine();

            while (login.Equals(""))
            {
                Console.Write("Enter login again: ");
                login = Console.ReadLine();
            }

            Console.Write("Enter password: ");
            password = Console.ReadLine();

            while (password.Equals(""))
            {
                Console.Write("Enter password again: ");
                password = Console.ReadLine();
            }

            Console.Write("Enter age: ");
            age = Int32.Parse(Console.ReadLine());

            while (age <= 0)
            {
                Console.Write("Enter age again: ");
                age = Int32.Parse(Console.ReadLine());
            }

            this.name = name;
            this.surname = surname;
            this.login = login;
            this.password = password;
            this.age = age;
        }
    }
}
