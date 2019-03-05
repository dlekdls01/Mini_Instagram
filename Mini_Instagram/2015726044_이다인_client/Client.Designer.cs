namespace _2015726044_이다인_client
{
    partial class Client
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_connect = new System.Windows.Forms.Button();
            this.button_login = new System.Windows.Forms.Button();
            this.textBox_pw = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_회원가입 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox2_찾은후 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button2_찾기 = new System.Windows.Forms.Button();
            this.textBox2_search = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3_등록 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pictureBox3_업로드 = new System.Windows.Forms.PictureBox();
            this.textBox3_찾기 = new System.Windows.Forms.TextBox();
            this.button3_찾기 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button4_리스트 = new System.Windows.Forms.Button();
            this.button4_바둑판 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4_숫자 = new System.Windows.Forms.Label();
            this.label4_게시물 = new System.Windows.Forms.Label();
            this.button4_수정 = new System.Windows.Forms.Button();
            this.pictureBox4_profile = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3_업로드)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4_profile)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 7F);
            this.label1.Location = new System.Drawing.Point(57, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP:";
            // 
            // textBox_ip
            // 
            this.textBox_ip.Location = new System.Drawing.Point(88, 17);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(168, 28);
            this.textBox_ip.TabIndex = 1;
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(88, 54);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(168, 28);
            this.textBox_port.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 7F);
            this.label2.Location = new System.Drawing.Point(39, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port:";
            // 
            // button_connect
            // 
            this.button_connect.Font = new System.Drawing.Font("굴림", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_connect.Location = new System.Drawing.Point(263, 17);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(78, 65);
            this.button_connect.TabIndex = 4;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // button_login
            // 
            this.button_login.Font = new System.Drawing.Font("굴림", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_login.Location = new System.Drawing.Point(263, 151);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(78, 65);
            this.button_login.TabIndex = 9;
            this.button_login.Text = "로그인";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // textBox_pw
            // 
            this.textBox_pw.Location = new System.Drawing.Point(88, 188);
            this.textBox_pw.Name = "textBox_pw";
            this.textBox_pw.Size = new System.Drawing.Size(168, 28);
            this.textBox_pw.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(4, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password :";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(88, 151);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(168, 28);
            this.textBox_id.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 7F);
            this.label4.Location = new System.Drawing.Point(61, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 8F);
            this.label5.Location = new System.Drawing.Point(61, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "아직 계정이 없나요?";
            // 
            // button_회원가입
            // 
            this.button_회원가입.Font = new System.Drawing.Font("굴림", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_회원가입.Location = new System.Drawing.Point(217, 238);
            this.button_회원가입.Name = "button_회원가입";
            this.button_회원가입.Size = new System.Drawing.Size(87, 31);
            this.button_회원가입.TabIndex = 11;
            this.button_회원가입.Text = "회원가입";
            this.button_회원가입.UseVisualStyleBackColor = true;
            this.button_회원가입.Click += new System.EventHandler(this.button_회원가입_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::_2015726044_이다인_client.Properties.Resources.button_mypage;
            this.pictureBox4.Location = new System.Drawing.Point(699, 479);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::_2015726044_이다인_client.Properties.Resources.button_upload;
            this.pictureBox3.Location = new System.Drawing.Point(611, 478);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::_2015726044_이다인_client.Properties.Resources.button_search;
            this.pictureBox2.Location = new System.Drawing.Point(523, 479);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_2015726044_이다인_client.Properties.Resources.button_home;
            this.pictureBox1.Location = new System.Drawing.Point(441, 479);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listBox2_찾은후);
            this.panel2.Controls.Add(this.listBox2);
            this.panel2.Controls.Add(this.button2_찾기);
            this.panel2.Controls.Add(this.textBox2_search);
            this.panel2.Location = new System.Drawing.Point(367, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 455);
            this.panel2.TabIndex = 16;
            // 
            // listBox2_찾은후
            // 
            this.listBox2_찾은후.FormattingEnabled = true;
            this.listBox2_찾은후.ItemHeight = 18;
            this.listBox2_찾은후.Location = new System.Drawing.Point(12, 44);
            this.listBox2_찾은후.Name = "listBox2_찾은후";
            this.listBox2_찾은후.Size = new System.Drawing.Size(429, 400);
            this.listBox2_찾은후.TabIndex = 3;
            this.listBox2_찾은후.Visible = false;
            this.listBox2_찾은후.DoubleClick += new System.EventHandler(this.listBox2_찾은후_DoubleClick);
            this.listBox2_찾은후.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox2_찾은후_MouseDoubleClick);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 18;
            this.listBox2.Location = new System.Drawing.Point(12, 44);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(429, 400);
            this.listBox2.TabIndex = 2;
            this.listBox2.DoubleClick += new System.EventHandler(this.listBox2_DoubleClick);
            // 
            // button2_찾기
            // 
            this.button2_찾기.Location = new System.Drawing.Point(365, 6);
            this.button2_찾기.Name = "button2_찾기";
            this.button2_찾기.Size = new System.Drawing.Size(76, 28);
            this.button2_찾기.TabIndex = 1;
            this.button2_찾기.Text = "찾기";
            this.button2_찾기.UseVisualStyleBackColor = true;
            this.button2_찾기.Click += new System.EventHandler(this.button2_찾기_Click);
            // 
            // textBox2_search
            // 
            this.textBox2_search.Location = new System.Drawing.Point(12, 6);
            this.textBox2_search.Name = "textBox2_search";
            this.textBox2_search.Size = new System.Drawing.Size(347, 28);
            this.textBox2_search.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.button3_등록);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.pictureBox3_업로드);
            this.panel3.Controls.Add(this.textBox3_찾기);
            this.panel3.Controls.Add(this.button3_찾기);
            this.panel3.Location = new System.Drawing.Point(367, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(454, 455);
            this.panel3.TabIndex = 17;
            // 
            // button3_등록
            // 
            this.button3_등록.Location = new System.Drawing.Point(12, 411);
            this.button3_등록.Name = "button3_등록";
            this.button3_등록.Size = new System.Drawing.Size(429, 32);
            this.button3_등록.TabIndex = 4;
            this.button3_등록.Text = "게시글 등록하기";
            this.button3_등록.UseVisualStyleBackColor = true;
            this.button3_등록.Click += new System.EventHandler(this.button3_등록_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 316);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(429, 89);
            this.textBox3.TabIndex = 3;
            // 
            // pictureBox3_업로드
            // 
            this.pictureBox3_업로드.Location = new System.Drawing.Point(12, 45);
            this.pictureBox3_업로드.Name = "pictureBox3_업로드";
            this.pictureBox3_업로드.Size = new System.Drawing.Size(429, 265);
            this.pictureBox3_업로드.TabIndex = 2;
            this.pictureBox3_업로드.TabStop = false;
            // 
            // textBox3_찾기
            // 
            this.textBox3_찾기.Enabled = false;
            this.textBox3_찾기.Location = new System.Drawing.Point(106, 11);
            this.textBox3_찾기.Name = "textBox3_찾기";
            this.textBox3_찾기.Size = new System.Drawing.Size(335, 28);
            this.textBox3_찾기.TabIndex = 1;
            // 
            // button3_찾기
            // 
            this.button3_찾기.Location = new System.Drawing.Point(12, 9);
            this.button3_찾기.Name = "button3_찾기";
            this.button3_찾기.Size = new System.Drawing.Size(85, 29);
            this.button3_찾기.TabIndex = 0;
            this.button3_찾기.Text = "찾기";
            this.button3_찾기.UseVisualStyleBackColor = true;
            this.button3_찾기.Click += new System.EventHandler(this.button3_찾기_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel4);
            this.panel4.Controls.Add(this.button4_리스트);
            this.panel4.Controls.Add(this.button4_바둑판);
            this.panel4.Controls.Add(this.textBox4);
            this.panel4.Controls.Add(this.label4_숫자);
            this.panel4.Controls.Add(this.label4_게시물);
            this.panel4.Controls.Add(this.button4_수정);
            this.panel4.Controls.Add(this.pictureBox4_profile);
            this.panel4.Location = new System.Drawing.Point(354, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(454, 455);
            this.panel4.TabIndex = 18;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.AutoScroll = true;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel4.Location = new System.Drawing.Point(12, 196);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(429, 256);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // button4_리스트
            // 
            this.button4_리스트.Location = new System.Drawing.Point(223, 161);
            this.button4_리스트.Name = "button4_리스트";
            this.button4_리스트.Size = new System.Drawing.Size(176, 29);
            this.button4_리스트.TabIndex = 6;
            this.button4_리스트.Text = "리스트";
            this.button4_리스트.UseVisualStyleBackColor = true;
            // 
            // button4_바둑판
            // 
            this.button4_바둑판.Location = new System.Drawing.Point(39, 162);
            this.button4_바둑판.Name = "button4_바둑판";
            this.button4_바둑판.Size = new System.Drawing.Size(174, 28);
            this.button4_바둑판.TabIndex = 5;
            this.button4_바둑판.Text = "바둑판";
            this.button4_바둑판.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 110);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(429, 45);
            this.textBox4.TabIndex = 4;
            // 
            // label4_숫자
            // 
            this.label4_숫자.AutoSize = true;
            this.label4_숫자.Location = new System.Drawing.Point(310, 21);
            this.label4_숫자.Name = "label4_숫자";
            this.label4_숫자.Size = new System.Drawing.Size(18, 18);
            this.label4_숫자.TabIndex = 3;
            this.label4_숫자.Text = "0";
            // 
            // label4_게시물
            // 
            this.label4_게시물.AutoSize = true;
            this.label4_게시물.Location = new System.Drawing.Point(286, 47);
            this.label4_게시물.Name = "label4_게시물";
            this.label4_게시물.Size = new System.Drawing.Size(62, 18);
            this.label4_게시물.TabIndex = 2;
            this.label4_게시물.Text = "게시물";
            // 
            // button4_수정
            // 
            this.button4_수정.Location = new System.Drawing.Point(223, 68);
            this.button4_수정.Name = "button4_수정";
            this.button4_수정.Size = new System.Drawing.Size(176, 39);
            this.button4_수정.TabIndex = 1;
            this.button4_수정.Text = "프로필 수정";
            this.button4_수정.UseVisualStyleBackColor = true;
            // 
            // pictureBox4_profile
            // 
            this.pictureBox4_profile.Image = global::_2015726044_이다인_client.Properties.Resources.profile_img;
            this.pictureBox4_profile.Location = new System.Drawing.Point(54, 5);
            this.pictureBox4_profile.Name = "pictureBox4_profile";
            this.pictureBox4_profile.Size = new System.Drawing.Size(152, 101);
            this.pictureBox4_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4_profile.TabIndex = 0;
            this.pictureBox4_profile.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "KYA.jpg");
            this.imageList1.Images.SetKeyName(1, "KSH.jpg");
            this.imageList1.Images.SetKeyName(2, "SJK.jpg");
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(5, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 454);
            this.panel1.TabIndex = 8;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 538);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_회원가입);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_pw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.textBox_port);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_ip);
            this.Controls.Add(this.label1);
            this.Name = "Client";
            this.Text = "Mini instagram Client";
            this.Load += new System.EventHandler(this.Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3_업로드)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4_profile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.TextBox textBox_pw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_회원가입;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button2_찾기;
        private System.Windows.Forms.TextBox textBox2_search;
        private System.Windows.Forms.ListBox listBox2_찾은후;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3_등록;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox pictureBox3_업로드;
        private System.Windows.Forms.TextBox textBox3_찾기;
        private System.Windows.Forms.Button button3_찾기;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button4_리스트;
        private System.Windows.Forms.Button button4_바둑판;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4_숫자;
        private System.Windows.Forms.Label label4_게시물;
        private System.Windows.Forms.Button button4_수정;
        private System.Windows.Forms.PictureBox pictureBox4_profile;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel1;
    }
}

