using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class DataSourceDecorator : IDataSource
    {
        protected IDataSource dataSource;

        public DataSourceDecorator(IDataSource dataSource) {
            this.dataSource = dataSource;
        }
        public virtual string ReadData()
        {
            return dataSource.ReadData();
        }

        public virtual void WriteData(string data)
        {
            dataSource.WriteData(data);
        }
    }
}
