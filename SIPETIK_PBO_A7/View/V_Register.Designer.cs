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
            tbnotelp = new TextBox();
            btndaftar = new Button();
            SuspendLayout();
            // 
            // tbnama
            // 
            tbnama.BorderStyle = BorderStyle.None;
            tbnama.Location = new Point(861, 262);
            tbnama.Name = "tbnama";
            tbnama.Size = new Size(242, 16);
            tbnama.TabIndex = 1;
            // 
            // tbemail
            // 
            tbemail.BorderStyle = BorderStyle.None;
            tbemail.Location = new Point(861, 332);
            tbemail.Name = "tbemail";
            tbemail.Size = new Size(242, 16);
            tbemail.TabIndex = 2;
            // 
            // tbpassword
            // 
            tbpassword.BorderStyle = BorderStyle.None;
            tbpassword.Location = new Point(861, 407);
            tbpassword.Name = "tbpassword";
            tbpassword.Size = new Size(242, 16);
            tbpassword.TabIndex = 3;
            // 
            // tbnotelp
            // 
            tbnotelp.BorderStyle = BorderStyle.None;
            tbnotelp.Location = new Point(861, 474);
            tbnotelp.Name = "tbnotelp";
            tbnotelp.Size = new Size(242, 16);
            tbnotelp.TabIndex = 4;
            // 
            // btndaftar
            // 
            btndaftar.AutoSize = true;
            btndaftar.BackColor = Color.Transparent;
            btndaftar.FlatAppearance.BorderSize = 0;
            btndaftar.FlatStyle = FlatStyle.Flat;
            btndaftar.ForeColor = Color.Transparent;
            btndaftar.Location = new Point(897, 547);
            btndaftar.Name = "btndaftar";
            btndaftar.Size = new Size(146, 43);
            btndaftar.TabIndex = 5;
            btndaftar.UseVisualStyleBackColor = false;
            // 
            // V_Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 681);
            Controls.Add(btndaftar);
            Controls.Add(tbnotelp);
            Controls.Add(tbpassword);
            Controls.Add(tbemail);
            Controls.Add(tbnama);
            DoubleBuffered = true;
            Name = "V_Register";
            Text = "V_Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbnama;
        private TextBox tbemail;
        private TextBox tbpassword;
        private TextBox tbnotelp;
        private Button btndaftar;
    }
}