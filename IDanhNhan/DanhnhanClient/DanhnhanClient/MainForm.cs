using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DanhnhanClient
{
    public partial class MainForm : Form
    {
        String[,] all;
        Int32 selected = 0;
        ToolTip tt = new ToolTip();
        DanhNhanSH.DanhnhanClient client = new DanhNhanSH.DanhnhanClient();

        public MainForm()
        {
            InitializeComponent();
            if (BIENTOANCUC.LOGIN)
            {
                accountToolStripMenuItem.Visible = true;
                quanlyToolStripMenuItem.Visible = true;
            }
            else
            {
                accountToolStripMenuItem.Visible = false;
                quanlyToolStripMenuItem.Visible = false;
            }

            foreach (Control control in groupBox1.Controls)
            {
                Label lb = control as Label;
                if (lb != null)
                {
                    lb.MouseHover += new EventHandler(lb_MouseHover);
                    lb.MouseLeave += new EventHandler(lb_MouseLeave);
                    lb.MouseClick += new MouseEventHandler(lb_MouseClick);
                }
            }

            foreach (Control control in groupBox2.Controls)
            {
                Label lb = control as Label;
                if (lb != null)
                {
                    lb.MouseHover += new EventHandler(lb_MouseHovergb2);
                    lb.MouseLeave += new EventHandler(lb_MouseLeavegb2);
                    lb.MouseClick += new MouseEventHandler(lb_MouseClickgb2);
                }
            }
        }

        private void MainForm_Load(Object sender, EventArgs e)
        {
            LoadALL();
        }

        private void LoadALL()
        {
            DataTable dt = client.ShowAll().Tables[0];
            all = new String[dt.Rows.Count, 13];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                all[i, 0] = dt.Rows[i][2].ToString();
                all[i, 1] = dt.Rows[i][3].ToString();
                all[i, 2] = dt.Rows[i][4].ToString();
                all[i, 3] = dt.Rows[i][5].ToString();
                all[i, 4] = dt.Rows[i][6].ToString();
                all[i, 5] = dt.Rows[i][7].ToString();
                all[i, 6] = dt.Rows[i][8].ToString();
                all[i, 7] = dt.Rows[i][9].ToString();
                all[i, 8] = dt.Rows[i][10].ToString();
                all[i, 9] = dt.Rows[i][11].ToString();
                all[i, 10] = dt.Rows[i][12].ToString();
                all[i, 11] = dt.Rows[i][1].ToString();
                all[i, 12] = client.GetPathHinhanh(dt.Rows[i][2].ToString());
            }
        }

        private void timer1_Tick(Object sender, EventArgs e)
        {
            showImage();
        }

        private void showImage()
        {
            try
            {
                Image imgtemp = new Bitmap(all[selected, 12]);
                pictureBox1.Image = imgtemp;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                selected++;
            }
            catch
            {
            }
            finally
            {
                if (selected >= all.Length / 13)
                    selected = 0;
            }
        }

        private void pictureBox1_MouseHover(Object sender, EventArgs e)
        {
            int index = selected;
            if (selected > 0)
                index -= 1;
            timer1.Enabled = false;
            tt.SetToolTip(pictureBox1,
                "Tên: " + all[index, 0] + Environment.NewLine +
                "Năm sinh: " + all[index, 3] + Environment.NewLine +
                "Năm mất: " + all[index, 4]);
        }

        private void pictureBox1_MouseLeave(Object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void pictureBox1_Click(Object sender, EventArgs e)
        {
            Detail dt = new Detail();
            this.Hide();
            dt.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            BIENTOANCUC.LOGIN = false;
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Close();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            AccountInformation ai = new AccountInformation();
            this.Hide();
            ai.ShowDialog();
        }

        private void lb_MouseHover(Object sender, EventArgs e)
        {
            Label lb = ((Label)sender);
            lb.ForeColor = Color.White;
            lb.BackColor = Color.LawnGreen;
        }

        private void lb_MouseLeave(Object sender, EventArgs e)
        {
            Label lb = ((Label)sender);
            lb.ForeColor = Color.FromArgb(0, 192, 0);
            lb.BackColor = Color.Empty;
        }

        private void lb_MouseHovergb2(Object sender, EventArgs e)
        {
            Label lb = ((Label)sender);
            lb.ForeColor = Color.White;
            lb.BackColor = Color.FromArgb(255, 128, 0);
        }

        private void lb_MouseLeavegb2(Object sender, EventArgs e)
        {
            Label lb = ((Label)sender);
            lb.ForeColor = Color.FromArgb(192, 64, 0);
            lb.BackColor = Color.Empty;
        }

        private void lb_MouseClick(Object sender, EventArgs e)
        {
            Label lb = ((Label)sender);
            BIENTOANCUC.NAMETEXTCLICKED = lb.Text;

            TimKiem tk = new TimKiem();
            this.Hide();
            tk.ShowDialog();
        }

        private void lb_MouseClickgb2(Object sender, EventArgs e)
        {
            Label lb = ((Label)sender);
            BIENTOANCUC.TOPICTEXTCLICKED = lb.Text;

            TimKiem tk = new TimKiem();
            this.Hide();
            tk.ShowDialog();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm lf = new LoginForm();
            this.Close();
            lf.Show();
        }

        private void layoutView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            e.Value = Image.FromFile(client.GetPathHinhanh("Léonard Da Vinci "));
        }
    }
}
