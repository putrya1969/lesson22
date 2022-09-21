using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarProject.Commands
{
    internal class ViewMeetingsByRoom : ICommand
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Mnemonic { get; set; }
        public List<Room> Data { get; set; }

        public ViewMeetingsByRoom(string name, string description, string mnemonic, List<Room> rooms)
        {
            Name = name;
            Description = description;
            Mnemonic = mnemonic;
            Data = rooms;
        }
        public bool Execute()
        {
            Console.WriteLine("Existing rooms list:");
            ShowExistingRoom();
            Console.WriteLine("Select and enter room number");
            if (!CheckRoom(int.Parse(Console.ReadLine()), out Room room))
            {
                Console.WriteLine("room not finded");
                return true;
            }
            ShowMeetings(room);
            return true;
        }
        private void ShowExistingRoom()
        {
            foreach (var item in Data)
            {
                Console.WriteLine(item.Number);
            }
        }
        private bool CheckRoom(int roomNumber, out Room room)
        {
            room = Data.Where(r => r.Number == roomNumber).FirstOrDefault();
            return room != null;
        }

        private void ShowMeetings(Room room)
        {
            Console.WriteLine($"Meetings for {room.Number} room");
            foreach (var meeting in room.Meetings)
            {
                Console.WriteLine($"  {meeting.StartTime} {meeting.Duration} {meeting.Organizer} {meeting.Topic}");
            }
        }
    }
}
