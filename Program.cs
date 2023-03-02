using System;
using System.IO;

namespace ICTPRG302_Intro_to_Programming
{
	class Program
	{
		/// <summary>
		/// This is the starting location for the program.
		/// </summary>
		/// <param name="args">
		/// A list of strings passed in to the program
		/// from the command-line when it was started
		/// </param>
		static void Main(string[] args)
		{

			Gamertags gamertags = new Gamertags();

            bool isRunning = true;
            while (isRunning)
			{

                gamertags.ShowWelcomeMessage();
                gamertags.LoadGamertags();
                gamertags.PrintAllGamertags();
                gamertags.PrintGamertagsEndingWithNumber();
				gamertags.PrintGamertagsStartingWithSymbol();
                gamertags.PrintGamertagsNotEndingWithNumber();
                
                

				 //Ask user to rerun program or not
				Console.WriteLine("Would you like to view the gamertags again (y/n)?");

				//Read user response and compare it to character 'y'
				if(Console.ReadKey().Key == ConsoleKey.Y)
					isRunning = true;
				else isRunning = false;

			}
			
			
		}
	}
}
