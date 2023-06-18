using System;

namespace TaskHub.Models
{
    public class TaskProcess : Task
    {
        public string MainProcedure { get; set; }

        public override void Execute()
        {
            try
            {
                this.LogStart($"{this.MainProcedure}");
                Helpers.Db.RunProc(this.MainProcedure);
            }
            catch (Exception ex)
            {
                this.LogFailure(ex.Message);
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()} {this.MainProcedure}";
        }
    }
}
