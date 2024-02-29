using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoAppAPI.Models
{
    public class Task
    {
        [Key]
        public int TaskId { get; set; }
        public DateTime TaskDate { get; set; }
        public string TaskTitle { get; set; }
        public string TaskDescription { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

    }
}
