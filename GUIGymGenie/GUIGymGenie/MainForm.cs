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
using Training;
using User;

namespace GUIGymGenie
{
    public partial class MainForm : Form
    {
        static UserMgmt UM = new UserMgmt();
        static TSMgmt TM = new TSMgmt();
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

                }else if(LOGGEDIN.Role == 1)
                {
                    trainerGroup.Visible = true;
                    trainerGroup.Location = new Point(12, 33);
                    refreshBtn2.PerformClick();
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
            trainerGroup.Visible = false;
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
            trainerChart.Series["Trainer"].Points.AddXY("Jane", 10);
            trainerChart.Series["Trainer"].Points.AddXY("Andrew", 17);
            trainerChart.Series["Trainer"].Points.AddXY("Marco", 14);
            trainerChart.Series["Trainer"].Points.AddXY("Sindy", 16);

            profitChart.Series["profit"].Points.Clear();
            profitChart.Series["profit"].Points.AddXY(1, ""+(80*7));
            profitChart.Series["profit"].Points.AddXY(2, ""+(80*23));
            profitChart.Series["profit"].Points.AddXY(3, ""+(80*25));
            profitChart.Series["profit"].Points.AddXY(4, ""+(80*30));
            profitChart.Series["profit"].Points.AddXY(5, ""+(80*statistic[3]));
        }

        private void cheatLabel_Click(object sender, EventArgs e)
        {
            string[] fName = { "Emma", "Liam", "Olivia", "Noah", "Ava", "William", "Isabella", "James", "Sophia", "Oliver", "Charlotte", "Benjamin", "Mia", "Elijah", "Amelia", "Lucas", "Harper", "Mason", "Evelyn", "Logan", "Abigail", "Alexander", "Emily", "Ethan", "Elizabeth", "Jacob", "Mila", "Michael", "Ella", "Daniel", "Avery", "Henry", "Sofia", "Jackson", "Camila", "Sebastian", "Aria", "Aiden", "Scarlett", "Matthew", "Victoria", "Samuel", "Madison", "David", "Luna", "Joseph", "Grace", "Carter", "Chloe", "Owen", "Penelope", "Wyatt", "Layla", "John", "Riley", "Jack", "Zoey", "Luke", "Nora", "Jayden", "Lily", "Dylan", "Eleanor", "Grayson", "Hannah", "Levi", "Lillian", "Isaac", "Addison", "Gabriel", "Aubrey", "Julian", "Ellie", "Mateo", "Stella", "Anthony", "Natalie", "Jaxon", "Zoe", "Lincoln" };
            string[] lName = { "Smith", "Johnson", "Williams", "Jones", "Brown", "Davis", "Miller", "Wilson", "Moore", "Taylor", "Anderson", "Thomas", "Jackson", "White", "Harris", "Martin", "Thompson", "Garcia", "Martinez", "Robinson", "Clark", "Rodriguez", "Lewis", "Lee", "Walker", "Hall", "Allen", "Young", "Hernandez", "King", "Wright", "Lopez", "Hill", "Scott", "Green", "Adams", "Baker", "Gonzalez", "Nelson", "Carter", "Mitchell", "Perez", "Roberts", "Turner", "Phillips", "Campbell", "Parker", "Evans", "Edwards", "Collins", "Stewart", "Sanchez", "Morris", "Rogers", "Reed", "Cook", "Morgan", "Bell", "Murphy", "Bailey", "Rivera", "Cooper", "Richardson", "Cox", "Howard", "Ward", "Torres", "Peterson", "Gray", "Ramirez", "James", "Watson", "Brooks", "Kelly", "Sanders", "Price", "Bennett", "Wood", "Barnes", "Ross", "Henderson" };
            var ran = new Random();
            int ind = ran.Next(fName.Length);
            string ranName = fName[ind] + " " + lName[ind];
            string ranEmail = fName[ind].ToLower() + "." + lName[ind].ToLower() + "@gmail.com";
            UM.AddUser(ranName, ranEmail, "0000");
        }

        private void cheatBtn1_Click(object sender, EventArgs e)
        {
            string[] fName = { "Emma", "Liam", "Olivia", "Noah", "Ava", "William", "Isabella", "James", "Sophia", "Oliver", "Charlotte", "Benjamin", "Mia", "Elijah", "Amelia", "Lucas", "Harper", "Mason", "Evelyn", "Logan", "Abigail", "Alexander", "Emily", "Ethan", "Elizabeth", "Jacob", "Mila", "Michael", "Ella", "Daniel", "Avery", "Henry", "Sofia", "Jackson", "Camila", "Sebastian", "Aria", "Aiden", "Scarlett", "Matthew", "Victoria", "Samuel", "Madison", "David", "Luna", "Joseph", "Grace", "Carter", "Chloe", "Owen", "Penelope", "Wyatt", "Layla", "John", "Riley", "Jack", "Zoey", "Luke", "Nora", "Jayden", "Lily", "Dylan", "Eleanor", "Grayson", "Hannah", "Levi", "Lillian", "Isaac", "Addison", "Gabriel", "Aubrey", "Julian", "Ellie", "Mateo", "Stella", "Anthony", "Natalie", "Jaxon", "Zoe", "Lincoln" };
            string[] lName = { "Smith", "Johnson", "Williams", "Jones", "Brown", "Davis", "Miller", "Wilson", "Moore", "Taylor", "Anderson", "Thomas", "Jackson", "White", "Harris", "Martin", "Thompson", "Garcia", "Martinez", "Robinson", "Clark", "Rodriguez", "Lewis", "Lee", "Walker", "Hall", "Allen", "Young", "Hernandez", "King", "Wright", "Lopez", "Hill", "Scott", "Green", "Adams", "Baker", "Gonzalez", "Nelson", "Carter", "Mitchell", "Perez", "Roberts", "Turner", "Phillips", "Campbell", "Parker", "Evans", "Edwards", "Collins", "Stewart", "Sanchez", "Morris", "Rogers", "Reed", "Cook", "Morgan", "Bell", "Murphy", "Bailey", "Rivera", "Cooper", "Richardson", "Cox", "Howard", "Ward", "Torres", "Peterson", "Gray", "Ramirez", "James", "Watson", "Brooks", "Kelly", "Sanders", "Price", "Bennett", "Wood", "Barnes", "Ross", "Henderson" };
            var ran = new Random();
            int ind = ran.Next(fName.Length);
            string ranName = fName[ind] + " " + lName[ind];
            string ranEmail = fName[ind].ToLower() + "." + lName[ind].ToLower() + "@gmail.com";
            UM.AddUser(ranName, ranEmail, "0000");
        }

        private void cheatBtn2_Click(object sender, EventArgs e)
        {
            var ran = new Random();
            int id = ran.Next(UM.Size());
            UM.SetMember(id);
        }

        private void trainerGroup_Enter(object sender, EventArgs e)
        {

        }

        private void addTSBtn_Click(object sender, EventArgs e)
        {
            var date = datePicker.Value;
            var time = timePicker.Value;
            string loc = locCombo.Text;
            int cap = (int) capUD.Value;
            string dateTime = string.Format("{0} {1}", date.ToString("MM/dd/yyyy"), time.ToString("hh:mm tt"));
            
            if(loc.Length != 0 && cap != 0)
            {
                AddTSHandler(dateTime, loc, cap);
            }
        }

        public void AddTSHandler(string dateTime, string loc, int cap)
        {
            TM.AddTS(LOGGEDIN.Id, dateTime, loc, cap);
            refreshBtn2.PerformClick();
        }

        private void refreshBtn2_Click(object sender, EventArgs e)
        {
            tsGridView.Rows.Clear();
            List<string[]> list = TM.outputDataGrid(LOGGEDIN.Id);
            int i = 1;
            foreach (string[] row in list)
            {
                row[0] = "" + i;
                i++;
                tsGridView.Rows.Add(row);
            }

            List<_User> memberList = UM.GetAllMember();
            foreach (_User user in memberList)
            {
                nameCombo.Items.Add(user.Name);
            }
        }

        private void cheatBtn3_Click(object sender, EventArgs e)
        {
            List<_User> memberList = UM.GetAllMember();

            var ran = new Random();
            int indexOfUser = ran.Next(memberList.Count);
            int indexOfTS = ran.Next(1, TM.getSizeTS(LOGGEDIN.Id) + 1);

            TM.AddPartInTS(LOGGEDIN.Id, indexOfTS, memberList[indexOfUser].Name);

        }

        private void bfrBtn_Click(object sender, EventArgs e)
        {
            string name = nameCombo.Text;
            string weight = weightBox.Text;
            string height = heightBox.Text;
            string date = bfrDatePicker.Text;
            string detail = bfrRichBox.Text;

            string[] bfr = { name, weight, height, date, detail };
        }
    }
}
