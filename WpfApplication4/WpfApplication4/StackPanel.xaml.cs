using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApplication4
{
    /// <summary>
    /// Interaction logic for StackPanel.xaml
    /// </summary>
    public partial class StackPanel : Window
    {
        public StackPanel()
        {
            InitializeComponent();
        }

        private void Window_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            test();
        }

        private void test()
        {
            //StackPanel sp = new StackPanel();

            //把sp添加为窗体的子控件

            //this.Content = sp;
            this.stackPanel.Children.Clear();
            this.stackPanel.Margin = new Thickness(0, 0, 0, 0);

            this.stackPanel.Background = new SolidColorBrush(Colors.White);

            this.stackPanel.Orientation = Orientation.Vertical;

            //Button1

            Button b1 = new Button();

            b1.Content = "后台代码，第一个";

            this.stackPanel.Children.Add(b1);



            //Button2

            Button b2 = new Button();

            b2.Content = "后台代码，第二个";

            this.stackPanel.Children.Add(b2);



            //Button3

            Button b3 = new Button();

            b3.Content = "后台代码，第三个";

            this.stackPanel.Children.Add(b3);

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.stackPanel.Orientation = Orientation.Horizontal;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            test();
        }
    }
}
