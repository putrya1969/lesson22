using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarProject.Commands
{
    internal class AddMeeting : ICommand
    {
        public string Name { get; set; }
        public string Description { get;  set; }
        public string Mnemonic { get; set; }
        public List<Room> Data { get; set; }

        public AddMeeting(string name, string description, string mnemonic, List<Room> data)
        {
            Name = name;
            Description = description;
            Mnemonic = mnemonic;
            Data = data;
        }
        public bool Execute()
        {
            Console.WriteLine("Enter room number");
            var roomNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter date and time meeting");
            var startDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter duration if meeting");
            var duration = TimeSpan.Parse(Console.ReadLine());
            Console.WriteLine("Enter organizer lastname");
            var organizer = Console.ReadLine();
            Console.WriteLine("Enter meeting topic");
            var topic = Console.ReadLine();
            var room = Data.Where(r => r.Number == roomNumber).FirstOrDefault();
            if (room == null)
            {
                throw new Exception("room not finded");
            }
            var meetingId = room.Meetings.Count == 0? 0: room.Meetings.Max(m => m.Id) + 1;
            room.Meetings.Add(new Meeting(meetingId, startDate, duration, organizer, topic));
            return true;
        }

        private void PrintRoomNumber()
        {
            foreach (var item in Data)
            {
                Console.WriteLine(item.Number);
            }
        }
    }
}
