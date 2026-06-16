namespace C_プログラム
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1 = new GroupBox();
            label4 = new Label();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            label5 = new Label();
            button8 = new Button();
            panel1 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 59);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 0;
            label1.Text = "ファイル選択：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 94);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 1;
            label2.Text = "ファイル内容：";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(208, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(361, 31);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(208, 94);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Location = new Point(587, 50);
            button1.Name = "button1";
            button1.Size = new Size(127, 34);
            button1.TabIndex = 4;
            button1.Text = "ファイル選択";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.Location = new Point(587, 89);
            button2.Name = "button2";
            button2.Size = new Size(127, 34);
            button2.TabIndex = 5;
            button2.Text = "表示";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Gray;
            button3.ForeColor = Color.White;
            button3.Location = new Point(587, 129);
            button3.Name = "button3";
            button3.Size = new Size(127, 34);
            button3.TabIndex = 6;
            button3.Text = "PUSH";
            button3.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(85, 201);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(433, 97);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "返却値";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 42);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 8;
            label4.Text = "label4";
            // 
            // button4
            // 
            button4.BackColor = Color.Yellow;
            button4.Location = new Point(587, 201);
            button4.Name = "button4";
            button4.Size = new Size(127, 34);
            button4.TabIndex = 9;
            button4.Text = "Yellow";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Yellow;
            button5.Location = new Point(587, 241);
            button5.Name = "button5";
            button5.Size = new Size(127, 34);
            button5.TabIndex = 10;
            button5.Text = "Green";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Yellow;
            button6.Location = new Point(587, 281);
            button6.Name = "button6";
            button6.Size = new Size(127, 34);
            button6.TabIndex = 11;
            button6.Text = "Blue";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.Yellow;
            button7.Location = new Point(587, 321);
            button7.Name = "button7";
            button7.Size = new Size(127, 34);
            button7.TabIndex = 12;
            button7.Text = "ファイル更新";
            button7.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(85, 326);
            label5.Name = "label5";
            label5.Size = new Size(80, 25);
            label5.TabIndex = 13;
            label5.Text = "00:00:00";
            // 
            // button8
            // 
            button8.BackColor = Color.Gray;
            button8.ForeColor = Color.White;
            button8.Location = new Point(587, 381);
            button8.Name = "button8";
            button8.Size = new Size(127, 34);
            button8.TabIndex = 14;
            button8.Text = "PUSH";
            button8.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Location = new Point(50, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 182);
            panel1.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button8);
            Controls.Add(label5);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(groupBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private GroupBox groupBox1;
        private Label label4;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label label5;
        private Button button8;
        private Panel panel1;
        private System.Windows.Forms.Timer timer1;
    }
}
