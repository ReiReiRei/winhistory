﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using lib;

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
            foreach (var client in clients)
            {
                client.MinLevel = 0;
                client.Search = true;
            }
            ClientView.DataSource = clients;
            ClientView.VirtualMode = true;





            // foreach( DataGridViewRow row in ClientView.Rows)
            // {




            //     (row.Cells[ClientView.Columns["Search"].Index] as DataGridViewCheckBoxCell).Value = "true";
            //     ClientView.Refresh();
            //     ((DataGridViewTextBoxCell)row.Cells[ClientView.Columns["MinLevel"].Index]).Value = "0";



            //}




            ResfreshMessages();


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
            ResfreshMessages();

        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            var saveFile = new SaveFileDialog();
            var exportTypes = new List<ILogExport> { new LogExportToTXT(), new LogExportToXML() };
            var exporter = new LogExporter(exportTypes);
            saveFile.Filter = exporter.Filter;
            var dialogResult = saveFile.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                exporter.Export(saveFile.FileName, saveFile.FilterIndex - 1, (List<lib.Models.Message>)MessagesView.DataSource);
            }
        }

        private void ResfreshMessages()
        {
            var mainParam = new NoParam();
            var globalContains = new ContainsParam(containsQuery.Text);
            mainParam.AddChild(globalContains);

            SearchParametrs globalMinLevel;
            try
            {
                globalMinLevel = new HasMinimumLevelParam(Convert.ToInt32(minLevelQuery.Text));
            }
            catch (System.FormatException e)
            {
                globalMinLevel = new NoParam();
            }
            globalContains.AddChild(globalMinLevel);





            foreach (DataGridViewRow row in ClientView.Rows)
            {
                if (row.Cells["Search"].Value == null || (bool)row.Cells["Search"].Value == false)
                {
                    continue;
                }





                SearchParametrs childHasGuid;
                childHasGuid = new lib.HasGuidParam(new Guid(row.Cells["Guid"].Value as string));
 globalMinLevel.AddChild(childHasGuid);

                var childContains = new lib.ContainsParam(Convert.ToString(row.Cells["Contains"].Value));
                childHasGuid.AddChild(childContains);

                SearchParametrs childMinLevel;
                try
                {
                    childMinLevel = new lib.HasMinimumLevelParam(Convert.ToInt32(row.Cells["MinLevel"].Value));

                }
                catch(FormatException e)
                {
                    childMinLevel = new NoParam();
                }
                childContains.AddChild(childMinLevel);




            }
            messages = history.Receive(mainParam).ToList();
            MessagesView.DataSource = messages;
        }

        private void ClientView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ResfreshMessages();
        }

        private void MessagesView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void messageBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void clientInfoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void containsQuery_TextChanged(object sender, EventArgs e)
        {
            ResfreshMessages();
        }

        private void minLevelQuery_TextChanged(object sender, EventArgs e)
        {
            ResfreshMessages();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
