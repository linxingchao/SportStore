using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportStore.Domain.Entities;
using System.Data.Entity;

namespace SportStore.Domain.Concrete
{
    public class EFDbContext:DbContext
    {
        private string connectStr = @"server=192.168.0.8;database=SportsStore;user id=sa;password=12345;";
        public DbSet<Product> products { get; set; }

        
    }
}
