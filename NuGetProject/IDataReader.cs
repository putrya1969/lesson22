using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarProject
{
    internal interface IDataReader
    {
        public List<Room> Data { get; set; }
        public void GetData();
    }
}
