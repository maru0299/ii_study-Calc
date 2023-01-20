﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            inputformula("1");// 入力処理を行う関数を呼ぶ
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            inputformula("2");// 入力処理を行う関数を呼ぶ
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            inputformula("3");// 入力処理を行う関数を呼ぶ
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            inputformula("4");// 入力処理を行う関数を呼ぶ
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            inputformula("5");// 入力処理を行う関数を呼ぶ
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            inputformula("6");// 入力処理を行う関数を呼ぶ
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            inputformula("7");// 入力処理を行う関数を呼ぶ
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            inputformula("8");// 入力処理を行う関数を呼ぶ
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            inputformula("9");// 入力処理を行う関数を呼ぶ
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            inputformula("0");// 入力処理を行う関数を呼ぶ
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            inputformula("=");// 入力処理を行う関数を呼ぶ
        }

        private void button_dot_Click(object sender, EventArgs e)
        {
            inputformula(".");// 入力処理を行う関数を呼ぶ
        }

        private void button_tasu_Click(object sender, EventArgs e)
        {
            inputformula("+");// 入力処理を行う関数を呼ぶ
        }

        private void button_hiku_Click(object sender, EventArgs e)
        {
            inputformula("-");// 入力処理を行う関数を呼ぶ
        }

        private void button_kakeru_Click(object sender, EventArgs e)
        {
            inputformula("*");// 入力処理を行う関数を呼ぶ
        }

        private void button_waru_Click(object sender, EventArgs e)
        {
            inputformula("/");// 入力処理を行う関数を呼ぶ
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            backspace();
        }
        
        private void inputformula(string str)
        {
            textBox_formula.AppendText(str);
        }

        private void backspace()
        {
            int Length = textBox_formula.Text.Length;
            if(Length != 0)
            {
                textBox_formula.Text = textBox_formula.Text.Substring(0, Length - 1);
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                // 数字とバックスペース以外は処理しない
                e.Handled = false;
            }
            inputformula(e.KeyChar.ToString());
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D1:
                case Keys.NumPad1:
                    this.button_1.Focus();
                    this.button_1.PerformClick();
                    break;
                case Keys.D2:
                case Keys.NumPad2:
                    this.button_2.Focus();
                    this.button_2.PerformClick();
                    break;
                case Keys.D3:
                case Keys.NumPad3:
                    this.button_3.Focus();
                    this.button_3.PerformClick();
                    break;
                case Keys.D4:
                case Keys.NumPad4:
                    this.button_4.Focus();
                    this.button_4.PerformClick();
                    break;
                case Keys.D5:
                case Keys.NumPad5:
                    this.button_5.Focus();
                    this.button_5.PerformClick();
                    break;
                case Keys.D6:
                case Keys.NumPad6:
                    this.button_6.Focus();
                    this.button_6.PerformClick();
                    break;
                case Keys.D7:
                case Keys.NumPad7:
                    this.button_7.Focus();
                    this.button_7.PerformClick();
                    break;
                case Keys.D8:
                case Keys.NumPad8:
                    this.button_8.Focus();
                    this.button_8.PerformClick();
                    break;
                case Keys.D9:
                case Keys.NumPad9:
                    this.button_9.Focus();
                    this.button_9.PerformClick();
                    break;
                case Keys.D0:
                case Keys.NumPad0:
                    this.button_0.Focus();
                    this.button_0.PerformClick();
                    break;
            }
        }
    }
}
