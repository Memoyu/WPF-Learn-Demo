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
    public class MemoViewModel : BindableBase
    {
        private ObservableCollection<MemoDto> memos;
        public ObservableCollection<MemoDto> Memos
        {
            get { return memos; }
            set { memos = value; RaisePropertyChanged(); }
        }

        private bool isRightDrawerOpen;
        public bool IsRightDrawerOpen
        {
            get { return isRightDrawerOpen; }
            set { isRightDrawerOpen = value; RaisePropertyChanged(); }
        }
        public DelegateCommand AddCommand { get; private set; }

        public MemoViewModel()
        {
            CreateTestData();
            AddCommand = new DelegateCommand(AddMemo);
        }

        private void CreateTestData()
        {
            Memos = new ObservableCollection<MemoDto>();
            for (int i = 0; i < 50; i++)
            {
                Memos.Add(new MemoDto
                {
                    Title = $"备忘-{i}",
                    Content = $"这是我喜欢的数 - {i}",
                });
            }
        }

        private void AddMemo()
        {
            IsRightDrawerOpen = true;
        }
    }
}