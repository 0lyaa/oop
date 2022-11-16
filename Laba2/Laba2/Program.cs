using System;

namespace Laba2
{
    public class Program
    {
        public static void Main()
        {
            string currency = "";
            int ss = 0;
            double result = 0;
            bool cycle = true;
            double amount = 0;

            //Створення об'єкту класу
            Address a = new Address(8300, "Ukraine", "Boryspil", "Serova", 7, 8);
            Console.WriteLine(a.ToString());

            Convert b = new Convert(41.5, 39.7, 5.14);
            Console.WriteLine("1.Change uah to another currency");
            Console.WriteLine("2.Change currency to uah");
            Console.Write("Choose an option: ");
            int option = Int32.Parse(Console.ReadLine());

            Console.Write("Enter currency: ");
            currency = Console.ReadLine();

            while (currency != "usd" && currency != "eur" && currency != "cny")
            {
                Console.Write("Currency name is wrong, please enter again: ");
                currency = Console.ReadLine();
            }

            Console.Write("Enter amount: ");
            amount = Double.Parse(Console.ReadLine());

            while (amount <= 0)
            {
                Console.Write("Amount is wrong, please enter again: ");
                amount = Double.Parse(Console.ReadLine());
            }
            if (option == 1)
            {
                result = b.ReverseUah(amount, currency);
            }

            if (option == 2)
            {
                result = b.ConvertInUah(amount, currency);
            }

            Console.WriteLine(result);

            Employee c = new Employee("Василь", "Васильович");
            c.Information();

            User d = new User("07.10.2022");
            d.SetValues();
            d.Information();

        }
    }
}

