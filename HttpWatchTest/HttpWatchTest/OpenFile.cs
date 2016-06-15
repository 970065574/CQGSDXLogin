using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HttpWatchTest
{
    static class FileEditor
    {
        public static string OpenFile_()
        {
            string path=null;
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "httpwatch记录文件|*.hwl";
            if(openFile.ShowDialog()==DialogResult.OK)
            {
                path = openFile.FileName;
            }
            return path;
        }
        public static string SaveFile_()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "httpwatch记录文件|*.hwl";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string localFilePath = saveFileDialog.FileName;
                //string fileNameExt = localFilePath.Substring(localFilePath.LastIndexOf("\\"));
                //string filePath = localFilePath.Substring(0, localFilePath.LastIndexOf("\\"));
                ////string newFileName = DateTime.Now.ToString("yyyymmdd") + fileNameExt;
                //System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog.OpenFile();
                return localFilePath;
            }
            else
                return null;
        }
    }
}
