using System;

namespace Composite.FileSystems
{
    internal class File : FileSystem
    {
        public override void PrintInfo(string message = "") => Console.WriteLine($"{message}{Title}");
        public File(string Title)
        {
            this.Title = Title;
        }
    }
}
