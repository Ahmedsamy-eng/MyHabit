namespace Habit_Tracker.Models.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public ICollection<Habit> habits { get; set; }
        public ICollection<User_Reward> rewards { get; set; }

    }
}
