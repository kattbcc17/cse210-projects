using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

namespace JournalApp
{
	class Journal
	{
		private string JournalFile = "MyJournal.txt";
		private string TitleArt = @"(\
(\ 
\'\ 
 \'\     __________  
 / '|   ()_________)
 \ '/    \ ~~~~~~~~ \
   \       \ ~~~~~~   \
   ==).      \__________\
  (__)       ()__________)";
		// Kicks off the journal app running.
		public void Run()
		{
			Title = "Journal App";
            DisplayIntro();
            CreateJournalFile();
			RunMenu();
			//AddEntry();
			//DisplayJournalContents();
			//ClearFile();
			//DisplayJournalContents();
            DisplayOutro();
		}


		// Present menu options for the user to choose what to do;
		// Repeat until they exit.
		private void RunMenu()
		{
			string choice;

			do
			{
				choice = GetChoice();
				switch (choice)
				{
					case "1":
						DisplayJournalContents();
						break;
					case "2":
						ClearFile();
						break;
					case "3":
						AddEntry();
						break;
					default:
						break;
				}
			} while (choice != "4");
			//WriteLine("You chose: " + GetChoice());
        }

		private string GetChoice()
		{
			bool isChoiceValid = false;
			string choice = "";

			do
			{
				Clear();
				ForegroundColor = ConsoleColor.DarkGray;
				WriteLine(TitleArt);
				ForegroundColor = ConsoleColor.Black;
				WriteLine("\nPlease select one of the following choices: ");
				WriteLine(" > 1 - Read journal.");
				WriteLine(" > 2 - Display.");
				WriteLine(" > 3 - Add to the journal.");
				WriteLine(" > 4 - Quit.");

				ForegroundColor = ConsoleColor.DarkBlue;
				choice = ReadLine().Trim();
				ForegroundColor = ConsoleColor.Black;

				if (choice == "1" || choice == "2" || choice == "3" || choice == "4")
				{
					isChoiceValid = true;
				}
				else
				{
					ForegroundColor = ConsoleColor.Red;
					WriteLine($"\"{choice}\" is not a valid option. Please choose one of the options available 1 - 4");
					WaitForKey();
				}
			} while (!isChoiceValid);
            return choice;
		}
		// Check if file exists, and if not, create it.
		private void CreateJournalFile()
		{
			// Relative to the exe. Create it manually
			// WriteLine($"Does file exist? {File.Exists("MyJournal.txt")}");

			// If file does not exist, create it!
			if (!File.Exists(JournalFile))
			{
				File.CreateText(JournalFile);
			}

		}

		private void DisplayIntro()
		{
            ForegroundColor = ConsoleColor.Black;
            BackgroundColor = ConsoleColor.White;
            Clear();
            WriteLine(TitleArt);
            WriteLine("\nWelcome to the only Journaling App you'll ever need!");
            ReadKey(true);
        }

		private void DisplayOutro()
		{
			WriteLine("\nArt from: https://www.asciiart.eu/books/books");
            WriteLine("Thanks for using the Journal App!");
            ReadKey(true);
			WaitForKey();
        }

		private void WaitForKey()
		{
			ForegroundColor = ConsoleColor.DarkGray;
			WriteLine("\nPress any key...");
			ReadKey(true);
		}

		private void DisplayJournalContents()
		{
			ForegroundColor = ConsoleColor.DarkMagenta;
			string journalText = File.ReadAllText(JournalFile);
			WriteLine("\n=== Journal Contents ===");
			WriteLine(journalText);
            WriteLine("\n==========================");
			WaitForKey();
        }

		private void ClearFile()
		{
			ForegroundColor = ConsoleColor.Black;
			File.WriteAllText(JournalFile, "");

			WriteLine("\nJournal clared!");
			WaitForKey();
		}
		private void AddEntry()
		{
			// My way to do it without over complicating it in one-line version
			//ForegroundColor = ConsoleColor.Black;
			//WriteLine("\nWhat would you like to add? ");
			//ForegroundColor = ConsoleColor.DarkMagenta;
			//string newLine = ReadLine();
			//File.AppendAllText(JournalFile, $"\nEntry: \n> {newLine}");
			//ForegroundColor = ConsoleColor.Black;
			//WriteLine("The journal has been modified!");
			//WaitForKey();

            // Advanced multi-line version that might make it crash
            ForegroundColor = ConsoleColor.Black;
            WriteLine("\nWhat would you like to add? (Type EXIT and press ENTER to stop.");
            ForegroundColor = ConsoleColor.DarkMagenta;

			string newEntry = "";
			bool shouldContinue = true;
			while (shouldContinue)
			{
				string line = ReadLine();
				if (line.ToLower().Trim() == "exit")
				{
					shouldContinue = false;
				}
				else
				{
					newEntry += line + "\n";
				}
			}

			File.AppendAllText(JournalFile, $"\nEntry: \n {newEntry}");
            ForegroundColor = ConsoleColor.Black;
            WriteLine("The journal has been modified!");
            WaitForKey();
        }


    }
}

