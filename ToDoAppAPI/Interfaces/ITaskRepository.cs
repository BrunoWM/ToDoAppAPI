using ToDoAppAPI.Models;

namespace ToDoAppAPI.Interfaces
{
    public interface ITaskRepository
    {
        ICollection<Models.Task> GetAllTasks();
        Models.Task GetTaskById(int id);
        bool CreateTask(Models.Task task);
        bool UpdateTask(Models.Task task);
        bool DeleteTask(Models.Task task);
        bool TaskExists(int id);
        bool Save();
    }
}
