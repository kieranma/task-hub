using System;

namespace TaskHub.Models
{
    public class TaskImport : Task
    {
        public string SourceFilePath { get; set; }
        public string SourceFileName { get; set; }
        public string FormatFile { get; set; }
        public string DestinationFilePath { get; set; }
        public string DestinationFileName { get; set; }
        public string PreProcedure { get; set; }
        public string MainProcedure { get; set; }
        public string PostProcedure { get; set; }
        public List<string> Files { get; set; }

        public override void Execute()
        {
            try
            {
                this.LogStart($"{this.SourceFilePath}{this.SourceFileName}");
                this.GetFilesToProcess();
                this.ImportFiles();
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

        public void GetFilesToProcess()
        {
            this.Files.AddRange(
                Helpers.File
                    .FileList(this.SourceFilePath)
                    .Where(f => IsValidFile(f))
            );
        }

        public List<string> GetAvailableFiles()
        {
            return Helpers.File.FileList(this.SourceFilePath);
        }

        public static bool IsValidFile(string fileName)
        {
            // etl.usp_TaskListFileCheck
            return MockData.Db.ImportFileList().Contains(fileName);
        }

        public void ImportFiles()
        {
            foreach (var file in this.Files)
            {
                Helpers.File.ImportFile(this.SourceFileName, this.SourceFilePath, this.FormatFile);
                Helpers.Db.RunProc(this.MainProcedure);
                base.LogSuccess($"Imported {this.SourceFilePath}{this.SourceFileName}");
            }
        }
    }
}
