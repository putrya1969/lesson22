using CalendarProject.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
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
        public ContextProcessor(IDataContext context)
        {
            Context = context;
        }

        public void Process()
        {
            var isProcess = true;
            while (isProcess)
            {
                Console.Clear();
                ShowCommands();
                var command = _context.ContextCommands.Where(c => c.Mnemonic == Console.ReadLine().ToUpper()).FirstOrDefault();
                isProcess = command.Execute();
            }
            UpdateData();
        }

        private void ShowCommands()
        {
            foreach (var command in _context.ContextCommands)
            {
                Console.WriteLine($"{_context.ContextCommands.IndexOf(command)} {command.Description}\t{command.Mnemonic}");
            }
        }

        private void UpdateData()
        {
            using (FileStream fs = new FileStream("rooms.json", FileMode.OpenOrCreate))
            {
                var rooms = _context.Data;
                JsonSerializer.SerializeAsync<List<Room>>(fs, rooms);
                Console.WriteLine("Data has been saved to file");
            }
        }
    }
}
