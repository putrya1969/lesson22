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
        public DateTime StartTime { get; set; }
        public TimeSpan Duration { get; set; }
        public Meeting(int id, DateTime startTime, TimeSpan duration, string organizer, string topic)
        {
            Id = id;
            StartTime = startTime;
            Duration = duration;
            Organizer = organizer;
            Topic = topic;
        }
    }
}
