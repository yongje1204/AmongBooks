using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj
{
    public partial class List : Form
    {
        ListPanel panel = new ListPanel();
        ListBookChk chk = new ListBookChk();
        ListBookRtn rtn = new ListBookRtn();
        ListBookSearch srch = new ListBookSearch();
        ListBookMng bookmng = new ListBookMng();
        ListUserMng usermng = new ListUserMng();

        public List()
        {
            InitializeComponent();
            panel.FormSendEvent += new ListPanel.FormSendDataHandler(listshow);

            panel.TopLevel = chk.TopLevel = rtn.TopLevel  = srch.TopLevel = bookmng.TopLevel = usermng.TopLevel = false;

            this.Controls.Add(panel);

            this.Controls.Add(chk);
            this.Controls.Add(rtn);
            this.Controls.Add(srch);
            this.Controls.Add(bookmng);
            this.Controls.Add(usermng);

            chk.Location = new Point(200, 0);
            rtn.Location = new Point(200, 0);
            srch.Location = new Point(200, 0);
            bookmng.Location = new Point(200, 0);
            usermng.Location = new Point(200, 0);

            panel.Show();

        }
        public List(int i):this()
        {
            listshow(i);
        }

        //리스트 패널에서 클릭시 다른 폼 Hide, 누른 패널만 Show
        private void listshow(int i)
        {
            switch (i)
            {
                case 1:
                    chkshow();
                    break;
                case 2:
                    rtnshow();
                    break;
                case 3:
                    srchshow();
                    break;
                case 4:
                    bookmngshow();
                    break;
                case 5:
                    usermngshow();
                    break;
                case 6:

                    break;
                case 7:
                    this.Hide();
                    break;
            }
        }
        public void chkshow()
        {
            chk.Show();
            rtn.Hide();
            srch.Hide();
            bookmng.Hide();
            usermng.Hide();
        }
        public void rtnshow()
        {
            chk.Hide();
            rtn.Show();
            srch.Hide();
            bookmng.Hide();
            usermng.Hide();
        }
        public void srchshow()
        {
            chk.Hide();
            rtn.Hide();
            srch.Show();
            bookmng.Hide();
            usermng.Hide();

        }
        public void bookmngshow()
        {
            chk.Hide();
            rtn.Hide();
            srch.Hide();
            bookmng.Show();
            usermng.Hide();
        }
        public void usermngshow()
        {
            chk.Hide();
            rtn.Hide();
            srch.Hide();
            bookmng.Hide();
            usermng.Show();
        }

        private void List_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
