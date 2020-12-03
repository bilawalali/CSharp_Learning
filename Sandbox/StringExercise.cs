using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Sandbox
{
    class StringExercise
    {
        public void Exercise1()
        {
            /* Write a program and ask the user to enter a few numbers separated by a hyphen.
             * Work out if the numbers are consecutive.
             * For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive"*/

            bool sequence = true;
            Console.WriteLine("Enter numbers: ");
            string[] input = Console.ReadLine().Split('-');

            int[] numbers = Array.ConvertAll(input, int.Parse);

            for (int i = 1; i < numbers.Length; i++)
            {
                
                //if (numbers[i] + 1 == numbers[i - 1] || numbers[i] - 1 == numbers[i - 1] && sequence == true)
                if (numbers[i] + 1 == numbers[i - 1] || numbers[i] - 1 == numbers[i - 1] )
                {
                    sequence = true;
                }
                else 
                {
                    sequence = false;
                }
            }
            
            
            if (sequence)
                Console.WriteLine("Consecutive");
            else
                Console.WriteLine("Not Consecutive");
               


        }

        public void Exercise2()
        {
            /* 
                 Write a program and ask the user to enter a few numbers separated by a hyphen.
                 If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates.
                 If so, display "Duplicate" on the console.
             
             */
            string[] elements;

            while (true)

            {
                Console.WriteLine("Enter a Number");
                var UserInput = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(UserInput))
                {
                    elements = UserInput.Split('-');
                    if (elements.Length >= 5)
                    {

                        break;
                    }
                    Console.WriteLine("Invalid List");
                }

            }
            var numbers = new List<int>();
            
            foreach (var number in elements)
            {
                numbers.Add(Convert.ToInt32(number));
                //Console.WriteLine(number);
                Console.WriteLine("");
            }

            if (numbers.Count != numbers.Distinct().Count())
            {
                Console.WriteLine("Duplicate");
            }
            else
            {
                //IEnumerable<int> distinctNum = numbers.Distinct();
                //foreach (var number in distinctNum)
                //{
                 //   Console.WriteLine(number);
               // }
                Console.WriteLine("Duplicate");

            }
            





        }

        public void Exercise3()
        {
            /* Write a program and ask the user to enter a time value in the 24 - hour time format(e.g. 19:00).
             * A valid time should be between 00:00 and 23:59.If the time is valid, display "Ok"; otherwise, display "Invalid Time".
             * If the user doesn't provide any values, consider it as invalid time.
             */
            bool passed = false;
            DateTime dt;
            Console.WriteLine("Enter a Time");
            var input = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
            }
            else
            {
                try
                {
                    dt = Convert.ToDateTime(input);
                    input = dt.ToString("hh:mm");
                    passed = true;
                    Console.WriteLine("Correct Time");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid Format");
                }
            }
        }

        public void Exercise4()
        {
            /*Write a program and ask the user to enter a few words separated by a space. 
             * Use the words to create a variable name with PascalCase. For example, if the user types: "number of students", display "NumberOfStudents".
             * Make sure that the program is not dependent on the input. So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".*/
        }

        public void Exercise5()
        {
            /*Write a program and ask the user to enter an English word. 
             * Count the number of vowels (a, e, o, u, i) in the word. So,
             * if the user enters "inadequate", the program should display 6 on the console
             */
            int total = 0;
            var vowels = new List<char>() {'a', 'e', 'o', 'u', 'i' };
            Console.WriteLine("Enter a Word");
            var input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (vowels.Contains(input[i]))
                {
                    total++;
                    
                }
            }
            Console.WriteLine(total);
        }

    }
}
