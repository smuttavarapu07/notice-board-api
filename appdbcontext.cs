using Microsoft.EntityFrameworkCore;
using NoticeBoardAPI.Models;

namespace NoticeBoardAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Notice> Notices { get; set; }
    }
}
