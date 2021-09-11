using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Api.Context
{
    public class MyToDoContext : DbContext
    {
        public MyToDoContext(DbContextOptions<MyToDoContext> options) : base(options)
        {

        }

        public DbSet<ToDoEntity> ToDo { get; set; }
        public DbSet<UserEntity> User { get; set; }
        public DbSet<MemoEntity> Memo { get; set; }
    }
}
