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
    public partial class FormAdmin : Form
    {
        private string ip = "127.0.0.1";
        private int port = 25101;
        private Thread listenThread;
        private Thread receiveThread;
        private Socket clientSocket;
        Admin admin = new Admin();
       
        
        public FormAdmin()
        {
            InitializeComponent();
            labelseau.Text = User.food4[0].ToString();
            labelPeanut.Text = User.food4[1].ToString();
            labelShort.Text = User.food4[2].ToString();
            labelSsun.Text = User.food4[3].ToString();
            labelOGam.Text = User.food4[4].ToString();
            labelOzip.Text = User.food4[5].ToString();
            labelPote.Text = User.food4[6].ToString();
            labelTorna.Text = User.food4[7].ToString();
            labelRamen.Text = User.food4[8].ToString();
            labelCupramen.Text = User.food4[9].ToString();
            labelShrimp.Text = User.food4[10].ToString();
            labelKimchi.Text = User.food4[11].ToString();
            labelChicken.Text = User.food4[12].ToString();
            labelHam.Text = User.food4[13].ToString();
            labelTuna.Text = User.food4[14].ToString();
            labelAme.Text = User.food4[15].ToString();
            labelLatte.Text = User.food4[16].ToString();
            labelCapu.Text = User.food4[17].ToString();
            labelMan.Text = User.food4[18].ToString();
            labelStraw.Text = User.food4[19].ToString();
            labelCola.Text = User.food4[20].ToString();
            labelCider.Text = User.food4[21].ToString();
            labelEgg.Text = User.food4[22].ToString();
            labelDduk.Text = User.food4[23].ToString();
            labelMozza.Text = User.food4[24].ToString();
            labelChe.Text = User.food4[25].ToString();
            labelRice.Text = User.food4[26].ToString();

        }
        private void Log(string msg)
        {
            listBox1.Items.Add(string.Format("[{0}]{1}",DateTime.Now.ToString(),msg));
        }
        

        private void buttonFoodA_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void buttonBeverageA_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void buttonSnackA_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void buttonSideA_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if(buttonStart.Text == "시작")
            {
                buttonStart.Text = "멈춤";
                Log("서버 시작됨");

                listenThread = new Thread(new ThreadStart(Listen));
                listenThread.IsBackground = true;

                listenThread.Start();
            }
            else
            {
                buttonStart.Text = "서버 실행";
                Log("서버 종료");
            }
        }

        private void Listen()
        {
            IPAddress ipaddress = IPAddress.Parse(ip);
            IPEndPoint endPoint = new IPEndPoint(ipaddress, port);

            Socket listenSocket = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp);
            listenSocket.Bind(endPoint);
            listenSocket.Listen(10);

            Log("클라이언트 요청 대기중..");

            clientSocket = listenSocket.Accept();

            Log("클라이언트 접속됨 - " + clientSocket.LocalEndPoint.ToString());

            receiveThread = new Thread(new ThreadStart(Receive));
            receiveThread.IsBackground = true;
            receiveThread.Start();
        }

        private void Receive()
        {
            
            while (true)
            
            {

                byte[] receiveBuffer = new byte[512];
                int length = clientSocket.Receive(receiveBuffer,receiveBuffer.Length,SocketFlags.None);

                string msg = Encoding.UTF8.GetString(receiveBuffer);
                

                Showmsg("[손님]\r" + msg);
                Log("메시지 수신함");
                for (int i = 0; i <= 10; i++)
                {
                    if (msg.Contains("새우깡   " + i))
                    {
                        User.food4[0] -= i;
                        if (User.food4[0] <= 0)
                        {
                            admin.SoldOut(0);
                            labelseau.Text = "품절";
                        }
                    }
                    else
                        labelseau.Text = User.food4[0].ToString();
                    if (msg.Contains("땅콩   " + i))
                    {
                        User.food4[1] -= i;
                        if (User.food4[1] <= 0)
                        {
                            admin.SoldOut(1);
                            labelPeanut.Text = "품절";
                        }
                    }
                    else
                        labelPeanut.Text = User.food4[1].ToString();
                    if (msg.Contains("숏다리   " + i))
                    {
                        User.food4[2] -= i;
                        if (User.food4[2] <= 0)
                        {
                            admin.SoldOut(2);
                            labelShort.Text = "품절";
                        }
                    }
                    else
                        labelShort.Text = User.food4[2].ToString();
                    if (msg.Contains("썬칩   " + i))
                    {
                        User.food4[3] -= i;
                        if (User.food4[3] <= 0)
                        {
                            admin.SoldOut(3);
                            labelSsun.Text = "품절";
                        }
                    }
                    else
                        labelSsun.Text = User.food4[3].ToString();
                    if (msg.Contains("오감자   " + i))
                    {
                        User.food4[4] -= i;
                        if (User.food4[4] <= 0)
                        {
                            admin.SoldOut(4);
                            labelOGam.Text = "품절";
                        }
                    }
                    else
                        labelOGam.Text = User.food4[4].ToString();
                    if (msg.Contains("오징어집   " + i))
                    {
                        User.food4[5] -= i;
                        if (User.food4[5] <= 0)
                        {
                            admin.SoldOut(5);
                            labelOzip.Text = "품절";
                        }
                    }
                    else
                        labelOzip.Text = User.food4[5].ToString();
                    if (msg.Contains("포테토칩   " + i))
                    {
                        User.food4[6] -= i;
                        if (User.food4[6] <= 0)
                        {
                            admin.SoldOut(6);
                            labelPote.Text = "품절";
                        }
                    }
                    else
                        labelPote.Text = User.food4[6].ToString();
                    if (msg.Contains("회오리감자   " + i))
                    {
                        User.food4[7] -= i;
                        if (User.food4[7] <= 0)
                        {
                            admin.SoldOut(7);
                            labelTorna.Text = "품절";
                        }
                    }
                    else
                        labelTorna.Text = User.food4[7].ToString();
                    if (msg.Contains("신라면   " + i))
                    {
                        User.food4[8] -= i;
                        if (User.food4[8] <= 0)
                        {
                            admin.SoldOut(8);
                            labelRamen.Text = "품절";
                        }
                    }
                    else
                        labelRamen.Text = User.food4[8].ToString();
                    if (msg.Contains("컵라면   " + i))
                    {
                        User.food4[9] -= i;
                        if (User.food4[9] <= 0)
                        {
                            admin.SoldOut(9);
                            labelCupramen.Text = "품절";
                        }
                    }
                    else
                        labelCupramen.Text = User.food4[9].ToString();
                    if (msg.Contains("새우볶음밥   " + i))
                    {
                        User.food4[10] -= i;
                        if (User.food4[10] <= 0)
                        {
                            admin.SoldOut(10);
                            labelShrimp.Text = "품절";
                        }
                    }
                    else
                        labelShrimp.Text = User.food4[10].ToString();
                    if (msg.Contains("김치볶음밥   " + i))
                    {
                        User.food4[11] -= i;
                        if (User.food4[11] <= 0)
                        {
                            admin.SoldOut(11);
                            labelKimchi.Text = "품절";
                        }
                    }
                    else
                        labelKimchi.Text = User.food4[11].ToString();
                    if (msg.Contains("닭가슴살볶음밥   " + i))
                    {
                        User.food4[12] -= i;
                        if (User.food4[12] <= 0)
                        {
                            admin.SoldOut(12);
                            labelChicken.Text = "품절";
                        }
                    }
                    else
                        labelChicken.Text = User.food4[12].ToString();
                    if (msg.Contains("햄야채볶음밥   " + i))
                    {
                        User.food4[13] -= i;
                        if (User.food4[13] <= 0)
                        {
                            admin.SoldOut(13);
                            labelHam.Text = "품절";
                        }
                    }
                    else
                        labelHam.Text = User.food4[13].ToString();
                    if (msg.Contains("참치마요볶음밥   " + i))
                    {
                        User.food4[14] -= i;
                        if (User.food4[14] <= 0)
                        {
                            admin.SoldOut(14);
                            labelTuna.Text = "품절";
                        }
                    }
                    else
                        labelTuna.Text = User.food4[14].ToString();
                    if (msg.Contains("아메리카노   " + i))
                    {
                        User.food4[15] -= i;
                        if (User.food4[15] <= 0)
                        {
                            admin.SoldOut(15);
                            labelAme.Text = "품절";
                        }
                    }
                    else
                        labelAme.Text = User.food4[15].ToString();
                    if (msg.Contains("카페라떼   " + i))
                    {
                        User.food4[16] -= i;
                        if (User.food4[16] <= 0)
                        {
                            admin.SoldOut(16);
                            labelLatte.Text = "품절";
                        }
                    }
                    else
                        labelLatte.Text = User.food4[16].ToString();
                    if (msg.Contains("카푸치노   " + i))
                    {
                        User.food4[17] -= i;
                        if (User.food4[17] <= 0)
                        {
                            admin.SoldOut(17);
                            labelCapu.Text = "품절";
                        }
                    }
                    else
                        labelCapu.Text = User.food4[17].ToString();
                    if (msg.Contains("망고스무디   " + i))
                    {
                        User.food4[18] -= i;
                        if (User.food4[18] <= 0)
                        {
                            admin.SoldOut(18);
                            labelMan.Text = "품절";
                        }
                    }
                    else
                        labelMan.Text = User.food4[18].ToString();
                    if (msg.Contains("딸기스무디   " + i))
                    {
                        User.food4[19] -= i;
                        if (User.food4[19] <= 0)
                        {
                            admin.SoldOut(19);
                            labelStraw.Text = "품절";
                        }
                    }
                    else
                        labelStraw.Text = User.food4[19].ToString();
                    if (msg.Contains("콜라   " + i))
                    {
                        User.food4[20] -= i;
                        if (User.food4[20] <= 0)
                        {
                            admin.SoldOut(20);
                            labelCola.Text = "품절";
                        }
                    }
                    else
                        labelCola.Text = User.food4[20].ToString();
                    if (msg.Contains("사이다   " + i))
                    {
                        User.food4[21] -= i;
                        if (User.food4[21] <= 0)
                        {
                            admin.SoldOut(21);
                            labelCider.Text = "품절";
                        }
                    }
                    else
                        labelCider.Text = User.food4[21].ToString();
                    if (msg.Contains("계란   " + i))
                    {
                        User.food4[22] -= i;
                        if (User.food4[22] <= 0)
                        {
                            admin.SoldOut(22);
                            labelEgg.Text = "품절";
                        }
                    }
                    else
                        labelEgg.Text = User.food4[22].ToString();
                    if (msg.Contains("떡   " + i))
                    {
                        User.food4[23] -= i;
                        if (User.food4[23] <= 0)
                        {
                            admin.SoldOut(23);
                            labelDduk.Text = "품절";
                        }
                    }
                    else
                        labelDduk.Text = User.food4[23].ToString();
                    if (msg.Contains("모짜렐라치즈   " + i))
                    {
                        User.food4[24] -= i;
                        if (User.food4[24] <= 0)
                        {
                            admin.SoldOut(24);
                            labelMozza.Text = "품절";
                        }
                    }
                    else
                        labelMozza.Text = User.food4[24].ToString();
                    if (msg.Contains("체다치즈   " + i))
                    {
                        User.food4[25] -= i;
                        if (User.food4[25] <= 0)
                        {
                            admin.SoldOut(25);
                            labelChe.Text = "품절";
                        }
                    }
                    else
                        labelChe.Text = User.food4[25].ToString();
                    if (msg.Contains("밥   " + i))
                    {
                        User.food4[26] -= i;
                        if (User.food4[26] <= 0)
                        {
                            admin.SoldOut(26);
                            labelRice.Text = "품절";
                        }
                    }
                    else
                        labelRice.Text = User.food4[26].ToString();


                }
                
            }
        }

        private void Showmsg(string msg)
        {
            textBoxRict.AppendText(msg);
            textBoxRict.AppendText("\r\n");
            this.Activate();
            
            textBoxRict.SelectionStart = textBoxRict.Text.Length;
            textBoxRict.ScrollToCaret();
           
        }
        Admin ad=new Admin();
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(textBox1.Text.Trim()!=""&& e.KeyCode == Keys.Enter)
            {
                byte[] sendBuffer = Encoding.UTF8.GetBytes(textBox1.Text.Trim());
                clientSocket.Send(sendBuffer);
                Log("메시지 전송됨");
                Showmsg("[카운터] " + textBox1.Text);
                textBox1.Text = "";
                
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
