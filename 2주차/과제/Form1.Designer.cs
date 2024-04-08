namespace Exercise02_8
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
            this.button1 = new System.Windows.Forms.Button();
            this.rdo_line = new System.Windows.Forms.RadioButton();
            this.rdo_circle = new System.Windows.Forms.RadioButton();
            this.rdo_box = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_red = new System.Windows.Forms.Button();
            this.btn_yellow = new System.Windows.Forms.Button();
            this.btn_blue = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(49, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "화면 초기화";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdo_line
            // 
            this.rdo_line.AutoSize = true;
            this.rdo_line.Checked = true;
            this.rdo_line.Location = new System.Drawing.Point(13, 15);
            this.rdo_line.Name = "rdo_line";
            this.rdo_line.Size = new System.Drawing.Size(35, 16);
            this.rdo_line.TabIndex = 1;
            this.rdo_line.TabStop = true;
            this.rdo_line.Text = "선";
            this.rdo_line.UseVisualStyleBackColor = true;
            this.rdo_line.CheckedChanged += new System.EventHandler(this.rdo_line_CheckedChanged);
            // 
            // rdo_circle
            // 
            this.rdo_circle.AutoSize = true;
            this.rdo_circle.Location = new System.Drawing.Point(68, 15);
            this.rdo_circle.Name = "rdo_circle";
            this.rdo_circle.Size = new System.Drawing.Size(35, 16);
            this.rdo_circle.TabIndex = 2;
            this.rdo_circle.Text = "원";
            this.rdo_circle.UseVisualStyleBackColor = true;
            this.rdo_circle.CheckedChanged += new System.EventHandler(this.rdo_circle_CheckedChanged);
            // 
            // rdo_box
            // 
            this.rdo_box.AutoSize = true;
            this.rdo_box.Location = new System.Drawing.Point(120, 15);
            this.rdo_box.Name = "rdo_box";
            this.rdo_box.Size = new System.Drawing.Size(59, 16);
            this.rdo_box.TabIndex = 3;
            this.rdo_box.Text = "사각형";
            this.rdo_box.UseVisualStyleBackColor = true;
            this.rdo_box.CheckedChanged += new System.EventHandler(this.rdo_box_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_box);
            this.groupBox1.Controls.Add(this.rdo_circle);
            this.groupBox1.Controls.Add(this.rdo_line);
            this.groupBox1.Location = new System.Drawing.Point(192, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 43);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "종류";
            // 
            // btn_red
            // 
            this.btn_red.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_red.Location = new System.Drawing.Point(192, 75);
            this.btn_red.Name = "btn_red";
            this.btn_red.Size = new System.Drawing.Size(48, 23);
            this.btn_red.TabIndex = 5;
            this.btn_red.Text = "빨강";
            this.btn_red.UseVisualStyleBackColor = false;
            this.btn_red.Click += new System.EventHandler(this.btn_red_Click);
            // 
            // btn_yellow
            // 
            this.btn_yellow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_yellow.Location = new System.Drawing.Point(246, 75);
            this.btn_yellow.Name = "btn_yellow";
            this.btn_yellow.Size = new System.Drawing.Size(49, 23);
            this.btn_yellow.TabIndex = 6;
            this.btn_yellow.Text = "노랑";
            this.btn_yellow.UseVisualStyleBackColor = false;
            this.btn_yellow.Click += new System.EventHandler(this.btn_yellow_Click);
            // 
            // btn_blue
            // 
            this.btn_blue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_blue.Location = new System.Drawing.Point(301, 75);
            this.btn_blue.Name = "btn_blue";
            this.btn_blue.Size = new System.Drawing.Size(45, 23);
            this.btn_blue.TabIndex = 7;
            this.btn_blue.Text = "파랑";
            this.btn_blue.UseVisualStyleBackColor = false;
            this.btn_blue.Click += new System.EventHandler(this.btn_blue_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(352, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 18);
            this.button2.TabIndex = 8;
            this.button2.Text = "검정";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 419);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_blue);
            this.Controls.Add(this.btn_yellow);
            this.Controls.Add(this.btn_red);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "연습문제 ";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdo_line;
        private System.Windows.Forms.RadioButton rdo_circle;
        private System.Windows.Forms.RadioButton rdo_box;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_red;
        private System.Windows.Forms.Button btn_yellow;
        private System.Windows.Forms.Button btn_blue;
        private System.Windows.Forms.Button button2;
    }
}

