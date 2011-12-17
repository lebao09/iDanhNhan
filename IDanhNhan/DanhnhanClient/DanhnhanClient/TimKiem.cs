using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;

namespace DanhnhanClient
{
    public partial class TimKiem : Form
    {
        DanhNhanSH.DanhnhanClient client = new DanhNhanSH.DanhnhanClient();
        ToolTip tt = new ToolTip();

        public TimKiem()
        {
            InitializeComponent();
            tt.UseFading = false;
            tt.UseAnimation = false;
        }

        private void LoadTimkiem()
        {
            DataTable dt;
            if (!String.IsNullOrEmpty(BIENTOANCUC.NAMETEXTCLICKED))
                LoadLV();
            else
            {
                panel1.Visible = false;
                panel2.Dock = DockStyle.Fill;
                treeView1.Dock = DockStyle.Fill;
                
                TreeNode node = null;
                if (!BIENTOANCUC.TOPICTEXTCLICKED.Equals("Hiển thị tất cả"))
                {
                    node = treeView1.Nodes.Add(BIENTOANCUC.TOPICTEXTCLICKED);
                    String query = "SELECT TEN, TENDANHMUC FROM DANHNHAN WHERE TENDANHMUC = N'" + BIENTOANCUC.TOPICTEXTCLICKED + "'";
                    dt = client.GetTable(query).Tables[0];
                    for (int i = 0; i < dt.Rows.Count; i++)
                        node.Nodes.Add(dt.Rows[i][0].ToString());
                }
                else
                {
                    DataTable tdm = client.GetTable("SELECT DISTINCT(TENDANHMUC) FROM DANHNHAN").Tables[0];
                    for (int i = 0; i < tdm.Rows.Count; i++)
                    {
                        if (!String.IsNullOrEmpty(tdm.Rows[i][0].ToString()))
                            node = treeView1.Nodes.Add(tdm.Rows[i][0].ToString());
                        DataTable ten = client.GetTable("SELECT TEN FROM DANHNHAN WHERE TENDANHMUC = N'" + tdm.Rows[i][0].ToString() + "'").Tables[0];
                        for (int j = 0; j < ten.Rows.Count; j++)
                            node.Nodes.Add(ten.Rows[j][0].ToString());
                    }
                }
            }
        }

        private void LoadLV()
        {
            panel2.Visible = false;
            panel1.Visible = true;
            panel1.Dock = DockStyle.Fill;
            dataGridView1.Dock = DockStyle.Fill;
            String query = "SELECT * FROM DANHNHAN";

            if (!String.IsNullOrEmpty(textBox1.Text))
                query += " WHERE " + GetComboBox() + " LIKE '%" + textBox1.Text + "%'";
            if (!String.IsNullOrEmpty(comboBox2.Text))
                query += " AND TENDANHMUC = N'" + comboBox2.Text + "'";

            DataTable dt = client.GetTable(query).Tables[0];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dataGridView1.Rows.Add(new String[] { dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), 
                    dt.Rows[i][4].ToString(), dt.Rows[i][5].ToString(), dt.Rows[i][6].ToString(), 
                    dt.Rows[i][7].ToString(), dt.Rows[i][8].ToString(), dt.Rows[i][9].ToString(), 
                    dt.Rows[i][10].ToString(), dt.Rows[i][11].ToString(), dt.Rows[i][12].ToString(), 
                    dt.Rows[i][1].ToString()});
                DataGridViewImageColumn img = new DataGridViewImageColumn();
                Image image = null;
                try
                {
                    image = Image.FromFile(client.GetPathHinhanh(dt.Rows[i][2].ToString()));
                }
                catch
                {
                }
                dataGridView1.Rows[i].Cells[12].Value = image;
            }
        }

        private void TimKiem_FormClosed(object sender, FormClosedEventArgs e)
        {
            BIENTOANCUC.NAMETEXTCLICKED = null;
            BIENTOANCUC.TOPICTEXTCLICKED = null;
            MainForm mf = new MainForm();
            mf.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadLV();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.PerformClick();
        }

        private void LoadTable(String option)
        {
            String query = "SELECT * FROM DANHNHAN " + option;
            dataGridView1.DataSource = client.GetTable(query.Trim()).Tables[0];
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Nodes.Count < 1)
            {
                textBox1.Text = e.Node.Text;
                BIENTOANCUC.NAMETEXTCLICKED = null;
                LoadLV();
            }
        }

        private void comboBox1_MouseEnter(object sender, EventArgs e)
        {
            tt.SetToolTip(comboBox1, "Tìm kiếm theo " + comboBox1.Text);
        }

        private void comboBox2_MouseEnter(object sender, EventArgs e)
        {
            tt.SetToolTip(comboBox2, "Tìm kiếm theo danh mục " + comboBox2.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                BIENTOANCUC.dt = client.GetTable("SELECT * FROM DANHNHAN WHERE TEN = N'" + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "'").Tables[0];
                BIENTOANCUC.imagepath = System.IO.Path.GetFullPath(client.GetTable("SELECT HINH FROM HINHANH WHERE TEN = N'" + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "'").Tables[0].Rows[0][0].ToString());
                Detail dtl = new Detail();
                this.Hide();
                dtl.ShowDialog();
            }
        }

        private void TimKiem_Load(object sender, EventArgs e)
        {
            LoadTimkiem();
        }
    }
}
