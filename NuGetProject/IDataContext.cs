using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarProject
{
    internal interface IDataContext
    {
        public List<ICommand> ContextCommands { get; set; }
        public List<Room> Data { get; set; }
    }
}
