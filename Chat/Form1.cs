namespace Chat
{
    public partial class LoginForm : Form
    {
        string MongoConString = "mongodb://localhost:27017";
        string MongoDatabase = "chat";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var mongoHelper = new MongoDBHelper(MongoConString, MongoDatabase);

            if (mongoHelper.LoginUser(tbUserName.Text, tbPassword.Text))
            {
                ChatForm chatForm = new ChatForm(tbUserName.Text);
                chatForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid login");
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            var mongoHelper = new MongoDBHelper(MongoConString, MongoDatabase);

            if (tbSignInUserName.Text != "" && tbSignInPassword.Text != "" && !mongoHelper.LoginUser(tbSignInUserName.Text, tbSignInPassword.Text))
            {
                mongoHelper.RegisterUser(tbSignInUserName.Text, tbSignInPassword.Text);
                MessageBox.Show($"Sign in success! ({tbSignInUserName.Text})");
                tbSignInUserName.Text = "";
                tbSignInPassword.Text = "";

            }
            else
            {
                MessageBox.Show($"Sign in failed! ({tbSignInUserName.Text}) User already exists or given data are not correct.");
            }

        }
    }
}
