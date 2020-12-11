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
    public partial class ListBookSearch : Form
    {
        public ListBookSearch()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }


        private string StrSQL = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=AmongBooks.accdb;Mode=ReadWrite"; //데이터베이스 연결 문자열

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();

            if (tbSearch_word.Text!="") { 
                var Conn = new OleDbConnection(StrSQL);
                Conn.Open();
                var Sql = "select book_num, book_state, book_name, book_callsign, book_auth, book_pub, book_pubdate, book_vol, book_copy, " +
                    "book_oripri, book_getpri, book_gettype, book_field, book_lang from book where book_num Like '%" + tbSearch_word.Text + "%' " +
                    "or book_name Like '%"+tbSearch_word.Text+"%' or book_callsign Like '%"+tbSearch_word.Text+"%' or book_auth Like '%"+tbSearch_word.Text+"%' "+
                    "or book_pub Like '%"+tbSearch_word.Text+"%'";


                var Comm = new OleDbCommand(Sql, Conn);
                var myRead = Comm.ExecuteReader();

                while (myRead.Read())
                {
                    this.listView1.Items.Add(new ListViewItem(new string[] { 
                        myRead[0].ToString(),myRead[1].ToString(),myRead[2].ToString(),myRead[3].ToString(),
                        myRead[4].ToString(),myRead[5].ToString(),myRead[6].ToString(),myRead[7].ToString(),myRead[8].ToString(),
                        myRead[9].ToString(),myRead[10].ToString(),myRead[11].ToString(),myRead[12].ToString(),myRead[13].ToString()
                    }));
                    
                }

                myRead.Close();
                Conn.Close();
            }
        }

        private void tbSearch_word_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                if (tbSearch_word.Text != "") {
                    btnSearch_Click(sender, e);
                }
                else{
                    MessageBox.Show("검색어를 입력하세요", "");
                }
            }
        }
    }
}
