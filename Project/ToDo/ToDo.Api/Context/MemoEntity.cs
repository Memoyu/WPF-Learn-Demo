using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Api.Context
{
    public class MemoEntity : BaseEntity
    {
        public string Title { get; set; }

        public string Content { get; set; }
    }
}
