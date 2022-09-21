using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarProject
{
    internal class Meeting
    {
        public int Id { get; set; }
        public string Topic { get; set; }
        public string Organizer { get; set; }
        public string StartTime { get; set; }
        public string Duration { get; set; }
        public Meeting(int id, string startTime, string duration, string organizer, string topic)
        {
            Id = id;
            StartTime = startTime;
            Duration = duration;
            Organizer = organizer;
            Topic = topic;
        }
    }
}
