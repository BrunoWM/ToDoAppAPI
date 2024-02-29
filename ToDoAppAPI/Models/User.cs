using System.ComponentModel.DataAnnotations;

namespace ToDoAppAPI.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }

        public List<Task> Tasks { get; set; }
    }
}
