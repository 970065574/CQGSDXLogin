using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HttpWatch;
namespace HttpWatchTest
{
    public partial class Form1 : Form
    {
        Controller controller;
        Log log;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            log = controller.OpenLog(FileEditor.OpenFile_());
            Console.WriteLine("The log file contains " + log.Entries.Count + " entries");
            Plugin plugin = controller.Firefox.New();
            plugin.Log.EnableFilter(false);
            plugin.Clear();
            plugin.Record();
            plugin.GotoURL("www.baidu.com");
            controller.Wait(plugin, -1);
            plugin.Stop();
            plugin.Log.Save( FileEditor.SaveFile_());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            controller = new Controller();
        }
    }
}
