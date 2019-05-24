using System;
using System.Windows.Threading;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;

namespace ScreenWatcher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        DispatcherTimer sendkey;
        DateTime start;

        public MainWindow()
        {
            InitializeComponent();

            timer = new DispatcherTimer(new TimeSpan(0, 0, 0, 0, 50), DispatcherPriority.Background, Timer_Tick, Dispatcher.CurrentDispatcher);
            sendkey = new DispatcherTimer(new TimeSpan(0,1,0), DispatcherPriority.Background, Timer_Sendkey, Dispatcher.CurrentDispatcher);
            timer.IsEnabled = true;
            sendkey.IsEnabled = true;
            start = DateTime.Now;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //labelTimer.Content = Convert.ToString(DateTime.Now - start);
            labelTimer.Content = String.Format("{0:00}:{1:00}:{2:00}", (DateTime.Now - start).TotalHours, (DateTime.Now - start).TotalMinutes, (DateTime.Now - start).TotalSeconds);
            
        }

        private void Timer_Sendkey(object sender, EventArgs e)
        {
            SendKeys.SendWait("{NUMLOCK}");
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
        }

        /// Close button action
        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        /// Minimize button action
        private void ButtonMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        /// Allow window to be dragged without a WindowStyle
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            /// Begin dragging the window
            this.DragMove();
        }
    }
}
