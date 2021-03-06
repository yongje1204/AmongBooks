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
            this.tbSearch_word = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.chNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBookName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBookSymbol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBookSign = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBookPublisher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBookPbDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBookVol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBookCopy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBookOripri = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBookGetpri = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBookGettype = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBookField = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBookLang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // tbSearch_word
            // 
            this.tbSearch_word.Location = new System.Drawing.Point(25, 70);
            this.tbSearch_word.Name = "tbSearch_word";
            this.tbSearch_word.Size = new System.Drawing.Size(525, 21);
            this.tbSearch_word.TabIndex = 0;
            this.tbSearch_word.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_word_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(583, 70);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNo,
            this.chState,
            this.chBookName,
            this.chBookSymbol,
            this.chBookSign,
            this.chBookPublisher,
            this.chBookPbDate,
            this.chBookVol,
            this.chBookCopy,
            this.chBookOripri,
            this.chBookGetpri,
            this.chBookGettype,
            this.chBookField,
            this.chBookLang});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(8, 143);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(680, 380);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // chNo
            // 
            this.chNo.Text = "등록번호";
            this.chNo.Width = 100;
            // 
            // chState
            // 
            this.chState.Text = "상태";
            // 
            // chBookName
            // 
            this.chBookName.Text = "서명";
            this.chBookName.Width = 150;
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
            // chBookVol
            // 
            this.chBookVol.Text = "Vol.";
            this.chBookVol.Width = 40;
            // 
            // chBookCopy
            // 
            this.chBookCopy.Text = "Copy.";
            this.chBookCopy.Width = 40;
            // 
            // chBookOripri
            // 
            this.chBookOripri.Text = "원가격";
            // 
            // chBookGetpri
            // 
            this.chBookGetpri.Text = "입수 가격";
            // 
            // chBookGettype
            // 
            this.chBookGettype.Text = "입수 유형";
            // 
            // chBookField
            // 
            this.chBookField.Text = "자료 분야";
            // 
            // chBookLang
            // 
            this.chBookLang.Text = "언어";
            // 
            // ListBookSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch_word);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListBookSearch";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ListBookSearch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearch_word;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader chNo;
        private System.Windows.Forms.ColumnHeader chState;
        private System.Windows.Forms.ColumnHeader chBookName;
        private System.Windows.Forms.ColumnHeader chBookSymbol;
        private System.Windows.Forms.ColumnHeader chBookSign;
        private System.Windows.Forms.ColumnHeader chBookPublisher;
        private System.Windows.Forms.ColumnHeader chBookPbDate;
        private System.Windows.Forms.ColumnHeader chBookVol;
        private System.Windows.Forms.ColumnHeader chBookCopy;
        private System.Windows.Forms.ColumnHeader chBookOripri;
        private System.Windows.Forms.ColumnHeader chBookGetpri;
        private System.Windows.Forms.ColumnHeader chBookGettype;
        private System.Windows.Forms.ColumnHeader chBookField;
        private System.Windows.Forms.ColumnHeader chBookLang;
    }
}