using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_CreateDialogWinForms.Data
{
    public class AppFormData : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }
        public AppFormData()
        {
            this.Database.EnsureCreated(); //Автоматично створити БД
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=myData.sqlite");
        }

    }
}
