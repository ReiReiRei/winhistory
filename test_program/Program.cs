using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lib;

namespace test_program
{
    class Program
    {
        static void Main(string[] args)
        {
            Guid my = new Guid();

            var  messages = WinHistory.Login(my, "ТроЛолЛо");
            messages.Send("ГОГОГО");
            messages.Receive();
            messages.Receive();


            //var msgs = messages.Receive(my);

            //foreach(var msg in msgs)
            //{
               

            //}

        }
    }
}
