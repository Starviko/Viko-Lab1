using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1;
            person1 = new Person(1,"Ian","Brooks", 30, "Red",true);

            Person person2;
            person2 = new Person(2, "Gina", "James", 18, "Green", false);
            person2.DisplayPersonInfo();

            Person person3;
            person3 = new Person(3, "Mike", "Briscoe", 45, "Blue", true);
            Console.WriteLine(person3);

            person1.ChangeFavoriteColor();
            person1.DisplayPersonInfo();
            
            Person person4;
            person4 = new Person(4, "Mary", "Beals", 28, "Yellow", true);
            person4.GetAgeInTenYears();

            //make a Person list
            List<Person> persons = new List<Person>();
            persons.Add(person1);
            persons.Add(person2);
            persons.Add(person3);
            persons.Add(person4);
            
            
        }
    }
}
