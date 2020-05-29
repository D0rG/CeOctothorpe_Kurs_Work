using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace KursWork
{
    public partial class Form1 : Form
    {
        private String dbFileName = "DataBase.sqllite";
        private SQLiteConnection dbConnection;
        private SQLiteCommand dbCommand;
        private byte lastTablePrint;    //Хранит индекс последней выведенной таблицы.
        private byte userStatus = 1;    //1 - индекс не залогиненого в перечилсении permission

        public enum permission
        {
            admin,
            notLogged,
            user,
            guest
        };

        public enum tables //Название таблиц, как в БД
        {
            DeviceInWork,
            FinishedWork,
            Reasons,
            ModelAndReason,
            Users
        };

        private enum status
        {
            expertise,
            w8Money,
            repair,
            W8Owner
        };

        //Выводимые названия колонок (индексы в enum и тут должны совпадать)
        string[][] columns =  
        {
            new string[]{"Модельный номер", "Статус", "Время начала работы", "ФИО клиента", "Стоимость", "Причины поломки", "Время завершения"},
            new string[]{"Модельный номер", "Время начала работы", "Время окончания работы", "Стоимость ремонта", "ФИО"},
            new string[]{ "Причины поломок" },
            new string[]{ "Модельный номер", "Причина поломки" },
            new string[]{ "Логин", "Пароль", "Права" }
        };

        public Form1()
        {
            InitializeComponent();

            SelectDB.SelectedIndex = 0;
            SelectDB.DropDownStyle = ComboBoxStyle.DropDownList;    //Не нашел в визуалке, сделал так. (запрет ввода в комбобокс)
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            Enabled = false;    //Выключаем эту форму, ждём логина
            Form2 form = new Form2(this);
            form.Show();
        }

        #region Draw
        private void DrawTable(int tableIndex)  //Отрисовка выбранной таблицы.
        {
            lastTablePrint = (byte)tableIndex;
            dataGridView1.Columns.Clear();  //Отчистка таблицы на форме.
            dataGridView1.Refresh();

            string tableName = Enum.GetName(typeof(tables), tableIndex);
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM {tableName}", dbConnection);
            SQLiteDataReader reader = null;
            reader = command.ExecuteReader();

            for(int i = 0; i < columns[tableIndex].Length; ++i) //Отрисовка названия столбов.
            {
                dataGridView1.Columns.Add("", columns[tableIndex][i]);
            }

            while (reader.Read())
            {
                string[] fileds = new string[reader.FieldCount];
                for(int i = 0; i < reader.FieldCount; ++i)
                {
                    try
                    {
                        fileds[i] = reader[i].ToString();
                    }
                    catch (Exception e)
                    {
                        ;
                    }
                }
                dataGridView1.Rows.Add(fileds);
            }

            reader.Close();
        }

        private void DrawTable(int tableIndex, string name, string model)  //Отрисовка выбранной таблицы по имени и модели
        {
            lastTablePrint = (byte)tableIndex;
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
            lastTablePrint = (byte)tableIndex;
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
            lastTablePrint = (byte)tableIndex;
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

        private void AddNewDevice(string name, string model)    //Добавление нового девайса.
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            string dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); //Получение даты по формату DateTime в sql
            string tableName = Enum.GetName(typeof(tables), 0);
            SQLiteCommand command = new SQLiteCommand($"INSERT INTO {tableName} (modelNum, Status, FIO, StartTime) VALUES ('{model}', 'expertise', '{name}', '{dateTime}')", dbConnection);
            command.ExecuteNonQuery();
        }

        private void PrintDB_Click(object sender, EventArgs e)
        {
            DrawTable(SelectDB.SelectedIndex);
        }

        private void BtSearch_Click(object sender, EventArgs e) //Вывод только удовлетворяющией информации о устройстве.
        {
            string fullName = (Name.Text).Trim();
            string model = (Model.Text).Trim();


            if (NameCheckBox.Checked && ModelCheckBox.Checked && Name.Text != "" && Model.Text != "")
            {
                DrawTable(0, fullName, model);
            }
            else if (NameCheckBox.Checked && !ModelCheckBox.Checked && Name.Text != "")
            {
                DrawTable(0, fullName);
            }
            else if(!NameCheckBox.Checked && ModelCheckBox.Checked && Model.Text != "")
            {
                DrawTable(model, 0);
            }
            else
            {
                MessageBox.Show("Выбирите признак(и) для поиска.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)    //Добавляет девайс в таблицу и отрпавляет его на экспертизу
        {
            string fullName = (Name.Text).Trim();
            string model = (Model.Text).Trim();

            if(fullName != "" && model != "")
            {
                AddNewDevice(fullName, model);
                Name.Text = Model.Text = "";
            }
            DrawTable(0);
        }

        private void AddDamageBttn_Click(object sender, EventArgs e)
        {
            AddDamage();
        }

        private void DamageList_DoubleClick(object sender, EventArgs e)
        {
            AddDamage();
        }

        private void AddDamage()    //Переносит причину из списка возможных причин в список причин
        {
            try
            {
                thisDamageList.Items.Add(DamageList.SelectedItem);  //Не ограничивал повтор причин, т.к. причины могут повторяться.
            }
            catch
            {
                MessageBox.Show("Элемент не был выбран.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void delDamageBtn_Click(object sender, EventArgs e) //Удаляет один из типов выбраных повреждений
        {
            try
            {
                thisDamageList.Items.RemoveAt(thisDamageList.SelectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Вы не выбрали элемент.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SetMark_Click(object sender, EventArgs e)  //Именение суммы и сохранение причин поломки.
        {
            double cost;
            try
            {
                if (Double.TryParse(CostTB.Text, out cost) && lastTablePrint == 0)  //Вводить сумму можно только выбирая из таблицы с индексом 0
                {
                    string modelNum = dataGridView1[0, dataGridView1.SelectedRows[0].Index].Value.ToString();
                    string status = dataGridView1[1, dataGridView1.SelectedRows[0].Index].Value.ToString();
                    string startTime = dataGridView1[2, dataGridView1.SelectedRows[0].Index].Value.ToString();
                    string FIO = dataGridView1[3, dataGridView1.SelectedRows[0].Index].Value.ToString();
                    string reasons = null;

                    for (int i = 0; i < thisDamageList.Items.Count; ++i)
                    {
                        reasons += thisDamageList.Items[i] + "*";
                    }

                    startTime = DateTime.Parse(startTime).ToString("yyyy-MM-dd HH:mm:ss");  //Переформирование даты в нужный  для поиска формат.

                    dataGridView1.Columns.Clear();
                    dataGridView1.Refresh();

                    string tableName = Enum.GetName(typeof(tables), 0);
                    SQLiteCommand command = new SQLiteCommand($"UPDATE {tableName} SET Cost='{cost}', reasons='{reasons}'  WHERE modelNum='{modelNum}' AND status='{status}' AND FIO='{FIO}' AND StartTime='{startTime}'", dbConnection);
                    command.ExecuteNonQuery();

                    CostTB.Text = "";
                    SaveReason(modelNum);
                    thisDamageList.Items.Clear();
                    DrawTable(0);
                }
                else if (lastTablePrint != 0)
                {
                    MessageBox.Show("Попытка выбора не из той таблицы", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Введено нерпавильное число.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                ;
            }
        }

        private void SaveReason(string modelNum)    //Сохранение всех поврежденй по модели.
        {
            for(int i = 0; i < thisDamageList.Items.Count; ++i)
            {
                SQLiteCommand command = new SQLiteCommand($"INSERT INTO ModelAndReason (modelNum, reason) VALUES ('{modelNum}', '{thisDamageList.Items[i]}')", dbConnection);
                command.ExecuteNonQuery();
            }
        }

        public void UpdDamageList()    //Подтягивает список возможных повреждений из БД.
        {
            DamageList.Items.Clear();
            int tableIndex = 2;
            string tableName = Enum.GetName(typeof(tables), tableIndex);
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM {tableName}", dbConnection);
            SQLiteDataReader reader = null;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                string[] fileds = new string[reader.FieldCount];
                for (int i = 0; i < reader.FieldCount; ++i)
                {
                    DamageList.Items.Add(reader[i].ToString());
                }
            }
            reader.Close();
        }

        private void ChangeStatusBtn_Click(object sender, EventArgs e)  //Меняем статус экспертизы на починку.
        {
            ChangeStatus("repair", true);
        }

        private void ChangeW8StatusBtn_Click(object sender, EventArgs e)    //W8 Status
        {
            ChangeStatus("w8Money", false);
        }  

        private void ChangeStatus(string Status, bool setEndTime)    //Изменение статуса в таблице статуса
        {
            try
            {
                if (lastTablePrint == 0)
                {
                    string modelNum = dataGridView1[0, dataGridView1.SelectedRows[0].Index].Value.ToString();
                    string status = dataGridView1[1, dataGridView1.SelectedRows[0].Index].Value.ToString();
                    string startTime = dataGridView1[2, dataGridView1.SelectedRows[0].Index].Value.ToString();
                    string FIO = dataGridView1[3, dataGridView1.SelectedRows[0].Index].Value.ToString();
                    string Cost = dataGridView1[4, dataGridView1.SelectedRows[0].Index].Value.ToString();
                    string reasons = dataGridView1[5, dataGridView1.SelectedRows[0].Index].Value.ToString();
                    startTime = DateTime.Parse(startTime).ToString("yyyy-MM-dd HH:mm:ss");


                    double cost;
                    if (Double.TryParse(Cost, out cost))
                    {
                        string tableName = Enum.GetName(typeof(tables), 0);
                        if (setEndTime)
                        {
                            string newStartTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            SQLiteCommand command = new SQLiteCommand($"UPDATE {tableName} SET status='{Status}', StartTime='{newStartTime}' WHERE modelNum='{modelNum}' AND status='{status}' AND FIO='{FIO}' AND StartTime='{startTime}' AND Cost='{Cost}' AND reasons='{reasons}'", dbConnection);
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            SQLiteCommand command = new SQLiteCommand($"UPDATE {tableName} SET status='{Status}' WHERE modelNum='{modelNum}' AND status='{status}' AND FIO='{FIO}' AND StartTime='{startTime}' AND Cost='{Cost}' AND reasons='{reasons}'", dbConnection);
                            command.ExecuteNonQuery();
                        }
                        DrawTable(0);
                    }
                    else
                    {
                        MessageBox.Show("Нельзя переместить не оценённое устройство.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Выбрана не правильная таблица.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                ;
            }
        }

        private void DelFromWipBtn_Click(object sender, EventArgs e)    //Удаление из первой таблицы и перенос в архивную таблицу
        {
            try
            {
                if (lastTablePrint == 0)
                {
                    string modelNum = dataGridView1[0, dataGridView1.SelectedRows[0].Index].Value.ToString();
                    string status = dataGridView1[1, dataGridView1.SelectedRows[0].Index].Value.ToString();
                    string startTime = dataGridView1[2, dataGridView1.SelectedRows[0].Index].Value.ToString();
                    string FIO = dataGridView1[3, dataGridView1.SelectedRows[0].Index].Value.ToString();
                    string Cost = dataGridView1[4, dataGridView1.SelectedRows[0].Index].Value.ToString();
                    string reasons = dataGridView1[5, dataGridView1.SelectedRows[0].Index].Value.ToString();
                    string endTime = dataGridView1[6, dataGridView1.SelectedRows[0].Index].Value.ToString();
                    startTime = DateTime.Parse(startTime).ToString("yyyy-MM-dd HH:mm:ss");
                    endTime = DateTime.Parse(endTime).ToString("yyyy-MM-dd HH:mm:ss");

                    string tableName = Enum.GetName(typeof(tables), 0);
                    SQLiteCommand command = new SQLiteCommand($"DELETE FROM {tableName} WHERE modelNum='{modelNum}' AND status='{status}' AND FIO='{FIO}' AND StartTime='{startTime}' AND Cost='{Cost}' AND reasons='{reasons}' AND EndTime='{endTime}'", dbConnection);
                    command.ExecuteNonQuery();

                    tableName = Enum.GetName(typeof(tables), 1);
                    command = new SQLiteCommand($"INSERT INTO {tableName} (modelNum, StartTime, EndTime, cost, FIO) VALUES ('{modelNum}', '{startTime}', '{endTime}', '{Cost}', '{FIO}')", dbConnection);
                    command.ExecuteNonQuery();
                    DrawTable(0);
                }
            }
            catch
            {
                ;
            }
        }

        private void StopRepairBtn_Click(object sender, EventArgs e)    //Завершения починки устройства
        {
            try
            {
                if (lastTablePrint == 0)
                {
                    string modelNum = dataGridView1[0, dataGridView1.SelectedRows[0].Index].Value.ToString();
                    string status = dataGridView1[1, dataGridView1.SelectedRows[0].Index].Value.ToString();
                    string startTime = dataGridView1[2, dataGridView1.SelectedRows[0].Index].Value.ToString();
                    string FIO = dataGridView1[3, dataGridView1.SelectedRows[0].Index].Value.ToString();
                    string Cost = dataGridView1[4, dataGridView1.SelectedRows[0].Index].Value.ToString();
                    string reasons = dataGridView1[5, dataGridView1.SelectedRows[0].Index].Value.ToString();
                    startTime = DateTime.Parse(startTime).ToString("yyyy-MM-dd HH:mm:ss");


                    double cost;
                    if (Double.TryParse(Cost, out cost))
                    {
                        string tableName = Enum.GetName(typeof(tables), 0);

                        string endTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        SQLiteCommand command = new SQLiteCommand($"UPDATE {tableName} SET EndTime='{endTime}', status='W8Owner' WHERE modelNum='{modelNum}' AND status='{status}' AND FIO='{FIO}' AND StartTime='{startTime}' AND Cost='{cost}' AND reasons='{reasons}'", dbConnection);
                        command.ExecuteNonQuery();

                        DrawTable(0);
                    }
                    else
                    {
                        MessageBox.Show("Нельзя переместить не оценённое устройство.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Выбрана не правильная таблица.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                ;
            }
        }

        private void AvarageTimeBtn_Click(object sender, EventArgs e)   //Cреднее время ремонта определённой модели
        {
            List<double> times = new List<double>();
            byte tableIndex = 1;
            lastTablePrint = (byte)tableIndex;

            string tableName = Enum.GetName(typeof(tables), tableIndex);
            SQLiteCommand command = new SQLiteCommand($"SELECT StartTime, EndTime FROM {tableName} WHERE modelNum ='{ModelNumTb.Text}'", dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string[] fileds = new string[reader.FieldCount];
                for (int i = 0; i < reader.FieldCount; ++i)
                {
                    fileds[i] = reader[i].ToString();
                }
                TimeSpan deltaTime = DateTime.Parse(fileds[1]) - DateTime.Parse(fileds[0]); //Считает разницу.
                times.Add(deltaTime.TotalHours);    //Кол-во часов которое ремонтировалось устройство.
            }

            reader.Close();

            if (times.Count != 0)
            {
                double res = 0;
                for (int i = 0; i < times.Count; ++i)
                {
                    res += times[i];
                }
                res /= times.Count;
                MessageBox.Show($"Среднее время ремонта устройств с модельным номером {ModelNumTb.Text} составляет {res} часов", "Результат вашего запроса.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Не найдено информации о устройстве.", "Результат вашего запроса.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AvarageCostBtn_Click(object sender, EventArgs e)   //Средняя стоимость ремонта по модели
        {
            List<double> costs = new List<double>();
            byte tableIndex = 1;
            lastTablePrint = (byte)tableIndex;

            string tableName = Enum.GetName(typeof(tables), tableIndex);
            SQLiteCommand command = new SQLiteCommand($"SELECT cost FROM {tableName} WHERE modelNum ='{ModelNumTb.Text}'", dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string[] fileds = new string[reader.FieldCount];
                
                for (int i = 0; i < reader.FieldCount; ++i)
                {
                    fileds[i] = reader[i].ToString();
                }

                costs.Add(Convert.ToDouble(reader[0]));
            }

            reader.Close();

            if (costs.Count != 0)
            {
                double res = 0;
                for (int i = 0; i < costs.Count; ++i)
                {
                    res += costs[i];
                }
                res /= costs.Count;
                MessageBox.Show($"Средняя стоимость ремонта устройств с модельным номером {ModelNumTb.Text} составляет {res}", "Результат вашего запроса.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Не найдено информации о устройстве.", "Результат вашего запроса.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MainReasonBtn_Click(object sender, EventArgs e)    //Основная причина ремонта по модели
        {
            List<double> costs = new List<double>();
            byte tableIndex = 3;
            lastTablePrint = (byte)tableIndex;

            string tableName = Enum.GetName(typeof(tables), tableIndex);
            SQLiteCommand command = new SQLiteCommand($"SELECT reason FROM {tableName} WHERE modelNum ='{ModelNumTb.Text}' GROUP BY reason ORDER BY count(*) DESC LIMIT 1", dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if(reader.FieldCount != 0)
                {
                    MessageBox.Show($"Для устройства с модельным номером {ModelNumTb.Text} самой частой причиной поломки является: {reader[0].ToString()}", "Результат вашего запроса.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reader.Close();
                    return;
                }
            }
            reader.Close();
            MessageBox.Show($"Информация не найдедна.", "Результат вашего запроса.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void LoginProgramm(string statusUser)    //Настройка формы под тип польозователя.
        {
            Enabled = true;
            this.WindowState = FormWindowState.Normal;

            if (statusUser == "admin")
            {
                userStatus = 0;
                SelectDB.Items.Add("Возможные причины поломок");
                SelectDB.Items.Add("Модели и повреждения");
                SelectDB.Items.Add("Пользователи");
            }
            else if (statusUser == "user")
            {
                userStatus = 2;
                GroupBoxAdmin.Enabled = false;
            }
            else if(statusUser == "guest")
            {
                userStatus = 3;
                GroupBoxReasons.Enabled = GroupBoxSearch.Enabled = GroupBoxStat.Enabled = GroupBoxAdmin.Enabled = false;
            }
        }

        public SQLiteConnection GetDBConnection()
        {
            return dbConnection;
        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.Show();
        }

        private void UpdBtn_Click(object sender, EventArgs e)
        {
            UpdDamageList();
        }

        public void SetNameDB(string name = "DataBase.sqllite")     //Подключение к БД.
        {
            dbFileName = name;
            if (File.Exists(dbFileName)) {
                try
                {
                    dbConnection = new SQLiteConnection("Data Source=" + dbFileName);
                    dbConnection.Open();
                    dbCommand = new SQLiteCommand();
                    DrawTable(0);
                    UpdDamageList();
                }
                catch
                {
                    MessageBox.Show("Не удалось подключиться к базе данных. Приложение будет остановлено.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                }
            }
            else
            {
                MessageBox.Show("Файла базы данных не существует, приложение будет остановелно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }
    }
}
