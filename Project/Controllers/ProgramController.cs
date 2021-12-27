using System;
using RCVBacklogSorter.Project.Interfaces;

namespace RCVBacklogSorter.Project.Controllers
{
    public class ProgramController : IProgramController
    {
        private ProgramService _programService = new ProgramService();
        private bool _running = true;

        public void Run()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nRanked Choice Voting Backlog Sorter\n")
        }
    }
}