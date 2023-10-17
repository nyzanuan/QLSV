
namespace QLSV
{
    partial class FormMain
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
            this.btn_manage_stu = new System.Windows.Forms.Button();
            this.btn_manage_class = new System.Windows.Forms.Button();
            this.btn_manage_score = new System.Windows.Forms.Button();
            this.btn_subject = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_report = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_manage_stu
            // 
            this.btn_manage_stu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manage_stu.Location = new System.Drawing.Point(20, 33);
            this.btn_manage_stu.Name = "btn_manage_stu";
            this.btn_manage_stu.Size = new System.Drawing.Size(156, 44);
            this.btn_manage_stu.TabIndex = 0;
            this.btn_manage_stu.Text = "Quản lí sinh viên";
            this.btn_manage_stu.UseVisualStyleBackColor = true;
            this.btn_manage_stu.Click += new System.EventHandler(this.btn_manage_stu_Click);
            // 
            // btn_manage_class
            // 
            this.btn_manage_class.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manage_class.Location = new System.Drawing.Point(200, 33);
            this.btn_manage_class.Name = "btn_manage_class";
            this.btn_manage_class.Size = new System.Drawing.Size(156, 44);
            this.btn_manage_class.TabIndex = 1;
            this.btn_manage_class.Text = "Quản lí lớp học";
            this.btn_manage_class.UseVisualStyleBackColor = true;
            this.btn_manage_class.Click += new System.EventHandler(this.btn_manage_class_Click);
            // 
            // btn_manage_score
            // 
            this.btn_manage_score.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manage_score.Location = new System.Drawing.Point(380, 33);
            this.btn_manage_score.Name = "btn_manage_score";
            this.btn_manage_score.Size = new System.Drawing.Size(156, 44);
            this.btn_manage_score.TabIndex = 2;
            this.btn_manage_score.Text = "Quản lí điểm";
            this.btn_manage_score.UseVisualStyleBackColor = true;
            this.btn_manage_score.Click += new System.EventHandler(this.btn_manage_score_Click);
            // 
            // btn_subject
            // 
            this.btn_subject.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_subject.Location = new System.Drawing.Point(560, 33);
            this.btn_subject.Name = "btn_subject";
            this.btn_subject.Size = new System.Drawing.Size(156, 44);
            this.btn_subject.TabIndex = 3;
            this.btn_subject.Text = "Quản lí môn học";
            this.btn_subject.UseVisualStyleBackColor = true;
            this.btn_subject.Click += new System.EventHandler(this.btn_subject_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Location = new System.Drawing.Point(920, 33);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(156, 44);
            this.btn_logout.TabIndex = 4;
            this.btn_logout.Text = "Đăng xuất";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bảng chức năng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel_main
            // 
            this.panel_main.AutoSize = true;
            this.panel_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_main.Location = new System.Drawing.Point(-3, 91);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1096, 532);
            this.panel_main.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_report);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_logout);
            this.panel2.Controls.Add(this.btn_subject);
            this.panel2.Controls.Add(this.btn_manage_score);
            this.panel2.Controls.Add(this.btn_manage_class);
            this.panel2.Controls.Add(this.btn_manage_stu);
            this.panel2.Location = new System.Drawing.Point(-3, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1096, 94);
            this.panel2.TabIndex = 7;
            // 
            // btn_report
            // 
            this.btn_report.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_report.Location = new System.Drawing.Point(740, 33);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(156, 44);
            this.btn_report.TabIndex = 6;
            this.btn_report.Text = "Báo cáo";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1093, 621);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_main);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_manage_stu;
        private System.Windows.Forms.Button btn_manage_class;
        private System.Windows.Forms.Button btn_manage_score;
        private System.Windows.Forms.Button btn_subject;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_report;
    }
}