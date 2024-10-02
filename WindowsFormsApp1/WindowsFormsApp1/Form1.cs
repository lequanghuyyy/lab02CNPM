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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Mssv.ReadOnly = true;
            Hocluc.ReadOnly = true;

            Hoten.ReadOnly = true;

            Ngaysinh.Enabled = false;
            Quequan.Enabled = false;
            buttonDelete.Enabled = false;
            buttonSave.Enabled = false;
            buttonUpdate.Enabled = false;
        }
        SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-TNST8J7;Initial Catalog=QLSV;Integrated Security=True");
        private void ketnoicsdl()
        {
            cnn.Open();
            string sql = "select * from sinhvien";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            buttonSave.Enabled = true;
            Mssv.ReadOnly = false;
            Mssv.Text = "";
            Hocluc.ReadOnly = false;
            Hocluc.Text = "";
            Hoten.ReadOnly = false;
            Hoten.Text = "";
            Ngaysinh.Enabled = true;
            Quequan.Enabled = true;
            Quequan.Text = "";
            Mssv.Focus();
        }



        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Ngaysinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mssv.ReadOnly = true;
            Hocluc.ReadOnly = true;

            Hoten.ReadOnly = true;

            Ngaysinh.Enabled = false;
            Quequan.Enabled = false;
            buttonDelete.Enabled = false;
            buttonSave.Enabled = true;
            buttonUpdate.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridView1.Rows[e.RowIndex];
                Mssv.Text = row.Cells[0].Value.ToString();
                Hoten.Text = row.Cells[1].Value.ToString();
                Quequan.Text = row.Cells[2].Value.ToString();
                Ngaysinh.Text = row.Cells[3].Value.ToString();
                Hocluc.Text = row.Cells[4].Value.ToString();
               buttonUpdate.Enabled = true;
                buttonDelete.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Chua co du lieu");
            }
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

    
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridView1.Rows[e.RowIndex];
                Mssv.Text = row.Cells[0].Value.ToString();
                Hoten.Text = row.Cells[1].Value.ToString();
                Quequan.Text = row.Cells[2].Value.ToString();
                Ngaysinh.Text = row.Cells[3].Value.ToString();
                Hocluc.Text = row.Cells[4].Value.ToString();
                buttonUpdate.Enabled = true;
                buttonDelete.Enabled = true;
           
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Form form2 = new Form();
            form2.TopLevel = false;
            form2.Show();
        }
    }
}
