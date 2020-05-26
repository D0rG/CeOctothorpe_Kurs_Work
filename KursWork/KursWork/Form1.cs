using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;
using System.IO;

namespace KursWork
{
    public partial class Form1 : Form
    {
        private String dbFileName = "DataBase.sqllite";
        private SQLiteConnection dbConnection;
        private SQLiteCommand dbCommand;

        private enum tables
        {
            DeviceInWork,
            FinishedWork
        };

        public Form1()
        {
            InitializeComponent();

            if(!File.Exists(dbFileName)) //Если с программой нет БД, то выкидываем ошибку и вырубаем приложение.
            {
                MessageBox.Show("Файла базы данных не существует, приложение будет остановелно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            else
            {
                dbConnection = new SQLiteConnection("Data Source=" + dbFileName);
                dbConnection.Open();
            }
            SelectDB.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbCommand = new SQLiteCommand();
            DrawTable("DeviceInWork");
        }

        private void DrawTable(string tableName)
        {
            dataGridView1.Columns.Clear(); //Отчистка таблицы на форме.
            dataGridView1.Refresh();
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM {tableName}", dbConnection);
            SQLiteDataReader reader = null;
            reader = command.ExecuteReader();
            dataGridView1.Columns.Add("", "Номер модели");
            dataGridView1.Columns.Add("", "Статус");
            dataGridView1.Columns.Add("", "Время приёма");
            while (reader.Read())
            {
                string[] fileds = new string[reader.FieldCount];
                for(int i = 0; i < reader.FieldCount; ++i)
                {
                    fileds[i] = reader[i].ToString();
                }
                dataGridView1.Rows.Add(fileds);
            }
            reader.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PrintDB_Click(object sender, EventArgs e)
        {
            DrawTable(Enum.GetName(typeof(tables), SelectDB.SelectedIndex));
        }
    }
}
