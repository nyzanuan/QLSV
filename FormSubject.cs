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
namespace QLSV
{
    public partial class FormSubject : Form
    {
        public FormSubject()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection(@"Data Source=.;Initial Catalog=QLSV;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loadData()
        {
            cmd = connect.CreateCommand();
            cmd.CommandText = "Select * from MONHOC";
            adpt.SelectCommand = cmd;
            table.Clear();
            adpt.Fill(table);
            show_sub.DataSource = table;
            //table.Select().Where(item => item["MASV"] == txt_id.Text);
            // DataRow[] dr = table.Select().Where(item => item["MASV"] == txt_id.Text).ToArray();
            show_sub.Columns["MAMH"].HeaderText = "Mã môn học";
            show_sub.Columns["TENMH"].HeaderText = "Tên môn học";
            show_sub.Columns["SOTC"].HeaderText = "Số tín chỉ";
        }
        private void FormSubject_Load(object sender, EventArgs e)
        {
            loadData();
        }


        
        private void show_sub_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.ReadOnly = true;
            int i;
            i = show_sub.CurrentRow.Index;
            txt_id.Text = show_sub.Rows[i].Cells[0].Value.ToString();
            txt_name.Text = show_sub.Rows[i].Cells[1].Value.ToString();
            txt_tc.Text = show_sub.Rows[i].Cells[2].Value.ToString();
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand cmdCheck = new SqlCommand(@"SELECT Count(*) FROM MONHOC WHERE MAMH = @id", connect);
            cmdCheck.Parameters.AddWithValue("@id", txt_id.Text);
            //SqlDataReader dr = cmdCheck.ExecuteReader();
            int result = (int)cmdCheck.ExecuteScalar();
            // if (dr.Read())
            if (result > 0)             
            {
                MessageBox.Show("Mã môn học đã tồn tại");
                connect.Close();

            }
            else
            {
                if (string.IsNullOrEmpty(txt_id.Text) == true || string.IsNullOrEmpty(txt_name.Text) == true || string.IsNullOrEmpty(txt_tc.Text) == true)
                {
                    MessageBox.Show("Phải điền đầy đủ thông tin");
                    connect.Close();
                }
                else
                { 
                    SqlCommand com = new SqlCommand(@"INSERT INTO MONHOC (MAMH,TENMH,SOTC) VALUES (@id,@name,@tc)", connect);
                    com.Parameters.AddWithValue("@id", txt_id.Text);               
                    com.Parameters.AddWithValue("@name", txt_name.Text);
                    com.Parameters.AddWithValue("@tc", txt_tc.Text);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công");
                    connect.Close();
                }
            }
            loadData();
            //xóa các textbox
            txt_id.ResetText();
            txt_name.ResetText();
            txt_tc.ResetText();
           
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            connect.Open();
            if (string.IsNullOrEmpty(txt_id.Text) == true || string.IsNullOrEmpty(txt_name.Text) == true || string.IsNullOrEmpty(txt_tc.Text) == true)
            {
                MessageBox.Show("Phải chọn môn học cần xóa");
                connect.Close();
            }
            else
            {
                SqlCommand com = new SqlCommand(@"DELETE FROM MONHOC WHERE MAMH=@id ", connect);
                com.Parameters.AddWithValue("@id", txt_id.Text);
                com.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
                connect.Close();
            }
                
            loadData();
            //xóa các textbox
            txt_id.ResetText();
            txt_name.ResetText();
            txt_tc.ResetText();
            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            connect.Open();
            txt_id.ReadOnly = true;                      
            SqlCommand cmdCheck = new SqlCommand(@"SELECT Count(*) FROM MONHOC WHERE MAMH NOT LIKE '%' + @id + '%' AND TENMH = @name", connect);
            cmdCheck.Parameters.AddWithValue("@id", txt_id.Text);
            cmdCheck.Parameters.AddWithValue("@name", txt_name.Text);
            int result = (int)cmdCheck.ExecuteScalar();
            if (result > 0)           
            {
                MessageBox.Show("Tên môn học đã tồn tại");
                connect.Close();
            }
            else
            {
                SqlCommand com = new SqlCommand(@"UPDATE  MONHOC SET TENMH=@name, SOTC=@tc WHERE MAMH =@id ", connect);
                com.Parameters.AddWithValue("@id", txt_id.Text);
                com.Parameters.AddWithValue("@name", txt_name.Text);
                com.Parameters.AddWithValue("@tc", txt_tc.Text);
                com.ExecuteNonQuery();
            }
            
            MessageBox.Show("Cập nhật thành công");
            connect.Close();
            loadData();
            //xóa các textbox
            txt_id.ResetText();
            txt_name.ResetText();
            txt_tc.ResetText();
        }
        

        private void btn_reset_Click(object sender, EventArgs e)
        {
            //xóa các textbox
            txt_id.ResetText();
            txt_name.ResetText();
            txt_tc.ResetText();
        }
        private void tbn_search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_search.Text) == true)
            {
                MessageBox.Show("Nhập vào thông tin cần tìm kiếm");
            }
            else
            {

                connect.Open();
                SqlCommand com = new SqlCommand(@"SELECT * FROM MONHOC WHERE MAMH LIKE '%' + @key + '%' OR TENMH LIKE '%' + @key + '%' OR SOTC LIKE '%' + @key + '%' ", connect);
                com.Parameters.AddWithValue("@key", "%" + txt_search.Text + "%");
                SqlDataReader dr = com.ExecuteReader();
                table.Clear();
                table.Load(dr);
                show_sub.DataSource = table;
                connect.Close();

            }
        }
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_search.Text) == true)
            {
                loadData();
            }
        }






        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
