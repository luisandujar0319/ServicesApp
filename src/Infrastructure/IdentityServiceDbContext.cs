using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class IdentityServiceDbContext: DbContext
    {
        public IdentityServiceDbContext(DbContextOptions<IdentityServiceDbContext> options): base(options)
        {

        }
        public DbSet<Users> Users { get; set; }
    }
}
