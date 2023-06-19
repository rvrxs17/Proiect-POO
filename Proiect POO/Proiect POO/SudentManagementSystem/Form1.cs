using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace SudentManagementSystem
{
    public partial class Form1 : Form
    {
        public int StudentID;
        public string Gender;     
       
        SqlConnection DBconnection = new SqlConnection("Data Source=DESKTOP-A32AENL\\SQLEXPRESS;Initial Catalog=SMSDB;Integrated Security=True;TrustServerCertificate=True");
        public Form1()
        {
            InitializeComponent();
            DisplayData();
            Date.Value = DateTime.Today;
        }
        public void DisplayData()
        {
            SqlDataAdapter SQLselectQuery = new SqlDataAdapter("SELECT * FROM Students", DBconnection);
            DataTable StudentDataTable = new DataTable();
            SQLselectQuery.Fill(StudentDataTable);
            StudentDataGridView.DataSource = StudentDataTable;
        }
        private void AllClear()
        {
            StudentName.Clear();
            Age.Clear();
            Mobile.Clear();
            Email.Clear();
            Male.Checked = false;
            Female.Checked = false;
            Other.Checked = false;
            StudentClass.SelectedIndex = -1;
            Date.Value = DateTime.Today;
        }

        private void save_Click(object sender, EventArgs e)
        {
            bool IsAllValid = true;
            String ErrorMessage = string.Empty;

            if (IsAllValid)
            {
                ErrorMessage = NameValidate(StudentName.Text);

                if (ErrorMessage != "")
                {
                    IsAllValid = false;

                }
                else
                {
                    IsAllValid = true;
                }
            }

            if (IsAllValid)
            {
                ErrorMessage = AgeValidate(Age.Text);
                if (ErrorMessage != "")
                {
                    IsAllValid = false;
                }
                else
                {
                    IsAllValid = true;
                }
            }

            if (IsAllValid)
            {
                ErrorMessage = EmailValidate(Email.Text);

                if (ErrorMessage != "")
                {
                    IsAllValid = false;
                }
                else
                {
                    IsAllValid = true;
                    if (CountDuplicateEmail(Email.Text) > 0)
                    {
                        IsAllValid = false;
                        ErrorMessage = ("Acest Email este deja folosit.");
                    }
                    else
                    {
                        IsAllValid = true;
                    }
                }
            }

            if (IsAllValid)
            {
                ErrorMessage = MobileValidate(Mobile.Text);

                if (ErrorMessage != "")
                {
                    IsAllValid = false;
                }
                else
                {
                    IsAllValid = true;
                    if (CountDuplicateMobile(Mobile.Text) > 0)
                    {
                        IsAllValid = false;
                        ErrorMessage = ("Acest numar de telefon este deja folosit.");
                    }
                    else
                    {
                        IsAllValid = true;
                    }
                }
            }
            if (IsAllValid)
            {
                if (StudentClass.SelectedIndex == -1)
                {
                    IsAllValid = false;
                    ErrorMessage = ("Alege specializarea.");
                }
                else
                {
                    IsAllValid = true;
                }
            }

            if (IsAllValid)
            {
                if (Male.Checked != true && Female.Checked != true && Other.Checked != true)
                {
                    IsAllValid = false;
                    ErrorMessage = ("Alege sexul.");
                }
                else
                {
                    IsAllValid = true;
                }
            }

            if (IsAllValid)
            {
                if (Date.Value > DateTime.Today)
                {
                    IsAllValid = false;
                    Date.Value = DateTime.Today;
                    ErrorMessage = ("Ai introdus o data incorecta.");
                }
                else
                {
                    IsAllValid = true;
                }
            }


            if (IsAllValid)
            {
                string sqlQuery = "INSERT INTO Students " +
                    "(Name, Age, MobileNumber, Email, Gender, Class, Ad_date) VALUES " +
                    "('" + StudentName.Text +
                    "' ,'" + Convert.ToInt32(Age.Text) +
                    "','" + Mobile.Text +
                    "','" + Email.Text +
                    "','" + Gender +
                    "','" + StudentClass.SelectedItem +
                    "','" + Date.Value.ToShortDateString() + "')";

                DBconnection.Open();
                SqlCommand cm = new SqlCommand(sqlQuery, DBconnection);
                if (cm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Salvat cu succes !");
                }
                else
                {
                    MessageBox.Show("Eroare ! Incearca din nou.");
                }
                DBconnection.Close();
                AllClear();
                DisplayData();
            }
            else
            {
                MessageBox.Show(ErrorMessage);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            bool IsAllValid = true;
            String ErrorMessage = string.Empty;

            if (IsAllValid)
            {
                ErrorMessage = NameValidate(StudentName.Text);

                if (ErrorMessage != "")
                {
                    IsAllValid = false;

                }
                else
                {
                    IsAllValid = true;
                }
            }

            if (IsAllValid)
            {
                ErrorMessage = AgeValidate(Age.Text);
                if (ErrorMessage != "")
                {
                    IsAllValid = false;
                }
                else
                {
                    IsAllValid = true;
                }
            }
            if (IsAllValid)
            {
                if (StudentClass.SelectedIndex == -1)
                {
                    IsAllValid = false;
                    ErrorMessage = ("Selecteaza specializarea.");
                }
                else
                {
                    IsAllValid = true;
                }
            }

            if (IsAllValid)
            {
                ErrorMessage = EmailValidate(Email.Text);

                if (ErrorMessage != "")
                {
                    IsAllValid = false;
                }
                else
                {
                    IsAllValid = true;
                    if (CountDuplicateEmail(Email.Text) > 1)
                    {
                        IsAllValid = false;
                        ErrorMessage = ("Acest Email este deja folosit.");
                    }
                    else
                    {
                        IsAllValid = true;
                    }
                }
            }

            if (IsAllValid)
            {
                ErrorMessage = MobileValidate(Mobile.Text);

                if (ErrorMessage != "")
                {
                    IsAllValid = false;
                }
                else
                {
                    IsAllValid = true;
                    if (CountDuplicateMobile(Mobile.Text) > 1)
                    {
                        IsAllValid = false;
                        ErrorMessage = ("Acest numar de telefon este deja folosit.");
                    }
                    else
                    {
                        IsAllValid = true;
                    }
                }
            }

            if (IsAllValid)
            {
                if (Male.Checked != true && Female.Checked != true && Other.Checked != true)
                {
                    IsAllValid = false;
                    ErrorMessage = ("Selecteaza sexul.");
                }
                else
                {
                    IsAllValid = true;
                }
            }

            if (IsAllValid)
            {
                if (Date.Value > DateTime.Today)
                {
                    IsAllValid = false;
                    Date.Value = DateTime.Today;
                    ErrorMessage = ("Ai introdus data incorecta.");
                }
                else
                {
                    IsAllValid = true;
                }
            }
            if (IsAllValid)
            {
                string sqlQuery = "update Students set Name = " + "'" + StudentName.Text +
                                    "' , " + "Age = " + "'" + Convert.ToInt32(Age.Text) +
                                    "' , MobileNumber = " + "'" + Mobile.Text +
                                    "' , Email = " + "'" + Email.Text +
                                    "' , Gender = " + "'" + Gender +
                                    "' , Class = " + "'" + StudentClass.SelectedItem +
                                    "' , Ad_date = " + "'" + Date.Value.ToShortDateString() +
                                    "'   where ID = " + StudentID;
                DBconnection.Open();
                SqlCommand cm = new SqlCommand(sqlQuery, DBconnection);
                if (cm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Salvat cu succes !");
                }
                else
                {
                    MessageBox.Show("Eroare ! Incearca din nou.");
                }
                DBconnection.Close();
                AllClear();
                DisplayData();
            }
            else
            {
                MessageBox.Show(ErrorMessage);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DBconnection.Open();
            int TotalRow = StudentDataGridView.Rows.Count;
            for (int i = 0; i < TotalRow; i++)
            {
                DataGridViewRow gridr = StudentDataGridView.Rows[i];
                if (gridr.Selected == true)
                {
                    string sqlQuery = "DELETE FROM Students WHERE ID= '" + StudentDataGridView.Rows[i].Cells[0].Value + "'";
                    SqlCommand cmd = new SqlCommand(sqlQuery, DBconnection);
                    cmd.ExecuteNonQuery();
                }
            }
            AllClear();
            DisplayData();
            MessageBox.Show("Date sterse.");
            DBconnection.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            AllClear();
        }
        public string NameValidate(string StudenName)
        {
            StudenName = StudenName.Trim();
            string NameErrorMessage = string.Empty;
            if (StudenName == "")
            {
                NameErrorMessage = "Trebuie sa introduci un nume.";
            }
            else if (StudenName.Length < 3)
            {
                NameErrorMessage = "Numele tau trebuie sa aiba minim 3 litere.";
            }
            else if (StudenName.Length > 50)
            {
                NameErrorMessage = "Numele tau trebuie sa aiba intre 3 si 50 de litere.";
            }
            else
            {
                NameErrorMessage = string.Empty;
            }
            return NameErrorMessage;
        }
        public int CountDuplicateEmail(string email)
        {
            int count = 0;
            foreach (DataGridViewRow row in StudentDataGridView.Rows)
            {
                var gridEmail = row.Cells[4].Value.ToString();
                if (gridEmail == email)
                {
                    count++;
                }
            }
            return count;
        }
        public string EmailValidate(string StudenEmail)
        {
            string EmailErrorMessage = string.Empty;
            StudenEmail = StudenEmail.Trim();
            string email = Email.Text;

            System.Text.RegularExpressions.Regex expr = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (!expr.IsMatch(email))
            {
                EmailErrorMessage = "Email invalid";
            }
            else if (StudenEmail.Length > 50)
            {
                EmailErrorMessage = "Email-ul este prea lung.";
            }
            else
            {
                EmailErrorMessage = string.Empty;
            }
            return EmailErrorMessage;
        }

        public string AgeValidate(string StudentAge)
        {
            int StudentAgeInt;
            string AgeErrorMessage = string.Empty;
            string age = StudentAge.Trim();

            if (StudentAge == "")
            {
                AgeErrorMessage = "Introdu varsta.";
            }
            else
            {
                try
                {
                    StudentAgeInt = Int32.Parse(StudentAge);
                    if (StudentAgeInt < 18)
                    {
                        AgeErrorMessage = "Varsta minima: 18 ani.";
                    }
                    else if (StudentAgeInt > 40)
                    {
                        AgeErrorMessage = "Varsta trebuie sa fie intre 18 si 40 de ani.";
                    }
                    else
                    {
                        AgeErrorMessage = string.Empty;
                    }
                }
                catch (FormatException)
                {
                    AgeErrorMessage = "Introdu numar pentru varsta.";
                }
            }
            return AgeErrorMessage;
        }
        public int CountDuplicateMobile(string mobile)
        {
            int count = 0;
            foreach (DataGridViewRow row in StudentDataGridView.Rows)
            {
                var gridMobile = row.Cells[3].Value.ToString();
                if (gridMobile == mobile)
                {
                    count++;
                }
            }
            return count;
        }

        public string MobileValidate(string StudenMobile)
        {
            string MobileErrorMessage = string.Empty;
            StudenMobile = StudenMobile.Trim();
            if (StudenMobile == "")
            {
                MobileErrorMessage = "Introdu numarul de telefon.";
            }
            else if (StudenMobile.Length > 20)
            {
                MobileErrorMessage = "Numarul de telefon trebuie sa fie intre 11 si 20 de cifre.";
            }
            else if (StudenMobile.Length < 11)
            {
                MobileErrorMessage = "Numarul de telefon trebuie sa aiba minim 11 cifre.";
            }
            else
            {
                MobileErrorMessage = string.Empty;
            }
            return MobileErrorMessage;
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            StudentID = int.Parse(StudentDataGridView.SelectedRows[0].Cells[0].Value.ToString());
            StudentName.Text = StudentDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            Age.Text = StudentDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            Mobile.Text = StudentDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            Email.Text = StudentDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            string sclass = StudentDataGridView.SelectedRows[0].Cells[6].Value.ToString();
            if (sclass == "AIA")
            {
                StudentClass.SelectedIndex = 0;
            }
            else if (sclass == "ROBO")
            {
                StudentClass.SelectedIndex = 1;
            }
            else if (sclass == "TI")
            {
                StudentClass.SelectedIndex = 2;
            }
            else if (sclass == "ETTI")
            {
                StudentClass.SelectedIndex = 3;
            }
            else
            {
                StudentClass.SelectedIndex = -1;
            }
            string gendercheck = StudentDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            string Dtc = StudentDataGridView.SelectedRows[0].Cells[7].Value.ToString();
            string[] subs1 = Dtc.Split(' ');
            string[] subs = subs1[0].Split("/");
            Date.Value = new DateTime(Int16.Parse(subs[2]), Int16.Parse(subs[0]), Int16.Parse(subs[1]));
            if (gendercheck == "Male")
            {
                Male.Checked = true;
            }
            else if (gendercheck == "Female")
            {
                Female.Checked = true;
            }
            else
            {
                Other.Checked = true;
            }

        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void other_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Other";
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string SearchValue = txtSearch.Text.Trim().ToLower();
            foreach (DataGridViewRow row in StudentDataGridView.Rows)
            {
                var SearchName = row.Cells[1].Value.ToString();
                var SearchNameLower = SearchName.ToLower();
                if (!SearchNameLower.Contains(SearchValue))
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[StudentDataGridView.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = false;
                    currencyManager1.ResumeBinding();
                }
                else
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[StudentDataGridView.DataSource];
                    currencyManager1.SuspendBinding();
                    row.Visible = true;
                    currencyManager1.ResumeBinding();
                }
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Guideline guideline = new Guideline();
            guideline.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lebel_Click(object sender, EventArgs e)
        {

        }
    }
}