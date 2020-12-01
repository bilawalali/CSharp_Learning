using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TestProgram1
{
    class ListExercise
    {


        /* When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

            If no one likes your post, it doesn't display anything.
            If only one person likes your post, it displays: [Friend's Name] likes your post.
            If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
            If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
            Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). 
            Depending on the number of names provided, display a message based on the above pattern.
        
         */
        public void Exercise1()
        {

            var names = new List<string>();

            while (true)
            { 

            Console.WriteLine("Enter Names: ");
            var UserInput = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(UserInput))
               break;

                names.Add(UserInput);
            }
            if (names.Count > 2)
            {
                Console.WriteLine("{0}, {1} and {2} others like your post", names[0], names[1], names.Count - 2);
            }

            else if (names.Count == 2)
            {
                Console.WriteLine("{0}, {1} like your post", names[0], names[1]);
            }
            else if (names.Count == 1)
            {
                Console.WriteLine("{1} like your post", names[0]);
            }




        }
        /* 
         * Write a program and ask the user to enter their name. 
         * Use an array to reverse the name and then store the result in a new string. 
         * Display the reversed name on the console.
         * */
        public void Exercise2()
        {
            Console.WriteLine("Enter the name: ");
            var UserInput = Console.ReadLine();
            string result = new string(UserInput.ToCharArray().Reverse().ToArray());
            foreach (var i in result)
            Console.WriteLine(i);

        }


        /*
         * Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try.
         * Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
         * */
        public void Exercise3()
        {
            var numbers = new List<int>();

            while (numbers.Count<5)
            {
                Console.WriteLine("Enter the Number: ");
                var UserInput = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(UserInput))
                {
                    Console.WriteLine("Number Exist");
                    continue;
                }
                numbers.Add(UserInput);            
            
            }
            numbers.Sort();
            foreach (var a in numbers)
            Console.WriteLine(a);
        }

        /*Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
         * The list of numbers may include duplicates.
         * Display the unique numbers that the user has entered.

        */
        public void Exercise4()
        {
            var numbers = new List<int>();

            while (numbers.Count<5)
            {
                Console.Write("Enter a number (or 'Quit' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;

                numbers.Add(Convert.ToInt32(input));
            }
            
            var unique = numbers.Distinct();
            foreach (var i in unique)
            Console.WriteLine(i);
        }
        /*Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). 
         * If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise,
         * display the 3 smallest numbers in the list.*/


        public void Exercise5()
        {
            string[] elements;

            while (true)
          
            {
                Console.WriteLine("Enter a Number");
                var UserInput = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(UserInput))
                {
                    elements = UserInput.Split(',');
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
            }
            var smallest = new List<int>();
            while(smallest.Count<3)
            {
                var min = numbers[0];
                foreach (var number in numbers)
                    if (number < min)
                    {
                        min = number;
                    }

                smallest.Add(min);
                numbers.Remove(min);

                

            }
            foreach (var number in smallest)
                Console.WriteLine(number);
        }
    }
}
