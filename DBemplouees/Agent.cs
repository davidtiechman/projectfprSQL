using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectforSql.DBemplouees
{
    public class Agent
    {
        public static int Id { get; set; }
        public  string CodeName { get; set; }
        public  string RealName { get; set; }
        public  string Location { get; set; }
        public  string Status { get; set; }
        public  int MissionsCompleted { get; set; }
        public Agent(string codename, string realname, string location, string status) 
       
        {
            CodeName = codename;
            RealName = realname;
            Location = location;
            Status = status;
            MissionsCompleted = 0;
        }
        //public void UpdeadeStatus(string status)
        //{
            //this.Status = status;
        //}
        //public void UpdeateMissicon()
        //{

        //}

            }
        
        }

   

