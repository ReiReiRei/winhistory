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
        private List<lib.Models.Message> messages;
        private List<lib.Models.ClientInfo> clients;
        public Form1()
        {
            InitializeComponent();
            history = lib.WinHistory.Login(new Guid("14d88c08-115a-4599-8837-4d2f72065169"), "LogViewer");
            history.Send("Запуск просмоторщика лога");
            clients = history.ReceiveClients().ToList();
            ClientView.DataSource = clients;
            

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
            messages = history.Receive(searchQuery.Text).ToList();
            
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            var saveFile = new SaveFileDialog();
            var exportTypes = new List<ILogExport> { new LogExportToTXT(), new LogExportToXML() };
            var exporter  = new LogExporter(exportTypes);
            saveFile.Filter = exporter.Filter;
            var dialogResult = saveFile.ShowDialog();

            if(dialogResult == DialogResult.OK)
            {
                exporter.Export(saveFile.FileName, saveFile.FilterIndex - 1 , (List<lib.Models.Message>) MessagesView.DataSource );
            }
        }


    }
}
