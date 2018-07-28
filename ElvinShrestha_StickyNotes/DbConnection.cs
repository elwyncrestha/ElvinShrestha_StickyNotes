using System;
using System.Data;
using System.Data.SqlClient;

namespace ElvinShrestha_StickyNotes
{
    public class DbConnection
    {
        SqlConnection connection = new SqlConnection(@"Data Source=ELVIN-PC;Initial Catalog=ElvinShrestha_StickyNote;Integrated Security=True");

        public void dbManipulate(string query)
        {
            if (connection != null)
            {
                // opens connection
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = query;
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Console.WriteLine("____________________________________");
                    Console.WriteLine("Exception Message: {0}", e.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public DataTable dbRetrieve(string query)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataSet dataSet = new DataSet();

            if (connection != null)
            {
                try
                {
                    dataAdapter = new SqlDataAdapter(query, connection);
                    dataAdapter.Fill(dataSet);
                }
                catch (Exception e)
                {
                    Console.WriteLine("____________________________________");
                    Console.WriteLine("Exception Message: {0}", e.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return dataSet.Tables[0];
        }
    }
}