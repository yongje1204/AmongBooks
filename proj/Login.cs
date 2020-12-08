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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private string StrSQL = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=AmongBooks.accdb;Mode=ReadWrite"; //데이터베이스 연결 문자열
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbPsw.Text != "" && tbId.Text != "")
            {
                string strCom = "select * from manager where mng_id ='" + tbId.Text + "' and mng_pwd='" + tbPsw.Text + "'";
                OleDbConnection obConn = new OleDbConnection(StrSQL);
                OleDbCommand obCmd = new OleDbCommand(strCom, obConn);
                obConn.Open();
                OleDbDataReader read = obCmd.ExecuteReader();

                if (read.Read())
                {
                    Main main = new Main();
                    main.Show();
                    this.Hide();
                    read.Close();
                }
                else
                {
                    MessageBox.Show("관리자에게 계정 등록을 문의하십시오", "로그인 오류");
                }
            }
            else {
                if (tbId.Text == "")
                {
                    MessageBox.Show("아이디를 입력하십시오", "");
                    tbId.Focus();
                }
                else {
                    MessageBox.Show("비밀번호를 입력하십시오", "");
                    tbPsw.Focus();
                }
            }

        }

        private void tbPsw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                if (tbPsw.Text != "")
                {
                    btnLogin_Click(sender, e);
                }
                else {
                    MessageBox.Show("비밀번호를 입력하십시오", "");
                    tbPsw.Focus();
                }
            }
        }

        private void tbId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbId.Text != "")
                {
                    MessageBox.Show("비밀번호를 입력하십시오", "");
                    tbPsw.Focus();
                }
                else
                {
                    MessageBox.Show("아이디를 입력하십시오", "");
                    tbId.Focus();
                }
            }
        }
    }
}
