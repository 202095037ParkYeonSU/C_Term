using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Diagnostics;
using System.Xml.Serialization;

namespace C__Assign_Team9
{
    public partial class Form2 : Form
    {
        Random rnd = new Random();
        public Form2()
        {
            InitializeComponent();
            Naration.Text = $"{CharacterImage1.Left}, {FinishLine.Left}";
        }
        int LeftCharacterImage1, LeftCharacterImage2;
        private void Form2_Load(object sender, EventArgs e)
        {
            button1.FlatAppearance.BorderSize = 0;

            LeftCharacterImage1 = CharacterImage1.Left;
            LeftCharacterImage2 = CharacterImage2.Left;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            int widthCharacterImage1 = CharacterImage1.Width, widthCharacterImage2 = CharacterImage2.Width; // 캐릭터별 시작점
            int finish = FinishLine.Left;   // 도착점

            Character character1 = new Character("A", 10);
            Character character2 = new Character("B", 10);

            CharacterImage1.Left = CharacterImage1.Left + character1.GetSpeed();   // 캐릭터들 이동 속도
            CharacterImage2.Left = CharacterImage2.Left + character2.GetSpeed();

            Naration.Text = $"{character1.GetName()} : {CharacterImage1.Left}, {character2.GetName()} : {CharacterImage2.Left}";  // 캐릭터별 현재 위치 프린트

            if (CharacterImage1.Left >= finish) // 도착선 밟으면 게임 종료
            {
                timer1.Enabled = false;
                Naration.Text = "게임 종료! 1번 승리!";
            }
            if (CharacterImage2.Left >= finish)
            {
                timer1.Enabled = false;
                Naration.Text = "게임 종료! 2번 승리!";
            }

            if (CharacterImage1.Left == 500)
            {

            }

        }








        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {
        }

        public void ProgressBarIncrease(object sender) // 프로그레스바의 값을 증가시키는 함수
        {

        }

        private void CharacterImage1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }





        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void CharacterImage2_Click(object sender, EventArgs e)
        {

        }
    }
}
