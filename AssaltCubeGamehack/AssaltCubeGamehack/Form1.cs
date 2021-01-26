using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProcessMemoryReaderLib;

namespace AssaltCubeGamehack
{
    public partial class Form1 : Form
    {
        Process[] MyProcess; //프로세스를 목록을 저장할 장소, 배열 형태
        ProcessMemoryReader mem = new ProcessMemoryReader();
        bool attach = false; 
        bool healthHack = false; //처음에 키자마자 동작하면 이상하니까
        bool ammoHack = false;

        PlayerData mainPlayer;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void AmmoLBL_Click(object sender, EventArgs e)
        {

        }

        private void ExitBT_Click(object sender, EventArgs e)
        {
            DialogResult result;    //닫기 실행할 꺼냐?? 정말 ??
            result = MessageBox.Show("종료하시겠습니까?", "종료메시지", MessageBoxButtons.OKCancel); //1.메시지내용2.타이틀제목3.다양한선택지yes no 등

            if (result == DialogResult.OK)//만약 result에 담겨있는 정보가 ok라면
            {
                this.DialogResult = DialogResult.Abort;
                Application.Exit();     //종료 얘 없으면 확인버튼 눌러도 안꺼짐
            }
        }
        
        private void comboBox1_Click(object sender, EventArgs e)//클릭했을 때 프로세스 목록이 보여주도록
        {
            comboBox1.Items.Clear(); // 기존의 프로세스 목록을 초기화 (why?- 계속 누를때마다 추가되는 것이 아닌 초기화 되게끔. 처음불러온것과 후에 불러온것이 다를 수 있기 때문!

            //Process[] MyProcess; 이 함수안에 선언하게되면 프로세스 목록을 한번쓰고 버리기때문에 
            //다른 함수에서도 쓸수 있도록 밖에다가 쓰자

            MyProcess = Process.GetProcesses(); //프로세스 목록을 불러옴 (30개) Length는 결국 30개인듯 정해져있는 듯

            for (int i = 0; i < MyProcess.Length; i++) //저장된 MyProcess를 for문돌리자 한개씩한개씩 꺼내오기 위해 for문을 자주씀, Length 는 총 갯수
            {
                // 여기에 작성되는 내용이 총 MyProcess.Length번 진행이 됨
                string text = MyProcess[i].ProcessName + "-" + MyProcess[i].Id;
                comboBox1.Items.Add(text);
            }
        }
        //프로세스를 선택했을 때 어떤 행동을 할지 정하는 얘
        // 콤보박스 메뉴중에 어떤 항목을 클릭했을 때 동작할 내용
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try //프로세스 열기를 실패할때 에러뜨면 안되니까 만들어주자
            {


                // 해당 프로세스에 대한 권한을 가져온다.
                // 프로세스 메모리 읽기/수정
                if (comboBox1.SelectedIndex != -1) // 목록(프로세스)을 선택했다면
                {
                    string selectedItem = comboBox1.SelectedItem.ToString(); //kakaoTalk-704 같이 클릭했을때 스트링으로 불러옴
                    int pid = int.Parse(selectedItem.Split('-')[selectedItem.Split('-').Length - 1]);//문자열을 -로 나눈후 가장 마지막 문자열으로 가져온다
                    Process attachProc = Process.GetProcessById(pid);

                    // 이제 프로세스를 열어야함! (권한떄문) ProcessmemoryReader가 이제 필요하게된다

                    //ProcessMemoryReader mem = new ProcessMemoryReader(); 이 라이브러리는 함수가 끝나면서 없어지기 때문에한번이 아닌여러군데 사용하기 위해 밖에다가!

                    //mem의 역할은 ProcessMemoryReader.cs에 있는 것들을 사용할 수 있게끔 해준다
                    mem.ReadProcess = attachProc; //어떤 프로세스를 읽을거냐, 열지 를 저장
                    mem.OpenProcess();// 프로세스를 열기
                    

                    MessageBox.Show("프로세스 열기 성공! " + attachProc.ProcessName);

                    mainPlayer = new PlayerData(attachProc, 0x0016BA08, mem);

                    attach = true;//프로세스를 열었다는 것을 표시해주기위해 작성 맨위에 false
                }
            }
            catch (Exception ex) // 시도했을 때 예외 처리
            {
                attach = false;
                MessageBox.Show(" 프로세스 열기 실패!" + ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e) // 0.1초마다 동작
        {
            if (attach)
            {
                try
                {
                    if(healthHack)
                    {
                        mainPlayer.hackHealth(mem);
                    }
                    if (ammoHack)
                    {
                        mainPlayer.hackAmmo(mem);
                    }

                    mainPlayer.SetPlayerData(mem); //데이터 모니터링
                    HealtthLBL.Text = "Health: " + mainPlayer.health; //Health:100
                    AmmoLBL.Text = "Ammo: " + mainPlayer.ammo;
                    BulletproofLBL.Text = "BulletProof: " + mainPlayer.bullet_proof;
                    AngleLBL.Text = "Angle : " + mainPlayer.x_angle.ToString("#.##") + " |" + mainPlayer.y_angle.ToString("#.##");
                    PositionLBL.Text = "Pos: " + mainPlayer.x_pos.ToString("#.##") + "," + mainPlayer.y_pos.ToString("#.##") + "," + mainPlayer.z_pos.ToString("#.##");
                }
                catch { }
            }
        }
        private void HealthBT_Click(object sender, EventArgs e)
        {            
            if (healthHack)
            {
                healthHack = false;
                HealthHLBL.Text = "동작 안함";
            }
            else { 
                healthHack = true;
                HealthHLBL.Text = "동작 중";
            }
        }

        private void AmmoBT_Click(object sender, EventArgs e)
        {
            if (ammoHack)
            {
                ammoHack = false;
                AmmoHLBL.Text = "동작 안함";
            }
            else
            {
                ammoHack = true;
                AmmoHLBL.Text = "동작 중";
            }
        }

        
    }
}
