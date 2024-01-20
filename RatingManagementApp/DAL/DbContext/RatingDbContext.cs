
using RatingManagementApp.Models;
using System.Data.Entity;


namespace RatingManagementApp.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DefaultConnection") { }

        public DbSet<Rating> Ratings { get; set; }
    }
}