using ASPNET6_Template.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPNET6_Template.Data
{
    public class InterrogationDbContext : DbContext
    {
        public InterrogationDbContext(DbContextOptions<InterrogationDbContext> options) : base(options)
        {

        }

        public DbSet<Problem> Problems { set; get; }
    }
}
