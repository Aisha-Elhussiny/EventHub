using EventHub.Data;

namespace EventHub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (EventHubContext context = new EventHubContext())
            {
                Console.WriteLine("EventHub Database Connected");
            }
        }
    }
}
