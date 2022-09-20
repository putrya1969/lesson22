using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarProject.Commands
{
    internal class AddRoom : ICommand
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Mnemonic { get; set; }
        public List<Room> Data { get; set; }

        public AddRoom(string name, string description, string mnemonic, List<Room> data)
        {
            Name = name;
            Description = description;
            Mnemonic = mnemonic;
            Data = data;
        }
        public bool Execute()
        {
            Console.WriteLine("Rooms list:");
            foreach (var room in Data)
            {
                Console.WriteLine(room.Number);
            }
            Console.WriteLine("Enter new number room");
            Data.Add(new Room(int.Parse(Console.ReadLine())));
            Console.WriteLine($"Room was added!");
            return true;
        }
    }
}
