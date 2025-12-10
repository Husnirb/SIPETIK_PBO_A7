namespace SIPETIK_PBO_A7.View
{
    partial class V_Beranda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Beranda));
            klikprofil = new PictureBox();
            klikTiket = new PictureBox();
            klikTransaksi = new PictureBox();
            btnpesantiket = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)klikprofil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)klikTiket).BeginInit();
            ((System.ComponentModel.ISupportInitialize)klikTransaksi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnpesantiket).BeginInit();
            SuspendLayout();
            // 
            // klikprofil
            // 
            klikprofil.BackColor = Color.Transparent;
            klikprofil.Cursor = Cursors.Hand;
            klikprofil.Location = new Point(1154, 24);
            klikprofil.Name = "klikprofil";
            klikprofil.Size = new Size(63, 58);
            klikprofil.TabIndex = 7;
            klikprofil.TabStop = false;
            klikprofil.Click += klikprofil_Click;
            // 
            // klikTiket
            // 
            klikTiket.BackColor = Color.Transparent;
            klikTiket.Cursor = Cursors.Hand;
            klikTiket.Location = new Point(766, 27);
            klikTiket.Name = "klikTiket";
            klikTiket.Size = new Size(126, 51);
            klikTiket.TabIndex = 8;
            klikTiket.TabStop = false;
            klikTiket.Click += klikTiket_Click;
            // 
            // klikTransaksi
            // 
            klikTransaksi.BackColor = Color.Transparent;
            klikTransaksi.Cursor = Cursors.Hand;
            klikTransaksi.Location = new Point(924, 27);
            klikTransaksi.Name = "klikTransaksi";
            klikTransaksi.Size = new Size(138, 51);
            klikTransaksi.TabIndex = 9;
            klikTransaksi.TabStop = false;
            klikTransaksi.Click += klikTransaksi_Click;
            // 
            // btnpesantiket
            // 
            btnpesantiket.BackColor = Color.Transparent;
            btnpesantiket.BackgroundImage = Properties.Resources.pesantiketskrg;
            btnpesantiket.BackgroundImageLayout = ImageLayout.Stretch;
            btnpesantiket.Cursor = Cursors.Hand;
            btnpesantiket.Location = new Point(514, 458);
            btnpesantiket.Name = "btnpesantiket";
            btnpesantiket.Size = new Size(248, 51);
            btnpesantiket.TabIndex = 10;
            btnpesantiket.TabStop = false;
            btnpesantiket.Click += btnpesantiket_Click;
            // 
            // V_Beranda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1262, 673);
            Controls.Add(btnpesantiket);
            Controls.Add(klikTransaksi);
            Controls.Add(klikTiket);
            Controls.Add(klikprofil);
            DoubleBuffered = true;
            Name = "V_Beranda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_Beranda";
            ((System.ComponentModel.ISupportInitialize)klikprofil).EndInit();
            ((System.ComponentModel.ISupportInitialize)klikTiket).EndInit();
            ((System.ComponentModel.ISupportInitialize)klikTransaksi).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnpesantiket).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox klikprofil;
        private PictureBox klikTiket;
        private PictureBox pictureBox2;
        private PictureBox klikTransaksi;
        private PictureBox btnpesantiket;
    }
}