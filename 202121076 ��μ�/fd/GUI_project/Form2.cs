using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_project
{
    public partial class Form2 : Form
    {
        private Socket socket;
        private Thread receiveThread;
        Order food = new Order();
        DateTime dt = new DateTime();
        Time time = new Time();
        StringBuilder sb = new StringBuilder();
        string[] food1 = new string[] { "새우깡", "땅콩", "숏다리", "썬칩", "오감자", "오징어집", "포테토칩", "회오리감자","신라면", "컵라면", "새우볶음밥", "김치볶음밥", "닭가슴살볶음밥", "햄야채볶음밥", "참치마요볶음밥", "아메리카노", "카페라떼", "카푸치노", "망고스무디", "딸기스무디", "콜라", "사이다", "계란", "떡", "모짜렐라치즈", "체다치즈", "밥" };
        public int[] food2 = new int[] { 0, 0, 0, 0, 0, 0, 0, 0 ,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int ssum;
        int hour1, hour2, hour5;
        
        public Form2()
        {
            ssum = food.Price;
            InitializeComponent();
            


            time.Duration = 100;
            textBoxInput.Visible = false;
            listBox1.Visible = false;
           

            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void buttonFood_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void buttonBeverage_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void buttonSnack_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void buttonSide_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;

        }

        private void buttonAddtime_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;

        }

        private void buttonSaeuggang_Click(object sender, EventArgs e)
        {
            ssum = food.Price;
            food.Price_cal(food.saeuggang);
            if (User.food4[0]!=0)
                food2[0]++;
            textBox1.Text = "";
            food.SoldOut(0);
            for (int i = 0; i < 27; i++)
            {
                if (food2[i] != 0)
                {
                    textBox1.Text += food1[i] + "   " + food2[i] + "개" + Environment.NewLine;
                }
            }
            sum.Text = ssum.ToString();
        }

        private void buttonPeanut_Click(object sender, EventArgs e)
        {
            food.Price_cal(food.peanut);
            if (User.food4[1] != 0)
                food2[1]++;
            textBox1.Text = "";
            food.SoldOut(1);
            for (int i = 0; i < 27; i++)
            {
                if (food2[i] != 0)
                {
                    textBox1.Text += food1[i] + "   " + food2[i] + "개" + Environment.NewLine;
                }
            }
            ssum = food.Price;
            sum.Text = ssum.ToString();
        }

        private void buttonShortdari_Click(object sender, EventArgs e)
        {
            food.Price_cal(food.shortdari);
            if (User.food4[2] != 0)
                food2[2]++;
            textBox1.Text = "";
            food.SoldOut(2);
            for (int i = 0; i < 27; i++)
            {
                if (food2[i] != 0)
                {
                    textBox1.Text += food1[i] + "   " + food2[i] + "개" + Environment.NewLine;
                }
            }
            ssum = food.Price;
            sum.Text = ssum.ToString();
        }

        private void buttonSunchip_Click(object sender, EventArgs e)
        {
            food.Price_cal(food.sunchip);
            if (User.food4[3] != 0)
                food2[3]++;
            textBox1.Text = "";
            food.SoldOut(3);
            for (int i = 0; i < 27; i++)
            {
                if (food2[i] != 0)
                {
                    textBox1.Text += food1[i] + "   " + food2[i] + "개" + Environment.NewLine;
                }
            }
            ssum = food.Price;
            sum.Text = ssum.ToString();
        }

        private void buttonOzinguzip_Click(object sender, EventArgs e)
        {
            food.Price_cal(food.ozinguzip);
            if (User.food4[5] != 0)
                food2[5]++;
            textBox1.Text = "";
            food.SoldOut(5);
            for (int i = 0; i < 27; i++)
            {
                if (food2[i] != 0)
                {
                    textBox1.Text += food1[i] + "   " + food2[i] + "개" + Environment.NewLine;
                }
            }
            ssum = food.Price;
            sum.Text = ssum.ToString();
        }

        private void buttonPotatoChips_Click(object sender, EventArgs e)
        {
            food.Price_cal(food.potatoChips);
            if (User.food4[6] != 0)
                food2[6]++;
            textBox1.Text = "";
            food.SoldOut(6);
            for (int i = 0; i < 27; i++)
            {
                if (food2[i] != 0)
                {
                    textBox1.Text += food1[i] + "   " + food2[i] + "개" + Environment.NewLine;
                }
            }
            ssum = food.Price;
            sum.Text = ssum.ToString();
        }

        private void buttonTornadoPotato_Click(object sender, EventArgs e)
        {
            food.Price_cal(food.tornadoPotato);
            if (User.food4[7] != 0)
                food2[7]++;
            textBox1.Text = "";
            food.SoldOut(7);
            for (int i = 0; i < 27; i++)
            {
                if (food2[i] != 0)
                {
                    textBox1.Text += food1[i] + "   " + food2[i] + "개" + Environment.NewLine;
                }
            }
            ssum = food.Price;
            sum.Text = ssum.ToString();
        }

        private void buttonOgamja_Click(object sender, EventArgs e)
        {
            food.Price_cal(food.ogamja);
            if (User.food4[4] != 0)
                food2[4]++;
            textBox1.Text = "";
            food.SoldOut(4);
            for (int i = 0; i < 27; i++)
            {
                if (food2[i] != 0)
                {
                    textBox1.Text += food1[i] + "   " + food2[i] + "개" + Environment.NewLine;
                }
            }
            ssum = food.Price;
            sum.Text = ssum.ToString();
        }

        private void button_Ramen_Click(object sender, EventArgs e)
        {
            food.Price_cal(food.ramen);
            if (User.food4[8] != 0)
                food2[8]++;
            textBox1.Text = "";
            food.SoldOut(8);
            for (int i = 0; i < 27; i++)
            {
                if (food2[i] != 0)
                {
                    textBox1.Text += food1[i] + "   " + food2[i] + "개" + Environment.NewLine;
                }
            }
            ssum = food.Price;
            sum.Text = ssum.ToString();
        }

        private void buttonCupramen_Click(object sender, EventArgs e)
        {
            food.Price_cal(food.cupramen);
            if (User.food4[9] != 0)
                food2[9]++;
            textBox1.Text = "";
            food.SoldOut(9);
            for (int i = 0; i < 27; i++)
            {
                if (food2[i] != 0)
                {
                    textBox1.Text += food1[i] + "   " + food2[i] + "개" + Environment.NewLine;
                }
            }
            ssum = food.Price;
            sum.Text = ssum.ToString();
        }

        private void buttonShrimp_Click(object sender, EventArgs e)
        {
            food.Price_cal(food.shrimp_fried_rice);
            if (User.food4[10] != 0)
                food2[10]++;
            textBox1.Text = "";
            food.SoldOut(10);
            for (int i = 0; i < 27; i++)
            {
                if (food2[i] != 0)
                {
                    textBox1.Text += food1[i] + "   " + food2[i] + "개" + Environment.NewLine;
                }
            }
            ssum = food.Price;
            sum.Text = ssum.ToString();
        }

        private void buttonKimch_Click(object sender, EventArgs e)
        {
            food.Price_cal(food.kimchi_fried_rice);
            if (User.food4[11] != 0)
                food2[11]++;
            textBox1.Text = "";
            food.SoldOut(11);
            for (int i = 0; i < 27; i++)
            {
                if (food2[i] != 0)
                {
                    textBox1.Text += food1[i] + "   " + food2[i] + "개" + Environment.NewLine;
                }
            }
            ssum = food.Price;
            sum.Text = ssum.ToString();
        }

        private void buttonChicken_Click(object sender, EventArgs e)
        {
            food.Price_cal(food.chicken_fried_rice);
            if (User.food4[12] != 0)
                food2[12]++;
            textBox1.Text = "";
            food.SoldOut(12);
            for (int i = 0; i < 27; i++)
            {
                if (food2[i] != 0)
                {
                    textBox1.Text += food1[i] + "   " + food2[i] + "개" + Environment.NewLine;
                }
            }
            ssum = food.Price;
            sum.Text = ssum.ToString();
        }

        private void buttonHV_Click(object sender, EventArgs e)
        {
            food.Price_cal(food.hv_fried_rice);
            if (User.food4[13] != 0)
                food2[13]++;
            textBox1.Text = "";
            food.SoldOut(13);
            for (int i = 0; i < 27; i++)
            {
                if (food2[i] != 0)
                {
                    textBox1.Text += food1[i] + "   " + food2[i] + "개" + Environment.NewLine;
                }

            }
            ssum = food.Price;
            sum.Text = ssum.ToString();
        }

        private void buttonTM_Click(object sender, EventArgs e)
        {
            food.Price_cal(food.tm);
            if (User.food4[14] != 0)
                food2[14]++;
            textBox1.Text = "";
            food.SoldOut(14);
            for (int i = 0; i < 27; i++)
            {
                if (food2[i] != 0)
                {
                    textBox1.Text += food1[i] + "   " + food2[i] + "개" + Environment.NewLine;
                }

            }
            ssum = food.Price;
            sum.Text = ssum.ToString();
        }

        private void buttonAmericano_Click(object sender, EventArgs e)
        {
            food.Price_cal(food.americano);
            if (User.food4[15] != 0)
                food2[15]++;
            textBox1.Text = "";
            food.SoldOut(15);
            for (int i = 0; i < 27; i++)
            {
                if (food2[i] != 0)
                {
                    textBox1.Text += food1[i] + "   " + food2[i] + "개" + Environment.NewLine;
                }

            }
            ssum = food.Price;
            sum.Text = ssum.ToString();
        }

        private void buttonLatte_Click(object sender, EventArgs e)
        {
            food.Price_cal(food.latte);
            if (User.food4[16] != 0)
                food2[16]++;
            textBox1.Text = "";
            food.SoldOut(16);
            for (int i = 0; i < 27; i++)
            {
                if (food2[i] != 0)
                {
                    textBox1.Text += food1[i] + "   " + food2[i] + "개" + Environment.NewLine;
                }

            }
            ssum = food.Price;
            sum.Text = ssum.ToString();
        }

        private void buttonCappucchino_Click(object sender, EventArgs e)
        {
            food.Price_cal(food.cappuccino);
            if (User.food4[17] != 0)
                food2[17]++;
            textBox1.Text = "";
            food.SoldOut(17);
            for (int i = 0; i < 27; i++)
            {
                if (food2[i] != 0)
                {
                    textBox1.Text += food1[i] + "   " + food2[i] + "개" + Environment.NewLine;
                }

            }
            ssum = food.Price;
            sum.Text = ssum.ToString();
        }

        private void buttonMangoSmoodie_Click(object sender, EventArgs e)
        {
            food.Price_cal(food.mango_smoodie);
            if (User.food4[18] != 0)
                food2[18]++;
            textBox1.Text = "";
            food.SoldOut(18);
            for (int i = 0; i < 27; i++)
            {
                if (food2[i] != 0)
                {
                    textBox1.Text += food1[i] + "   " + food2[i] + "개" + Environment.NewLine;
                }

            }
            ssum = food.Price;
            sum.Text = ssum.ToString();
        }

        private void buttonStrawsmoodie_Click(object sender, EventArgs e)
        {
            food.Price_cal(food.straw_smoodie);
            if (User.food4[19] != 0)
                food2[19]++;
            textBox1.Text = "";
            food.SoldOut(19);
            for (int i = 0; i < 27; i++)
            {
                if (food2[i] != 0)
                {
                    textBox1.Text += food1[i] + "   " + food2[i] + "개" + Environment.NewLine;
                }

            }
            ssum = food.Price;
            sum.Text = ssum.ToString();
        }

        private void buttonCoke_Click(object sender, EventArgs e)
        {
            food.Price_cal(food.coke);
            if (User.food4[20] != 0)
                food2[20]++;
            textBox1.Text = "";
            food.SoldOut(20);
            for (int i = 0; i < 27; i++)
            {
                if (food2[i] != 0)
                {
                    textBox1.Text += food1[i] + "   " + food2[i] + "개" + Environment.NewLine;
                }

            }
            ssum = food.Price;
            sum.Text = ssum.ToString();
        }

        private void buttonCider_Click(object sender, EventArgs e)
        {
            food.Price_cal(food.cider);
            if (User.food4[21] != 0)
                food2[21]++;
            textBox1.Text = "";
            food.SoldOut(21);
            for (int i = 0; i < 27; i++)
            {
                if (food2[i] != 0)
                {
                    textBox1.Text += food1[i] + "   " + food2[i] + "개" + Environment.NewLine;
                }

            }
            ssum = food.Price;
            sum.Text = ssum.ToString();
        }

        private void buttonEgg_Click(object sender, EventArgs e)
        {
            food.Side();
            if (User.food4[22] != 0)
                food2[22]++;
            textBox1.Text = "";
            food.SoldOut(22);
            for (int i = 0; i < 27; i++)
            {
                if (food2[i] != 0)
                {
                    textBox1.Text += food1[i] + "   " + food2[i] + "개" + Environment.NewLine;
                }

            }
            ssum = food.Price;
            sum.Text = ssum.ToString();
        }

        private void buttonDduk_Click(object sender, EventArgs e)
        {
            food.Side();
            if (User.food4[23] != 0)
                food2[23]++;
            textBox1.Text = "";
            food.SoldOut(23);
            for (int i = 0; i < 27; i++)
            {
                if (food2[i] != 0)
                {
                    textBox1.Text += food1[i] + "   " + food2[i] + "개" + Environment.NewLine;
                }

            }
            ssum = food.Price;
            sum.Text = ssum.ToString();

        }

        private void buttonMozzarellaCheese_Click(object sender, EventArgs e)
        {
            food.Side();
            if (User.food4[24] != 0)
                food2[24]++;
            textBox1.Text = "";
            food.SoldOut(24);
            for (int i = 0; i < 27; i++)
            {
                if (food2[i] != 0)
                {
                    textBox1.Text += food1[i] + "   " + food2[i] + "개" + Environment.NewLine;
                }

            }
            ssum = food.Price;
            sum.Text = ssum.ToString();

        }

        private void buttonChedaCheese_Click(object sender, EventArgs e)
        {
            food.Side();
            if (User.food4[25] != 0)
                food2[25]++;

            textBox1.Text = "";
            food.SoldOut(25);
            for (int i = 0; i < 27; i++)
            {
                if (food2[i] != 0)
                {
                    textBox1.Text += food1[i] + "   " + food2[i] + "개" + Environment.NewLine;
                }

            }
            ssum = food.Price;
            sum.Text = ssum.ToString();

        }

        private void buttonRice_Click(object sender, EventArgs e)
        {
            food.Side();
            if (User.food4[26] != 0)
                food2[26]++;
            textBox1.Text = "";
            food.SoldOut(26);
            for (int i = 0; i < 27; i++)
            {
                if (food2[i] != 0)
                {
                    textBox1.Text += food1[i] + "   " + food2[i] + "개" + Environment.NewLine;
                }


            }
            ssum = food.Price;
            sum.Text = ssum.ToString();

        }


        // 소켓 프로그래밍
        private void Log (string msg)
        {
            listBox1.Items.Add(string.Format("[{0}]{1}",DateTime.Now.ToString(),msg));
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            Log("클라이언트 로드 됨");
            //IPAddress ipaddress = IPAddress.Parse(textBoxIP.Text);
            IPAddress ipaddress = IPAddress.Parse("127.0.0.1");
            //IPEndPoint endPoint = new IPEndPoint(ipaddress,int.Parse(textBoxPort.Text));
            IPEndPoint endPoint = new IPEndPoint(ipaddress, 25101);

            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            Log("서버에 연결 시도중...");
            socket.Connect(endPoint);
            Log("서버에 접속됨");

            receiveThread = new Thread(new ThreadStart(Receive));
            receiveThread.IsBackground = true;
            receiveThread.Start();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text.Trim() != "" || textBox1.Text.Trim() !="")
            {
                byte[] sendBuffer = Encoding.UTF8.GetBytes(textBoxInput.Text.Trim() + "\r\n" + textBox1.Text + "\r" + "누적 " +
                    "금액 :" + ssum+"원" );

                socket.Send(sendBuffer);
                Log("메시지 전송됨");
                ShowMsg(textBoxInput.Text);
                textBoxInput.Text = "";
                MessageBox.Show("주문이 성공적으로 처리되었습니다.");
                food2 = Enumerable.Repeat<int>(0, 30).ToArray();
                textBox1.Text = "";

                if (hour1 != 0)
                    time.Duration += 3600;
                if (hour2 != 0)
                    time.Duration += 7200;
                if (hour5 != 0)
                    time.Duration += 18000;
                hour1 = 0;
                hour2 = 0;
                hour5 = 0;
            }

        }

        private void Receive()
        {
            while (true)
            {
                byte[] receiveBuffer = new byte[512];
                int length = socket.Receive(receiveBuffer, receiveBuffer.Length, SocketFlags.None);
                string msg = Encoding.UTF8.GetString(receiveBuffer,0,length);
                ShowMsg("상대]" + msg);
         
            }
        }
        private void ShowMsg(string msg)
        {
            textBoxRict.AppendText(msg);
            textBoxRict.AppendText("\r\n");

            this.Activate();
            textBoxRict.Focus();

            textBoxRict.SelectionStart = textBoxRict.Text.Length;
            textBoxRict.ScrollToCaret();
        }
        private void sum_Click(object sender, EventArgs e)
		{

		}

		private void Food_Click(object sender, EventArgs e)
		{

		}

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (time.Duration > 0)
            {
                labelTime.Text = "남은 시간 : " + dt.AddSeconds(time.Duration).ToString("HH:mm:ss");

            }
            else
            {
                labelTime.Text = time.Duration.ToString();
                timer1.Stop();
            }
                
            time.Count_down();
        }

        private void buttonHour2_Click(object sender, EventArgs e)
        {
            hour2 += 1;
            if (hour2 >= 2)
            {
                hour2 = 1;
                MessageBox.Show("담을 수 있는 최대 수량은 1개 입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                textBox1.Text += "2 시간" + Environment.NewLine;
                time.Price_cal(5000);
                ssum = time.Price;
                sum.Text = ssum.ToString();
            }
        }

        private void buttonHour5_Click(object sender, EventArgs e)
        {
            hour5 += 1;
            if (hour5 >= 2)
            {
                hour5 = 1;
                MessageBox.Show("담을 수 있는 최대 수량은 1개 입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                textBox1.Text += "5 시간" + Environment.NewLine;
                time.Price_cal(5000);
                ssum = time.Price;
                sum.Text = ssum.ToString();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if(textBox2.Text.Trim() !="" && e.KeyCode == Keys.Enter)
            {
                byte[] sendBuffer = Encoding.UTF8.GetBytes(textBox2.Text.Trim());
                socket.Send(sendBuffer);
                Log("메시지 전송됨");
                ShowMsg("나]" + textBox2.Text);
                textBox2.Text = "";
                textBox2.Focus();
            }
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 5;
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("종료하시겠습니까?", "사용 종료", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if(dr == DialogResult.OK)
            {
                socket.Close();
                Application.Exit();
            }
        }

        private void buttonHour1_Click(object sender, EventArgs e)
        {
            hour1 += 1;
            if (hour1>= 2)
            {
                hour1 = 1;
                MessageBox.Show("담을 수 있는 최대 수량은 1개 입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                    textBox1.Text += "1 시간" + Environment.NewLine;
                    time.Price_cal(1500);
                ssum = time.Price;
                sum.Text = ssum.ToString();
            }
        }
    }
}
