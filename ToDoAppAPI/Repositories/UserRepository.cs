using ToDoAppAPI.Data;
using ToDoAppAPI.Interfaces;
using ToDoAppAPI.Models;

namespace ToDoAppAPI.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _dataContext;
        public UserRepository(DataContext context) 
        { 
            _dataContext = context;
        }
        public bool CreateUser(User user)
        {
            _dataContext.Users.Add(user);
            return Save();
        }

        public bool DeleteUser(User user)
        {
            _dataContext.Users.Remove(user);
            return Save();
        }

        public User GetUserById(int id)
        {
            return _dataContext.Users.Where(p => p.UserId == id).FirstOrDefault();
        }

        public ICollection<User> GetUsers()
        {
            return _dataContext.Users.OrderBy(p => p.UserId).ToList();
        }

        public bool Save()
        {
            var saved = _dataContext.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool UpdateUser(User user)
        {
            _dataContext.Users.Update(user);
            return Save();
        }

        public bool UserExists(int id)
        {
            return _dataContext.Users.Any(p => p.UserId == id);
        }
    }
}
