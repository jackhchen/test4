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
    /// Interaction logic for WrapPanel.xaml
    /// </summary>
    public partial class WrapPanel : Window
    {
        public WrapPanel()
        {
            InitializeComponent();
        }

        private void Window_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.wrap1.Children.Clear();
            this.wrap1.Margin = new Thickness(0, 0, 0, 0);
            this.wrap1.Background = new SolidColorBrush(Colors.White);

            //遍历textblock
            TextBlock block;
            for (int i = 0; i < 10; i++)
            {
                block = new TextBlock();
                block.Text = "jack：" + i.ToString();
                block.Margin = new Thickness(0, 0, 0, 0);
                block.Width = 160;
                block.Height = 30;
                this.wrap1.Children.Add(block);
            }




        }
    }
}
