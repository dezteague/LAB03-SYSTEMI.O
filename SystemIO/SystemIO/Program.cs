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
            //Menu();
            CreateFile(path);
            string rdm = GenerateRandomWord(path);
            Console.WriteLine(GenerateUnderscores(rdm));

        }

        //main menu
        public static int Menu()
        {
            Console.WriteLine("1. New Game");
            Console.WriteLine("2. Word Options");
            Console.WriteLine("3. Exit Game");
            string selection = Console.ReadLine();
            int menuSelection = Convert.ToInt32(selection);
            return menuSelection;
        }

        //public static int MainMenuOption(int userInput, string path)
        //{
        //    try
        //    {
        //        switch(value)
        //        {
        //            case 1:
        //                CreateFile(path);
        //            break;
        //            case 2:
        //                WordOptions();
        //            break;
        //            case 3:
        //                Console.WriteLine("Thanks for playing");
        //            break;
        //            default:
        //                Console.WriteLine("Sorry you entered an invalid value");
        //                Menu();
        //                break;
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
            
        //}

        //from main menu, select 2 to navigate to word options: view, add, delete
        public static string WordOptions()
        {
            Console.WriteLine("1. View Words");
            Console.WriteLine("2. Add a Word");
            Console.WriteLine("3. Delete a Word");
            string wordOptionSelection = Console.ReadLine();
            return wordOptionSelection;
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
                    streamWriter.WriteLine("sloth");
                    streamWriter.WriteLine("turtle");
                    streamWriter.WriteLine("wolf");
                    streamWriter.WriteLine("dolphin");
                    streamWriter.WriteLine("tiger");
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
                string[] gameWords = File.ReadAllLines(path);
                for (int i = 0; i < gameWords.Length; i++)
                {
                    Console.WriteLine(gameWords[i]);
                }
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

        static string GenerateRandomWord(string path)
        {
            Random random = new Random();
            string[] randWords = File.ReadAllLines(path);
            string randomWord = randWords[random.Next(0, randWords.Length)];
            return randomWord;
        }

        static string GenerateUnderscores(string randomWord)
        {
            try
            {
                char[] wordsChoppedtoChars = randomWord.ToCharArray();
                string[] arrayofUnderscores = new string[wordsChoppedtoChars.Length];
                for (int i = 0; i < wordsChoppedtoChars.Length; i++)
                {
                    arrayofUnderscores[i] = "_";
                }
                return string.Join(" ", arrayofUnderscores);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }     
}

