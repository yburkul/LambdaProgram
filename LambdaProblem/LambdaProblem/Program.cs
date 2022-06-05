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