using System;
using System.Drawing.Drawing2D;
using System.IO;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace C_プログラム
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label5.Paint += label5_Paint;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //ファイル選択
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "開くファイルを選択してください";
            openFileDialog.Filter = "すべてのファイル(*.*|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog.FileName;
            }
        }

        //ファイル内容表示
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show(Message_manage.Msg2, Message_manage.Title4);
                return;
            }

            try
            {
                string text = File.ReadAllText(textBox1.Text);
                label3.Text = text;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(Message_manage.Msg2, Message_manage.Title4);
            }
        }

        //PUSH1
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                Message_manage.Msg1, Message_manage.Title3,
                MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                string text = label3.Text;
                Form2 form2 = new Form2(text);
                form2.ShowDialog();
            }

        }

      

        //Yellow
        private void button4_Click(object sender, EventArgs e)
        {
            label4.BackColor = Color.Yellow;
        }

        //Green

        private void button5_Click(object sender, EventArgs e)
        {
            label4.BackColor = Color.Green;
        }

        //Blue
        private void button6_Click(object sender, EventArgs e)
        {
            label4.BackColor = Color.Blue;
        }

        //ファイル更新
        private void button7_Click(object sender, EventArgs e)
        {

        }

        //PUSH2
        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               Message_manage.Msg1, Message_manage.Title3,
               MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                Form3 form3 = new Form3();
                form3.ShowDialog();
            }
        }

        //時計
        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        //label5のグラデーション
         private void label5_Paint(object sender, PaintEventArgs e)
         {
            using (LinearGradientBrush brush =
                new LinearGradientBrush(
                    label5.ClientRectangle,
                    Color.White,
                    Color.Blue,
                    LinearGradientMode.Vertical))
                    {
                        e.Graphics.FillRectangle(brush, label5.ClientRectangle);
                    }

            TextRenderer.DrawText(
                e.Graphics,
                label5.Text,
                label5.Font,
                label5.ClientRectangle,
                label5.ForeColor,
                TextFormatFlags.HorizontalCenter |
                TextFormatFlags.VerticalCenter);
         }

    }
}
    

