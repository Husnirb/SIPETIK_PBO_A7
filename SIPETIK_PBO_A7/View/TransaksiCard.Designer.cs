namespace SIPETIK_PBO_A7.View
{
    partial class TransaksiCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransaksiCard));
            klikDetail = new PictureBox();
            lblHarga = new Label();
            lblTglTransaksi = new Label();
            lblNamaUser = new Label();
            lblStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)klikDetail).BeginInit();
            SuspendLayout();
            // 
            // klikDetail
            // 
            klikDetail.BackColor = Color.Transparent;
            klikDetail.Cursor = Cursors.Hand;
            klikDetail.Location = new Point(327, 62);
            klikDetail.Name = "klikDetail";
            klikDetail.Size = new Size(112, 31);
            klikDetail.TabIndex = 9;
            klikDetail.TabStop = false;
            klikDetail.Click += klikDetail_Click_1;
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.BackColor = Color.Transparent;
            lblHarga.Font = new Font("Bookman Old Style", 8.5F, FontStyle.Bold);
            lblHarga.ForeColor = SystemColors.ActiveCaptionText;
            lblHarga.Location = new Point(101, 29);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(52, 18);
            lblHarga.TabIndex = 12;
            lblHarga.Text = "harga";
            // 
            // lblTglTransaksi
            // 
            lblTglTransaksi.AutoSize = true;
            lblTglTransaksi.BackColor = Color.Transparent;
            lblTglTransaksi.Font = new Font("Bookman Old Style", 8.5F, FontStyle.Bold);
            lblTglTransaksi.ForeColor = SystemColors.ActiveCaptionText;
            lblTglTransaksi.Location = new Point(101, 51);
            lblTglTransaksi.Name = "lblTglTransaksi";
            lblTglTransaksi.Size = new Size(143, 18);
            lblTglTransaksi.TabIndex = 13;
            lblTglTransaksi.Text = "tanggalTransaksi";
            // 
            // lblNamaUser
            // 
            lblNamaUser.AutoSize = true;
            lblNamaUser.BackColor = Color.Transparent;
            lblNamaUser.Font = new Font("Bookman Old Style", 8.5F, FontStyle.Bold);
            lblNamaUser.ForeColor = SystemColors.ActiveCaptionText;
            lblNamaUser.Location = new Point(101, 75);
            lblNamaUser.Name = "lblNamaUser";
            lblNamaUser.Size = new Size(51, 18);
            lblNamaUser.TabIndex = 14;
            lblNamaUser.Text = "nama";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Bookman Old Style", 7F, FontStyle.Bold);
            lblStatus.ForeColor = Color.ForestGreen;
            lblStatus.Location = new Point(297, 5);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(144, 14);
            lblStatus.TabIndex = 15;
            lblStatus.Text = "belum_terkonfirmasi";
            // 
            // TransaksiCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(lblStatus);
            Controls.Add(lblNamaUser);
            Controls.Add(lblTglTransaksi);
            Controls.Add(lblHarga);
            Controls.Add(klikDetail);
            DoubleBuffered = true;
            Name = "TransaksiCard";
            Size = new Size(442, 96);
            ((System.ComponentModel.ISupportInitialize)klikDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox klikDetail;
        private Label lblHarga;
        private Label lblTglTransaksi;
        private Label lblNamaUser;
        private Label lblStatus;
    }
}
