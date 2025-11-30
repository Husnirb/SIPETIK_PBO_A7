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
            email = new Label();
            pictureBox1 = new PictureBox();
            klikBeranda = new PictureBox();
            klikTiket = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)klikBeranda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)klikTiket).BeginInit();
            SuspendLayout();
            // 
            // nama1
            // 
            nama1.BackColor = Color.Transparent;
            nama1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nama1.ForeColor = Color.FromArgb(110, 23, 23);
            nama1.Location = new Point(592, 307);
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
            nama2.Location = new Point(93, 140);
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
            id_akun.Location = new Point(512, 414);
            id_akun.Name = "id_akun";
            id_akun.Size = new Size(263, 41);
            id_akun.TabIndex = 2;
            id_akun.Text = "idakun";
            // 
            // email
            // 
            email.BackColor = Color.Transparent;
            email.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            email.ForeColor = SystemColors.ControlText;
            email.Location = new Point(512, 533);
            email.Name = "email";
            email.Size = new Size(263, 38);
            email.TabIndex = 5;
            email.Text = "email";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(566, 641);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 42);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // klikBeranda
            // 
            klikBeranda.BackColor = Color.Transparent;
            klikBeranda.Cursor = Cursors.Hand;
            klikBeranda.Location = new Point(617, 38);
            klikBeranda.Name = "klikBeranda";
            klikBeranda.Size = new Size(120, 37);
            klikBeranda.TabIndex = 7;
            klikBeranda.TabStop = false;
            klikBeranda.Click += klikBeranda_Click;
            // 
            // klikTiket
            // 
            klikTiket.BackColor = Color.Transparent;
            klikTiket.Cursor = Cursors.Hand;
            klikTiket.Location = new Point(779, 38);
            klikTiket.Name = "klikTiket";
            klikTiket.Size = new Size(120, 37);
            klikTiket.TabIndex = 8;
            klikTiket.TabStop = false;
            klikTiket.Click += klikTiket_Click;
            // 
            // V_Profil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1280, 720);
            Controls.Add(klikTiket);
            Controls.Add(klikBeranda);
            Controls.Add(email);
            Controls.Add(id_akun);
            Controls.Add(nama1);
            Controls.Add(pictureBox1);
            Controls.Add(nama2);
            Cursor = Cursors.Default;
            Name = "V_Profil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_Profil";
            Load += V_Profil_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)klikBeranda).EndInit();
            ((System.ComponentModel.ISupportInitialize)klikTiket).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label nama1;
        private Label nama2;
        private Label id_akun;
        private Label email;
        private PictureBox pictureBox1;
        private PictureBox klikBeranda;
        private PictureBox klikTiket;
    }
}