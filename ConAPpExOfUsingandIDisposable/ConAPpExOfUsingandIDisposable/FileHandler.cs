using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppIDisposableEx
{
    public class FileHandler : IDisposable
    {
        File fileObject = null;
        static int totalFiles = 0;
        bool disposedValue;
        public FileHandler(string fileName)
        {
            if (fileObject == null)
            {
                totalFiles++;
                fileObject = new File(fileName);
            }
            Console.WriteLine("File created");
            Console.WriteLine("Number of files are: " + totalFiles);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    totalFiles = 0;
                }
            }
            Console.WriteLine("File {0} has been disposed", fileObject.Name);
            fileObject = null;
            disposedValue = true;
        }
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
        public void GetFileDetails()
        {
            Console.WriteLine(fileObject.Name + " File has been created successfully");
        }
        ~FileHandler()
        {
            Dispose(false);
        }
    }
}
