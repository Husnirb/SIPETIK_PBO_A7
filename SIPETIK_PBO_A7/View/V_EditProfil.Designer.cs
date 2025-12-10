namespace SIPETIK_PBO_A7.View
{
    partial class V_EditProfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_EditProfil));
            klikSimpan = new PictureBox();
            klikBatal = new PictureBox();
            pictureBox1 = new PictureBox();
            tbNama = new TextBox();
            tbEmail = new TextBox();
            ((System.ComponentModel.ISupportInitialize)klikSimpan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)klikBatal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // klikSimpan
            // 
            klikSimpan.BackColor = Color.Transparent;
            klikSimpan.Cursor = Cursors.Hand;
            klikSimpan.Location = new Point(650, 565);
            klikSimpan.Name = "klikSimpan";
            klikSimpan.Size = new Size(152, 54);
            klikSimpan.TabIndex = 10;
            klikSimpan.TabStop = false;
            klikSimpan.Click += klikSimpan_Click;
            // 
            // klikBatal
            // 
            klikBatal.BackColor = Color.Transparent;
            klikBatal.Cursor = Cursors.Hand;
            klikBatal.Location = new Point(460, 565);
            klikBatal.Name = "klikBatal";
            klikBatal.Size = new Size(152, 54);
            klikBatal.TabIndex = 11;
            klikBatal.TabStop = false;
            klikBatal.Click += klikBatal_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(594, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(625, 61);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // tbNama
            // 
            tbNama.BorderStyle = BorderStyle.None;
            tbNama.Font = new Font("Segoe UI", 12F);
            tbNama.Location = new Point(487, 315);
            tbNama.Margin = new Padding(3, 4, 3, 4);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(284, 27);
            tbNama.TabIndex = 13;
            // 
            // tbEmail
            // 
            tbEmail.BorderStyle = BorderStyle.None;
            tbEmail.Font = new Font("Segoe UI", 12F);
            tbEmail.Location = new Point(487, 409);
            tbEmail.Margin = new Padding(3, 4, 3, 4);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(284, 27);
            tbEmail.TabIndex = 14;
            // 
            // V_EditProfil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1262, 673);
            Controls.Add(tbEmail);
            Controls.Add(tbNama);
            Controls.Add(pictureBox1);
            Controls.Add(klikBatal);
            Controls.Add(klikSimpan);
            DoubleBuffered = true;
            Name = "V_EditProfil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_EditProfil";
            ((System.ComponentModel.ISupportInitialize)klikSimpan).EndInit();
            ((System.ComponentModel.ISupportInitialize)klikBatal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox klikSimpan;
        private PictureBox klikBatal;
        private PictureBox pictureBox1;
        private TextBox tbNama;
        private TextBox tbEmail;
    }
}