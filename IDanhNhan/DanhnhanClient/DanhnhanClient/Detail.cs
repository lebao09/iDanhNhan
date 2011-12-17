using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DanhnhanClient
{
    public partial class Detail : Form
    {
        public Detail()
        {
            InitializeComponent();
            LoadALL();
        }

        private void LoadALL()
        {
            if (BIENTOANCUC.dt != null)
                gridControl1.DataSource = BIENTOANCUC.dt;
            try
            {
                name.Text = BIENTOANCUC.dt.Rows[0][2].ToString();
                name.Location = new Point(panel2.Width / 2 - name.Width / 2, panel2.Height / 2 - name.Height / 2);
                Image img = Image.FromFile(BIENTOANCUC.imagepath);
                pictureBox1.Image = img;
            }
            catch
            {
            }
        }

        private void Detail_FormClosed(object sender, FormClosedEventArgs e)
        {
            BIENTOANCUC.dt = null;
            BIENTOANCUC.imagepath = null;
            TimKiem tk = new TimKiem();
            this.Close();
            tk.Show();
        }
    }
}
