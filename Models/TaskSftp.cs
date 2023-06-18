using System;

namespace TaskHub.Models
{
    public class TaskSftp : Task
    {
        public string SourceFilePath { get; set; }
        public string SourceFileName { get; set; }
        public string DestinationFilePath { get; set; }
        public string DestinationFileName { get; set; }

        public override void Execute()
        {
            try
            {
                this.LogStart($"{this.SourceFilePath}{this.SourceFileName} to {this.DestinationFilePath}{this.DestinationFileName}");
                Helpers.File.FileSftp($"{this.SourceFilePath}{this.SourceFileName}", $"{this.DestinationFilePath}{this.DestinationFileName}");
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
