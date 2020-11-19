namespace proj
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbSearchType = new System.Windows.Forms.ComboBox();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.cbRate = new System.Windows.Forms.ComboBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.cbRecord = new System.Windows.Forms.ComboBox();
            this.lblRecord = new System.Windows.Forms.Label();
            this.chNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBookName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBookSymbol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBookSign = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBookPublisher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBookPbDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(235, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 21);
            this.textBox1.TabIndex = 0;
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
            // cbLanguage
            // 
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Items.AddRange(new object[] {
            "전체",
            "한국어",
            "영어",
            "일본어",
            "중국어",
            "?",
            "??"});
            this.cbLanguage.Location = new System.Drawing.Point(94, 59);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(100, 20);
            this.cbLanguage.TabIndex = 4;
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.ForeColor = System.Drawing.Color.White;
            this.lblLanguage.Location = new System.Drawing.Point(23, 62);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(29, 12);
            this.lblLanguage.TabIndex = 7;
            this.lblLanguage.Text = "언어";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.ForeColor = System.Drawing.Color.White;
            this.lblGenre.Location = new System.Drawing.Point(23, 88);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(53, 12);
            this.lblGenre.TabIndex = 7;
            this.lblGenre.Text = "별차기호";
            // 
            // cbGenre
            // 
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Items.AddRange(new object[] {
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
            this.cbGenre.Location = new System.Drawing.Point(94, 85);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(100, 20);
            this.cbGenre.TabIndex = 5;
            // 
            // cbRate
            // 
            this.cbRate.FormattingEnabled = true;
            this.cbRate.Items.AddRange(new object[] {
            "?",
            "??",
            "???",
            "????"});
            this.cbRate.Location = new System.Drawing.Point(94, 111);
            this.cbRate.Name = "cbRate";
            this.cbRate.Size = new System.Drawing.Size(100, 20);
            this.cbRate.TabIndex = 6;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.ForeColor = System.Drawing.Color.White;
            this.lblRate.Location = new System.Drawing.Point(23, 114);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(53, 12);
            this.lblRate.TabIndex = 7;
            this.lblRate.Text = "자료등급";
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(556, 108);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
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
            // cbRecord
            // 
            this.cbRecord.FormattingEnabled = true;
            this.cbRecord.Items.AddRange(new object[] {
            "전체",
            "단행본",
            "시청각자료",
            "연속간행물",
            "이론서",
            "점자자료",
            "학습만화",
            "학위논문",
            "해외원서"});
            this.cbRecord.Location = new System.Drawing.Point(94, 33);
            this.cbRecord.Name = "cbRecord";
            this.cbRecord.Size = new System.Drawing.Size(100, 20);
            this.cbRecord.TabIndex = 3;
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.ForeColor = System.Drawing.Color.White;
            this.lblRecord.Location = new System.Drawing.Point(23, 36);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(65, 12);
            this.lblRecord.TabIndex = 7;
            this.lblRecord.Text = "레코드유형";
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
            // ListBookSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.cbRate);
            this.Controls.Add(this.cbGenre);
            this.Controls.Add(this.cbLanguage);
            this.Controls.Add(this.cbRecord);
            this.Controls.Add(this.cbSearchType);
            this.Controls.Add(this.textBox1);
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

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbSearchType;
        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.ComboBox cbGenre;
        private System.Windows.Forms.ComboBox cbRate;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox cbRecord;
        private System.Windows.Forms.Label lblRecord;
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