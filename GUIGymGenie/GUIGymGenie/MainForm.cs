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
                    refreshBtn.PerformClick();

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

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            userGridView.Rows.Clear();
            List<string[]> list = UM.outputDataGrid();
            int[] statistic = UM.getStatistics();

            foreach(string [] row in list)
            {
                userGridView.Rows.Add(row);
            }

            noaLabel.Text = "Admin: " + statistic[0];
            notLabel.Text = "Trainer: " + statistic[1];
            nocLabel.Text = "Customer: " + statistic[2];
            nomLabel.Text = "Member: " + statistic[3];

            userChart.Series["Customer"].Points.Clear();
            userChart.Series["Customer"].Points.AddXY(1, 10);
            userChart.Series["Customer"].Points.AddXY(2, 25);
            userChart.Series["Customer"].Points.AddXY(3, 27);
            userChart.Series["Customer"].Points.AddXY(4, 33);
            userChart.Series["Customer"].Points.AddXY(5, statistic[2]);
            userChart.Series["Customer"].Points.AddXY(6, 0);
            userChart.Series["Customer"].Points.AddXY(7, 0);
            userChart.Series["Customer"].Points.AddXY(8, 0);
            userChart.Series["Customer"].Points.AddXY(9, 0);
            userChart.Series["Customer"].Points.AddXY(10, 0);
            userChart.Series["Customer"].Points.AddXY(11, 0);
            userChart.Series["Customer"].Points.AddXY(12, 0);
            userChart.Series["Member"].Points.Clear();
            userChart.Series["Member"].Points.AddXY(1, 7);
            userChart.Series["Member"].Points.AddXY(2, 23);
            userChart.Series["Member"].Points.AddXY(3, 25);
            userChart.Series["Member"].Points.AddXY(4, 30);
            userChart.Series["Member"].Points.AddXY(5, statistic[3]);
            userChart.Series["Member"].Points.AddXY(6, 0);
            userChart.Series["Member"].Points.AddXY(7, 0);
            userChart.Series["Member"].Points.AddXY(8, 0);
            userChart.Series["Member"].Points.AddXY(9, 0);
            userChart.Series["Member"].Points.AddXY(10, 0);
            userChart.Series["Member"].Points.AddXY(11, 0);
            userChart.Series["Member"].Points.AddXY(12, 0);

            trainerChart.Series["Trainer"].Points.Clear();
            trainerChart.Series["Trainer"].Points.AddXY("John", 10);
            trainerChart.Series["Trainer"].Points.AddXY("Andrew", 20);
            trainerChart.Series["Trainer"].Points.AddXY("Marco", 14);

            profitChart.Series["profit"].Points.Clear();
            profitChart.Series["profit"].Points.AddXY(1, "2000");
            profitChart.Series["profit"].Points.AddXY(2, "2500");
            profitChart.Series["profit"].Points.AddXY(3, "2700");
            profitChart.Series["profit"].Points.AddXY(4, "3000");
            profitChart.Series["profit"].Points.AddXY(5, "3100");
        }
    }
}
