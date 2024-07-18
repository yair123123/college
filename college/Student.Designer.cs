namespace college
{
    partial class Student
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label_nane = new Label();
            label3 = new Label();
            button = new Button();
            label_debt = new Label();
            label5 = new Label();
            label_course = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(124, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(271, 162);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(281, 37);
            label1.Name = "label1";
            label1.Size = new Size(158, 28);
            label1.TabIndex = 1;
            label1.Text = "יתרת החוב היא:";
            // 
            // label_nane
            // 
            label_nane.AutoSize = true;
            label_nane.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label_nane.Location = new Point(124, 37);
            label_nane.Name = "label_nane";
            label_nane.Size = new Size(70, 28);
            label_nane.TabIndex = 2;
            label_nane.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.Location = new Point(22, 37);
            label3.Name = "label3";
            label3.Size = new Size(65, 28);
            label3.TabIndex = 3;
            label3.Text = "שלום:";
            // 
            // button
            // 
            button.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            button.Location = new Point(124, 305);
            button.Name = "button";
            button.Size = new Size(271, 76);
            button.TabIndex = 4;
            button.Text = "לתשלום";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click_1;
            // 
            // label_debt
            // 
            label_debt.AutoSize = true;
            label_debt.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label_debt.Location = new Point(478, 37);
            label_debt.Name = "label_debt";
            label_debt.Size = new Size(70, 28);
            label_debt.TabIndex = 5;
            label_debt.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label5.ForeColor = Color.OliveDrab;
            label5.Location = new Point(76, 401);
            label5.Name = "label5";
            label5.Size = new Size(141, 28);
            label5.TabIndex = 6;
            label5.Text = "הקורס הקרוב:";
            // 
            // label_course
            // 
            label_course.AutoSize = true;
            label_course.Location = new Point(263, 412);
            label_course.Name = "label_course";
            label_course.Size = new Size(38, 15);
            label_course.TabIndex = 7;
            label_course.Text = "label6";
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 450);
            Controls.Add(label_course);
            Controls.Add(label5);
            Controls.Add(label_debt);
            Controls.Add(button);
            Controls.Add(label3);
            Controls.Add(label_nane);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Student";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "Student";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label_nane;
        private Label label3;
        private Button button;
        private Label label_debt;
        private Label label5;
        private Label label_course;
    }
}