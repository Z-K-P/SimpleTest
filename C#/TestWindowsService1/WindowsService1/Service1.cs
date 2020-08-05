using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Timers;
using System.IO;
namespace WindowsService1
{
    public partial class Service1 : ServiceBase
    {
        /// <summary>
        /// 服务初始化构造方法
        /// </summary>
        public Service1()
        {
            InitializeComponent();
            //声明一个定时器，每2秒执行一次
            System.Timers.Timer timer = new System.Timers.Timer();
             //为执行器事件的委托绑定方法
            timer.Elapsed += new System.Timers.ElapsedEventHandler(TimedEvent);
            timer.Interval = 2000;
            timer.Enabled = true;
        }
        /// <summary>
        /// 定时执行的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimedEvent(object sender, ElapsedEventArgs e)
        {
            this.ServerMain("服务正在运行");
        }
        /// <summary>
        /// 服务执行状态
        /// </summary>
        /// <param name="message"></param>
        private void ServerMain(string message)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\ServerTest.log";
            FileInfo file = new FileInfo(path);
            if (!file.Exists)
            {
                FileStream fs = File.Create(path);
            fs.Close();
            }

        FileStream fileStream = new FileStream(path, FileMode.Append, FileAccess.Write);
        StreamWriter writer = new StreamWriter(fileStream);
        writer.WriteLine(DateTime.Now.ToString() + "  " + message);
             writer.Close();
        }
        /// <summary>
        ///启动服务时执行的方法
        ///
        /// </summary>
        /// <param name="args"></param>
        protected override void OnStart(string[] args)
        {
            this.ServerMain("服务启动");
        }
        /// <summary>
        ///关闭服务时执行的方法
        /// 
        /// </summary>
        protected override void OnStop()
        {
            this.ServerMain("服务停止");
        }
        }
    }
