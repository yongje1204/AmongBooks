namespace proj
{
    partial class ListBookRtn
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblBookSign = new System.Windows.Forms.Label();
            this.gbBook = new System.Windows.Forms.GroupBox();
            this.tbBookState = new System.Windows.Forms.TextBox();
            this.tbBookSymbol = new System.Windows.Forms.TextBox();
            this.tbBookPublisher = new System.Windows.Forms.TextBox();
            this.tbBookSign = new System.Windows.Forms.TextBox();
            this.lblBookState = new System.Windows.Forms.Label();
            this.tbBookName = new System.Windows.Forms.TextBox();
            this.lblBookSymbol = new System.Windows.Forms.Label();
            this.lblBookPublisher = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.tbBookNum = new System.Windows.Forms.TextBox();
            this.lblBookNum = new System.Windows.Forms.Label();
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.tbUserPhone = new System.Windows.Forms.TextBox();
            this.lblUserPhone = new System.Windows.Forms.Label();
            this.tbUserType = new System.Windows.Forms.TextBox();
            this.lblUserType = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.tbUserNum = new System.Windows.Forms.TextBox();
            this.lblUserNum = new System.Windows.Forms.Label();
            this.lblRtnMng = new System.Windows.Forms.Label();
            this.tbRtnMng = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lvBookList = new System.Windows.Forms.ListView();
            this.chNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBookNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBookName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSymbol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chChkDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRtnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBookState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblOverdue = new System.Windows.Forms.Label();
            this.gbBook.SuspendLayout();
            this.gbUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.White;
            this.btnReturn.Enabled = false;
            this.btnReturn.Location = new System.Drawing.Point(416, 519);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(130, 40);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "반납";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblBookSign
            // 
            this.lblBookSign.AutoSize = true;
            this.lblBookSign.ForeColor = System.Drawing.Color.White;
            this.lblBookSign.Location = new System.Drawing.Point(20, 70);
            this.lblBookSign.Name = "lblBookSign";
            this.lblBookSign.Size = new System.Drawing.Size(49, 12);
            this.lblBookSign.TabIndex = 2;
            this.lblBookSign.Text = "저     자";
            // 
            // gbBook
            // 
            this.gbBook.BackColor = System.Drawing.Color.Transparent;
            this.gbBook.Controls.Add(this.tbBookState);
            this.gbBook.Controls.Add(this.tbBookSymbol);
            this.gbBook.Controls.Add(this.tbBookPublisher);
            this.gbBook.Controls.Add(this.tbBookSign);
            this.gbBook.Controls.Add(this.lblBookState);
            this.gbBook.Controls.Add(this.tbBookName);
            this.gbBook.Controls.Add(this.lblBookSymbol);
            this.gbBook.Controls.Add(this.lblBookPublisher);
            this.gbBook.Controls.Add(this.lblBookSign);
            this.gbBook.Controls.Add(this.lblBookName);
            this.gbBook.Controls.Add(this.tbBookNum);
            this.gbBook.Controls.Add(this.lblBookNum);
            this.gbBook.ForeColor = System.Drawing.Color.White;
            this.gbBook.Location = new System.Drawing.Point(25, 25);
            this.gbBook.Name = "gbBook";
            this.gbBook.Size = new System.Drawing.Size(300, 183);
            this.gbBook.TabIndex = 6;
            this.gbBook.TabStop = false;
            this.gbBook.Text = "도서";
            // 
            // tbBookState
            // 
            this.tbBookState.Location = new System.Drawing.Point(76, 148);
            this.tbBookState.Name = "tbBookState";
            this.tbBookState.ReadOnly = true;
            this.tbBookState.Size = new System.Drawing.Size(203, 21);
            this.tbBookState.TabIndex = 3;
            this.tbBookState.TabStop = false;
            // 
            // tbBookSymbol
            // 
            this.tbBookSymbol.Location = new System.Drawing.Point(76, 121);
            this.tbBookSymbol.Name = "tbBookSymbol";
            this.tbBookSymbol.ReadOnly = true;
            this.tbBookSymbol.Size = new System.Drawing.Size(203, 21);
            this.tbBookSymbol.TabIndex = 3;
            this.tbBookSymbol.TabStop = false;
            // 
            // tbBookPublisher
            // 
            this.tbBookPublisher.Location = new System.Drawing.Point(76, 94);
            this.tbBookPublisher.Name = "tbBookPublisher";
            this.tbBookPublisher.ReadOnly = true;
            this.tbBookPublisher.Size = new System.Drawing.Size(203, 21);
            this.tbBookPublisher.TabIndex = 3;
            this.tbBookPublisher.TabStop = false;
            // 
            // tbBookSign
            // 
            this.tbBookSign.Location = new System.Drawing.Point(76, 67);
            this.tbBookSign.Name = "tbBookSign";
            this.tbBookSign.ReadOnly = true;
            this.tbBookSign.Size = new System.Drawing.Size(203, 21);
            this.tbBookSign.TabIndex = 3;
            this.tbBookSign.TabStop = false;
            // 
            // lblBookState
            // 
            this.lblBookState.AutoSize = true;
            this.lblBookState.ForeColor = System.Drawing.Color.White;
            this.lblBookState.Location = new System.Drawing.Point(20, 151);
            this.lblBookState.Name = "lblBookState";
            this.lblBookState.Size = new System.Drawing.Size(49, 12);
            this.lblBookState.TabIndex = 2;
            this.lblBookState.Text = "상     태";
            // 
            // tbBookName
            // 
            this.tbBookName.Location = new System.Drawing.Point(76, 41);
            this.tbBookName.Name = "tbBookName";
            this.tbBookName.ReadOnly = true;
            this.tbBookName.Size = new System.Drawing.Size(203, 21);
            this.tbBookName.TabIndex = 3;
            this.tbBookName.TabStop = false;
            // 
            // lblBookSymbol
            // 
            this.lblBookSymbol.AutoSize = true;
            this.lblBookSymbol.ForeColor = System.Drawing.Color.White;
            this.lblBookSymbol.Location = new System.Drawing.Point(17, 124);
            this.lblBookSymbol.Name = "lblBookSymbol";
            this.lblBookSymbol.Size = new System.Drawing.Size(53, 12);
            this.lblBookSymbol.TabIndex = 2;
            this.lblBookSymbol.Text = "청구기호";
            // 
            // lblBookPublisher
            // 
            this.lblBookPublisher.AutoSize = true;
            this.lblBookPublisher.ForeColor = System.Drawing.Color.White;
            this.lblBookPublisher.Location = new System.Drawing.Point(20, 97);
            this.lblBookPublisher.Name = "lblBookPublisher";
            this.lblBookPublisher.Size = new System.Drawing.Size(49, 12);
            this.lblBookPublisher.TabIndex = 2;
            this.lblBookPublisher.Text = "출 판 사";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.ForeColor = System.Drawing.Color.White;
            this.lblBookName.Location = new System.Drawing.Point(20, 44);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(49, 12);
            this.lblBookName.TabIndex = 2;
            this.lblBookName.Text = "서     명";
            // 
            // tbBookNum
            // 
            this.tbBookNum.Location = new System.Drawing.Point(76, 14);
            this.tbBookNum.Name = "tbBookNum";
            this.tbBookNum.Size = new System.Drawing.Size(203, 21);
            this.tbBookNum.TabIndex = 0;
            this.tbBookNum.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbBookNum_MouseClick);
            // 
            // lblBookNum
            // 
            this.lblBookNum.AutoSize = true;
            this.lblBookNum.BackColor = System.Drawing.Color.Transparent;
            this.lblBookNum.ForeColor = System.Drawing.Color.White;
            this.lblBookNum.Location = new System.Drawing.Point(17, 17);
            this.lblBookNum.Name = "lblBookNum";
            this.lblBookNum.Size = new System.Drawing.Size(53, 12);
            this.lblBookNum.TabIndex = 0;
            this.lblBookNum.Text = "등록번호";
            // 
            // gbUser
            // 
            this.gbUser.BackColor = System.Drawing.Color.Transparent;
            this.gbUser.Controls.Add(this.tbUserPhone);
            this.gbUser.Controls.Add(this.lblUserPhone);
            this.gbUser.Controls.Add(this.tbUserType);
            this.gbUser.Controls.Add(this.lblUserType);
            this.gbUser.Controls.Add(this.tbUserName);
            this.gbUser.Controls.Add(this.lblUserName);
            this.gbUser.Controls.Add(this.tbUserNum);
            this.gbUser.Controls.Add(this.lblUserNum);
            this.gbUser.ForeColor = System.Drawing.Color.White;
            this.gbUser.Location = new System.Drawing.Point(375, 25);
            this.gbUser.Name = "gbUser";
            this.gbUser.Size = new System.Drawing.Size(300, 128);
            this.gbUser.TabIndex = 11;
            this.gbUser.TabStop = false;
            this.gbUser.Text = "회원";
            // 
            // tbUserPhone
            // 
            this.tbUserPhone.Location = new System.Drawing.Point(76, 97);
            this.tbUserPhone.Name = "tbUserPhone";
            this.tbUserPhone.ReadOnly = true;
            this.tbUserPhone.Size = new System.Drawing.Size(203, 21);
            this.tbUserPhone.TabIndex = 3;
            this.tbUserPhone.TabStop = false;
            // 
            // lblUserPhone
            // 
            this.lblUserPhone.AutoSize = true;
            this.lblUserPhone.ForeColor = System.Drawing.Color.White;
            this.lblUserPhone.Location = new System.Drawing.Point(16, 100);
            this.lblUserPhone.Name = "lblUserPhone";
            this.lblUserPhone.Size = new System.Drawing.Size(57, 12);
            this.lblUserPhone.TabIndex = 2;
            this.lblUserPhone.Text = "휴  대  폰";
            // 
            // tbUserType
            // 
            this.tbUserType.Location = new System.Drawing.Point(76, 68);
            this.tbUserType.Name = "tbUserType";
            this.tbUserType.ReadOnly = true;
            this.tbUserType.Size = new System.Drawing.Size(203, 21);
            this.tbUserType.TabIndex = 3;
            this.tbUserType.TabStop = false;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.ForeColor = System.Drawing.Color.White;
            this.lblUserType.Location = new System.Drawing.Point(17, 71);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(53, 12);
            this.lblUserType.TabIndex = 2;
            this.lblUserType.Text = "회원유형";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(76, 41);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.ReadOnly = true;
            this.tbUserName.Size = new System.Drawing.Size(203, 21);
            this.tbUserName.TabIndex = 3;
            this.tbUserName.TabStop = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(19, 44);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(49, 12);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "이     름";
            // 
            // tbUserNum
            // 
            this.tbUserNum.Location = new System.Drawing.Point(76, 14);
            this.tbUserNum.Name = "tbUserNum";
            this.tbUserNum.ReadOnly = true;
            this.tbUserNum.Size = new System.Drawing.Size(203, 21);
            this.tbUserNum.TabIndex = 0;
            this.tbUserNum.TabStop = false;
            // 
            // lblUserNum
            // 
            this.lblUserNum.AutoSize = true;
            this.lblUserNum.BackColor = System.Drawing.Color.Transparent;
            this.lblUserNum.ForeColor = System.Drawing.Color.White;
            this.lblUserNum.Location = new System.Drawing.Point(17, 17);
            this.lblUserNum.Name = "lblUserNum";
            this.lblUserNum.Size = new System.Drawing.Size(53, 12);
            this.lblUserNum.TabIndex = 0;
            this.lblUserNum.Text = "회원번호";
            // 
            // lblRtnMng
            // 
            this.lblRtnMng.AutoSize = true;
            this.lblRtnMng.BackColor = System.Drawing.Color.Transparent;
            this.lblRtnMng.ForeColor = System.Drawing.Color.White;
            this.lblRtnMng.Location = new System.Drawing.Point(249, 515);
            this.lblRtnMng.Name = "lblRtnMng";
            this.lblRtnMng.Size = new System.Drawing.Size(69, 12);
            this.lblRtnMng.TabIndex = 2;
            this.lblRtnMng.Text = "반납 담당자";
            // 
            // tbRtnMng
            // 
            this.tbRtnMng.Location = new System.Drawing.Point(251, 530);
            this.tbRtnMng.Name = "tbRtnMng";
            this.tbRtnMng.ReadOnly = true;
            this.tbRtnMng.Size = new System.Drawing.Size(125, 21);
            this.tbRtnMng.TabIndex = 3;
            this.tbRtnMng.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(416, 173);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 40);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lvBookList
            // 
            this.lvBookList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNo,
            this.chBookNum,
            this.chBookName,
            this.chSymbol,
            this.chChkDate,
            this.chRtnDate,
            this.chBookState});
            this.lvBookList.FullRowSelect = true;
            this.lvBookList.GridLines = true;
            this.lvBookList.HideSelection = false;
            this.lvBookList.Location = new System.Drawing.Point(20, 247);
            this.lvBookList.Name = "lvBookList";
            this.lvBookList.Size = new System.Drawing.Size(664, 250);
            this.lvBookList.TabIndex = 13;
            this.lvBookList.UseCompatibleStateImageBehavior = false;
            this.lvBookList.View = System.Windows.Forms.View.Details;
            // 
            // chNo
            // 
            this.chNo.Text = "No";
            this.chNo.Width = 100;
            // 
            // chBookNum
            // 
            this.chBookNum.Text = "자료번호";
            this.chBookNum.Width = 100;
            // 
            // chBookName
            // 
            this.chBookName.Text = "자료명";
            this.chBookName.Width = 160;
            // 
            // chSymbol
            // 
            this.chSymbol.Text = "청구기호";
            this.chSymbol.Width = 80;
            // 
            // chChkDate
            // 
            this.chChkDate.Text = "대출일";
            this.chChkDate.Width = 80;
            // 
            // chRtnDate
            // 
            this.chRtnDate.Text = "반납예정일";
            this.chRtnDate.Width = 80;
            // 
            // chBookState
            // 
            this.chBookState.Text = "상태";
            // 
            // lblOverdue
            // 
            this.lblOverdue.AutoSize = true;
            this.lblOverdue.BackColor = System.Drawing.Color.Transparent;
            this.lblOverdue.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblOverdue.ForeColor = System.Drawing.Color.White;
            this.lblOverdue.Location = new System.Drawing.Point(95, 510);
            this.lblOverdue.Name = "lblOverdue";
            this.lblOverdue.Size = new System.Drawing.Size(57, 13);
            this.lblOverdue.TabIndex = 14;
            this.lblOverdue.Text = "0건 연체";
            // 
            // ListBookRtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.ControlBox = false;
            this.Controls.Add(this.lblOverdue);
            this.Controls.Add(this.lvBookList);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbRtnMng);
            this.Controls.Add(this.gbUser);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblRtnMng);
            this.Controls.Add(this.gbBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListBookRtn";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.gbBook.ResumeLayout(false);
            this.gbBook.PerformLayout();
            this.gbUser.ResumeLayout(false);
            this.gbUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblBookSign;
        private System.Windows.Forms.GroupBox gbBook;
        private System.Windows.Forms.TextBox tbBookSymbol;
        private System.Windows.Forms.TextBox tbBookPublisher;
        private System.Windows.Forms.TextBox tbBookSign;
        private System.Windows.Forms.TextBox tbBookName;
        private System.Windows.Forms.Label lblBookSymbol;
        private System.Windows.Forms.Label lblBookPublisher;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.TextBox tbBookNum;
        private System.Windows.Forms.Label lblBookNum;
        private System.Windows.Forms.GroupBox gbUser;
        private System.Windows.Forms.TextBox tbUserPhone;
        private System.Windows.Forms.Label lblUserPhone;
        private System.Windows.Forms.TextBox tbUserType;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox tbUserNum;
        private System.Windows.Forms.Label lblUserNum;
        private System.Windows.Forms.TextBox tbBookState;
        private System.Windows.Forms.Label lblBookState;
        private System.Windows.Forms.Label lblRtnMng;
        private System.Windows.Forms.TextBox tbRtnMng;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView lvBookList;
        private System.Windows.Forms.ColumnHeader chNo;
        private System.Windows.Forms.ColumnHeader chBookNum;
        private System.Windows.Forms.ColumnHeader chBookName;
        private System.Windows.Forms.ColumnHeader chSymbol;
        private System.Windows.Forms.ColumnHeader chChkDate;
        private System.Windows.Forms.ColumnHeader chRtnDate;
        private System.Windows.Forms.ColumnHeader chBookState;
        private System.Windows.Forms.Label lblOverdue;
    }
}