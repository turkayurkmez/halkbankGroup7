using eshop.Entities;

namespace eshop.Application
{
    public class UserService : IUserService
    {
        private List<User> _users;

        public UserService()
        {
            _users = new List<User>()
            {
                new(){ Id=1, UserName="turkay", Email="abc@def@com", Name="Türkay Ürkmez", Password="123", Role="Admin"},
                new(){ Id=2, UserName="yasin", Email="abc@def@com", Name="Yasin Ayas", Password="123", Role="Editor"},
                new(){ Id=3, UserName="mustafa", Email="abc@def@com", Name="Mustafa Çavuş", Password="123", Role="Client"},

            };
        }
        public User ValidateUser(string username, string password)
        {
            return _users.FirstOrDefault(u => u.UserName == username && u.Password == password);

        }
    }
}
