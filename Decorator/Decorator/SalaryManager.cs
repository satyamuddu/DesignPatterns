namespace Decorator
{
    internal class SalaryManager
    {
        private IDataSource source;

        public SalaryManager(IDataSource source)
        {
            this.source = source;
        }
        public string Load()
        {
            return source.ReadData();
        }

        public void Save()
        {
            source.WriteData("salaryRecords");
        }
    }
}