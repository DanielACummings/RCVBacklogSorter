using RCVSorter.Project.Interfaces;

namespace RCVSorter.Project.Models
{
    public class Program : iProgram
    {
        public IPlayer CurrentPlayer { get; set; }

        public void Setup()
        {
            CurrentPlayer = new Player("");
        }

        public Program()
        {
            Setup();
        }
    }
}