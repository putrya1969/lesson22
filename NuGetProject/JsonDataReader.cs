using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CalendarProject
{
    internal class JsonDataReader : IDataReader
    {
        public List<Room>? Data { get; set; }
        public JsonDataReader()
        {
            GetData();
        }
        public void GetData()
        {
            if (File.Exists("rooms.json"))
            {
                using (FileStream fs = new FileStream("rooms.json", FileMode.Open))
                {
                    var rooms = JsonSerializer.Deserialize<List<Room>>(fs);
                    Data = rooms;
                }
            }
        }
    }
}
