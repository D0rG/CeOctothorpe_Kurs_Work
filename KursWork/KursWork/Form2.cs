﻿using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace KursWork
{
    public partial class Form2 : Form
    {
        private bool Logged = false;

        Form1 form;

        public Form2(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            GroupBoxJoin.Enabled = false;
        }

        private void JoinBtn_Click(object sender, EventArgs e)
        {
            if (LoginTB.Text != "" && PassTB.Text != "")
            {
                byte tableIndex = 4;

                string tableName = Enum.GetName(typeof(Form1.tables), tableIndex);
                SQLiteCommand command = new SQLiteCommand($"SELECT permission FROM {tableName} WHERE login ='{LoginTB.Text.Trim()}' AND pass='{PassTB.Text.Trim()}'", form.GetDBConnection());
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.FieldCount != 0)
                    {
                        form.LoginProgramm(reader[0].ToString().Trim());
                        Logged = true;
                        reader.Close();
                        this.Close();
                        return;
                    }
                }
                reader.Close();
                MessageBox.Show($"Пользователь с такими данными не найден.", "Результат входа.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Logged)
            {
                form.Close();
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)    //Поиск базы данных
        {
            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                openDialog.Filter = "База данных|*.sqllite;";
                if (openDialog.ShowDialog(this) == DialogResult.OK)
                {
                    form.SetNameDB(openDialog.FileName);
                    GroupBoxJoin.Enabled = true;
                    GroupBoxSelect.Enabled = false;
                }
            }
        }

        private void HereBtn_Click(object sender, EventArgs e)      //Выбор БД в своей дериктории
        {
            form.SetNameDB();
            GroupBoxJoin.Enabled = true;
            GroupBoxSelect.Enabled = false;
        }
    }
}
