using Microsoft.EntityFrameworkCore;

namespace jquerypract.Models
{
    public class StateContext : DbContext
    {
        public StateContext(DbContextOptions options) : base(options) 
        {
            
        }
        public DbSet<state> states { get; set; }
        public DbSet<city> cities { get; set; }
        public DbSet<login> logins { get; set; }
        public DbSet<SignUp> signUps { get; set; }
    }
}
