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
            //table.Select().Where(item => item["MASV"] == txt_id.Text);
           // DataRow[] dr = table.Select().Where(item => item["MASV"] == txt_id.Text).ToArray();

        }
        public FormStu()
        {
            InitializeComponent();

        }



        private void btn_add_Click(object sender, EventArgs e)
        {

            connect.Open();
            SqlCommand com = new SqlCommand(@"INSERT INTO SINHVIEN (MASV,MALP,TENSV,DCSV) VALUES (@id,@class_id,@name,@address)", connect);
            SqlCommand cmdCheck = new SqlCommand(@"SELECT Count(*) FROM SINHVIEN WHERE MASV = @id", connect);
            cmdCheck.Parameters.AddWithValue("@id", txt_id.Text);
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

        private void btn_del_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand com = new SqlCommand(@"DELETE FROM SINHVIEN WHERE MASV = @id ", connect);
            com.Parameters.AddWithValue("@id", txt_id.Text);        
            com.ExecuteNonQuery();
            MessageBox.Show("Xóa thành công");
            loadData();
            txt_id.Text = "";
            txt_class_id.Text = "";
            txt_name.Text = "";
            txt_address.Text = "";
            connect.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            connect.Open(); 
            SqlCommand com = new SqlCommand(@"UPDATE SINHVIEN SET MALP = @class_id, TENSV = @name, DCSV= @address WHERE MASV =@id ", connect);
            com.Parameters.AddWithValue("@id", txt_id.Text);
            com.Parameters.AddWithValue("@class_id", txt_class_id.Text);
            com.Parameters.AddWithValue("@name", txt_name.Text);
            com.Parameters.AddWithValue("@address", txt_address.Text);

            com.ExecuteNonQuery();
            MessageBox.Show("Cập nhật thành công");
            loadData();

            connect.Close();
        }
       
        private void btn_search_Click(object sender, EventArgs e)
        {

            connect.Open(); //OR MALP LIKE '%@class_id%' OR TENSV LIKE '%@name%' OR DCSV LIKE '%@address%'//
            SqlCommand com = new SqlCommand(@"SELECT * FROM SINHVIEN WHERE MASV LIKE '%' + @key + '%' OR TENSV LIKE '%' + @key + '%' OR DCSV LIKE '%' + @key + '%' ", connect);
            com.Parameters.AddWithValue("@key", "%" + txt_search.Text + "%");
            /*com.Parameters.AddWithValue("@id", txt_search.Text);
            //com.Parameters.AddWithValue("@id", txt_search.Text);
            com.Parameters.AddWithValue("@class_id", txt_search.Text);
            com.Parameters.AddWithValue("@name", txt_search.Text);
            com.Parameters.AddWithValue("@address", txt_search.Text);*/

            com.ExecuteNonQuery();

           /* adpt.SelectCommand = cmd;
            table.Clear();
            adpt.Fill(table);
            show_stu.DataSource = table;*/

            SqlDataReader dr = com.ExecuteReader();
            table.Clear();
            table.Load(dr);           
            show_stu.DataSource = table;

            connect.Close();

        }





    }
}





