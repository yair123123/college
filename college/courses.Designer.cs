using System.Windows.Forms;

namespace college
{
    partial class courses
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
            button1 = new Button();
            dataGridView = new DataGridView();
            label_courses = new Label();
            button_add = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button1.Location = new Point(12, 539);
            button1.Name = "button1";
            button1.Size = new Size(114, 66);
            button1.TabIndex = 0;
            button1.Text = "הצג סל";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(111, 64);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(508, 363);
            dataGridView.TabIndex = 1;
            dataGridView.CellClick += dataGridView1_CellClick;
            // 
            // label_courses
            // 
            label_courses.AutoSize = true;
            label_courses.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label_courses.Location = new Point(318, 9);
            label_courses.Name = "label_courses";
            label_courses.Size = new Size(106, 37);
            label_courses.TabIndex = 4;
            label_courses.Text = "קורסים";
            label_courses.TextAlign = ContentAlignment.TopCenter;
            // 
            // button_add
            // 
            button_add.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button_add.Location = new Point(288, 433);
            button_add.Name = "button_add";
            button_add.Size = new Size(147, 44);
            button_add.TabIndex = 5;
            button_add.Text = "הוסף לסל";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += AddToCart;
            // 
            // courses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 617);
            Controls.Add(button_add);
            Controls.Add(label_courses);
            Controls.Add(dataGridView);
            Controls.Add(button1);
            Name = "courses";
            Text = "courses";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView;
        private Label label1;
        private Label label2;
        private Label label_courses;
        private Button button_add;
    }
}