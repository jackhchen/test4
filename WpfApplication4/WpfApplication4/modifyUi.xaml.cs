using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApplication4
{
    /// <summary>
    /// 子线程修改主线程的ui（用同步和异步的方法）
    /// </summary>
    public partial class modifyUi : Window
    {
        public modifyUi()
        {
            InitializeComponent();
        }

        private void btnAppBeginInvoke_Click(object sender, RoutedEventArgs e)
        {
            new Thread(() =>
            {
                this.Dispatcher.BeginInvoke(
                    new Action(() =>
                    {
                        Thread.Sleep(TimeSpan.FromSeconds(2));
                        this.lblHello.Content = "欢迎jack，异步方法" + DateTime.Now.ToString(); 

                    }), DispatcherPriority.Normal);

               // Thread.Sleep(TimeSpan.FromSeconds(2));
               // this.lblHello.Content = "欢迎jack，异步方法" + DateTime.Now.ToString(); ;
            }).Start();
        }

        private void modifyUi_fun()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            //lblHello.Content = "已经改变了，jack";
            this.Dispatcher.Invoke((ThreadStart)delegate ()
            {
                lblHello.Content = "已经改变了，jack,同步方法";
            }, DispatcherPriority.Normal);

        }

        private void btnThd_Click(object sender, RoutedEventArgs e)
        {
            Thread thread = new Thread(modifyUi_fun);
            thread.Start();

        }
    }
}
