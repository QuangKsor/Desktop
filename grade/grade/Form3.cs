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

namespace grade
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void cmbox_0993_SelectedIndexChanged()
        {
            string sqlConn = "Data Source = QUANG\\SQLEXPRESS; Initial Catalog = QL_Garage_1; Integrated Security = True";
            SqlConnection conn = new SqlConnection(sqlConn);
            try
            {
                conn.Open();
                
                string sql = "SELECT BienSoXe " +
                    "FROM ThongTinBaoDuong d " +
                    "JOIN ThongTinXe x ON d.MaXe = x.MaXe " +
                    "JOIN ChiTietBaoDuong b ON b.MaBaoDuong = d.MaBaoDuong";
                var adapter = new SqlDataAdapter(sql, conn);
                var table = new DataTable();
                adapter.Fill(table);

                
                cmbox_BienSo0993.DataSource = table;
                cmbox_BienSo0993.DisplayMember = "BienSoXe";
                cmbox_BienSo0993.ValueMember = "BienSoXe";
                string bienSo = cmbox_BienSo0993.SelectedValue.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối " + ex.Message);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cmbox_0993_SelectedIndexChanged();
            cmbBaoDuong_0993_SelectedIndexChanged();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string sqlConn = "Data Source = QUANG\\SQLEXPRESS; Initial Catalog = QL_Garage_1; Integrated Security = True";
            SqlConnection conn = new SqlConnection(sqlConn);
            try
            {
                conn.Open();
                string sql = "SELECT * FROM ChiTietBaoDuong";
                var adapter = new SqlDataAdapter(sql,conn);
                var table = new DataTable();
                adapter.Fill(table);
                dataGView_0993.DataSource = table;
                

            }catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sqlConn = "Data Source = QUANG\\SQLEXPRESS; Initial Catalog = QL_Garage_1; Integrated Security = True";
            SqlConnection conn = new SqlConnection(sqlConn);
            try
            {
                conn.Open();

                string bienSo = cmbox_BienSo0993.Text;
                string maGoi = cmbBaoDuong_0993.Text;
                decimal dongia = decimal.Parse(txtGiaTien_0993.Text);
                int sokm = int.Parse(txtSoKM_0993.Text);
                string ngayBD = DateTime_0993.Value.ToString("dd/MM/yyyy");
                string sql1 = "SELECT BienSoXe FROM ThongTinXe WHERE BienSoXe = @BienSoXe";
                SqlCommand cmd1 = new SqlCommand(sql1,conn);
                cmd1.Parameters.AddWithValue("@BienSoXe", bienSo);
                int maXe = (int)cmd1.ExecuteScalar();


                string sql2 = "INSERT INTO ThongTinBaoDuong(MaXe, LoaiDV, SoKm, NgayBaoDuong)";
                SqlCommand cmd2 = new SqlCommand(sql2, conn);
                cmd2.Parameters.AddWithValue("@MaXe", maXe);
                cmd2.Parameters.AddWithValue("@SoKm", sokm);
                cmd2.Parameters.AddWithValue("@NgayBaoDuong", ngayBD);
                int maBaoDuong = Convert.ToInt32(cmd2.ExecuteScalar());


                SqlCommand cmd3 = new SqlCommand("INSERT INTO ChiTietBaoDuong (MaBaoDuong, PhuTungSuDung, DonGia, SoKm, NgayBaoDuong, MaGoi) VALUES (@MaBaoDuong, @PhuTungSuDung, @DonGia, @SoKm, @NgayBaoDuong, MaGoi)", conn);
                cmd3.Parameters.AddWithValue("@MaBaoDuong", maBaoDuong);
                cmd3.Parameters.AddWithValue("@PhuTung", maGoi); // hoặc cho người dùng nhập
                cmd3.Parameters.AddWithValue("@DonGia", dongia);
                cmd3.Parameters.AddWithValue("@SoKm", sokm);
                cmd3.Parameters.AddWithValue("@NgayBaoDuong", ngayBD);
                cmd3.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối" + ex.Message);
            }
        }

        private void btnOK_0993_Click(object sender, EventArgs e)
        {
            string sqlConn = "Data Source = QUANG\\SQLEXPRESS; Initial Catalog = QL_Garage_1; Integrated Security = True";
            SqlConnection conn = new SqlConnection(sqlConn);
            try
            {
                conn.Open();

                string cbx = cmbox_BienSo0993.Text;
                string sql = "SELECT x.BienSoXe, x.TenKH, x.MauXe, d.SoKm, d.LoaiDV, b.PhuTungSuDung, b.DonGia, d.NgayBaoDuong " +
                        "FROM ThongTinBaoDuong d " +
                        "JOIN ThongTinXe x ON d.MaXe = x.MaXe " +
                        "JOIN ChiTietBaoDuong b ON b.MaBaoDuong = d.MaBaoDuong " +
                        "WHERE BienSoXe = '" + cbx + "'";
                var adapter = new SqlDataAdapter(sql, conn);
                var table = new DataTable();
                adapter.Fill(table);
                dataGView_0993.DataSource = table;
            }catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void cmbBaoDuong_0993_SelectedIndexChanged()
        {
            string sqlConn = "Data Source = QUANG\\SQLEXPRESS; Initial Catalog = QL_Garage_1; Integrated Security = True";
            SqlConnection conn = new SqlConnection(sqlConn);
            try
            {
                conn.Open();
                string sql = "SELECT DISTINCT MaGoi FROM ChiTietBaoDuong";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                cmbBaoDuong_0993.DataSource = table;
                cmbBaoDuong_0993.DisplayMember = "MaGoi";
                cmbBaoDuong_0993.ValueMember = "MaGoi";
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

            
        }
    }
}
