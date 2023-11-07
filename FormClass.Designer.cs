
namespace QLSV
{
    partial class FormClass
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_nk = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.show_class = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.show_class)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Niên khóa";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(122, 218);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(212, 29);
            this.txt_name.TabIndex = 5;
            // 
            // txt_nk
            // 
            this.txt_nk.Location = new System.Drawing.Point(122, 271);
            this.txt_nk.Name = "txt_nk";
            this.txt_nk.Size = new System.Drawing.Size(212, 29);
            this.txt_nk.TabIndex = 6;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn_add.Location = new System.Drawing.Point(27, 381);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(92, 43);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_search);
            this.panel1.Controls.Add(this.btn_del);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_reset);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.txt_nk);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 553);
            this.panel1.TabIndex = 10;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn_search.Location = new System.Drawing.Point(322, 49);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(57, 33);
            this.btn_search.TabIndex = 19;
            this.btn_search.Text = "Tìm";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tìm kiếm";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(104, 49);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(212, 29);
            this.txt_search.TabIndex = 17;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn_del.Location = new System.Drawing.Point(206, 381);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(92, 43);
            this.btn_del.TabIndex = 16;
            this.btn_del.Text = "Xóa";
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn_update.Location = new System.Drawing.Point(27, 446);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(92, 43);
            this.btn_update.TabIndex = 14;
            this.btn_update.Text = "Cập nhật";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn_reset.Location = new System.Drawing.Point(206, 446);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(92, 43);
            this.btn_reset.TabIndex = 12;
            this.btn_reset.Text = "Đặt lại";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã lớp";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(122, 158);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(212, 29);
            this.txt_id.TabIndex = 10;
            // 
            // show_class
            // 
            this.show_class.AllowUserToAddRows = false;
            this.show_class.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.show_class.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.show_class.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.show_class.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.show_class.Location = new System.Drawing.Point(388, 0);
            this.show_class.Name = "show_class";
            this.show_class.Size = new System.Drawing.Size(713, 553);
            this.show_class.TabIndex = 11;
            this.show_class.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.show_class_CellContentClick);
            // 
            // FormClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1094, 551);
            this.Controls.Add(this.show_class);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FormClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin lớp học";
            this.Load += new System.EventHandler(this.FormClass_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.show_class)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_nk;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView show_class;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_search;
    }
}