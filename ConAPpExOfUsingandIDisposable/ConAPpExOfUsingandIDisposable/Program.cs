using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppIDisposableEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example 1
            FileHandler fileHandler = new FileHandler("Sam File One");
            fileHandler.GetFileDetails();
            fileHandler.Dispose();
            FileHandler fileHandler1 = new FileHandler("Sam File Two");
            fileHandler1.GetFileDetails();

            //Example 2
            //using (FileHandler obj1 = new FileHandler("Document-001"))
            //{
            //    obj1.GetFileDetails();
            //}
            //using (FileHandler obj2 = new FileHandler("Document-002"))
            //{
            //    obj2.GetFileDetails();
            //}

            //Example 3 using Using
            using(FileHandler obj1 = new FileHandler("Document-001"))
            {
                obj1.GetFileDetails();
            }
            using (FileHandler obj2 = new FileHandler("Document-001"))
            {
                obj2.GetFileDetails();
            }
            using (FileHandler obj3 = new FileHandler("Document-001"))
            {
                obj3.GetFileDetails();
            }
            Console.ReadKey();
        }
    }
}
