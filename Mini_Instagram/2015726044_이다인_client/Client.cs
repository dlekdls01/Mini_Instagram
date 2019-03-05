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

namespace _2015726044_이다인_client
{
    public partial class Client : Form
    {

        NetworkStream stream;
        TcpClient client;
        
        bool ConnectOn = false;
        string path;
        int fileNum = 1;

        public Login login;
        public LoginResult loginResult;
        public MemberRegister memRegister;
        public MemberRegisterResult memRegResult;

        public Client()
        {
            InitializeComponent();
        }
        private void Client_Load(object sender, EventArgs e)
        {
            panel1.Parent = this;
            panel2.Parent = this;
            panel3.Parent = this;
            panel4.Parent = this;
            tableLayoutPanel4.Parent = panel4;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;

            textBox_id.Enabled = false;
            textBox_pw.Enabled = false;
            button_login.Enabled = false;
            button_회원가입.Enabled = false; 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;

            pictureBox1.BackColor = Color.LightSkyBlue;
            pictureBox2.BackColor = Color.Empty;
            pictureBox3.BackColor = Color.Empty;
            pictureBox4.BackColor = Color.Empty;
            

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;

            pictureBox1.BackColor = Color.Empty;
            pictureBox2.BackColor = Color.LightSkyBlue;
            pictureBox3.BackColor = Color.Empty;
            pictureBox4.BackColor = Color.Empty;
        }
         private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;

            pictureBox1.BackColor = Color.Empty;
            pictureBox2.BackColor = Color.Empty;
            pictureBox3.BackColor = Color.LightSkyBlue;
            pictureBox4.BackColor = Color.Empty;
            
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            button4_수정.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;

            pictureBox1.BackColor = Color.Empty;
            pictureBox2.BackColor = Color.Empty;
            pictureBox3.BackColor = Color.Empty;
            pictureBox4.BackColor = Color.LightSkyBlue;

            if (path != null)
            {
                tableLayoutPanel4.Controls.Clear();
                tableLayoutPanel4.RowCount = 0;
                DirectoryInfo dir = new DirectoryInfo(path + "//" + textBox_id.Text.Trim());
                FileInfo[] f = dir.GetFiles("*.jpg");
                string[] str = new string[f.Length];
                for (int i = 0; i < f.Length; i++)
                    str[i] = f[i].FullName;
                Array.Sort(str);
                for (int i = 0; i < f.Length; i++)
                {
                    //    if ((i % 3 == 0) && (i != 0))
                    //      tableLayoutPanel4.RowCount++;
                    PictureBox pcB = new PictureBox();
                    pcB.Load(str[i]);
                    pcB.SizeMode = PictureBoxSizeMode.StretchImage;
                    tableLayoutPanel4.Controls.Add(pcB, 0, 0);

                }
                label4_숫자.Text = f.Length.ToString();
            }

        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            if (button_connect.Text == "Connect")
            {
                client = new TcpClient();
                try
                {
                    client.Connect(textBox_ip.Text, Convert.ToInt32(textBox_port.Text));
                }
                catch
                {
                    MessageBox.Show("접속에러");
                    return;
                }
                button_connect.Text = "Deconnect";
                button_connect.ForeColor = Color.Red;
                textBox_id.Enabled = true;
                textBox_pw.Enabled = true;
                button_login.Enabled = true;
                button_회원가입.Enabled = true;
                textBox_ip.Enabled = false;
                textBox_port.Enabled = false;

                ConnectOn = true;
                stream = client.GetStream();
            }
            else
            {
                textBox_id.Enabled = false;
                textBox_pw.Enabled = false;
                button_login.Enabled = false;
                button_회원가입.Enabled = false;
                textBox_ip.Enabled = true;
                textBox_port.Enabled = true;

                ConnectOn = false;
                button_connect.Text = "Connect";
                button_connect.ForeColor = Color.Black;
                client.Close();
                stream.Close();
            }
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (button_login.Text == "로그인")
            {
                if ((string.Equals(textBox_id.Text, string.Empty)) || (string.Equals(textBox_pw.Text, string.Empty)))
                    MessageBox.Show("ID 또는 Password를 입력해주세요.");
                byte[] buffer = new byte[1024 * 4];
                login = new Login();
                login.type = (int)PacketType.Login;
                login.id = textBox_id.Text.Trim();
                login.pw = textBox_pw.Text.Trim();

                Class1.Serialize(login).CopyTo(buffer, 0);
                stream.Write(buffer, 0, buffer.Length);

                Array.Clear(buffer, 0, buffer.Length);
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                loginResult = (LoginResult)Class1.Desserialize(buffer);

                if (loginResult.result)
                {
                    MessageBox.Show(loginResult.reason, "", MessageBoxButtons.OK);
                    button_login.Text = "로그아웃";
                    button_login.ForeColor = Color.Red;
                    listBox2.Items.Remove(login.id);

                    path = loginResult.serverPath;
                    DirectoryInfo dir = new DirectoryInfo(path + "//"+ textBox_id.Text.Trim()); //id로폴더만듬
                    dir.Create();

                    
                }
                else
                    MessageBox.Show(loginResult.reason, "", MessageBoxButtons.OK);
            }
            else
            {
                button_login.Text = "로그인";
                button_login.ForeColor = Color.Black;
                listBox2.Items.Add(login.id);
                listBox2.Visible = true;
                listBox2_찾은후.Visible = false;
                label4_숫자.Text = "0";
                fileNum = 1;
                tableLayoutPanel4.Controls.Clear();
            }
            
        }

        private void button_회원가입_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[1024 * 4];
            memRegister = new MemberRegister();
            memRegister.type = (int)PacketType.Member_Register;
            memRegister.id = textBox_id.Text.Trim();
            memRegister.pw = textBox_pw.Text.Trim();

            Class1.Serialize(memRegister).CopyTo(buffer, 0);
            stream.Write(buffer, 0, buffer.Length);

            Array.Clear(buffer, 0, buffer.Length);
            int bytesRead = stream.Read(buffer, 0, buffer.Length);
            memRegResult = (MemberRegisterResult)Class1.Desserialize(buffer);

            if (memRegResult.result)
            {
                MessageBox.Show(memRegResult.reason, "", MessageBoxButtons.OK);
                listBox2.Items.Add(memRegister.id);
                
            }
            else
                MessageBox.Show(memRegResult.reason, "", MessageBoxButtons.OK);
            
        }


        private void button2_찾기_Click(object sender, EventArgs e)
        {
            listBox2_찾은후.Items.Clear();
            string[] arr = new string[listBox2.Items.Count];
            int j = 0;
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                string str = listBox2.Items[i].ToString();
                if (str.Contains(textBox2_search.Text))
                {
                    arr[j] = str;
                    j++;
                }
            }
            for (int i = 0; i < j; i++)
                listBox2_찾은후.Items.Add(arr[i]);
            listBox2.Visible = false;
            listBox2_찾은후.Visible = true;
        }

        private void button3_찾기_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox3_찾기.Text = openFileDialog1.FileName;
                pictureBox3_업로드.Visible = true;
                pictureBox3_업로드.Load(textBox3_찾기.Text);
                pictureBox3_업로드.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void button3_등록_Click(object sender, EventArgs e)
        {
            if (string.Equals(textBox3_찾기.Text,string.Empty))
                MessageBox.Show("업로드할 사진을 선택하세요.", "", MessageBoxButtons.OK);
            else
            {
                pictureBox3_업로드.Image.Save(path + "//" + textBox_id.Text.Trim() + "//image"+fileNum+".jpg");
                //File.Create(path + "//" + textBox_id.Text.Trim() + "//text"+fileNum+".txt");
                File.WriteAllText(path + "//" + textBox_id.Text.Trim() + "//text" + fileNum + ".txt", textBox3.Text);
                MessageBox.Show("성공적으로 업로드하였습니다! 마이페이지에서 확인하십시오.");

    /*            if (fileNum % 3 == 0)
                    tableLayoutPanel4.RowCount++;
                PictureBox pcB = new PictureBox();
                pcB.Load(path + "//" + textBox_id.Text.Trim() + "//image" + fileNum + ".jpg");
                pcB.SizeMode = PictureBoxSizeMode.StretchImage;
                tableLayoutPanel4.Controls.Add(pcB,0,0);
                label4_숫자.Text = fileNum.ToString();*/

                textBox3_찾기.Text = "";
                pictureBox3_업로드.Visible = false;
                textBox3.Text = "";
                fileNum++;
            }
        }

        private void listBox2_찾은후_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void listBox2_찾은후_DoubleClick(object sender, EventArgs e)
        {
            if (listBox2_찾은후.SelectedItem != null)
            {

                panel2.Visible = false;
                panel4.Visible = true;
                button4_수정.Visible = false;

                string id = listBox2_찾은후.SelectedItem.ToString();
                tableLayoutPanel4.Controls.Clear();
                tableLayoutPanel4.RowCount = 0;
                DirectoryInfo dir = new DirectoryInfo(path + "//" + id);
                FileInfo[] f = dir.GetFiles("*.jpg");
                string[] str = new string[f.Length];
                for (int i = 0; i < f.Length; i++)
                    str[i] = f[i].FullName;
                Array.Sort(str);
                for (int i = 0; i < f.Length; i++)
                {
                    //    if ((i % 3 == 0) && (i != 0))
                    //      tableLayoutPanel4.RowCount++;
                    PictureBox pcB = new PictureBox();
                    pcB.Load(str[i]);
                    pcB.SizeMode = PictureBoxSizeMode.StretchImage;
                    tableLayoutPanel4.Controls.Add(pcB, 0, 0);

                }
                label4_숫자.Text = f.Length.ToString();

                pictureBox1.BackColor = Color.Empty;
                pictureBox2.BackColor = Color.Empty;
                pictureBox3.BackColor = Color.Empty;
                pictureBox4.BackColor = Color.LightSkyBlue;
            }
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {

                panel2.Visible = false;
                panel4.Visible = true;
                button4_수정.Visible = false;

                string id = listBox2.SelectedItem.ToString();
                tableLayoutPanel4.Controls.Clear();
                tableLayoutPanel4.RowCount = 0;
                DirectoryInfo dir = new DirectoryInfo(path + "//" + id);
                FileInfo[] f = dir.GetFiles("*.jpg");
                string[] str = new string[f.Length];
                for (int i = 0; i < f.Length; i++)
                    str[i] = f[i].FullName;
                Array.Sort(str);
                for (int i = 0; i < f.Length; i++)
                {
                    //    if ((i % 3 == 0) && (i != 0))
                    //      tableLayoutPanel4.RowCount++;
                    PictureBox pcB = new PictureBox();
                    pcB.Load(str[i]);
                    pcB.SizeMode = PictureBoxSizeMode.StretchImage;
                    tableLayoutPanel4.Controls.Add(pcB, 0, 0);

                }
                label4_숫자.Text = f.Length.ToString();

                pictureBox1.BackColor = Color.Empty;
                pictureBox2.BackColor = Color.Empty;
                pictureBox3.BackColor = Color.Empty;
                pictureBox4.BackColor = Color.LightSkyBlue;
            }
        }
    }
}
