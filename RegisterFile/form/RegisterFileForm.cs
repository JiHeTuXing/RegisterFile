using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace RegisterFile
{
    public partial class RegisterFileForm : Form
    {
        /// <summary>
        /// 窗体初始化
        /// </summary>
        public RegisterFileForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 鼠标双击文件夹选择匡
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbDir_MouseDoubleClick(object sender, MouseEventArgs e)
        {
             DialogResult dirResult = dlgFolderBrowser.ShowDialog();
             if (dirResult.Equals(DialogResult.OK))
             {
                 tbDir.Text = dlgFolderBrowser.SelectedPath;
             }
        }

        /// <summary>
        /// 点击开始按键，开始注册
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            //1. 检测输入合法性
            if (!checkFileDirAndType(tbDir.Text, cbFileType.Text))
            {
                setTextSafe(rtbInfo, "检测合法性失败！");
                return;
            }

            //2. 获取文件列表
            string[] fileList = getFileList(tbDir.Text, cbFileType.Text);
            if(null == fileList || 0 == fileList.Length)
            {
                setTextSafe(rtbInfo, "获取文件失败！");
                return;
            }

            //3. 注册文件
            registerTheFile(fileList);
        }

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterFileForm_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// 检查文件夹格式与后缀的合法性
        /// </summary>
        /// <returns></returns>
        private bool checkFileDirAndType(String dir, String type)
        {
            if (dir.Equals("") || type.Equals(""))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 获取文件列表
        /// </summary>
        /// <returns></returns>
        private string[] getFileList(String dir, String type)
        {
            return System.IO.Directory.GetFiles(dir, type, System.IO.SearchOption.TopDirectoryOnly);
        }

        /// <summary>
        /// 注册文件
        /// </summary>
        /// <param name="fileList"></param>
        /// <returns></returns>
        private void registerTheFile(string[] fileList)
        {
            //功能切换
            if (btnStart.Text.Equals("开始注册"))
            {
                btnStart.Text = "停止注册";
            }
            else
            {
                btnStart.Text = "开始注册";
            }

            //创建注册线程
            if (null == registerThread || System.Threading.ThreadState.Stopped == registerThread.ThreadState)
            {
                registerThread = new Thread(delegate()
                {

                    for (int i = 0; i < progBarRegister.Maximum; ++i)
                    {
                        if (btnStart.Text.Equals("开始注册"))
                        {
                            break;
                        }

                        Process p = new Process();
                        p.StartInfo.FileName = "Regsvr32.exe";

                        p.StartInfo.Arguments = " /s " + "\"" + fileList[i] + "\"";
                        p.Start();
            
                        setTextSafe(rtbInfo, (i + 1) + "/" + progBarRegister.Maximum + "\r" + fileList[i]);
                        progBarRegister_setValue(i + 1);
                    }
             
                });
            }

            progBarRegister.Maximum = fileList.Length;
            progBarRegister.Value = 0;

            //若线程正在执行
            if (registerThread.IsAlive)
            {
                return;
            }

            registerThread.Start();
        }

        /// <summary>
        /// 简单的显示信息
        /// </summary>
        /// <param name="strs">要显示的字符</param>
        private void setTextSafe(Control c,string strs)
        {
            if (c.InvokeRequired)
            {
                SetTextCallback b = new SetTextCallback(setTextSafe);
                rtbInfo.Invoke(b, c, strs);
            }
            else
            {
                c.Text = strs;
                c.Update();
            }
        }

        /// <summary>
        /// 设置进度条，支持非UI线程调用
        /// </summary>
        /// <param name="value"></param>
        private void progBarRegister_setValue(int value)
        {
            if (progBarRegister.InvokeRequired)
            {
                SetProgBarValueCallback cb = new SetProgBarValueCallback(progBarRegister_setValue);
                progBarRegister.Invoke(cb, value);
            }
            else
            {
                progBarRegister.Value = value;
            }
        }



        /// <summary>
        /// 窗体关闭后触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterFileForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (null != registerThread && registerThread.IsAlive)
            {
                registerThread.Abort();//窗口关闭后关闭线程
            }
        }

        /// <summary>
        /// 设置文字委托
        /// </summary>
        /// <param name="value"></param>
        private delegate void SetTextCallback(Control c, string value);

        /// <summary>
        /// 设置进度条委托
        /// </summary>
        /// <param name="value"></param>
        private delegate void SetProgBarValueCallback(int value);

        /// <summary>
        /// 注册线程
        /// 
        private Thread registerThread;
        
    }
}
