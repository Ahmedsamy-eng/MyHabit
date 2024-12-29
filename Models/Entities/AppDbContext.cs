using Microsoft.EntityFrameworkCore;


namespace Habit_Tracker.Models.Entities
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> dbcontext) : base(dbcontext) { }
        public DbSet<User> users { get; set; }
        public DbSet<Habit> habits { get; set; }
        public DbSet<Reward> rewards { get; set; }
        public DbSet<Habit_Category> categories { get; set; }
        public DbSet<User_Reward> user_rewards { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Habit>()
                .HasOne(a => a.User)
                .WithMany(h => h.habits)
                .HasForeignKey(f => f.User_Id)
                .OnDelete(DeleteBehavior.NoAction);  


            modelBuilder.Entity<Habit>()
                .HasOne(c => c.Category)
                .WithMany(h => h.habits)
                .HasForeignKey(f => f.Category_Id);

            modelBuilder.Entity<User_Reward>()
                .HasOne(u => u.user)
                .WithMany(w => w.rewards)
                .HasForeignKey(f => f.u_id);

            modelBuilder.Entity<User_Reward>()
                .HasOne(r => r.reward)
                .WithMany(w => w.rewards)
                .HasForeignKey(f => f.r_id);

            modelBuilder.Entity<User_Reward>()
                .HasKey(p => new { p.u_id, p.r_id });

                
        }
    }
}
