namespace BookStoreApp.API.Constants
{
    public class Message
    {
        public const string Error500 = "There was an error completing your request. Please try Later";

        public static string WarningTableNotFound(string tableName) => $"Table {tableName} not found";
        public static string RecordNotFound(string table, int id) => $"Record in Table {table} with Id {id} not found";
    }
}
