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
            this.Model = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameCheckBox = new System.Windows.Forms.CheckBox();
            this.ModelCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(861, 213);
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
            this.SelectDB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.PrintDB);
            this.groupBox1.Controls.Add(this.SelectDB);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(873, 267);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Панель вывода базы данных";
            // 
            // BtSearch
            // 
            this.BtSearch.Location = new System.Drawing.Point(9, 128);
            this.BtSearch.Name = "BtSearch";
            this.BtSearch.Size = new System.Drawing.Size(280, 23);
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
            this.groupBox2.Controls.Add(this.ModelCheckBox);
            this.groupBox2.Controls.Add(this.NameCheckBox);
            this.groupBox2.Controls.Add(this.Model);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Name);
            this.groupBox2.Controls.Add(this.BtSearch);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 291);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 156);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Проверка состояния";
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
            // NameCheckBox
            // 
            this.NameCheckBox.AutoSize = true;
            this.NameCheckBox.Location = new System.Drawing.Point(9, 82);
            this.NameCheckBox.Name = "NameCheckBox";
            this.NameCheckBox.Size = new System.Drawing.Size(103, 17);
            this.NameCheckBox.TabIndex = 9;
            this.NameCheckBox.Text = "Поиск по ФИО";
            this.NameCheckBox.UseVisualStyleBackColor = true;
            // 
            // ModelCheckBox
            // 
            this.ModelCheckBox.AutoSize = true;
            this.ModelCheckBox.Location = new System.Drawing.Point(9, 105);
            this.ModelCheckBox.Name = "ModelCheckBox";
            this.ModelCheckBox.Size = new System.Drawing.Size(114, 17);
            this.ModelCheckBox.TabIndex = 10;
            this.ModelCheckBox.Text = "Поиск по модели";
            this.ModelCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 922);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
    }
}

