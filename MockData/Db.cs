using System;
using TaskHub.Models;

namespace TaskHub.MockData
{
    public class Db
    {
        public static List<DbTask> TaskList()
        {
            return new List<DbTask> {
                new DbTask { TaskType = "Import", TaskID = 1, TaskCode = "Import 1" },
                new DbTask { TaskType = "FileCopy", TaskID = 2, TaskCode = "File Copy 1" },
                new DbTask { TaskType = "Import", TaskID = 3, TaskCode = "Import 2" },
                new DbTask { TaskType = "Import", TaskID = 4, TaskCode = "Import 3" },
                new DbTask { TaskType = "Export", TaskID = 5, TaskCode = "Export 1" },
                new DbTask { TaskType = "Import", TaskID = 6, TaskCode = "Import 4" },
                new DbTask { TaskType = "Email", TaskID = 7, TaskCode = "Email 1" },
                new DbTask { TaskType = "Email", TaskID = 8, TaskCode = "Email 2" },
                new DbTask { TaskType = "Sftp", TaskID = 9, TaskCode = "Sftp 1" },
                new DbTask { TaskType = "Process", TaskID = 10, TaskCode = "Process 1" },
                new DbTask { TaskType = "Export", TaskID = 11, TaskCode = "Export 2" },
                new DbTask { TaskType = "Process", TaskID = 12, TaskCode = "Process 2" }
            };
        }

        public static List<string> ImportFileList()
        {
            return new List<string> {
                "a.txt",
                "f.txt"
            };
        }

        public static string ExportData(string proc)
        {
            return "A,B,C,D,E,F,G";
        }
    }
}
