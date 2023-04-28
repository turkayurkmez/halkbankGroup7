namespace Events
{
    public class User
    {
        public string UserName { get; set; }
        public string Email { get; set; }
    }

    public class UserCreatedEventArgs : EventArgs
    {
        public User NewUser { get; set; }
        public string Reason { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    public class UserService
    {
        public delegate void UserCreatedEventHandler(object sender, UserCreatedEventArgs e);
        public event UserCreatedEventHandler UserCreated;
        public void CreateUser(User user)
        {
            //kullanıcı oluşturuldu event'i fırlasın.


            if (UserCreated != null)
            {
                UserCreatedEventArgs args = new UserCreatedEventArgs() { NewUser = user, CreatedDate = DateTime.Now, Reason = "Yeni müşteri" };

                UserCreated(this, args);
            }

        }
    }
}
