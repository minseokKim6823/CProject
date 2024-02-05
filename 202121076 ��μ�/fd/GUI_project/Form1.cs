using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_project
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (File.Exists(folder + @"\데이터.txt"))
            {
            }
            else
            {
                folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                StreamWriter sw1 = new StreamWriter(folder + @"\데이터.txt");
                sw1.Close();
            }
            InitializeComponent();
            button1.Visible = false;//버튼 숨기기 로그인시 나오게 함
            
            buttonAdmin.Visible = false;
            
        }
        User user = new User();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm = new Form2(); //
            frm.Owner = this;
            frm.Show();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdmin frm = new FormAdmin(); //
            frm.Owner = this;
            frm.Show();
        }

		private void button3_Click(object sender, EventArgs e)
		{
            user.Login(textBox_PW.Text, textBox_ID.Text);
            if (user.x == true)
            {
                button1.Visible = true;
              
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                textBox_PW.Visible = false;
                textBox_ID.Visible = false;
            }
            else
                MessageBox.Show("오류");
            

        }

		private void button4_Click(object sender, EventArgs e)
		{
            this.Hide();
            Form3 frm3 = new Form3(); //
            frm3.Owner = this;
            frm3.Show();
        }

		private void button5_Click(object sender, EventArgs e)
		{
            if(textBox_ID.Text==user.admin_id && textBox_PW.Text ==user.admin_pass)
			{
                buttonAdmin.Visible = true;
                textBox_ID.Visible = false;
                textBox_PW.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
            }
            else
                MessageBox.Show(" 아이디(관리자 전용 아이디) 또는 비밀번호를 잘못 입력했습니다" + "\n" + "입력하신 내용을 다시 확인해주세요.");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
