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
        public void Execute()
        {
            Console.WriteLine("Select room number");
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
            if (room != null)
                room.Meetings.Add(new Meeting(0, startDate, duration, organizer, topic));
        }
    }
}
