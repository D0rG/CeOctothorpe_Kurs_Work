namespace KursWork
{
    partial class Form3
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
            this.AddReasonBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reasonTB = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.adminRB = new System.Windows.Forms.RadioButton();
            this.guestRB = new System.Windows.Forms.RadioButton();
            this.userRB = new System.Windows.Forms.RadioButton();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PassTB = new System.Windows.Forms.TextBox();
            this.AddUserBtn = new System.Windows.Forms.Button();
            this.DelUserBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddReasonBtn
            // 
            this.AddReasonBtn.Location = new System.Drawing.Point(9, 58);
            this.AddReasonBtn.Name = "AddReasonBtn";
            this.AddReasonBtn.Size = new System.Drawing.Size(414, 23);
            this.AddReasonBtn.TabIndex = 0;
            this.AddReasonBtn.Text = "Добавить причину.";
            this.AddReasonBtn.UseVisualStyleBackColor = true;
            this.AddReasonBtn.Click += new System.EventHandler(this.AddReasonBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reasonTB);
            this.groupBox1.Controls.Add(this.AddReasonBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 89);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Возмоная причина поломки:";
            // 
            // reasonTB
            // 
            this.reasonTB.Location = new System.Drawing.Point(9, 32);
            this.reasonTB.Name = "reasonTB";
            this.reasonTB.Size = new System.Drawing.Size(414, 20);
            this.reasonTB.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DelUserBtn);
            this.groupBox2.Controls.Add(this.AddUserBtn);
            this.groupBox2.Controls.Add(this.PassTB);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.LoginTB);
            this.groupBox2.Controls.Add(this.userRB);
            this.groupBox2.Controls.Add(this.guestRB);
            this.groupBox2.Controls.Add(this.adminRB);
            this.groupBox2.Location = new System.Drawing.Point(12, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 95);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Пользователи";
            // 
            // adminRB
            // 
            this.adminRB.AutoSize = true;
            this.adminRB.Location = new System.Drawing.Point(6, 19);
            this.adminRB.Name = "adminRB";
            this.adminRB.Size = new System.Drawing.Size(58, 17);
            this.adminRB.TabIndex = 0;
            this.adminRB.TabStop = true;
            this.adminRB.Text = "Aдмин";
            this.adminRB.UseVisualStyleBackColor = true;
            // 
            // guestRB
            // 
            this.guestRB.AutoSize = true;
            this.guestRB.Location = new System.Drawing.Point(6, 42);
            this.guestRB.Name = "guestRB";
            this.guestRB.Size = new System.Drawing.Size(54, 17);
            this.guestRB.TabIndex = 1;
            this.guestRB.TabStop = true;
            this.guestRB.Text = "Гость";
            this.guestRB.UseVisualStyleBackColor = true;
            // 
            // userRB
            // 
            this.userRB.AutoSize = true;
            this.userRB.Location = new System.Drawing.Point(6, 65);
            this.userRB.Name = "userRB";
            this.userRB.Size = new System.Drawing.Size(98, 17);
            this.userRB.TabIndex = 2;
            this.userRB.TabStop = true;
            this.userRB.Text = "Пользователь";
            this.userRB.UseVisualStyleBackColor = true;
            // 
            // LoginTB
            // 
            this.LoginTB.Location = new System.Drawing.Point(151, 19);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(272, 20);
            this.LoginTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Логин:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Пароль:";
            // 
            // PassTB
            // 
            this.PassTB.Location = new System.Drawing.Point(151, 43);
            this.PassTB.Name = "PassTB";
            this.PassTB.Size = new System.Drawing.Size(272, 20);
            this.PassTB.TabIndex = 5;
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.Location = new System.Drawing.Point(151, 65);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Size = new System.Drawing.Size(79, 23);
            this.AddUserBtn.TabIndex = 3;
            this.AddUserBtn.Text = "Добавить";
            this.AddUserBtn.UseVisualStyleBackColor = true;
            this.AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
            // 
            // DelUserBtn
            // 
            this.DelUserBtn.Location = new System.Drawing.Point(236, 65);
            this.DelUserBtn.Name = "DelUserBtn";
            this.DelUserBtn.Size = new System.Drawing.Size(187, 23);
            this.DelUserBtn.TabIndex = 6;
            this.DelUserBtn.Text = "Удалить";
            this.DelUserBtn.UseVisualStyleBackColor = true;
            this.DelUserBtn.Click += new System.EventHandler(this.DelUserBtn_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 211);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Admin Panel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddReasonBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox reasonTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox PassTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.RadioButton userRB;
        private System.Windows.Forms.RadioButton guestRB;
        private System.Windows.Forms.RadioButton adminRB;
        private System.Windows.Forms.Button DelUserBtn;
        private System.Windows.Forms.Button AddUserBtn;
    }
}