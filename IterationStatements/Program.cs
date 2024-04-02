using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace IterationStatements 
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        //Write a method to accept two integers as parameterss and check whether they are equal or not

        //Write a method to check whether a given number is even or odd

        //Write a method to check whether a given number is positive or negative

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            PrintThousand();

            threes();

            Console.WriteLine(counterTwo(2, 8));

            IsNumberEvenOrOdd();

            PositiveOrNegative();

           Console.WriteLine(CanPersonVote(15));

            IsNumberInRange();

            MultiplicationTable();
        }
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }

        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        public static void threes()
        {
            for (int k = 3; k <= 999; k += 3)
            {
                Console.WriteLine(k);
            }



        }

        //Write a method to accept two integers
        //as parameterss and check whether they are equal or not

        public static bool counterTwo(int a, int b)
        {
            var check = (a == b) ? true : false;
            return check;
        }

        //Write a method to check whether a given number is even or odd

        public static void IsNumberEvenOrOdd()
        {
            Console.WriteLine("Please enter a number, and i will check if its even or odd");
            int userInput = int.Parse(Console.ReadLine());
            if(userInput % 2 == 0)
            {

                Console.WriteLine($"{userInput} is even");
            }
            else
            {
                Console.WriteLine($"number is odd.");
            }
        }
        
            



        //Write a method to check whether a given number is positive or negative
        public static void PositiveOrNegative()
        {
            Console.WriteLine("Please enter in a number." +
                " I will check to if its positive or negative;");
            int number = int.Parse(Console.ReadLine());
            
            if (number > 0)
            {
                Console.WriteLine("Number is positive");
            }
            else
            {
                Console.WriteLine("Number is negative");
            }
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        public static bool CanPersonVote(int age)
        {
            if(age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }



        }

        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void IsNumberInRange()
        {
            Console.WriteLine("Please enter in a number. I will check to see if its in range");
            int number = int.Parse(Console.ReadLine());

            if(number >= -10 && number <= 10)
            {
                Console.WriteLine("Please enter in a number. I will check to see if its in range");
            }
            else
            {
                Console.WriteLine("Number is NOT in range");
            }
        
        }   



        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultiplicationTable()
        {
            for(int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} x {7} = {i*2}");
            }
                    
                    
                    
        }















































    }
}
