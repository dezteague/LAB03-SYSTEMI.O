using System;
//in order to be able to use IO:
using System.IO;

namespace SystemIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Deziree's Guessing Game!");
            string path = "../../../wordFile.txt";
            Menu();
        }

        //main menu
        public static string Menu()
        {
            Console.WriteLine("1. New Game");
            Console.WriteLine("2. Word Options");
            Console.WriteLine("2. Exit Game");
            string menuSelction = Console.ReadLine();
            return menuSelction;
        }
        //from main menu, select 2 to navigate to word options: view, add, delete
        public static string WordOptions()
        {
            Console.WriteLine("1. View Words");
            Console.WriteLine("2. Add a Word");
            Console.WriteLine("3. Delete a Word");
            string wordOptionSelection = Console.ReadLine();
            return wordOptionSelection;
        }

        public void UserInterface()
        {
            switch(value)
            {

            }
            
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

        static void DeleteFile(string path)
        {
            try
            {
                File.Delete(path);
            }
            catch (Exception)
            {

                throw;
            }
        }

        static void CreateWordBank (string path)
        {
            try
            {
                //if there is an exisiting file
                if (!File.Exists(path))
                {

                    using (StreamWriter streamwriter = File.CreateText(path))
                    {
                        try
                        {
                            streamwriter.WriteLine("sloth");
                            streamwriter.WriteLine("turtle");
                            streamwriter.WriteLine("pig");
                            streamwriter.WriteLine("dolphin");
                            streamwriter.WriteLine("tiger");
                        }
                        catch
                        {
                            throw;
                        }
                        finally
                        {
                            streamwriter.Close();
                        }
                    }

                }
                else
                {
                    File.Delete(path);
                    CreateWordBank(path);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }     
}

