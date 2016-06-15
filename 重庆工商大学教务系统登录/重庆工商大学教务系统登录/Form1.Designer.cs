namespace 重庆工商大学教务系统登录
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_login = new System.Windows.Forms.Button();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_psd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_html = new System.Windows.Forms.TextBox();
            this.pictureBox_Code = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Code = new System.Windows.Forms.TextBox();
            this.button_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Code)).BeginInit();
            this.SuspendLayout();
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(220, 12);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(75, 58);
            this.button_login.TabIndex = 0;
            this.button_login.Text = "登录";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(69, 12);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(141, 21);
            this.textBox_id.TabIndex = 1;
            this.textBox_id.Text = "2015011310";
            // 
            // textBox_psd
            // 
            this.textBox_psd.Location = new System.Drawing.Point(69, 49);
            this.textBox_psd.Name = "textBox_psd";
            this.textBox_psd.PasswordChar = '*';
            this.textBox_psd.Size = new System.Drawing.Size(141, 21);
            this.textBox_psd.TabIndex = 2;
            this.textBox_psd.Text = "zmd0412369+";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "学 号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "密 码：";
            // 
            // textBox_html
            // 
            this.textBox_html.Location = new System.Drawing.Point(12, 139);
            this.textBox_html.Multiline = true;
            this.textBox_html.Name = "textBox_html";
            this.textBox_html.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_html.Size = new System.Drawing.Size(792, 468);
            this.textBox_html.TabIndex = 5;
            // 
            // pictureBox_Code
            // 
            this.pictureBox_Code.BackColor = System.Drawing.Color.Silver;
            this.pictureBox_Code.Location = new System.Drawing.Point(69, 82);
            this.pictureBox_Code.Name = "pictureBox_Code";
            this.pictureBox_Code.Size = new System.Drawing.Size(72, 27);
            this.pictureBox_Code.TabIndex = 6;
            this.pictureBox_Code.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "验证码：";
            // 
            // textBox_Code
            // 
            this.textBox_Code.Location = new System.Drawing.Point(147, 88);
            this.textBox_Code.Name = "textBox_Code";
            this.textBox_Code.Size = new System.Drawing.Size(83, 21);
            this.textBox_Code.TabIndex = 8;
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(236, 82);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(43, 29);
            this.button_refresh.TabIndex = 9;
            this.button_refresh.Text = "刷新";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 619);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.textBox_Code);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox_Code);
            this.Controls.Add(this.textBox_html);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_psd);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.button_login);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Code)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_psd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_html;
        private System.Windows.Forms.PictureBox pictureBox_Code;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Code;
        private System.Windows.Forms.Button button_refresh;
    }
}

