﻿namespace proj
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
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCheckout = new System.Windows.Forms.Button();
            this.chDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRtnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvBookList = new System.Windows.Forms.ListView();
            this.lblBookSign = new System.Windows.Forms.Label();
            this.gbBook = new System.Windows.Forms.GroupBox();
            this.tbState = new System.Windows.Forms.TextBox();
            this.tbBookSymbol = new System.Windows.Forms.TextBox();
            this.tbBookPublisher = new System.Windows.Forms.TextBox();
            this.tbBookSign = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.tbBookName = new System.Windows.Forms.TextBox();
            this.lblBookSymbol = new System.Windows.Forms.Label();
            this.lblBookPublisher = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.tbBookNum = new System.Windows.Forms.TextBox();
            this.lblBookNum = new System.Windows.Forms.Label();
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.tbUserPhone = new System.Windows.Forms.TextBox();
            this.tbUserState = new System.Windows.Forms.TextBox();
            this.lblUserPhone = new System.Windows.Forms.Label();
            this.lblUserState = new System.Windows.Forms.Label();
            this.tbUserMajor = new System.Windows.Forms.TextBox();
            this.lblUserMajor = new System.Windows.Forms.Label();
            this.tbUserLevel = new System.Windows.Forms.TextBox();
            this.lblUserLevel = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.tbUserNum = new System.Windows.Forms.TextBox();
            this.lblUserNum = new System.Windows.Forms.Label();
            this.gbBook.SuspendLayout();
            this.gbUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // chType
            // 
            this.chType.Text = "대출유형";
            this.chType.Width = 70;
            // 
            // chNo
            // 
            this.chNo.Text = "No";
            this.chNo.Width = 50;
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.White;
            this.btnCheckout.Location = new System.Drawing.Point(285, 520);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(130, 40);
            this.btnCheckout.TabIndex = 8;
            this.btnCheckout.Text = "반납";
            this.btnCheckout.UseVisualStyleBackColor = false;
            // 
            // chDate
            // 
            this.chDate.Text = "대출일";
            this.chDate.Width = 80;
            // 
            // chRtnDate
            // 
            this.chRtnDate.Text = "반납예정일";
            this.chRtnDate.Width = 80;
            // 
            // chUserName
            // 
            this.chUserName.Text = "이름";
            this.chUserName.Width = 100;
            // 
            // lvBookList
            // 
            this.lvBookList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNo,
            this.chUserName,
            this.chDate,
            this.chRtnDate,
            this.chType});
            this.lvBookList.FullRowSelect = true;
            this.lvBookList.GridLines = true;
            this.lvBookList.HideSelection = false;
            this.lvBookList.Location = new System.Drawing.Point(160, 250);
            this.lvBookList.Name = "lvBookList";
            this.lvBookList.Size = new System.Drawing.Size(380, 250);
            this.lvBookList.TabIndex = 10;
            this.lvBookList.UseCompatibleStateImageBehavior = false;
            this.lvBookList.View = System.Windows.Forms.View.Details;
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
            this.gbBook.Controls.Add(this.tbState);
            this.gbBook.Controls.Add(this.tbBookSymbol);
            this.gbBook.Controls.Add(this.tbBookPublisher);
            this.gbBook.Controls.Add(this.tbBookSign);
            this.gbBook.Controls.Add(this.lblState);
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
            // tbState
            // 
            this.tbState.Location = new System.Drawing.Point(76, 148);
            this.tbState.Name = "tbState";
            this.tbState.ReadOnly = true;
            this.tbState.Size = new System.Drawing.Size(203, 21);
            this.tbState.TabIndex = 3;
            this.tbState.TabStop = false;
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
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.ForeColor = System.Drawing.Color.White;
            this.lblState.Location = new System.Drawing.Point(17, 151);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(29, 12);
            this.lblState.TabIndex = 2;
            this.lblState.Text = "상태";
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
            this.gbUser.Controls.Add(this.tbUserState);
            this.gbUser.Controls.Add(this.lblUserPhone);
            this.gbUser.Controls.Add(this.lblUserState);
            this.gbUser.Controls.Add(this.tbUserMajor);
            this.gbUser.Controls.Add(this.lblUserMajor);
            this.gbUser.Controls.Add(this.tbUserLevel);
            this.gbUser.Controls.Add(this.lblUserLevel);
            this.gbUser.Controls.Add(this.tbUserName);
            this.gbUser.Controls.Add(this.lblUserName);
            this.gbUser.Controls.Add(this.tbUserNum);
            this.gbUser.Controls.Add(this.lblUserNum);
            this.gbUser.ForeColor = System.Drawing.Color.White;
            this.gbUser.Location = new System.Drawing.Point(375, 25);
            this.gbUser.Name = "gbUser";
            this.gbUser.Size = new System.Drawing.Size(300, 183);
            this.gbUser.TabIndex = 11;
            this.gbUser.TabStop = false;
            this.gbUser.Text = "회원";
            // 
            // tbUserPhone
            // 
            this.tbUserPhone.Location = new System.Drawing.Point(76, 149);
            this.tbUserPhone.Name = "tbUserPhone";
            this.tbUserPhone.ReadOnly = true;
            this.tbUserPhone.Size = new System.Drawing.Size(203, 21);
            this.tbUserPhone.TabIndex = 3;
            this.tbUserPhone.TabStop = false;
            // 
            // tbUserState
            // 
            this.tbUserState.Location = new System.Drawing.Point(76, 122);
            this.tbUserState.Name = "tbUserState";
            this.tbUserState.ReadOnly = true;
            this.tbUserState.Size = new System.Drawing.Size(203, 21);
            this.tbUserState.TabIndex = 3;
            this.tbUserState.TabStop = false;
            // 
            // lblUserPhone
            // 
            this.lblUserPhone.AutoSize = true;
            this.lblUserPhone.ForeColor = System.Drawing.Color.White;
            this.lblUserPhone.Location = new System.Drawing.Point(16, 152);
            this.lblUserPhone.Name = "lblUserPhone";
            this.lblUserPhone.Size = new System.Drawing.Size(57, 12);
            this.lblUserPhone.TabIndex = 2;
            this.lblUserPhone.Text = "휴  대  폰";
            // 
            // lblUserState
            // 
            this.lblUserState.AutoSize = true;
            this.lblUserState.ForeColor = System.Drawing.Color.White;
            this.lblUserState.Location = new System.Drawing.Point(19, 125);
            this.lblUserState.Name = "lblUserState";
            this.lblUserState.Size = new System.Drawing.Size(49, 12);
            this.lblUserState.TabIndex = 2;
            this.lblUserState.Text = "상     태";
            // 
            // tbUserMajor
            // 
            this.tbUserMajor.Location = new System.Drawing.Point(76, 95);
            this.tbUserMajor.Name = "tbUserMajor";
            this.tbUserMajor.ReadOnly = true;
            this.tbUserMajor.Size = new System.Drawing.Size(203, 21);
            this.tbUserMajor.TabIndex = 3;
            this.tbUserMajor.TabStop = false;
            // 
            // lblUserMajor
            // 
            this.lblUserMajor.AutoSize = true;
            this.lblUserMajor.ForeColor = System.Drawing.Color.White;
            this.lblUserMajor.Location = new System.Drawing.Point(19, 98);
            this.lblUserMajor.Name = "lblUserMajor";
            this.lblUserMajor.Size = new System.Drawing.Size(49, 12);
            this.lblUserMajor.TabIndex = 2;
            this.lblUserMajor.Text = "학     과";
            // 
            // tbUserLevel
            // 
            this.tbUserLevel.Location = new System.Drawing.Point(76, 68);
            this.tbUserLevel.Name = "tbUserLevel";
            this.tbUserLevel.ReadOnly = true;
            this.tbUserLevel.Size = new System.Drawing.Size(203, 21);
            this.tbUserLevel.TabIndex = 3;
            this.tbUserLevel.TabStop = false;
            // 
            // lblUserLevel
            // 
            this.lblUserLevel.AutoSize = true;
            this.lblUserLevel.ForeColor = System.Drawing.Color.White;
            this.lblUserLevel.Location = new System.Drawing.Point(19, 71);
            this.lblUserLevel.Name = "lblUserLevel";
            this.lblUserLevel.Size = new System.Drawing.Size(49, 12);
            this.lblUserLevel.TabIndex = 2;
            this.lblUserLevel.Text = "등     급";
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
            // ListBookRtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.ControlBox = false;
            this.Controls.Add(this.gbUser);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.lvBookList);
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

        }

        #endregion
        private System.Windows.Forms.ColumnHeader chType;
        private System.Windows.Forms.ColumnHeader chNo;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.ColumnHeader chDate;
        private System.Windows.Forms.ColumnHeader chRtnDate;
        private System.Windows.Forms.ColumnHeader chUserName;
        private System.Windows.Forms.ListView lvBookList;
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
        private System.Windows.Forms.TextBox tbUserState;
        private System.Windows.Forms.Label lblUserPhone;
        private System.Windows.Forms.Label lblUserState;
        private System.Windows.Forms.TextBox tbUserMajor;
        private System.Windows.Forms.Label lblUserMajor;
        private System.Windows.Forms.TextBox tbUserLevel;
        private System.Windows.Forms.Label lblUserLevel;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox tbUserNum;
        private System.Windows.Forms.Label lblUserNum;
        private System.Windows.Forms.TextBox tbState;
        private System.Windows.Forms.Label lblState;
    }
}