using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaProblem
{
    public class PersonDetails
    {
        public List<Person> list = new List<Person>();
        public void AddDetails()
        {
            list.Add(new Person("101", "Yogesh", "Asola", 25));
            list.Add(new Person("102", "Ganesh", "Pune", 15));
            list.Add(new Person("103", "Arjun", "Nagpur", 35));
            list.Add(new Person("104", "Yogesh", "Beed", 65));
            list.Add(new Person("105", "Sachin", "Asola", 45));
            list.Add(new Person("106", "Atish", "Akola", 30));
            list.Add(new Person("107", "Soham", "Mumbai", 85));
            list.Add(new Person("108", "Dipak", "Surat", 70));

            foreach (var person in list)
            {
                Console.WriteLine("SSN: " + person.SSN + "\t" + "Name: " + person.Name + "\t" + "Address: " + person.Address + "\t" + "Age: " + person.Age);
            }
        }
        public void RetrieveTopTwoRecords()
        {
            var Result = list.FindAll(x => (x.Age < 60)).Take(2).ToList();
            foreach (var person in Result)
            {
                Console.WriteLine("SSN: " + person.SSN + "\t" + "Name: " + person.Name + "\t" + "Address: " + person.Address + "\t" + "Age: " + person.Age);
            }
        }
        public void AgeInBetween()
        {
            var result = list.FindAll(x => (x.Age >= 13 && x.Age <= 18));
            foreach (var person in result)
            {
                Console.WriteLine("Id: " + person.SSN + " " + "Name: " + person.Name + " " + "Address: " + person.Address + "  " + "Age: " + person.Age);
            }            
        }
        public void AverageOfAges()
        {
            double res = list.Average(x => x.Age);
            Console.WriteLine("Average of All Ages : " + res);
        }
        public void FindPerson()
        {
            if (list.Exists(x => x.Name == "Yogesh"))
            {
                Console.WriteLine("Yes, Yogesh is in the list");
            }
            else
            {
                Console.WriteLine("No Records Found");
            }
        }
    }
}