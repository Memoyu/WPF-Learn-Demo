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
    public class SettingsViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;

        private ObservableCollection<MenuBar> menuBars;
        public ObservableCollection<MenuBar> MenuBars
        {
            get { return menuBars; }
            set { menuBars = value; RaisePropertyChanged(); }
        }

        public DelegateCommand<MenuBar> NavigateCommand { get; private set; }

        public SettingsViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            NavigateCommand = new DelegateCommand<MenuBar>(Navigate);
            CreateMenuBar();
        }
        void CreateMenuBar()
        {
            MenuBars = new ObservableCollection<MenuBar>();
            MenuBars.Add(new MenuBar
            {
                Icon = "Palette",
                Title = "个性化",
                NameSpace = "SkinView",
            });
            MenuBars.Add(new MenuBar
            {
                Icon = "Cog",
                Title = "待办事项",
                NameSpace = "SystemSettingView",
            });
            MenuBars.Add(new MenuBar
            {
                Icon = "Information",
                Title = "关于作者",
                NameSpace = "AboutView",
            });
        }

        private void Navigate(MenuBar menuBar)
        {
            if (menuBar == null || string.IsNullOrWhiteSpace(menuBar.NameSpace)) return;
            _regionManager.Regions[PrismManager.SettingsViewRegionName].RequestNavigate(menuBar.NameSpace);
        }
    }
}