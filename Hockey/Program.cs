using System;

namespace Hockey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dbManager = new DatabaseManager();
            dbManager.Run();
        }
    }
}
