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
            Console.WriteLine("Existing rooms list:");
            ShowExistingRoom();
            Console.WriteLine("Enter new number room");
            if (RoomExists(int.Parse(Console.ReadLine())))
            {
                Console.WriteLine("Room exists");
                return true;
            }
            Data.Add(new Room(int.Parse(Console.ReadLine()), new List<Meeting>()));
            Console.WriteLine($"Room was added!");
            return true;
        }
        private void ShowExistingRoom()
        {
            foreach (var item in Data)
            {
                Console.WriteLine(item.Number);
            }
        }

        private bool RoomExists(int roomNumber)
        {
            return Data.Where(r => r.Number == roomNumber).ToList().Count > 0;
        }
    }
}
