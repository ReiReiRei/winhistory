using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lib;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Guid one = new Guid("1179becb-d70f-4637-9364-06a4e1dc52aa");
            //Guid two = new Guid("a7860e85-9c03-4c4c-ace4-3e02733701e2");
            //Guid three = new Guid("ef5ce431-1b23-4780-ac0a-82b529994843");
            //var history_one = WinHistory.Login(one, "ТроЛолЛо");
            //var history_two = WinHistory.Login(two, "Вторая программа");
            //var history_three = WinHistory.Login(three, "Третья прогрмма");

            //history_one.Send("ГОГОГО");
            //history_one.Send("ГОГОUSUS");

            //history_one.Send("ГОГОГО", 10);
            //history_one.Send("ГUSUSUS");
            //history_two.Send("Работа", 1000);
            //history_three.Send("И не только Работа", 10);

            var Conn = new System.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + Environment.CurrentDirectory + @"\db\db.mdf;Integrated Security=True;Connect Timeout=30");
            var module = new lib.Models.ClientInfoModule(Conn);
            module.addClient(new lib.Models.ClientInfo { Guid = (new Guid()).ToString(), Name = "Mya" });
           var cl =  module.find(new Guid("1179becb-d70f-4637-9364-06a4e1dc52aa"));
           Console.WriteLine(cl.Name);
            






        }
    }
}

















