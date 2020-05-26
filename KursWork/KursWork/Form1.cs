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

        private enum tables //Название таблиц, как в БД
        {
            DeviceInWork,
            FinishedWork
        };

        //Выводимые названия колонок (индексы в enum и тут должны совпадать)
        string[][] columns =  
        {
            new string[]{"Модельный номер", "Статус", "Время начала работы", "ФИО клиента", "Стоимость"},
            new string[]{"Модельный номер", "Время начала работы", "Время окончания работы", "Стоимость ремонта"}
        };

        public Form1()
        {
            InitializeComponent();

            if(!File.Exists(dbFileName))    //Если с программой нет БД, то выкидываем ошибку и вырубаем приложение.
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
            SelectDB.DropDownStyle = ComboBoxStyle.DropDownList;    //Не нашел в визуалке, сделал так. (запрет ввода в комбобокс)
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbCommand = new SQLiteCommand();
            DrawTable(0);
        }

        #region Draw
        private void DrawTable(int tableIndex)  //Отрисовка выбранной таблицы
        {
            dataGridView1.Columns.Clear();  //Отчистка таблицы на форме.
            dataGridView1.Refresh();

            string tableName = Enum.GetName(typeof(tables), tableIndex);
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM {tableName}", dbConnection);
            SQLiteDataReader reader = null;
            reader = command.ExecuteReader();

            for(int i = 0; i < columns[tableIndex].Length; ++i)
            {
                dataGridView1.Columns.Add("", columns[tableIndex][i]);
            }

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

        private void DrawTable(int tableIndex, string name, string model)  //Отрисовка выбранной таблицы по имени и модели
        {
            dataGridView1.Columns.Clear();  //Отчистка таблицы на форме.
            dataGridView1.Refresh();

            string tableName = Enum.GetName(typeof(tables), tableIndex);
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM {tableName} WHERE FIO = \"{name}\" AND modelNum = \"{model}\"", dbConnection);
            SQLiteDataReader reader = null;
            reader = command.ExecuteReader();

            for (int i = 0; i < columns[tableIndex].Length; ++i)
            {
                dataGridView1.Columns.Add("", columns[tableIndex][i]);
            }

            while (reader.Read())
            {
                string[] fileds = new string[reader.FieldCount];
                for (int i = 0; i < reader.FieldCount; ++i)
                {
                    fileds[i] = reader[i].ToString();
                }
                dataGridView1.Rows.Add(fileds);
            }

            reader.Close();
        }

        private void DrawTable(int tableIndex, string name)  //Отрисовка выбранной таблицы
        {
            dataGridView1.Columns.Clear();  //Отчистка таблицы на форме.
            dataGridView1.Refresh();

            string tableName = Enum.GetName(typeof(tables), tableIndex);
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM {tableName} WHERE FIO = \"{name}\"", dbConnection);
            SQLiteDataReader reader = null;
            reader = command.ExecuteReader();

            for (int i = 0; i < columns[tableIndex].Length; ++i)
            {
                dataGridView1.Columns.Add("", columns[tableIndex][i]);
            }

            while (reader.Read())
            {
                string[] fileds = new string[reader.FieldCount];
                for (int i = 0; i < reader.FieldCount; ++i)
                {
                    fileds[i] = reader[i].ToString();
                }
                dataGridView1.Rows.Add(fileds);
            }

            reader.Close();
        }

        private void DrawTable(string model, int tableIndex)  //Отрисовка выбранной таблицы 
        {
            dataGridView1.Columns.Clear();  //Отчистка таблицы на форме.
            dataGridView1.Refresh();

            string tableName = Enum.GetName(typeof(tables), tableIndex);
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM {tableName} WHERE modelNum = \"{model}\"", dbConnection);
            SQLiteDataReader reader = null;
            reader = command.ExecuteReader();

            for (int i = 0; i < columns[tableIndex].Length; ++i)
            {
                dataGridView1.Columns.Add("", columns[tableIndex][i]);
            }

            while (reader.Read())
            {
                string[] fileds = new string[reader.FieldCount];
                for (int i = 0; i < reader.FieldCount; ++i)
                {
                    fileds[i] = reader[i].ToString();
                }
                dataGridView1.Rows.Add(fileds);
            }

            reader.Close();
        }
        #endregion Draw

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PrintDB_Click(object sender, EventArgs e)
        {
            DrawTable(SelectDB.SelectedIndex);
        }

        private void BtSearch_Click(object sender, EventArgs e) //Вывод только удовлетворяющией информации о устройстве.
        {
            string fullName = (Name.Text).Trim();
            string model = (Model.Text).Trim();


            if (NameCheckBox.Checked && ModelCheckBox.Checked)
            {
                DrawTable(0, fullName, model);
            }
            else if (NameCheckBox.Checked && !ModelCheckBox.Checked)
            {
                DrawTable(0, fullName);
            }
            else if(!NameCheckBox.Checked && ModelCheckBox.Checked)
            {
                DrawTable(model, 0);
            }
            else
            {
                MessageBox.Show("Выбирите по признак(и) для поиска.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
