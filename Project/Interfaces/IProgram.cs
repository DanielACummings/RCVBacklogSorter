using RCVSorter.Project.Models;

namespace RCVSorter.Project.Interfaces
{
    public interface IProject
    {
        IPlayer CurrentPlayer { get; set; }

        void Setup();
    }
}