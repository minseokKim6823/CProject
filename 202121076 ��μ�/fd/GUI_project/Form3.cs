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
	public partial class Form3 : Form
	{
		string t;
		bool T = false;
		string folder;
		public Form3()
		{
			InitializeComponent();
			folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (textBox8.Text == textBox9.Text && T==true )
			{
				
				//string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+@"데이터.txt";

				
				string filePath = @"C:\Users\김민석\Documents\데이터.txt";

				string txtVal = textBox1.Text + "\t" + textBox2.Text + "-" + textBox3.Text + "\t" + textBox4.Text + "-" + textBox5.Text + "-" + textBox6.Text + "\t" + textBox7.Text + "\t\t" + textBox8.Text;

                if (File.Exists(filePath))
                {
					System.IO.File.AppendAllText(filePath, txtVal, Encoding.Default);
				}
				else
					System.IO.File.WriteAllText(filePath, txtVal, Encoding.Default);
				
					
				//s.Close();
				this.Hide();
				Form1 frm = new Form1(); //
				frm.Owner = this;
				frm.Show();
			}

			else
				MessageBox.Show("비밀번호 혹은 아이디를 확인하세요");
		}

		private void button1_Click(object sender, EventArgs e)
		{

			//string filename = folder + @"\데이터.txt";
			string filename = @"C:\Users\김민석\Documents\데이터.txt";
			string txtVal = System.IO.File.ReadAllText(filename);
				
				if (File.Exists(filename))
                {
                        if (txtVal.Contains(textBox7.Text) == false)
                        {
							t = textBox7.Text;
							MessageBox.Show("아이디를 사용하실 수 있습니다");
							T = true;
                        }
					else
						MessageBox.Show("아이디를 사용하실 수 없습니다");
				}
				else
				{
					System.IO.File.WriteAllText(File.ReadAllText(filename), txtVal, Encoding.Default);
					MessageBox.Show("아이디를 사용하실 수 있습니다");
				}
					

		}
			
	}
}

