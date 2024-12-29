namespace Habit_Tracker.Models.Entities
{
    public class Habit_Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Habit> habits { get; set; }

    }
}
