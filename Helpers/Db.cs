using System;

namespace TaskHub.Helpers
{
    public class Db
    {
        public static void RunProc(string procName)
        {
            Console.WriteLine($"Running {procName}...");
        }

        public static string ExportData(string proc)
        {
            return MockData.Db.ExportData(proc);
        }
    }
}
