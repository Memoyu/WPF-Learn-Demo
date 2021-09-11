using System.Windows;
using System.Windows.Input;

namespace ToDoClient.Views
{
    /// <summary>
    /// MainView.xaml 的交互逻辑
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();

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
