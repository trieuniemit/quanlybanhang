using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyBanHangLibraries;

namespace QuanLyBanHang.HoSyHuy
{
    public partial class ThemSuaSanPham : Form
    {
        int Ma = -1;
        SqlConnection con = Helper.SqlCnn;

        public ThemSuaSanPham(int ma)
        {
            Ma = ma;
            InitializeComponent();
        }

        public ThemSuaSanPham()
        {
            InitializeComponent();
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            comboBoxLoaiSP.DisplayMember = "Text";
            comboBoxLoaiSP.ValueMember = "Value";

            getLoaiSP();

            if(Ma != -1)
                load_infor();
        }

        private void load_infor()
        {
            con.Open();
            string load = "SELECT * FROM products WHERE id = " + Ma;
            SqlCommand cmd = new SqlCommand(load,con);
            SqlDataReader dr = cmd.ExecuteReader();

            dr.Read();

            tbMa.Text = Ma.ToString();
            tbTen.Text = dr["name"].ToString();

            LookupAndSetValue(comboBoxLoaiSP, dr["cat_id"].ToString());
            tbDonVi.Text = dr["unit"].ToString();

            tbSoLuong.Text = dr["count"].ToString();
            tbDonGia.Text = dr["price"].ToString();
            tbGiaKM.Text = dr["promo_price"].ToString();
            checkBoxStatus.Checked = (int.Parse(dr["status"].ToString())==0)?false:true;

            con.Close();

        }

        private void getLoaiSP()
        {
            con.Open();
            string getLoaiSanPham = "SELECT * FROM product_cats";
            SqlCommand cmd = new SqlCommand(getLoaiSanPham, con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBoxLoaiSP.Items.Add(new { Text = dr["name"].ToString(), Value = dr["cat_id"].ToString() });
            }
            con.Close();
        }

  

        private void bntDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void bntLuuLai_Click_1(object sender, EventArgs e)
        {
            if(Ma == -1 )
            {
                ThemMoiSanPham();
            } else
            {
                SuaSanPham();
            }
        }

        private static void LookupAndSetValue(ComboBox combobox, object value)
        {
            if (combobox.Items.Count > 0)
            {
                for (int i = 0; i < combobox.Items.Count; i++)
                {
                    object item = combobox.Items[i];
                    object thisValue = item.GetType().GetProperty(combobox.ValueMember).GetValue(item);
                    if (thisValue != null && thisValue.Equals(value))
                    {
                        combobox.SelectedIndex = i;
                        return;
                    }
                }
                // Select first item if requested item was not found
                combobox.SelectedIndex = 0;
            }
        }
        
        void SuaSanPham()
        {
            con.Open();
            string update = "UPDATE products SET name=@tenSP,cat_id=@maLoaiSP,count=@soLuong,price=@donGia,promo_price=@giaKM,unit=@maDonVi,status=@tinhTrang, updated_at = CONVERT(datetime,@updated,103) WHERE id=@maSP";
            SqlCommand cmd = new SqlCommand(update, con);

            cmd.Parameters.AddWithValue("maSP", int.Parse(tbMa.Text));
            cmd.Parameters.AddWithValue("tenSP", tbTen.Text);
            cmd.Parameters.AddWithValue("maLoaiSP", comboBoxLoaiSP.SelectedIndex + 1);
            cmd.Parameters.AddWithValue("maDonVi", tbDonVi.Text);
            cmd.Parameters.AddWithValue("soLuong", int.Parse(tbSoLuong.Text));
            cmd.Parameters.AddWithValue("donGia", int.Parse(tbDonGia.Text));
            cmd.Parameters.AddWithValue("giaKM", int.Parse(tbGiaKM.Text));
            cmd.Parameters.AddWithValue("tinhTrang", (checkBoxStatus.Checked ? 1 : 0));
            cmd.Parameters.AddWithValue("updated", DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"));
            cmd.ExecuteNonQuery();
            con.Close();
            this.Close();

        }

        void ThemMoiSanPham()
        {
            con.Open();
            string add = "INSERT INTO products VALUES(@maSP,@tenSP,@maLoaiSP,@soLuong,@donGia,@giaKM,@maDonVi,@tinhTrang,CONVERT(datetime,@created, 103), CONVERT(datetime,@updated,103))";
            SqlCommand cmd = new SqlCommand(add, con);
            cmd.Parameters.AddWithValue("maSP", int.Parse(tbMa.Text));
            cmd.Parameters.AddWithValue("tenSP", tbTen.Text);
            cmd.Parameters.AddWithValue("maLoaiSP", comboBoxLoaiSP.SelectedIndex + 1);
            cmd.Parameters.AddWithValue("maDonVi", tbDonVi.Text);
            cmd.Parameters.AddWithValue("soLuong", int.Parse(tbSoLuong.Text));
            cmd.Parameters.AddWithValue("donGia", int.Parse(tbDonGia.Text));
            cmd.Parameters.AddWithValue("giaKM", int.Parse(tbGiaKM.Text));
            cmd.Parameters.AddWithValue("tinhTrang", (checkBoxStatus.Checked ? 1 : 0));
            cmd.Parameters.AddWithValue("created", DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"));
            cmd.Parameters.AddWithValue("updated", DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"));
            cmd.ExecuteNonQuery();
            con.Close();
            this.Close();
        }
    }
}
