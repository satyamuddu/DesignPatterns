using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class EncryptionDecorator : DataSourceDecorator
    {
        public EncryptionDecorator(IDataSource dataSource) : base(dataSource)
        {
        }
        public override void WriteData(string data)
        {
            dataSource.WriteData(data);
        }
        public override string ReadData()
        {
            return "Encrypted data : " + dataSource.ReadData();
        }
    }
}
