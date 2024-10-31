namespace MeetingApp.Models
{
    public class Repository
    {
        private static List<UserInfo> _users = new();
        static Repository()
        {
            _users.Add(new UserInfo()
            {
                Id = 1,
                Name = "Harun",
                Email = "harun@info.com",
                Phone = "123456789",
                WillAttend = true
            });
            _users.Add(new UserInfo()
            {
                Id = 2,
                Name = "Ahmet",
                Email = "ahmet@info.com",
                Phone = "123456789",
                WillAttend = true
            });
            _users.Add(new UserInfo()
            {
                Id = 3,
                Name = "Eda",
                Email = "eda@info.com",
                Phone = "123456789",
                WillAttend = false
            });
        }

        public static List<UserInfo> Users
        {
            get
            {
                return _users;
            }
        }
        public static void CreateUser(UserInfo user)
        {
            user.Id=Users.Count + 1;    
            _users.Add(user);
        }
        public static UserInfo GetById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }

    }
}
