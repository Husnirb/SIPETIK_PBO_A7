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
            kliklogout = new PictureBox();
            klikBeranda = new PictureBox();
            klikTiket = new PictureBox();
            klikTransaksi = new PictureBox();
            klikEdit = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)kliklogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)klikBeranda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)klikTiket).BeginInit();
            ((System.ComponentModel.ISupportInitialize)klikTransaksi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)klikEdit).BeginInit();
            SuspendLayout();
            // 
            // nama1
            // 
            nama1.BackColor = Color.Transparent;
            nama1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nama1.ForeColor = Color.FromArgb(110, 23, 23);
            nama1.Location = new Point(569, 281);
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
            nama2.Location = new Point(152, 145);
            nama2.Name = "nama2";
            nama2.Size = new Size(150, 48);
            nama2.TabIndex = 1;
            nama2.Text = "nama";
            // 
            // id_akun
            // 
            id_akun.BackColor = Color.Transparent;
            id_akun.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            id_akun.ForeColor = Color.DarkRed;
            id_akun.Location = new Point(526, 400);
            id_akun.Name = "id_akun";
            id_akun.Size = new Size(263, 41);
            id_akun.TabIndex = 2;
            id_akun.Text = "idakun";
            // 
            // email
            // 
            email.BackColor = Color.Transparent;
            email.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            email.ForeColor = Color.DarkRed;
            email.Location = new Point(526, 501);
            email.Name = "email";
            email.Size = new Size(263, 38);
            email.TabIndex = 5;
            email.Text = "email";
            // 
            // kliklogout
            // 
            kliklogout.BackColor = Color.Transparent;
            kliklogout.Cursor = Cursors.Hand;
            kliklogout.Location = new Point(609, 640);
            kliklogout.Name = "kliklogout";
            kliklogout.Size = new Size(123, 48);
            kliklogout.TabIndex = 6;
            kliklogout.TabStop = false;
            kliklogout.Click += kliklogout_Click;
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
            // klikTransaksi
            // 
            klikTransaksi.BackColor = Color.Transparent;
            klikTransaksi.Cursor = Cursors.Hand;
            klikTransaksi.Location = new Point(936, 30);
            klikTransaksi.Name = "klikTransaksi";
            klikTransaksi.Size = new Size(138, 51);
            klikTransaksi.TabIndex = 10;
            klikTransaksi.TabStop = false;
            klikTransaksi.Click += klikTransaksi_Click;
            // 
            // klikEdit
            // 
            klikEdit.BackColor = Color.Transparent;
            klikEdit.Cursor = Cursors.Hand;
            klikEdit.Location = new Point(944, 218);
            klikEdit.Name = "klikEdit";
            klikEdit.Size = new Size(54, 50);
            klikEdit.TabIndex = 11;
            klikEdit.TabStop = false;
            klikEdit.Click += klikEdit_Click;
            // 
            // V_Profil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1280, 720);
            Controls.Add(klikEdit);
            Controls.Add(klikTransaksi);
            Controls.Add(klikTiket);
            Controls.Add(klikBeranda);
            Controls.Add(email);
            Controls.Add(id_akun);
            Controls.Add(nama1);
            Controls.Add(kliklogout);
            Controls.Add(nama2);
            Name = "V_Profil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_Profil";
            Load += V_Profil_Load;
            ((System.ComponentModel.ISupportInitialize)kliklogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)klikBeranda).EndInit();
            ((System.ComponentModel.ISupportInitialize)klikTiket).EndInit();
            ((System.ComponentModel.ISupportInitialize)klikTransaksi).EndInit();
            ((System.ComponentModel.ISupportInitialize)klikEdit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label nama1;
        private Label nama2;
        private Label id_akun;
        private Label email;
        private PictureBox kliklogout;
        private PictureBox klikBeranda;
        private PictureBox klikTiket;
        private PictureBox klikTransaksi;
        private PictureBox klikEdit;
    }
}