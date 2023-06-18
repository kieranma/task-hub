using System;

namespace TaskHub.MockData
{
    public class File
    {
        public static List<string> FileList()
        {
            return new List<string> {
                "a.txt",
                "b.txt",
                "c.txt",
                "d.txt",
                "e.txt",
                "f.txt"
            };
        }
    }
}
