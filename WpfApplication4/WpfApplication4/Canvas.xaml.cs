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
    /// Interaction logic for Canvas.xaml
    /// </summary>
    public partial class Canvas : Window
    {
        public Canvas()
        {
            InitializeComponent();
           // DisplayCanvas();
        }

        private void btnByCode_Click(object sender, RoutedEventArgs e)
        {

            DisplayCanvas();

        }

        public void DisplayCanvas()
        {
            //Canvas canv = new Canvas();
            this.can1.Children.Clear();
            //this.Content=canv;
            //this.Content=canv;
            this.can1.Margin = new Thickness(0,0,0,0);
            this.can1.Background = new SolidColorBrush(Colors.White);

            //reactangle
            Rectangle r = new Rectangle();
            r.Fill = new SolidColorBrush(Colors.Red);
            r.Stroke = new SolidColorBrush(Colors.Yellow);
            r.Width = 200;
            r.Height = 140;
            r.SetValue(Panel.ZIndexProperty, 0);
            r.SetValue(Canvas.LeftProperty, (double)200);//设置定位
            r.SetValue(Canvas.TopProperty, (double)120);//设置定位
            this.can1.Children.Add (r);

            //ellipse
            Ellipse el = new Ellipse();
            el.Fill = new SolidColorBrush(Colors.Blue);
            el.Stroke = new SolidColorBrush(Colors.Blue);
            el.Width = 240;
            el.Height = 80;
            el.SetValue(Panel.ZIndexProperty,1);
            el.SetValue(Canvas.LeftProperty, (double)100);
            el.SetValue(Canvas.LeftProperty, (double)80);
            this.can1.Children.Add(el);



        }



    }
}
