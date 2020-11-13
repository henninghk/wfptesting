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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Timer = System.Timers.Timer;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BeginAnimations();
        }

        public void BeginAnimations()
        {
            MoveAllEnemies();
        }
        public void MoveAllEnemies()
        {
            MoveEnemy1();
        }
        public void MoveEnemy1()
        {
                Point startPoint = new Point(300,20);
                Point endPoint = new Point(300,200);

                var toEndPoint = new DoubleAnimation(Canvas.GetLeft(rectAnimation), endPoint.X, new Duration(TimeSpan.FromSeconds(5)));
                var toStartPoint = new DoubleAnimation(endPoint.X, startPoint.X, new Duration(TimeSpan.FromSeconds(5)));
                while (true)
                {
                    //TwoSecondTimer();
                    rectAnimation.BeginAnimation(Canvas.LeftProperty, toEndPoint);
                    //TwoSecondTimer();
                    if (Canvas.GetLeft(rectAnimation).X == 300) 
                    {
                        rectAnimation.BeginAnimation(Canvas.RightProperty, toStartPoint);
                    }
                }
        }
        //fix timeren
        //lag solstråler og få de til å spinne rundt sola?
        //lag bakgrunn? 

        private void keyisdown(object sender, KeyEventArgs e)
        {

        }

        private void keyisup(object sender, KeyEventArgs e)
        {

        }

        private void TwoSecondTimer()
        {
            Timer t1 = new Timer();
            t1.Interval = 10000;
            t1.Start();
        }

        
    }
}
