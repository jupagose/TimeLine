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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TimeLineControl;

namespace TimeLineTestApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TimeLineData = new TimeLineData()
                .Initialize(DurationUnit.Seconds, 5, 0.3);
            TimeLineData
                .AddEntry(TimeSpan.FromSeconds(0), TimeSpan.FromSeconds(3), "Test 1", null)
                .MakeMovable();
            TimeLineData
                .AddEntry(TimeSpan.FromSeconds(3), TimeSpan.FromSeconds(2), "Test 2", null);
            TimeLineData
                .AddEntry(TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(1), "Test 3", null);
            TimeLineData
                .AddEntry(TimeSpan.FromSeconds(4), TimeSpan.FromSeconds(0.5), "Test 4", null)
                .LockDuration();
            //timeLine.TotalDuration = TimeSpan.FromSeconds(5);
        }

        #region Timeline data
        public TimeLineData TimeLineData
        {
            get => (TimeLineData)GetValue(TimeLineDataProperty);
            set => SetValue(TimeLineDataProperty, value);
        }
        public static readonly DependencyProperty TimeLineDataProperty =
            DependencyProperty.Register(
                "TimeLineData",
                typeof(TimeLineData),
                typeof(MainWindow),
                new PropertyMetadata(new TimeLineData(), new PropertyChangedCallback(OnTimeLineDataChanged)));

        private static void OnTimeLineDataChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is MainWindow p)
            {
                /// Your OnChanged CODE       
            }
        }
        #endregion

    }
}
