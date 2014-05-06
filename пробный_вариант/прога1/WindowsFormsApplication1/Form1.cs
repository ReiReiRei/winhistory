using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void masBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.masBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bd1DataSet.mas' table. You can move, or remove it, as needed.
            this.masTableAdapter.Fill(this.bd1DataSet.mas);

        }
    }
}
