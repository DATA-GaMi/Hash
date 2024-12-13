using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Force.Crc32;

namespace Hash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox1.AllowDrop = true;
            richTextBox1.DragEnter += new DragEventHandler(RichTextBox1_DragEnter);
            richTextBox1.DragDrop += new DragEventHandler(RichTextBox1_DragDrop);
        }

        private void RichTextBox1_DragDrop(object sender, DragEventArgs e)
        {
            // 获取拖拽的数据
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string filepath = "";
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string file in files)
                {
                    // 在RichTextBox中显示文件路径
                    filepath = file + Environment.NewLine;
                }

                progressBar2.Value = 0;
                progressBar2.Maximum = 1;


                progressBar1.Value = 0;
                int totalsteps = 5;

                if (richTextBox1.Text != "")
                {
                   richTextBox1.AppendText("\n\n");
                }

                richTextBox1.AppendText("文件路径: " + filepath.Trim() + "\n");
                if (Get_fileversion(filepath) != "")
                {
                   AppendTextWithProgress(Get_fileversion(filepath), totalsteps);
                }
                else
                {
                    AppendTextWithProgress(totalsteps);
                }
                AppendTextWithProgress(Get_filedate(filepath), totalsteps);
                AppendTextWithProgress(GetMD5HashFromFile(filepath), totalsteps);
                AppendTextWithProgress(GetSHA1HashFromFile(filepath), totalsteps);
                AppendTextWithProgress(GetCRC32HashFromFile(filepath), totalsteps);

                    //MessageBox.Show((i).ToString());
                TotalProgress(1);
            }
        }
        

        private void RichTextBox1_DragEnter(object sender, DragEventArgs e)
        {
            // 如果拖拽的数据是文件，设置拖拽效果为Copy
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
        }

        /// <summary>
        /// 获取程序文件的日期
        /// </summary>
        private string Get_fileversion(string filepath)
        {
            //string filepath = "";
            FileVersionInfo fileversioninfo = FileVersionInfo.GetVersionInfo(filepath);
            //MessageBox.Show(fileversioninfo.FileVersion.ToString());
            if (fileversioninfo!=null && !string.IsNullOrEmpty(fileversioninfo.FileVersion))
            {
                if(versionbox.Checked)
                {
                    return "文件版本: " + fileversioninfo.FileVersion;
                }
                
            }
            return "";
        }

        /// <summary>
        /// 获取程序文件的修改日期
        /// </summary>
        private string Get_filedate(string filepath)
        {
            FileInfo fileInfo = new FileInfo(filepath.Trim());
            DateTime lastModifedtime = fileInfo.LastWriteTime;
            if (datebox.Checked)
            {
                return "修改时间: " + lastModifedtime.ToString();
            }
            return "";
        }

        /// <summary>
        /// 获取程序文件的全路径
        /// </summary>
        private static void Get_filepath()
        {
            
        }


        /// <summary>
        /// 获取程序文件的大小
        /// </summary>
        private static void Get_filesize()
        {
            
        }

        private string GetMD5HashFromFile(string filepath)
        {
            if (md5box.Checked)
            {
                using (FileStream fileStream = File.OpenRead(filepath.Trim()))
                {
                    using (MD5 md5 = MD5.Create())
                    {
                        byte[] hash = md5.ComputeHash(fileStream);
                        return "MD5: " + BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                    }
                }
            }
            return "";
        }


        private string GetSHA1HashFromFile(string filepath)
        {
            if (sha1box.Checked)
            {
                using (FileStream fileStream = File.OpenRead(filepath.Trim()))
                {
                    using (SHA1 sha1 = SHA1.Create())
                    {
                        byte[] hash = sha1.ComputeHash(fileStream);
                        return "SHA1: " + BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                    }
                }
            }
            return "";
        }

        private string GetCRC32HashFromFile(string fileName)
        {
            
            if(crc32box.Checked)
            {
                byte[] filedata = File.ReadAllBytes(fileName.Trim());
                uint crc = Crc32Algorithm.Compute(filedata, 0, filedata.Length);
                return "CRC32: " + crc.ToString("X8");
            }
            return null;
        }


        private void AppendTextWithProgress(string text,int totalsteps)
        {
            richTextBox1.AppendText(text + "\n");
            progressBar1.Value += 100 / totalsteps;
            progressBar1.Refresh();
        }

        private void AppendTextWithProgress(int totalsteps)
        {
            progressBar1.Value += 100 / totalsteps;
            progressBar1.Refresh();
        }

        private void TotalProgress(int Total,int totalsteps)
        {
            progressBar2.Value += Total/ totalsteps;
            progressBar2.Refresh();
        }

        private void TotalProgress(int totalsteps)
        {
            progressBar2.Value += totalsteps / totalsteps;
            progressBar2.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                richTextBox1.AppendText("\n\n");
            }
            string[] filepaths= { };
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "All Files|*.*";
            openFileDialog1.Title = "选择文件";
            openFileDialog1.Multiselect = true;

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filepaths = openFileDialog1.FileNames;
            }

            //重置并显示进度条
            
            progressBar2.Value = 0;
            progressBar2.Maximum = filepaths.Length;
            

            for (int i = 0; i < filepaths.Length; i++)
            {
                progressBar1.Value = 0;
                int totalsteps = 5;

                if (richTextBox1.Text != "")
                {
                    richTextBox1.AppendText("\n\n");
                }

                richTextBox1.AppendText("文件路径: " + filepaths[i] + "\n");
                if (Get_fileversion(filepaths[i]) != "")
                {
                    AppendTextWithProgress(Get_fileversion(filepaths[i]), totalsteps);
                }
                else
                {
                    AppendTextWithProgress(totalsteps);
                }
                AppendTextWithProgress(Get_filedate(filepaths[i]), totalsteps);
                AppendTextWithProgress(GetMD5HashFromFile(filepaths[i]), totalsteps);
                AppendTextWithProgress(GetSHA1HashFromFile(filepaths[i]), totalsteps);
                AppendTextWithProgress(GetCRC32HashFromFile(filepaths[i]), totalsteps);

                //MessageBox.Show((i).ToString());
                TotalProgress(filepaths.Length);
            }
        }

        private void copy_button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBox1.Text))
            {
                // 将文本复制到剪贴板
                Clipboard.SetText(richTextBox1.Text);
            }
        }
    }
}
