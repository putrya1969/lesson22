using CalendarProject.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarProject
{
    internal class ContextProcessor
    {
        private IDataContext _context;
        public IDataContext Context
        {
            set { _context = value; }
        }
        public void BuildUserContext()
        {
            this._context.ContextCommands.Add(new ViewMeetings( "View", "View all meetings", "V", _context.Data));
        }
        public void BuildAdminContext()
        {
        }

        public void Process()
        { 

        }
    }
}
