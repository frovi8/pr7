using pr7.UserInteraction;

namespace pr7
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using var db = new DickieYagodkiContext();

            CheckConnection connect = new (db);
            connect.CheckConn();

            Start start = new (db);
            await start.StartMenu();
        }
    }
}
