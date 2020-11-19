namespace proj
{
    partial class ListPanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListPanel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBookChk = new System.Windows.Forms.Button();
            this.imglistBookChk = new System.Windows.Forms.ImageList(this.components);
            this.btnBookRtn = new System.Windows.Forms.Button();
            this.imglistBookRtn = new System.Windows.Forms.ImageList(this.components);
            this.btnHome = new System.Windows.Forms.Button();
            this.imglistHome = new System.Windows.Forms.ImageList(this.components);
            this.btnBookSearch = new System.Windows.Forms.Button();
            this.imglistBookSearch = new System.Windows.Forms.ImageList(this.components);
            this.btnUserMng = new System.Windows.Forms.Button();
            this.imglistUserMng = new System.Windows.Forms.ImageList(this.components);
            this.btnBookMng = new System.Windows.Forms.Button();
            this.imglistBookMng = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnBookChk);
            this.panel1.Controls.Add(this.btnBookRtn);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnBookSearch);
            this.panel1.Controls.Add(this.btnUserMng);
            this.panel1.Controls.Add(this.btnBookMng);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 600);
            this.panel1.TabIndex = 0;
            // 
            // btnBookChk
            // 
            this.btnBookChk.BackColor = System.Drawing.Color.White;
            this.btnBookChk.FlatAppearance.BorderSize = 0;
            this.btnBookChk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookChk.ImageIndex = 0;
            this.btnBookChk.ImageList = this.imglistBookChk;
            this.btnBookChk.Location = new System.Drawing.Point(40, 35);
            this.btnBookChk.Name = "btnBookChk";
            this.btnBookChk.Size = new System.Drawing.Size(120, 40);
            this.btnBookChk.TabIndex = 0;
            this.btnBookChk.Text = "도서대출";
            this.btnBookChk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            // btnBookRtn
            // 
            this.btnBookRtn.BackColor = System.Drawing.Color.White;
            this.btnBookRtn.FlatAppearance.BorderSize = 0;
            this.btnBookRtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookRtn.ImageIndex = 0;
            this.btnBookRtn.ImageList = this.imglistBookRtn;
            this.btnBookRtn.Location = new System.Drawing.Point(40, 81);
            this.btnBookRtn.Name = "btnBookRtn";
            this.btnBookRtn.Size = new System.Drawing.Size(120, 40);
            this.btnBookRtn.TabIndex = 0;
            this.btnBookRtn.Text = "도서반납";
            this.btnBookRtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ImageIndex = 0;
            this.btnHome.ImageList = this.imglistHome;
            this.btnHome.Location = new System.Drawing.Point(40, 525);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(40, 40);
            this.btnHome.TabIndex = 0;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.btnHome.MouseEnter += new System.EventHandler(this.btnHome_MouseEnter);
            this.btnHome.MouseLeave += new System.EventHandler(this.btnHome_MouseLeave);
            // 
            // imglistHome
            // 
            this.imglistHome.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglistHome.ImageStream")));
            this.imglistHome.TransparentColor = System.Drawing.Color.Transparent;
            this.imglistHome.Images.SetKeyName(0, "home1.png");
            this.imglistHome.Images.SetKeyName(1, "home2.png");
            // 
            // btnBookSearch
            // 
            this.btnBookSearch.BackColor = System.Drawing.Color.White;
            this.btnBookSearch.FlatAppearance.BorderSize = 0;
            this.btnBookSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookSearch.ImageIndex = 0;
            this.btnBookSearch.ImageList = this.imglistBookSearch;
            this.btnBookSearch.Location = new System.Drawing.Point(40, 127);
            this.btnBookSearch.Name = "btnBookSearch";
            this.btnBookSearch.Size = new System.Drawing.Size(120, 40);
            this.btnBookSearch.TabIndex = 0;
            this.btnBookSearch.Text = "도서검색";
            this.btnBookSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.btnUserMng.ImageIndex = 0;
            this.btnUserMng.ImageList = this.imglistUserMng;
            this.btnUserMng.Location = new System.Drawing.Point(40, 219);
            this.btnUserMng.Name = "btnUserMng";
            this.btnUserMng.Size = new System.Drawing.Size(120, 40);
            this.btnUserMng.TabIndex = 0;
            this.btnUserMng.Text = "회원관리";
            this.btnUserMng.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            // btnBookMng
            // 
            this.btnBookMng.BackColor = System.Drawing.Color.White;
            this.btnBookMng.FlatAppearance.BorderSize = 0;
            this.btnBookMng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookMng.ImageIndex = 0;
            this.btnBookMng.ImageList = this.imglistBookMng;
            this.btnBookMng.Location = new System.Drawing.Point(40, 173);
            this.btnBookMng.Name = "btnBookMng";
            this.btnBookMng.Size = new System.Drawing.Size(120, 40);
            this.btnBookMng.TabIndex = 0;
            this.btnBookMng.Text = "도서관리";
            this.btnBookMng.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBookMng.UseVisualStyleBackColor = false;
            this.btnBookMng.Click += new System.EventHandler(this.btnBookMng_Click);
            this.btnBookMng.MouseEnter += new System.EventHandler(this.btnBookMng_MouseEnter);
            this.btnBookMng.MouseLeave += new System.EventHandler(this.btnBookMng_MouseLeave);
            // 
            // imglistBookMng
            // 
            this.imglistBookMng.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglistBookMng.ImageStream")));
            this.imglistBookMng.TransparentColor = System.Drawing.Color.Transparent;
            this.imglistBookMng.Images.SetKeyName(0, "bookmanage1.png");
            this.imglistBookMng.Images.SetKeyName(1, "bookmanage2.png");
            // 
            // ListPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 600);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListPanel";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ListPanel";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBookMng;
        private System.Windows.Forms.ImageList imglistBookMng;
        private System.Windows.Forms.ImageList imglistBookChk;
        private System.Windows.Forms.ImageList imglistUserMng;
        private System.Windows.Forms.Button btnBookChk;
        private System.Windows.Forms.Button btnUserMng;
        private System.Windows.Forms.Button btnBookRtn;
        private System.Windows.Forms.ImageList imglistBookRtn;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ImageList imglistHome;
        private System.Windows.Forms.Button btnBookSearch;
        private System.Windows.Forms.ImageList imglistBookSearch;
    }
}