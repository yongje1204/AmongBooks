﻿namespace proj
{
    partial class ListBookSearch
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
            this.tbBookName = new System.Windows.Forms.TextBox();
            this.cbSearchType = new System.Windows.Forms.ComboBox();
            this.cbBookLanguage = new System.Windows.Forms.ComboBox();
            this.lblBookLanguage = new System.Windows.Forms.Label();
            this.lblBookGenre = new System.Windows.Forms.Label();
            this.cbBookGenre = new System.Windows.Forms.ComboBox();
            this.cbBookRate = new System.Windows.Forms.ComboBox();
            this.lblBookRate = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.chNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBookName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBookSymbol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBookSign = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBookPublisher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBookPbDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbBookRecord = new System.Windows.Forms.ComboBox();
            this.lblBookRecord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbBookName
            // 
            this.tbBookName.Location = new System.Drawing.Point(235, 110);
            this.tbBookName.Name = "tbBookName";
            this.tbBookName.Size = new System.Drawing.Size(280, 21);
            this.tbBookName.TabIndex = 0;
            // 
            // cbSearchType
            // 
            this.cbSearchType.FormattingEnabled = true;
            this.cbSearchType.Items.AddRange(new object[] {
            "단어일치",
            "완전일치"});
            this.cbSearchType.Location = new System.Drawing.Point(235, 80);
            this.cbSearchType.Name = "cbSearchType";
            this.cbSearchType.Size = new System.Drawing.Size(100, 20);
            this.cbSearchType.TabIndex = 2;
            // 
            // cbBookLanguage
            // 
            this.cbBookLanguage.FormattingEnabled = true;
            this.cbBookLanguage.Items.AddRange(new object[] {
            "전체",
            "한국어",
            "영어",
            "일본어",
            "중국어",
            "?",
            "??"});
            this.cbBookLanguage.Location = new System.Drawing.Point(94, 59);
            this.cbBookLanguage.Name = "cbBookLanguage";
            this.cbBookLanguage.Size = new System.Drawing.Size(100, 20);
            this.cbBookLanguage.TabIndex = 4;
            // 
            // lblBookLanguage
            // 
            this.lblBookLanguage.AutoSize = true;
            this.lblBookLanguage.ForeColor = System.Drawing.Color.White;
            this.lblBookLanguage.Location = new System.Drawing.Point(23, 62);
            this.lblBookLanguage.Name = "lblBookLanguage";
            this.lblBookLanguage.Size = new System.Drawing.Size(29, 12);
            this.lblBookLanguage.TabIndex = 7;
            this.lblBookLanguage.Text = "언어";
            // 
            // lblBookGenre
            // 
            this.lblBookGenre.AutoSize = true;
            this.lblBookGenre.ForeColor = System.Drawing.Color.White;
            this.lblBookGenre.Location = new System.Drawing.Point(23, 88);
            this.lblBookGenre.Name = "lblBookGenre";
            this.lblBookGenre.Size = new System.Drawing.Size(53, 12);
            this.lblBookGenre.TabIndex = 7;
            this.lblBookGenre.Text = "별차기호";
            // 
            // cbBookGenre
            // 
            this.cbBookGenre.FormattingEnabled = true;
            this.cbBookGenre.Items.AddRange(new object[] {
            "전체",
            "SF",
            "학원",
            "판타지",
            "코믹/명랑",
            "취미/오락",
            "요리",
            "예술",
            "역사/고전",
            "액션",
            "실물자료",
            "스포츠"});
            this.cbBookGenre.Location = new System.Drawing.Point(94, 85);
            this.cbBookGenre.Name = "cbBookGenre";
            this.cbBookGenre.Size = new System.Drawing.Size(100, 20);
            this.cbBookGenre.TabIndex = 5;
            // 
            // cbBookRate
            // 
            this.cbBookRate.FormattingEnabled = true;
            this.cbBookRate.Items.AddRange(new object[] {
            "?",
            "??",
            "???",
            "????"});
            this.cbBookRate.Location = new System.Drawing.Point(94, 111);
            this.cbBookRate.Name = "cbBookRate";
            this.cbBookRate.Size = new System.Drawing.Size(100, 20);
            this.cbBookRate.TabIndex = 6;
            // 
            // lblBookRate
            // 
            this.lblBookRate.AutoSize = true;
            this.lblBookRate.ForeColor = System.Drawing.Color.White;
            this.lblBookRate.Location = new System.Drawing.Point(23, 114);
            this.lblBookRate.Name = "lblBookRate";
            this.lblBookRate.Size = new System.Drawing.Size(53, 12);
            this.lblBookRate.TabIndex = 7;
            this.lblBookRate.Text = "자료등급";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(556, 108);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNo,
            this.chType,
            this.chState,
            this.chBookName,
            this.chBookSymbol,
            this.chBookSign,
            this.chBookPublisher,
            this.chBookPbDate});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(25, 200);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(650, 380);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // chNo
            // 
            this.chNo.Text = "No";
            this.chNo.Width = 50;
            // 
            // chType
            // 
            this.chType.Text = "자료유형";
            this.chType.Width = 50;
            // 
            // chState
            // 
            this.chState.Text = "상태";
            this.chState.Width = 40;
            // 
            // chBookName
            // 
            this.chBookName.Text = "서명";
            this.chBookName.Width = 180;
            // 
            // chBookSymbol
            // 
            this.chBookSymbol.Text = "청구기호";
            this.chBookSymbol.Width = 100;
            // 
            // chBookSign
            // 
            this.chBookSign.Text = "저자";
            this.chBookSign.Width = 100;
            // 
            // chBookPublisher
            // 
            this.chBookPublisher.Text = "출판사";
            this.chBookPublisher.Width = 66;
            // 
            // chBookPbDate
            // 
            this.chBookPbDate.Text = "발행년도";
            // 
            // cbBookRecord
            // 
            this.cbBookRecord.FormattingEnabled = true;
            this.cbBookRecord.Items.AddRange(new object[] {
            "전체",
            "단행본",
            "시청각자료",
            "연속간행물",
            "이론서",
            "점자자료",
            "학습만화",
            "학위논문",
            "해외원서"});
            this.cbBookRecord.Location = new System.Drawing.Point(94, 33);
            this.cbBookRecord.Name = "cbBookRecord";
            this.cbBookRecord.Size = new System.Drawing.Size(100, 20);
            this.cbBookRecord.TabIndex = 3;
            // 
            // lblBookRecord
            // 
            this.lblBookRecord.AutoSize = true;
            this.lblBookRecord.ForeColor = System.Drawing.Color.White;
            this.lblBookRecord.Location = new System.Drawing.Point(23, 36);
            this.lblBookRecord.Name = "lblBookRecord";
            this.lblBookRecord.Size = new System.Drawing.Size(65, 12);
            this.lblBookRecord.TabIndex = 7;
            this.lblBookRecord.Text = "레코드유형";
            // 
            // ListBookSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblBookRate);
            this.Controls.Add(this.lblBookGenre);
            this.Controls.Add(this.lblBookRecord);
            this.Controls.Add(this.lblBookLanguage);
            this.Controls.Add(this.cbBookRate);
            this.Controls.Add(this.cbBookGenre);
            this.Controls.Add(this.cbBookLanguage);
            this.Controls.Add(this.cbBookRecord);
            this.Controls.Add(this.cbSearchType);
            this.Controls.Add(this.tbBookName);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListBookSearch";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ListBookSearch";
            this.Load += new System.EventHandler(this.ListBookSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBookName;
        private System.Windows.Forms.ComboBox cbSearchType;
        private System.Windows.Forms.ComboBox cbBookLanguage;
        private System.Windows.Forms.Label lblBookLanguage;
        private System.Windows.Forms.Label lblBookGenre;
        private System.Windows.Forms.ComboBox cbBookGenre;
        private System.Windows.Forms.ComboBox cbBookRate;
        private System.Windows.Forms.Label lblBookRate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox cbBookRecord;
        private System.Windows.Forms.Label lblBookRecord;
        private System.Windows.Forms.ColumnHeader chNo;
        private System.Windows.Forms.ColumnHeader chType;
        private System.Windows.Forms.ColumnHeader chState;
        private System.Windows.Forms.ColumnHeader chBookName;
        private System.Windows.Forms.ColumnHeader chBookSymbol;
        private System.Windows.Forms.ColumnHeader chBookSign;
        private System.Windows.Forms.ColumnHeader chBookPublisher;
        private System.Windows.Forms.ColumnHeader chBookPbDate;
    }
}