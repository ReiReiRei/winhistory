using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class Form1 : Form
    {
        private lib.WinHistory history;
        public Form1()
        {
            InitializeComponent();
            history = lib.WinHistory.Login(new Guid("14d88c08-115a-4599-8837-4d2f72065169"), "LogViewer");
            history.Send("Запуск просмоторщика лога");
            var Clients = history.ReceiveClients().ToList();
            ClientView.DataSource = Clients;
            ClientView.Update();

            var Messages = history.Receive().ToList();
            MessagesView.DataSource = Messages;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          


        }


        private void ClientView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ClientView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchQuery_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var messages = history.Receive(searchQuery.Text).ToList();
            MessagesView.DataSource = messages;
            MessagesView.Update();
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }


    }
}
