using MySql.Data.MySqlClient;

namespace projectforSql.DBemplouees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Agent a = new Agent("223","mustafa","berlin", "injured");
            AgentDAL b = new AgentDAL();
            b.Delet(10);
            //b.AddedAgent(a);
            //b.PrintAgent();
            //b.UpdeateStatus(2, "Active");

            //MySqlConnection connection = new MySqlConnection();
            //string inputQuery = Console.ReadLine();
            //string whitchParametr = Console.ReadLine();
            //try
            //{
            //    connection.Open();
            //    MySqlCommand query = new MySqlCommand(inputQuery, connection);
            //    var result = query.ExecuteReader();
            //    while (result.Read())
            //    {
            //        string parameter = result.GetString(whitchParametr);
            //        Console.WriteLine($"{parameter}");
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("error");
            //}
            //finally { 
            //    connection.Close();
            //}
            
        }
    }
    }
