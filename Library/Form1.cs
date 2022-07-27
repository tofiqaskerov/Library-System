using Business;

namespace Library
{
    public partial class Form1 : Form
    {
        UserManager _userManager = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public static string SendId = "";  
        private void button1_Click(object sender, EventArgs e)
        {           
            var email = TxtEmail.Text;
            var password = TxtPassword.Text;
            var checkemail = _userManager.GetByEmail(email);
            if(checkemail != null)
            {
                if(checkemail.Email == email && checkemail.Password == password)
                {
                    var userID = Convert.ToString(checkemail.Id);
                    LblUserId.Text = userID;
                    SendId = userID;
                    if (checkemail.RoleId == 1 || checkemail.RoleId == 1002)
                    {

                        Dashboard dashboard = new Dashboard();
                        dashboard.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                       
                        UserDashboardScreen screen = new();
                        screen.ShowDialog();
                    }                      
                }   
                else
                {
                    MessageBox.Show("Email or password is not correct");
                }
            }
            else
            {
                MessageBox.Show("Email or password is not correct");
            }
        }       
    }
}