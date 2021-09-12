using Prism.Events;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoClient.Common;
using ToDoClient.Common.Extensions;

namespace ToDoClient.ViewModels.Base
{
    public class BaseNavigationViewModel : BindableBase, INavigationAware
    {
        private readonly IContainerProvider _containerProvider;
        public readonly IEventAggregator EventAggregator;
        
        public BaseNavigationViewModel(IContainerProvider containerProvider)
        {
            _containerProvider = containerProvider;
            EventAggregator = containerProvider.Resolve<IEventAggregator>();
        }

        public virtual bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public virtual void OnNavigatedFrom(NavigationContext navigationContext)
        {
            
        }

        public virtual void OnNavigatedTo(NavigationContext navigationContext)
        {
            
        }

        public void Loading(bool isOpen, string hint = "加载中...")
        {
            EventAggregator.Publish(new LoadingEventModel
            {
                IsOpen = isOpen,
                Hint = hint,
            });
        }
    }
}
