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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            string sqlConn = "Data Source = QUANG\\SQLEXPRESS; Initial Catalog = QL_Garage_1; Integrated Security = True";
            SqlConnection conn = new SqlConnection(sqlConn);
            try
            {
                conn.Open();
                string sql = "SELECT * FROM ThongTinXe";
                var adapter = new SqlDataAdapter(sql, conn);
                var table = new DataTable();
                adapter.Fill(table);
                dataGView_0993.DataSource = table;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Lỗi kết nối");
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sqlConn = "Data Source = QUANG\\SQLEXPRESS; Initial Catalog = QL_Garage_1; Integrated Security = True";
            SqlConnection conn = new SqlConnection(sqlConn);
            try
            {
                conn.Open();
                //int maxe = int.Parse(txtMaxe_0993.Text);
                string bienSX = txtBSoXe_0993.Text;
                
                string hangxe = txtHangXe_0993.Text;
                string mauXe = txtMauXe_0993.Text;
                
                string mausac = txtMauSac_0993.Text;
                
                string tenchuxe = txtTenChuXe_0993.Text;
               

                string sql = "INSERT INTO ThongTinXe(BienSoXe, HangXe, MauXe, MauSac, TenKH)" +
                             "VALUES (@bienSX, @hangxe, @mauXe, @mausac, @tenchuxe)";
                
                SqlCommand cmd = new SqlCommand(sql,conn);

                cmd.Parameters.AddWithValue("@bienSX", bienSX);
                
                cmd.Parameters.AddWithValue("@hangxe", hangxe);
                cmd.Parameters.AddWithValue("@mauXe", mauXe);
                
                cmd.Parameters.AddWithValue("@mausac", mausac);
                
                
                cmd.Parameters.AddWithValue("@tenchuxe", tenchuxe);
                

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công");
                btnHienThi_Click(sender, e);
                Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Lỗi kết nối");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sqlConn = "Data Source = QUANG\\SQLEXPRESS; Initial Catalog = QL_Garage_1; Integrated Security = True";
            SqlConnection conn = new SqlConnection(sqlConn);
            try
            {
                conn.Open();
                int maxe = int.Parse(txtMaxe_0993.Text);
                
                string checkQuery = "SELECT COUNT(*) FROM ThongTinXe WHERE MaXe = @maxe";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@MaXe", maxe);
                
                int count = (int)checkCmd.ExecuteScalar();

                if (count == 0)
                {
                    MessageBox.Show("Không có thông tin xe này");
                    return;
                }

                DialogResult result = MessageBox.Show("Bạn có muốn xoá xe này không?" , "Xoá xe", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string sqlChiTiet = "DELETE FROM ThongTinBaoDuong WHERE MaXe = '" + maxe + "'";
                    SqlCommand cmdCt = new SqlCommand(sqlChiTiet, conn);
                    cmdCt.ExecuteNonQuery();

                    string sql = "DELETE FROM ThongTinXe WHERE MaXe = '" + maxe + "' ";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    if (cmd.CommandType > 0 && cmdCt.CommandType > 0)
                    {
                        MessageBox.Show("Xoá thành công!");
                        btnHienThi_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Xoá không thành công!");
                    }
                }
                
                
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Lỗi kết nối");
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            string sqlConn = "Data Source = QUANG\\SQLEXPRESS; Initial Catalog = QL_Garage_1; Integrated Security = True";
            SqlConnection conn = new SqlConnection(sqlConn);
            try
            {
                conn.Open();
                int maXe = int.Parse(txtMaxe_0993.Text);
                string bienSX = txtBSoXe_0993.Text;
                
                string hangxe = txtHangXe_0993.Text;
                string mauXe = txtMauXe_0993.Text;
                
                string mausac = txtMauSac_0993.Text;
                
                string tenchuxe = txtTenChuXe_0993.Text;
               
                if (maXe.Equals("")){
                    MessageBox.Show("Bạn chưa nhập mã xe");
                }
                else
                {
                    string sql = "UPDATE ThongTinXe SET BienSoXe = @bienSX, HangXe = @hangxe, MauXe = @mauXe, MauSac = @mausac, " +
                        "TenKH = @tenchuxe WHERE MaXe = @maXe";
                       
                        
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@maXe", maXe);
                    cmd.Parameters.AddWithValue("@bienSX", txtBSoXe_0993.Text);
                    
                    cmd.Parameters.AddWithValue("@hangxe", txtHangXe_0993.Text);
                    cmd.Parameters.AddWithValue("@mauXe", mauXe);
                    
                    cmd.Parameters.AddWithValue("@mausac", txtMauSac_0993.Text);
                    
                    
                    cmd.Parameters.AddWithValue("@tenchuxe", txtTenChuXe_0993.Text);
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thành công");
                    btnHienThi_Click(sender, e);
                    Clear();
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Lỗi Kết nối " + ex.Message);
            }
        }
        private void Clear()
        {
            txtBSoXe_0993.Text = "";
            txtHangXe_0993.Text = "";
            txtMauSac_0993.Text = "";
            txtMauXe_0993.Text = "";
            txtTenChuXe_0993.Text = "";

        }
        
    }
}
