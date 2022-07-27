using Business;
using Entites;
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
    public partial class Dashboard : Form
    {
        UserManager _userManager = new();
        UserScreen _userScreen = new();

        public Dashboard()
        {
            InitializeComponent();
        }


       private void LoadForm(object form)
        {
            if (this.MainPanel.Controls.Count > 0)
                this.MainPanel.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock  = DockStyle.Fill;
            this.MainPanel.Controls.Add(f);
            f.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _userScreen.DGV();
            LoadForm(new UserScreen());
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadForm(new BookScreen());
        }
        
        private void Dashboard_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            LblUserId.Text = Form1.SendId;
            var userID = Convert.ToInt32(LblUserId.Text);
            var userName = _userManager.GetUserById(userID);
            LblUserName.Text = userName.Name;
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadForm(new ShowReadersScreen());
        }

       
    }
}
