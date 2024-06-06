﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscapeGame
{
    public partial class Room2 : Form
    {
        private HashSet<Keys> pressedKeys = new HashSet<Keys>();
        private Timer movementTimer;
        private const int step = 10; // 캐릭터 이동 거리
        private bool hasReachedTarget = false; // 목표 위치 도달 여부를 추적
        private bool hasKeyToRoom3 = false; // Room3 열쇠 획득 여부
        private Form1 mainForm; // Form1 인스턴스를 저장

        public Room2(Form1 form)
        {
            InitializeComponent();
            this.mainForm = form; // 전달된 Form1 인스턴스를 저장
            this.KeyDown += new KeyEventHandler(Room2_KeyDown);
            this.KeyUp += new KeyEventHandler(Room2_KeyUp);
            this.KeyPreview = true;

            // 방향키 두 개를 동시에 눌렀을 때 대각선으로 이동시키기 위함
            movementTimer = new Timer();
            movementTimer.Interval = 20; // 20ms 간격으로 움직임을 업데이트
            movementTimer.Tick += MovementTimer_Tick;
            movementTimer.Start();
        }

        private void Room2_KeyDown(object sender, KeyEventArgs e)
        {
            pressedKeys.Add(e.KeyCode);
        }

        private void Room2_KeyUp(object sender, KeyEventArgs e)
        {
            pressedKeys.Remove(e.KeyCode);
        }

        private void MovementTimer_Tick(object sender, EventArgs e)
        {
            MovePlayer();
            MoveMainRoom();
            MoveHint();
            MoveGameMachine();
        }

        private void MovePlayer()
        {
            if (pressedKeys.Contains(Keys.Up))
            {
                pbPlayer.Top -= step;
            }
            if (pressedKeys.Contains(Keys.Down))
            {
                pbPlayer.Top += step;
            }
            if (pressedKeys.Contains(Keys.Left))
            {
                pbPlayer.Left -= step;
            }
            if (pressedKeys.Contains(Keys.Right))
            {
                pbPlayer.Left += step;
            }
        }
        public void BlackjackGameWon()
        {
            hasKeyToRoom3 = true;
            mainForm.hasKeyToRoom3 = true;
            MessageBox.Show("어디선가 문이 열리는 소리가 들린다.");
        }
        private void MoveHint()
        {
            if (pbPlayer.Bounds.IntersectsWith(pbHint.Bounds))
            {
                movementTimer.Stop();
                MessageBox.Show("게임에서 승리한다면..");
                pbPlayer.Top += 20;
                movementTimer.Start();
                pressedKeys.Clear();
            }
        }
        private void MoveGameMachine()
        {
            if (pbPlayer.Bounds.IntersectsWith(pbRunnerGameMachine.Bounds))
            {
                if (hasKeyToRoom3 == false)
                {
                    movementTimer.Stop();
                    Blackjack blackjackgame = new Blackjack(this);
                    blackjackgame.Show();
                    pbPlayer.Top += 20;
                    movementTimer.Start();
                    pressedKeys.Clear();
                }
                else
                {
                    movementTimer.Stop();
                    MessageBox.Show("이럴 시간 없어. 어서 열린 곳으로 가보자.");
                    pbPlayer.Top += 20;
                    movementTimer.Start();
                    pressedKeys.Clear();
                }
            }
        }
        private void MoveMainRoom()
        {
            if (hasReachedTarget == false && pbPlayer.Bounds.IntersectsWith(pbMainp.Bounds))
            {
                hasReachedTarget = true;
                mainForm.SetPlayerPosition(30, 200);
                mainForm.Show();
                this.Hide();
            }
        }
    }
}