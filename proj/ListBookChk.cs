using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;

namespace proj
{
    public partial class ListBookChk : Form
    {
        private string StrSQL = @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=AmongBooks.accdb;Mode=ReadWrite"; //데이터베이스 연결 문자열

        public ListBookChk()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }

        private void ListBookChk_Load(object sender, EventArgs e)
        {
            cbChkType.SelectedIndex = 0;
            this.ActiveControl = tbBookNum;
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.lvBookList.Items.Clear();
            
            if (this.tbBookNum != null)
            {
                var Conn = new OleDbConnection(StrSQL);
                Conn.Open();

                string sql = "SELECT Book.book_name, Book.book_auth, Book.book_pub, Book.book_callsign, Book.book_state FROM Book WHERE Book.book_num = \"" + this.tbBookNum.Text + "\";";
                var Comm = new OleDbCommand(sql, Conn);
                var myRead = Comm.ExecuteReader();

                if (myRead.Read() == true)
                {
                    this.tbBookName.Text = myRead[0].ToString();
                    this.tbBookSign.Text = myRead[1].ToString();
                    this.tbBookPublisher.Text = myRead[2].ToString();
                    this.tbBookSymbol.Text = myRead[3].ToString();
                    this.tbBookState.Text = myRead[4].ToString();
                }
                else if (myRead.Read() == false)
                {
                    this.tbBookName.Text = "검색 결과 없음";
                    this.tbBookSign.Text = "검색 결과 없음";
                    this.tbBookPublisher.Text = "검색 결과 없음";
                    this.tbBookSymbol.Text = "검색 결과 없음";
                    this.tbBookState.Text = "검색 결과 없음";
                }

                sql = "SELECT Member.user_name, Member.user_type, Member.user_phone FROM Member WHERE Member.user_num = \"" + this.tbUserNum.Text + "\";";
                Comm = new OleDbCommand(sql, Conn);
                myRead = Comm.ExecuteReader();

                if (myRead.Read() == true)
                {
                    this.tbUserName.Text = myRead[0].ToString();
                    this.tbUserType.Text = myRead[1].ToString();
                    this.tbUserPhone.Text = myRead[2].ToString();
                }
                else if (myRead.Read() == false)
                {
                    this.tbUserName.Text = "검색 결과 없음";
                    this.tbUserType.Text = "검색 결과 없음";
                    this.tbUserPhone.Text = "검색 결과 없음";
                }

                sql = "SELECT Rent.rent_num, Rent.rent_state, Rent.book_num, Book.book_name, Book.book_callsign, Rent.rent_date FROM Rent INNER JOIN Book ON Rent.book_num = Book.book_num WHERE Rent.user_num = \"" + this.tbUserNum.Text + "\";";
                Comm = new OleDbCommand(sql, Conn);
                myRead = Comm.ExecuteReader();
                while(myRead.Read())
                {
                    this.lvBookList.Items.Add(new ListViewItem(new string[] { myRead[0].ToString(), myRead[1].ToString(), myRead[2].ToString(), myRead[3].ToString(), myRead[4].ToString(), myRead[5].ToString() }));
                }

                myRead.Close();
                Conn.Close();


                if (this.tbBookState.Text == "대출가능" & this.tbBookNum.Text != "" & this.tbUserName.Text != "검색 결과 없음" & this.tbUserNum.Text != "")
                {
                    this.btnCheckout.Enabled = true;
                }
                else
                {
                    this.btnCheckout.Enabled = false;
                }
            }

        }

        private void tbUserNum_MouseClick(object sender, MouseEventArgs e)
        {
            this.tbUserName.Text = "";
            this.tbUserType.Text = "";
            this.tbUserPhone.Text = "";
            this.btnCheckout.Enabled = false;
        }

        private void tbBookNum_Click(object sender, EventArgs e)
        {
            this.tbBookName.Text = "";
            this.tbBookSign.Text = "";
            this.tbBookPublisher.Text = "";
            this.tbBookSymbol.Text = "";
            this.tbBookState.Text = "";
            this.btnCheckout.Enabled = false;
        }
    }
}