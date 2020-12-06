using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Sandbox
{
    class WorkingWithFilesLecture
    {

        // file provide static method , file info provide instance method
        public void Lecture()
        {
            // Copy a file from one location to the another.
            //File.Copy("C:\\TestOrigin\\TestImage1.png", "C:\\TestNewOrigin\\TestImage1.jpg",true);
            //var content = File.ReadAllText("C:\\TestOrigin\\myFile.txt");
            //Console.WriteLine(content);

            //Directory and DirectoryInfo

            // Directory.CreateDirectory(@"c:\\TestOrigin\\");
            //var files =Directory.GetFiles(@"c:\\TestOrigin", "*.*",SearchOption.AllDirectories);
            //foreach (var file in files)
            // {
            //   Console.WriteLine(file);
            //}

            //Path class, to work with the string and extract the parts of the path

            var path = @"C:\TestOrigin\myFile.txt";

            //var dotIndex = path.IndexOf('.');
            //var extentions = path.Substring(dotIndex);
            // Get path extension
            Console.WriteLine("Extension is " + Path.GetExtension(path));
            // Get File name with the path
            Console.WriteLine("FileName is " + Path.GetFileName(path));
            //Get File name without the extension
            Console.WriteLine("FileName is " + Path.GetFileNameWithoutExtension(path));
            //Get full path
            Console.WriteLine("FullPath is : " + Path.GetFullPath(path));
            //Get DirectoryName
            Console.WriteLine("Directory Name is  " + Path.GetDirectoryName(path));
            // Get Path Root
            Console.WriteLine("Get path root : "+Path.GetPathRoot(path));
        }
        
    }
}
