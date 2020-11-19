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
    public partial class ListBookSearch : Form
    {
        public ListBookSearch()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }

        private void ListBookSearch_Load(object sender, EventArgs e)
        {
            this.cbRecord.SelectedIndex = this.cbLanguage.SelectedIndex = this.cbGenre.SelectedIndex = this.cbRate.SelectedIndex = this.cbSearchType.SelectedIndex = 0;
        }
    }
}
