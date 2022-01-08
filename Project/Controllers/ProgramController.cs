using System;
using System.Collections.Generic;
using RCVSorter.Project.Interfaces;

namespace RCVSorter.Project.Controllers
{
    public class ProgramController : IProgramController
    {
        private ProgramService _programService = new ProgramService();
        private bool _running = true;

        public void Run()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nRanked Choice Voting Sorter\nPlease enter a comma separated list of items to sort: ");
            string userInputList = Console.ReadLine();
            List<string> listToSort = new List<string>();
            listToSort = userInputList.Split(',').ToList();

            Console.WriteLine("\nWhat is your name? ");
            string playerName = Console.ReadLine();
            _programService.Setup(playerName);
            Console.Clear();

            Console.WriteLine("Type \"help\" at any time to view your options.\n");
            // test
            Console.WriteLine("List to be sorted:");
            foreach (var item in listToSort)
            {
                Console.WriteLine(item);
            }

            while (_playing)
            {
                Print();
                GetUserInput();
            }
        }

        public void Print()
        {
            foreach (var message in _programService.messages)
            {
                Console.WriteLine(message);
            }
            _programService.messages.Clear();
        }

        public void GetUserInput()
        {
            Console.WriteLine("\nWhat would you like to do?");
            string input = Console.ReadLine().ToLower();

            Console.Clear();
            switch (input)
            {
                case "help":
                    _programService.Help();
            }
        }
    }
}