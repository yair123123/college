namespace college
{
    partial class lids
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
            listBox = new ListBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(270, 144);
            listBox.Name = "listBox";
            listBox.Size = new Size(214, 169);
            listBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label1.Location = new Point(98, 62);
            label1.Name = "label1";
            label1.Size = new Size(618, 46);
            label1.TabIndex = 1;
            label1.Text = "משמרת נעימה נא לחזור ללידים הבאים!";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button1.Location = new Point(270, 356);
            button1.Name = "button1";
            button1.Size = new Size(214, 42);
            button1.TabIndex = 2;
            button1.Text = "התחל עסקה";
            button1.UseVisualStyleBackColor = true;
            button1.Click += NameLid;
            // 
            // lids
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(listBox);
            Name = "lids";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "lids";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox;
        private Label label1;
        private Button button1;
    }
}