using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarProject.Commands
{
    internal class HaltProcess : ICommand
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Mnemonic { get; set; }
        public List<Room> Data { get; set; }

        public HaltProcess(string name, string description, string mnemonic, List<Room> rooms)
        {
            Name = name;
            Description = description;
            Mnemonic = mnemonic;
        }

        public bool Execute()
        {
            return false;
        }
    }
}
