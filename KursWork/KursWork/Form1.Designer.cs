namespace KursWork
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PrintDB = new System.Windows.Forms.Button();
            this.SelectDB = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ModelCheckBox = new System.Windows.Forms.CheckBox();
            this.NameCheckBox = new System.Windows.Forms.CheckBox();
            this.Model = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.DelFromWipBtn = new System.Windows.Forms.Button();
            this.ChangeStatusBtn = new System.Windows.Forms.Button();
            this.StopRepairBtn = new System.Windows.Forms.Button();
            this.ChangeW8StatusBtn = new System.Windows.Forms.Button();
            this.DamageList = new System.Windows.Forms.ListBox();
            this.delDamageBtn = new System.Windows.Forms.Button();
            this.thisDamageList = new System.Windows.Forms.ListBox();
            this.SetMark = new System.Windows.Forms.Button();
            this.CostTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lable = new System.Windows.Forms.Label();
            this.AddDamageBttn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(886, 213);
            this.dataGridView1.TabIndex = 0;
            // 
            // PrintDB
            // 
            this.PrintDB.Location = new System.Drawing.Point(220, 236);
            this.PrintDB.Name = "PrintDB";
            this.PrintDB.Size = new System.Drawing.Size(75, 23);
            this.PrintDB.TabIndex = 1;
            this.PrintDB.Text = "Вывод";
            this.PrintDB.UseVisualStyleBackColor = true;
            this.PrintDB.Click += new System.EventHandler(this.PrintDB_Click);
            // 
            // SelectDB
            // 
            this.SelectDB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SelectDB.Items.AddRange(new object[] {
            "Устройства в работе",
            "Законченые устройства"});
            this.SelectDB.Location = new System.Drawing.Point(6, 238);
            this.SelectDB.Name = "SelectDB";
            this.SelectDB.Size = new System.Drawing.Size(208, 21);
            this.SelectDB.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.PrintDB);
            this.groupBox1.Controls.Add(this.SelectDB);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(898, 267);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Панель вывода базы данных";
            // 
            // BtSearch
            // 
            this.BtSearch.Location = new System.Drawing.Point(6, 65);
            this.BtSearch.Name = "BtSearch";
            this.BtSearch.Size = new System.Drawing.Size(114, 23);
            this.BtSearch.TabIndex = 4;
            this.BtSearch.Text = "Поиск";
            this.BtSearch.UseVisualStyleBackColor = true;
            this.BtSearch.Click += new System.EventHandler(this.BtSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ФИО: ";
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(61, 30);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(228, 20);
            this.Name.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AddButton);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.Model);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Name);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 291);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 127);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(9, 95);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(280, 23);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "Принять устройство на экспертизу";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ModelCheckBox);
            this.groupBox4.Controls.Add(this.BtSearch);
            this.groupBox4.Controls.Add(this.NameCheckBox);
            this.groupBox4.Location = new System.Drawing.Point(295, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(127, 99);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Проверка статуса";
            // 
            // ModelCheckBox
            // 
            this.ModelCheckBox.AutoSize = true;
            this.ModelCheckBox.Location = new System.Drawing.Point(6, 42);
            this.ModelCheckBox.Name = "ModelCheckBox";
            this.ModelCheckBox.Size = new System.Drawing.Size(114, 17);
            this.ModelCheckBox.TabIndex = 10;
            this.ModelCheckBox.Text = "Поиск по модели";
            this.ModelCheckBox.UseVisualStyleBackColor = true;
            // 
            // NameCheckBox
            // 
            this.NameCheckBox.AutoSize = true;
            this.NameCheckBox.Location = new System.Drawing.Point(6, 19);
            this.NameCheckBox.Name = "NameCheckBox";
            this.NameCheckBox.Size = new System.Drawing.Size(103, 17);
            this.NameCheckBox.TabIndex = 9;
            this.NameCheckBox.Text = "Поиск по ФИО";
            this.NameCheckBox.UseVisualStyleBackColor = true;
            // 
            // Model
            // 
            this.Model.Location = new System.Drawing.Point(61, 56);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(228, 20);
            this.Model.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Модель:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.DamageList);
            this.groupBox3.Controls.Add(this.delDamageBtn);
            this.groupBox3.Controls.Add(this.thisDamageList);
            this.groupBox3.Controls.Add(this.SetMark);
            this.groupBox3.Controls.Add(this.CostTB);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lable);
            this.groupBox3.Controls.Add(this.AddDamageBttn);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(449, 291);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(461, 550);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Оценка и ремонт";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.DelFromWipBtn);
            this.groupBox5.Controls.Add(this.ChangeStatusBtn);
            this.groupBox5.Controls.Add(this.StopRepairBtn);
            this.groupBox5.Controls.Add(this.ChangeW8StatusBtn);
            this.groupBox5.Location = new System.Drawing.Point(9, 409);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(446, 135);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Изменение статуса";
            // 
            // DelFromWipBtn
            // 
            this.DelFromWipBtn.Location = new System.Drawing.Point(6, 106);
            this.DelFromWipBtn.Name = "DelFromWipBtn";
            this.DelFromWipBtn.Size = new System.Drawing.Size(434, 23);
            this.DelFromWipBtn.TabIndex = 23;
            this.DelFromWipBtn.Text = "Устройство передано клиенту";
            this.DelFromWipBtn.UseVisualStyleBackColor = true;
            this.DelFromWipBtn.Click += new System.EventHandler(this.DelFromWipBtn_Click);
            // 
            // ChangeStatusBtn
            // 
            this.ChangeStatusBtn.Location = new System.Drawing.Point(6, 48);
            this.ChangeStatusBtn.Name = "ChangeStatusBtn";
            this.ChangeStatusBtn.Size = new System.Drawing.Size(434, 23);
            this.ChangeStatusBtn.TabIndex = 21;
            this.ChangeStatusBtn.Text = "Перевести устройство из экспертизы в починку";
            this.ChangeStatusBtn.UseVisualStyleBackColor = true;
            this.ChangeStatusBtn.Click += new System.EventHandler(this.ChangeStatusBtn_Click);
            // 
            // StopRepairBtn
            // 
            this.StopRepairBtn.Location = new System.Drawing.Point(6, 77);
            this.StopRepairBtn.Name = "StopRepairBtn";
            this.StopRepairBtn.Size = new System.Drawing.Size(434, 23);
            this.StopRepairBtn.TabIndex = 24;
            this.StopRepairBtn.Text = "Устройство починено, остановка починки";
            this.StopRepairBtn.UseVisualStyleBackColor = true;
            this.StopRepairBtn.Click += new System.EventHandler(this.StopRepairBtn_Click);
            // 
            // ChangeW8StatusBtn
            // 
            this.ChangeW8StatusBtn.Location = new System.Drawing.Point(6, 19);
            this.ChangeW8StatusBtn.Name = "ChangeW8StatusBtn";
            this.ChangeW8StatusBtn.Size = new System.Drawing.Size(434, 23);
            this.ChangeW8StatusBtn.TabIndex = 22;
            this.ChangeW8StatusBtn.Text = "Перевести в ожидание оплаты";
            this.ChangeW8StatusBtn.UseVisualStyleBackColor = true;
            this.ChangeW8StatusBtn.Click += new System.EventHandler(this.ChangeW8StatusBtn_Click);
            // 
            // DamageList
            // 
            this.DamageList.FormattingEnabled = true;
            this.DamageList.Location = new System.Drawing.Point(152, 12);
            this.DamageList.Name = "DamageList";
            this.DamageList.Size = new System.Drawing.Size(303, 147);
            this.DamageList.TabIndex = 20;
            this.DamageList.DoubleClick += new System.EventHandler(this.DamageList_DoubleClick);
            // 
            // delDamageBtn
            // 
            this.delDamageBtn.Location = new System.Drawing.Point(6, 217);
            this.delDamageBtn.Name = "delDamageBtn";
            this.delDamageBtn.Size = new System.Drawing.Size(140, 23);
            this.delDamageBtn.TabIndex = 19;
            this.delDamageBtn.Text = "Удалить повреждение";
            this.delDamageBtn.UseVisualStyleBackColor = true;
            this.delDamageBtn.Click += new System.EventHandler(this.delDamageBtn_Click);
            // 
            // thisDamageList
            // 
            this.thisDamageList.FormattingEnabled = true;
            this.thisDamageList.Location = new System.Drawing.Point(152, 201);
            this.thisDamageList.Name = "thisDamageList";
            this.thisDamageList.Size = new System.Drawing.Size(303, 147);
            this.thisDamageList.TabIndex = 9;
            // 
            // SetMark
            // 
            this.SetMark.Location = new System.Drawing.Point(6, 380);
            this.SetMark.Name = "SetMark";
            this.SetMark.Size = new System.Drawing.Size(449, 23);
            this.SetMark.TabIndex = 18;
            this.SetMark.Text = "Закончить оценку";
            this.SetMark.UseVisualStyleBackColor = true;
            this.SetMark.Click += new System.EventHandler(this.SetMark_Click);
            // 
            // CostTB
            // 
            this.CostTB.Location = new System.Drawing.Point(183, 354);
            this.CostTB.Name = "CostTB";
            this.CostTB.Size = new System.Drawing.Size(272, 20);
            this.CostTB.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Оценочная стоимось: ";
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Location = new System.Drawing.Point(6, 201);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(140, 13);
            this.lable.TabIndex = 14;
            this.lable.Text = "Повреждения устройства:";
            // 
            // AddDamageBttn
            // 
            this.AddDamageBttn.Location = new System.Drawing.Point(6, 172);
            this.AddDamageBttn.Name = "AddDamageBttn";
            this.AddDamageBttn.Size = new System.Drawing.Size(449, 23);
            this.AddDamageBttn.TabIndex = 13;
            this.AddDamageBttn.Text = "Добавить повреждение из списка";
            this.AddDamageBttn.UseVisualStyleBackColor = true;
            this.AddDamageBttn.Click += new System.EventHandler(this.AddDamageBttn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Список  повреждений: ";
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(12, 424);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(431, 147);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Вывод стат. данных";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 922);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Курсач Мишани - Мишанин курсач";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button PrintDB;
        private System.Windows.Forms.ComboBox SelectDB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Model;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox NameCheckBox;
        private System.Windows.Forms.CheckBox ModelCheckBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Button AddDamageBttn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SetMark;
        private System.Windows.Forms.TextBox CostTB;
        private System.Windows.Forms.ListBox thisDamageList;
        private System.Windows.Forms.Button delDamageBtn;
        private System.Windows.Forms.ListBox DamageList;
        private System.Windows.Forms.Button ChangeStatusBtn;
        private System.Windows.Forms.Button ChangeW8StatusBtn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button DelFromWipBtn;
        private System.Windows.Forms.Button StopRepairBtn;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}

