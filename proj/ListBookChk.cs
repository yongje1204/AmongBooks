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
    public partial class ListBookChk : Form
    {
        public ListBookChk()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }

        private void ListBookChk_Load(object sender, EventArgs e)
        {
            cbChkType.SelectedIndex = 0;
            this.ActiveControl = tbBookNum;
        }

    }
}
