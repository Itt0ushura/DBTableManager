using System.Data.SQLite;
using System.Data;

namespace DBTableManager
{
    public class DataBaseConnector
    {

        private readonly string _connectionString;

        public DataBaseConnector(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DataTable StartQuery(string query)
        {

            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {

                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {


                        DataTable table = new DataTable();

                        table.Load(reader);

                        return table;

                    }

                }

            }

        }

        public void StartNoQuery(string query)
        {

            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {

                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {

                    command.ExecuteNonQuery();

                }

            }

        }

    }

}
