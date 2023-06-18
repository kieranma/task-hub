using System;

namespace TaskHub.Helpers
{
    public class File
    {
        public static void FileCopy(string source, string destination)
        {
            // Implement
            Console.WriteLine($"Copying {source} to {destination}...");
        }

        public static List<string> FileList(string path)
        {
            // Implement
            return MockData.File.FileList();
        }

        public static void ImportFile(string importTable, string sourceFilePath, string sourceFileName)
        {
            // Implement
            Console.WriteLine($"Importing {sourceFilePath}{sourceFileName} to {importTable}...");
        }

        public static void ExportFile(string sourceFilePath, string sourceFileName, string content)
        {
            // Implement
            Console.WriteLine($"Exporting content to {sourceFilePath}{sourceFileName}...");
        }

        public static void FileSftp(string source, string destination)
        {
            // Implement
            Console.WriteLine($"Sftp {source} to {destination}...");
        }
    }
}
