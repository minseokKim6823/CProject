namespace GUI_project
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
			this.buttonAdmin = new System.Windows.Forms.Button();
			this.textBox_ID = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox_PW = new System.Windows.Forms.TextBox();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("굴림", 24F);
			this.button1.Location = new System.Drawing.Point(190, 270);
			this.button1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(254, 116);
			this.button1.TabIndex = 0;
			this.button1.Text = "시작하기";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// buttonAdmin
			// 
			this.buttonAdmin.Font = new System.Drawing.Font("굴림", 24F);
			this.buttonAdmin.Location = new System.Drawing.Point(190, 185);
			this.buttonAdmin.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.buttonAdmin.Name = "buttonAdmin";
			this.buttonAdmin.Size = new System.Drawing.Size(254, 116);
			this.buttonAdmin.TabIndex = 2;
			this.buttonAdmin.Text = "관리자테스트";
			this.buttonAdmin.UseVisualStyleBackColor = true;
			this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
			// 
			// textBox_ID
			// 
			this.textBox_ID.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textBox_ID.Location = new System.Drawing.Point(190, 195);
			this.textBox_ID.Multiline = true;
			this.textBox_ID.Name = "textBox_ID";
			this.textBox_ID.Size = new System.Drawing.Size(177, 32);
			this.textBox_ID.TabIndex = 3;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(405, 256);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(117, 32);
			this.button3.TabIndex = 4;
			this.button3.Text = "로그인";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// textBox_PW
			// 
			this.textBox_PW.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.textBox_PW.Location = new System.Drawing.Point(190, 252);
			this.textBox_PW.Multiline = true;
			this.textBox_PW.Name = "textBox_PW";
			this.textBox_PW.PasswordChar = '●';
			this.textBox_PW.Size = new System.Drawing.Size(177, 32);
			this.textBox_PW.TabIndex = 5;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(250, 305);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(117, 36);
			this.button4.TabIndex = 6;
			this.button4.Text = "회원가입";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(405, 195);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(117, 32);
			this.button5.TabIndex = 7;
			this.button5.Text = "관리자 로그인";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(707, 478);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.textBox_PW);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.textBox_ID);
			this.Controls.Add(this.buttonAdmin);
			this.Controls.Add(this.button1);
			this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAdmin;
		private System.Windows.Forms.TextBox textBox_ID;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox textBox_PW;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
	}
}

