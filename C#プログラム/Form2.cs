using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace C_プログラム
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string text)
        {
            InitializeComponent();
            label3.Text = text;
        }

        //前後の空白削除メソッド
        private string TrimText(string text)
        {
            return text.Trim();
        }

        //分割ボタン
        private void button1_Click(object sender, EventArgs e)
        {
            string[] items = label3.Text.Split(",");

            textBox1.Text = TrimText(items[0]);
            textBox2.Text = TrimText(items[1]);
            textBox3.Text = TrimText(items[2]);
            textBox4.Text = TrimText(items[3]);

        }
        //空白削除A
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = TrimText(textBox1.Text);
            textBox2.Text = TrimText(textBox2.Text);
            textBox3.Text = TrimText(textBox3.Text);
            textBox4.Text = TrimText(textBox4.Text);
        }
        //空白削除B

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Replace(" ", "");
            textBox2.Text = textBox2.Text.Replace(" ", "");
            textBox3.Text = textBox3.Text.Replace(" ", "");
            textBox4.Text = textBox4.Text.Replace(" ", "");
        }

        //形成
        private void button4_Click(object sender, EventArgs e)
        {
            string[] data =
            {
                textBox1.Text,
                textBox2.Text,
                textBox3.Text,
                textBox4.Text
            };

            string result = string.Join(",", data);

            textBox5.Text = result;

        }

        //階段作成
        private void button5_Click(object sender, EventArgs e)
        {
            int num = (int)numericUpDown1.Value;

            string text = "";

            for (int i = 0; i < num; i++)
            {
                text += i;
                richTextBox1.Text += text + Environment.NewLine;
            }
        }

        //返却値の内容をForm1のlabel4に表示
        public string ResultText
        {
            get { return textBox5.Text; }
            
        }

        //close
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
