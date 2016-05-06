using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class UserContext : DbContext ,IDbContext, IUnitOfWork
    {
        public UserContext() : base("DefaultConnection")
        {

        }

        public DbSet<Product> Products {get; set;}
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }

        public IDbSet<TEntity> GetSet<TEntity>() where TEntity : class
        {
            return Set<TEntity>();
        }
    }
}
