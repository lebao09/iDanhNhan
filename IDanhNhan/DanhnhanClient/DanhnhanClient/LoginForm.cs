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
    public partial class LoginForm : Form
    {
        DanhNhanSH.DanhnhanClient client = new DanhNhanSH.DanhnhanClient();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            NewForm();
        }
        private void NewForm()
        {
            if (CheckService())
            {
                MainForm mf = new MainForm();
                mf.ShowDialog();
                this.Hide();
            }
            else
                MessageBox.Show("Không thể kết nối tới service", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DataTable dt = client.GetTable("SELECT LASTTIME FROM ACCOUNT WHERE USERNAME ='" + username.Text + "' AND PASSWORD ='" + password.Text + "'").Tables[0];

            if (dt.Rows.Count > 0)
            {
                client.ExcuteNoneQuery("UPDATE ACCOUNT SET LASTTIME = '" + System.DateTime.Now + "' WHERE USERNAME = '" + username.Text + "'");
                BIENTOANCUC.LOGIN = true;
                BIENTOANCUC.USERNAME = username.Text;
                BIENTOANCUC.PASSWORD = password.Text;
                BIENTOANCUC.LASTTIME = System.DateTime.Now.ToString();
                username.Text = null;
                password.Text = null;
                NewForm();
            }
        }

        private Boolean CheckService() // TRUE MEANS SERVICE IS AVAILABLE
        {
            Boolean check = false;
            try
            {
                client.GetAuthors();
                check = true;
            }
            catch
            {
            }

            return check;
        }
    }
}
