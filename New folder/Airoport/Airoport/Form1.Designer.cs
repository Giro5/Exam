namespace Airoport
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
            this.Destination2_cbox = new System.Windows.Forms.ComboBox();
            this.Number_cbox = new System.Windows.Forms.ComboBox();
            this.FNP_tbox = new System.Windows.Forms.TextBox();
            this.Export_but = new System.Windows.Forms.Button();
            this.Destination1_cbox = new System.Windows.Forms.ComboBox();
            this.Date_tpiker = new System.Windows.Forms.DateTimePicker();
            this.Data_lview = new System.Windows.Forms.ListView();
            this.SNP_colunm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Destination1_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Destination2_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Number_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File_menustrip = new System.Windows.Forms.ToolStripMenuItem();
            this.Open_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.Save_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAs_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.Open_fdialog = new System.Windows.Forms.OpenFileDialog();
            this.Del_But = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Destination2_cbox
            // 
            this.Destination2_cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Destination2_cbox.FormattingEnabled = true;
            this.Destination2_cbox.Items.AddRange(new object[] {
            "Астрахань",
            "Благовещенск",
            "Волгоград",
            "Иркутск",
            "Калининград",
            "Москва",
            "Саратов",
            "Тюмень",
            "Уфа",
            "Якутск"});
            this.Destination2_cbox.Location = new System.Drawing.Point(269, 43);
            this.Destination2_cbox.Name = "Destination2_cbox";
            this.Destination2_cbox.Size = new System.Drawing.Size(121, 21);
            this.Destination2_cbox.TabIndex = 0;
            // 
            // Number_cbox
            // 
            this.Number_cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Number_cbox.FormattingEnabled = true;
            this.Number_cbox.Location = new System.Drawing.Point(403, 43);
            this.Number_cbox.Name = "Number_cbox";
            this.Number_cbox.Size = new System.Drawing.Size(121, 21);
            this.Number_cbox.TabIndex = 1;
            this.Number_cbox.DropDown += new System.EventHandler(this.Number_cbox_DropDown);
            // 
            // FNP_tbox
            // 
            this.FNP_tbox.Location = new System.Drawing.Point(32, 43);
            this.FNP_tbox.Name = "FNP_tbox";
            this.FNP_tbox.Size = new System.Drawing.Size(100, 20);
            this.FNP_tbox.TabIndex = 2;
            // 
            // Export_but
            // 
            this.Export_but.Location = new System.Drawing.Point(625, 43);
            this.Export_but.Name = "Export_but";
            this.Export_but.Size = new System.Drawing.Size(75, 23);
            this.Export_but.TabIndex = 4;
            this.Export_but.Text = "Export";
            this.Export_but.UseVisualStyleBackColor = true;
            this.Export_but.Click += new System.EventHandler(this.Export_but_Click);
            // 
            // Destination1_cbox
            // 
            this.Destination1_cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Destination1_cbox.FormattingEnabled = true;
            this.Destination1_cbox.Items.AddRange(new object[] {
            "Астрахань",
            "Благовещенск",
            "Волгоград",
            "Иркутск",
            "Калининград",
            "Москва",
            "Саратов",
            "Тюмень",
            "Уфа",
            "Якутск"});
            this.Destination1_cbox.Location = new System.Drawing.Point(142, 43);
            this.Destination1_cbox.Name = "Destination1_cbox";
            this.Destination1_cbox.Size = new System.Drawing.Size(121, 21);
            this.Destination1_cbox.TabIndex = 5;
            // 
            // Date_tpiker
            // 
            this.Date_tpiker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date_tpiker.Location = new System.Drawing.Point(530, 44);
            this.Date_tpiker.Name = "Date_tpiker";
            this.Date_tpiker.Size = new System.Drawing.Size(81, 20);
            this.Date_tpiker.TabIndex = 6;
            // 
            // Data_lview
            // 
            this.Data_lview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SNP_colunm,
            this.Destination1_column,
            this.Destination2_column,
            this.Number_column,
            this.Date_column});
            this.Data_lview.FullRowSelect = true;
            this.Data_lview.Location = new System.Drawing.Point(32, 70);
            this.Data_lview.Name = "Data_lview";
            this.Data_lview.Size = new System.Drawing.Size(579, 155);
            this.Data_lview.TabIndex = 7;
            this.Data_lview.UseCompatibleStateImageBehavior = false;
            this.Data_lview.View = System.Windows.Forms.View.Details;
            // 
            // SNP_colunm
            // 
            this.SNP_colunm.Text = "SNP";
            this.SNP_colunm.Width = 105;
            // 
            // Destination1_column
            // 
            this.Destination1_column.Text = "City 1";
            this.Destination1_column.Width = 101;
            // 
            // Destination2_column
            // 
            this.Destination2_column.Text = "City 2";
            this.Destination2_column.Width = 97;
            // 
            // Number_column
            // 
            this.Number_column.Text = "Number";
            this.Number_column.Width = 94;
            // 
            // Date_column
            // 
            this.Date_column.Text = "Date";
            this.Date_column.Width = 109;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(625, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "OUTPUT VSEGO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_menustrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(712, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File_menustrip
            // 
            this.File_menustrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open_tool,
            this.Save_tool,
            this.SaveAs_tool});
            this.File_menustrip.Name = "File_menustrip";
            this.File_menustrip.Size = new System.Drawing.Size(37, 20);
            this.File_menustrip.Text = "File";
            // 
            // Open_tool
            // 
            this.Open_tool.Name = "Open_tool";
            this.Open_tool.Size = new System.Drawing.Size(114, 22);
            this.Open_tool.Text = "Open";
            this.Open_tool.Click += new System.EventHandler(this.Open_tool_Click);
            // 
            // Save_tool
            // 
            this.Save_tool.Name = "Save_tool";
            this.Save_tool.Size = new System.Drawing.Size(114, 22);
            this.Save_tool.Text = "Save";
            // 
            // SaveAs_tool
            // 
            this.SaveAs_tool.Name = "SaveAs_tool";
            this.SaveAs_tool.Size = new System.Drawing.Size(114, 22);
            this.SaveAs_tool.Text = "Save As";
            // 
            // Open_fdialog
            // 
            this.Open_fdialog.FileName = "openFileDialog1";
            // 
            // Del_But
            // 
            this.Del_But.Location = new System.Drawing.Point(625, 132);
            this.Del_But.Name = "Del_But";
            this.Del_But.Size = new System.Drawing.Size(75, 23);
            this.Del_But.TabIndex = 10;
            this.Del_But.Text = "Delete";
            this.Del_But.UseVisualStyleBackColor = true;
            this.Del_But.Click += new System.EventHandler(this.Del_But_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 379);
            this.Controls.Add(this.Del_But);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Data_lview);
            this.Controls.Add(this.Date_tpiker);
            this.Controls.Add(this.Destination1_cbox);
            this.Controls.Add(this.Export_but);
            this.Controls.Add(this.FNP_tbox);
            this.Controls.Add(this.Number_cbox);
            this.Controls.Add(this.Destination2_cbox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Destination2_cbox;
        private System.Windows.Forms.ComboBox Number_cbox;
        private System.Windows.Forms.TextBox FNP_tbox;
        private System.Windows.Forms.Button Export_but;
        private System.Windows.Forms.ComboBox Destination1_cbox;
        private System.Windows.Forms.DateTimePicker Date_tpiker;
        private System.Windows.Forms.ListView Data_lview;
        private System.Windows.Forms.ColumnHeader Destination1_column;
        private System.Windows.Forms.ColumnHeader Destination2_column;
        private System.Windows.Forms.ColumnHeader Number_column;
        private System.Windows.Forms.ColumnHeader SNP_colunm;
        private System.Windows.Forms.ColumnHeader Date_column;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File_menustrip;
        private System.Windows.Forms.ToolStripMenuItem Open_tool;
        private System.Windows.Forms.ToolStripMenuItem Save_tool;
        private System.Windows.Forms.ToolStripMenuItem SaveAs_tool;
        private System.Windows.Forms.OpenFileDialog Open_fdialog;
        private System.Windows.Forms.Button Del_But;
    }
}

