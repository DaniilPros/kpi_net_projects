using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            const string connectionString = "Data Source=DESKTOP-05Q2667\\SQLEXPRESS;Initial Catalog=ToysHouse;"
                                            + "Integrated Security=true";

            OutputAllUsers(connectionString);
            Console.WriteLine("InputName: ");
            var name = Console.ReadLine();
            EditUsers(connectionString,name,1);
            OutputAllUsers(connectionString);
            EditUsers(connectionString, "Dan", 1);
            OutputAllUsers(connectionString);
            AddUser(connectionString, 10, "Name1");
            OutputAllUsers(connectionString);
            RemoveUser(connectionString, 10);
            OutputAllUsers(connectionString);
            OutputAllOrders(connectionString);
            Console.ReadLine();


        }

        private static void RemoveUser(string connectionString, int id)
        {
            Console.WriteLine($"Remove user: {id}");
            using (var connection =
                new SqlConnection(connectionString))
            {
                var dataAdpater = new SqlDataAdapter(
                    "SELECT * from dbo.users",
                    connection)
                {
                    DeleteCommand = new SqlCommand(
                        "Delete dbo.users " +
                        "WHERE ClientId = @ClientId", connection)
                };

                dataAdpater.DeleteCommand.Parameters.AddWithValue(
                    "@ClientId", id);
                connection.Open();
                dataAdpater.DeleteCommand.ExecuteNonQuery();
                connection.Close();
            }
        }

        private static void AddUser(string connectionString, int id, string name1)
        {
            Console.WriteLine($"Add user: {id}");
            using (var connection =
                new SqlConnection(connectionString))
            {
                var dataAdpater = new SqlDataAdapter(
                    "SELECT * from dbo.users where 0 = 1",
                    connection)
                {
                    InsertCommand = new SqlCommand(
                        "Insert into dbo.users (ClientId,Name,Discount) " +
                        "Values(@id,@name,@discount)", connection)
                };


                dataAdpater.InsertCommand.Parameters.AddWithValue(
                    "@id", id);
                dataAdpater.InsertCommand.Parameters.AddWithValue(
                    "@name", name1);
                dataAdpater.InsertCommand.Parameters.AddWithValue(
                    "@discount", 0);
                var dataSet = new DataSet();
                var rowsCount = dataAdpater.Fill(dataSet);
                var newRow = dataSet.Tables["Table"].NewRow();
                newRow["ClientId"] = id;
                newRow["Name"] = name1;
                newRow["Discount"] = 0;
                dataSet.Tables["Table"].Rows.Add(newRow);

                dataAdpater.Update(dataSet);
            }
        }

        private static void EditUsers(string connectionString,string userName,int userId)
        {
            Console.WriteLine($"Edit user: {userId}");
            using (var connection =
                new SqlConnection(connectionString))
            {
                var dataAdpater = new SqlDataAdapter(
                    "SELECT * from dbo.users",
                    connection)
                {
                    UpdateCommand = new SqlCommand(
                        "UPDATE dbo.users SET Name = @Name " +
                        "WHERE ClientId = @ClientId", connection)
                };

                dataAdpater.UpdateCommand.Parameters.Add(
                    "@Name", SqlDbType.NVarChar, 15, "Name");

                dataAdpater.UpdateCommand.Parameters.AddWithValue(
                    "@ClientId",userId);

                var categoryTable = new DataTable();
                dataAdpater.Fill(categoryTable);

                var categoryRow = categoryTable.Rows[0];
                categoryRow["Name"] = userName;

                dataAdpater.Update(categoryTable);
            }
        }

        private static void OutputAllUsers(string connectionString)
        {
            Console.WriteLine("All users");
            using (var connection =
                new SqlConnection(connectionString))
            {
                // Provide the query string with a parameter placeholder.
                const string queryString = "SELECT * from dbo.users";
                // Create the Command and Parameter objects.
                var command = new SqlCommand(queryString, connection);

                // Open the connection in a try/catch block. 
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("\t{0}\t{1}\t{2}",
                            reader[0], reader[1], reader[2]);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("");

            }
        }

        private static void OutputAllOrders(string connectionString)
        {
            Console.WriteLine("All orders");
            using (var connection =
                new SqlConnection(connectionString))
            {
                // Provide the query string with a parameter placeholder.
                const string queryString = "SELECT * from dbo.orders where clientId = 1";
                // Create the Command and Parameter objects.
                var command = new SqlCommand(queryString, connection);

                // Open the connection in a try/catch block. 
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("OrderId\t{0} StoreId\t{1} ClientId\t{2} TypeId\t{3} Date\t{4} OrderType\t{5}",
                            reader[0], reader[1], reader[2],reader[3],reader[4],reader[5]);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("");

            }
        }
    }
}
