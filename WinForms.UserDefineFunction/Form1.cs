using System.Xml.Linq;

namespace WinForms.UserDefineFunction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string firstname = "";
        string lastname = "";
        string username = "";
        string password = "";

        private void checkfirstname()
        {
            firstname = textBox5.Text;
            if (string.IsNullOrWhiteSpace(firstname))
            {
                MessageBox.Show("กำหนดให้ชื่อไม่เป็นที่ว่าง");
                textBox5.Focus();
                return;
            }
            if (firstname.Length < 2)
            {
                MessageBox.Show("กำหนดให้ชื่อมีความยาวอย่างน้อย 2 ตัวอักษร");
                textBox5.Focus();
            }
        }

        private void checklastname()
        {
            lastname = textBox1.Text;
            if (string.IsNullOrWhiteSpace(lastname))
            {
                MessageBox.Show("กำหนดให้นามสกุลไม่เป็นที่ว่าง");
                textBox1.Focus();
                return;
            }
            if (lastname.Length < 2)
            {
                MessageBox.Show("กำหนดให้นามสกุลมีความยาวอย่างน้อย 2 ตัวอักษร");
                textBox1.Focus();
            }
        }

        private void checkusername()
        {
            username = textBox2.Text;
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("กำหนดให้ชื่อผู้ใช้ไม่เป็นที่ว่าง");
                textBox2.Focus();
                return;
            }
            if (username.Length > 20)
            {
                MessageBox.Show("กำหนดให้ชื่อผู้ใช้มีความยาวไม่เกิน 20 ตัวอักษร");
                textBox2.Focus();
            }
        }

        private void checkname(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("กำหนดให้ไม่เป็นที่ว่าง");
                return;
            }
            if (name.Length < 2)
            {
                MessageBox.Show("กำหนดให้มีความยาวอย่างน้อย 2 ตัวอักษร");
            }
        }

        private void checkpassword(TextBox password, TextBox confirm)
        {
            if (string.IsNullOrWhiteSpace(password.Text) || string.IsNullOrWhiteSpace(confirm.Text))
            {
                MessageBox.Show("กำหนดให้รหัสผ่านไม่เป็นที่ว่าง");
                textBox3.Focus();
                return;
            }
            if (password.TextLength < 8)
            {
                MessageBox.Show("กำหนดให้รหัสผ่านมีความยาวอย่างน้อย 8 ตัวอักษร");
                return;
            }
            if (password.Text != confirm.Text)
            {
                MessageBox.Show("รหัสผ่านไม่ตรงกัน");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //checkfirstname();
            //checklastname();
            firstname = textBox5.Text;
            lastname = textBox2.Text;
            checkname(firstname);
            checkname(lastname);
            checkusername();
            checkpassword(textBox3, textBox4);
        }

    }
}
