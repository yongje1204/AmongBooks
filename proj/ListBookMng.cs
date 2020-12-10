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
            this.cbBookGenre_Cre.SelectedIndex = this.cbBookLanguage_Cre.SelectedIndex = this.cbBookPbMonth_Cre.SelectedIndex = this.cbBookGetType_Cre.SelectedIndex = 0;
            this.cbBookPbYear_Cre.SelectedItem = DateTime.Now.ToString("yyyy");
            this.cbBookPbMonth_Cre.SelectedItem = DateTime.Now.ToString("MM");
            this.cbBookPbDate_Cre.SelectedItem = DateTime.Now.ToString("dd");
        }

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
            sql = "INSERT INTO BOOK(book_num, book_name, book_auth, book_pub, book_callsign, book_pubdate, book_field, book_lang, book_vol, book_copy, book_oripri, book_getpri, book_gettype, book_state) VALUES('b" + DateTime.Now.ToString("yyyyMMdd") + "_" + bok_num + "', '" + this.tbBookName_Cre.Text + "', '" + this.tbBookSign_Cre.Text + "', '" + this.tbBookPublisher_Cre.Text + "', '" + this.tbBookSymbol_Cre.Text + "', '" + this.cbBookPbYear_Cre.SelectedItem + "-" + this.cbBookPbMonth_Cre.SelectedItem + "-" + this.cbBookPbDate_Cre.SelectedItem + "', '" + this.cbBookGenre_Cre.SelectedItem + "', '" + this.cbBookLanguage_Cre.SelectedItem + "', '" + this.tbBookVol_Cre.Text + "', '" + this.tbBookCopy_Cre.Text + "', '" + Convert.ToInt32(this.tbBookOriPri_Cre.Text) + "', '" + Convert.ToInt32(this.tbBookGetPri_Cre.Text) + "', '" + this.cbBookGetType_Cre.SelectedItem + "', '대출가능');";
            Comm = new OleDbCommand(sql, Conn);
            int x = Comm.ExecuteNonQuery();

            if (x == 1)
            {
                MessageBox.Show("정상적으로 데이터가 저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 자료 등록 후 폼초기화
                this.tbBookName_Cre.Text = this.tbBookSign_Cre.Text = this.tbBookPublisher_Cre.Text = this.tbBookSymbol_Cre.Text = this.tbBookVol_Cre.Text = this.tbBookCopy_Cre.Text = this.tbBookOriPri_Cre.Text = this.tbBookGetPri_Cre.Text = "";
                this.cbBookGenre_Cre.SelectedIndex = this.cbBookLanguage_Cre.SelectedIndex = this.cbBookPbMonth_Cre.SelectedIndex = this.cbBookGetType_Cre.SelectedIndex = 0;
                this.cbBookPbYear_Cre.SelectedItem = DateTime.Now.ToString("yyyy");
                this.cbBookPbMonth_Cre.SelectedItem = DateTime.Now.ToString("MM");
                this.cbBookPbDate_Cre.SelectedItem = DateTime.Now.ToString("dd");
            }
            else
            {
                MessageBox.Show("정상적으로 데이터가 저장되지 않았습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Conn.Close();
        }
    }
}
