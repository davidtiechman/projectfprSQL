using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

namespace projectforSql.DBemplouees
{
    public class Menu
    {
        //Agent a = Agent.Instance;
        private Menu() { }
        public void PrintMenu()
        {
            Console.WriteLine("");
        }
        public void EntrCouse(string couse)
        { bool exit = true;
            while (exit)
            switch (couse)
            {
                case "1":
                        break;
                case "2":
                        AddNewAgent();
                break;
                case "3":
                    break;
                case "4":
                case "5":
                    break;
                    case "9":
                        exit = false;
                        break;
            }
        }
        private void AddNewAgent()
        {
            Console.Write("הכנס שם קוד: ");
            string codename = Console.ReadLine();

            Console.Write("הכנס שם אמיתי: ");
            string realname = Console.ReadLine();

            Console.Write("הכנס מיקום: ");
            string location = Console.ReadLine();

            Console.Write("הכנס סטטוס: ");
            string status = Console.ReadLine();

           Agent a = new Agent(codename, realname, location, status);
            AgentDAL d = new AgentDAL();
            d.AddedAgent(a);
        }



    }
}
