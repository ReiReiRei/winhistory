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

        }
    }
}
