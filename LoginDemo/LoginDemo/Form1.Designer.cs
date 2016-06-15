namespace LoginDemo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView_UrlSelect = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Column_WebName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Url = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_UrlSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "网站选择";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(499, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "配置数据导入";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(582, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView_UrlSelect
            // 
            this.dataGridView_UrlSelect.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_UrlSelect.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView_UrlSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_UrlSelect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_WebName,
            this.Column_Url});
            this.dataGridView_UrlSelect.Location = new System.Drawing.Point(12, 36);
            this.dataGridView_UrlSelect.Name = "dataGridView_UrlSelect";
            this.dataGridView_UrlSelect.RowTemplate.Height = 23;
            this.dataGridView_UrlSelect.Size = new System.Drawing.Size(441, 261);
            this.dataGridView_UrlSelect.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(476, 36);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(382, 261);
            this.textBox1.TabIndex = 6;
            // 
            // Column_WebName
            // 
            this.Column_WebName.HeaderText = "Name";
            this.Column_WebName.Name = "Column_WebName";
            this.Column_WebName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column_WebName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column_Url
            // 
            this.Column_Url.HeaderText = "URL";
            this.Column_Url.Name = "Column_Url";
            this.Column_Url.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column_Url.Width = 300;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 682);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView_UrlSelect);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_UrlSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView_UrlSelect;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_WebName;
        private System.Windows.Forms.DataGridViewLinkColumn Column_Url;
    }
}

