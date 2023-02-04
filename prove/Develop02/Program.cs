using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //sets up list for promts and adds prompts to the list.
        List<string> prompts = new List<string>();
        prompts.Add("Who was the most interesting person I interacted with today?");
        prompts.Add("What was the best part of my day?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("If I had one thing I could do over today, what would it be?");

        List<string> entries = new List<string>();
        
        //Gets date from systems. NEEDS REVIEW NOT SURE IF WORKING. Seems to be functional.
        static string GetDate()
        {
            DateTime dateNow = DateTime.Now;
            string dateCurrent = dateNow.ToString();
            return dateCurrent;
        }
        
        //Displays menu and recieves users choice.
        static int DisplayMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("1. Write new entry");
            Console.WriteLine("2. Display entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Quit");
            Console.Write("Enter the number of your choice: ");

            string userChoice = Console.ReadLine();
            int choice = int.Parse(userChoice);
            return choice;
        }

        static string GetPrompt(List<string> promptList)
        {
            Random randomGenerator = new Random();
            int listSize = promptList.Count;
            int randomIndex = randomGenerator.Next(1, listSize);
            string prompt = promptList[randomIndex];
            return prompt;
        }

        int userChoice = -1;

        while (userChoice != 5)
        {
            userChoice = DisplayMenu();

            if (userChoice == 1)
            {
                string currentPrompt = GetPrompt(prompts);
                Console.WriteLine(currentPrompt);
                string userInput = Console.ReadLine();

                JournalEntry entry1 = new JournalEntry();
                entry1._date = GetDate();
                entry1._prompt = currentPrompt;
                entry1._inputUser = userInput;

                string formattedEntry = entry1.CreateEntry();
                entries.Add(formattedEntry);
            }

            else if (userChoice == 2)
            {
                foreach (string entry in entries)
                {
                    Console.WriteLine(entry);
                }
            }

            else if (userChoice == 3)
            {
                Console.WriteLine("Enter file name to save (Ex: JounalLog1)");
                string filename = Console.ReadLine();

                Scribe saveFile = new Scribe();
                saveFile._fileName = filename;

                saveFile.SaveToFile(entries);
                Console.WriteLine("File Saved");
            }

            else if (userChoice == 4)
            {
                Console.WriteLine("Enter file to load (Ex: JounalLog1)");
                string fileName = Console.ReadLine();

                Scribe loadFile = new Scribe();
                loadFile._fileName = fileName;

                List<string> tempEntryLocation = loadFile.LoadFromFile();

                foreach (string item in tempEntryLocation)
                {
                    entries.Add(item);                    
                }

                Console.WriteLine("File Loaded");
            }

            else if (userChoice == 5)
            {

            }

            else
            {
                Console.WriteLine("Please choose from the menu.");
            }
        }

    }
}