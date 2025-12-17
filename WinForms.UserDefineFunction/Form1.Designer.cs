namespace WinForms.UserDefineFunction
{
    partial class Form1
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox5 = new TextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 67);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 0;
            label1.Text = "นามสกุล";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(163, 61);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(316, 31);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(487, 64);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(150, 25);
            label2.TabIndex = 2;
            label2.Text = "ไม่ต่ำกว่า 2 ตัวอักษร";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 116);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 3;
            label3.Text = "ชื่อบัญชีผู้ใช้";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(163, 116);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(316, 31);
            textBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(83, 173);
            label4.Name = "label4";
            label4.Size = new Size(71, 25);
            label4.TabIndex = 5;
            label4.Text = "รหัสผ่าน";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(163, 170);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(316, 34);
            textBox3.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 224);
            label5.Name = "label5";
            label5.Size = new Size(111, 25);
            label5.TabIndex = 7;
            label5.Text = "ยืนยันรหัสผ่าน";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(163, 224);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(316, 31);
            textBox4.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(163, 287);
            button1.Name = "button1";
            button1.Size = new Size(137, 47);
            button1.TabIndex = 9;
            button1.Text = "สมัครสมาชิก";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(487, 122);
            label6.Name = "label6";
            label6.Size = new Size(103, 25);
            label6.TabIndex = 10;
            label6.Text = "ไม่เกิน 20 ตัว";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(487, 173);
            label7.Name = "label7";
            label7.Size = new Size(150, 25);
            label7.TabIndex = 11;
            label7.Text = "ไม่ต่ำกว่า 8 ตัวอักษร";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(487, 16);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(150, 25);
            label8.TabIndex = 14;
            label8.Text = "ไม่ต่ำกว่า 2 ตัวอักษร";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(163, 13);
            textBox5.Margin = new Padding(4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(316, 31);
            textBox5.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(121, 19);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(33, 25);
            label9.TabIndex = 12;
            label9.Text = "ชื่อ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1089, 578);
            Controls.Add(label8);
            Controls.Add(textBox5);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Leelawadee UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Button button1;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox5;
        private Label label9;
    }
}
