using System;
using System.Collections.Generic;
using System.Text;

namespace TestProgram1
{
    class StringLecture
    {

        public void String_Lecture()
        {
        //Each Trim method returns the new string , and string is immutable.
        // Trim method removes the whitespaces from the string fullName , {0} is the placeholder .
        var fullName = "Bilawal Wajid Ali    ";
        Console.WriteLine("Trim: '{0}'", fullName.Trim());

        //ToUpper
        Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

        //ToLower
        Console.WriteLine("ToLower: '{0}'", fullName.Trim().ToLower());

        // Split the name string into two parts using split method.

        var names = fullName.Split();
        Console.WriteLine("FirstName: " + names[0]);
        Console.WriteLine("MiddleName : " + names[1]);
        Console.WriteLine("LastName : " + names[2]);

        //Split the name string into two parts without using the split method.

        var index = fullName.IndexOf("Wajid");
        var firstName = fullName.Substring(0,index+5);
        var lastName = fullName.Substring(13);

        Console.WriteLine("FirstName: " + firstName);
        Console.WriteLine("LastName: " + lastName);

        //Replace a string name with the other string
        Console.WriteLine(fullName.Replace("Bilawal", "Bilawall"));

        //String is Null or WhiteSpace
        if (String.IsNullOrWhiteSpace(""))
            Console.WriteLine("Invalid");
        //Convert String into numbers
        var str = "25";
        var age = Convert.ToByte(str);
        Console.WriteLine(age);

        //Conver number into String

        float price = 29.123f;
        Console.WriteLine(price.ToString());

        }
        public void Summary_Text()
        {

            var text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.";
            const int max_length = 20;
            if (text.Length < max_length)
                Console.WriteLine(text);
            else
            {
                // To summarize the long text we use substring method.
                var new_text= text.Substring(0, max_length);
                //by using substring method the words are not complete in the text , therefore we use split method to break the sentence in the word and the summarize the text.
                // words is string array here.
                var words = text.Split(' ');
                var tot_characters = 0;
                // Here we need one list which dynamically store the summarywords
                var summarywords = new List<String>();
                //Loop over the words array and adds in the tot_characters.
                foreach(var word in words)
                {
                    //Add word in the list.
                    summarywords.Add(word);
                    //length + 1 is for space after the word.
                    tot_characters += word.Length + 1;
                    //If the word limit exceeds the 20 characters it will get out of the loop
                    if (tot_characters > max_length)
                        break;
                }

                // create a new string and join all the words with whitespace.
                Console.WriteLine(String.Join(" ", summarywords)+"..."); 




            }


        }
  }

}
