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
                Console.WriteLine("SSN: " + person.SSN + " " + "Name: " + person.Name + " " + "Address: " + person.Address + "  " + "Age: " + person.Age);
            }
        }
    }
}