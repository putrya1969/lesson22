using CalendarProject.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarProject
{
    internal class AdminContext : IDataContext
    {
        public List<ICommand> ContextCommands { get; set; } = new List<ICommand>();
        public List<Room> Data { get; set; }
        public AdminContext(List<Room> data)
        {
            Data = data;
            ContextCommands.Add(new ViewMeetings("View", "View all meetings", "V", Data));
            ContextCommands.Add(new AddMeeting("Add", "Add meeting to room", "V", Data));
        }
    }
}
