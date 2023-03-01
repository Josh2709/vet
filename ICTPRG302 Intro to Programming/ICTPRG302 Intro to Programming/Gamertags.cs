using System;
using System.IO;
namespace ICTPRG302_Intro_to_Programming
{ 
    public class Gamertags
    {


        public void ShowWelcomeMessage()
        {

            Console.Clear();
            Console.WriteLine("====================");
            Console.WriteLine("Hello, and welcome to the Gamertag Database!");
            Console.WriteLine("====================");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        //the list of gamertags from the file
        private string[] gamerTagList = { };


        //load list of gamertags from a seperate file 
        //and store that list in the gamerTagList
        public void LoadGamertags()
        {
            gamerTagList = File.ReadAllLines("../Gamertags.txt");

        }

        public void PrintAllGamertags()
        {
            Console.Clear();
            Console.WriteLine("====================");
            Console.WriteLine("All Gamertags");
            Console.WriteLine("====================");

            //loop over list of gamertags and print em' on new line
            int lineNumber = 1; //variable that acts as a bullet list counter for each line 
            foreach (string s in gamerTagList)
            {
                //formats the gamertags one per line and puts a number in front. Listing them 1,2,3, etc. 
                Console.WriteLine(lineNumber.ToString() + ")" + s);

                lineNumber = lineNumber + 1;

            }
            //display "Press any key to continue..." to the user, reqcuiring a key press to continue. 
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }

        public void PrintGamertagsEndingWithNumber()
        {
            Console.Clear();
            Console.WriteLine("====================");
            Console.WriteLine("Gamertags ending with a number");
            Console.WriteLine("====================");
            //loop over list of gamertags and print em' on new line

            int lineNumber = 1; //variable that acts as a bullet list counter for each line 
            foreach (string s in gamerTagList)
            {
                //test each gamertag to make sure it has atleast one number in
                //then, tests if the LAST number in the gamertag is a number
                //if statement will execute if both statements are met
                if ((s.Length > 0) && !Char.IsNumber(s, s.Length - 1))
                {
                    //formats the gamertags one per line and puts a number in front. Listing them 1,2,3, etc. 
                    Console.WriteLine(lineNumber.ToString() + ")" + s);

                    lineNumber = lineNumber + 1;
                }

            }
            //display "Press any key to continue..." to the user, reqcuiring a key press to continue.
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }



        public void Char.IsLetterOrDigit()
        {
            Console.Clear();
            Console.WriteLine("====================");
            Console.WriteLine("Gamertags NOT ending with a number");
            Console.WriteLine("====================");
            //loop over list of gamertags and print em' on new line

            int lineNumber = 1; //variable that acts as a bullet list counter for each line 
            foreach (string s in gamerTagList)
            {
                //test each gamertag to make sure it has atleast one number in
                //then, tests if the LAST number in the gamertag is a number
                //if statement will execute if both statements are met
                if ((s.Length > 0) && Char.IsNumber(s, s.Length - 1))
                {
                    //formats the gamertags one per line and puts a number in front. Listing them 1,2,3, etc. 
                    Console.WriteLine(lineNumber.ToString() + ")" + s);

                    lineNumber = lineNumber + 1;
                }

            }
            //display "Press any key to continue..." to the user, reqcuiring a key press to continue.
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }



    }
            

}


