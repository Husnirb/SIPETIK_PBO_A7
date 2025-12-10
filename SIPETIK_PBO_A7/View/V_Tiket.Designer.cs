namespace SIPETIK_PBO_A7.View
{
    partial class V_Tiket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Tiket));
            klikBeranda = new PictureBox();
            klikprofil = new PictureBox();
            klikPesanTiket = new PictureBox();
            klikJumlah = new NumericUpDown();
            klikTransaksi = new PictureBox();
            pbjumlah = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)klikBeranda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)klikprofil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)klikPesanTiket).BeginInit();
            ((System.ComponentModel.ISupportInitialize)klikJumlah).BeginInit();
            ((System.ComponentModel.ISupportInitialize)klikTransaksi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbjumlah).BeginInit();
            SuspendLayout();
            // 
            // klikBeranda
            // 
            klikBeranda.BackColor = Color.Transparent;
            klikBeranda.Cursor = Cursors.Hand;
            klikBeranda.Location = new Point(600, 27);
            klikBeranda.Name = "klikBeranda";
            klikBeranda.Size = new Size(135, 51);
            klikBeranda.TabIndex = 9;
            klikBeranda.TabStop = false;
            klikBeranda.Click += klikBeranda_Click;
            // 
            // klikprofil
            // 
            klikprofil.BackColor = Color.Transparent;
            klikprofil.Cursor = Cursors.Hand;
            klikprofil.Location = new Point(1155, 24);
            klikprofil.Name = "klikprofil";
            klikprofil.Size = new Size(63, 58);
            klikprofil.TabIndex = 10;
            klikprofil.TabStop = false;
            klikprofil.Click += klikprofil_Click;
            // 
            // klikPesanTiket
            // 
            klikPesanTiket.BackColor = Color.Transparent;
            klikPesanTiket.BackgroundImage = Properties.Resources.pesantiketskrgV2;
            klikPesanTiket.BackgroundImageLayout = ImageLayout.Stretch;
            klikPesanTiket.Cursor = Cursors.Hand;
            klikPesanTiket.Location = new Point(994, 596);
            klikPesanTiket.Name = "klikPesanTiket";
            klikPesanTiket.Size = new Size(241, 52);
            klikPesanTiket.TabIndex = 11;
            klikPesanTiket.TabStop = false;
            klikPesanTiket.Click += klikPesanTiket_Click;
            // 
            // klikJumlah
            // 
            klikJumlah.Font = new Font("Segoe UI", 11.5F);
            klikJumlah.Location = new Point(908, 606);
            klikJumlah.Name = "klikJumlah";
            klikJumlah.Size = new Size(57, 33);
            klikJumlah.TabIndex = 12;
            klikJumlah.ValueChanged += klikJumlah_ValueChanged;
            // 
            // klikTransaksi
            // 
            klikTransaksi.BackColor = Color.Transparent;
            klikTransaksi.Cursor = Cursors.Hand;
            klikTransaksi.Location = new Point(926, 27);
            klikTransaksi.Name = "klikTransaksi";
            klikTransaksi.Size = new Size(138, 51);
            klikTransaksi.TabIndex = 13;
            klikTransaksi.TabStop = false;
            klikTransaksi.Click += klikTransaksi_Click;
            // 
            // pbjumlah
            // 
            pbjumlah.BackColor = Color.Transparent;
            pbjumlah.BackgroundImage = Properties.Resources.jumlah;
            pbjumlah.BackgroundImageLayout = ImageLayout.Stretch;
            pbjumlah.Cursor = Cursors.Hand;
            pbjumlah.Location = new Point(793, 596);
            pbjumlah.Name = "pbjumlah";
            pbjumlah.Size = new Size(109, 52);
            pbjumlah.TabIndex = 14;
            pbjumlah.TabStop = false;
            // 
            // V_Tiket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1262, 673);
            Controls.Add(pbjumlah);
            Controls.Add(klikTransaksi);
            Controls.Add(klikJumlah);
            Controls.Add(klikPesanTiket);
            Controls.Add(klikprofil);
            Controls.Add(klikBeranda);
            DoubleBuffered = true;
            Name = "V_Tiket";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_Tiket";
            ((System.ComponentModel.ISupportInitialize)klikBeranda).EndInit();
            ((System.ComponentModel.ISupportInitialize)klikprofil).EndInit();
            ((System.ComponentModel.ISupportInitialize)klikPesanTiket).EndInit();
            ((System.ComponentModel.ISupportInitialize)klikJumlah).EndInit();
            ((System.ComponentModel.ISupportInitialize)klikTransaksi).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbjumlah).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox klikBeranda;
        private PictureBox klikprofil;
        private PictureBox klikPesanTiket;
        private NumericUpDown klikJumlah;
        private PictureBox klikTransaksi;
        private PictureBox pbjumlah;
    }
}