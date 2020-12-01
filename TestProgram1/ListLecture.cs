using System;
using System.Collections.Generic;
using System.Text;

namespace TestProgram1
{
    class ListLecture
    {
        public void ListTutorial()
        {

            // Add new List

            var numbers = new List<int>();

            // Add numbers to list

            numbers.Add(1);
            numbers.Add(7);
            // Add array into list by using Add.Range method

            numbers.AddRange(new int[4] { 1, 2, 3, 4 });
            foreach (var a in numbers)
            Console.WriteLine(a);
            Console.WriteLine("");

            // check the index of both 1s in the list

            Console.WriteLine("Index of 1st 1:" + numbers.IndexOf(1));
            Console.WriteLine("");
            Console.WriteLine("Index of 2nd 1:" + numbers.LastIndexOf(1));
            Console.WriteLine("");
            // Total number of Count in list

            Console.WriteLine("Count: " + numbers.Count);
            Console.WriteLine("");

            // Remove item from the list
            numbers.Remove(4);
            foreach (var e in numbers)
            Console.WriteLine(e);
            Console.WriteLine("");
            // Removed the item from index 2 in list
            numbers.RemoveAt(2);
            foreach (var q in numbers)
            Console.WriteLine(q);
            Console.WriteLine("");
            //Clear the compelete List
            numbers.Clear();
            Console.WriteLine("Count of the List: " + numbers.Count);

        }
    }
}
