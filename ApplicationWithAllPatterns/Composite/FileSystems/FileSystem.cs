namespace Composite.FileSystems
{
    internal abstract class FileSystem
    {
        protected virtual FileSystem AddItem(FileSystem system) => this;
        public abstract void PrintInfo(string message = "");
        public string Title { get; set; }
    }
}
