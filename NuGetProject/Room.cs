using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarProject
{
    internal class Room
    {
        public int Number { get; set; }
        public List<Meeting> Meetings { get; set; }

        public Room(int number)
        {
            Number = number;
            Meetings = new List<Meeting>();
        }
    }
}
