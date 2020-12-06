using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Sandbox
{
    class TextExercise
    {
        public void Exercise1()

        {
            /* Write a program that reads a text file and displays the number of words./
             */

            var path = @"C:\TestOrigin\myFile.txt";
            var content = File.ReadAllText(path);
            Console.WriteLine("Content of the File: " + content);

            string numbers = File.ReadAllText(path);
            Console.WriteLine("Total numbers of the words: " + numbers.Length);

        }

        public void Exercise2()

        {
            /* Write a program that reads a text file and displays the longest word in the file.*/

            

            var path = @"C:\TestOrigin\myFile.txt";
            var content = File.ReadAllText(path);
            Console.WriteLine("Content of the File: " + content);
            var my = content.Split(' ');
            var words = new List<string>(content.Split(new char[] { }));
            Console.WriteLine(words.Count);
            if (words.Count > 0)
            {
                string longestWord = words[0];
                for (int i = 0; i < words.Count; i++)
                {
                    string item = words[i];
                    if(item.Length>longestWord.Length)
                    {
                        longestWord = item;

                    }
                }
                Console.WriteLine(longestWord);
            }
           




        }
    }
}
