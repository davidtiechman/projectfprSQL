using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace projectforSql.DBemplouees
{
    public  class AgentDAL
    {
        public  string connStr = "server=localhost;username=root;password=;database=eagleeyedb";
        public  MySqlConnection con;
        public  string Query;
        public   AgentDAL() {
           this.con = new MySqlConnection(connStr);
        }
        public void AddedAgent(Agent agent)
        {
            this.Query = $"INSERT INTO agents (codeName,realName,location,status) VALUES('{agent.CodeName}','{agent.RealName}','{agent.Location}','{agent.Status}')";
            try
            {
                con.Open();
                MySqlCommand command = new MySqlCommand(Query, this.con);
                var reade = command.ExecuteReader();
                command.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine($"error {e.Message}");
            }
            finally { con.Close(); }
        }
        public void PrintAgent()
        {
            try
            {
                this.Query = "SELECT * FROM agents;";
                this.con.Open();
                MySqlCommand command = new MySqlCommand(Query, con);
                var reade = command.ExecuteReader();
                while (reade.Read())
                {
                    int id = reade.GetInt32("Id");
                    string codeName = reade.IsDBNull(reade.GetOrdinal("codeName")) ? "לא ידוע" : reade.GetString("codeName");
                    string realName = reade.IsDBNull(reade.GetOrdinal("realName")) ? "לא ידוע" : reade.GetString("codeName");
                    string location = reade.IsDBNull(reade.GetOrdinal("location")) ? "לא ידוע" : reade.GetString("location");
                    string status = reade.IsDBNull(reade.GetOrdinal("status")) ? "לא ידוע" : reade.GetString("status");
                    string missionsCompleted = reade.IsDBNull(reade.GetOrdinal("missionsCompleted")) ? "0" : reade.GetString("missionsCompleted");
                    Console.WriteLine($"The agent in id {id} name {realName} in location {location} in status {status} missionscompleted {missionsCompleted}");
                }
                    //Console.WriteLine($"{reade.GetName(i)}");
                con.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine($"{e.Message}");
            }
            finally { con.Close(); }
        }
        public void UpdeateStatus(int id, string status)
        {
            try
            {
                this.Query = $"UPDATE agents SET status = '{status}' WHERE Id = {id};";
                con.Open();
                MySqlCommand command = new MySqlCommand(Query, con);
                command.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
            }
            finally { con.Close(); }
            
        }
        public void UpdeateMission(int id, int miss)
        {
            try
            {
                this.Query = $"UPDATE agents SET missionsCompleted = '{miss}' WHERE Id = {id};";
                con.Open();
                MySqlCommand command = new MySqlCommand(Query, con);
                command.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                Console.WriteLine($"{e.Message}");
            }
            finally { con.Close(); }
        }
        public void UpdeateLocaion(int id,string loction)
        {
            try
            {
                this.Query = $"UPDATE agents SET missionsCompleted = '{loction}' WHERE Id = {id};";
                con.Open();
                MySqlCommand command = new MySqlCommand(Query, con);
                command.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                Console.WriteLine($"{e.Message}");
            }
            finally { con.Close(); }
            
        }
        public void Delet(int id)
        {
            try
            {
                this.Query = $"DELETE FROM agents WHERE Id = {id};";
                con.Open();
                MySqlCommand command = new MySqlCommand(Query,con);
                command.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e){ 
                Console.WriteLine($"{e.Message}"); 
            }
            finally { con.Close(); }
        }
        

    }
}