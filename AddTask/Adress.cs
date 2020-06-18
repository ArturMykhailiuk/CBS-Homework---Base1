using System;
using System.Collections.Generic;
using System.Text;

namespace AddTask
{
    class Adress
    {
        private string index, country, city, street, house, apartment;
              
        public string Index
        {
            set {index = value;}
            get {return index;}
        }
        public string Country
        {
            set { country = value; }
            get { return country; }
        }
        public string City
        {
            set { city = value; }
            get { return city; }
        }
        public string Street
        {
            set { street = value; }
            get { return street; }
        }
        public string House
        {
            set { house = value; }
            get { return house; }
        }
        public string Apartment
        {
            set { apartment = value; }
            get { return apartment; }
        }
    }
}
