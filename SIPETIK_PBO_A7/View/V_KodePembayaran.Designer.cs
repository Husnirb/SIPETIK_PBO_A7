namespace SIPETIK_PBO_A7.View
{
    partial class V_KodePembayaran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_KodePembayaran));
            klikBeranda = new PictureBox();
            lblTotalTiket = new Label();
            lblTotalHarga = new Label();
            klikSelesai = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)klikBeranda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)klikSelesai).BeginInit();
            SuspendLayout();
            // 
            // klikBeranda
            // 
            klikBeranda.BackColor = Color.Transparent;
            klikBeranda.Cursor = Cursors.Hand;
            klikBeranda.Location = new Point(599, 28);
            klikBeranda.Name = "klikBeranda";
            klikBeranda.Size = new Size(628, 51);
            klikBeranda.TabIndex = 10;
            klikBeranda.TabStop = false;
            klikBeranda.Click += klikBeranda_Click;
            // 
            // lblTotalTiket
            // 
            lblTotalTiket.AutoSize = true;
            lblTotalTiket.BackColor = Color.Transparent;
            lblTotalTiket.Font = new Font("Arial Black", 11F, FontStyle.Bold);
            lblTotalTiket.ForeColor = SystemColors.ControlLightLight;
            lblTotalTiket.Location = new Point(648, 266);
            lblTotalTiket.Name = "lblTotalTiket";
            lblTotalTiket.Size = new Size(107, 27);
            lblTotalTiket.TabIndex = 11;
            lblTotalTiket.Text = "totaltiket";
            // 
            // lblTotalHarga
            // 
            lblTotalHarga.AutoSize = true;
            lblTotalHarga.BackColor = Color.Transparent;
            lblTotalHarga.Font = new Font("Arial Black", 11F, FontStyle.Bold);
            lblTotalHarga.ForeColor = SystemColors.ControlLightLight;
            lblTotalHarga.Location = new Point(648, 294);
            lblTotalHarga.Name = "lblTotalHarga";
            lblTotalHarga.Size = new Size(120, 27);
            lblTotalHarga.TabIndex = 12;
            lblTotalHarga.Text = "totalharga";
            // 
            // klikSelesai
            // 
            klikSelesai.BackColor = Color.Transparent;
            klikSelesai.Cursor = Cursors.Hand;
            klikSelesai.Location = new Point(804, 492);
            klikSelesai.Name = "klikSelesai";
            klikSelesai.Size = new Size(120, 50);
            klikSelesai.TabIndex = 13;
            klikSelesai.TabStop = false;
            klikSelesai.Click += klikSelesai_Click;
            // 
            // V_KodePembayaran
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1262, 673);
            Controls.Add(klikSelesai);
            Controls.Add(lblTotalHarga);
            Controls.Add(lblTotalTiket);
            Controls.Add(klikBeranda);
            DoubleBuffered = true;
            Name = "V_KodePembayaran";
            Text = "V_KodePembayaran";
            Load += V_KodePembayaran_Load;
            ((System.ComponentModel.ISupportInitialize)klikBeranda).EndInit();
            ((System.ComponentModel.ISupportInitialize)klikSelesai).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox klikBeranda;
        private Label lblTotalTiket;
        private Label lblTotalHarga;
        private PictureBox klikSelesai;
    }
}