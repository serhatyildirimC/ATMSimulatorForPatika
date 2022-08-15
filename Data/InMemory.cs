using Entities;

namespace Data
{
    public class InMemory
    {
        List<User> _users;
        public InMemory()
        {
            _users = new List<User>
            {
                new User { Id = 1,  Password = "12345",Balance=5000 },
                new User { Id = 2,  Password = "54321",Balance=3000 },
                new User { Id = 3,  Password = "12345",Balance=2000 },
                new User { Id = 4,  Password = "12345",Balance=7000 },
                new User { Id = 5,  Password = "12345",Balance=1500 },
            };

        }
        public void Add(User user)
        {
            _users.Add(user);
        }
        public List<User> GetUsers()
        {
            return _users;
        }
        public User Get(int id)
        {
            return _users.Find(x => x.Id == id);
        }
        public void UpdateBalance(int id, int balance)
        {
            User user =_users.Find(x => x.Id == id);
            user.Balance = balance;

        }


    }
}