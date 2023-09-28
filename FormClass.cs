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
            dataGridView1.DataSource = table;

        }
        public FormClass()
        {
            InitializeComponent();
        }
        private void FormClass_Load(object sender, EventArgs e)
        {
            loadData();
        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

 
        private void label1_Click(object sender, EventArgs e)
        {

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
                com.Parameters.AddWithValue("@class_id", txt_id.Text);               
                com.Parameters.AddWithValue("@class_name", txt_name.Text);
                com.Parameters.AddWithValue("@nk", txt_nk.Text);
                com.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công");
                connect.Close();
            }
            loadData();
        }
    }
}
