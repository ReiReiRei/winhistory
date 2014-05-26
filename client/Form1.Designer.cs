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
            this.clientInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MessagesView = new System.Windows.Forms.DataGridView();
            this.messageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchQuery = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.ClientView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientView.AutoGenerateColumns = false;
            this.ClientView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.guidDataGridViewTextBoxColumn});
            this.ClientView.DataSource = this.clientInfoBindingSource;
            this.ClientView.Location = new System.Drawing.Point(12, 66);
            this.ClientView.Name = "ClientView";
            this.ClientView.Size = new System.Drawing.Size(313, 635);
            this.ClientView.TabIndex = 0;
            this.ClientView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientView_CellContentClick);
            this.ClientView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientView_CellEnter);
            // 
            // clientInfoBindingSource
            // 
            this.clientInfoBindingSource.DataSource = typeof(lib.Models.ClientInfo);
            // 
            // MessagesView
            // 
            this.MessagesView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessagesView.AutoGenerateColumns = false;
            this.MessagesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MessagesView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.textDataGridViewTextBoxColumn,
            this.stampDataGridViewTextBoxColumn,
            this.levelDataGridViewTextBoxColumn});
            this.MessagesView.DataSource = this.messageBindingSource;
            this.MessagesView.Location = new System.Drawing.Point(331, 66);
            this.MessagesView.Name = "MessagesView";
            this.MessagesView.ReadOnly = true;
            this.MessagesView.Size = new System.Drawing.Size(763, 635);
            this.MessagesView.TabIndex = 1;
            // 
            // messageBindingSource
            // 
            this.messageBindingSource.DataSource = typeof(lib.Models.Message);
            // 
            // searchQuery
            // 
            this.searchQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchQuery.Location = new System.Drawing.Point(912, 10);
            this.searchQuery.Name = "searchQuery";
            this.searchQuery.Size = new System.Drawing.Size(100, 20);
            this.searchQuery.TabIndex = 2;
            this.searchQuery.TextChanged += new System.EventHandler(this.searchQuery_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(1018, 10);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Найти";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exportButton.Location = new System.Drawing.Point(912, 37);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(182, 23);
            this.exportButton.TabIndex = 4;
            this.exportButton.Text = "Экспорт";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 54;
            // 
            // guidDataGridViewTextBoxColumn
            // 
            this.guidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.guidDataGridViewTextBoxColumn.DataPropertyName = "Guid";
            this.guidDataGridViewTextBoxColumn.HeaderText = "Guid";
            this.guidDataGridViewTextBoxColumn.Name = "guidDataGridViewTextBoxColumn";
            this.guidDataGridViewTextBoxColumn.Width = 54;
            // 
            // textDataGridViewTextBoxColumn
            // 
            this.textDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.textDataGridViewTextBoxColumn.DataPropertyName = "Text";
            this.textDataGridViewTextBoxColumn.HeaderText = "Text";
            this.textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            this.textDataGridViewTextBoxColumn.ReadOnly = true;
            this.textDataGridViewTextBoxColumn.Width = 53;
            // 
            // stampDataGridViewTextBoxColumn
            // 
            this.stampDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.stampDataGridViewTextBoxColumn.DataPropertyName = "Stamp";
            this.stampDataGridViewTextBoxColumn.HeaderText = "Stamp";
            this.stampDataGridViewTextBoxColumn.Name = "stampDataGridViewTextBoxColumn";
            this.stampDataGridViewTextBoxColumn.ReadOnly = true;
            this.stampDataGridViewTextBoxColumn.Width = 62;
            // 
            // levelDataGridViewTextBoxColumn
            // 
            this.levelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.levelDataGridViewTextBoxColumn.DataPropertyName = "Level";
            this.levelDataGridViewTextBoxColumn.HeaderText = "Level";
            this.levelDataGridViewTextBoxColumn.Name = "levelDataGridViewTextBoxColumn";
            this.levelDataGridViewTextBoxColumn.ReadOnly = true;
            this.levelDataGridViewTextBoxColumn.Width = 58;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 713);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchQuery);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ClientView;
        private System.Windows.Forms.BindingSource clientInfoBindingSource;
        private System.Windows.Forms.DataGridView MessagesView;
        private System.Windows.Forms.BindingSource messageBindingSource;
        private System.Windows.Forms.TextBox searchQuery;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stampDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelDataGridViewTextBoxColumn;
    }
}

