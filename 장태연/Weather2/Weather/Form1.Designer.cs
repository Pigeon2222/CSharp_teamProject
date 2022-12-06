namespace Weather
{
    partial class Form1
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
            this.weather_textBox1 = new System.Windows.Forms.TextBox();
            this.weather_label1 = new System.Windows.Forms.Label();
            this.weather_button1 = new System.Windows.Forms.Button();
            this.weather_button2 = new System.Windows.Forms.Button();
            this.weather_label2 = new System.Windows.Forms.Label();
            this.weather_textBox2 = new System.Windows.Forms.TextBox();
            this.weather_button3 = new System.Windows.Forms.Button();
            this.weather_richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.weather_button4 = new System.Windows.Forms.Button();
            this.weather_button5 = new System.Windows.Forms.Button();
            this.weather_button6 = new System.Windows.Forms.Button();
            this.weather_button8 = new System.Windows.Forms.Button();
            this.weather_button9 = new System.Windows.Forms.Button();
            this.weather_button10 = new System.Windows.Forms.Button();
            this.weather_button11 = new System.Windows.Forms.Button();
            this.weather_button7 = new System.Windows.Forms.Button();
            this.weather_button12 = new System.Windows.Forms.Button();
            this.weather_button16 = new System.Windows.Forms.Button();
            this.weather_button15 = new System.Windows.Forms.Button();
            this.weather_button14 = new System.Windows.Forms.Button();
            this.weather_button13 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // weather_textBox1
            // 
            this.weather_textBox1.Location = new System.Drawing.Point(748, 72);
            this.weather_textBox1.Name = "weather_textBox1";
            this.weather_textBox1.Size = new System.Drawing.Size(100, 21);
            this.weather_textBox1.TabIndex = 0;
            this.weather_textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // weather_label1
            // 
            this.weather_label1.AutoSize = true;
            this.weather_label1.Location = new System.Drawing.Point(702, 75);
            this.weather_label1.Name = "weather_label1";
            this.weather_label1.Size = new System.Drawing.Size(18, 12);
            this.weather_label1.TabIndex = 4;
            this.weather_label1.Text = "lat";
            // 
            // weather_button1
            // 
            this.weather_button1.Location = new System.Drawing.Point(748, 250);
            this.weather_button1.Name = "weather_button1";
            this.weather_button1.Size = new System.Drawing.Size(75, 23);
            this.weather_button1.TabIndex = 6;
            this.weather_button1.Text = "현재날씨";
            this.weather_button1.UseVisualStyleBackColor = true;
            this.weather_button1.Click += new System.EventHandler(this.button2_Click);
            // 
            // weather_button2
            // 
            this.weather_button2.Location = new System.Drawing.Point(748, 299);
            this.weather_button2.Name = "weather_button2";
            this.weather_button2.Size = new System.Drawing.Size(75, 23);
            this.weather_button2.TabIndex = 7;
            this.weather_button2.Text = "주간날씨";
            this.weather_button2.UseVisualStyleBackColor = true;
            this.weather_button2.Click += new System.EventHandler(this.button3_Click);
            // 
            // weather_label2
            // 
            this.weather_label2.AutoSize = true;
            this.weather_label2.Location = new System.Drawing.Point(702, 115);
            this.weather_label2.Name = "weather_label2";
            this.weather_label2.Size = new System.Drawing.Size(22, 12);
            this.weather_label2.TabIndex = 9;
            this.weather_label2.Text = "lon";
            // 
            // weather_textBox2
            // 
            this.weather_textBox2.Location = new System.Drawing.Point(748, 112);
            this.weather_textBox2.Name = "weather_textBox2";
            this.weather_textBox2.Size = new System.Drawing.Size(100, 21);
            this.weather_textBox2.TabIndex = 8;
            // 
            // weather_button3
            // 
            this.weather_button3.Location = new System.Drawing.Point(33, 12);
            this.weather_button3.Name = "weather_button3";
            this.weather_button3.Size = new System.Drawing.Size(72, 58);
            this.weather_button3.TabIndex = 12;
            this.weather_button3.Text = "서울";
            this.weather_button3.UseVisualStyleBackColor = true;
            this.weather_button3.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // weather_richTextBox1
            // 
            this.weather_richTextBox1.Location = new System.Drawing.Point(136, 161);
            this.weather_richTextBox1.Name = "weather_richTextBox1";
            this.weather_richTextBox1.Size = new System.Drawing.Size(584, 374);
            this.weather_richTextBox1.TabIndex = 3;
            this.weather_richTextBox1.Text = "";
            // 
            // weather_button4
            // 
            this.weather_button4.Location = new System.Drawing.Point(124, 12);
            this.weather_button4.Name = "weather_button4";
            this.weather_button4.Size = new System.Drawing.Size(72, 58);
            this.weather_button4.TabIndex = 13;
            this.weather_button4.Text = "인천";
            this.weather_button4.UseVisualStyleBackColor = true;
            this.weather_button4.Click += new System.EventHandler(this.weather_button4_Click);
            // 
            // weather_button5
            // 
            this.weather_button5.Location = new System.Drawing.Point(224, 12);
            this.weather_button5.Name = "weather_button5";
            this.weather_button5.Size = new System.Drawing.Size(72, 58);
            this.weather_button5.TabIndex = 14;
            this.weather_button5.Text = "춘천";
            this.weather_button5.UseVisualStyleBackColor = true;
            this.weather_button5.Click += new System.EventHandler(this.weather_button5_Click);
            // 
            // weather_button6
            // 
            this.weather_button6.Location = new System.Drawing.Point(319, 12);
            this.weather_button6.Name = "weather_button6";
            this.weather_button6.Size = new System.Drawing.Size(72, 58);
            this.weather_button6.TabIndex = 15;
            this.weather_button6.Text = "강릉";
            this.weather_button6.UseVisualStyleBackColor = true;
            this.weather_button6.Click += new System.EventHandler(this.weather_button6_Click);
            // 
            // weather_button8
            // 
            this.weather_button8.Location = new System.Drawing.Point(503, 12);
            this.weather_button8.Name = "weather_button8";
            this.weather_button8.Size = new System.Drawing.Size(72, 58);
            this.weather_button8.TabIndex = 16;
            this.weather_button8.Text = "대전";
            this.weather_button8.UseVisualStyleBackColor = true;
            this.weather_button8.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // weather_button9
            // 
            this.weather_button9.Location = new System.Drawing.Point(593, 12);
            this.weather_button9.Name = "weather_button9";
            this.weather_button9.Size = new System.Drawing.Size(72, 58);
            this.weather_button9.TabIndex = 17;
            this.weather_button9.Text = "청주";
            this.weather_button9.UseVisualStyleBackColor = true;
            this.weather_button9.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // weather_button10
            // 
            this.weather_button10.Location = new System.Drawing.Point(33, 92);
            this.weather_button10.Name = "weather_button10";
            this.weather_button10.Size = new System.Drawing.Size(72, 58);
            this.weather_button10.TabIndex = 18;
            this.weather_button10.Text = "대구";
            this.weather_button10.UseVisualStyleBackColor = true;
            this.weather_button10.Click += new System.EventHandler(this.button5_Click);
            // 
            // weather_button11
            // 
            this.weather_button11.Location = new System.Drawing.Point(125, 92);
            this.weather_button11.Name = "weather_button11";
            this.weather_button11.Size = new System.Drawing.Size(72, 58);
            this.weather_button11.TabIndex = 19;
            this.weather_button11.Text = "전주";
            this.weather_button11.UseVisualStyleBackColor = true;
            this.weather_button11.Click += new System.EventHandler(this.button6_Click);
            // 
            // weather_button7
            // 
            this.weather_button7.Location = new System.Drawing.Point(411, 12);
            this.weather_button7.Name = "weather_button7";
            this.weather_button7.Size = new System.Drawing.Size(72, 58);
            this.weather_button7.TabIndex = 20;
            this.weather_button7.Text = "울릉도";
            this.weather_button7.UseVisualStyleBackColor = true;
            this.weather_button7.Click += new System.EventHandler(this.weather_button7_Click);
            // 
            // weather_button12
            // 
            this.weather_button12.Location = new System.Drawing.Point(224, 92);
            this.weather_button12.Name = "weather_button12";
            this.weather_button12.Size = new System.Drawing.Size(72, 58);
            this.weather_button12.TabIndex = 21;
            this.weather_button12.Text = "창원";
            this.weather_button12.UseVisualStyleBackColor = true;
            this.weather_button12.Click += new System.EventHandler(this.button8_Click);
            // 
            // weather_button16
            // 
            this.weather_button16.Location = new System.Drawing.Point(593, 92);
            this.weather_button16.Name = "weather_button16";
            this.weather_button16.Size = new System.Drawing.Size(72, 58);
            this.weather_button16.TabIndex = 22;
            this.weather_button16.Text = "제주";
            this.weather_button16.UseVisualStyleBackColor = true;
            this.weather_button16.Click += new System.EventHandler(this.weather_button16_Click);
            // 
            // weather_button15
            // 
            this.weather_button15.Location = new System.Drawing.Point(503, 92);
            this.weather_button15.Name = "weather_button15";
            this.weather_button15.Size = new System.Drawing.Size(72, 58);
            this.weather_button15.TabIndex = 23;
            this.weather_button15.Text = "부산";
            this.weather_button15.UseVisualStyleBackColor = true;
            this.weather_button15.Click += new System.EventHandler(this.weather_button15_Click);
            // 
            // weather_button14
            // 
            this.weather_button14.Location = new System.Drawing.Point(411, 92);
            this.weather_button14.Name = "weather_button14";
            this.weather_button14.Size = new System.Drawing.Size(72, 58);
            this.weather_button14.TabIndex = 24;
            this.weather_button14.Text = "광주";
            this.weather_button14.UseVisualStyleBackColor = true;
            this.weather_button14.Click += new System.EventHandler(this.weather_button14_Click);
            // 
            // weather_button13
            // 
            this.weather_button13.Location = new System.Drawing.Point(319, 92);
            this.weather_button13.Name = "weather_button13";
            this.weather_button13.Size = new System.Drawing.Size(72, 58);
            this.weather_button13.TabIndex = 25;
            this.weather_button13.Text = "울산";
            this.weather_button13.UseVisualStyleBackColor = true;
            this.weather_button13.Click += new System.EventHandler(this.weather_button13_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.weather_button13);
            this.Controls.Add(this.weather_button14);
            this.Controls.Add(this.weather_button15);
            this.Controls.Add(this.weather_button16);
            this.Controls.Add(this.weather_button12);
            this.Controls.Add(this.weather_button7);
            this.Controls.Add(this.weather_button11);
            this.Controls.Add(this.weather_button10);
            this.Controls.Add(this.weather_button9);
            this.Controls.Add(this.weather_button8);
            this.Controls.Add(this.weather_button6);
            this.Controls.Add(this.weather_button5);
            this.Controls.Add(this.weather_button4);
            this.Controls.Add(this.weather_button3);
            this.Controls.Add(this.weather_label2);
            this.Controls.Add(this.weather_textBox2);
            this.Controls.Add(this.weather_button2);
            this.Controls.Add(this.weather_button1);
            this.Controls.Add(this.weather_label1);
            this.Controls.Add(this.weather_richTextBox1);
            this.Controls.Add(this.weather_textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox weather_textBox1;
        private System.Windows.Forms.Label weather_label1;
        private System.Windows.Forms.Button weather_button2;
        private System.Windows.Forms.Label weather_label2;
        private System.Windows.Forms.TextBox weather_textBox2;
        private System.Windows.Forms.Button weather_button1;
        private System.Windows.Forms.Button weather_button3;
        private System.Windows.Forms.RichTextBox weather_richTextBox1;
        private System.Windows.Forms.Button weather_button4;
        private System.Windows.Forms.Button weather_button5;
        private System.Windows.Forms.Button weather_button6;
        private System.Windows.Forms.Button weather_button8;
        private System.Windows.Forms.Button weather_button9;
        private System.Windows.Forms.Button weather_button10;
        private System.Windows.Forms.Button weather_button11;
        private System.Windows.Forms.Button weather_button7;
        private System.Windows.Forms.Button weather_button12;
        private System.Windows.Forms.Button weather_button16;
        private System.Windows.Forms.Button weather_button15;
        private System.Windows.Forms.Button weather_button14;
        private System.Windows.Forms.Button weather_button13;
    }
}

