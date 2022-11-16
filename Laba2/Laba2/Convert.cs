using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    //Створити клас Converter. У тілі класу створити користувальницький конструктор, який приймає три аргументи,
    //і ініціалізує поля, що відповідають курсу 3-х основних валют, по відношенню
    //до гривні – public Converter (double usd, double eur, double rub).
    //Написати програму, яка виконуватиме конвертацію з гривні в одну із зазначених валют, також
    //програма повинна проводити конвертацію із зазначених валют у гривню.
    internal class Convert
    {
        private double usd;
        private double eur;
        private double cny; // yuan
        private double uah;

        public Convert(double usd, double eur, double cny)
        {
            SetUsd(usd);
            SetEur(eur);
            SetCny(cny);

        }

        // вик
        public double ReverseUah(double amount, string currency)
        {
            if (amount <= 0)
            {
                return -2;
            }

            if (currency.Equals("usd"))
            {
                return Math.Round(amount / usd, 3);

            }
            else if (currency.Equals("eur"))
            {
                return Math.Round(amount / eur, 3);
            }
            else if (currency.Equals("cny"))
            {
                return Math.Round(amount / cny, 3);
            }
            else
            {
                return -1;
            }
        }

        public double ConvertInUah(double amount, string currency)
        {
            if (amount <= 0)
            {
                return -2;
            }

            if (currency.Equals("usd"))
            {
                return amount * usd;

            }
            else if (currency.Equals("eur"))
            {
                return amount * eur;
            }
            else if (currency.Equals("cny"))
            {
                return amount * cny;
            }
            else
            {
                return -1;
            }
        }

        public void SetUsd(double usd)
        {
            this.usd = usd;
        }

        public void SetEur(double eur)
        {
            this.eur = eur;
        }
        public void SetCny(double cny)
        {
            this.cny = cny;
        }
        public void SetUah(double uah)
        {
            this.uah = uah;
        }
    }
}