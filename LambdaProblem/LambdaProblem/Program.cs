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
                Console.WriteLine("\n1: Add Details");               ;
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        personDetails.AddDetails();
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