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
    public partial class ListUserMng : Form
    {
        private string StrSQL = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=AmongBooks.accdb;Mode=ReadWrite"; //데이터베이스 연결 문자열

        public ListUserMng()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;

            Usernum_Cnt();
            var Conn = new OleDbConnection(StrSQL);
            Conn.Open();

            string sql = "SELECT count(*) FROM member WHERE (user_num LIKE 'u" + DateTime.Now.ToString("yyyyMMdd") + "_%%%');";
            var Comm = new OleDbCommand(sql, Conn);
            var myRead = Comm.ExecuteReader();
            while (myRead.Read())
            {
                string user_reg_date = DateTime.Now.ToString("yyyyMMdd");
                string user_cnt = (Convert.ToInt32(myRead[0]) + 1).ToString().PadLeft(3, '0');

                tbUserNum_Cre.Text = "u" + user_reg_date + "_" + user_cnt;

                
            }
            myRead.Close();


        }

        

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string gender, user_type,birth,phone,email;


            if (tbUserName_Cre.Text != "" && tbUserPhone1_Cre.Text != "" && tbUserPhone2_Cre.Text != ""
                && tbUserPhone3_Cre.Text != "")
            {


                var Conn = new OleDbConnection(StrSQL);
                Conn.Open();


                if (rbMale_Cre.Checked == true)
                {
                    gender = rbMale_Cre.Text;
                }
                else
                {
                    gender = rbFemale_Cre.Text;
                };


                if (rbTypeMem_Cre.Checked == true)
                {
                    user_type = rbTypeMem_Cre.Text;
                }
                else
                {
                    user_type = rbTypeEmp_Cre.Text;
                };

                birth = cbUserBirth1_Cre.Text +"-"+ cbUserBirth2_Cre.Text +"-"+ cbUserBirth3_Cre.Text;
                phone = tbUserPhone1_Cre.Text + "-" + tbUserPhone2_Cre.Text + "-" + tbUserPhone3_Cre.Text;
                email = tbUserEmail1_Cre.Text + "@" + tbUserEmail2_Cre.Text;


                string Sql = "insert into member(user_num,user_name,user_sex,user_birth,user_phone,user_add,user_type,user_email) values ('" + tbUserNum_Cre.Text + "','" + tbUserName_Cre.Text + "','" + gender + "','" +
                    birth + "','" + phone + "', '" + tbUserAddr_Cre.Text + "', '" + user_type + "', '" + email + "')";

                var Comm = new OleDbCommand(Sql, Conn);
                int i = Comm.ExecuteNonQuery();
                Conn.Close();

                if (i == 1)
                {
                    MessageBox.Show("정상적으로 회원이 등록되었습니다.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    Controll_Clear();
                    Usernum_Cnt();


                }
                else
                {
                    MessageBox.Show("정상적으로 회원이 등록되지 않았습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else {
                MessageBox.Show("* 표시된 항목은 필수 입력 항목입니다.", "");
            }
        }

        private void Controll_Clear() // 입력란 공백 처리
        {
            tbUserName_Cre.Clear();
            tbUserPhone1_Cre.Clear();
            tbUserPhone2_Cre.Clear();
            tbUserPhone3_Cre.Clear();
            tbUserAddr_Cre.Clear();
            tbUserEmail1_Cre.Clear();
            tbUserEmail2_Cre.Clear();
            rbMale_Cre.Select();
            cbUserBirth1_Cre.SelectedIndex = 0;
            cbUserBirth2_Cre.SelectedIndex = 0;
            cbUserBirth3_Cre.SelectedIndex = 0;
        }
        
        private void Usernum_Cnt() // 회원번호
        {
            int cnt = 1;
            string user_reg_date = DateTime.Now.ToString("yyyyMMdd");

            string user_cnt = cnt.ToString("000");
            tbUserNum_Cre.Text = "u" + user_reg_date + "_" + user_cnt;

        }

    }
}
