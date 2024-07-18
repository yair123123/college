namespace college
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button_confirm = new Button();
            label1 = new Label();
            textBox_name = new TextBox();
            textBox_phone = new TextBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button_enter = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(433, 44);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button_confirm
            // 
            button_confirm.BackColor = Color.SpringGreen;
            button_confirm.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button_confirm.Location = new Point(159, 324);
            button_confirm.Name = "button_confirm";
            button_confirm.Size = new Size(200, 100);
            button_confirm.TabIndex = 1;
            button_confirm.Text = "שלח";
            button_confirm.UseVisualStyleBackColor = false;
            button_confirm.Click += button_confirm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(-4, 44);
            label1.Name = "label1";
            label1.Size = new Size(554, 37);
            label1.TabIndex = 2;
            label1.Text = "אנא השאר פרטים ונציגנו יחזור אליך בהקדם";
            // 
            // textBox_name
            // 
            textBox_name.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            textBox_name.Location = new Point(159, 101);
            textBox_name.Multiline = true;
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(200, 40);
            textBox_name.TabIndex = 3;
            // 
            // textBox_phone
            // 
            textBox_phone.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            textBox_phone.Location = new Point(159, 187);
            textBox_phone.Multiline = true;
            textBox_phone.Name = "textBox_phone";
            textBox_phone.Size = new Size(200, 40);
            textBox_phone.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(159, 269);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 23);
            comboBox1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.Location = new Point(389, 199);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 6;
            label2.Text = "טלפון";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.Location = new Point(392, 113);
            label3.Name = "label3";
            label3.Size = new Size(42, 28);
            label3.TabIndex = 7;
            label3.Text = "שם";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label4.Location = new Point(392, 264);
            label4.Name = "label4";
            label4.Size = new Size(58, 28);
            label4.TabIndex = 8;
            label4.Text = "קורס";
            // 
            // button_enter
            // 
            button_enter.BackColor = Color.Chartreuse;
            button_enter.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button_enter.Location = new Point(-4, 400);
            button_enter.Name = "button_enter";
            button_enter.Size = new Size(136, 53);
            button_enter.TabIndex = 9;
            button_enter.Text = "כניסת מנהלים";
            button_enter.UseVisualStyleBackColor = false;
            button_enter.Click += button_enter_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.GreenYellow;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.ForeColor = Color.Coral;
            button2.Location = new Point(-4, 341);
            button2.Name = "button2";
            button2.Size = new Size(136, 53);
            button2.TabIndex = 10;
            button2.Text = "כניסת תלמידים";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 450);
            Controls.Add(button2);
            Controls.Add(button_enter);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(textBox_phone);
            Controls.Add(textBox_name);
            Controls.Add(label1);
            Controls.Add(button_confirm);
            Controls.Add(button1);
            Name = "login";
            Text = "Form1";
            FormClosed += stop_application;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button_confirm;
        private Label label1;
        private TextBox textBox_name;
        private TextBox textBox_phone;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button_enter;
        private Button button2;
    }
}
