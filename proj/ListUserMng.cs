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
        string gender, user_type, birth, phone, email;


        public ListUserMng()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            User_Cnt();
            cbUserBirth1_Cre.SelectedIndex = 0;
            cbUserBirth2_Cre.SelectedIndex = 0;
            cbUserBirth3_Cre.SelectedIndex = 0;
        }

        

        private void btnCreate_Click(object sender, EventArgs e)
        {
            


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
                    User_Cnt();

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

        private void btnSearch_Del_Click(object sender, EventArgs e)
        {
            lvBookList.Items.Clear();

            var Conn = new OleDbConnection(StrSQL);
            Conn.Open();

            string sql = "SELECT user_name, user_birth,user_phone FROM member WHERE user_num = '" + tbUserNum_Del.Text + "';";
            var Comm = new OleDbCommand(sql, Conn);
            var myRead = Comm.ExecuteReader();


            if (myRead.Read())
            {
                tbUserName_Del.Text = myRead[0].ToString();

                string birth = myRead[1].ToString();
                string[] births = birth.Split(new char[] { '-' });
                cbUserBirth1_Del.Text = births[0];
                cbUserBirth2_Del.Text = births[1];
                cbUserBirth3_Del.Text = births[2];


                string phone = myRead[2].ToString();
                string[] phones = phone.Split(new char[] { '-' });
                tbUserPhone1_Del.Text = phones[0];
                tbUserPhone2_Del.Text = phones[1];
                tbUserPhone3_Del.Text = phones[2];
            }
            else
            {
                MessageBox.Show("해당되는 회원이 존재하지 않습니다.", "");
            }
            myRead.Close();

            sql = "select rent_num, book_num,rent_state,rent_date,return_date from rent where user_num ='" + tbUserNum_Del.Text + "'and rent_state='대출중';";
            Comm = new OleDbCommand(sql, Conn);
            myRead = Comm.ExecuteReader();



            while (myRead.Read())
            {
                this.lvBookList.Items.Add(new ListViewItem(new string[] {
                        myRead[0].ToString(),myRead[1].ToString(),myRead[2].ToString(),myRead[3].ToString(),myRead[4].ToString()
                    }));

            }

            myRead.Close();
            Conn.Close();


        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvBookList.Items.Count == 0) {
                DialogResult dlr = MessageBox.Show("'"+ tbUserName_Del.Text +"'회원을 탈퇴하시겠습니까?", "알림",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch (dlr)
                {
                    case DialogResult.Yes:
                        var Conn = new OleDbConnection(StrSQL);
                        Conn.Open();

                        string sql = "delete from member WHERE user_num = '" + tbUserNum_Del.Text + "';";
                        var Comm = new OleDbCommand(sql, Conn);
                        var myRead = Comm.ExecuteNonQuery();
                        Conn.Close();

                        if (myRead == 1)
                        {
                            MessageBox.Show("정상적으로 회원이 탈퇴되었습니다.", "알림",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lvBookList.Clear();
                            tbUserNum_Del.Clear();
                            tbUserName_Del.Clear();
                            cbUserBirth1_Del.SelectedIndex = 0;
                            cbUserBirth2_Del.SelectedIndex = 0;
                            cbUserBirth3_Del.SelectedIndex = 0;
                            tbUserPhone1_Del.Clear();
                            tbUserPhone2_Del.Clear();
                            tbUserPhone3_Del.Clear();

                        }
                        else
                        {
                            MessageBox.Show("정상적으로 회원이 되지 않았습니다.", "에러",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case DialogResult.No:
                        break;
                }

            }
            else
            {
                MessageBox.Show("대출 중인 책이 있는 경우에는 회원 탈퇴가 불가능합니다.", "알림");
            }
        }

        private void tbUserNum_Del_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Del_Click(sender, e);
            }

        }

        private void User_Cnt() {
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
        

        private void btnSearch_Mod_Click(object sender, EventArgs e)
        {
            var Conn = new OleDbConnection(StrSQL);
            Conn.Open();

            string sql = "SELECT * FROM member WHERE user_num = '"+tbUserNum_Mod.Text+"';";
            var Comm = new OleDbCommand(sql, Conn);
            var myRead = Comm.ExecuteReader();



            if (myRead.Read())
            {
                tbUserName_Mod.Text = myRead[1].ToString();

                if (myRead[2].ToString() == "남자") rbMale_Mod.Checked = true;
                else rbFemale_Mod.Checked = true;

                string birth = myRead[3].ToString();
                string[] births = birth.Split(new char[] { '-' });
                cbUserBirth1_Mod.Text = births[0];
                cbUserBirth2_Mod.Text = births[1];
                cbUserBirth3_Mod.Text = births[2];


                string phone = myRead[4].ToString();
                string[] phones = phone.Split(new char[] { '-' });
                tbUserPhone1_Mod.Text = phones[0];
                tbUserPhone2_Mod.Text = phones[1];
                tbUserPhone3_Mod.Text = phones[2];

                tbUserAddr_Mod.Text = myRead[5].ToString();

                if (myRead[6].ToString() == "일반 회원") rbTypeMem_Mod.Checked = true;
                else rbTypeEmp_Mod.Checked = true;


                string email = myRead[7].ToString();
                string[] emails = email.Split(new char[] { '@' });
                tbUserEmail1_Mod.Text = emails[0];
                tbUserEmail2_Mod.Text = emails[1];

            }
            else {
                MessageBox.Show("해당되는 회원이 존재하지 않습니다.", "");
                
            }
            myRead.Close();
        }

        private void tbUserNum_Mod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                btnSearch_Mod_Click(sender,e);
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (tbUserName_Mod.Text != "" && tbUserPhone1_Mod.Text != "" && tbUserPhone2_Mod.Text != ""
               && tbUserPhone3_Mod.Text != "")
            {


                var Conn = new OleDbConnection(StrSQL);
                Conn.Open();


                if (rbMale_Mod.Checked == true)
                {
                    gender = rbMale_Mod.Text;
                }
                else
                {
                    gender = rbFemale_Mod.Text;
                };


                if (rbTypeMem_Mod.Checked == true)
                {
                    user_type = rbTypeMem_Mod.Text;
                }
                else
                {
                    user_type = rbTypeEmp_Mod.Text;
                };

                birth = cbUserBirth1_Mod.Text + "-" + cbUserBirth2_Mod.Text + "-" + cbUserBirth3_Mod.Text;
                phone = tbUserPhone1_Mod.Text + "-" + tbUserPhone2_Mod.Text + "-" + tbUserPhone3_Mod.Text;
                email = tbUserEmail1_Mod.Text + "@" + tbUserEmail2_Mod.Text;


                string Sql = "UPDATE Member SET user_name ='" + tbUserName_Mod.Text + "',user_sex= '" + gender + "', user_birth= '" +
                    birth + "', user_phone= '" + phone + "', user_add= '" + tbUserAddr_Mod.Text + "', user_type= '" + user_type + "', user_email= '" + email + "' where user_num = '"+ tbUserNum_Mod.Text+"'";

                var Comm = new OleDbCommand(Sql, Conn);
                int i = Comm.ExecuteNonQuery();
                Conn.Close();

                if (i == 1)
                {
                    MessageBox.Show("정상적으로 회원정보가 수정되었습니다.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tbUserName_Mod.Clear();
                    tbUserPhone1_Mod.Clear();
                    tbUserPhone2_Mod.Clear();
                    tbUserPhone3_Mod.Clear();
                    tbUserAddr_Mod.Clear();
                    tbUserEmail1_Mod.Clear();
                    tbUserEmail2_Mod.Clear();
                    rbMale_Mod.Select();
                    cbUserBirth1_Mod.SelectedIndex = 0;
                    cbUserBirth2_Mod.SelectedIndex = 0;
                    cbUserBirth3_Mod.SelectedIndex = 0;

                }
                else
                {
                    MessageBox.Show("회원정보가 수정되지 않았습니다.", "에러",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }
            else
            {
                MessageBox.Show("* 표시된 항목은 필수 입력 항목입니다.", "");
            }
        }
    }
}
