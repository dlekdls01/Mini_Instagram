using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using _2015726044_이다인_library;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace _2015726044_이다인
{
    public partial class Server : Form
    {
        int indexnum = 0, lvwIndex=0;
        string path;

        bool clientOn = false;
        TcpListener listener = null;
        TcpClient client;
        NetworkStream stream;
        Thread thread;

        public Login login;
        public LoginResult loginResult;
        public MemberRegister memRegister;
        public MemberRegisterResult memRegResult;

        private void setLog(string msg)
        {
            this.BeginInvoke((MethodInvoker)delegate{
                textBox1.AppendText(msg + "\n");
            });
        }
        public Server()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IPHostEntry iPHost = Dns.GetHostByName(Dns.GetHostName());
            textBox_ip.Text = iPHost.AddressList[0].ToString();
            listView1.View = View.Details;
            listView1.Columns.Add("Index",60);
            listView1.Columns.Add("ID",100);
            listView1.Columns.Add("Password",100);
            
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if (string.Equals(textBox_ip.Text, string.Empty))
            {
                MessageBox.Show("IP를 입력해주세요");
                return;
            }
            if (string.Equals(textBox_port.Text, string.Empty))
            {
                MessageBox.Show("Port를 입력해주세요");
                return;
            }
            if(button_start.Text == "Start")
            {
                path = Environment.CurrentDirectory;
                DirectoryInfo dir = new DirectoryInfo(path+"//serverStore");
                dir.Create(); 

                thread = new Thread(StartServer);
                thread.IsBackground = true;
                thread.Start();
                textBox1.AppendText("Server - Start\n");
                textBox1.AppendText("Storage Path :" + path+"\n");

                button_start.Text = "Stop";
                button_start.ForeColor = Color.Red;
            }
            else
            {
                listener.Stop();
                thread.Abort();
                button_start.Text = "Start";
                button_start.ForeColor = Color.Black;
            }
        }
        public void StartServer()
        {
            listener = new TcpListener(Convert.ToInt32(textBox_port.Text));
            listener.Start();
            
                byte[] buffer = new byte[1024 * 4];
                string data = string.Empty;
            if (!clientOn) 
                setLog("Waiting for client access...");
            client = listener.AcceptTcpClient();
            if (client.Connected)
            {
                clientOn = true;
                setLog("Client access!");
                data = string.Empty;
                stream = client.GetStream();
            }
            int nRead = 0;
                
            while(clientOn)
            {
                try
                {
                    nRead = 0;
                    nRead = stream.Read(buffer, 0, buffer.Length);
                }
                catch
                {
                    clientOn = false;
                    stream = null;
                }

                Class1 packet = (Class1)Class1.Desserialize(buffer);
                if (packet == null) return;
                switch ((int)packet.type)
                {
                    case (int)PacketType.Login:

                        login = (Login)Class1.Desserialize(buffer);
                        loginResult = new LoginResult();
                        loginResult.type = (int)PacketType.Login_Result;

                        if (SearchListview(login.id, login.pw) == 1)
                        {
                            loginResult.result = true;
                            loginResult.reason = "정상적으로 로그인 되었습니다";
                            loginResult.serverPath = path + "//serverStore";
                            setLog(login.id + ">> Log in");
                        }
                        else
                        {
                            loginResult.result = false;
                            loginResult.reason = "ID 또는 PW가 잘못되었습니다.\n계정이 없다면 회원가입 버튼을 통해 계정을 만드십시오!";
                        }
                        Array.Clear(buffer, 0, buffer.Length);
                        Class1.Serialize(loginResult).CopyTo(buffer, 0);
                        stream.Write(buffer, 0, buffer.Length);
                        break;

                    case (int)PacketType.Member_Register:
                        memRegister = (MemberRegister)Class1.Desserialize(buffer);
                        memRegResult = new MemberRegisterResult();
                        memRegResult.type = (int)PacketType.Member_Register_Result;

                        if (SearchListview(memRegister.id, memRegister.pw) == 3)
                        {
                            memRegResult.result = true;
                            memRegResult.reason = "회원가입이 정상적으로 완료되었습니다 !";
                            setLog(memRegister.id + ">> Join");

                            lvwIndex++;
                            string[] arr = new string[3];
                            arr[0] = lvwIndex.ToString();
                            arr[1] = memRegister.id;
                            arr[2] = memRegister.pw;
                            ListViewItem i = new ListViewItem(arr);
                            listView1.Items.Add(i);
                        }
                        else
                        {
                            memRegResult.result = false;
                            memRegResult.reason = "이미 사용중인 ID 입니다.";
                        }
                        Array.Clear(buffer, 0, buffer.Length);
                        Class1.Serialize(memRegResult).CopyTo(buffer, 0);
                        stream.Write(buffer, 0, buffer.Length);
                        break;
                            
                            
                    }
                }//while
            client.Close();
            stream.Close();
            
        }
        public int SearchListview(string id, string pw)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
                if (id == listView1.Items[i].SubItems[1].Text)
                {
                    if (pw == listView1.Items[i].SubItems[2].Text)
                    {
                        indexnum = i;
                        return 1;  //로그인성공
                    }
                    return 2;  //비번안맞
                }
            return 3; //로그인실패 아이디없어
        }
    }
}
