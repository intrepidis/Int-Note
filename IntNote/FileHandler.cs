using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntNote
{
    internal class FileHandler
    {
        public FileHandler(Action clearFile, Action<string> setFile, Action<string> announceFile)
        {
            this.clearFile = clearFile;
            this.setFile = setFile;
            this.announceFile = announceFile;
        }

        private readonly Action clearFile;
        private readonly Action<string> setFile;
        private readonly Action<string> announceFile;

        public string CurrentFile { get; private set; } = "";

        public bool Dirty { get; set; } = false;

        public void NewFile()
        {
            clearFile();

            CurrentFile = "";
            Dirty = false;
        }

        public void OpenFile(string file)
        {
            setFile(File.ReadAllText(file));

            announceFile(file);

            CurrentFile = file;
            Dirty = false;
        }

        public void SaveFile(string fileData)
        {
            SaveAsFile(CurrentFile, fileData);
        }

        public void SaveAsFile(string filePath, string fileData)
        {
            File.WriteAllText(filePath, fileData);

            announceFile(filePath);

            CurrentFile = filePath;
            Dirty = false;
        }
    }
}
