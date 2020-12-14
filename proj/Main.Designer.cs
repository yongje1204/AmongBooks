using System.Drawing;

namespace proj
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.imglistBookMng = new System.Windows.Forms.ImageList(this.components);
            this.lblUser = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBookMng = new System.Windows.Forms.Button();
            this.btnBookChk = new System.Windows.Forms.Button();
            this.imglistBookChk = new System.Windows.Forms.ImageList(this.components);
            this.btnBookSearch = new System.Windows.Forms.Button();
            this.imglistBookSearch = new System.Windows.Forms.ImageList(this.components);
            this.btnUserMng = new System.Windows.Forms.Button();
            this.imglistUserMng = new System.Windows.Forms.ImageList(this.components);
            this.btnBookRtn = new System.Windows.Forms.Button();
            this.imglistBookRtn = new System.Windows.Forms.ImageList(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // imglistBookMng
            // 
            this.imglistBookMng.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglistBookMng.ImageStream")));
            this.imglistBookMng.TransparentColor = System.Drawing.Color.Transparent;
            this.imglistBookMng.Images.SetKeyName(0, "bookmanage1.png");
            this.imglistBookMng.Images.SetKeyName(1, "bookmanage2.png");
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUser.Location = new System.Drawing.Point(722, 11);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(41, 12);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Admin";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Font = new System.Drawing.Font("굴림", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLogout.Location = new System.Drawing.Point(764, 6);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(59, 17);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "LogOut";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnBookMng
            // 
            this.btnBookMng.BackColor = System.Drawing.Color.White;
            this.btnBookMng.FlatAppearance.BorderSize = 0;
            this.btnBookMng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookMng.ForeColor = System.Drawing.Color.Black;
            this.btnBookMng.ImageIndex = 0;
            this.btnBookMng.ImageList = this.imglistBookMng;
            this.btnBookMng.Location = new System.Drawing.Point(309, 216);
            this.btnBookMng.Name = "btnBookMng";
            this.btnBookMng.Size = new System.Drawing.Size(112, 122);
            this.btnBookMng.TabIndex = 0;
            this.btnBookMng.Text = "\r\n도서관리";
            this.btnBookMng.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBookMng.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBookMng.UseVisualStyleBackColor = false;
            this.btnBookMng.Click += new System.EventHandler(this.btnBookMng_Click);
            this.btnBookMng.MouseEnter += new System.EventHandler(this.btnBookMng_MouseEnter);
            this.btnBookMng.MouseLeave += new System.EventHandler(this.btnBookMng_MouseLeave);
            // 
            // btnBookChk
            // 
            this.btnBookChk.BackColor = System.Drawing.Color.White;
            this.btnBookChk.FlatAppearance.BorderSize = 0;
            this.btnBookChk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookChk.ForeColor = System.Drawing.Color.Black;
            this.btnBookChk.ImageIndex = 0;
            this.btnBookChk.ImageList = this.imglistBookChk;
            this.btnBookChk.Location = new System.Drawing.Point(251, 88);
            this.btnBookChk.Name = "btnBookChk";
            this.btnBookChk.Size = new System.Drawing.Size(112, 122);
            this.btnBookChk.TabIndex = 0;
            this.btnBookChk.Text = "\r\n도서대출";
            this.btnBookChk.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBookChk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBookChk.UseVisualStyleBackColor = false;
            this.btnBookChk.Click += new System.EventHandler(this.btnBookChk_Click);
            this.btnBookChk.MouseEnter += new System.EventHandler(this.btnBookChk_MouseEnter);
            this.btnBookChk.MouseLeave += new System.EventHandler(this.btnBookChk_MouseLeave);
            // 
            // imglistBookChk
            // 
            this.imglistBookChk.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglistBookChk.ImageStream")));
            this.imglistBookChk.TransparentColor = System.Drawing.Color.Transparent;
            this.imglistBookChk.Images.SetKeyName(0, "bookchk1.png");
            this.imglistBookChk.Images.SetKeyName(1, "bookchk2.png");
            // 
            // btnBookSearch
            // 
            this.btnBookSearch.BackColor = System.Drawing.Color.White;
            this.btnBookSearch.FlatAppearance.BorderSize = 0;
            this.btnBookSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookSearch.ImageIndex = 0;
            this.btnBookSearch.ImageList = this.imglistBookSearch;
            this.btnBookSearch.Location = new System.Drawing.Point(369, 88);
            this.btnBookSearch.Name = "btnBookSearch";
            this.btnBookSearch.Size = new System.Drawing.Size(112, 122);
            this.btnBookSearch.TabIndex = 0;
            this.btnBookSearch.Text = "도서검색";
            this.btnBookSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBookSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBookSearch.UseVisualStyleBackColor = false;
            this.btnBookSearch.Click += new System.EventHandler(this.btnBookSearch_Click);
            this.btnBookSearch.MouseEnter += new System.EventHandler(this.btnBookSearch_MouseEnter);
            this.btnBookSearch.MouseLeave += new System.EventHandler(this.btnBookSearch_MouseLeave);
            // 
            // imglistBookSearch
            // 
            this.imglistBookSearch.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglistBookSearch.ImageStream")));
            this.imglistBookSearch.TransparentColor = System.Drawing.Color.Transparent;
            this.imglistBookSearch.Images.SetKeyName(0, "search1.png");
            this.imglistBookSearch.Images.SetKeyName(1, "search2.png");
            // 
            // btnUserMng
            // 
            this.btnUserMng.BackColor = System.Drawing.Color.White;
            this.btnUserMng.FlatAppearance.BorderSize = 0;
            this.btnUserMng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserMng.ForeColor = System.Drawing.Color.Black;
            this.btnUserMng.ImageIndex = 0;
            this.btnUserMng.ImageList = this.imglistUserMng;
            this.btnUserMng.Location = new System.Drawing.Point(427, 216);
            this.btnUserMng.Name = "btnUserMng";
            this.btnUserMng.Size = new System.Drawing.Size(112, 122);
            this.btnUserMng.TabIndex = 0;
            this.btnUserMng.Text = "\r\n회원관리";
            this.btnUserMng.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUserMng.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUserMng.UseVisualStyleBackColor = false;
            this.btnUserMng.Click += new System.EventHandler(this.btnUserMng_Click);
            this.btnUserMng.MouseEnter += new System.EventHandler(this.btnUserMng_MouseEnter);
            this.btnUserMng.MouseLeave += new System.EventHandler(this.btnUserMng_MouseLeave);
            // 
            // imglistUserMng
            // 
            this.imglistUserMng.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglistUserMng.ImageStream")));
            this.imglistUserMng.TransparentColor = System.Drawing.Color.Transparent;
            this.imglistUserMng.Images.SetKeyName(0, "user1.png");
            this.imglistUserMng.Images.SetKeyName(1, "user2.png");
            // 
            // btnBookRtn
            // 
            this.btnBookRtn.BackColor = System.Drawing.Color.White;
            this.btnBookRtn.FlatAppearance.BorderSize = 0;
            this.btnBookRtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookRtn.ForeColor = System.Drawing.Color.Black;
            this.btnBookRtn.ImageIndex = 0;
            this.btnBookRtn.ImageList = this.imglistBookRtn;
            this.btnBookRtn.Location = new System.Drawing.Point(487, 88);
            this.btnBookRtn.Name = "btnBookRtn";
            this.btnBookRtn.Size = new System.Drawing.Size(112, 122);
            this.btnBookRtn.TabIndex = 0;
            this.btnBookRtn.Text = "\r\n도서반납";
            this.btnBookRtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBookRtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBookRtn.UseVisualStyleBackColor = false;
            this.btnBookRtn.Click += new System.EventHandler(this.btnBookRtn_Click);
            this.btnBookRtn.MouseEnter += new System.EventHandler(this.btnBookRtn_MouseEnter);
            this.btnBookRtn.MouseLeave += new System.EventHandler(this.btnBookRtn_MouseLeave);
            // 
            // imglistBookRtn
            // 
            this.imglistBookRtn.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglistBookRtn.ImageStream")));
            this.imglistBookRtn.TransparentColor = System.Drawing.Color.Transparent;
            this.imglistBookRtn.Images.SetKeyName(0, "bookreturn1.png");
            this.imglistBookRtn.Images.SetKeyName(1, "bookreturn2.png");
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proj.Properties.Resources._900x600;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnBookRtn);
            this.Controls.Add(this.btnUserMng);
            this.Controls.Add(this.btnBookSearch);
            this.Controls.Add(this.btnBookChk);
            this.Controls.Add(this.btnBookMng);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "AmongBooks";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imglistBookMng;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnBookMng;
        private System.Windows.Forms.Button btnBookChk;
        private System.Windows.Forms.Button btnBookSearch;
        private System.Windows.Forms.Button btnUserMng;
        private System.Windows.Forms.Button btnBookRtn;
        private System.Windows.Forms.ImageList imglistBookChk;
        private System.Windows.Forms.ImageList imglistUserMng;
        private System.Windows.Forms.ImageList imglistBookRtn;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ImageList imglistBookSearch;
    }
}

