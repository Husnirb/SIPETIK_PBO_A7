namespace SIPETIK_PBO_A7.View
{
    partial class V_DetailTransaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_DetailTransaksi));
            btnKembali = new PictureBox();
            lbltotalharga = new Label();
            lbljumlah = new Label();
            lbltanggal = new Label();
            label1 = new Label();
            lblidtransaksi = new Label();
            lblstatus = new Label();
            btnUbahStatus = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btnKembali).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnUbahStatus).BeginInit();
            SuspendLayout();
            // 
            // btnKembali
            // 
            btnKembali.BackColor = Color.Transparent;
            btnKembali.Cursor = Cursors.Hand;
            btnKembali.Location = new Point(926, 468);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(133, 51);
            btnKembali.TabIndex = 10;
            btnKembali.TabStop = false;
            // 
            // lbltotalharga
            // 
            lbltotalharga.AutoSize = true;
            lbltotalharga.BackColor = Color.Transparent;
            lbltotalharga.Font = new Font("Bookman Old Style", 14F, FontStyle.Bold);
            lbltotalharga.ForeColor = Color.DarkRed;
            lbltotalharga.Location = new Point(714, 389);
            lbltotalharga.Name = "lbltotalharga";
            lbltotalharga.Size = new Size(81, 28);
            lbltotalharga.TabIndex = 13;
            lbltotalharga.Text = "harga";
            // 
            // lbljumlah
            // 
            lbljumlah.AutoSize = true;
            lbljumlah.BackColor = Color.Transparent;
            lbljumlah.Font = new Font("Bookman Old Style", 14F, FontStyle.Bold);
            lbljumlah.ForeColor = Color.DarkRed;
            lbljumlah.Location = new Point(714, 351);
            lbljumlah.Name = "lbljumlah";
            lbljumlah.Size = new Size(98, 28);
            lbljumlah.TabIndex = 14;
            lbljumlah.Text = "jumlah";
            // 
            // lbltanggal
            // 
            lbltanggal.AutoSize = true;
            lbltanggal.BackColor = Color.Transparent;
            lbltanggal.Font = new Font("Bookman Old Style", 14F, FontStyle.Bold);
            lbltanggal.ForeColor = Color.DarkRed;
            lbltanggal.Location = new Point(714, 427);
            lbltanggal.Name = "lbltanggal";
            lbltanggal.Size = new Size(103, 28);
            lbltanggal.TabIndex = 15;
            lbltanggal.Text = "tanggal";
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // lblidtransaksi
            // 
            lblidtransaksi.AutoSize = true;
            lblidtransaksi.BackColor = Color.Transparent;
            lblidtransaksi.Font = new Font("Bookman Old Style", 18F, FontStyle.Bold);
            lblidtransaksi.ForeColor = Color.DarkRed;
            lblidtransaksi.Location = new Point(752, 281);
            lblidtransaksi.Name = "lblidtransaksi";
            lblidtransaksi.Size = new Size(122, 36);
            lblidtransaksi.TabIndex = 16;
            lblidtransaksi.Text = "jumlah";
            // 
            // lblstatus
            // 
            lblstatus.AutoSize = true;
            lblstatus.BackColor = Color.Transparent;
            lblstatus.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold);
            lblstatus.ForeColor = Color.Black;
            lblstatus.Location = new Point(881, 191);
            lblstatus.Name = "lblstatus";
            lblstatus.Size = new Size(224, 24);
            lblstatus.TabIndex = 17;
            lblstatus.Text = "belum_terkonfirmasi";
            // 
            // btnUbahStatus
            // 
            btnUbahStatus.BackColor = Color.Transparent;
            btnUbahStatus.BackgroundImage = Properties.Resources.ubah;
            btnUbahStatus.BackgroundImageLayout = ImageLayout.Stretch;
            btnUbahStatus.Cursor = Cursors.Hand;
            btnUbahStatus.Location = new Point(752, 179);
            btnUbahStatus.Name = "btnUbahStatus";
            btnUbahStatus.Size = new Size(107, 55);
            btnUbahStatus.TabIndex = 18;
            btnUbahStatus.TabStop = false;
            btnUbahStatus.Click += btnUbahStatus_Click;
            // 
            // V_DetailTransaksi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1262, 673);
            Controls.Add(btnUbahStatus);
            Controls.Add(lblstatus);
            Controls.Add(lblidtransaksi);
            Controls.Add(label1);
            Controls.Add(lbltanggal);
            Controls.Add(lbljumlah);
            Controls.Add(lbltotalharga);
            Controls.Add(btnKembali);
            DoubleBuffered = true;
            Name = "V_DetailTransaksi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_DetailTransaksi";
            ((System.ComponentModel.ISupportInitialize)btnKembali).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnUbahStatus).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox btnKembali;
        private Label lbltotalharga;
        private Label lbljumlah;
        private Label lbltanggal;
        private Label label1;
        private Label lblidtransaksi;
        private Label lblstatus;
        private PictureBox btnUbahStatus;
    }
}