using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using User;

namespace GUIGymGenie
{
    public partial class MainForm : Form
    {
        static UserMgmt UM = new UserMgmt();
        static _User LOGGEDIN;

        public MainForm()
        {
            InitializeComponent();
        }

        public void LoginHander(string em, string pw)
        {
            LOGGEDIN = UM.Login(em, pw);
            if (LOGGEDIN != null)
            {
                userInfoLabel.Text = LOGGEDIN.Name;
                if (LOGGEDIN.Role == 0)
                {
                    AdminGroup.Visible = true;
                }
                emailBox.Text = "";
                passBox.Text = "";
                errorLabel.Text = "";
                logoutbtn.Visible = true;
                loginGroup.Visible = false;
            }
            else
            {
                errorLabel.Text = "Email or Password is invalid.";
                emailBox.Text = "";
                passBox.Text = "";
            }
        }

        public void RegisterHander(string n, string e, string p, string c)
        {
            bool isValid = false;
            if (n.Trim() != "")
            {
                if (e.Trim() != "")
                {
                    if (IsValidEmail(e))
                    {
                        if (p.Trim() != "" && p == c)
                        {
                            isValid = true;
                        }
                        else
                        {
                            regErrorLabel.Text = "Password and Confirm do not match";
                        }
                    }
                    else
                    {
                        regErrorLabel.Text = "Email is incorrect";
                    }
                }
                else
                {
                    regErrorLabel.Text = "Email is required";
                }
            }
            else
            {
                regErrorLabel.Text = "Name is required";
            }

            if (isValid)
            {
                bool isSuccess = UM.AddUser(n, e, p);
                if (isSuccess)
                {
                    LoginHander(e, p);
                    registerGroup.Visible = false;
                }
                else
                {
                    regEmailBox.Text = "";
                    regConfBox.Text = "";
                    regErrorLabel.Text = "Email already exists";
                }
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string email = emailBox.Text;
            string passw = passBox.Text;

            LoginHander(email, passw);
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            userInfoLabel.Text = "";
            AdminGroup.Visible = false;
            loginGroup.Visible = true;
            logoutbtn.Visible = false;
            LOGGEDIN = null;
        }

        private void registerBtn2_Click(object sender, EventArgs e)
        {
            string name = regNameBox.Text;
            string email = regEmailBox.Text;
            string pass = regPassBox.Text;
            string conf = regConfBox.Text;

            RegisterHander(name, email, pass, conf);
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            loginGroup.Visible = false;
            registerGroup.Visible = true;
        }

        public bool IsValidEmail(string email)
        {
            bool valid = Regex.IsMatch(email, @"[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?\.)+[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?");
            return valid;
        }

        private void userListBtn_Click(object sender, EventArgs e)
        {
            List<string[]> list = UM.outputDataGrid();

            foreach(string [] row in list)
            {
                userGridView.Rows.Add(row);
            }

        }
    }
}
