using ToDoAppAPI.Data;
using ToDoAppAPI.Interfaces;

namespace ToDoAppAPI.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly DataContext _dataContext;
        public TaskRepository(DataContext context)
        {
            _dataContext = context;
        }
        public bool CreateTask(Models.Task task)
        {
            _dataContext.Tasks.Add(task);
            return Save();
        }

        public bool DeleteTask(Models.Task task)
        {
            _dataContext.Tasks.Remove(task);
            return Save();
        }

        public ICollection<Models.Task> GetAllTasks()
        {
            return _dataContext.Tasks.OrderBy(p => p.TaskId).ToList();
        }

        public Models.Task GetTaskById(int id)
        {
            return _dataContext.Tasks.Where(p => p.TaskId == id).FirstOrDefault();
        }

        public bool Save()
        {
            var saved = _dataContext.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool TaskExists(int id)
        {
            return _dataContext.Tasks.Any(p => p.TaskId == id);
        }

        public bool UpdateTask(Models.Task task)
        {
            _dataContext.Tasks.Update(task);
            return Save();
        }
    }
}
