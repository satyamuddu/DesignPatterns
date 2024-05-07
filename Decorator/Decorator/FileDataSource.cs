using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class FileDataSource : IDataSource
    {
        public FileDataSource(string file)
        {

        }
        public string ReadData()
        {
            return "FileDataSource: ReadData()";
        }

        public void WriteData(string data)
        {

        }
    }
}
