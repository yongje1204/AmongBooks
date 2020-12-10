using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj
{
    public partial class Main : Form
    {
        string mng_id = Login.mng_id;

        public Main()
        {
            InitializeComponent();
            lblUser.Text = mng_id;
        }

        private void btnBookChk_MouseEnter(object sender, EventArgs e)
        {
            this.btnBookChk.BackColor = System.Drawing.Color.GreenYellow;
            this.btnBookChk.ImageIndex = 1;
            this.btnBookChk.ForeColor = System.Drawing.Color.White;

        }

        private void btnBookChk_MouseLeave(object sender, EventArgs e)
        {
            this.btnBookChk.BackgroundImage = null;
            this.btnBookChk.BackColor = System.Drawing.Color.White;
            this.btnBookChk.ImageIndex = 0;
            this.btnBookChk.ForeColor = System.Drawing.Color.Black;
        }

        private void btnBookRtn_MouseEnter(object sender, EventArgs e)
        {
            this.btnBookRtn.BackColor = System.Drawing.Color.OrangeRed;
            this.btnBookRtn.ImageIndex = 1;
            this.btnBookRtn.ForeColor = System.Drawing.Color.White;
        }

        private void btnBookRtn_MouseLeave(object sender, EventArgs e)
        {
            this.btnBookRtn.BackgroundImage = null;
            this.btnBookRtn.BackColor = System.Drawing.Color.White;
            this.btnBookRtn.ImageIndex = 0;
            this.btnBookRtn.ForeColor = System.Drawing.Color.Black;

        }

        private void btnBookSearch_MouseEnter(object sender, EventArgs e)
        {
            this.btnBookSearch.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBookSearch.ImageIndex = 1;
            this.btnBookSearch.ForeColor = System.Drawing.Color.White;
        }

        private void btnBookSearch_MouseLeave(object sender, EventArgs e)
        {
            this.btnBookSearch.BackgroundImage = null;
            this.btnBookSearch.BackColor = System.Drawing.Color.White;
            this.btnBookSearch.ImageIndex = 0;
            this.btnBookSearch.ForeColor = System.Drawing.Color.Black;
        }

        private void btnBookMng_MouseEnter(object sender, EventArgs e)
        {
            this.btnBookMng.BackColor = System.Drawing.Color.BlueViolet;
            this.btnBookMng.ImageIndex = 1;
            this.btnBookMng.ForeColor = System.Drawing.Color.White;
        }

        private void btnBookMng_MouseLeave(object sender, EventArgs e)
        {
            this.btnBookMng.BackgroundImage = null;
            this.btnBookMng.BackColor = System.Drawing.Color.White;
            this.btnBookMng.ImageIndex = 0;
            this.btnBookMng.ForeColor = System.Drawing.Color.Black;
        }

        private void btnUserMng_MouseEnter(object sender, EventArgs e)
        {
            this.btnUserMng.BackColor = System.Drawing.Color.DarkCyan;
            this.btnUserMng.ImageIndex = 1;
            this.btnUserMng.ForeColor = System.Drawing.Color.White;
        }

        private void btnUserMng_MouseLeave(object sender, EventArgs e)
        {
            this.btnUserMng.BackgroundImage = null;
            this.btnUserMng.BackColor = System.Drawing.Color.White;
            this.btnUserMng.ImageIndex = 0;
            this.btnUserMng.ForeColor = System.Drawing.Color.Black;
        }

        private void btnBookChk_Click(object sender, EventArgs e)
        {
            List list = new List(1);
            list.Show();
            this.Hide();
        }

        private void btnBookRtn_Click(object sender, EventArgs e)
        {
            List list = new List(2);
            list.Show();
            this.Hide();
        }

        private void btnBookSearch_Click(object sender, EventArgs e)
        {
            List list = new List(3);
            list.Show();
            this.Hide();
        }

        private void btnBookMng_Click(object sender, EventArgs e)
        {
            List list = new List(4);
            list.Show();
            this.Hide();
        }

        private void btnUserMng_Click(object sender, EventArgs e)
        {
            List list = new List(5);
            list.Show();
            this.Hide();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }



    }
}
