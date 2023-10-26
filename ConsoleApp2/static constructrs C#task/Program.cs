class DbRepository
{
    private static string connectionString = "local BD";

    static DbRepository()
    {
        ConfigurationManager configurationManager = new ConfigurationManager();
        connectionString = configurationManager.GetConnectionString();
    }

    public void GetData()
    {
        Console.WriteLine("using: " + connectionString);
    }
}

class ConfigurationManager
{
    public string GetConnectionString()
    {
        return "local DB";
    }
}

class Programm
{
    static void Main(string[] args)
    {
        DbRepository dbrepository = new DbRepository();
        dbrepository.GetData();
    }
}