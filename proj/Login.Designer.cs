using System.Windows.Forms;

namespace proj
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbPsw = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblPsw = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(110, 167);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(123, 21);
            this.tbId.TabIndex = 0;
            this.tbId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbId_KeyDown);
            // 
            // tbPsw
            // 
            this.tbPsw.Location = new System.Drawing.Point(110, 194);
            this.tbPsw.Name = "tbPsw";
            this.tbPsw.PasswordChar = '*';
            this.tbPsw.Size = new System.Drawing.Size(123, 21);
            this.tbPsw.TabIndex = 1;
            this.tbPsw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPsw_KeyDown);
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Location = new System.Drawing.Point(259, 167);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(73, 48);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "로그인";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(51, 170);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(41, 12);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "아이디";
            // 
            // lblPsw
            // 
            this.lblPsw.AutoSize = true;
            this.lblPsw.BackColor = System.Drawing.Color.Transparent;
            this.lblPsw.ForeColor = System.Drawing.Color.White;
            this.lblPsw.Location = new System.Drawing.Point(51, 197);
            this.lblPsw.Name = "lblPsw";
            this.lblPsw.Size = new System.Drawing.Size(53, 12);
            this.lblPsw.TabIndex = 3;
            this.lblPsw.Text = "비밀번호";
            // 
            // lblLine
            // 
            this.lblLine.BackColor = System.Drawing.Color.Transparent;
            this.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLine.ForeColor = System.Drawing.Color.White;
            this.lblLine.Location = new System.Drawing.Point(51, 144);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(281, 2);
            this.lblLine.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::proj.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(26, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proj.Properties.Resources._900x600;
            this.ClientSize = new System.Drawing.Size(384, 247);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPsw);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbPsw);
            this.Controls.Add(this.tbId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbPsw;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblPsw;
        private System.Windows.Forms.Label lblLine;
        private PictureBox pictureBox1;
    }
}