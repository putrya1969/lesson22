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
                Console.WriteLine("For selecting command enter char:");
                ShowCommands();
                var userChoice = Console.ReadLine().ToUpper();
                Console.Clear();
                var command = _context.ContextCommands.Where(c => c.Mnemonic == userChoice).FirstOrDefault();
                isProcess = command.Execute();
                Console.WriteLine("press any key for continue...");
                Console.ReadKey();
            }
        }

        private void ShowCommands()
        {
            foreach (var command in _context.ContextCommands)
            {
                Console.WriteLine($"{command.Description}{new string(' ', 35 - command.Description.Length)}{command.Mnemonic}");
            }
        }
    }
}
