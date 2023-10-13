using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        Form currentChildForm = null;
        private void OpenForm(Form ChildForm)
        {
            // Đóng form con hiện tại (nếu có)
            if (currentChildForm != null)
            {
                currentChildForm.Dispose();
                currentChildForm = null;
                panel_main.Controls.Clear();
            }

            currentChildForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(ChildForm);
            ChildForm.Show();

        }
        private void btn_manage_stu_Click(object sender, EventArgs e)
        {
            FormStu formStu = new FormStu();
            OpenForm(formStu);
        }

        private void btn_manage_class_Click(object sender, EventArgs e)
        {
            FormClass formClass = new FormClass();
            OpenForm(formClass); 
        }

        private void btn_manage_score_Click(object sender, EventArgs e)
        {
            FormScore formScore = new FormScore();
            OpenForm(formScore); 
           
        }

        private void btn_subject_Click(object sender, EventArgs e)
        {
            FormSubject formSubject = new FormSubject();

            OpenForm(formSubject); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
