using quanlibanxe.BLL;
using quanlibanxe.DAL;
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
    public partial class Formnhanvien : Form
    {
        BLLNHASX nhasx = new BLLNHASX();
        BLLXE xe = new BLLXE();
        BLLKH kh = new BLLKH();
        BLLBILLBAN billban = new BLLBILLBAN();
        BLLINFORBILLBAN infbillban = new BLLINFORBILLBAN();
        BLLBILLNHAP billnhap = new BLLBILLNHAP();
        BLLINFORBILLNHAP infbillnhap = new BLLINFORBILLNHAP();
        public Formnhanvien()
        {
            InitializeComponent();
            load();
        }

        void load()
        {
            loadnhasx();
            loadxe();
            loadkh();
            loadformbanhang();
            loadformnhaphang();
            loadformhoadon();
        }
        void loadnhasx()
        {
            dataGridViewnhasx.DataSource = nhasx.Getnhasx(); // truyền dữ liệu vào datagridview
        }
        void loadxe()
        {
            dataGridViewXE.DataSource = xe.Getxe();
        }
        void loadkh()
        {
            dataGridViewKH.DataSource = kh.Getkh();
        }
        void loadformbanhang()
        {
            comboBoxnhasxban.DataSource = nhasx.listnhasx();
            comboBoxnhasxban.DisplayMember = "ten";
        }
        void loadformnhaphang()
        {
            comboBoxnhasxnhap.DataSource = nhasx.listnhasx();
            comboBoxnhasxnhap.DisplayMember = "ten";
        }
        void loadformhoadon()
        {
            dataGridViewbillban.DataSource = billban.Getbillban();
            dataGridViewbillnhap.DataSource = billnhap.Getbillnhap();
        }
        void loadthongtinban(string id)
        {
            dataGridViewbillbaninfor.DataSource = infbillban.Getinforbillban(id);
            //dataGridViewbillnhapinfor.DataSource = infbillnhap.Getinforbillnhap(id);
        }
        void loadthongtinnhap(string id)
        {
            
            dataGridViewbillnhapinfor.DataSource = infbillnhap.Getinforbillnhap(id);
        }
        ListViewItem addlistban(string maxe,string tenxe,string nhasx,int sl,int tien)
        {
            ListViewItem a = new ListViewItem();
            a.Text = maxe;
            a.SubItems.Add(tenxe);
            a.SubItems.Add(nhasx);
            a.SubItems.Add(sl.ToString());
            a.SubItems.Add(tien.ToString());
            return a;
        }
        ListViewItem addlistnhap(string maxe, string tenxe, string nhasx, int sl, int tien)
        {
            ListViewItem a = new ListViewItem();
            a.Text = maxe;
            a.SubItems.Add(tenxe);
            a.SubItems.Add(nhasx);
            a.SubItems.Add(sl.ToString());
            a.SubItems.Add(tien.ToString());
            return a;
        }
        void loadttienban(int a)
        {
            textBoxtongtienban.Text = (Convert.ToInt32(textBoxtongtienban.Text) + a).ToString();
        }
        void loadttiennhap(int a)
        {
            textBoxtongtiennhap.Text = (Convert.ToInt32(textBoxtongtiennhap.Text) + a).ToString();
        }
        private void buttonthemnhasx_Click(object sender, EventArgs e)
        {
            //lấy thông tin từ textbox
            string manhasx = textBoxmanhasx.Text;
            string tennhasx = textBoxtennhasx.Text;
            string emailnhasx = textBoxemailnhasx.Text;
            Int32.TryParse(textBoxsdtnhasx.Text, out int sdtnhax);
            NHASX a = new NHASX(manhasx, tennhasx, emailnhasx, sdtnhax);//tạo 1 DTO nhà sx
            if (manhasx != "" && tennhasx != "" && emailnhasx != "" && sdtnhax != 0)//kiểm tra textbox khác 0
            {
                if (nhasx.ADD(a)) //kiểm tra thực hiện query thành công
                {
                    load();//load lại bảng
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

        private void buttonsuanhasx_Click(object sender, EventArgs e)
        {
            //lấy thông tin từ textbox
            string manhasx = textBoxmanhasx.Text;
            string tennhasx = textBoxtennhasx.Text;
            string emailnhasx = textBoxemailnhasx.Text;
            Int32.TryParse(textBoxsdtnhasx.Text, out int sdtnhax);
            NHASX a = new NHASX(manhasx, tennhasx, emailnhasx, sdtnhax); //tạo 1 DTO nhà sx
            if (manhasx != "" && tennhasx != "" && emailnhasx != "" && sdtnhax != 0) //kiểm tra textbox khác 0
            {
                if (nhasx.Update(a)) //kiểm tra thực hiện query thành công
                {
                    load();//load lại bảng
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

        private void buttonxoanhasx_Click(object sender, EventArgs e)
        {
            string manhasx = textBoxmanhasx.Text;
            if (manhasx != "") //kiểm tra textbox khác 0
            {
                if (nhasx.Delete(manhasx)) //kiểm tra thực hiện query thành công
                {
                    load();//load lại bảng
                }
                else
                {
                    MessageBox.Show("xoa that bai1");
                }
            }
            else
            {
                MessageBox.Show("xoa that bai2");
            }
        }

        private void buttonxoatext_Click(object sender, EventArgs e)
        {
            textBoxmanhasx.Clear();
            textBoxtennhasx.Clear();
            textBoxemailnhasx.Clear();
            textBoxsdtnhasx.Clear();
        }

        private void dataGridViewnhasx_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewnhasx.SelectedCells.Count == 1) // kiểm tra số hàng chọn =1 hay không
            {
                int rowindex = dataGridViewnhasx.SelectedCells[0].RowIndex; // lấy số của hàng khi chọn ô
                DataGridViewRow row = dataGridViewnhasx.Rows[rowindex];//lấy thông tin trên hàng
                //truyền dữ liệu vào text
                textBoxmanhasx.Text = row.Cells[0].Value.ToString();
                textBoxtennhasx.Text = row.Cells[1].Value.ToString();
                textBoxemailnhasx.Text = row.Cells[2].Value.ToString();
                textBoxsdtnhasx.Text = row.Cells[3].Value.ToString();
            }
        }

        private void buttontimnhasx_Click(object sender, EventArgs e)
        {
            string a = textBoxtimkiemnhasx.Text;
            if (a != null) // kiem tra text khac rong
            {
                dataGridViewnhasx.DataSource = nhasx.Search(a); // dua thong tin vao bang
            }
            if (a == null)
            {
                load(); // xuất bảng ban đầu
            }
        }

        private void buttonthemxe_Click(object sender, EventArgs e)
        {
            string ma = textBoxMAXE.Text;
            string ten = textBoxtenxe.Text;
            string nhasx = textBoxnhasxxe.Text;
            string ttbh = textBoxtnbaohanh.Text;
            string mt = textBoxmotaxe.Text;
            bool checkgia = Int32.TryParse(textBoxgiaxe.Text, out int gia);
            DTOXE a = new DTOXE(ma, ten, nhasx, mt, ttbh, gia);
            if (ma != "" && ten != "" && nhasx != "" && mt != "" && ttbh != "" && checkgia != false)
            {
                if (xe.Add(a))
                {
                    load();
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

        private void dataGridViewXE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewXE.SelectedCells.Count == 1)
            {
                int rowindex = dataGridViewXE.SelectedCells[0].RowIndex;
                DataGridViewRow row = dataGridViewXE.Rows[rowindex];
                textBoxMAXE.Text = row.Cells[0].Value.ToString(); ;
                textBoxtenxe.Text = row.Cells[1].Value.ToString(); ;
                textBoxnhasxxe.Text = row.Cells[2].Value.ToString(); ;
                textBoxtnbaohanh.Text = row.Cells[4].Value.ToString(); ;
                textBoxmotaxe.Text = row.Cells[5].Value.ToString(); ;
                textBoxsoluongxe.Text = row.Cells[3].Value.ToString();
                textBoxgiaxe.Text = row.Cells[6].Value.ToString();
            }
        }

        private void buttonsuaxe_Click(object sender, EventArgs e)
        {
            string ma = textBoxMAXE.Text;
            string ten = textBoxtenxe.Text;
            string nhasx = textBoxnhasxxe.Text;
            string ttbh = textBoxtnbaohanh.Text;
            string mt = textBoxmotaxe.Text;
            bool checkgia = Int32.TryParse(textBoxgiaxe.Text, out int gia);
            DTOXE a = new DTOXE(ma, ten, nhasx, mt, ttbh, gia);
            if (ma != "" && ten != "" && nhasx != "" && mt != "" && ttbh != "" && checkgia != false)
            {
                if (xe.Update(a))
                {
                    load();
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

        private void buttonxoaxe_Click(object sender, EventArgs e)
        {
            string a = textBoxMAXE.Text;
            if (a != "")
            {
                if (xe.Delete(a))
                {
                    load();
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

        private void buttontimkiemxe_Click(object sender, EventArgs e)
        {
            string a = textBoxtimkiemxe.Text;
            if (a != null)
            {
                dataGridViewXE.DataSource = xe.Search(a);
            }
            else
            {
                load();
            }
        }

        private void dataGridViewKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewKH.SelectedCells.Count == 1)
            {
                int rowindex = dataGridViewKH.SelectedCells[0].RowIndex;
                DataGridViewRow row = dataGridViewKH.Rows[rowindex];
                textBoxmakh.Text = row.Cells[0].Value.ToString();
                textBoxtenkh.Text = row.Cells[1].Value.ToString();
                textBoxemailkh.Text = row.Cells[4].Value.ToString();
                textBoxsdtkh.Text = row.Cells[3].Value.ToString();
                textBoxdiachikh.Text = row.Cells[2].Value.ToString();
            }
        }

        private void buttonsuakh_Click(object sender, EventArgs e)
        {
            string a = textBoxmakh.Text;
            string b = textBoxtenkh.Text;
            string c = textBoxdiachikh.Text;
            string d = textBoxemailkh.Text;
            bool sdt = Int32.TryParse(textBoxsdtkh.Text, out int dt);
            DTOKH k = new DTOKH( b, c, dt, d);
            if (a != "" && b != "" && c != "" && d != "" && sdt != false)
            {
                if (kh.Update(k))
                {
                    load();
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

        private void buttonxoakh_Click(object sender, EventArgs e)
        {
            string a = textBoxmakh.Text;
            if (a != "")
            {
                if (kh.Delete(a))
                {
                    load();
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

        private void buttontimkh_Click(object sender, EventArgs e)
        {
            string a = textBoxtimkiemkh.Text;
            if (a != null)
            {
                dataGridViewKH.DataSource = kh.Search(a);
            }
            else
            {
                load();
            }
        }

        private void comboBoxnhasxban_SelectedIndexChanged(object sender, EventArgs e)
        {
            NHASX a = comboBoxnhasxban.SelectedItem as NHASX; // ép kiểu về nhasx
            string i = a.Ma; //lấy mã nhà sản xuất
                comboBoxxeban.DataSource = xe.listxe(i); // load lại combobox
                comboBoxxeban.DisplayMember = "tenxe";
            

        }

        private void comboBoxnhasxnhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            NHASX a = comboBoxnhasxnhap.SelectedItem as NHASX; // ép kiểu về nhasx
            string i = a.Ma; //lấy mã nhà sản xuất
            comboBoxxenhap.DataSource = xe.listxe(i); // load lại combobox
            comboBoxxenhap.DisplayMember = "tenxe";
        }

        private void buttonthanhtoan_Click(object sender, EventArgs e)
        {
            string manv = textBoxmanvban.Text;
            DateTime day = dateTimePickerban.Value;
            string a = textBoxthongtinkh.Lines[0];
            string b = textBoxthongtinkh.Lines[1];
            bool ch = Int32.TryParse(textBoxthongtinkh.Lines[2], out int c);
            string d = textBoxthongtinkh.Lines[3];
            int tt = Convert.ToInt32(textBoxtongtienban.Text);
                DTOKH k = new DTOKH(a, b, c, d);
            if (a != "" && b != "" && d != "" && ch != false)
            {
                if (kh.Add(k))
                {
                    string makh = kh.Getmax().ToString();
                    DTOBILLBAN bi = new DTOBILLBAN(day, tt, makh, manv);
                    if (billban.Add(bi)){
                        string idbi = billban.Getmax().ToString();
                        foreach(ListViewItem item in listViewBAN.Items)
                        {
                            string nhasx = item.SubItems[2].Text;
                            string xe = item.SubItems[0].Text;
                            bool soluong = Int32.TryParse(item.SubItems[3].Text, out int sl);
                            Int32.TryParse(item.SubItems[4].Text, out int tien);
                            DTOINFORBILLBAN bif = new DTOINFORBILLBAN(xe, sl, nhasx, idbi);
                            if (infbillban.Add(bif,tien))
                            {
                                load();
                            }
                            else
                            {
                                MessageBox.Show("them thong tin bill that bai");
                                billban.Delete(idbi);
                                kh.Delete(makh);
                                load();
                                
                            }
                        }
                    }
                    else
                    {
                        kh.Delete(makh);
                        MessageBox.Show("them bill that bai");
                    }
                    
                }
                else
                {
                    MessageBox.Show("them khach hang that bai");
                }
            }
            else
            {
                MessageBox.Show("them that bai");
            }
            

        }

        private void buttonthemtnkh_Click(object sender, EventArgs e)
        {
            if (textBoxthongtinkh.Text == "")
            {
                textBoxthongtinkh.AppendText(textBoxnhaptenkh.Text + Environment.NewLine);
                textBoxthongtinkh.AppendText(textBoxnhapdiachi.Text + Environment.NewLine);
                textBoxthongtinkh.AppendText(textBoxnhapsdt.Text + Environment.NewLine);
                textBoxthongtinkh.AppendText(textBoxnhapemail.Text);
            }
            else
            {
                MessageBox.Show("them that bai");
            }
        }

        private void buttonthemvaobillnhap_Click(object sender, EventArgs e)
        {
            DTOXE xeban = comboBoxxeban.SelectedItem as DTOXE;
            string a = xeban.Maxe;
            string b = xeban.Tenxe;
            NHASX sx = comboBoxnhasxban.SelectedItem as NHASX;
            string c = sx.Ma;
            int d = Convert.ToInt32(numericUpDownxeban.Value.ToString());
            int f = xeban.Giaban * d;
            if (a != "" && b != "" && c != "" && d != 0)
            {
                listViewBAN.Items.Add(addlistban(a, b, c, d, f));
                loadttienban(f);
            }

        }

        private void dataGridViewbillban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewbillban.SelectedCells.Count == 1)
            {
                int rowindex = dataGridViewbillban.SelectedCells[0].RowIndex;
                DataGridViewRow row = dataGridViewbillban.Rows[rowindex];
                string a = row.Cells[0].Value.ToString();
                loadthongtinban(a);
            }
        }

        private void buttonthembillnhap_Click(object sender, EventArgs e)
        {
            DTOXE xenhap = comboBoxxenhap.SelectedItem as DTOXE;
            string a = xenhap.Maxe;
            string b = xenhap.Tenxe;
            NHASX sx = comboBoxnhasxnhap.SelectedItem as NHASX;
            string c = sx.Ma;
            int d = Convert.ToInt32(numericUpDownnhap.Value.ToString());
            int f = (xenhap.Giaban * d) / 10*7;
            if (a != "" && b != "" && c != "" && d != 0)
            {
                listViewnhap.Items.Add(addlistnhap(a, b, c, d, f));
                loadttiennhap(f);
                comboBoxnhasxnhap.Enabled = false;
            }
        }

        private void buttonthanhtoannhap_Click(object sender, EventArgs e)
        {
            NHASX sx = comboBoxnhasxnhap.SelectedItem as NHASX;
            string s = sx.Ma;
            string manv = textBoxmanvnhap.Text;
            DateTime day = dateTimePickernhap.Value;
            int tt = Convert.ToInt32(textBoxtongtiennhap.Text);
            DTOBILLNHAP bi = new DTOBILLNHAP(day,tt,manv,s);
            if (billnhap.Add(bi))
            {
                string idbi = billnhap.Getnew().ToString();
                foreach (ListViewItem item in listViewnhap.Items)
                {
                    string nhasx = item.SubItems[2].Text;
                    string xe = item.SubItems[0].Text;
                    bool soluong = Int32.TryParse(item.SubItems[3].Text, out int sl);
                    Int32.TryParse(item.SubItems[4].Text, out int tien);
                    DTOINFORBILLNHAP bif = new DTOINFORBILLNHAP(xe, sl, idbi);
                    if (infbillnhap.Add(bif, tien))
                    {
                        load();
                    }
                    else
                    {
                        MessageBox.Show("them thong tin bill that bai");
                        billnhap.Delete(idbi);
                        load();

                    }
                }
            }
            else
            {
                MessageBox.Show("them bill that bai");
            }
        }

        private void listViewBAN_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
