using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug30_2017NestedLoopClassPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //a couple regular loop examples

            int x = 1;
            while(x <= 10)
            {
                Console.WriteLine(x);
                x++;
            }

            //a guessing game.
            //fixed chances to guess a number

            int lives = 3; //number of guesses
            int correct = 24; //our number
            bool isPlaying = true;

            while (lives > 0 /*|| isPlaying == true*/) //you just want one OR the other
            {
                Console.WriteLine("Guess the magic number!");
                Console.WriteLine($"You have {lives} guesses left.");
                Console.WriteLine("Hint: the answer is 24.");
                int userGuess = int.Parse(Console.ReadLine());

                if (userGuess == correct)
                {
                    Console.WriteLine("You guessed right.");
                    break; //ends loop if correct. needed only for lives > 0, not bool
                    //isPlaying = false; //use only if you use the bool
                }

                else
                {
                    Console.WriteLine("You guessed wrong. Try again.");
                    lives--;  //removes one from the number of allowed guesses
                }
            }
            //this program could be better -- count down lives and at 0 say no guesses left.
            //but you get the idea

            //class practices:

            //print 1 - 100. FizzBuzz with 3 and 5

            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("Fizzbuzz!");
                }

                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz!");
                }

                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz!");
                }

                else
                {
                    Console.WriteLine(i);
                }
            }

            //create an int array 10 numbers. find the mean, output result

            int[] array = { 10, 20, 30, 40, 50, 50, 60, 70, 80, 90 };
            Console.WriteLine("\nYou're finding the mean of 10 numbers you entered as an array:");
            int sumArray = 0;

            for (int i = 0; i < array.Length; i++) //you could have also used a foreach loop
            {
                sumArray += array[i];
                Console.WriteLine($"Index {i} is {array[i]}. Running total is {sumArray}." );
            }

            double arrayAverage = sumArray / array.Length;

            Console.WriteLine($"The average of the array is {arrayAverage}.");

            //ask user for 2 numbers
            //if second is not larger than first as for two more
            //when m <n, find all numbers multiples of 3 then print those to console.

            Console.WriteLine("\nNow let's print some mulitples of three.");
            Console.WriteLine("Please enter one number.");
            int numN = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter another number.");
            int numM = int.Parse(Console.ReadLine());

            if (numN > numM)
            {
                Console.WriteLine("\nOops your second number should be larger than your first number.");
                Console.WriteLine("Please enter a new first number.");
                numN = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter a new second number.");
                numM = int.Parse(Console.ReadLine());
            }

            for (int digit = numN; digit <= numM; digit++)
            {
                if (digit % 3 == 0)
                {
                    Console.Write(" " + digit);
                }

                else
                {
                    continue;
                }
            }

            //break the three-digit lock.
            //you get five tries per digit

            Console.WriteLine("\nYou need to open the lock. It's got three numbers between 0 and 35. You get five tries each.");

            int correct1 = 30;
            int correct2 = 8;
            int correct3 = 25;

            int guess1 = 0;
            int guess2 = 0;
            int guess3 = 0;

            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine("What's your guess for the first number?");
                guess1 = int.Parse(Console.ReadLine());
            }



            Console.ReadLine();
        }
    }
}
