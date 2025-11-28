namespace SIPETIK_PBO_A7.View
{
    partial class V_Profil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Profil));
            nama1 = new Label();
            nama2 = new Label();
            id_akun = new Label();
            nama3 = new Label();
            password = new Label();
            email = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // nama1
            // 
            nama1.BackColor = Color.Transparent;
            nama1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nama1.ForeColor = Color.FromArgb(110, 23, 23);
            nama1.Location = new Point(592, 300);
            nama1.Name = "nama1";
            nama1.Size = new Size(150, 46);
            nama1.TabIndex = 0;
            nama1.Text = "nama";
            // 
            // nama2
            // 
            nama2.BackColor = Color.Transparent;
            nama2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nama2.ForeColor = Color.FromArgb(246, 175, 175);
            nama2.Location = new Point(93, 139);
            nama2.Name = "nama2";
            nama2.Size = new Size(150, 48);
            nama2.TabIndex = 1;
            nama2.Text = "nama";
            // 
            // id_akun
            // 
            id_akun.BackColor = Color.Transparent;
            id_akun.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            id_akun.ForeColor = SystemColors.ControlText;
            id_akun.Location = new Point(307, 406);
            id_akun.Name = "id_akun";
            id_akun.Size = new Size(263, 41);
            id_akun.TabIndex = 2;
            id_akun.Text = "idakun";
            // 
            // nama3
            // 
            nama3.BackColor = Color.Transparent;
            nama3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nama3.ForeColor = SystemColors.ControlText;
            nama3.Location = new Point(305, 504);
            nama3.Name = "nama3";
            nama3.Size = new Size(263, 42);
            nama3.TabIndex = 3;
            nama3.Text = "nama";
            // 
            // password
            // 
            password.BackColor = Color.Transparent;
            password.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            password.ForeColor = SystemColors.ControlText;
            password.Location = new Point(673, 403);
            password.Name = "password";
            password.Size = new Size(263, 44);
            password.TabIndex = 4;
            password.Text = "password";
            // 
            // email
            // 
            email.BackColor = Color.Transparent;
            email.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            email.ForeColor = SystemColors.ControlText;
            email.Location = new Point(673, 504);
            email.Name = "email";
            email.Size = new Size(263, 38);
            email.TabIndex = 5;
            email.Text = "email";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(566, 641);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 42);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Location = new Point(617, 38);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 37);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // V_Profil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1280, 720);
            Controls.Add(pictureBox2);
            Controls.Add(email);
            Controls.Add(nama3);
            Controls.Add(id_akun);
            Controls.Add(password);
            Controls.Add(nama1);
            Controls.Add(pictureBox1);
            Controls.Add(nama2);
            Name = "V_Profil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_Profil";
            Load += V_Profil_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label nama1;
        private Label nama2;
        private Label id_akun;
        private Label nama3;
        private Label password;
        private Label email;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}