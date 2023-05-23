namespace Assignment
{
    partial class professorcourseOption
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.semesterbox = new System.Windows.Forms.TextBox();
            this.addCoursbox = new System.Windows.Forms.TextBox();
            this.AddCourse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Semster";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Add Course";
            // 
            // semesterbox
            // 
            this.semesterbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semesterbox.Location = new System.Drawing.Point(143, 106);
            this.semesterbox.Name = "semesterbox";
            this.semesterbox.Size = new System.Drawing.Size(154, 26);
            this.semesterbox.TabIndex = 2;
            // 
            // addCoursbox
            // 
            this.addCoursbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCoursbox.Location = new System.Drawing.Point(143, 195);
            this.addCoursbox.Name = "addCoursbox";
            this.addCoursbox.Size = new System.Drawing.Size(154, 26);
            this.addCoursbox.TabIndex = 3;
            // 
            // AddCourse
            // 
            this.AddCourse.BackColor = System.Drawing.SystemColors.ControlDark;
            this.AddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCourse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddCourse.Location = new System.Drawing.Point(143, 264);
            this.AddCourse.Name = "AddCourse";
            this.AddCourse.Size = new System.Drawing.Size(168, 35);
            this.AddCourse.TabIndex = 4;
            this.AddCourse.Text = "Course Add";
            this.AddCourse.UseVisualStyleBackColor = false;
            this.AddCourse.Click += new System.EventHandler(this.AddCourse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Course Option";
            // 
            // professorcourseOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(478, 326);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddCourse);
            this.Controls.Add(this.addCoursbox);
            this.Controls.Add(this.semesterbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "professorcourseOption";
            this.Text = "professorcourseOption";
            this.Load += new System.EventHandler(this.professorcourseOption_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox semesterbox;
        private System.Windows.Forms.TextBox addCoursbox;
        private System.Windows.Forms.Button AddCourse;
        private System.Windows.Forms.Label label3;
    }
}