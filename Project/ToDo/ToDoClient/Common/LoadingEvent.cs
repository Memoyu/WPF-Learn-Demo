using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoClient.Common
{
    public class LoadingEvent : PubSubEvent<LoadingEventModel>
    {
    }

    public class LoadingEventModel
    {
        public bool IsOpen { get; set; }

        public string Hint { get; set; }
    }
}
