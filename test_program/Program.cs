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

            var  history = WinHistory.Login(my, "ТроЛолЛо");
            history.Send("ГОГОГО");
            var r = history.Receive();
            foreach(var message in history.Receive() )
            {
                Console.WriteLine(message.Text);
            }
            




        }
    }
}
