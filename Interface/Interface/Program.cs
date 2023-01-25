namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseManager databaseManager = new DatabaseManager();
            databaseManager.Save(new MySqlManager());
            databaseManager.Save(new MsSqlManager());
        }
    }
}
