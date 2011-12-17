namespace DanhnhanClient
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongtintaikhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangxuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanlydulieuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.quanlyToolStripMenuItem,
            this.sToolStripMenuItem,
            this.aboutUsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(618, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thongtintaikhoanToolStripMenuItem,
            this.dangxuatToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.accountToolStripMenuItem.Text = "Tài khoản";
            this.accountToolStripMenuItem.Visible = false;
            // 
            // thongtintaikhoanToolStripMenuItem
            // 
            this.thongtintaikhoanToolStripMenuItem.Name = "thongtintaikhoanToolStripMenuItem";
            this.thongtintaikhoanToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.thongtintaikhoanToolStripMenuItem.Text = "Thông tin tài khoản";
            this.thongtintaikhoanToolStripMenuItem.Click += new System.EventHandler(this.thôngTinTàiKhoảnToolStripMenuItem_Click);
            // 
            // dangxuatToolStripMenuItem
            // 
            this.dangxuatToolStripMenuItem.Name = "dangxuatToolStripMenuItem";
            this.dangxuatToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.dangxuatToolStripMenuItem.Text = "Đăng xuất";
            this.dangxuatToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // quanlyToolStripMenuItem
            // 
            this.quanlyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanlydulieuToolStripMenuItem});
            this.quanlyToolStripMenuItem.Name = "quanlyToolStripMenuItem";
            this.quanlyToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.quanlyToolStripMenuItem.Text = "Quản lý";
            this.quanlyToolStripMenuItem.Visible = false;
            // 
            // quanlydulieuToolStripMenuItem
            // 
            this.quanlydulieuToolStripMenuItem.Name = "quanlydulieuToolStripMenuItem";
            this.quanlydulieuToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.quanlydulieuToolStripMenuItem.Text = "Quản lý dữ liệu";
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.sToolStripMenuItem.Text = "Tìm kiếm nâng cao";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.aboutUsToolStripMenuItem.Text = "About us";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(64, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 79);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo tên";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label25.Location = new System.Drawing.Point(558, 34);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(16, 16);
            this.label25.TabIndex = 0;
            this.label25.Text = "Z";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label20.Location = new System.Drawing.Point(439, 34);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(18, 16);
            this.label20.TabIndex = 0;
            this.label20.Text = "U";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label30.Location = new System.Drawing.Point(246, 60);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(87, 16);
            this.label30.TabIndex = 0;
            this.label30.Text = "Hiển thị tất cả";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(209, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "J";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label24.Location = new System.Drawing.Point(535, 34);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(17, 16);
            this.label24.TabIndex = 0;
            this.label24.Text = "Y";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label19.Location = new System.Drawing.Point(416, 34);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 16);
            this.label19.TabIndex = 0;
            this.label19.Text = "T";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(192, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "I";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label23.Location = new System.Drawing.Point(513, 34);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(16, 16);
            this.label23.TabIndex = 0;
            this.label23.Text = "X";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label18.Location = new System.Drawing.Point(393, 34);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 16);
            this.label18.TabIndex = 0;
            this.label18.Text = "S";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(168, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "H";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label22.Location = new System.Drawing.Point(486, 34);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(21, 16);
            this.label22.TabIndex = 0;
            this.label22.Text = "W";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label17.Location = new System.Drawing.Point(369, 34);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(18, 16);
            this.label17.TabIndex = 0;
            this.label17.Text = "R";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label21.Location = new System.Drawing.Point(463, 34);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(17, 16);
            this.label21.TabIndex = 0;
            this.label21.Text = "V";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(144, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "G";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label16.Location = new System.Drawing.Point(346, 34);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 16);
            this.label16.TabIndex = 0;
            this.label16.Text = "P";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(122, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "F";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(322, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 16);
            this.label15.TabIndex = 0;
            this.label15.Text = "O";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(99, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "E";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(298, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "N";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(75, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "D";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(273, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "M";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(52, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "C";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(252, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "L";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(29, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "B";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(230, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "K";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "A";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label31);
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox2.Location = new System.Drawing.Point(445, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 149);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm theo chủ đề";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label31.Location = new System.Drawing.Point(6, 130);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(87, 16);
            this.label31.TabIndex = 0;
            this.label31.Text = "Hiển thị tất cả";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label29.Location = new System.Drawing.Point(6, 106);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(114, 16);
            this.label29.TabIndex = 0;
            this.label29.Text = "Kinh tế ngoại giao";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label28.Location = new System.Drawing.Point(6, 82);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(112, 16);
            this.label28.TabIndex = 0;
            this.label28.Text = "Khoa học tự nhiên";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label27.Location = new System.Drawing.Point(6, 58);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(122, 16);
            this.label27.TabIndex = 0;
            this.label27.Text = "Văn hoá nghệ thuật";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label26.Location = new System.Drawing.Point(6, 34);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(57, 16);
            this.label26.TabIndex = 0;
            this.label26.Text = "Quân sự";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 367);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chính";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongtintaikhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangxuatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem quanlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanlydulieuToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
    }
}