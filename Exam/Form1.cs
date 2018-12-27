using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using System.Windows.Forms;
using System.IO;

namespace Exam
{
    public partial class Form1 : Form
    {
        string path = "", TitleName = "Orders";
        ExcelPackage excel;//Install-Package EPPlus
        ExcelWorksheet worksheet;
        bool changed = false;
        string[] Cities = new[] { "Уфа", "Москва", "Санкт-Петербург", "Волгоград", "Екатеринбург", "Пермь", "Казань" };
        string[] Numbers = new[] { "123", "345", "666", "843", "557" };

        public Form1()
        {
            InitializeComponent();
            FromCB.Items.AddRange(Cities);
            FromCB2.Items.AddRange(Cities);
            ToCB.Items.AddRange(Cities);
            ToCB2.Items.AddRange(Cities);
            FromCB2.SelectedIndex = 0;
            ToCB2.SelectedIndex = 1;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (excel == null)
            {
                if (DialogResult.Yes == MessageBox.Show("No connection to excel file.\nTo create the excel file?", "Error", MessageBoxButtons.YesNo))
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        path = saveFileDialog1.FileName;
                        excel = new ExcelPackage(new FileInfo(path));
                        excel.Workbook.Worksheets.Add("Sheet1");
                        excel.Save();
                        worksheet = excel.Workbook.Worksheets[1];
                        Text = path.Split('\\').Last() + " - " + TitleName;
                    }
                }
                else
                    return;
            }
            OrdersLV.Items.Clear();
            int countrows = 0;
            for (; ; countrows++)
                if (worksheet.Cells[countrows + 1, 1].Value == null)
                    break;
            for (int i = 1; i <= countrows; i++)
            {
                DateTime datecur = (DateTime)worksheet.Cells[i, 5].Value;
                string datestr = $"{datecur.Day}.{datecur.Month}.{datecur.Year}";
                ListViewItem row = new ListViewItem(worksheet.Cells[i, 1].Value.ToString());//name
                row.SubItems.AddRange(new[] {
                    new ListViewItem.ListViewSubItem(row, worksheet.Cells[i, 2].Value.ToString()),//from
                    new ListViewItem.ListViewSubItem(row, worksheet.Cells[i, 3].Value.ToString()),//to
                    new ListViewItem.ListViewSubItem(row, worksheet.Cells[i, 4].Value.ToString()),//num
                    new ListViewItem.ListViewSubItem(row, datestr)//date
                });
                OrdersLV.Items.Add(row);
            }
            if (FullNameTB.Text != "")
            {
                string filter = FullNameTB.Text;
                for (int i = 0; i < OrdersLV.Items.Count; i++)
                {
                    if (filter != OrdersLV.Items[i].Text)
                    {
                        OrdersLV.Items[i].Remove();
                        i--;
                    }
                }
            }
            if (FromCB.Text != "")
            {
                string filter = FromCB.Text;
                for (int i = 0; i < OrdersLV.Items.Count; i++)
                {
                    if (filter != OrdersLV.Items[i].SubItems[1].Text)
                    {
                        OrdersLV.Items[i].Remove();
                        i--;
                    }
                }
            }
            if (ToCB.Text != "")
            {
                string filter = ToCB.Text;
                for (int i = 0; i < OrdersLV.Items.Count; i++)
                {
                    if (filter != OrdersLV.Items[i].SubItems[2].Text)
                    {
                        OrdersLV.Items[i].Remove();
                        i--;
                    }
                }
            }
            if (NumberCB.Text != "")
            {
                string filter = NumberCB.Text;
                for (int i = 0; i < OrdersLV.Items.Count; i++)
                {
                    if (filter != OrdersLV.Items[i].SubItems[3].Text)
                    {
                        OrdersLV.Items[i].Remove();
                        i--;
                    }
                }
            }
            if (DTP.Checked)
            {
                DateTime filter = DTP.Value.Date;
                string datestr = $"{filter.Day}.{filter.Month}.{filter.Year}";
                for (int i = 0; i < OrdersLV.Items.Count; i++)
                {
                    if (datestr != OrdersLV.Items[i].SubItems[4].Text)
                    {
                        OrdersLV.Items[i].Remove();
                        i--;
                    }
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changed)
            {
                DialogResult res = MessageBox.Show("You don't save the file.\nTo save it?", "Exiting", MessageBoxButtons.YesNoCancel);
                if (res == DialogResult.Yes)
                    saveToolStripMenuItem.PerformClick();
                else if (res == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
            }
            worksheet?.Dispose();
            excel?.Dispose();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var item = OrdersLV.SelectedItems[0];
            OrdersLV.Items.Clear();
            int countrows = 0;
            for (; ; countrows++)
                if (worksheet.Cells[countrows + 1, 1].Value == null)
                    break;
            int index = -1;
            for (int i = 1; i <= countrows; i++)
            {
                DateTime datecur = (DateTime)worksheet.Cells[i, 5].Value;
                string datestr = $"{datecur.Day}.{datecur.Month}.{datecur.Year}";
                ListViewItem row = new ListViewItem(worksheet.Cells[i, 1].Value.ToString());//name
                row.SubItems.AddRange(new[] {
                    new ListViewItem.ListViewSubItem(row, worksheet.Cells[i, 2].Value.ToString()),//from
                    new ListViewItem.ListViewSubItem(row, worksheet.Cells[i, 3].Value.ToString()),//to
                    new ListViewItem.ListViewSubItem(row, worksheet.Cells[i, 4].Value.ToString()),//num
                    new ListViewItem.ListViewSubItem(row, datestr)//date
                });
                OrdersLV.Items.Add(row);
                bool pure = true;
                for (int j = 0; j < 5; j++)
                    pure = item.SubItems[j].Text == row.SubItems[j].Text;
                if (pure)
                    index = OrdersLV.Items.Count - 1;
            }
            worksheet.DeleteRow(index + 1);
            SearchBtn.PerformClick();
            changed = true;
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (excel == null)
            {
                if (DialogResult.Yes == MessageBox.Show("No connection to excel file.\nTo create the excel file?", "Error", MessageBoxButtons.YesNo))
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        path = saveFileDialog1.FileName;
                        excel = new ExcelPackage(new FileInfo(path));
                        excel.Workbook.Worksheets.Add("Sheet1");
                        excel.Save();
                        worksheet = excel.Workbook.Worksheets[1];
                        Text = path.Split('\\').Last() + " - " + TitleName;
                    }
                }
                else
                    return;
            }
            if (FullNameTB2.Text == "" || FromCB2.Text == "" || NumberCB2.Text == "" || ToCB2.Text == "")
            {
                MessageBox.Show("Some field isn't filled", "Error");
                return;
            }
            int countrows = 0;
            for (; ; countrows++)
                if (worksheet.Cells[countrows + 1, 1].Value == null)
                    break;
            worksheet.Cells[countrows + 1, 1].Value = FullNameTB2.Text;
            worksheet.Cells[countrows + 1, 2].Value = FromCB2.Text;
            worksheet.Cells[countrows + 1, 3].Value = ToCB2.Text;
            worksheet.Cells[countrows + 1, 4].Value = NumberCB2.Text;
            worksheet.Cells[countrows + 1, 5].Value = DTP2.Value;
            changed = true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (path == "")
                saveAsToolStripMenuItem.PerformClick();
            else
                excel.Save();
            changed = false;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog1.FileName;
                excel.SaveAs(new FileInfo(path));
                excel = new ExcelPackage(new FileInfo(path));
                Text = path.Split('\\').Last() + " - " + TitleName;
                worksheet = excel.Workbook.Worksheets[1];
                changed = false;
            }
        }

        private void NumberCB2_DropDown(object sender, EventArgs e)
        {
            NumberCB2.Items.Clear();
            if (FromCB2.Text != ToCB2.Text)
                NumberCB2.Items.AddRange(Numbers.Select(x => x + FromCB2.Text.Remove(1) + ToCB2.Text.Remove(1)).ToArray());

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                Text = path.Split('\\').Last() + " - " + TitleName;
                excel = new ExcelPackage(new FileInfo(path));
                worksheet = excel.Workbook.Worksheets[1];
                OrdersLV.Items.Clear();
            }
        }

    }
}
