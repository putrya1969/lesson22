using CalendarProject.Commands;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarProject
{
    internal class UserContext : IDataContext
    {
        public List<ICommand> ContextCommands { get; set; } = new List<ICommand>();
        public List<Room> Data { get; set; }

        public UserContext(List<Room> data)
        {
            Data = data;
            ContextCommands.Add(new ViewAllMeetings("ViewAll", "View all meetings", "V", Data));
            ContextCommands.Add(new ViewMeetingsByRoom("ViewByRoom", "View meetings by selected room", "M", Data));
            ContextCommands.Add(new HaltProcess("Halt", "To return", "R", Data));
        }
    }
}
