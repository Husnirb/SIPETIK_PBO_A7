namespace SIPETIK_PBO_A7.View
{
    partial class V_Transaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Transaksi));
            flpTransaksi = new FlowLayoutPanel();
            klikBeranda = new PictureBox();
            klikTiket = new PictureBox();
            klikprofil = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)klikBeranda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)klikTiket).BeginInit();
            ((System.ComponentModel.ISupportInitialize)klikprofil).BeginInit();
            SuspendLayout();
            // 
            // flpTransaksi
            // 
            flpTransaksi.BackColor = Color.MistyRose;
            flpTransaksi.Location = new Point(162, 181);
            flpTransaksi.Name = "flpTransaksi";
            flpTransaksi.Size = new Size(976, 412);
            flpTransaksi.TabIndex = 0;
            // 
            // klikBeranda
            // 
            klikBeranda.BackColor = Color.Transparent;
            klikBeranda.Cursor = Cursors.Hand;
            klikBeranda.Location = new Point(601, 27);
            klikBeranda.Name = "klikBeranda";
            klikBeranda.Size = new Size(135, 51);
            klikBeranda.TabIndex = 10;
            klikBeranda.TabStop = false;
            klikBeranda.Click += klikBeranda_Click;
            // 
            // klikTiket
            // 
            klikTiket.BackColor = Color.Transparent;
            klikTiket.Cursor = Cursors.Hand;
            klikTiket.Location = new Point(761, 27);
            klikTiket.Name = "klikTiket";
            klikTiket.Size = new Size(135, 51);
            klikTiket.TabIndex = 11;
            klikTiket.TabStop = false;
            klikTiket.Click += klikTiket_Click;
            // 
            // klikprofil
            // 
            klikprofil.BackColor = Color.Transparent;
            klikprofil.Cursor = Cursors.Hand;
            klikprofil.Location = new Point(1155, 24);
            klikprofil.Name = "klikprofil";
            klikprofil.Size = new Size(63, 58);
            klikprofil.TabIndex = 12;
            klikprofil.TabStop = false;
            klikprofil.Click += klikprofil_Click;
            // 
            // V_Transaksi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1262, 673);
            Controls.Add(klikprofil);
            Controls.Add(klikTiket);
            Controls.Add(klikBeranda);
            Controls.Add(flpTransaksi);
            DoubleBuffered = true;
            Name = "V_Transaksi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_Transaksi";
            ((System.ComponentModel.ISupportInitialize)klikBeranda).EndInit();
            ((System.ComponentModel.ISupportInitialize)klikTiket).EndInit();
            ((System.ComponentModel.ISupportInitialize)klikprofil).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpTransaksi;
        private PictureBox klikBeranda;
        private PictureBox klikTiket;
        private PictureBox klikprofil;
    }
}