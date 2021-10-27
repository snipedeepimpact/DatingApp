using API.Entities;
using Microsoft.EntityFrameworkCore;


namespace API.Data
{
    public class DataContext : DbContext
    {
        //Constructor to initlaize DBContext
        public DataContext( DbContextOptions options) : base(options)
        {
        }

        //Class which has to be managed by DBContext-->table name is Users
        public DbSet<AppUser> Users { get; set; }
    }
}
