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
    public partial class FormScore : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=.;Initial Catalog=QLSV;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt = new SqlDataAdapter();
        DataTable table = new DataTable();
        public FormScore()
        {
            InitializeComponent();
        }
        void loadData()
        {
            cmd = connect.CreateCommand();
            cmd.CommandText = "Select * from DIEMSV";
            adpt.SelectCommand = cmd;
            table.Clear();
            adpt.Fill(table);
            show_score.DataSource = table;
            //table.Select().Where(item => item["MASV"] == txt_id.Text);
            // DataRow[] dr = table.Select().Where(item => item["MASV"] == txt_id.Text).ToArray();

        }
        private void FormScore_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void show_score_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.ReadOnly = true;
            int i;
            i = show_score.CurrentRow.Index;
            txt_id.Text = show_score.Rows[i].Cells[0].Value.ToString();
            txt_sub_id.Text = show_score.Rows[i].Cells[1].Value.ToString();
            txt_score.Text = show_score.Rows[i].Cells[2].Value.ToString();

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            connect.Open();           
            SqlCommand cmdCheck = new SqlCommand(@"SELECT MASV FROM SINHVIEN WHERE MASV = @id", connect);
            cmdCheck.Parameters.AddWithValue("@id", txt_id.Text);
            SqlDataReader dr = cmdCheck.ExecuteReader();      
            if (dr.Read())
            { 
                connect.Close();
                connect.Open();
                SqlCommand com = new SqlCommand(@"INSERT INTO DIEMSV (MASV,MAMH,DIEM) VALUES (@id,@sub_id,@score)", connect);
                com.Parameters.AddWithValue("@id", txt_id.Text);
                com.Parameters.AddWithValue("@sub_id", txt_sub_id.Text);
                com.Parameters.AddWithValue("@score", double.Parse(txt_score.Text));
                com.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công");


            }
            else               
            {
                if (string.IsNullOrEmpty(txt_id.Text) == true || string.IsNullOrEmpty(txt_sub_id.Text) == true || string.IsNullOrEmpty(txt_score.Text) == true)
                {
                    MessageBox.Show("Phải điền đầy đủ thông tin");
                    connect.Close();
                }
                else
                {
                    MessageBox.Show("Mã sinh viên không tồn tại");
                    connect.Close();
                }
                
            }
            connect.Close();
            loadData();
        }
        private void btn_del_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand com = new SqlCommand(@"DELETE FROM DIEMSV WHERE MASV = @id AND MAMH=@sub_id ", connect);
            com.Parameters.AddWithValue("@id", txt_id.Text);
            com.Parameters.AddWithValue("@sub_id", txt_sub_id.Text);
            com.ExecuteNonQuery();
            MessageBox.Show("Xóa thành công");
            loadData();
            txt_id.Text = "";
            txt_sub_id.Text = "";
            txt_score.Text = "";
            connect.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            connect.Open();
            txt_id.ReadOnly = true;
            txt_sub_id.ReadOnly = true;
            SqlCommand com = new SqlCommand(@"UPDATE  DIEMSV SET DIEM=@score WHERE MASV =@id AND MAMH=@sub_id", connect);
            com.Parameters.AddWithValue("@id", txt_id.Text);
            com.Parameters.AddWithValue("@sub_id", txt_sub_id.Text);
            com.Parameters.AddWithValue("@score", double.Parse(txt_score.Text));
            com.ExecuteNonQuery();
            MessageBox.Show("Cập nhật thành công");
            loadData();

            connect.Close();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_id.ReadOnly = false;
            txt_id.Text = "";
            txt_sub_id.Text = "";
            txt_score.Text = "";
            
        }

       
    }
}
