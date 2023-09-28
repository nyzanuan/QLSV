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
            FormMain formMain = new FormMain();
            formMain.ShowDialog();
        }
    }
}
