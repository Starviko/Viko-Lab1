using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lab1
{
    internal class Person
    {
        private int personId;
        private string firstName;
        private string lastName;
        private int age;
        private string favoriteColor;
        private bool isWorking;

        public int PersonId { get=>age; set => age = value; }
        public string FirstName { get=> firstName; set => firstName = value; }
        public string LastName { get=> lastName; set => lastName = value; }
        public int Age { get=> age; set => age = value; }
        public string FavoriteColor { get => favoriteColor;set=> favoriteColor = value; }
        public bool IsWorking { get => isWorking; }

        public Person(int personId, string firstName, string lastName, int age, string favoriteColor, bool isWorking)
        {
            this.personId = personId;
            this.firstName = firstName;               
            this.lastName = lastName;
            this.age = age;               
            this.favoriteColor = favoriteColor;
            this.isWorking = isWorking;
        }

        public void DisplayPersonInfo()
        {
            int personId = this.personId;
            string firstName = this.firstName;
            string lastName = this.lastName;
            string name = firstName +" "+ lastName;
            string favoriteColor = this.favoriteColor;
            Console.WriteLine(personId+ ": " + name+"'s favorite colour is "+favoriteColor);
        }
        
        public string ChangeFavoriteColor()
        {
            this.favoriteColor = "White";
            string color = this.favoriteColor;
            return color;
        }

        public void GetAgeInTenYears()
        {
            //string firstName = this.firstName;
            string lastName = this.lastName;
            string name = firstName +" " +lastName;
            int age10 = this.age + 10;
            Console.WriteLine(name + "'s Age in 10 years is: " + age10);
        }

        public override string ToString()
        {
            int personId = this.personId;
            string firstName = this.firstName;
            string lastName = this.lastName;
            int age = this.age;
            string favoriteColor = this.favoriteColor;
            bool isWorking = this.isWorking;
            return "PersonId: " + personId + "\nFirstName: " + firstName + "\nLastName: " + lastName
                + "\nFavoriteColor: " + favoriteColor + "\nAge: " + age
                + "\nIsWorking: " + isWorking;
        }

    }
}
