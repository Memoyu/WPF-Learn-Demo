using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Api.Context.Repository
{
    public class MemoRepository : Repository<MemoEntity>, IRepository<MemoEntity>
    {
        public MemoRepository(MyToDoContext dbContext) : base(dbContext)
        {

        }
    }
}
