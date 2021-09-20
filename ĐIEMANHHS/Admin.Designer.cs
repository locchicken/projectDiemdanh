
namespace ĐIEMANHHS
{
    partial class Admin
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rjButton6 = new ĐIEMANHHS.RJButton();
            this.btnstudent = new ĐIEMANHHS.RJButton();
            this.btnTeacher = new ĐIEMANHHS.RJButton();
            this.btnClass = new ĐIEMANHHS.RJButton();
            this.rjButton2 = new ĐIEMANHHS.RJButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnstudent);
            this.panel1.Controls.Add(this.btnTeacher);
            this.panel1.Controls.Add(this.btnClass);
            this.panel1.Controls.Add(this.rjButton2);
            this.panel1.Location = new System.Drawing.Point(1, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1261, 585);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.rjButton6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1258, 66);
            this.panel2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TIME";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHỌN CHỨC NĂNG ĐỂ THỰC HIỆN";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rjButton6
            // 
            this.rjButton6.BackColor = System.Drawing.Color.White;
            this.rjButton6.BackgroundColor = System.Drawing.Color.White;
            this.rjButton6.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton6.BorderRadius = 20;
            this.rjButton6.BorderSize = 0;
            this.rjButton6.FlatAppearance.BorderSize = 0;
            this.rjButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton6.ForeColor = System.Drawing.Color.Black;
            this.rjButton6.Image = global::ĐIEMANHHS.Properties.Resources.Go_back_icon;
            this.rjButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButton6.Location = new System.Drawing.Point(1134, 12);
            this.rjButton6.Name = "rjButton6";
            this.rjButton6.Size = new System.Drawing.Size(111, 40);
            this.rjButton6.TabIndex = 2;
            this.rjButton6.Text = "Quay Lại";
            this.rjButton6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rjButton6.TextColor = System.Drawing.Color.Black;
            this.rjButton6.UseVisualStyleBackColor = false;
            // 
            // btnstudent
            // 
            this.btnstudent.BackColor = System.Drawing.Color.LightCyan;
            this.btnstudent.BackgroundColor = System.Drawing.Color.LightCyan;
            this.btnstudent.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnstudent.BorderRadius = 20;
            this.btnstudent.BorderSize = 0;
            this.btnstudent.FlatAppearance.BorderSize = 0;
            this.btnstudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstudent.ForeColor = System.Drawing.Color.Black;
            this.btnstudent.Image = global::ĐIEMANHHS.Properties.Resources.Student_3_icon;
            this.btnstudent.Location = new System.Drawing.Point(356, 371);
            this.btnstudent.Margin = new System.Windows.Forms.Padding(2);
            this.btnstudent.Name = "btnstudent";
            this.btnstudent.Size = new System.Drawing.Size(150, 117);
            this.btnstudent.TabIndex = 11;
            this.btnstudent.Text = "Học Sinh";
            this.btnstudent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnstudent.TextColor = System.Drawing.Color.Black;
            this.btnstudent.UseVisualStyleBackColor = false;
            this.btnstudent.Click += new System.EventHandler(this.btnstudent_Click);
            // 
            // btnTeacher
            // 
            this.btnTeacher.BackColor = System.Drawing.Color.LightCyan;
            this.btnTeacher.BackgroundColor = System.Drawing.Color.LightCyan;
            this.btnTeacher.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTeacher.BorderRadius = 20;
            this.btnTeacher.BorderSize = 0;
            this.btnTeacher.FlatAppearance.BorderSize = 0;
            this.btnTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacher.ForeColor = System.Drawing.Color.Black;
            this.btnTeacher.Image = global::ĐIEMANHHS.Properties.Resources._10225_woman_teacher_light_skin_tone_icon2;
            this.btnTeacher.Location = new System.Drawing.Point(739, 371);
            this.btnTeacher.Margin = new System.Windows.Forms.Padding(2);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(150, 117);
            this.btnTeacher.TabIndex = 10;
            this.btnTeacher.Text = "Giáo  Viên";
            this.btnTeacher.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTeacher.TextColor = System.Drawing.Color.Black;
            this.btnTeacher.UseVisualStyleBackColor = false;
            this.btnTeacher.Click += new System.EventHandler(this.btnTeacher_Click);
            // 
            // btnClass
            // 
            this.btnClass.BackColor = System.Drawing.Color.LightCyan;
            this.btnClass.BackgroundColor = System.Drawing.Color.LightCyan;
            this.btnClass.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnClass.BorderRadius = 20;
            this.btnClass.BorderSize = 0;
            this.btnClass.FlatAppearance.BorderSize = 0;
            this.btnClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClass.ForeColor = System.Drawing.Color.Black;
            this.btnClass.Image = global::ĐIEMANHHS.Properties.Resources.Science_Classroom_icon;
            this.btnClass.Location = new System.Drawing.Point(356, 78);
            this.btnClass.Margin = new System.Windows.Forms.Padding(2);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(150, 125);
            this.btnClass.TabIndex = 8;
            this.btnClass.Text = "Lớp THPT";
            this.btnClass.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClass.TextColor = System.Drawing.Color.Black;
            this.btnClass.UseVisualStyleBackColor = false;
            this.btnClass.Click += new System.EventHandler(this.btnClass_Click);
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.LightCyan;
            this.rjButton2.BackgroundColor = System.Drawing.Color.LightCyan;
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 20;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.Black;
            this.rjButton2.Image = global::ĐIEMANHHS.Properties.Resources.Documents_icon;
            this.rjButton2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rjButton2.Location = new System.Drawing.Point(739, 78);
            this.rjButton2.Margin = new System.Windows.Forms.Padding(2);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(150, 125);
            this.rjButton2.TabIndex = 7;
            this.rjButton2.Text = "Lớp, Chuyên Nghành và Khoa";
            this.rjButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rjButton2.TextColor = System.Drawing.Color.Black;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1260, 647);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private RJButton btnstudent;
        private RJButton btnTeacher;
        private RJButton btnClass;
        private RJButton rjButton2;
        private System.Windows.Forms.Panel panel2;
        private RJButton rjButton6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}