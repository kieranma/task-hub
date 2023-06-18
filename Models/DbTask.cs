using System;

namespace TaskHub.Models
{
    public class DbTask
    {
        public int TaskID { get; set; }
        public string TaskCode { get; set; }
        public string TaskType { get; set; }
        public string SourceFilePath { get; set; }
        public string SourceFileName { get; set; }
        public string DestinationFilePath { get; set; }
        public string DestinationFileName { get; set; }
        public string PreProcedure { get; set; }
        public string MainProcedure { get; set; }
        public string FormatFile { get; set; }
        public string ImportTable { get; set; }


        public Task ToTask()
        {
            switch (this.TaskCode)
            {
                case "Import":
                    return new TaskImport { TaskID = this.TaskID, TaskCode = this.TaskCode, TaskType = this.TaskType };
                case "Process":
                    return new TaskProcess { TaskID = this.TaskID, TaskCode = this.TaskCode, TaskType = this.TaskType };
                case "FileCopy":
                    return new TaskFileCopy { TaskID = this.TaskID, TaskCode = this.TaskCode, TaskType = this.TaskType };
                case "Export":
                    return new TaskExport { TaskID = this.TaskID, TaskCode = this.TaskCode, TaskType = this.TaskType };
                case "Sftp":
                    return new TaskSftp { TaskID = this.TaskID, TaskCode = this.TaskCode, TaskType = this.TaskType };
                default:
                    return null;
            }
        }
    }
}
