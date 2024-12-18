namespace DBTableManager
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxTables = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_OpenFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_AddEntry = new System.Windows.Forms.ToolStripButton();
            this.btn_ModifyEntry = new System.Windows.Forms.ToolStripButton();
            this.btn_DeleteEntry = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_RefreshTable = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(886, 409);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBoxTables
            // 
            this.comboBoxTables.FormattingEnabled = true;
            this.comboBoxTables.Location = new System.Drawing.Point(804, 2);
            this.comboBoxTables.Name = "comboBoxTables";
            this.comboBoxTables.Size = new System.Drawing.Size(94, 21);
            this.comboBoxTables.TabIndex = 5;
            this.comboBoxTables.SelectedIndexChanged += new System.EventHandler(this.comboBoxTables_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_OpenFile,
            this.toolStripSeparator1,
            this.btn_AddEntry,
            this.btn_ModifyEntry,
            this.btn_DeleteEntry,
            this.toolStripSeparator2,
            this.btn_RefreshTable});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(910, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_OpenFile
            // 
            this.btn_OpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_OpenFile.Image = ((System.Drawing.Image)(resources.GetObject("btn_OpenFile.Image")));
            this.btn_OpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.Size = new System.Drawing.Size(23, 22);
            this.btn_OpenFile.Text = "Open .db file";
            this.btn_OpenFile.Click += new System.EventHandler(this.btn_OpenFile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_AddEntry
            // 
            this.btn_AddEntry.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_AddEntry.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddEntry.Image")));
            this.btn_AddEntry.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_AddEntry.Name = "btn_AddEntry";
            this.btn_AddEntry.Size = new System.Drawing.Size(23, 22);
            this.btn_AddEntry.Text = "Add an entry to the table";
            this.btn_AddEntry.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btn_ModifyEntry
            // 
            this.btn_ModifyEntry.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_ModifyEntry.Image = ((System.Drawing.Image)(resources.GetObject("btn_ModifyEntry.Image")));
            this.btn_ModifyEntry.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ModifyEntry.Name = "btn_ModifyEntry";
            this.btn_ModifyEntry.Size = new System.Drawing.Size(23, 22);
            this.btn_ModifyEntry.Text = "Edit selected entry";
            this.btn_ModifyEntry.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btn_DeleteEntry
            // 
            this.btn_DeleteEntry.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_DeleteEntry.Image = ((System.Drawing.Image)(resources.GetObject("btn_DeleteEntry.Image")));
            this.btn_DeleteEntry.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_DeleteEntry.Name = "btn_DeleteEntry";
            this.btn_DeleteEntry.Size = new System.Drawing.Size(23, 22);
            this.btn_DeleteEntry.Text = "Delete selected entry";
            this.btn_DeleteEntry.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_RefreshTable
            // 
            this.btn_RefreshTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_RefreshTable.Image = ((System.Drawing.Image)(resources.GetObject("btn_RefreshTable.Image")));
            this.btn_RefreshTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_RefreshTable.Name = "btn_RefreshTable";
            this.btn_RefreshTable.Size = new System.Drawing.Size(23, 22);
            this.btn_RefreshTable.Text = "Refresh table";
            this.btn_RefreshTable.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(737, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Your table is";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTables);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "DTViewManager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxTables;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_OpenFile;
        private System.Windows.Forms.ToolStripButton btn_AddEntry;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_ModifyEntry;
        private System.Windows.Forms.ToolStripButton btn_DeleteEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_RefreshTable;
    }
}

