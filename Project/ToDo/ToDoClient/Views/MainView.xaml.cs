using Prism.Events;
using System.Windows;
using System.Windows.Input;
using ToDoClient.Common.Extensions;
using ToDoClient.Views.Base;

namespace ToDoClient.Views
{
    /// <summary>
    /// MainView.xaml 的交互逻辑
    /// </summary>
    public partial class MainView : Window
    {
        public MainView(IEventAggregator eventAggregator )
        {
            InitializeComponent();

            eventAggregator.Subscribe(arg =>
            {
                DialogHost.IsOpen = arg.IsOpen;
                if (DialogHost.IsOpen)
                    DialogHost.DialogContent = new LoadingView(arg.Hint);
            });

            btnMin.Click += (s, e) =>
            {
                WindowState = WindowState.Minimized;
            };

            btnMax.Click += (s, e) =>
            {
                if (WindowState == WindowState.Normal)
                    WindowState = WindowState.Maximized;
                else
                    WindowState = WindowState.Normal;
            };

            btnClose.Click += (s, e) =>
            {
                Close();
            };

            ColorZone.MouseMove += (s, e) =>
            {
                if (e.LeftButton == MouseButtonState.Pressed)
                    DragMove();
            };

            ColorZone.MouseDoubleClick += (s, e) =>
            {
                if (WindowState == WindowState.Normal)
                    WindowState = WindowState.Maximized;
                else
                    WindowState = WindowState.Normal;
            };

            menuBar.SelectionChanged += (s, e) =>
            {
                MenuToggleButton.IsChecked = false;
            };

        }
    }
}
