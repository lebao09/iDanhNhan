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
    public partial class AccountInformation : Form
    {
        DanhNhanSH.DanhnhanClient client = new DanhNhanSH.DanhnhanClient();

        public AccountInformation()
        {
            InitializeComponent();
            username.Text = BIENTOANCUC.USERNAME;
            password.Text = BIENTOANCUC.PASSWORD;
            timelogin.Text = BIENTOANCUC.LASTTIME;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Ẩn mật khẩu";
                password.Properties.PasswordChar = '\0';
            }
            else
            {
                checkBox1.Text = "Hiện mậtkhẩu";
                password.Properties.PasswordChar = '*';
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(256, 432);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Size = new Size(256, 293);
            newpassword.Text = null;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cập nhật mật khẩu thành công");
            client.ExcuteNoneQuery("UPDATE ACCOUNT SET PASSWORD = '" + newpassword.Text + "' WHERE USERNAME = '" + username.Text + "'");
            BIENTOANCUC.PASSWORD = newpassword.Text;
            password.Text = BIENTOANCUC.PASSWORD;
            simpleButton3.PerformClick();
        }

        private void AccountInformation_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Close();
        }
    }
}
