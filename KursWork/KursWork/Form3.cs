using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace KursWork
{
    public partial class Form3 : Form
    {
        Form1 form;

        public Form3(Form1 form)
        {
            InitializeComponent();
            this.form = form;
            guestRB.Select();
        }

        private void AddReasonBtn_Click(object sender, EventArgs e)     //Добавление причины в базу данных причин.
        {
            string res = reasonTB.Text.Trim();
            if (res != "")
            {
                string dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); //Получение даты по формату DateTime в sql
                string tableName = Enum.GetName(typeof(Form1.tables), 2);
                SQLiteCommand command = new SQLiteCommand($"INSERT INTO {tableName} (Reason) VALUES ('{res}')", form.GetDBConnection());
                command.ExecuteNonQuery();
                form.UpdDamageList();
                reasonTB.Text = "";
            }
            else
            {
                MessageBox.Show("Введите причину.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AddUserBtn_Click(object sender, EventArgs e)   //Добавление нового польлователя.
        {
            string pass = PassTB.Text.Trim();
            string login = LoginTB.Text.Trim();
            if (pass != "" && login != "")
            {
                if (IsNewLogin(login))
                {
                    string dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); //Получение даты по формату DateTime в sql
                    string tableName = Enum.GetName(typeof(Form1.tables), 4);
                    SQLiteCommand command = null;

                    if (adminRB.Checked)
                    {
                        command = new SQLiteCommand($"INSERT INTO {tableName} (login, pass, permission) VALUES ('{login}', '{pass}', 'admin')", form.GetDBConnection());
                    }
                    else if (userRB.Checked)
                    {
                        command = new SQLiteCommand($"INSERT INTO {tableName} (login, pass, permission) VALUES ('{login}', '{pass}', 'user')", form.GetDBConnection());
                    }
                    else
                    {
                        command = new SQLiteCommand($"INSERT INTO {tableName} (login, pass, permission) VALUES ('{login}', '{pass}', 'guest')", form.GetDBConnection());
                    }
                    command.ExecuteNonQuery();

                    LoginTB.Text = PassTB.Text = "";
                }
                else
                {
                    MessageBox.Show("Пользлователь с таким логином уже существует.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Введите данные для нового пользователя.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DelUserBtn_Click(object sender, EventArgs e)   //Удаление пользователя по его логину.
        {
            try
            {
                string tableName = Enum.GetName(typeof(Form1.tables), 4);
                SQLiteCommand command = new SQLiteCommand($"DELETE FROM {tableName} WHERE login='{LoginTB.Text.Trim()}'", form.GetDBConnection());
                command.ExecuteNonQuery();
            }
            catch
            {
                ;
            }
        }

        private bool IsNewLogin(string login)   //Проверка, есть ли данный логин в базе данных.
        {
            bool isNewUser = true;
            string tableName = Enum.GetName(typeof(Form1.tables), 4);
            SQLiteCommand command = new SQLiteCommand($"SELECT login FROM {tableName} WHERE login ='{login}'", form.GetDBConnection());
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if(reader.FieldCount != 0)
                {
                    isNewUser = false;
                }
            }

            reader.Close();
            return isNewUser;
        }
    }
}
