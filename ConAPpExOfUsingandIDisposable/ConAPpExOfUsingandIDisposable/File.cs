using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppIDisposableEx
{
    public class File
    {
        string name;
        public string Name { get { return name; } set { name = value; } }
        public File(string name)
        {
            this.name = name;
        }
    }
}
