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
    public partial class FormClass : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=.;Initial Catalog=QLSV;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
            cmd = connect.CreateCommand();
            cmd.CommandText = "Select * from LOP";
            adpt.SelectCommand = cmd;
            table.Clear();
            adpt.Fill(table);
            show_class.DataSource = table;

        }
        public FormClass()
        {
            InitializeComponent();
        }
        private void FormClass_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void show_class_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.ReadOnly = true;
            int i;
            i = show_class.CurrentRow.Index;
            txt_id.Text = show_class.Rows[i].Cells[0].Value.ToString();
            txt_name.Text = show_class.Rows[i].Cells[1].Value.ToString();
            txt_nk.Text = show_class.Rows[i].Cells[2].Value.ToString();

        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand com = new SqlCommand(@"INSERT INTO LOP VALUES (@class_id,@class_name,@nk)", connect);
            SqlCommand cmdCheck = new SqlCommand(@"SELECT Count(*) FROM LOP WHERE MALP = @class_id", connect);
            cmdCheck.Parameters.AddWithValue("@class_id", txt_id.Text);
            int result = (int)cmdCheck.ExecuteScalar();
            if (result > 0)
            {
                MessageBox.Show("Mã lớp đã tồn tại");
                connect.Close();

            }
            else
            {
                if (string.IsNullOrEmpty(txt_id.Text) == true || string.IsNullOrEmpty(txt_name.Text) == true || string.IsNullOrEmpty(txt_nk.Text) == true)
                {
                    MessageBox.Show("Phải điền đầy đủ thông tin");
                    connect.Close();
                }
                else
                {
                    com.Parameters.AddWithValue("@class_id", txt_id.Text);
                    com.Parameters.AddWithValue("@class_name", txt_name.Text);
                    com.Parameters.AddWithValue("@nk", txt_nk.Text);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công");
                    connect.Close();
                }

            }
            loadData();

            txt_id.ResetText();
            txt_name.ResetText();
            txt_nk.ResetText();
        }




        private void btn_del_Click(object sender, EventArgs e)
        {
            connect.Open();
            if (string.IsNullOrEmpty(txt_id.Text) == true || string.IsNullOrEmpty(txt_name.Text) == true || string.IsNullOrEmpty(txt_nk.Text) == true)
            {
                MessageBox.Show("Phải chọn lớp cần xóa");
                connect.Close();
            }
            else
            {
                SqlCommand com = new SqlCommand(@"DELETE FROM LOP WHERE MALP=@id ", connect);
                com.Parameters.AddWithValue("@id", txt_id.Text);
                com.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
                connect.Close();
            }

            loadData();
            txt_id.ReadOnly = false;
            txt_id.ResetText();
            txt_name.ResetText();
            txt_nk.ResetText();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand cmdCheck = new SqlCommand(@"SELECT Count(*) FROM LOP WHERE MALP NOT LIKE '%' + @id + '%' AND TENLP =@name", connect);
            cmdCheck.Parameters.AddWithValue("@id", txt_id.Text);
            cmdCheck.Parameters.AddWithValue("@name", txt_name.Text);
            int result = (int)cmdCheck.ExecuteScalar();
            if (result > 0)
            {
                MessageBox.Show("Tên lớp đã tồn tại");
                connect.Close();
            }
            else
            {
                if (string.IsNullOrEmpty(txt_id.Text) == true || string.IsNullOrEmpty(txt_name.Text) == true || string.IsNullOrEmpty(txt_nk.Text) == true)
                {
                    MessageBox.Show("Phải chọn lớp cần cập nhật");
                    connect.Close();
                }
                else
                {
                    SqlCommand com = new SqlCommand(@"UPDATE LOP SET TENLP = @name, NK= @nk WHERE MALP =@id AND TENLP =@name ", connect);
                    com.Parameters.AddWithValue("@id", txt_id.Text);
                    com.Parameters.AddWithValue("@name", txt_name.Text);
                    com.Parameters.AddWithValue("@nk", txt_nk.Text);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thành công");
                    connect.Close();

                }
            }
            

            loadData();
            txt_id.ReadOnly = false;
            txt_id.ResetText();
            txt_name.ResetText();
            txt_nk.ResetText();

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_id.ReadOnly = false;
            txt_id.ResetText();
            txt_name.ResetText();
            txt_nk.ResetText();
        }
    }
}
