using System;

namespace LambdaProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome In Lambda Problem");
            PersonDetails personDetails = new PersonDetails();  
            int input;
            do
            {
                Console.WriteLine("\n1: Add Details");
                Console.WriteLine("2: Retrieve top 2 records from the list for age is less than 60");
                Console.WriteLine("3: Retrieve all record from the list for age between 13 to 18");
                Console.WriteLine("4: Retrieve Average age in the list");
                Console.WriteLine("5: Check for specific name present in the list or not");
                Console.WriteLine("0: Exit");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        personDetails.AddDetails();
                        break;
                    case 2:
                        personDetails.RetrieveTopTwoRecords();
                        break;
                    case 3:
                        personDetails.AgeInBetween();
                        break;
                    case 4:
                        personDetails.AverageOfAges();
                        break;
                    case 5:
                        personDetails.FindPerson();
                        break;
                    case 0:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Invalid Input:----Please Enter Correct Input");
                        break;
                }
            }
            while (input != 0);   
        }
    }
}