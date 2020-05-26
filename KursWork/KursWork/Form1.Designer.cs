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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 922);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button PrintDB;
        private System.Windows.Forms.ComboBox SelectDB;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

