using Prism.Commands;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Shared.Dtos;
using ToDoClient.ViewModels.Base;

namespace ToDoClient.ViewModels
{
    public class ToDoViewModel : BaseNavigationViewModel
    {
        private ObservableCollection<ToDoDto> toDos;
        public ObservableCollection<ToDoDto> ToDos
        {
            get { return toDos; }
            set { toDos = value; RaisePropertyChanged(); }
        }

        private bool isRightDrawerOpen;
        public bool IsRightDrawerOpen
        {
            get { return isRightDrawerOpen; }
            set { isRightDrawerOpen = value; RaisePropertyChanged(); }
        }
        public DelegateCommand AddCommand { get; private set; }

        public ToDoViewModel(IContainerProvider containerProvider)
            : base(containerProvider)
        {
            AddCommand = new DelegateCommand(AddToDo);
        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
          //GetData();
        }

        private async void GetData()
        {
            Loading(true);
            try
            {

                ToDos = new ObservableCollection<ToDoDto>();
                for (int i = 0; i < 50; i++)
                {
                    ToDos.Add(new ToDoDto
                    {
                        Title = $"待办-{i}",
                        Content = $"正在处理，还需要{i}分钟",
                    });
                }

               // await Task.Delay(5000);
            }
            catch (Exception ex)
            {
            }
            finally
            {
                Loading(false);
            }
        }

        private void AddToDo()
        {
            IsRightDrawerOpen = true;
        }

    }
}
