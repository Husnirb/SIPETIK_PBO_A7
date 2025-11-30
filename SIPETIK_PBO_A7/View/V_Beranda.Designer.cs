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
            btnpesantiket = new Button();
            klikprofil = new PictureBox();
            klikTiket = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)klikprofil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)klikTiket).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnpesantiket
            // 
            btnpesantiket.AutoSize = true;
            btnpesantiket.BackColor = Color.Transparent;
            btnpesantiket.BackgroundImage = Properties.Resources.pesantiketskrg;
            btnpesantiket.BackgroundImageLayout = ImageLayout.Stretch;
            btnpesantiket.Cursor = Cursors.Hand;
            btnpesantiket.FlatAppearance.BorderSize = 0;
            btnpesantiket.FlatStyle = FlatStyle.Flat;
            btnpesantiket.ForeColor = Color.Transparent;
            btnpesantiket.Location = new Point(515, 458);
            btnpesantiket.Margin = new Padding(3, 4, 3, 4);
            btnpesantiket.Name = "btnpesantiket";
            btnpesantiket.Size = new Size(242, 52);
            btnpesantiket.TabIndex = 6;
            btnpesantiket.UseVisualStyleBackColor = false;
            btnpesantiket.Click += btnpesantiket_Click;
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
            klikTiket.Location = new Point(759, 27);
            klikTiket.Name = "klikTiket";
            klikTiket.Size = new Size(135, 51);
            klikTiket.TabIndex = 8;
            klikTiket.TabStop = false;
            klikTiket.Click += klikTiket_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Location = new Point(924, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(138, 51);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // V_Beranda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1262, 673);
            Controls.Add(pictureBox2);
            Controls.Add(klikTiket);
            Controls.Add(klikprofil);
            Controls.Add(btnpesantiket);
            DoubleBuffered = true;
            Name = "V_Beranda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_Beranda";
            ((System.ComponentModel.ISupportInitialize)klikprofil).EndInit();
            ((System.ComponentModel.ISupportInitialize)klikTiket).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnpesantiket;
        private PictureBox klikprofil;
        private PictureBox klikTiket;
        private PictureBox pictureBox2;
    }
}