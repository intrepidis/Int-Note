using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
            StoreHash("");
        }

        private readonly Action clearFile;
        private readonly Action<string> setFile;
        private readonly Action<string> announceFile;
        private int dirtyHash;
        private int dirtyLength;

        public string CurrentFile { get; private set; } = "";

        public void NewFile()
        {
            clearFile();
            StoreHash("");

            CurrentFile = "";
        }

        public void OpenFile(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            setFile(fileData);
            StoreHash(fileData);

            announceFile(filePath);

            CurrentFile = filePath;
        }

        public void SaveFile(string fileData)
        {
            SaveAsFile(CurrentFile, fileData);
        }

        public void SaveAsFile(string filePath, string fileData)
        {
            File.WriteAllText(filePath, fileData);
            StoreHash(fileData);

            announceFile(filePath);

            CurrentFile = filePath;
        }

        private void StoreHash(string fileData)
        {
            dirtyHash = fileData.GetHashCode();
            dirtyLength = fileData.Length;
        }

        public bool DoesHashMatch(string fileData)
        {
            if (fileData.Length != dirtyLength)
                return false;
            return fileData.GetHashCode() == dirtyHash;
        }
    }
}
