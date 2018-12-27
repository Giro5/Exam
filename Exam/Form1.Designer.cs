namespace Exam
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.DTP = new System.Windows.Forms.DateTimePicker();
            this.FromCB = new System.Windows.Forms.ComboBox();
            this.FullNameTB = new System.Windows.Forms.TextBox();
            this.NumberCB = new System.Windows.Forms.ComboBox();
            this.ToCB = new System.Windows.Forms.ComboBox();
            this.OrdersLV = new System.Windows.Forms.ListView();
            this.FullNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FromCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ToCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumberCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.DTP2 = new System.Windows.Forms.DateTimePicker();
            this.FromCB2 = new System.Windows.Forms.ComboBox();
            this.FullNameTB2 = new System.Windows.Forms.TextBox();
            this.NumberCB2 = new System.Windows.Forms.ComboBox();
            this.ToCB2 = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(820, 420);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DeleteBtn);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.OrdersLV);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(812, 394);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Search";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(668, 54);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(141, 23);
            this.DeleteBtn.TabIndex = 14;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.SearchBtn);
            this.groupBox1.Controls.Add(this.DTP);
            this.groupBox1.Controls.Add(this.FromCB);
            this.groupBox1.Controls.Add(this.FullNameTB);
            this.groupBox1.Controls.Add(this.NumberCB);
            this.groupBox1.Controls.Add(this.ToCB);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(812, 48);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Data";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchBtn.Location = new System.Drawing.Point(668, 20);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(141, 23);
            this.SearchBtn.TabIndex = 18;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // DTP
            // 
            this.DTP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DTP.Checked = false;
            this.DTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP.Location = new System.Drawing.Point(535, 21);
            this.DTP.Name = "DTP";
            this.DTP.ShowCheckBox = true;
            this.DTP.Size = new System.Drawing.Size(130, 20);
            this.DTP.TabIndex = 17;
            // 
            // FromCB
            // 
            this.FromCB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FromCB.FormattingEnabled = true;
            this.FromCB.Location = new System.Drawing.Point(136, 21);
            this.FromCB.Name = "FromCB";
            this.FromCB.Size = new System.Drawing.Size(130, 21);
            this.FromCB.TabIndex = 16;
            // 
            // FullNameTB
            // 
            this.FullNameTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FullNameTB.Location = new System.Drawing.Point(3, 21);
            this.FullNameTB.Name = "FullNameTB";
            this.FullNameTB.Size = new System.Drawing.Size(130, 20);
            this.FullNameTB.TabIndex = 15;
            // 
            // NumberCB
            // 
            this.NumberCB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NumberCB.FormattingEnabled = true;
            this.NumberCB.Location = new System.Drawing.Point(402, 21);
            this.NumberCB.Name = "NumberCB";
            this.NumberCB.Size = new System.Drawing.Size(130, 21);
            this.NumberCB.TabIndex = 14;
            // 
            // ToCB
            // 
            this.ToCB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ToCB.FormattingEnabled = true;
            this.ToCB.Location = new System.Drawing.Point(269, 21);
            this.ToCB.Name = "ToCB";
            this.ToCB.Size = new System.Drawing.Size(130, 21);
            this.ToCB.TabIndex = 13;
            // 
            // OrdersLV
            // 
            this.OrdersLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FullNameCol,
            this.FromCol,
            this.ToCol,
            this.NumberCol,
            this.DateCol});
            this.OrdersLV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OrdersLV.FullRowSelect = true;
            this.OrdersLV.Location = new System.Drawing.Point(3, 83);
            this.OrdersLV.Name = "OrdersLV";
            this.OrdersLV.Size = new System.Drawing.Size(806, 308);
            this.OrdersLV.TabIndex = 0;
            this.OrdersLV.UseCompatibleStateImageBehavior = false;
            this.OrdersLV.View = System.Windows.Forms.View.Details;
            // 
            // FullNameCol
            // 
            this.FullNameCol.Text = "Full Name";
            this.FullNameCol.Width = 131;
            // 
            // FromCol
            // 
            this.FromCol.Text = "From Where";
            this.FromCol.Width = 127;
            // 
            // ToCol
            // 
            this.ToCol.Text = "To Where";
            this.ToCol.Width = 140;
            // 
            // NumberCol
            // 
            this.NumberCol.Text = "Number";
            this.NumberCol.Width = 132;
            // 
            // DateCol
            // 
            this.DateCol.Text = "Date";
            this.DateCol.Width = 134;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(812, 394);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Order";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.SubmitBtn);
            this.groupBox2.Controls.Add(this.DTP2);
            this.groupBox2.Controls.Add(this.FromCB2);
            this.groupBox2.Controls.Add(this.FullNameTB2);
            this.groupBox2.Controls.Add(this.NumberCB2);
            this.groupBox2.Controls.Add(this.ToCB2);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(812, 48);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Data";
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubmitBtn.Location = new System.Drawing.Point(668, 20);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(141, 23);
            this.SubmitBtn.TabIndex = 18;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // DTP2
            // 
            this.DTP2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DTP2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP2.Location = new System.Drawing.Point(535, 22);
            this.DTP2.Name = "DTP2";
            this.DTP2.Size = new System.Drawing.Size(130, 20);
            this.DTP2.TabIndex = 17;
            // 
            // FromCB2
            // 
            this.FromCB2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FromCB2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FromCB2.FormattingEnabled = true;
            this.FromCB2.Location = new System.Drawing.Point(136, 21);
            this.FromCB2.Name = "FromCB2";
            this.FromCB2.Size = new System.Drawing.Size(130, 21);
            this.FromCB2.TabIndex = 16;
            // 
            // FullNameTB2
            // 
            this.FullNameTB2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FullNameTB2.Location = new System.Drawing.Point(3, 22);
            this.FullNameTB2.Name = "FullNameTB2";
            this.FullNameTB2.Size = new System.Drawing.Size(130, 20);
            this.FullNameTB2.TabIndex = 15;
            // 
            // NumberCB2
            // 
            this.NumberCB2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NumberCB2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NumberCB2.FormattingEnabled = true;
            this.NumberCB2.Location = new System.Drawing.Point(402, 21);
            this.NumberCB2.Name = "NumberCB2";
            this.NumberCB2.Size = new System.Drawing.Size(130, 21);
            this.NumberCB2.TabIndex = 14;
            this.NumberCB2.DropDown += new System.EventHandler(this.NumberCB2_DropDown);
            // 
            // ToCB2
            // 
            this.ToCB2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ToCB2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ToCB2.FormattingEnabled = true;
            this.ToCB2.Location = new System.Drawing.Point(269, 21);
            this.ToCB2.Name = "ToCB2";
            this.ToCB2.Size = new System.Drawing.Size(130, 21);
            this.ToCB2.TabIndex = 13;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(820, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Excel files|*.xlsx";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Excel files|*.xlsx";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 444);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView OrdersLV;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.DateTimePicker DTP;
        private System.Windows.Forms.ComboBox FromCB;
        private System.Windows.Forms.TextBox FullNameTB;
        private System.Windows.Forms.ComboBox NumberCB;
        private System.Windows.Forms.ComboBox ToCB;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.DateTimePicker DTP2;
        private System.Windows.Forms.ComboBox FromCB2;
        private System.Windows.Forms.TextBox FullNameTB2;
        private System.Windows.Forms.ComboBox NumberCB2;
        private System.Windows.Forms.ComboBox ToCB2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColumnHeader FullNameCol;
        private System.Windows.Forms.ColumnHeader FromCol;
        private System.Windows.Forms.ColumnHeader ToCol;
        private System.Windows.Forms.ColumnHeader NumberCol;
        private System.Windows.Forms.ColumnHeader DateCol;
    }
}

