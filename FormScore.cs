﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
            cmd.CommandText = "Select * from DIEMSV ORDER BY MASV";
            adpt.SelectCommand = cmd;
            table.Clear();
            adpt.Fill(table);
            show_score.DataSource = table;
            //table.Select().Where(item => item["MASV"] == txt_id.Text);
            // DataRow[] dr = table.Select().Where(item => item["MASV"] == txt_id.Text).ToArray();
            show_score.Columns["MASV"].HeaderText = "Mã sinh viên";
            show_score.Columns["MAMH"].HeaderText = "Mã môn học";
            show_score.Columns["DIEM"].HeaderText = "Điểm";
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
            SqlCommand cmdCheckIdStu = new SqlCommand(@"SELECT MASV FROM SINHVIEN WHERE MASV = @id", connect);
            cmdCheckIdStu.Parameters.AddWithValue("@id", txt_id.Text);
            SqlDataReader dr = cmdCheckIdStu.ExecuteReader();
            
            if (dr.Read())
            {

                connect.Close();
                connect.Open();
                SqlCommand cmdCheckIdSub = new SqlCommand(@"SELECT MAMH FROM MONHOC WHERE MAMH = @sub_id", connect);
                cmdCheckIdSub.Parameters.AddWithValue("@sub_id", txt_sub_id.Text);
                SqlDataReader dr1 = cmdCheckIdStu.ExecuteReader();
                if (dr1.Read())
                {

                    MessageBox.Show("Mã môn học không tồn tại");
                }
                else
                {
                    try
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
                    catch (Exception ex)
                    {
                        MessageBox.Show("Điểm phải nhỏ hơn 10 và lớn hơn hoặc bằng 0" + ex);
                    }
                }
                

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

            txt_id.ResetText();
            txt_sub_id.ResetText();
            txt_score.ResetText();
        }
        private void btn_del_Click(object sender, EventArgs e)
        {
            connect.Open();
            if (string.IsNullOrEmpty(txt_id.Text) == true || string.IsNullOrEmpty(txt_sub_id.Text) == true || string.IsNullOrEmpty(txt_score.Text) == true)
            {
                MessageBox.Show("Phải chọn sinh viên cần xóa");
                connect.Close();
            }
            else
            {
                SqlCommand com = new SqlCommand(@"DELETE FROM DIEMSV WHERE MASV = @id AND MAMH=@sub_id ", connect);
                com.Parameters.AddWithValue("@id", txt_id.Text);
                com.Parameters.AddWithValue("@sub_id", txt_sub_id.Text);
                com.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
                connect.Close();
            }

            loadData();
            txt_id.ResetText();
            txt_sub_id.ResetText();
            txt_score.ResetText();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            connect.Open();
            txt_id.ReadOnly = true;
            txt_sub_id.ReadOnly = true;
            if (string.IsNullOrEmpty(txt_id.Text) == true || string.IsNullOrEmpty(txt_sub_id.Text) == true || string.IsNullOrEmpty(txt_score.Text) == true)
            {
                MessageBox.Show("Phải chọn sinh viên cần cập nhật");
                connect.Close();
            }
            else
            {
                SqlCommand com = new SqlCommand(@"UPDATE  DIEMSV SET DIEM=@score WHERE MASV =@id AND MAMH=@sub_id", connect);
                com.Parameters.AddWithValue("@id", txt_id.Text);
                com.Parameters.AddWithValue("@sub_id", txt_sub_id.Text);
                com.Parameters.AddWithValue("@score", double.Parse(txt_score.Text));
                com.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công");
                connect.Close();
            }

            loadData();
            txt_id.ResetText();
            txt_sub_id.ResetText();
            txt_score.ResetText();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {

            txt_id.ResetText();
            txt_sub_id.ResetText();
            txt_score.ResetText();

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
                SqlCommand com = new SqlCommand(@"SELECT * FROM DIEMSV WHERE MASV LIKE '%' + @key + '%' OR MAMH LIKE '%' + @key + '%' OR DIEM LIKE '%' + @key + '%' ", connect);
                com.Parameters.AddWithValue("@key", "%" + txt_search.Text + "%");
                SqlDataReader dr = com.ExecuteReader();
                table.Clear();
                table.Load(dr);
                show_score.DataSource = table;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
