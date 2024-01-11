namespace интерфейсы_и_полиморфизм
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDataProcessor dataProcessor = new ConsoleDataProcessor();
            dataProcessor.ProcessData(new DbDataProvider());
            dataProcessor.ProcessData(new FileDataProvider());
            dataProcessor.ProcessData(new APIDataProvider());
        }
    }

    class DbDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "data from db";
        }
    }

    class FileDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "data from file";
        }
    }

    class APIDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "data from api";
        }
    }

    class ConsoleDataProcessor : IDataProcessor
    {
        public void ProcessData(IDataProvider dataProvider)
        {
            Console.WriteLine(dataProvider.GetData());
        }
    }
    interface IDataProvider
    {
        string GetData();
    }

    interface IDataProcessor
    {
        void ProcessData(IDataProvider dataProvider);
    }
}
