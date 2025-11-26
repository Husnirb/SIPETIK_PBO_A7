namespace SIPETIK_PBO_A7.View
{
    partial class V_Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Register));
            tbnama = new TextBox();
            tbemail = new TextBox();
            tbpassword = new TextBox();
            tbtelp = new TextBox();
            btndaftar = new Button();
            SuspendLayout();
            // 
            // tbnama
            // 
            tbnama.BorderStyle = BorderStyle.None;
            tbnama.Location = new Point(862, 257);
            tbnama.Margin = new Padding(3, 4, 3, 4);
            tbnama.Name = "tbnama";
            tbnama.Size = new Size(244, 20);
            tbnama.TabIndex = 1;
            // 
            // tbemail
            // 
            tbemail.BorderStyle = BorderStyle.None;
            tbemail.Location = new Point(862, 326);
            tbemail.Margin = new Padding(3, 4, 3, 4);
            tbemail.Name = "tbemail";
            tbemail.Size = new Size(244, 20);
            tbemail.TabIndex = 2;
            // 
            // tbpassword
            // 
            tbpassword.BorderStyle = BorderStyle.None;
            tbpassword.Location = new Point(862, 398);
            tbpassword.Margin = new Padding(3, 4, 3, 4);
            tbpassword.Name = "tbpassword";
            tbpassword.Size = new Size(244, 20);
            tbpassword.TabIndex = 3;
            // 
            // tbtelp
            // 
            tbtelp.BorderStyle = BorderStyle.None;
            tbtelp.Location = new Point(862, 468);
            tbtelp.Margin = new Padding(3, 4, 3, 4);
            tbtelp.Name = "tbtelp";
            tbtelp.Size = new Size(244, 20);
            tbtelp.TabIndex = 4;
            // 
            // btndaftar
            // 
            btndaftar.AutoSize = true;
            btndaftar.BackColor = Color.LightCoral;
            btndaftar.BackgroundImage = Properties.Resources.RegisterButton;
            btndaftar.BackgroundImageLayout = ImageLayout.Stretch;
            btndaftar.FlatAppearance.BorderSize = 0;
            btndaftar.FlatStyle = FlatStyle.Flat;
            btndaftar.ForeColor = Color.Transparent;
            btndaftar.Location = new Point(894, 541);
            btndaftar.Margin = new Padding(3, 4, 3, 4);
            btndaftar.Name = "btndaftar";
            btndaftar.Size = new Size(150, 43);
            btndaftar.TabIndex = 5;
            btndaftar.UseVisualStyleBackColor = false;
            btndaftar.Click += btndaftar_Click;
            // 
            // V_Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1262, 673);
            Controls.Add(btndaftar);
            Controls.Add(tbtelp);
            Controls.Add(tbpassword);
            Controls.Add(tbemail);
            Controls.Add(tbnama);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "V_Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbnama;
        private TextBox tbemail;
        private TextBox tbpassword;
        private TextBox tbtelp;
        private Button btndaftar;
    }
}