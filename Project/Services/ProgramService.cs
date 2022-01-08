using System;
using System.Collections.Generic;
using RCVSorter.Project.Interfaces;
using RCVSorter.Project.Models;

namespace RCVSorter.Project
{
    public class ProgramService : IProgramService
    {
        private iProgram _program {get; set;}
        public List<string> messages {get; set;}

        public ProgramService()
        {
            _program = new Program();
            messages = new List<string>();
        }

        public void Help()
        {
            Messages.Add(String.Join(
                "Add voter"
            ));
        }
    }
}