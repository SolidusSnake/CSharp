using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using WinForms = System.Windows.Forms;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ScreenWatcher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window  // , INotifyPropertyChanged
    {
        ////Timer timer;
        ////WinForms::Timer timer;
        ////Stopwatch watch;
        ////string elapsedTime = String.Format("{0:00}h {1:00}m {2:00}s", ts.Hours, ts.Minutes, ts.Seconds);
        ///
        DispatcherTimer t;
        DateTime start;

        public MainWindow()
        {
            InitializeComponent();
            ////DataContext = this;
            ///
            t = new DispatcherTimer(new TimeSpan(0, 0, 0, 0, 50), DispatcherPriority.Background, t_Tick, Dispatcher.CurrentDispatcher);
            t.IsEnabled = true;
            start = DateTime.Now;
        }

        private void t_Tick(object sender, EventArgs e)
        {
            labelTimer.Content = Convert.ToString(DateTime.Now - start);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            ////TimeSpan ts = watch.Elapsed;
            ////timer = new WinForms::Timer();
            ////timer.Interval = (5000);
            ////timer.Tick += new EventHandler(timer_Tick);
            //watch = new Stopwatch();
            ////timer.Start();
            //watch.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //// TimeSpan ts = watch.Elapsed;
            //// string elapsedTime = String.Format("{0:00}h {1:00}m {2:00}s", ts.Hours, ts.Minutes, ts.Seconds);
            ////labelTimer.Content = elapsedTime;

            DoEvents();
        }

        /*
        public string Elapsed
        {
            get { return elapsedTime; }
            set
            {
                elapsedTime = value;
                OnPropertyChanged();
            }
        }

        public string SpanTime
        {
            get { ts}
            set
            {

            }
        }
        */

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void ButtonMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        // Allow window to be dragged without a WindowStyle
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            // Begin dragging the window
            this.DragMove();
        }

        public static void DoEvents()
        {
            Application.Current.Dispatcher.Invoke(DispatcherPriority.Background, new Action(delegate { }));
        }
    }
}
