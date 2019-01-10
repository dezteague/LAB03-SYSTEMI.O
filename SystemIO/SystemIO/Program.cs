using System;
//in order to be able to use IO:
using System.IO;

namespace SystemIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string path = "../../../wordFile.txt";
            CreateFile(path);
            ReadFile(path);
            AppendFile(path);
        }

        static void CreateFile(string path)
        {
            //using statement (FINALLY)
            try
            {
                //using makes sure you are closing the file
                using (StreamWriter streamWriter = new StreamWriter(path))
                {
                    //when you leave this block, the engine will dispose streamWriter
                    Console.WriteLine("List of random words");
                    streamWriter.WriteLine("List of random words");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
                throw;
            }
            catch (NotSupportedException e)
            {
                Console.WriteLine(e);
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        static void ReadFile(string path)
        {
            try
            {
                //send the lines to be read in the text file based on the path
                string[] lines = File.ReadAllLines(path);
                for (int i = 0; i < lines.Length; i++)
                {
                    Console.WriteLine(lines[i]);
                }

                //use for each only if youre going through every element in the array
                //    foreach (string line in lines)
                //    {
                //        Console.WriteLine(line);
                //    }
            }
            catch (Exception)
            {

                throw;
            }
        }

        static void AppendFile(string path)
        {
            try
            {
                using (StreamWriter streamWriter = File.AppendText(path))
                {
                    streamWriter.WriteLine("this is a new line to be added");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }     
}

