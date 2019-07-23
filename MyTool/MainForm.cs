using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadAndProcess_Click(object sender, EventArgs e)
        {
            //testClass.IniMapper();
            string fileFullPath = "";
            string filePath = "";
            string fileName = "";
            // 获取文件名       
            OpenFileDialog openfile = new OpenFileDialog
            {
                Filter = "文本文件|*.txt"
            };
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                fileFullPath = openfile.FileName;
                filePath = Path.GetDirectoryName(openfile.FileName);
                fileName = Path.GetFileName(openfile.FileName).Split('.')[0];
            }
            else
            {
                return;
            }
            //处理文件
            string[] lineArray = File.ReadAllLines(fileFullPath);//读取文本文件
            //保存文件
            string newfile = filePath + @"\" + fileName + "_New.txt";
            //写入文件
            FileStream fs = new FileStream(newfile, System.IO.FileMode.Create, System.IO.FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.UTF8);
            for (int i = 0;i< lineArray.Length; i++)
            {
                string tmp = "";
                for (int j = 0;j< lineArray[i].Length;j++)
                {
                    tmp += lineArray[i][j] + "  ";
                }
                sw.WriteLine(tmp);
            }
            sw.Close();
            fs.Close();
        }
    }
}
