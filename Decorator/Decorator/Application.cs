using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Application
    {
        public void UsageExample()
        {
            IDataSource source = new FileDataSource("somefile.dat");
            source.WriteData("Data");
            // The target file has been written with plain data.
            Console.WriteLine(source.ReadData());
            source = new CompressionDecorator(source);
            source.WriteData("");
            Console.WriteLine(source.ReadData());

            // The target file has been written with compressed
            // data.

            source = new EncryptionDecorator(source);
            // The source variable now contains this:
            // Encryption > Compression > FileDataSource
            source.WriteData("");
            Console.WriteLine(source.ReadData());

        }
    }
}
