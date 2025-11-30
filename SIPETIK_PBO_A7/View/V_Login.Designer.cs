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
            tbemail = new TextBox();
            tbpassword = new TextBox();
            btnlogin = new Button();
            lblregister = new Label();
            SuspendLayout();
            // 
            // tbemail
            // 
            tbemail.BorderStyle = BorderStyle.None;
            tbemail.Cursor = Cursors.IBeam;
            tbemail.Location = new Point(837, 350);
            tbemail.Margin = new Padding(3, 4, 3, 4);
            tbemail.Name = "tbemail";
            tbemail.Size = new Size(248, 20);
            tbemail.TabIndex = 0;
            // 
            // tbpassword
            // 
            tbpassword.BorderStyle = BorderStyle.None;
            tbpassword.Cursor = Cursors.IBeam;
            tbpassword.Location = new Point(837, 444);
            tbpassword.Margin = new Padding(3, 4, 3, 4);
            tbpassword.Name = "tbpassword";
            tbpassword.Size = new Size(248, 20);
            tbpassword.TabIndex = 1;
            // 
            // btnlogin
            // 
            btnlogin.AutoSize = true;
            btnlogin.BackColor = Color.LightCoral;
            btnlogin.BackgroundImage = Properties.Resources.LoginButton1;
            btnlogin.BackgroundImageLayout = ImageLayout.Stretch;
            btnlogin.Cursor = Cursors.Hand;
            btnlogin.FlatAppearance.BorderSize = 0;
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.ForeColor = Color.Transparent;
            btnlogin.Location = new Point(881, 519);
            btnlogin.Margin = new Padding(3, 4, 3, 4);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(149, 41);
            btnlogin.TabIndex = 2;
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // lblregister
            // 
            lblregister.AutoSize = true;
            lblregister.BackColor = Color.Transparent;
            lblregister.Cursor = Cursors.Hand;
            lblregister.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblregister.ForeColor = Color.Maroon;
            lblregister.Location = new Point(1001, 623);
            lblregister.Name = "lblregister";
            lblregister.Size = new Size(91, 25);
            lblregister.TabIndex = 4;
            lblregister.Text = "Register";
            lblregister.Click += lblregister_Click;
            // 
            // V_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.LoginPage1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1262, 673);
            Controls.Add(lblregister);
            Controls.Add(btnlogin);
            Controls.Add(tbpassword);
            Controls.Add(tbemail);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "V_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += V_Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbemail;
        private TextBox tbpassword;
        private Button btnlogin;
        private Label lblregister;
    }
}
