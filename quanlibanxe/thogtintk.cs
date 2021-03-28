using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlibanxe
{
    public partial class thogtintk : Form
    {
        public thogtintk()
        {
            InitializeComponent();
        }

        private void buttonquanli_Click(object sender, EventArgs e)
        {
            quanli a = new quanli();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void buttonnhanvien_Click(object sender, EventArgs e)
        {
            Formnhanvien a = new Formnhanvien();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }
    }
}
