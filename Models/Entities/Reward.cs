namespace Habit_Tracker.Models.Entities
{
    public class Reward
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Point {  get; set; }
        public ICollection<User_Reward> rewards { get; set; }
    }
}
