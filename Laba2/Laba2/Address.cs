using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{   
    //Створити клас із ім'ям Address. У тілі класу потрібно створити поля:
    //index, country, city, street, house, apartment. Для кожного поля створити властивість з двома методами доступу.
    //Створити екземпляр класу Address. У поля екземпляра записати інформацію про поштову адресу.
    //Виведіть на екран значення полів, що описують адресу.
    internal class Address
    {
        private int index;
        private string country;
        private string city;
        private string street;
        private int house;
        private int apartament;
        //конструктор класу
        public Address(int index, string country, string city, string street, int house, int apartament)
        {
            setIndex(index);
            setCountry(country);
            setCity(city);      
            setStreet(street);
            setHouse(house);
            setApartament(apartament);
        }
        //переписуємо метод ToString
        public override string ToString()
        {
            return "address: " + getIndex() + ", " + getCountry() + ", " + getCity() + ", " + getStreet() + " " +
                getHouse() + "/" + getApartament();
        }
        public int getIndex ()
        {
            return index;
        }
        public void setIndex(int index)
        {
            this.index = index;
        }
        public string getCountry()
        {
            return country;
        }
        public void setCountry(string country)
        {
            this.country = country;
        }
        public string getCity ()
        {
            return city;
        }
        public void setCity(string city)
        {
            this.city = city;
        }
        public string getStreet()
        {
            return street;
        }
        public void setStreet(string street)
        {
            this.street = street;
        }
        public int getHouse()
        {
            return house;
        }
        public void setHouse(int house)
        {
            this.house = house;
        }
        public int getApartament()
        {
            return apartament;
        }
        public void setApartament(int apartament)
        {
            this.apartament = apartament;
        }
    }
}
