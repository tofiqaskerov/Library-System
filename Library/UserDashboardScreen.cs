using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class UserDashboardScreen : Form
    {
        UserManager _userManager = new();
        public UserDashboardScreen()
        {
            InitializeComponent();
        }

        private void LoadForm(object form)
        {
            if (this.MainPanel2.Controls.Count > 0)
                this.MainPanel2.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.MainPanel2.Controls.Add(f);
            f.Show();

        }

        private void UserDashboardScreen_Load(object sender, EventArgs e)
        {
            LblUserId.Text = Form1.SendId;
            var userId = Convert.ToInt32(LblUserId.Text);
            var userName = _userManager.GetUserById(userId);
            LblUserName.Text = userName.Name;
        }
        

        
        
        
        

        

        private void button1_Click(object sender, EventArgs e)
        {
            LoadForm(new  RentBookScreen());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadForm(new ReturnBookScreen());
        }
    }
}
