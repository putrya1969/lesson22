
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
            var data = new JsonDataReader().Data;
            if (data == null) data = new List<Room>();
            do
            {
            Console.WriteLine("For authentification\nenter your name");
            var userInput = Console.ReadLine().ToLower();
            currentContext = userInput != "admin"? new UserContext(data): new AdminContext(data);
            var contextProcessor = new ContextProcessor(currentContext);
            contextProcessor.Process();
            Console.WriteLine("To exit press Esc, to change user press any key");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}