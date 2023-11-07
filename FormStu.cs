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
    public partial class FormStu : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=.;Initial Catalog=QLSV;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
            cmd = connect.CreateCommand();
            cmd.CommandText = "Select * from SINHVIEN";
            adpt.SelectCommand = cmd;
            table.Clear();
            adpt.Fill(table);
            show_stu.DataSource = table;

            //định dạng cột
            show_stu.Columns["MASV"].HeaderText = "Mã sinh viên";
            show_stu.Columns["MALP"].HeaderText = "Mã lớp ";
            show_stu.Columns["TENSV"].HeaderText = "Tên sinh viên";
            show_stu.Columns["DCSV"].HeaderText = "Địa chỉ sinh viên";

            //table.Select().Where(item => item["MASV"] == txt_id.Text);
            // DataRow[] dr = table.Select().Where(item => item["MASV"] == txt_id.Text).ToArray();

        }
        public FormStu()
        {
            InitializeComponent();

        }
        private void FormStu_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void show_stu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.ReadOnly = true;
            int i;
            i = show_stu.CurrentRow.Index;
            txt_id.Text = show_stu.Rows[i].Cells[0].Value.ToString();
            txt_class_id.Text = show_stu.Rows[i].Cells[1].Value.ToString();
            txt_name.Text = show_stu.Rows[i].Cells[2].Value.ToString();
            txt_address.Text = show_stu.Rows[i].Cells[3].Value.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            connect.Open();
            SqlCommand cmdCheck = new SqlCommand(@"SELECT Count(*) FROM SINHVIEN WHERE MASV = @id", connect);
            cmdCheck.Parameters.AddWithValue("@id", txt_id.Text);
            //SqlDataReader dr = cmdCheck.ExecuteReader();
            int result = (int)cmdCheck.ExecuteScalar();

            if (result > 0)
            {
                MessageBox.Show("Mã sinh viên đã tồn tại");
                connect.Close();

            }
            else
            {
                if (string.IsNullOrEmpty(txt_id.Text) == true || string.IsNullOrEmpty(txt_class_id.Text) == true || string.IsNullOrEmpty(txt_name.Text) == true || string.IsNullOrEmpty(txt_address.Text) == true)
                {
                    MessageBox.Show("Phải điền đầy đủ thông tin");
                }
                else
                {
                    SqlCommand com = new SqlCommand(@"INSERT INTO SINHVIEN (MASV,MALP,TENSV,DCSV) VALUES (@id,@class_id,@name,@address)", connect);
                    com.Parameters.AddWithValue("@id", txt_id.Text);
                    com.Parameters.AddWithValue("@class_id", txt_class_id.Text);
                    com.Parameters.AddWithValue("@name", txt_name.Text);
                    com.Parameters.AddWithValue("@address", txt_address.Text);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công");

                }

                connect.Close();
            }
            loadData();
            //xóa các textbox
            txt_id.ReadOnly = false;
            txt_id.ResetText();
            txt_class_id.ResetText();
            txt_name.ResetText();
            txt_address.ResetText();

        }



        private void btn_del_Click(object sender, EventArgs e)
        {
            connect.Open();
            if (string.IsNullOrEmpty(txt_id.Text) == true || string.IsNullOrEmpty(txt_class_id.Text) == true || string.IsNullOrEmpty(txt_name.Text) == true || string.IsNullOrEmpty(txt_address.Text) == true)
            {
                MessageBox.Show("Phải chọn sinh viên cần xóa");
            }
            else
            {
                SqlCommand com = new SqlCommand(@"DELETE FROM SINHVIEN WHERE MASV = @id ", connect);
                com.Parameters.AddWithValue("@id", txt_id.Text);
                com.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
                connect.Close();
            }

            loadData();
            //xóa các textbox
            txt_id.ReadOnly = false;
            txt_id.ResetText();
            txt_class_id.ResetText();
            txt_name.ResetText();
            txt_address.ResetText();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            connect.Open();
            if (string.IsNullOrEmpty(txt_id.Text) == true || string.IsNullOrEmpty(txt_class_id.Text) == true || string.IsNullOrEmpty(txt_name.Text) == true || string.IsNullOrEmpty(txt_address.Text) == true)
            {
                MessageBox.Show("Phải chọn sinh viên cần cập nhật");
                connect.Close();
            }
            else
            {
                SqlCommand com = new SqlCommand(@"UPDATE SINHVIEN SET MALP = @class_id, TENSV = @name, DCSV= @address WHERE MASV =@id ", connect);
                com.Parameters.AddWithValue("@id", txt_id.Text);
                com.Parameters.AddWithValue("@class_id", txt_class_id.Text);
                com.Parameters.AddWithValue("@name", txt_name.Text);
                com.Parameters.AddWithValue("@address", txt_address.Text);
                com.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công");
                connect.Close();
            }

            loadData();

            //xóa các textbox
            txt_id.ReadOnly = false;
            txt_id.ResetText();
            txt_class_id.ResetText();
            txt_name.ResetText();
            txt_address.ResetText();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_search.Text) == true)
            {
                MessageBox.Show("Nhập vào thông tin cần tìm kiếm");
            }
            else
            {

                connect.Open();
                SqlCommand com = new SqlCommand(@"SELECT * FROM SINHVIEN WHERE MASV LIKE '%' + @key + '%' OR TENSV LIKE '%' + @key + '%' OR DCSV LIKE '%' + @key + '%' ", connect);
                com.Parameters.AddWithValue("@key", "%" + txt_search.Text + "%");
                SqlDataReader dr = com.ExecuteReader();
                table.Clear();
                table.Load(dr);
                show_stu.DataSource = table;
                connect.Close();

            }
            

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_id.ReadOnly = false;
            txt_id.ResetText();
            txt_class_id.ResetText();
            txt_name.ResetText();
            txt_address.ResetText();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_search.Text) == true)
            {
                loadData();
            }
        }
    }
}





