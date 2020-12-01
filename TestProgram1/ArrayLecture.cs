using System;
using System.Collections.Generic;
using System.Text;

namespace TestProgram1
{

    
    class ArrayLecture
    {
        
        public void CopyArray()
        {

            var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var duplicate = new int[3];
            Array.Copy(numbers, duplicate, 3);
            foreach (var j in duplicate)
                Console.WriteLine(j);
        }
        public void SortArray()
        {
            var digits = new[] { 1, 22, 13, 44, 51, 36, 17, 68, 93, 110 };
            Array.Sort(digits);
            foreach (var i in digits)
            Console.WriteLine(i);
            
        }
        public void ReverseArray()
        {
            var numbers1 = new[] {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15 };
            Array.Reverse(numbers1);
            foreach (var a in numbers1)
            Console.WriteLine(a);
        
        
        }
        public void ArrayLength()
        {

            var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(numbers.Length);


        }
        public void ArrayIndex()
        {
            var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var index = Array.IndexOf(numbers, 3);
            Console.WriteLine(index);


        }

        public void ArrayClear()
        {
            var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Array.Clear(numbers,0, 3);
            foreach (var b in numbers)
            Console.WriteLine(b);


        }

    }
}
