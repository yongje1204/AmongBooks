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
        //데이터베이스 연결
        private string StrSQL = @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=AmongBooks.accdb;Mode=ReadWrite";
        public ListBookChk()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }

        private void ListBookChk_Load(object sender, EventArgs e)
        {
            this.ActiveControl = tbBookNum;
        }

        //검색 버튼
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

            //회원 정보 조회
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

            //회원 연체여부 갱신
            sql = "UPDATE Rent SET Rent.rent_state = '연체중' where Rent.user_num = '" + this.tbUserNum.Text + "' AND Rent.return_date < '" + DateTime.Now.ToString("yyyy-MM-dd") + "';";
            Comm = new OleDbCommand(sql, Conn);
            Comm.ExecuteNonQuery();

            //회원의 대출 도서 리스트 조회
            sql = "SELECT Rent.rent_num,  Rent.book_num, Book.book_name, Book.book_callsign, Rent.rent_date, Rent.return_date, Rent.rent_state FROM Rent INNER JOIN Book ON Rent.book_num = Book.book_num WHERE Rent.user_num = \"" + this.tbUserNum.Text + "\";";
            Comm = new OleDbCommand(sql, Conn);
            myRead = Comm.ExecuteReader();
            while(myRead.Read())
            {
                this.lvBookList.Items.Add(new ListViewItem(new string[] { myRead[0].ToString(), myRead[1].ToString(), myRead[2].ToString(), myRead[3].ToString(), myRead[4].ToString(), myRead[5].ToString(), myRead[6].ToString() }));
            }

            //lvlOverdue 갱신
            string overdue = "";
            sql = "SELECT COUNT(*) From Rent WHERE Rent.rent_state = '연체중'";
            Comm = new OleDbCommand(sql, Conn);
            myRead = Comm.ExecuteReader();
            while (myRead.Read())
            {
                overdue = myRead[0].ToString();
            }
            this.lblOverdue.Text = overdue + "건 연체";

            myRead.Close();
            Conn.Close();

            //도서번호입력, 회원번호입력, 도서가 대출가능 상태일 경우 대출 버튼 활성화
            if (this.tbBookState.Text == "대출가능" & this.tbBookNum.Text != "" & this.tbUserName.Text != "검색 결과 없음" & this.tbUserNum.Text != "")
            {
                this.btnCheckout.Enabled = true;
            }
            else
            {
                this.btnCheckout.Enabled = false;
            }
        }

        //tbUserNum 수정 시도시 조회한 값 초기화
        private void tbUserNum_MouseClick(object sender, MouseEventArgs e)
        {
            this.tbUserName.Text = "";
            this.tbUserType.Text = "";
            this.tbUserPhone.Text = "";
            this.btnCheckout.Enabled = false; 
            this.lblOverdue.Text = "0건 연체";
            this.lvBookList.Items.Clear();
        }

        //tbBookNum수정 시도시 조회한 값 초기화
        private void tbBookNum_Click(object sender, EventArgs e)
        {
            this.tbBookName.Text = "";
            this.tbBookSign.Text = "";
            this.tbBookPublisher.Text = "";
            this.tbBookSymbol.Text = "";
            this.tbBookState.Text = "";
            this.btnCheckout.Enabled = false;
        }

        //대출 버튼
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            string rnt_num = "";
            var Conn = new OleDbConnection(StrSQL);
            Conn.Open();

            //rent_num 생성을 위한 오늘 대출수 count(rnt_num)
            string sql = "SELECT count(*) FROM Rent WHERE (Rent.rent_num LIKE 'r20201210_%%%');";
            var Comm = new OleDbCommand(sql, Conn);
            var myRead = Comm.ExecuteReader();
            while (myRead.Read())
            {
                rnt_num = (Convert.ToInt32(myRead[0]) + 1).ToString().PadLeft(3, '0');
            }
            myRead.Close();
           
            //Rent테이블에 Insert
            sql = "INSERT INTO Rent(rent_num, rent_manager, rent_date, return_date, user_num, book_num, rent_state) VALUES('r" + DateTime.Now.ToString("yyyyMMdd") + "_" + rnt_num + "', " + "'rentManager추가해야됨', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + DateTime.Now.AddDays(7).ToString("yyyy-MM-dd") + "', '" + this.tbUserNum.Text + "', '" + this.tbBookNum.Text + "', '대출중');";
            Comm = new OleDbCommand(sql, Conn);
            int x = Comm.ExecuteNonQuery();

            if (x == 1)
            {
                MessageBox.Show("정상적으로 데이터가 저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Book테이블에 (도서상태)Update
                sql = "UPDATE Book SET book_state = '대출중' WHERE book_num = '" + this.tbBookNum.Text + "';";
                Comm = new OleDbCommand(sql, Conn);
                Comm.ExecuteNonQuery();

                //대출시 조회값 전부 초기화
                this.tbUserName.Text = "";
                this.tbUserType.Text = "";
                this.tbUserPhone.Text = "";
                this.lblOverdue.Text = "0건 연체";
                this.tbBookName.Text = "";
                this.tbBookSign.Text = "";
                this.tbBookPublisher.Text = "";
                this.tbBookSymbol.Text = "";
                this.tbBookState.Text = "";
                this.lvBookList.Items.Clear();
                this.btnCheckout.Enabled = false;
            }
            else
            {
                MessageBox.Show("정상적으로 데이터가 저장되지 않았습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Conn.Close();
        }
    }
}