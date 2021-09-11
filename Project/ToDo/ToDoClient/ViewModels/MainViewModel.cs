using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoClient.Common;

namespace ToDoClient.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;
        private IRegionNavigationJournal _regionNavigationJournal;

        private ObservableCollection<MenuBar> menuBars;
        public ObservableCollection<MenuBar> MenuBars
        {
            get { return menuBars; }
            set { menuBars = value; RaisePropertyChanged(); }
        }

        public DelegateCommand<MenuBar> NavigateCommand { get; private set; }

        public DelegateCommand GoBackCommand { get; private set; }
        public DelegateCommand GoForwardCommand { get; private set; }

        public MainViewModel(IRegionManager regionManager, IRegionNavigationJournal regionNavigationJournal)
        {
            _regionManager = regionManager;
            _regionNavigationJournal = regionNavigationJournal;
            CreateMenuBar();
            NavigateCommand = new DelegateCommand<MenuBar>(Navigate);
            GoBackCommand = new DelegateCommand(GoBack);
            GoForwardCommand = new DelegateCommand(GoForward);
        }

        void CreateMenuBar()
        {
            MenuBars = new ObservableCollection<MenuBar>();
            MenuBars.Add(new MenuBar
            {
                Icon = "Home",
                Title = "首页",
                NameSpace = "IndexView",
            });
            MenuBars.Add(new MenuBar
            {
                Icon = "NotebookOutline",
                Title = "待办事项",
                NameSpace = "ToDoView",
            });
            MenuBars.Add(new MenuBar
            {
                Icon = "NotebookPlus",
                Title = "备忘录",
                NameSpace = "MemoView",
            });
            MenuBars.Add(new MenuBar
            {
                Icon = "Cog",
                Title = "设置",
                NameSpace = "SettingsView",
            });
        }

        private void Navigate(MenuBar menuBar)
        {
            if (menuBar == null || string.IsNullOrWhiteSpace(menuBar.NameSpace)) return;
            _regionManager.Regions[PrismManager.MainViewRegionName].RequestNavigate(menuBar.NameSpace, back =>
            {
                // 添加到导航日志中
                _regionNavigationJournal = back.Context.NavigationService.Journal;
            });
        }

        private void GoBack()
        {
            if (_regionNavigationJournal != null && _regionNavigationJournal.CanGoBack)
                _regionNavigationJournal.GoBack();
        }

        private void GoForward()
        {
            if (_regionNavigationJournal != null && _regionNavigationJournal.CanGoForward)
                _regionNavigationJournal.GoForward();
        }
    }
}
