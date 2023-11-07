using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLSV
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(@"Data Source=.;Initial Catalog=QLSV;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadDSSV()
        {
            cmd = connect.CreateCommand();
            cmd.CommandText = "Select * from SINHVIEN";
            adpt.SelectCommand = cmd;
            table.Clear();
            adpt.Fill(table);
            dataGridView1.DataSource = table;
            //table.Select().Where(item => item["MASV"] == txt_id.Text);
            // DataRow[] dr = table.Select().Where(item => item["MASV"] == txt_id.Text).ToArray();
            dataGridView1.Columns["MASV"].HeaderText = "Mã sinh viên";
            dataGridView1.Columns["MALP"].HeaderText = "Mã lớp ";
            dataGridView1.Columns["TENSV"].HeaderText = "Tên sinh viên";
            dataGridView1.Columns["DCSV"].HeaderText = "Địa chỉ sinh viên";
        }
        void loadDSLOP()
        {
            DataTable table2 = new DataTable();
            cmd = connect.CreateCommand();
            cmd.CommandText = "Select * from LOP";
            adpt.SelectCommand = cmd;
            table.Clear();
            adpt.Fill(table2);
            dataGridView1.DataSource = table2;
            //table.Select().Where(item => item["MASV"] == txt_id.Text);
            // DataRow[] dr = table.Select().Where(item => item["MASV"] == txt_id.Text).ToArray();
            
            dataGridView1.Columns["MALP"].HeaderText = "Mã lớp ";
            dataGridView1.Columns["TENLP"].HeaderText = "Tên lớp";
            dataGridView1.Columns["NK"].HeaderText = "Niên khóa";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) 
            {
                
                loadDSSV();
            }else
            {
                
                loadDSLOP();

            }
            

        }
        void loadComboBox()
        {
            DataTable table1 = new DataTable();
            connect.Open();
            cmd.CommandText ="Select MASV from SINHVIEN";
            adpt.SelectCommand = cmd;
            table1.Clear();
            adpt.Fill(table1);           
            comboBox1.ValueMember = "MASV";
            comboBox1.DataSource = table1;
            connect.Close();
        }
        



        private void btn_print_Click(object sender, EventArgs e)
        {

            exportPDF();
        }
        public void exportPDF()
        {
            
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = "Result.pdf";
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {

                            ErrorMessage = true;
                            MessageBox.Show("Không thể lưu file" + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            
                            BaseFont baseFont = BaseFont.CreateFont(@"C:\Windows\Fonts\times.ttf", BaseFont.IDENTITY_H, true);                         
                            PdfPTable pTable = new PdfPTable(dataGridView1.Columns.Count);
                            pTable.DefaultCell.Padding = 5;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            //Create our usable font
                            var font = new iTextSharp.text.Font(baseFont, 14);

                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                PdfPCell Cell = new PdfPCell(new Phrase(column.HeaderText));
                                pTable.AddCell(Cell);
                            }
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pTable.AddCell(new Phrase(cell.Value.ToString(),font));
                                }
                            }
                                                     
                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                
                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);                               
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("Tạo file PDF thành công");

                        }

                        catch (Exception ex)
                        {

                            MessageBox.Show("Lỗi tạo file" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy bảng dữ liệu");

            }
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
           
        }

        
    }
}
