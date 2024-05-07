using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class ApplicationConfigurator
    {
        IDataSource source;
        private bool enabledEncryption=true;
        private bool enabledCompression=true;
        SalaryManager salaryManager;

        public ApplicationConfigurator() {
            source = new FileDataSource("salary.dat");
            if (enabledEncryption)
                source = new EncryptionDecorator(source);
            if (enabledCompression)
                source = new CompressionDecorator(source);

            salaryManager = new SalaryManager(source);
           
        }

        public void ReadData()
        {
            string s = salaryManager.Load();
            Console.WriteLine(  s);
        }
    }
}
