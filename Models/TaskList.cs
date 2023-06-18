using System;
using TaskHub.MockData;

namespace TaskHub.Models
{
    public class TaskList
    {
        public TaskList()
        {
            this.Tasks = new List<Task>();
        }

        public List<Task> Tasks { get; set; }

        public TaskList Clear()
        {
            this.Tasks.Clear();
            return this;
        }

        public TaskList Populate()
        {
            // DataAccess Run etl.usp_TaskList
            this.Tasks = MockData.Db
                .TaskList()
                .Select(t => t.ToTask())
                .ToList();
            return this;
        }

        public TaskList Execute()
        {
            this.Tasks
                .ForEach(t => t.Execute());
            return this;
        }
    }
}
