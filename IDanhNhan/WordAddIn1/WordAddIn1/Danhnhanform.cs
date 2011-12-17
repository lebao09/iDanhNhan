using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace WordAddIn1
{
    public partial class Danhnhanform : Form
    {
        DNSH.DanhnhanClient client = new DNSH.DanhnhanClient();
        DataTable dtig = null;

        public Danhnhanform()
        {
            InitializeComponent();
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2, Screen.PrimaryScreen.Bounds.Height / 2 - this.Height / 2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                client.GetAuthors();
                button2.Visible = false;
                button4.Visible = true;
                button4.Location = new Point(button2.Location.X, button2.Location.Y);
                button3.Enabled = true;
                this.Size = new Size(733, 460);
            }
            catch
            {
                MessageBox.Show("Không thể kết nối tới service");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button3.Enabled = false;
            button4.Visible = false;
            this.Size = new Size(733, 68);
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = null;
            String query = "SELECT * FROM DANHNHAN";

            if (!String.IsNullOrEmpty(textBox1.Text))
                query += " WHERE " + GetComboBox() + " LIKE '%" + textBox1.Text + "%'";

            DataTable dt = client.GetTable(query).Tables[0];
            dtig = client.GetTable("SELECT * FROM HINHANH").Tables[0];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                /*dataGridView1.Rows.Add(new String[] { dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), 
                    dt.Rows[i][4].ToString(), dt.Rows[i][5].ToString(), dt.Rows[i][6].ToString(), 
                    dt.Rows[i][7].ToString(), dt.Rows[i][8].ToString(), dt.Rows[i][9].ToString(), 
                    dt.Rows[i][10].ToString(), dt.Rows[i][11].ToString(), dt.Rows[i][12].ToString(), 
                    dt.Rows[i][1].ToString()});*/
                gridControl1.DataSource = dt;
                DataGridViewImageColumn img = new DataGridViewImageColumn();
                Image image = null;
                try
                {
                    image = Image.FromFile(System.IO.Path.GetFullPath(dtig.Rows[i][2].ToString()));
                    pictureEdit1.Image = image;
                }
                catch
                {
                }

                //dataGridView1.Rows[i].Cells[12].Value = image;
            }
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private String GetComboBox()
        {
            if (comboBox1.Text == "TÊN")
                return "TEN";
            else if (comboBox1.Text == "DANH HIỆU")
                return "DANHHIEU";
            else if (comboBox1.Text == "NIÊN HIỆU")
                return "NIENHIEU";
            else if (comboBox1.Text == "NĂM SINH")
                return "NGAYSINH";
            else if (comboBox1.Text == "NĂM MẤT")
                return "NGAYMAT";
            else if (comboBox1.Text == "NƠI SINH")
                return "NOISINH";
            else if (comboBox1.Text == "TÀI NĂNG")
                return "TAINANG";
            else if (comboBox1.Text == "SỰ NGHIỆP")
                return "SUNGHIEP";
            else if (comboBox1.Text == "THÀNH TỰU")
                return "THANHTUU";
            else if (comboBox1.Text == "HOẠT ĐỘNG")
                return "HOATDONG";
            else //if (comboBox1.Text == "GIẢI THƯỞNG")
                return "GIAITHUONG";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void Danhnhanform_Load(object sender, EventArgs e)
        {
            button3.PerformClick();
            button3.Enabled = false;
        }

        private void tênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Automation("Tên: " + layoutView1.GetRowCellValue(layoutView1.FocusedRowHandle, "TEN"));
        }

        private void nămSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Automation("Danh hiệu: " + layoutView1.GetRowCellValue(layoutView1.FocusedRowHandle, "DANHHIEU"));
        }

        private void nămMấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Automation("Niên hiệu: " + layoutView1.GetRowCellValue(layoutView1.FocusedRowHandle, "NIENHIEU"));
        }

        private void hìnhẢnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Automation("Năm sinh: " + layoutView1.GetRowCellValue(layoutView1.FocusedRowHandle, "NGAYSINH"));
        }

        private void tấtCảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Automation("Năm mất: " + layoutView1.GetRowCellValue(layoutView1.FocusedRowHandle, "NGAYMAT"));
        }

        private void nơiSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Automation("Nơi sinh: " + layoutView1.GetRowCellValue(layoutView1.FocusedRowHandle, "NOISINH"));
        }

        private void tàiNăngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Automation("Tài năng: " + layoutView1.GetRowCellValue(layoutView1.FocusedRowHandle, "TAINANG"));
        }

        private void sựNghiệpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Automation("Sự nghiệp: " + layoutView1.GetRowCellValue(layoutView1.FocusedRowHandle, "SUNGHIEP"));
        }

        private void thànhTựuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Automation("Thành tựu: " + layoutView1.GetRowCellValue(layoutView1.FocusedRowHandle, "THANHTUU"));
        }

        private void hoạtĐộngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Automation("Hoạt động: " + layoutView1.GetRowCellValue(layoutView1.FocusedRowHandle, "HOATDONG"));
        }

        private void giảiThưởngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Automation("Giải thưởng: " + layoutView1.GetRowCellValue(layoutView1.FocusedRowHandle, "GIAITHUONG"));
        }

        private void Automation(String text)
        {
            Microsoft.Office.Interop.Word.Range currentRange = Globals.ThisAddIn.Application.Selection.Range;
            currentRange.Text = text;
        }

        private void hìnhẢnhToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.Range currentRange = Globals.ThisAddIn.Application.Selection.Range;

            Image img = null;

            try
            {
                img = Image.FromFile(System.IO.Path.GetFullPath(dtig.Rows[dataGridView1.CurrentRow.Index][2].ToString()));
            }
            catch
            {
            }
            Clipboard.SetImage(img);
            currentRange.Paste();
        }

        private void tấtCảToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            object missing = System.Type.Missing;
            Microsoft.Office.Interop.Word.Range currentRange = Globals.ThisAddIn.Application.Selection.Range;
            Word.Table newTable = Globals.ThisAddIn.Application.ActiveDocument.Tables.Add(
            currentRange, 1, 13, ref missing, ref missing);

            Word.Border[] borders = new Word.Border[6];
            borders[0] = newTable.Borders[Word.WdBorderType.wdBorderLeft];
            borders[1] = newTable.Borders[Word.WdBorderType.wdBorderRight];
            borders[2] = newTable.Borders[Word.WdBorderType.wdBorderTop];
            borders[3] = newTable.Borders[Word.WdBorderType.wdBorderBottom];
            borders[4] = newTable.Borders[Word.WdBorderType.wdBorderHorizontal];
            borders[5] = newTable.Borders[Word.WdBorderType.wdBorderVertical];

            // Format each of the borders.
            foreach (Word.Border border in borders)
            {
                border.LineStyle = Word.WdLineStyle.wdLineStyleSingle;
                border.Color = Word.WdColor.wdColorBlue;
            }

            newTable.Cell(0, 1).Range.Text = layoutView1.GetRowCellValue(layoutView1.FocusedRowHandle, "TEN").ToString();
            newTable.Cell(0, 2).Range.Text = layoutView1.GetRowCellValue(layoutView1.FocusedRowHandle, "DANHHIEU").ToString();
            newTable.Cell(0, 3).Range.Text = layoutView1.GetRowCellValue(layoutView1.FocusedRowHandle, "NIENHIEU").ToString();
            newTable.Cell(0, 4).Range.Text = layoutView1.GetRowCellValue(layoutView1.FocusedRowHandle, "NGAYSINH").ToString();
            newTable.Cell(0, 5).Range.Text = layoutView1.GetRowCellValue(layoutView1.FocusedRowHandle, "NGAYMAT").ToString();
            newTable.Cell(0, 6).Range.Text = layoutView1.GetRowCellValue(layoutView1.FocusedRowHandle, "NOISINH").ToString();
            newTable.Cell(0, 7).Range.Text = layoutView1.GetRowCellValue(layoutView1.FocusedRowHandle, "TAINANG").ToString();
            newTable.Cell(0, 8).Range.Text = layoutView1.GetRowCellValue(layoutView1.FocusedRowHandle, "SUNGHIEP").ToString();
            newTable.Cell(0, 9).Range.Text = layoutView1.GetRowCellValue(layoutView1.FocusedRowHandle, "THANHTUU").ToString();
            newTable.Cell(0, 10).Range.Text = layoutView1.GetRowCellValue(layoutView1.FocusedRowHandle, "HOATDONG").ToString();
            newTable.Cell(0, 11).Range.Text = layoutView1.GetRowCellValue(layoutView1.FocusedRowHandle, "GIAITHUONG").ToString();
            newTable.Cell(0, 12).Range.Text = layoutView1.GetRowCellValue(layoutView1.FocusedRowHandle, "TENDANHMUC").ToString();

            Image img = null;

            try
            {
                img = Image.FromFile(client.GetPathHinhanh(layoutView1.GetRowCellValue(layoutView1.FocusedRowHandle, "TEN").ToString()));
            }
            catch
            {
            }
            Clipboard.SetImage(img);
            newTable.Cell(0, 13).Range.Paste();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.PerformClick();
        }

        private void layoutView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                Image img = Image.FromFile(client.GetPathHinhanh(layoutView1.GetRowCellValue(layoutView1.FocusedRowHandle, "TEN").ToString()));
                pictureEdit1.Image = img;
            }
            catch
            {
                pictureEdit1.Image = null;
                pictureEdit1.ErrorText = "No image data";
            }
        }
    }
}
