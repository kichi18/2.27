using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;

namespace C_プログラム
{
    public partial class Form3 : Form
    {
        //week配列
        private string[] week =
        {
            "",//0
            "Mon",//1
            "Tue",//2
            "Wed",//3
            "Thu",//4
            "Fri",//5
            "Sat",//6
            "Sun"//7
        };

        //month配列
        private string[] month =
        {
            "",//0
            "Jan",//1
            "Feb",//2
            "Mar",//3
            "Apr",//4
            "May",//5
            "Jun",//6
            "Jul",//7
            "Aug",//8
            "Sep",//9
            "Oct",//10
            "Nov",//11
            "Dec"//12
        };

        private RadioButton[] radioweeks;

        private bool isLoaded = false;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //ラジオボタンを配列に入れる
            radioweeks = new RadioButton[]
            {
                radioButton1,
                radioButton2,
                radioButton3,
                radioButton4,
                radioButton5,
                radioButton6,
                radioButton7
            };

            //ラジオボタンに曜日を表示
            for (int i = 0; i < radioweeks.Length; i++)
            {
                radioweeks[i].Text = week[i + 1];
            }

            //コンボボックスに曜日を追加
            for (int i = 1; i < week.Length; i++)
            {
                comboBox1.Items.Add(week[i]);
            }

            //ラベルの初期表示
            label1.Text = "Days";
            label2.Text = "Days";

            //チェックボタンイベントの初期化
            button1.Enabled = false;

            //ボタンの上のマウスをHandにする
            checkBox1.Cursor = Cursors.Hand;
            checkBox2.Cursor = Cursors.Hand;
            checkBox3.Cursor = Cursors.Hand;

        }

        //曜日のイベント
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!isLoaded)
            {
                return;
            }

            for (int i = 0; i < radioweeks.Length; i++)
            {
                if (radioweeks[i].Checked)
                {
                    label1.Text = radioweeks[i].Text;
                }
            }
        }

        //曜日か月かのイベント
        private void radioButton_DaysYears_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            if (radioButton8.Checked)
            {
                for (int i = 1; i < week.Length; i++)
                {
                    comboBox1.Items.Add(week[i]);
                }

                comboBox1.SelectedIndex = -1;

                label2.Text = "Days";

            }
            else if (radioButton9.Checked)
            {
                for (int i = 1; i < month.Length; i++)
                {
                    comboBox1.Items.Add(month[i]);
                }

                comboBox1.SelectedIndex = -1;

                label2.Text = "Years";
            }
        }

        private void Form3_Shown(object sender, EventArgs e)
        {
            isLoaded = true;
        }

        //コンボボックスのイベント
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = comboBox1.Text;
        }

        //チェックボックスのイベント
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckButton();
        }

        //チェックボタンの有効化メソッド
        private void CheckButton()
        {
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        //ボタンのイベント
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Message_manage.Msg4, Message_manage.Title3, MessageBoxButtons.OK);
        }

        //ボタンのマウスが当たったときのイベント
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.Yellow;
        }

        //ボタンのマウスが離れたときのイベント
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Yellow;
            button1.ForeColor = Color.Black;
        }

        //ラジオボタンの画像イベント
        private void radioButton_ImageLayout_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton10.Checked)
            {
                panel5.BackgroundImageLayout = ImageLayout.Zoom;
            }
            else if (radioButton11.Checked)
            {
                panel5.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (radioButton12.Checked)
            {
                panel5.BackgroundImageLayout = ImageLayout.Center;
            }

        }
    }
}
