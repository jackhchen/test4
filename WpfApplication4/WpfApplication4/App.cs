using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApplication4
{
    class App
    {

        #region 第一种方法
        /// <summary>
        /// 第一种方法
        /// </summary>
        [STAThread]
        static void Main1()
        {
            //定义application对象为着呢哥哥应用程序的入口
            Application app = new Application();
            //方法一调用run方法，这种方法跟winforn的调用一样
            MainWindow win = new MainWindow();
            app.Run(win);
            MessageBox.Show("1");

        }
        #endregion

        #region 第二种方法
        /// <summary>
        /// 第二种方法
        /// </summary>
        [STAThread]
        static void Main2()
        {
            //定义application对象为着呢哥哥应用程序的入口
            Application app = new Application();
            //方法一调用run方法，这种方法跟winforn的调用一样
            MainWindow win = new MainWindow();
            app.MainWindow = win;
            win.Show();
            app.Run();
            MessageBox.Show("2");


        }
        #endregion

        #region 第三种方法
        /// <summary>
        /// 第三种方法（通过url的方式）
        /// </summary>
        [STAThread]
        static void Main()
        {
            //定义application对象为着呢哥哥应用程序的入口
            Application app = new Application();
            app.StartupUri = new Uri("MainWindow.xaml", UriKind.Relative);
            app.ShutdownMode = ShutdownMode.OnLastWindowClose;//设置关闭wpf应用程序模式
            app.Run();
            app.Activated += app_Activated;
            app.Exit += app_Exit;

            MessageBox.Show("3");


        }

        static void app_Activated(object sender, EventArgs e)
        {
            MessageBox.Show("app_Activated");
            //throw new NotImplementedException();
        }

        static void app_Exit(object sender, EventArgs e)
        {
            MessageBox.Show("app_Exit");
            //throw new NotImplementedException();
        }

        #endregion

    }
}
