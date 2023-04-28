namespace Events
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Red;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void buttonEvent_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            userService.UserCreated += UserService_UserCreated;

            userService.CreateUser(new User { UserName = "turkay" });

        }

        private void UserService_UserCreated(object sender, UserCreatedEventArgs e)
        {
            MessageBox.Show($"{e.NewUser.UserName} isimli kullanıcı {e.Reason} sebebiyle, {e.CreatedDate.ToLongDateString()} tarihinde eklendi");
        }
    }
}