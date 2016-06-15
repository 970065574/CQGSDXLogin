using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace 重庆工商大学教务系统登录
{
    class Visitor
    {
        private string id;
        private string psd;
        private string value;
        private string cookieStore;
        private string imageCode;
        private bool loginState;
        public Visitor()
        {
            cookieStore = string.Empty;
        }
        public Visitor(string std,string pwd)
        {
            id = std;
            psd = pwd;
            cookieStore = string.Empty;
        }
        public bool LoginState
        {
            get { return loginState; }
        }
        public void SetStdInfo(string ID,string pwd)
        {
            id = ID;
            psd = pwd;
        }
        public string ImageCode
        {
            set { imageCode = value; }
        }
        public HttpResult Go2FirstPage()
        {
            HttpHelper help = new HttpHelper();
            HttpResult result= new HttpResult();
            HttpItem item = new HttpItem()
            {
                URL = "http://jwsys.ctbu.edu.cn/",
                KeepAlive = true,
                UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:35.0) Gecko/20100101 Firefox/35.0",
                Method = "get",
                Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8"
            };
            result = help.GetHtml(item);
            GetValue(result);   
            string cookie = result.Cookie;
            cookieStore = cookie.Replace("path=/,", "");
            //Console.WriteLine("Cookie: " + cookieStore);
            return result;
        }
        private void GetValue(HttpResult result)
        {
            string html = result.Html;
            string pattern = "<input type=\"hidden\" name=\"__VIEWSTATE\" +\\S+";
            Match match = Regex.Match(html, pattern);
            string s = match.ToString().Replace("<input type=\"hidden\" name=\"__VIEWSTATE\"", "");
            s = s.Replace("\"", "");
            s = s.Replace("value=", "");
            value = s.Trim();
            Console.WriteLine("Value: " + value);
        }
        public Image GetImg()
        {
            HttpHelper helper = new HttpHelper();
            HttpResult result = new HttpResult();
            HttpItem item = new HttpItem()
            {
                URL= "http://jwsys.ctbu.edu.cn/CheckCode.aspx",
                Method = "get",
                Accept = "image/png,image/*;q=0.8,*/*;q=0.5",
                KeepAlive = true,
                Cookie = cookieStore,
                Referer = "http://jwsys.ctbu.edu.cn/",
                ResultType = ResultType.Byte,
                UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:35.0) Gecko/20100101 Firefox/35.0",
            };
            result = helper.GetHtml(item);           
            return byteArrayToImage(result.ResultByte);
        }       
        private Image byteArrayToImage(byte[] Bytes)
        {
            MemoryStream ms = new MemoryStream(Bytes);
            return Bitmap.FromStream(ms, true);
        }
        public HttpResult Login()
        {
            psd = GetStringfromSymbol(psd);
            HttpHelper helper = new HttpHelper();
            HttpResult result = new HttpResult();
            HttpItem item = new HttpItem()
            {
                URL = "http://jwsys.ctbu.edu.cn/Default2.aspx",
                Method = "post",
                Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8",
                KeepAlive = true,
                Cookie = cookieStore,
                Postdata= "__VIEWSTATE="+value+ "&txtUserName="+id+ "&TextBox2="+psd+ "&txtSecretCode="+imageCode+ "&RadioButtonList1=%D1%A7%C9%FA&Button1=&lbLanguage=",
                Referer = "http://jwsys.ctbu.edu.cn/",
                UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:35.0) Gecko/20100101 Firefox/35.0",
                ContentType = "application/x-www-form-urlencoded",
            };           
            result = helper.GetHtml(item);
            if (result.Html.Contains("alert('验证码不正确！！')"))
            {
                //throw new Exception("验证码不正确！！！");
            }
            return result;
        }
        private string GetStringfromSymbol(string s)
        {
            return  System.Uri.EscapeDataString(s);
        }
        public Image RefreshImage()
        {
            HttpHelper helper = new HttpHelper();
            HttpResult result = new HttpResult();
            HttpItem item = new HttpItem()
            {
                URL = "http://jwsys.ctbu.edu.cn/CheckCode.aspx?",
                Accept = "image/png,image/*;q=0.8,*/*;q=0.5",
                KeepAlive = true,
                Cookie = cookieStore,
                Referer = "http://jwsys.ctbu.edu.cn/",
                UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:35.0) Gecko/20100101 Firefox/35.0",
                ResultType = ResultType.Byte
            };
            result = helper.GetHtml(item);
            return byteArrayToImage(result.ResultByte);
        }
    }
}
