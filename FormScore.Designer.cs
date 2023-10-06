
namespace QLSV
{
    partial class FormScore
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_sub_id = new System.Windows.Forms.TextBox();
            this.txt_score = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.show_score = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.show_score)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(404, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã môn học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sinh viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(751, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Điểm";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(205, 31);
            this.txt_id.MaxLength = 3500;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(164, 29);
            this.txt_id.TabIndex = 3;
            // 
            // txt_sub_id
            // 
            this.txt_sub_id.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sub_id.Location = new System.Drawing.Point(524, 31);
            this.txt_sub_id.MaxLength = 3500;
            this.txt_sub_id.Name = "txt_sub_id";
            this.txt_sub_id.Size = new System.Drawing.Size(164, 29);
            this.txt_sub_id.TabIndex = 4;
            // 
            // txt_score
            // 
            this.txt_score.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_score.Location = new System.Drawing.Point(807, 31);
            this.txt_score.MaxLength = 3500;
            this.txt_score.Name = "txt_score";
            this.txt_score.Size = new System.Drawing.Size(164, 29);
            this.txt_score.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_reset);
            this.panel1.Controls.Add(this.btn_del);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.txt_score);
            this.panel1.Controls.Add(this.txt_sub_id);
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1097, 124);
            this.panel1.TabIndex = 6;
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn_reset.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(818, 83);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(100, 29);
            this.btn_reset.TabIndex = 9;
            this.btn_reset.Text = "Đặt lại";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn_del.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.Location = new System.Drawing.Point(588, 83);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(100, 29);
            this.btn_del.TabIndex = 8;
            this.btn_del.Text = "Xóa";
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn_update.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(361, 83);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(100, 29);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "Cập nhật";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn_add.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(156, 83);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 29);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // show_score
            // 
            this.show_score.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.show_score.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.show_score.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.show_score.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.show_score.DefaultCellStyle = dataGridViewCellStyle5;
            this.show_score.Location = new System.Drawing.Point(0, 125);
            this.show_score.Name = "show_score";
            this.show_score.Size = new System.Drawing.Size(1097, 431);
            this.show_score.TabIndex = 7;
            this.show_score.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.show_score_CellContentClick);
            // 
            // FormScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 551);
            this.Controls.Add(this.show_score);
            this.Controls.Add(this.panel1);
            this.Name = "FormScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin điểm sinh viên";
            this.Load += new System.EventHandler(this.FormScore_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.show_score)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_sub_id;
        private System.Windows.Forms.TextBox txt_score;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView show_score;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_reset;
    }
}