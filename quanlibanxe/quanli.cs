using quanlibanxe.BLL;
using quanlibanxe.DTO;
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
    public partial class quanli : Form
    {
        BLLNV nv = new BLLNV();
        BLLTK tk = new BLLTK();
        public quanli()
        {
            InitializeComponent();
            load();
        }
        void load()
        {
            loadnv();
            loadtk();
        }
        void loadnv()
        {
            dataGridViewNV.DataSource = nv.Getnv();
            comboBoxchucvunv.DataSource = nv.listcv();
            comboBoxchucvunv.DisplayMember = "tencv";
        }
        void loadtk()
        {
            dataGridViewTK.DataSource = tk.Gettk();
        }

        private void dataGridViewNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewNV.SelectedCells.Count == 1)
            {
                int rowindex = dataGridViewNV.SelectedCells[0].RowIndex;
                DataGridViewRow row = dataGridViewNV.Rows[rowindex];
                textBoxmanv.Text = row.Cells[0].Value.ToString(); 
                textBoxtennv.Text = row.Cells[1].Value.ToString();
                dateTimePickernamsinhnv.Text = row.Cells[2].Value.ToString();
                Int32.TryParse(row.Cells[3].Value.ToString(), out int a);
                textBoxsdtnv.Text = row.Cells[4].Value.ToString(); 
                textBoxemailnv.Text = row.Cells[5].Value.ToString();
                textBoxdiachinv.Text = row.Cells[6].Value.ToString();
                textBoxluongnv.Text= row.Cells[7].Value.ToString();
                Int32.TryParse(row.Cells[8].Value.ToString(), out int b);
                comboBoxchucvunv.Text = row.Cells[9].Value.ToString();
                if (a == 1)
                {
                    comboBoxgoitinhnv.Text = "NAM";
                }
                else if(a==0)
                {
                    comboBoxgoitinhnv.Text = "NỮ";
                }
                if (b == 1)
                {
                    comboBoxtrangthainv.Text = "ĐANG LÀM";
                }
                else if(b==0)
                {
                    comboBoxtrangthainv.Text = "ĐÃ NGHỈ";
                }
            }
        }

        private void buttonsuanv_Click(object sender, EventArgs e)
        {
            string a = textBoxmanv.Text;
            string b = textBoxtennv.Text;
            DateTime c = dateTimePickernamsinhnv.Value;
            bool sdt = Int32.TryParse(textBoxsdtnv.Text, out int d);
            string k =textBoxemailnv.Text;
            string g =textBoxdiachinv.Text;
            bool luong = Int32.TryParse(textBoxluongnv.Text, out int h);
            string gt = comboBoxgoitinhnv.Text;
            int x;
            if (gt == "NAM") x = 1;
            else x = 0;
            string tt = comboBoxtrangthainv.Text;
            int y;
            if (tt == "ĐANG LÀM") y = 1;
            else y = 0;
            CV t = comboBoxchucvunv.SelectedItem as CV;
            int ma = t.Macv;
            DTONV p = new DTONV(a, b, c, x, d, g, h, y,k,ma);
            //int cv = comboBoxchucvunv.
            if (a != "" && b != "" && sdt != false && k != "" && g != "" && luong != false && gt != "" && tt != "")
            {
                if (nv.Update(p))
                {
                    loadnv();
                }
                else
                {
                    MessageBox.Show("sua that bai");
                }
            }
            else
            {
                MessageBox.Show("sua that bai");
            }
        }

        private void buttonthemnv_Click(object sender, EventArgs e)
        {
            string a = textBoxmanv.Text;
            string b = textBoxtennv.Text;
            DateTime c = dateTimePickernamsinhnv.Value;
            bool sdt = Int32.TryParse(textBoxsdtnv.Text, out int d);
            string k = textBoxemailnv.Text;
            string g = textBoxdiachinv.Text;
            bool luong = Int32.TryParse(textBoxluongnv.Text, out int h);
            string gt = comboBoxgoitinhnv.Text;
            int x;
            if (gt == "NAM") x = 1;
            else x = 0;
            string tt = comboBoxtrangthainv.Text;
            int y;
            if (tt == "ĐANG LÀM") y = 1;
            else y = 0;
            CV t = comboBoxchucvunv.SelectedItem as CV;
            int ma = t.Macv;
            DTONV p = new DTONV(a, b, c, x, d, g, h, y, k,ma);
            if (a != "" && b != "" && sdt != false && k != "" && g != "" && luong != false && gt != "" && tt != ""&& ma!=-1)
            {
                if (nv.Add(p))
                {
                    loadnv();
                }
                else
                {
                    MessageBox.Show("them that bai");
                }
            }
            else
            {
                MessageBox.Show("them that bai1");
            }
        }

        private void buttontimnv_Click(object sender, EventArgs e)
        {
            string a = textBoxtimkiemnv.Text;
            if (a != "")
            {
                dataGridViewNV.DataSource = nv.Search(a);
            }
            else
            {
                loadnv();
            }
        }

        private void buttonxoatestnv_Click(object sender, EventArgs e)
        {
            textBoxmanv.Clear();
            textBoxtennv.Clear();
            textBoxsdtnv.Clear();
            textBoxemailnv.Clear();
            textBoxdiachinv.Clear();
            textBoxluongnv.Clear();
            comboBoxchucvunv.Text = null;
            comboBoxgoitinhnv.Text = null;
            comboBoxtrangthainv.Text = null;
            dateTimePickernamsinhnv.Value = DateTime.Now;
            loadnv();
        }

        private void buttonthemtk_Click(object sender, EventArgs e)
        {
            string a = textBoxmaaccnv.Text;
            string b = textBoxtendangnhap.Text;
            string c = textBoxmatkhau.Text;
            string d = textBoxtenhienthi.Text;
            ACC acc = new ACC(a, b, c, d);
            if (a != "" && b != "" && c != "" && d != "")
            {
                if (tk.Add(acc))
                {
                    loadtk();
                }
                else
                {
                    MessageBox.Show("them that bai");
                }
            }
            else
            {
                MessageBox.Show("them that bai");
            }
        }

        private void dataGridViewTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewTK.SelectedCells.Count == 1)
            {
                int rowindex = dataGridViewTK.SelectedCells[0].RowIndex;
                DataGridViewRow row = dataGridViewTK.Rows[rowindex];
                textBoxmaaccnv.Text = row.Cells[0].Value.ToString();
                textBoxtendangnhap.Text = row.Cells[1].Value.ToString();
                textBoxmatkhau.Text = row.Cells[2].Value.ToString();
                textBoxtenhienthi.Text = row.Cells[3].Value.ToString();
            }
        }

        private void buttonsuatk_Click(object sender, EventArgs e)
        {
            string a = textBoxmaaccnv.Text;
            string b = textBoxtendangnhap.Text;
            string c = textBoxmatkhau.Text;
            string d = textBoxtenhienthi.Text;
            ACC acc = new ACC(a, b, c, d);
            if (a != "" && b != "" && c != "" && d != "")
            {
                if (tk.Update(acc))
                {
                    loadtk();
                }
                else
                {
                    MessageBox.Show("sua that bai");
                }
            }
            else
            {
                MessageBox.Show("sua that bai");
            }
        }

        private void buttonxoatk_Click(object sender, EventArgs e)
        {
            string a = textBoxmaaccnv.Text;
            if (a != "")
            {
                if (tk.Delete(a))
                {
                    loadtk();
                }
                else
                {
                    MessageBox.Show("xoa that bai");
                }
            }
            else
            {
                MessageBox.Show("xoa that bai");
            }
        }

        private void buttontimtk_Click(object sender, EventArgs e)
        {
            string a = textBoxtimkiemtk.Text;
            if (a != "")
            {
                dataGridViewTK.DataSource = tk.Search(a);
            }
            else
            {
                loadtk();
            }
        }

        private void buttonxoatexttk_Click(object sender, EventArgs e)
        {
            textBoxmaaccnv.Clear();
            textBoxtendangnhap.Clear();
            textBoxmatkhau.Clear();
            textBoxtenhienthi.Clear();
            loadtk();
        }
    }
}
