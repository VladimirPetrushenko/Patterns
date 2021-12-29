using System;
using System.Collections.Generic;

namespace Composite.FileSystems
{
    internal class Folder : FileSystem
    {
        private readonly List<FileSystem> fileSystems;

        public Folder(string Title)
        {
            this.fileSystems = new List<FileSystem>();
            this.Title = Title;
        }

        protected override FileSystem AddItem(FileSystem system)
        {
            fileSystems.Add(system);

            return this;
        }

        public FileSystem AddItems(params FileSystem[] systems)
        {
            foreach (FileSystem system in systems)
            {
                this.AddItem(system);
            }

            return this;
        }

        public override void PrintInfo(string message = "")
        {
            Console.WriteLine($"{message}{Title}");

            foreach(FileSystem system in fileSystems)
            {
                system.PrintInfo($"{message} ");
            }
        }
    }
}
