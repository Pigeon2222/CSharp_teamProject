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
            this.weather_richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.weather_label1 = new System.Windows.Forms.Label();
            this.weather_button2 = new System.Windows.Forms.Button();
            this.weather_button3 = new System.Windows.Forms.Button();
            this.weather_label2 = new System.Windows.Forms.Label();
            this.weather_textBox2 = new System.Windows.Forms.TextBox();
            this.weather_button1 = new System.Windows.Forms.Button();
            this.weather_button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // weather_textBox1
            // 
            this.weather_textBox1.Location = new System.Drawing.Point(556, 69);
            this.weather_textBox1.Name = "weather_textBox1";
            this.weather_textBox1.Size = new System.Drawing.Size(100, 21);
            this.weather_textBox1.TabIndex = 0;
            this.weather_textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // weather_richTextBox1
            // 
            this.weather_richTextBox1.Location = new System.Drawing.Point(136, 161);
            this.weather_richTextBox1.Name = "weather_richTextBox1";
            this.weather_richTextBox1.Size = new System.Drawing.Size(584, 374);
            this.weather_richTextBox1.TabIndex = 3;
            this.weather_richTextBox1.Text = "";
            // 
            // weather_label1
            // 
            this.weather_label1.AutoSize = true;
            this.weather_label1.Location = new System.Drawing.Point(510, 72);
            this.weather_label1.Name = "weather_label1";
            this.weather_label1.Size = new System.Drawing.Size(18, 12);
            this.weather_label1.TabIndex = 4;
            this.weather_label1.Text = "lat";
            // 
            // weather_button2
            // 
            this.weather_button2.Location = new System.Drawing.Point(748, 250);
            this.weather_button2.Name = "weather_button2";
            this.weather_button2.Size = new System.Drawing.Size(75, 23);
            this.weather_button2.TabIndex = 6;
            this.weather_button2.Text = "현재날씨";
            this.weather_button2.UseVisualStyleBackColor = true;
            this.weather_button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // weather_button3
            // 
            this.weather_button3.Location = new System.Drawing.Point(748, 299);
            this.weather_button3.Name = "weather_button3";
            this.weather_button3.Size = new System.Drawing.Size(75, 23);
            this.weather_button3.TabIndex = 7;
            this.weather_button3.Text = "주간날씨";
            this.weather_button3.UseVisualStyleBackColor = true;
            this.weather_button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // weather_label2
            // 
            this.weather_label2.AutoSize = true;
            this.weather_label2.Location = new System.Drawing.Point(510, 112);
            this.weather_label2.Name = "weather_label2";
            this.weather_label2.Size = new System.Drawing.Size(22, 12);
            this.weather_label2.TabIndex = 9;
            this.weather_label2.Text = "lon";
            // 
            // weather_textBox2
            // 
            this.weather_textBox2.Location = new System.Drawing.Point(556, 109);
            this.weather_textBox2.Name = "weather_textBox2";
            this.weather_textBox2.Size = new System.Drawing.Size(100, 21);
            this.weather_textBox2.TabIndex = 8;
            // 
            // weather_button1
            // 
            this.weather_button1.Location = new System.Drawing.Point(158, 32);
            this.weather_button1.Name = "weather_button1";
            this.weather_button1.Size = new System.Drawing.Size(72, 58);
            this.weather_button1.TabIndex = 10;
            this.weather_button1.Text = "포항";
            this.weather_button1.UseVisualStyleBackColor = true;
            this.weather_button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // weather_button4
            // 
            this.weather_button4.Location = new System.Drawing.Point(268, 32);
            this.weather_button4.Name = "weather_button4";
            this.weather_button4.Size = new System.Drawing.Size(72, 58);
            this.weather_button4.TabIndex = 11;
            this.weather_button4.Text = "대구";
            this.weather_button4.UseVisualStyleBackColor = true;
            this.weather_button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.weather_button4);
            this.Controls.Add(this.weather_button1);
            this.Controls.Add(this.weather_label2);
            this.Controls.Add(this.weather_textBox2);
            this.Controls.Add(this.weather_button3);
            this.Controls.Add(this.weather_button2);
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
        private System.Windows.Forms.RichTextBox weather_richTextBox1;
        private System.Windows.Forms.Label weather_label1;
        private System.Windows.Forms.Button weather_button2;
        private System.Windows.Forms.Button weather_button3;
        private System.Windows.Forms.Label weather_label2;
        private System.Windows.Forms.TextBox weather_textBox2;
        private System.Windows.Forms.Button weather_button1;
        private System.Windows.Forms.Button weather_button4;
    }
}

