namespace college
{
    partial class Cart
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
            dataGridView = new DataGridView();
            button_confirm = new Button();
            button_delete = new Button();
            button_clear = new Button();
            button_back = new LinkLabel();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(146, 80);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(427, 258);
            dataGridView.TabIndex = 0;
            dataGridView.CellClick += dataGridView1_CellClick;
            // 
            // button_confirm
            // 
            button_confirm.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            button_confirm.Location = new Point(17, 358);
            button_confirm.Name = "button_confirm";
            button_confirm.Size = new Size(165, 51);
            button_confirm.TabIndex = 1;
            button_confirm.Text = "אישור";
            button_confirm.UseVisualStyleBackColor = true;
            button_confirm.Click += button_confirm_Click;
            // 
            // button_delete
            // 
            button_delete.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            button_delete.Location = new Point(281, 358);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(165, 51);
            button_delete.TabIndex = 2;
            button_delete.Text = "מחק פריט";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // button_clear
            // 
            button_clear.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            button_clear.Location = new Point(526, 358);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(165, 51);
            button_clear.TabIndex = 3;
            button_clear.Text = "נקה סל";
            button_clear.UseVisualStyleBackColor = true;
            button_clear.Click += button_clear_Click;
            // 
            // button_back
            // 
            button_back.AutoSize = true;
            button_back.Location = new Point(605, 31);
            button_back.Name = "button_back";
            button_back.Size = new Size(29, 15);
            button_back.TabIndex = 4;
            button_back.TabStop = true;
            button_back.Text = "חזור";
            button_back.LinkClicked += button_back_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(146, 31);
            label1.Name = "label1";
            label1.Size = new Size(193, 37);
            label1.TabIndex = 5;
            label1.Text = "סכום לתשלום:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(380, 31);
            label2.Name = "label2";
            label2.Size = new Size(90, 37);
            label2.TabIndex = 6;
            label2.Text = "label2";
            // 
            // Cart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_back);
            Controls.Add(button_clear);
            Controls.Add(button_delete);
            Controls.Add(button_confirm);
            Controls.Add(dataGridView);
            Name = "Cart";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "Cart";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Button button_confirm;
        private Button button_delete;
        private Button button_clear;
        private LinkLabel button_back;
        private Label label1;
        private Label label2;
    }
}