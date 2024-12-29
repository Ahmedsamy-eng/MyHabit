using System.ComponentModel.DataAnnotations.Schema;

namespace Habit_Tracker.Models.Entities
{
    public class Habit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public bool IsCompleted {  get; set; }
        public int User_Id {  get; set; }
        [ForeignKey("User_Id")]
        public User User { get; set; }
        public int Category_Id { get; set; }
        [ForeignKey("Category_Id")]
        public Habit_Category Category { get; set; }

    }
}
