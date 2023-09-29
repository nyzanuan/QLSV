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

        private void btn_add_Click(object sender, EventArgs e)
        {
            connect.Open();           
            SqlCommand cmdCheck = new SqlCommand(@"SELECT MASV FROM SINHVIEN WHERE MASV = @id", connect);
            cmdCheck.Parameters.AddWithValue("@id", txt_id.Text);
            SqlDataReader dr = cmdCheck.ExecuteReader();      
            if (dr.Read())
            {
                SqlCommand com = new SqlCommand(@"INSERT INTO DIEMSV (MASV,MAMH,DIEM) VALUES (@id,@sub_id,@score)", connect);
                com.Parameters.AddWithValue("@id", txt_id.Text);
                com.Parameters.AddWithValue("@sub_id", txt_id.Text);
                com.Parameters.AddWithValue("@score", txt_id.Text);
                com.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công");
                connect.Close();
            }
            else               
            { 
                MessageBox.Show("Mã sinh viên không tồn tại");
                connect.Close();
            }
            
            loadData();
        }
    }
}
