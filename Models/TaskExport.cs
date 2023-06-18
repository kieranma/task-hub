using System;

namespace TaskHub.Models
{
    public class TaskExport : Task
    {
        public string SourceFilePath { get; set; }
        public string SourceFileName { get; set; }
        public string PreProcedure { get; set; }
        public string MainProcedure { get; set; }

        public override void Execute()
        {
            try
            {
                this.LogStart($"{this.SourceFilePath}{this.SourceFileName}");
                Helpers.File.ExportFile(
                        this.SourceFilePath,
                        this.SourceFileName,
                        Helpers.Db.ExportData(this.MainProcedure));
            }
            catch (Exception ex)
            {
                this.LogFailure(ex.Message);
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()} {SourceFilePath}{SourceFileName}";
        }
    }
}
