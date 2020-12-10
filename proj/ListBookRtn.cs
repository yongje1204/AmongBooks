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
    public partial class ListBookRtn : Form
    {
        //데이터베이스 연결
        private string StrSQL = @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=AmongBooks.accdb;Mode=ReadWrite";

        public ListBookRtn()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.lvBookList.Items.Clear();

            var Conn = new OleDbConnection(StrSQL);
            Conn.Open();

            //도서 정보 조회
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

            //도서가 대출중인지 확인
            sql = "SELECT Rent.user_num FROM Rent WHERE Rent.book_num = '" + this.tbBookNum.Text + "' AND Rent.rent_state LIKE '%%중'";
            Comm = new OleDbCommand(sql, Conn);
            myRead = Comm.ExecuteReader();

            //도서가 대출 중일 경우
            if(myRead.Read() == true)
            {
                this.tbUserNum.Text = myRead[0].ToString();

                //대출중인 회원 조회
                sql = "SELECT Member.user_name, Member.user_type, Member.user_phone FROM Member WHERE Member.user_num = '" + this.tbUserNum.Text + "';";
                Comm = new OleDbCommand(sql, Conn);
                myRead = Comm.ExecuteReader();

                if (myRead.Read() == true)
                {
                    this.tbUserName.Text = myRead[0].ToString();
                    this.tbUserType.Text = myRead[1].ToString();
                    this.tbUserPhone.Text = myRead[2].ToString();
                }

                //회원 연체여부 갱신
                sql = "UPDATE Rent SET Rent.rent_state = '연체중' where Rent.user_num = '" + this.tbUserNum.Text + "' AND Rent.return_date < '" + DateTime.Now.ToString("yyyy-MM-dd") + "';";
                Comm = new OleDbCommand(sql, Conn);
                Comm.ExecuteNonQuery();

                //회원의 대출 도서 리스트 조회
                sql = "SELECT Rent.rent_num,  Rent.book_num, Book.book_name, Book.book_callsign, Rent.rent_date, Rent.return_date, Rent.rent_state FROM Rent INNER JOIN Book ON Rent.book_num = Book.book_num WHERE Rent.user_num = \"" + this.tbUserNum.Text + "\";";
                Comm = new OleDbCommand(sql, Conn);
                myRead = Comm.ExecuteReader();
                while (myRead.Read())
                {
                    this.lvBookList.Items.Add(new ListViewItem(new string[] { myRead[0].ToString(), myRead[1].ToString(), myRead[2].ToString(), myRead[3].ToString(), myRead[4].ToString(), myRead[5].ToString(), myRead[6].ToString() }));
                }

                //lvlOverdue 갱신
                string overdue = "";
                sql = "SELECT COUNT(*) From Rent WHERE Rent.user_num = '" + this.tbUserNum.Text + "' AND Rent.rent_state = '연체중'";
                Comm = new OleDbCommand(sql, Conn);
                myRead = Comm.ExecuteReader();
                while (myRead.Read())
                {
                    overdue = myRead[0].ToString();
                }
                this.lblOverdue.Text = overdue + "건 연체";

                myRead.Close();
                Conn.Close();

                if (this.tbBookState.Text == "대출중" & this.tbBookNum.Text != "" & this.tbUserName.Text != "검색 결과 없음" & this.tbUserNum.Text != "")
                {
                    this.btnReturn.Enabled = true;
                }
                else
                {
                    this.btnReturn.Enabled = false;
                }
            }

            //도서가 대출중이 아닐 경우
            else if(myRead.Read() == false)
            {
                this.tbUserNum.Text = "대출중인 도서가 아닙니다.";
                this.tbUserName.Text = "대출중인 도서가 아닙니다.";
                this.tbUserType.Text = "대출중인 도서가 아닙니다.";
                this.tbUserPhone.Text = "대출중인 도서가 아닙니다.";
            }

        }

        //tbBookNum수정 시도시 조회한 값 초기화
        private void tbBookNum_MouseClick(object sender, MouseEventArgs e)
        {
            this.tbBookName.Text = "";
            this.tbBookSign.Text = "";
            this.tbBookPublisher.Text = "";
            this.tbBookSymbol.Text = "";
            this.tbBookState.Text = "";
            this.btnReturn.Enabled = false;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

        }
    }
}
