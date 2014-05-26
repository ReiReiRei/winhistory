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
            this.MessagesView = new System.Windows.Forms.DataGridView();
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exportButton = new System.Windows.Forms.Button();
            this.ClientView = new System.Windows.Forms.DataGridView();
            this.Guid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contains = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Search = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clientInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.minLevelQuery = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.containsQuery = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MessagesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientInfoBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.MessagesView.Location = new System.Drawing.Point(612, 66);
            this.MessagesView.Name = "MessagesView";
            this.MessagesView.ReadOnly = true;
            this.MessagesView.Size = new System.Drawing.Size(482, 635);
            this.MessagesView.TabIndex = 1;
            this.MessagesView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MessagesView_CellContentClick);
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
            // messageBindingSource
            // 
            this.messageBindingSource.DataSource = typeof(lib.Models.Message);
            this.messageBindingSource.CurrentChanged += new System.EventHandler(this.messageBindingSource_CurrentChanged);
            // 
            // exportButton
            // 
            this.exportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exportButton.Location = new System.Drawing.Point(912, 37);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(182, 23);
            this.exportButton.TabIndex = 4;
            this.exportButton.Text = "Экспорт";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // ClientView
            // 
            this.ClientView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientView.AutoGenerateColumns = false;
            this.ClientView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Guid,
            this.nameDataGridViewTextBoxColumn,
            this.MinLevel,
            this.Contains,
            this.Search});
            this.ClientView.DataSource = this.clientInfoBindingSource;
            this.ClientView.Location = new System.Drawing.Point(12, 66);
            this.ClientView.Name = "ClientView";
            this.ClientView.Size = new System.Drawing.Size(594, 635);
            this.ClientView.TabIndex = 0;
            this.ClientView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientView_CellContentClick);
            this.ClientView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientView_CellEndEdit);
            this.ClientView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientView_CellEnter);
            // 
            // Guid
            // 
            this.Guid.DataPropertyName = "Guid";
            this.Guid.HeaderText = "Guid";
            this.Guid.Name = "Guid";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Программа";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // MinLevel
            // 
            this.MinLevel.DataPropertyName = "MinLevel";
            this.MinLevel.HeaderText = "MinLevel";
            this.MinLevel.Name = "MinLevel";
            // 
            // Contains
            // 
            this.Contains.DataPropertyName = "Contains";
            this.Contains.HeaderText = "Содержит";
            this.Contains.Name = "Contains";
            // 
            // Search
            // 
            this.Search.DataPropertyName = "Search";
            this.Search.HeaderText = "Участвует в поиске";
            this.Search.Name = "Search";
            // 
            // clientInfoBindingSource
            // 
            this.clientInfoBindingSource.DataSource = typeof(lib.Models.ClientInfo);
            this.clientInfoBindingSource.CurrentChanged += new System.EventHandler(this.clientInfoBindingSource_CurrentChanged);
            // 
            // minLevelQuery
            // 
            this.minLevelQuery.Location = new System.Drawing.Point(162, 35);
            this.minLevelQuery.Name = "minLevelQuery";
            this.minLevelQuery.Size = new System.Drawing.Size(100, 20);
            this.minLevelQuery.TabIndex = 5;
            this.minLevelQuery.TextChanged += new System.EventHandler(this.minLevelQuery_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Минимальный уровень";
            // 
            // containsQuery
            // 
            this.containsQuery.Location = new System.Drawing.Point(407, 34);
            this.containsQuery.Name = "containsQuery";
            this.containsQuery.Size = new System.Drawing.Size(100, 20);
            this.containsQuery.TabIndex = 8;
            this.containsQuery.TextChanged += new System.EventHandler(this.containsQuery_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Содержит";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 713);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.containsQuery);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minLevelQuery);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.MessagesView);
            this.Controls.Add(this.ClientView);
            this.Name = "Form1";
            this.Text = "Обзор лога. by Тихонов и Лахвич.";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MessagesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MessagesView;
        private System.Windows.Forms.BindingSource messageBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stampDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.DataGridView ClientView;
        private System.Windows.Forms.BindingSource clientInfoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Guid;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contains;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Search;
        private System.Windows.Forms.TextBox minLevelQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox containsQuery;
        private System.Windows.Forms.Label label2;
    }
}

