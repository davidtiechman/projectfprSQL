using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectforSql
{
    public class Agent
        {
            public int Id { get; set; }
        public string CodeName { get; set; }
        public string RealName { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }
        public int MissionsCompleted { get; set; }
        public Agent(string codename,string realname,string location,string status)
        {
            this.CodeName = codename;
            this.RealName = realname;
            this.Location = location;
            this.Status = status;
            this.MissionsCompleted = 0;
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

   

