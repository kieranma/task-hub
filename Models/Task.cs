using System;

namespace TaskHub.Models
{
    public abstract class Task
    {
        public int TaskID { get; set; }
        public string TaskCode { get; set; }
        public string TaskType { get; set; }

        public abstract void Execute();

        public void LogStart(string msg)
        {
            // etl.TaskLogStart
            Console.WriteLine($"LogStart: {this} {msg}");
        }

        public void LogSuccess(string msg)
        {
            // etl.TaskLogEnd
            Console.WriteLine($"LogSuccess: {this} {msg}");
        }

        public void LogFailure(string msg)
        {
            // etl.TaskLogEnd
            Console.WriteLine($"LogFailure: {this} {msg}");
        }

        public override string ToString()
        {
            return $"{this.TaskType}, ID:{this.TaskID}, Code:{this.TaskCode}";
        }
    }
}
