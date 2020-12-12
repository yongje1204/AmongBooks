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
    public partial class ListBookMng : Form
    {
        //데이터베이스 연결
        private string StrSQL = @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=AmongBooks.accdb;Mode=ReadWrite";

        public ListBookMng()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }

        private void ListBookMng_Load(object sender, EventArgs e)
        {
            //컨트롤 값 초기화
            this.cbBookGenre_Cre.SelectedIndex = this.cbBookLanguage_Cre.SelectedIndex = this.cbBookPbMonth_Cre.SelectedIndex = this.cbBookGetType_Cre.SelectedIndex = 0;
            this.cbBookPbYear_Cre.SelectedItem = DateTime.Now.ToString("yyyy");
            this.cbBookPbMonth_Cre.SelectedItem = DateTime.Now.ToString("MM");
            this.cbBookPbDay_Cre.SelectedItem = DateTime.Now.ToString("dd");
            this.cbBookGenre_Mod.SelectedIndex = this.cbBookLanguage_Mod.SelectedIndex = this.cbBookGetType_Mod.SelectedIndex = 0;
            this.cbBookGenre_Del.SelectedIndex = this.cbBookLanguage_Del.SelectedIndex = this.cbBookGetType_Del.SelectedIndex = 0;
        }

        //자료등록 버튼
        private void btnCreate_Click(object sender, EventArgs e)
        {
            string bok_num = "";
            var Conn = new OleDbConnection(StrSQL);
            Conn.Open();

            //book_num 생성을 위한 오늘 추가한 도서 수 count(bok_num)
            string sql = "SELECT count(*) FROM Book WHERE (Book.book_num LIKE 'b" + DateTime.Now.ToString("yyyyMMdd") + "_%%%');";
            var Comm = new OleDbCommand(sql, Conn);
            var myRead = Comm.ExecuteReader();
            while (myRead.Read())
            {
                bok_num = (Convert.ToInt32(myRead[0]) + 1).ToString().PadLeft(3, '0');
            }
            myRead.Close();

            //Book테이블에 Insert
            sql = "INSERT INTO BOOK(book_num, book_name, book_auth, book_pub, book_callsign, book_pubdate, book_field, book_lang, book_vol, book_copy, book_oripri, book_getpri, book_gettype, book_state) VALUES('b" + DateTime.Now.ToString("yyyyMMdd") + "_" + bok_num + "', '" + this.tbBookName_Cre.Text + "', '" + this.tbBookSign_Cre.Text + "', '" + this.tbBookPublisher_Cre.Text + "', '" + this.tbBookSymbol_Cre.Text + "', '" + this.cbBookPbYear_Cre.SelectedItem + "-" + this.cbBookPbMonth_Cre.SelectedItem + "-" + this.cbBookPbDay_Cre.SelectedItem + "', '" + this.cbBookGenre_Cre.SelectedItem + "', '" + this.cbBookLanguage_Cre.SelectedItem + "', '" + this.tbBookVol_Cre.Text + "', '" + this.tbBookCopy_Cre.Text + "', '" + Convert.ToInt32(this.tbBookOriPri_Cre.Text) + "', '" + Convert.ToInt32(this.tbBookGetPri_Cre.Text) + "', '" + this.cbBookGetType_Cre.SelectedItem + "', '대출가능');";
            Comm = new OleDbCommand(sql, Conn);
            int x = Comm.ExecuteNonQuery();

            if (x == 1)
            {
                MessageBox.Show("정상적으로 데이터가 저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 자료 등록 후 폼초기화
                this.tbBookName_Cre.Text = this.tbBookSign_Cre.Text = this.tbBookPublisher_Cre.Text = this.tbBookSymbol_Cre.Text = this.tbBookVol_Cre.Text = this.tbBookCopy_Cre.Text = this.tbBookOriPri_Cre.Text = this.tbBookGetPri_Cre.Text = "";
                this.cbBookGenre_Cre.SelectedIndex = this.cbBookLanguage_Cre.SelectedIndex = this.cbBookGetType_Cre.SelectedIndex = 0;
                this.cbBookPbYear_Cre.SelectedItem = DateTime.Now.ToString("yyyy");
                this.cbBookPbMonth_Cre.SelectedItem = DateTime.Now.ToString("MM");
                this.cbBookPbDay_Cre.SelectedItem = DateTime.Now.ToString("dd");
            }
            else
            {
                MessageBox.Show("정상적으로 데이터가 저장되지 않았습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Conn.Close();
        }

        //자료수정 검색 버튼
        private void btnSearch_Mod_Click(object sender, EventArgs e)
        {
            var Conn = new OleDbConnection(StrSQL);
            Conn.Open();
            
            //tbBookNum 검색, 검색 값 주입
            string sql = "SELECT * FROM Book WHERE Book.book_num = '" + tbBookNum_Mod.Text + "';";
            var Comm = new OleDbCommand(sql, Conn);
            var myRead = Comm.ExecuteReader();

            if (myRead.Read() == true)
            {
                this.tbBookName_Mod.Text = myRead[1].ToString();
                this.tbBookSign_Mod.Text = myRead[2].ToString();
                this.tbBookPublisher_Mod.Text = myRead[3].ToString();
                this.tbBookSymbol_Mod.Text = myRead[4].ToString();
                this.tbBookVol_Mod.Text = myRead[8].ToString();
                this.tbBookCopy_Mod.Text = myRead[9].ToString();
                this.tbBookOriPri_Mod.Text = myRead[10].ToString();
                this.tbBookGetPri_Mod.Text = myRead[11].ToString();
                this.tbBookState_Mod.Text = myRead[13].ToString();

                this.cbBookPbYear_Mod.SelectedItem = myRead[5].ToString().Substring(0, 4);
                this.cbBookPbMonth_Mod.SelectedItem = myRead[5].ToString().Substring(5, 2);
                this.cbBookPbDay_Mod.SelectedItem = myRead[5].ToString().Substring(8, 2);

                this.cbBookGenre_Mod.SelectedItem = myRead[6].ToString();
                this.cbBookLanguage_Mod.SelectedItem = myRead[7].ToString();
                this.cbBookGetType_Mod.SelectedItem = myRead[12].ToString();

                //대출중인 자료인 경우 수정x
                if (this.tbBookState_Mod.Text == "대출중")
                {
                    MessageBox.Show("자료가 대출중일 경우 수정할 수 없습니다..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //대출중이지 않은 자료 검색 후 컨트롤 활성화
                    this.tbBookName_Mod.Enabled = this.tbBookSign_Mod.Enabled = this.tbBookPublisher_Mod.Enabled = this.tbBookSymbol_Mod.Enabled = this.cbBookPbYear_Mod.Enabled = this.cbBookPbMonth_Mod.Enabled = this.cbBookPbDay_Mod.Enabled = this.tbBookVol_Mod.Enabled = this.tbBookCopy_Mod.Enabled = this.tbBookOriPri_Mod.Enabled = this.tbBookGetPri_Mod.Enabled = this.cbBookGenre_Mod.Enabled = this.cbBookLanguage_Mod.Enabled = this.cbBookGetType_Mod.Enabled = true;
                }
            }
            //자료 검색 실패
            else if (myRead.Read() == false)
            {
                this.tbBookName_Mod.Text = "검색 결과 없음";
            }
            myRead.Close();
            Conn.Close();
        }

        //자료수정 버튼
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (this.tbBookName_Mod.Text != "")
            {
                if (this.tbBookState_Mod.Text != "대출중")
                {
                    var Conn = new OleDbConnection(StrSQL);
                    Conn.Open();

                    string sql = "UPDATE Book SET book_name = '" + this.tbBookName_Mod.Text + "', book_auth = '" + this.tbBookSign_Mod.Text + "', book_pub = '" + this.tbBookPublisher_Mod.Text + "', book_callsign = '" + this.tbBookSymbol_Mod.Text + "', book_pubdate = '" + this.cbBookPbYear_Mod.SelectedItem + "-" + this.cbBookPbMonth_Mod.SelectedItem + "-" + this.cbBookPbDay_Mod.SelectedItem  + "', book_field = '" + this.cbBookGenre_Mod.SelectedItem + "', book_lang = '" + cbBookLanguage_Mod.SelectedItem + "', book_vol = '" + this.tbBookVol_Mod.Text + "', book_copy = '" + this.tbBookCopy_Mod.Text + "', book_oripri = " + Convert.ToInt32(this.tbBookOriPri_Mod.Text) + ", book_getpri = " + Convert.ToInt32(this.tbBookGetPri_Mod.Text) + ", book_gettype = '" + this.cbBookGetType_Mod.SelectedItem + "' WHERE Book.book_num = '" + this.tbBookNum_Mod.Text + "';";
                    var Comm = new OleDbCommand(sql, Conn);
                    int x = Comm.ExecuteNonQuery();
                    if (x == 1)
                    {
                        MessageBox.Show("자료가 수정되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //자료 수정후 검색결과 전부 초기화
                        this.tbBookNum_Mod.Text = this.tbBookName_Mod.Text = this.tbBookSign_Mod.Text = this.tbBookPublisher_Mod.Text = this.tbBookSymbol_Mod.Text = this.tbBookVol_Mod.Text = this.tbBookCopy_Mod.Text = this.tbBookOriPri_Mod.Text = this.tbBookGetPri_Mod.Text = this.tbBookState_Mod.Text = "";
                        this.cbBookGenre_Mod.SelectedIndex = this.cbBookLanguage_Mod.SelectedIndex = this.cbBookGetType_Mod.SelectedIndex = 0;
                        this.cbBookPbYear_Mod.SelectedItem = DateTime.Now.ToString("yyyy");
                        this.cbBookPbMonth_Mod.SelectedItem = DateTime.Now.ToString("MM");
                        this.cbBookPbDay_Mod.SelectedItem =  DateTime.Now.ToString("dd");
                        this.tbBookName_Mod.Enabled = this.tbBookSign_Mod.Enabled = this.tbBookPublisher_Mod.Enabled = this.tbBookSymbol_Mod.Enabled = this.cbBookPbYear_Mod.Enabled = this.cbBookPbMonth_Mod.Enabled = this.cbBookPbDay_Mod.Enabled = this.tbBookVol_Mod.Enabled = this.tbBookCopy_Mod.Enabled = this.tbBookOriPri_Mod.Enabled = this.tbBookGetPri_Mod.Enabled = this.cbBookGenre_Mod.Enabled = this.cbBookLanguage_Mod.Enabled = this.cbBookGetType_Mod.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("정상적으로 자료가 수정되지 않았습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Conn.Close();
                }
                else
                {
                    MessageBox.Show("자료가 대출중일 경우 수정할 수 없습니다..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            { 
                MessageBox.Show("수정할 자료를 검색해주세요.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //tbBookNum_Mod 수정 시도시 조회한 값 초기화
        private void tbBookNum_Mod_MouseClick(object sender, MouseEventArgs e)
        {
            this.tbBookName_Mod.Text = this.tbBookSign_Mod.Text = this.tbBookPublisher_Mod.Text = this.tbBookSymbol_Mod.Text = this.tbBookVol_Mod.Text = this.tbBookCopy_Mod.Text = this.tbBookOriPri_Mod.Text = this.tbBookGetPri_Mod.Text = this.tbBookState_Mod.Text = "";
            this.cbBookGenre_Mod.SelectedIndex = this.cbBookLanguage_Mod.SelectedIndex = this.cbBookGetType_Mod.SelectedIndex = 0;
            this.cbBookPbYear_Mod.SelectedItem = DateTime.Now.ToString("yyyy");
            this.cbBookPbMonth_Mod.SelectedItem = DateTime.Now.ToString("MM");
            this.cbBookPbDay_Mod.SelectedItem = DateTime.Now.ToString("dd");
            this.tbBookName_Mod.Enabled = this.tbBookSign_Mod.Enabled = this.tbBookPublisher_Mod.Enabled = this.tbBookSymbol_Mod.Enabled = this.cbBookPbYear_Mod.Enabled = this.cbBookPbMonth_Mod.Enabled = this.cbBookPbDay_Mod.Enabled = this.tbBookVol_Mod.Enabled = this.tbBookCopy_Mod.Enabled = this.tbBookOriPri_Mod.Enabled = this.tbBookGetPri_Mod.Enabled = this.cbBookGenre_Mod.Enabled = this.cbBookLanguage_Mod.Enabled = this.cbBookGetType_Mod.Enabled = false;

        }

        //자료삭제 검색 버튼
        private void btnSearch_Del_Click(object sender, EventArgs e)
        {
            var Conn = new OleDbConnection(StrSQL);
            Conn.Open();

            //tbBookNum 검색, 검색 값 주입
            string sql = "SELECT * FROM Book WHERE Book.book_num = '" + tbBookNum_Del.Text + "';";
            var Comm = new OleDbCommand(sql, Conn);
            var myRead = Comm.ExecuteReader();

            if (myRead.Read() == true)
            {
                this.tbBookName_Del.Text = myRead[1].ToString();
                this.tbBookSign_Del.Text = myRead[2].ToString();
                this.tbBookPublisher_Del.Text = myRead[3].ToString();
                this.tbBookSymbol_Del.Text = myRead[4].ToString();
                this.tbBookPbDate_Del.Text = myRead[5].ToString();
                this.tbBookVol_Del.Text = myRead[8].ToString();
                this.tbBookCopy_Del.Text = myRead[9].ToString();
                this.tbBookOriPri_Del.Text = myRead[10].ToString();
                this.tbBookGetPri_Del.Text = myRead[11].ToString();
                this.tbBookState_Del.Text = myRead[13].ToString();

                this.cbBookGenre_Del.SelectedItem = myRead[6].ToString();
                this.cbBookLanguage_Del.SelectedItem = myRead[7].ToString();
                this.cbBookGetType_Del.SelectedItem = myRead[12].ToString();
            }
            else if (myRead.Read() == false)
            {
                this.tbBookName_Del.Text = "검색 결과 없음";
            }
            myRead.Close();
            Conn.Close();
        }

        //자료삭제 버튼
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(tbBookName_Del.Text != "")
            {
                if(tbBookState_Del.Text != "대출중")
                {
                    var Conn = new OleDbConnection(StrSQL);
                    Conn.Open();

                    string sql = "DELETE FROM Book WHERE Book.book_num = '" + tbBookNum_Del.Text + "';";
                    var Comm = new OleDbCommand(sql, Conn);
                    int x = Comm.ExecuteNonQuery();
                    if(x == 1)
                    {
                        MessageBox.Show("자료가 삭제되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //자료 삭제후 검색결과 전부 초기화
                        this.tbBookNum_Del.Text = this.tbBookName_Del.Text = this.tbBookSign_Del.Text = this.tbBookPublisher_Del.Text = this.tbBookSymbol_Del.Text = this.tbBookPbDate_Del.Text = this.tbBookVol_Del.Text = this.tbBookCopy_Del.Text = this.tbBookOriPri_Del.Text = this.tbBookGetPri_Del.Text = this.tbBookState_Del.Text = "";
                        this.cbBookGenre_Del.SelectedIndex = this.cbBookLanguage_Del.SelectedIndex = this.cbBookGetType_Del.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show("정상적으로 자료가 삭제되지 않았습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Conn.Close();
                }
                else
                {
                    MessageBox.Show("자료가 대출중일 경우 삭제할 수 없습니다..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("삭제할 자료를 검색해주세요.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //tbBookNum_Del 수정 시도시 조회한 값 초기화
        private void tbBookNum_Del_MouseClick(object sender, MouseEventArgs e)
        {
            this.tbBookName_Del.Text = this.tbBookSign_Del.Text = this.tbBookPublisher_Del.Text = this.tbBookSymbol_Del.Text = this.tbBookPbDate_Del.Text = this.tbBookVol_Del.Text = this.tbBookCopy_Del.Text = this.tbBookOriPri_Del.Text = this.tbBookGetPri_Del.Text = this.tbBookState_Del.Text = "";
            this.cbBookGenre_Del.SelectedIndex = this.cbBookLanguage_Del.SelectedIndex = this.cbBookGetType_Del.SelectedIndex = 0;
        }
    }
}
