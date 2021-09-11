using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Shared.Dtos;

namespace ToDoClient.ViewModels
{
    public class ToDoViewModel : BindableBase
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

        public ToDoViewModel()
        {
            CreateTestData();
            AddCommand = new DelegateCommand(AddToDo);
        }

        private void CreateTestData()
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
        }

        private void AddToDo()
        {
            IsRightDrawerOpen = true;
        }

    }
}
