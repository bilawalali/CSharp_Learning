using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TestProgram1
{
    class IterationsExercise
    {
        public void Exercise1()
        {
            /* Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.*/

            for (var i=0; i<=100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public void Exercise2()
        {
            /* Write a program and continuously ask the user to enter a number or "ok" to exit.
             * Calculate the sum of all the previously entered numbers and display it on the console..*/
            var sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a Number Or Enter Ok: ");
                var UserInput = Console.ReadLine();

                if (UserInput == "ok")
                    break;
                sum += Convert.ToInt32(UserInput);
                Console.WriteLine(sum);
                
            }

        }

        public void Exercise3()
        {

            /* Write a program and ask the user to enter a number.
             * Compute the factorial of the number and print it on the console.
             * For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
             */
            Console.WriteLine("Enter a Number: ");
            var UserInput = Convert.ToInt32(Console.ReadLine());
            var factorial=1;
            for (var i=1; i<=UserInput;i++)
            {
                factorial *= i;
               
            }
            Console.WriteLine(factorial);

        }

        public void Exercise4()
        {

            /*   
             Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. 
             If the user guesses the number, display “You won". Otherwise, display “You lost".
            */


            var number = new Random().Next(1, 10);

            for (var i=0; i<4; i++)
            {
                Console.WriteLine("Enter a Number: ");
                var UserInput = Convert.ToInt32(Console.ReadLine());
                if (UserInput == number)
                {
                    Console.WriteLine("You Won");
                }
                
            }
        
                Console.WriteLine("You Lost " + number);
            

        }
        public void Exercise5()
        {


            /* Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the 
            /// numbers and display it on the result. For example, if the user enters “5, 3, 8, 1, 4", the program should 
            /// display 8 on the console.*/

            Console.Write("Enter a Number: ");
            var UserInput = Console.ReadLine();
           
            var numbers = UserInput.Split(",");
            
            
            var max = numbers.Max();
            Console.WriteLine(max);

            var min = numbers.Min();
            Console.WriteLine(min);


        }
    }
}
