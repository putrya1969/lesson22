
using CalendarProject;

namespace NuGetProject
{
    internal class Program
    {

        /*Calendar solution. User should be able to:
        add/view rooms list book meeting
        see booked meetings in selected room
        program supports 2 modes: readonly and RW mode
        readonly: users cannot add room, book meeting
        RW: permits all actions*/
        static void Main(string[] args)
        {
            IDataContext currentContext = null;
            Console.WriteLine("Enter your name");
            var userInput = Console.ReadLine().ToLower();
            currentContext = userInput != "admin"? new UserContext(new List<Room>()): new AdminContext(new List<Room>());
            var contextProcessor = new ContextProcessor(currentContext);
            contextProcessor.Process();
            
            //Console.WriteLine("Select command Id");
            //foreach (var item in currentContext.ContextCommands)
            //{
            //    Console.WriteLine($"{currentContext.ContextCommands.IndexOf(item)} {item.Description}\t{item.Mnemonic}");
            //}
            //var position = Console.ReadLine().ToLower();
            //var command = currentContext.ContextCommands.Where(c => c.Mnemonic == position).FirstOrDefault();
            //command.Execute();

        }
    }
}