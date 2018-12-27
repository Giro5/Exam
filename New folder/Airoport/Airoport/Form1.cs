using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace Airoport
{
    public partial class Form1 : Form
    {
        Excel.Application excapp = new Excel.Application();
        Excel.Workbook excbook;
        string[] numbers = { "316", "831", "319" };
        public Form1()
        {
            InitializeComponent();
            Destination1_cbox.SelectedIndex = 0;
            Destination2_cbox.SelectedIndex = 0;
            //excapp.Visible = true;
        }

        private void Number_cbox_DropDown(object sender, EventArgs e)
        {
            Number_cbox.Items.Clear();
            if (Destination1_cbox.SelectedItem.ToString() == Destination2_cbox.SelectedItem.ToString())
                return;
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    Number_cbox.Items.Add(numbers[i] + Destination1_cbox.SelectedItem.ToString().Substring(0, 1) + Destination2_cbox.SelectedItem.ToString().Substring(0, 1));
                }
            }
        }

        private void Export_but_Click(object sender, EventArgs e)
        {
            Excel.Worksheet wsheet = (Excel.Worksheet)excapp.ActiveSheet;
            int last=0;
            for (int i = 1; ; i++)
            {
                last += 1;
                if (wsheet.Cells[i, "A"].Text == "")
                    break;
            }
            //string[,] data = new string[countrows, 5];
            wsheet.Cells[last, "B"] = Destination1_cbox.Text;
            wsheet.Cells[last, "C"] = Destination2_cbox.Text;
            wsheet.Cells[last, "D"] = Number_cbox.Text;
            wsheet.Cells[last, "A"] = FNP_tbox.Text;
            wsheet.Cells[last, "E"] = Date_tpiker.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data_lview?.Items?.Clear();
            Excel.Worksheet wsheet = (Excel.Worksheet)excapp.ActiveSheet;
            int countrows = 0;
            for (int i = 1; ;i++)
            {
                countrows += 1;
                if (wsheet.Cells[i, "A"].Text == "")
                    break;
            }
            countrows--;
            //string[,] data = new string[countrows, 5];
            for (int i = 1; i <= countrows; i++)
            {
                ListViewItem lvsnp = new ListViewItem();
                ListViewItem.ListViewSubItem lvcity2 = new ListViewItem.ListViewSubItem();
                ListViewItem.ListViewSubItem lvnumber = new ListViewItem.ListViewSubItem();
                ListViewItem.ListViewSubItem lvcity1 = new ListViewItem.ListViewSubItem();
                ListViewItem.ListViewSubItem lvdate = new ListViewItem.ListViewSubItem();
                //data[i, j] = wsheet.Cells[i, j];
                lvcity1.Text = wsheet.Cells[i, "B"].Text;
                lvcity2.Text = wsheet.Cells[i, "C"].Text;
                lvnumber.Text = wsheet.Cells[i, "D"].Text;
                lvsnp.Text = wsheet.Cells[i, "A"].Text;
                lvdate.Text = wsheet.Cells[i, "E"].Text;
                lvsnp.SubItems.Add(lvcity1);
                lvsnp.SubItems.Add(lvcity2);
                lvsnp.SubItems.Add(lvnumber);
                lvsnp.SubItems.Add(lvdate);
                Data_lview.Items.Add(lvsnp);
            }
        }

        private void Open_tool_Click(object sender, EventArgs e)
        {
            Open_fdialog.FileName = "";
            if (Open_fdialog.ShowDialog() == DialogResult.OK)
            {
                string fname = Open_fdialog.FileName;
                try
                {
                    excbook = excapp.Workbooks.Open(fname);
                }
                catch
                {
                    return;
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            excbook.Save();
            excbook.Close();
        }

        private void Del_But_Click(object sender, EventArgs e)
        {
            var ar = Data_lview.SelectedIndices;
            int ind = ar[0];
            
            Data_lview.Items.RemoveAt(ind);
            Excel.Worksheet wsheet = (Excel.Worksheet)excapp.ActiveSheet;
            wsheet.Cells.Delete();
            for (int i = 0; i < Data_lview.Items.Count;i++)
            {
                wsheet.Cells[i+1,"A"]= Data_lview.Items[i].Text;
                wsheet.Cells[i+1, "B"] = Data_lview.Items[i].SubItems[0].Text;
                wsheet.Cells[i+1, "C"] = Data_lview.Items[i].SubItems[1].Text;
                wsheet.Cells[i+1, "D"] = Data_lview.Items[i].SubItems[2].Text;
                wsheet.Cells[i+1, "E"] = Data_lview.Items[i].SubItems[3].Text;
            }
        }
    }
}
