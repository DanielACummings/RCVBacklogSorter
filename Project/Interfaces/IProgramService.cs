using System.Collections.Generic;
using RCVSorter.Project.Models;

namespace RCVSorter.Project.Interfaces
{
    public interface IProgramService
    {
        List<string> messages {get;}
        void Setup(string playerName);

        void Help();
    }
}