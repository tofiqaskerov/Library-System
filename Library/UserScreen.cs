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
    public partial class UserScreen : Form
    {


        public UserScreen()
        {
            InitializeComponent();
        }

        UserManager _userManager = new();
        

        private void UserScreen_Load(object sender, EventArgs e)
        {
            var allrole = _userManager.GetAllRoles();

            foreach (var role in allrole)
            {
                CmbRole.Items.Add(role.RoleName);
            }

            DGV();
        }
        public void DGV()
        {
            var allUser = _userManager.GetAllUser().Where(user => user.RoleId > 0).Select(user => new
            {
                Id = user.Id,
                Name = user.Name,
                Surname = user.Surname,
                Age = user.Age,
                Role = user.Role.RoleName,
                Email = user.Email,
                Phone = String.Format("{0:+(### ##) ###-##-##}", Convert.ToInt64(user.PhoneNumber)),
                IsDeleted  = user.IsDeleted

            }).ToList();
            DgvUser.DataSource = allUser;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var username = TxtName.Text;
            var surname = TxtSurname.Text;
            var age = NmrAge.Value;
            var finCode = TxtFINCode.Text;
            var phone = TxtPhoneNumber.Text;
            var email = TxtEmail.Text;
            var cmbRole = CmbRole.Text;
            var password = TxtPassword.Text;
            var confirmPassword = TxtConfirmPassword.Text;
            var checkedFinCode = _userManager.GetByFinCode(finCode);

            if(checkedFinCode != null)
            {
                MessageBox.Show("Bele bir sexs Qeydiyyatdan kecib", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var passwordTrim = password.Trim();
                if(passwordTrim.Length >=6 && passwordTrim.Length <=10)
                {
                    if (password != confirmPassword)
                    {
                        MessageBox.Show("Please Confirm Password", "Error", MessageBoxButtons.OK);
                    }
                    else
                    {
                        try
                        {
                            var role = _userManager.GetRoleByName(cmbRole);
                            int roleId = role.Id;
                            User _user = new();
                            _user.Name = username;
                            _user.Surname = surname;
                            _user.Age = Convert.ToInt32(age);
                            _user.RoleId = roleId;
                            _user.Email = email;
                            _user.FinCode = finCode;
                            _user.Password = password;
                            _user.PhoneNumber = Convert.ToInt32(phone);
                            _userManager.Register(_user);
                            DialogResult result = MessageBox.Show("Register is success", "Register", MessageBoxButtons.OK);
                            if (result == DialogResult.OK)
                            {
                                TxtName.Text = "";
                                TxtSurname.Text = "";
                                NmrAge.Value = 0;
                                CmbRole.Text = "";
                                TxtFINCode.Text = "";
                                TxtPhoneNumber.Text = "";
                                TxtEmail.Text = "";
                                TxtPassword.Text = "";
                                TxtConfirmPassword.Text = "";
                                DGV();
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Something is wrong ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Sifrenin uzunlugu 6 ve 10 araliginda olmalidir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
               

            }
           
        }

        private void DgvUser_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BtnAdd.Visible = false;
            BtnUpdate.Visible = true;
            BtnDelete.Visible = true;

            var userId = (int)DgvUser.Rows[e.RowIndex].Cells[0].Value;
            LblId.Text = userId.ToString();


            try
            {
                var user = _userManager.GetUserById(userId);
                TxtName.Text = user.Name;
                TxtSurname.Text = user.Surname;
                NmrAge.Value = user.Age;
                TxtFINCode.Text = user.FinCode;
                var phonenumber = user.PhoneNumber;
                TxtPhoneNumber.Text = Convert.ToString(phonenumber);
                TxtEmail.Text = user.Email;
                TxtPassword.Text = user.Password;
                TxtConfirmPassword.Text = TxtPassword.Text;

            }
            catch (Exception error)
            {

                MessageBox.Show("Something is wrong \n Error:" + error.Message, "Error message", MessageBoxButtons.OK);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you Sure", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                try
                {
                    int userId = Convert.ToInt32(LblId.Text);
                    var user = _userManager.GetUserById(userId);
                    user.Name = TxtName.Text;
                    user.Surname = TxtSurname.Text;
                    user.Age = Convert.ToInt32(NmrAge.Value);
                    user.FinCode = TxtFINCode.Text;
                    user.PhoneNumber = Convert.ToInt32(TxtPhoneNumber.Text);
                    user.Email = TxtEmail.Text;
                    user.Password = TxtPassword.Text;   

                    _userManager.UpdateUser(user);

                    TxtName.Text = string.Empty;
                    TxtSurname.Text = string.Empty;
                    NmrAge.Value = 0;
                    TxtFINCode.Text = string.Empty;
                    TxtPhoneNumber.Text = string.Empty;
                    TxtEmail.Text = string.Empty;
                    TxtPassword.Text = string.Empty;
                    TxtConfirmPassword.Text = string.Empty;

                    BtnAdd.Visible = true;
                    BtnDelete.Visible = false;
                    BtnUpdate.Visible = false;
                    MessageBox.Show("User is Updated" , "Completed" , MessageBoxButtons.OK);
                    DGV();


                }
                catch (Exception)
                {

                    MessageBox.Show("Something is wrong! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are your sure?", "Delete teacher", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    var userId = Convert.ToInt32(LblId.Text);
                    var user = _userManager.GetUserById(userId);
                    _userManager.DeleteUser(user);

                    TxtName.Text = string.Empty;
                    TxtSurname.Text = string.Empty;
                    NmrAge.Value = 0;
                    TxtFINCode.Text = string.Empty;
                    TxtPhoneNumber.Text = string.Empty;
                    TxtEmail.Text = string.Empty;
                    TxtPassword.Text = string.Empty;
                    TxtConfirmPassword.Text = string.Empty;

                    BtnAdd.Visible = true;
                    BtnDelete.Visible = false;
                    BtnUpdate.Visible = false;

                }
                catch (Exception)
                {
                    MessageBox.Show("Something is wrong! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
