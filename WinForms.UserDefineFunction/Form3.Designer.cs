namespace WinForms.UserDefineFunction
{
    partial class Form3
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 41);
            label1.Name = "label1";
            label1.Size = new Size(145, 25);
            label1.TabIndex = 0;
            label1.Text = "กรอกตัวอักษร 1 ตัว";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(214, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 31);
            textBox1.TabIndex = 1;
            textBox1.Text = "X";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(214, 90);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 31);
            textBox2.TabIndex = 2;
            textBox2.Text = "5";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 90);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 3;
            label2.Text = "กำหนดขนาด";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(37, 159);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(413, 359);
            textBox3.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(478, 61);
            button1.Name = "button1";
            button1.Size = new Size(97, 54);
            button1.TabIndex = 5;
            button1.Text = "Go";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(371, 37);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(88, 29);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "แบบที่ 1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(371, 72);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(88, 29);
            radioButton2.TabIndex = 7;
            radioButton2.Text = "แบบที่ 2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(371, 107);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(88, 29);
            radioButton3.TabIndex = 8;
            radioButton3.Text = "แบบที่ 3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1000, 562);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Leelawadee UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Button button1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
    }
}