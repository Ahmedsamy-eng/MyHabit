using System.ComponentModel.DataAnnotations.Schema;

namespace Habit_Tracker.Models.Entities
{
    public class User_Reward
    {
        public int u_id {  get; set; }
        [ForeignKey("u_id")]
        public User user { get; set; }

        public int r_id {  get; set; }
        [ForeignKey("r_id")]
        public Reward reward { get; set; }

    }
}
