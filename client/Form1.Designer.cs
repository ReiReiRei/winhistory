namespace client
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ClientView = new System.Windows.Forms.DataGridView();
            this.clientInfoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MessagesView = new System.Windows.Forms.DataGridView();
            this.messageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ClientView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MessagesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientView
            // 
            this.ClientView.AutoGenerateColumns = false;
            this.ClientView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientInfoIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.guidDataGridViewTextBoxColumn});
            this.ClientView.DataSource = this.clientInfoBindingSource;
            this.ClientView.Location = new System.Drawing.Point(12, 86);
            this.ClientView.Name = "ClientView";
            this.ClientView.Size = new System.Drawing.Size(275, 343);
            this.ClientView.TabIndex = 0;
            this.ClientView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientView_CellContentClick);
            this.ClientView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientView_CellEnter);
            // 
            // clientInfoIdDataGridViewTextBoxColumn
            // 
            this.clientInfoIdDataGridViewTextBoxColumn.DataPropertyName = "ClientInfoId";
            this.clientInfoIdDataGridViewTextBoxColumn.HeaderText = "ClientInfoId";
            this.clientInfoIdDataGridViewTextBoxColumn.Name = "clientInfoIdDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // guidDataGridViewTextBoxColumn
            // 
            this.guidDataGridViewTextBoxColumn.DataPropertyName = "Guid";
            this.guidDataGridViewTextBoxColumn.HeaderText = "Guid";
            this.guidDataGridViewTextBoxColumn.Name = "guidDataGridViewTextBoxColumn";
            // 
            // clientInfoBindingSource
            // 
            this.clientInfoBindingSource.DataSource = typeof(lib.Models.ClientInfo);
            // 
            // MessagesView
            // 
            this.MessagesView.AutoGenerateColumns = false;
            this.MessagesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MessagesView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.textDataGridViewTextBoxColumn,
            this.stampDataGridViewTextBoxColumn,
            this.levelDataGridViewTextBoxColumn});
            this.MessagesView.DataSource = this.messageBindingSource;
            this.MessagesView.Location = new System.Drawing.Point(294, 86);
            this.MessagesView.Name = "MessagesView";
            this.MessagesView.ReadOnly = true;
            this.MessagesView.Size = new System.Drawing.Size(530, 343);
            this.MessagesView.TabIndex = 1;
            // 
            // messageBindingSource
            // 
            this.messageBindingSource.DataSource = typeof(lib.Models.Message);
            // 
            // textDataGridViewTextBoxColumn
            // 
            this.textDataGridViewTextBoxColumn.DataPropertyName = "Text";
            this.textDataGridViewTextBoxColumn.HeaderText = "Text";
            this.textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            this.textDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stampDataGridViewTextBoxColumn
            // 
            this.stampDataGridViewTextBoxColumn.DataPropertyName = "Stamp";
            this.stampDataGridViewTextBoxColumn.HeaderText = "Stamp";
            this.stampDataGridViewTextBoxColumn.Name = "stampDataGridViewTextBoxColumn";
            this.stampDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // levelDataGridViewTextBoxColumn
            // 
            this.levelDataGridViewTextBoxColumn.DataPropertyName = "Level";
            this.levelDataGridViewTextBoxColumn.HeaderText = "Level";
            this.levelDataGridViewTextBoxColumn.Name = "levelDataGridViewTextBoxColumn";
            this.levelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 441);
            this.Controls.Add(this.MessagesView);
            this.Controls.Add(this.ClientView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MessagesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ClientView;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientInfoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guidDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clientInfoBindingSource;
        private System.Windows.Forms.DataGridView MessagesView;
        private System.Windows.Forms.BindingSource messageBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stampDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelDataGridViewTextBoxColumn;
    }
}

