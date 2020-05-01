namespace GUIGymGenie
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.loginGroup = new System.Windows.Forms.GroupBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.AdminGroup = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.userChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.userGridView = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMember = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.userInfoLabel = new System.Windows.Forms.Label();
            this.registerGroup = new System.Windows.Forms.GroupBox();
            this.regErrorLabel = new System.Windows.Forms.Label();
            this.registerBtn2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.regConfBox = new System.Windows.Forms.TextBox();
            this.regNameBox = new System.Windows.Forms.TextBox();
            this.regPassBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.regEmailBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.noaLabel = new System.Windows.Forms.Label();
            this.notLabel = new System.Windows.Forms.Label();
            this.nocLabel = new System.Windows.Forms.Label();
            this.nomLabel = new System.Windows.Forms.Label();
            this.trainerChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.profitChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.loginGroup.SuspendLayout();
            this.AdminGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).BeginInit();
            this.registerGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainerChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profitChart)).BeginInit();
            this.SuspendLayout();
            // 
            // loginGroup
            // 
            this.loginGroup.Controls.Add(this.errorLabel);
            this.loginGroup.Controls.Add(this.passBox);
            this.loginGroup.Controls.Add(this.emailBox);
            this.loginGroup.Controls.Add(this.label2);
            this.loginGroup.Controls.Add(this.label1);
            this.loginGroup.Controls.Add(this.registerBtn);
            this.loginGroup.Controls.Add(this.loginBtn);
            this.loginGroup.Location = new System.Drawing.Point(457, 219);
            this.loginGroup.Name = "loginGroup";
            this.loginGroup.Size = new System.Drawing.Size(265, 236);
            this.loginGroup.TabIndex = 0;
            this.loginGroup.TabStop = false;
            this.loginGroup.Text = "Login";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.errorLabel.Location = new System.Drawing.Point(34, 133);
            this.errorLabel.MinimumSize = new System.Drawing.Size(200, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(200, 13);
            this.errorLabel.TabIndex = 7;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(99, 101);
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '*';
            this.passBox.Size = new System.Drawing.Size(136, 20);
            this.passBox.TabIndex = 5;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(99, 72);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(136, 20);
            this.emailBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email";
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(99, 188);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(75, 23);
            this.registerBtn.TabIndex = 1;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(99, 155);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // AdminGroup
            // 
            this.AdminGroup.BackColor = System.Drawing.SystemColors.Control;
            this.AdminGroup.Controls.Add(this.groupBox1);
            this.AdminGroup.Controls.Add(this.refreshBtn);
            this.AdminGroup.Controls.Add(this.userGridView);
            this.AdminGroup.Location = new System.Drawing.Point(12, 33);
            this.AdminGroup.Name = "AdminGroup";
            this.AdminGroup.Size = new System.Drawing.Size(1135, 636);
            this.AdminGroup.TabIndex = 1;
            this.AdminGroup.TabStop = false;
            this.AdminGroup.Text = "Admin Dashboard";
            this.AdminGroup.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.profitChart);
            this.groupBox1.Controls.Add(this.trainerChart);
            this.groupBox1.Controls.Add(this.nomLabel);
            this.groupBox1.Controls.Add(this.nocLabel);
            this.groupBox1.Controls.Add(this.notLabel);
            this.groupBox1.Controls.Add(this.noaLabel);
            this.groupBox1.Controls.Add(this.userChart);
            this.groupBox1.Location = new System.Drawing.Point(599, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 581);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistic";
            // 
            // userChart
            // 
            chartArea3.Name = "ChartArea1";
            this.userChart.ChartAreas.Add(chartArea3);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.userChart.Legends.Add(legend1);
            this.userChart.Location = new System.Drawing.Point(129, 20);
            this.userChart.Name = "userChart";
            this.userChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Customer";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Member";
            this.userChart.Series.Add(series3);
            this.userChart.Series.Add(series4);
            this.userChart.Size = new System.Drawing.Size(377, 211);
            this.userChart.TabIndex = 3;
            this.userChart.Text = "Chart";
            title1.Name = "dfasadf";
            this.userChart.Titles.Add(title1);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(17, 34);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(91, 27);
            this.refreshBtn.TabIndex = 1;
            this.refreshBtn.Text = "refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // userGridView
            // 
            this.userGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colRole,
            this.colName,
            this.colEmail,
            this.colMember});
            this.userGridView.Location = new System.Drawing.Point(17, 77);
            this.userGridView.Name = "userGridView";
            this.userGridView.Size = new System.Drawing.Size(540, 538);
            this.userGridView.TabIndex = 0;
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 30;
            // 
            // colRole
            // 
            this.colRole.HeaderText = "Role";
            this.colRole.Name = "colRole";
            this.colRole.ReadOnly = true;
            this.colRole.Width = 70;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 150;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Width = 200;
            // 
            // colMember
            // 
            this.colMember.HeaderText = "M";
            this.colMember.Name = "colMember";
            this.colMember.ReadOnly = true;
            this.colMember.Width = 30;
            // 
            // logoutbtn
            // 
            this.logoutbtn.Location = new System.Drawing.Point(1062, 8);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(75, 23);
            this.logoutbtn.TabIndex = 2;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.UseVisualStyleBackColor = true;
            this.logoutbtn.Visible = false;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // userInfoLabel
            // 
            this.userInfoLabel.AutoSize = true;
            this.userInfoLabel.Location = new System.Drawing.Point(956, 13);
            this.userInfoLabel.MinimumSize = new System.Drawing.Size(100, 0);
            this.userInfoLabel.Name = "userInfoLabel";
            this.userInfoLabel.Size = new System.Drawing.Size(100, 13);
            this.userInfoLabel.TabIndex = 3;
            this.userInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // registerGroup
            // 
            this.registerGroup.Controls.Add(this.regErrorLabel);
            this.registerGroup.Controls.Add(this.registerBtn2);
            this.registerGroup.Controls.Add(this.label6);
            this.registerGroup.Controls.Add(this.regConfBox);
            this.registerGroup.Controls.Add(this.regNameBox);
            this.registerGroup.Controls.Add(this.regPassBox);
            this.registerGroup.Controls.Add(this.label5);
            this.registerGroup.Controls.Add(this.regEmailBox);
            this.registerGroup.Controls.Add(this.label3);
            this.registerGroup.Controls.Add(this.label4);
            this.registerGroup.Location = new System.Drawing.Point(457, 219);
            this.registerGroup.Name = "registerGroup";
            this.registerGroup.Size = new System.Drawing.Size(265, 236);
            this.registerGroup.TabIndex = 4;
            this.registerGroup.TabStop = false;
            this.registerGroup.Text = "Register";
            this.registerGroup.Visible = false;
            // 
            // regErrorLabel
            // 
            this.regErrorLabel.AutoSize = true;
            this.regErrorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.regErrorLabel.Location = new System.Drawing.Point(33, 164);
            this.regErrorLabel.MinimumSize = new System.Drawing.Size(200, 0);
            this.regErrorLabel.Name = "regErrorLabel";
            this.regErrorLabel.Size = new System.Drawing.Size(200, 13);
            this.regErrorLabel.TabIndex = 9;
            // 
            // registerBtn2
            // 
            this.registerBtn2.Location = new System.Drawing.Point(95, 188);
            this.registerBtn2.Name = "registerBtn2";
            this.registerBtn2.Size = new System.Drawing.Size(75, 23);
            this.registerBtn2.TabIndex = 8;
            this.registerBtn2.Text = "Register";
            this.registerBtn2.UseVisualStyleBackColor = true;
            this.registerBtn2.Click += new System.EventHandler(this.registerBtn2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Confirm";
            // 
            // regConfBox
            // 
            this.regConfBox.Location = new System.Drawing.Point(95, 132);
            this.regConfBox.Name = "regConfBox";
            this.regConfBox.PasswordChar = '*';
            this.regConfBox.Size = new System.Drawing.Size(139, 20);
            this.regConfBox.TabIndex = 3;
            // 
            // regNameBox
            // 
            this.regNameBox.Location = new System.Drawing.Point(95, 54);
            this.regNameBox.Name = "regNameBox";
            this.regNameBox.Size = new System.Drawing.Size(139, 20);
            this.regNameBox.TabIndex = 0;
            // 
            // regPassBox
            // 
            this.regPassBox.Location = new System.Drawing.Point(95, 106);
            this.regPassBox.Name = "regPassBox";
            this.regPassBox.PasswordChar = '*';
            this.regPassBox.Size = new System.Drawing.Size(139, 20);
            this.regPassBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Password";
            // 
            // regEmailBox
            // 
            this.regEmailBox.Location = new System.Drawing.Point(95, 80);
            this.regEmailBox.Name = "regEmailBox";
            this.regEmailBox.Size = new System.Drawing.Size(139, 20);
            this.regEmailBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email";
            // 
            // noaLabel
            // 
            this.noaLabel.AutoSize = true;
            this.noaLabel.Location = new System.Drawing.Point(30, 50);
            this.noaLabel.Name = "noaLabel";
            this.noaLabel.Size = new System.Drawing.Size(42, 13);
            this.noaLabel.TabIndex = 4;
            this.noaLabel.Text = "Admin: ";
            // 
            // notLabel
            // 
            this.notLabel.AutoSize = true;
            this.notLabel.Location = new System.Drawing.Point(30, 80);
            this.notLabel.Name = "notLabel";
            this.notLabel.Size = new System.Drawing.Size(43, 13);
            this.notLabel.TabIndex = 5;
            this.notLabel.Text = "Trainer:";
            // 
            // nocLabel
            // 
            this.nocLabel.AutoSize = true;
            this.nocLabel.Location = new System.Drawing.Point(30, 110);
            this.nocLabel.Name = "nocLabel";
            this.nocLabel.Size = new System.Drawing.Size(54, 13);
            this.nocLabel.TabIndex = 6;
            this.nocLabel.Text = "Customer:";
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Location = new System.Drawing.Point(30, 140);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(51, 13);
            this.nomLabel.TabIndex = 7;
            this.nomLabel.Text = "Member: ";
            // 
            // trainerChart
            // 
            chartArea2.Name = "ChartArea1";
            this.trainerChart.ChartAreas.Add(chartArea2);
            this.trainerChart.Location = new System.Drawing.Point(22, 232);
            this.trainerChart.Name = "trainerChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Name = "Trainer";
            this.trainerChart.Series.Add(series2);
            this.trainerChart.Size = new System.Drawing.Size(468, 138);
            this.trainerChart.TabIndex = 5;
            this.trainerChart.Text = "chart1";
            // 
            // profitChart
            // 
            chartArea1.Name = "ChartArea1";
            this.profitChart.ChartAreas.Add(chartArea1);
            this.profitChart.Location = new System.Drawing.Point(6, 394);
            this.profitChart.Name = "profitChart";
            this.profitChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "profit";
            this.profitChart.Series.Add(series1);
            this.profitChart.Size = new System.Drawing.Size(484, 162);
            this.profitChart.TabIndex = 3;
            this.profitChart.Text = "chart1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 681);
            this.Controls.Add(this.AdminGroup);
            this.Controls.Add(this.registerGroup);
            this.Controls.Add(this.userInfoLabel);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.loginGroup);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Gym Genie";
            this.loginGroup.ResumeLayout(false);
            this.loginGroup.PerformLayout();
            this.AdminGroup.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).EndInit();
            this.registerGroup.ResumeLayout(false);
            this.registerGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainerChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profitChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox loginGroup;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.GroupBox AdminGroup;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label userInfoLabel;
        private System.Windows.Forms.GroupBox registerGroup;
        private System.Windows.Forms.TextBox regNameBox;
        private System.Windows.Forms.TextBox regPassBox;
        private System.Windows.Forms.TextBox regEmailBox;
        private System.Windows.Forms.Button registerBtn2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox regConfBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label regErrorLabel;
        private System.Windows.Forms.DataGridView userGridView;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMember;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart userChart;
        private System.Windows.Forms.Label nomLabel;
        private System.Windows.Forms.Label nocLabel;
        private System.Windows.Forms.Label notLabel;
        private System.Windows.Forms.Label noaLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart trainerChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart profitChart;
    }
}

