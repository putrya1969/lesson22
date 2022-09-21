using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Text.Json;
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
            Data = rooms;
        }

        public bool Execute()
        {
            UpdateData();
            return false;
        }
        private void UpdateData()
        {

            using (FileStream fs = new FileStream("rooms.json", FileMode.Create))
            {
                JsonSerializer.SerializeAsync<List<Room>>(fs, Data);
                Console.WriteLine("Data has been saved to file");
            }
        }
    }
}
