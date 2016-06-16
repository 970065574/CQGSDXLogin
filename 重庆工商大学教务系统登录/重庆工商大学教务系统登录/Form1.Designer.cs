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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView_schedule = new System.Windows.Forms.DataGridView();
            this.label_stdinfo = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Code)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_schedule)).BeginInit();
            this.SuspendLayout();
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(729, 6);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(75, 27);
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
            this.textBox_psd.Location = new System.Drawing.Point(269, 12);
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
            this.label2.Location = new System.Drawing.Point(216, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "密 码：";
            // 
            // textBox_html
            // 
            this.textBox_html.Location = new System.Drawing.Point(12, 606);
            this.textBox_html.Multiline = true;
            this.textBox_html.Name = "textBox_html";
            this.textBox_html.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_html.Size = new System.Drawing.Size(983, 44);
            this.textBox_html.TabIndex = 5;
            // 
            // pictureBox_Code
            // 
            this.pictureBox_Code.BackColor = System.Drawing.Color.Silver;
            this.pictureBox_Code.Location = new System.Drawing.Point(486, 6);
            this.pictureBox_Code.Name = "pictureBox_Code";
            this.pictureBox_Code.Size = new System.Drawing.Size(72, 27);
            this.pictureBox_Code.TabIndex = 6;
            this.pictureBox_Code.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "验证码：";
            // 
            // textBox_Code
            // 
            this.textBox_Code.Location = new System.Drawing.Point(564, 12);
            this.textBox_Code.Name = "textBox_Code";
            this.textBox_Code.Size = new System.Drawing.Size(83, 21);
            this.textBox_Code.TabIndex = 8;
            // 
            // button_refresh
            // 
            this.button_refresh.Location = new System.Drawing.Point(658, 12);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(43, 21);
            this.button_refresh.TabIndex = 9;
            this.button_refresh.Text = "刷新";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(14, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(981, 534);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label_stdinfo);
            this.tabPage1.Controls.Add(this.dataGridView_schedule);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(973, 508);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "课程表";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(973, 508);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView_schedule
            // 
            this.dataGridView_schedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_schedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView_schedule.Location = new System.Drawing.Point(6, 40);
            this.dataGridView_schedule.Name = "dataGridView_schedule";
            this.dataGridView_schedule.RowHeadersVisible = false;
            this.dataGridView_schedule.RowTemplate.Height = 23;
            this.dataGridView_schedule.Size = new System.Drawing.Size(961, 462);
            this.dataGridView_schedule.TabIndex = 0;
            // 
            // label_stdinfo
            // 
            this.label_stdinfo.AutoSize = true;
            this.label_stdinfo.Location = new System.Drawing.Point(6, 16);
            this.label_stdinfo.Name = "label_stdinfo";
            this.label_stdinfo.Size = new System.Drawing.Size(587, 12);
            this.label_stdinfo.TabIndex = 1;
            this.label_stdinfo.Text = "学号：2015011310| 姓名：赵美迪| 学院：经济学院| 专业：经济学| 行政班：15经济学三                 ";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "星期一";
            this.Column1.Name = "Column1";
            this.Column1.Width = 137;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "星期二";
            this.Column2.Name = "Column2";
            this.Column2.Width = 137;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "星期三";
            this.Column3.Name = "Column3";
            this.Column3.Width = 137;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "星期四";
            this.Column4.Name = "Column4";
            this.Column4.Width = 137;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "星期五";
            this.Column5.Name = "Column5";
            this.Column5.Width = 137;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "星期六";
            this.Column6.Name = "Column6";
            this.Column6.Width = 137;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "星期天";
            this.Column7.Name = "Column7";
            this.Column7.Width = 137;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 662);
            this.Controls.Add(this.tabControl1);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Code)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_schedule)).EndInit();
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label_stdinfo;
        private System.Windows.Forms.DataGridView dataGridView_schedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

