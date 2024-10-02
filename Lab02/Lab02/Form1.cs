using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Lab02
{
    public partial class FQLSV : Form
    {
        public FQLSV()
        {
          
            InitializeComponent();
        }
        string connectionString = "Data Source=LOCALHOST\\SQLEXPRESS01;Initial Catalog=QLThucTap;Integrated Security=True";

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            panel1.Enabled = false;
            buttonXoa.Enabled = false;
            buttonLuu.Enabled = false;
            buttonSua.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Xx_Load(object sender, EventArgs e)
        {

            dataGridView1.CellClick += dataGridView1_CellClick;
            panel1.Enabled = false;
            buttonXoa.Enabled = false;
            buttonLuu.Enabled = false;
            buttonSua.Enabled = false;
            HienThiDanhSachSinhVien();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
            comboBox1.SelectedIndex = -1;
            buttonLuu.Enabled = true;
        }
        
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void HienThiDanhSachSinhVien()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT Mssv, HoTen, QueQuan, NgaySinh, Hocluc FROM SinhVien";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];


                textBox1.Text = row.Cells["Mssv"].Value.ToString();
                textBox4.Text = row.Cells["HoTen"].Value.ToString();
                comboBox1.Text = row.Cells["QueQuan"].Value.ToString();
                dateTimePicker1.Value = DateTime.Parse(row.Cells["NgaySinh"].Value.ToString());
                textBox3.Text = row.Cells["HocLuc"].Value.ToString();
                buttonSua.Enabled = true;
                buttonXoa.Enabled = true;
            }
            else
            {
                MessageBox.Show("No");
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
           
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            
            if (result == DialogResult.Yes)
            {
                
                XoaSinhVien();

            
                //LoadData();
            }
        }
        private void XoaSinhVien()
        {

            string maSoSinhVien = textBox1.Text;

            if (!string.IsNullOrEmpty(maSoSinhVien))
            {
              
               

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        
                        conn.Open();

                        // Tạo câu lệnh SQL xóa sinh viên theo mã số sinh viên
                        string query = "DELETE FROM SinhVien WHERE Mssv = @Mssv";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            // Thêm tham số cho câu truy vấn
                            cmd.Parameters.AddWithValue("@Mssv", maSoSinhVien);

                            // Hiển thị hộp thoại xác nhận trước khi xóa
                            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result == DialogResult.Yes)
                            {
                                // Thực thi lệnh xóa
                                int rowsAffected = cmd.ExecuteNonQuery();

                                // Nếu có dòng bị xóa, cập nhật lại GridView
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Đã xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // Gọi hàm để load lại dữ liệu sau khi xóa
                                    LoadSinhVienData();
                                }
                                else
                                {
                                    MessageBox.Show("Không tìm thấy sinh viên để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã số sinh viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
private void LoadSinhVienData()
        {
            try
            {
                string query = "SELECT Mssv, HoTen, QueQuan, NgaySinh, Hocluc FROM SinhVien";
                SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
