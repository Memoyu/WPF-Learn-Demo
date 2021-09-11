using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Shared.Dtos;
using ToDoClient.Common;

namespace ToDoClient.ViewModels
{
    public class IndexViewModel : BindableBase
    {
        private ObservableCollection<TaskStatBar> taskStatBars;
        public ObservableCollection<TaskStatBar> TaskStatBars
        {
            get { return taskStatBars; }
            set { taskStatBars = value; RaisePropertyChanged(); }
        }

        private ObservableCollection<ToDoDto> toDos;
        public ObservableCollection<ToDoDto> ToDos
        {
            get { return toDos; }
            set { toDos = value; RaisePropertyChanged(); }
        }

        private ObservableCollection<MemoDto> memos;
        public ObservableCollection<MemoDto> Memos
        {
            get { return memos; }
            set { memos = value; RaisePropertyChanged(); }
        }

        public IndexViewModel()
        {
            TaskStatBars = new ObservableCollection<TaskStatBar>();
            CreatTaskStatBar();
            CreateTestData();
        }

        private void CreatTaskStatBar()
        {
            taskStatBars.Add(new TaskStatBar
            {
                Icon = "ClockFast",
                Title = "汇总",
                Content = "9",
                Color = "#FF0CA0FF",
                Target = "",
            });
            taskStatBars.Add(new TaskStatBar
            {
                Icon = "ClockChechOutline",
                Title = "已完成",
                Content = "9",
                Color = "#FF1ECA3A",
                Target = "",
            });
            taskStatBars.Add(new TaskStatBar
            {
                Icon = "ChartLineVariant",
                Title = "完成比例",
                Content = "100%",
                Color = "#FF02C6DC",
                Target = "",
            });
            taskStatBars.Add(new TaskStatBar
            {
                Icon = "PlaylistStar",
                Title = "备忘录",
                Content = "19",
                Color = "#FFFFA000",
                Target = "",
            });
        }

        private void CreateTestData()
        {
            ToDos = new ObservableCollection<ToDoDto>();
            Memos = new ObservableCollection<MemoDto>();

            for (int i = 0; i < 50; i++)
            {
                ToDos.Add(new ToDoDto
                {
                    Title = $"待办-{i}",
                    Content = $"正在处理，还需要{i}分钟",
                });

                Memos.Add(new MemoDto
                {
                    Title = $"备忘-{i}",
                    Content = $"这是我喜欢的数 - {i}",
                });
            }
        }

    }
}
