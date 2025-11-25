namespace SIPETIK_PBO_A7
{
    partial class V_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Login));
            tbemail = new TextBox();
            tbpassword = new TextBox();
            btnlogin = new Button();
            btnregister = new Button();
            SuspendLayout();
            // 
            // tbemail
            // 
            tbemail.BorderStyle = BorderStyle.None;
            tbemail.Location = new Point(840, 356);
            tbemail.Name = "tbemail";
            tbemail.Size = new Size(242, 16);
            tbemail.TabIndex = 0;
            // 
            // tbpassword
            // 
            tbpassword.BorderStyle = BorderStyle.None;
            tbpassword.Location = new Point(840, 453);
            tbpassword.Name = "tbpassword";
            tbpassword.Size = new Size(242, 16);
            tbpassword.TabIndex = 1;
            // 
            // btnlogin
            // 
            btnlogin.AutoSize = true;
            btnlogin.BackColor = Color.Transparent;
            btnlogin.FlatAppearance.BorderSize = 0;
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.ForeColor = Color.Transparent;
            btnlogin.Location = new Point(894, 524);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(146, 43);
            btnlogin.TabIndex = 2;
            btnlogin.UseVisualStyleBackColor = false;
            // 
            // btnregister
            // 
            btnregister.AutoSize = true;
            btnregister.BackColor = Color.Transparent;
            btnregister.FlatAppearance.BorderSize = 0;
            btnregister.FlatStyle = FlatStyle.Flat;
            btnregister.ForeColor = Color.Transparent;
            btnregister.Location = new Point(1009, 626);
            btnregister.Name = "btnregister";
            btnregister.Size = new Size(97, 43);
            btnregister.TabIndex = 3;
            btnregister.UseVisualStyleBackColor = false;
            // 
            // V_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 681);
            Controls.Add(btnregister);
            Controls.Add(btnlogin);
            Controls.Add(tbpassword);
            Controls.Add(tbemail);
            DoubleBuffered = true;
            Name = "V_Login";
            Text = "Form1";
            Load += V_Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbemail;
        private TextBox tbpassword;
        private Button btnlogin;
        private Button btnregister;
    }
}
