using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 重庆工商大学教务系统登录
{
    public partial class Form1 : Form
    {
        Visitor viser;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            HttpResult result=new HttpResult();
            if(textBox_id.Text==""||textBox_psd.Text=="")
            {
                MessageBox.Show("输入学号和密码！");
                return;
            }
            if(textBox_Code.Text=="")
            {
                MessageBox.Show("输入验证码！");
                return;
            }
            viser.SetStdInfo(textBox_id.Text, textBox_psd.Text);
            viser.ImageCode = textBox_Code.Text;
            try
            {
                result = viser.Login();
                textBox_html.Text = result.Html;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Refreshimg();
                return;
            }
            if(viser.LoginState)
            {
                viser.LodMainPage();
                this.Text = viser.StdName;
                MessageBox.Show("欢迎您，" + viser.StdName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            viser = new Visitor();
            HttpResult Result = new HttpResult();
            Result = viser.Go2FirstPage();
            Refreshimg();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            pictureBox_Code.Image = viser.RefreshImage();
        }
        private void Refreshimg()
        {         
            pictureBox_Code.Image = viser.GetImg();
        }
    }
}
