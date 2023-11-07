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
    public partial class FormLogin : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=.;Initial Catalog=QLSV;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt = new SqlDataAdapter();
        DataTable table = new DataTable();

        
        public FormLogin()
        {
            InitializeComponent();
        }
      
        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand cmdCheck = new SqlCommand(@"SELECT * FROM TAIKHOAN WHERE TENDN = @account AND MATKHAU = @password ", connect);
            cmdCheck.Parameters.AddWithValue("@account", txt_acc.Text);
            cmdCheck.Parameters.AddWithValue("@password", txt_pass.Text);
            SqlDataReader dr = cmdCheck.ExecuteReader();
            // int result = (int)cmdCheck.ExecuteScalar();
            if (string.IsNullOrEmpty(txt_acc.Text) == true || string.IsNullOrEmpty(txt_pass.Text) == true)
            {
                MessageBox.Show("Phải điền đầy đủ thông tin");
                connect.Close();
            }
            else
            {
                if(dr.Read() != true)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
                    
                    connect.Close();
                }
                else
                {
                    FormMain formMain = new FormMain();
                    
                    formMain.ShowDialog();
                    txt_acc.ResetText();
                    txt_pass.ResetText();
                }
               
            }
            
            connect.Close();
            
            
        }

        
    }
}
