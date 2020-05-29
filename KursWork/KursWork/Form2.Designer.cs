namespace KursWork
{
    partial class Form2
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
            this.JoinBtn = new System.Windows.Forms.Button();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PassTB = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GroupBoxJoin = new System.Windows.Forms.GroupBox();
            this.GroupBoxSelect = new System.Windows.Forms.GroupBox();
            this.HereBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.GroupBoxJoin.SuspendLayout();
            this.GroupBoxSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // JoinBtn
            // 
            this.JoinBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.JoinBtn.Location = new System.Drawing.Point(10, 68);
            this.JoinBtn.MinimumSize = new System.Drawing.Size(154, 23);
            this.JoinBtn.Name = "JoinBtn";
            this.JoinBtn.Size = new System.Drawing.Size(167, 27);
            this.JoinBtn.TabIndex = 0;
            this.JoinBtn.Text = "вход";
            this.JoinBtn.UseVisualStyleBackColor = true;
            this.JoinBtn.Click += new System.EventHandler(this.JoinBtn_Click);
            // 
            // LoginTB
            // 
            this.LoginTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginTB.Location = new System.Drawing.Point(64, 16);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(113, 20);
            this.LoginTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль:";
            // 
            // PassTB
            // 
            this.PassTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PassTB.Location = new System.Drawing.Point(64, 42);
            this.PassTB.Name = "PassTB";
            this.PassTB.Size = new System.Drawing.Size(113, 20);
            this.PassTB.TabIndex = 3;
            // 
            // GroupBoxJoin
            // 
            this.GroupBoxJoin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxJoin.Controls.Add(this.PassTB);
            this.GroupBoxJoin.Controls.Add(this.label2);
            this.GroupBoxJoin.Controls.Add(this.JoinBtn);
            this.GroupBoxJoin.Controls.Add(this.LoginTB);
            this.GroupBoxJoin.Controls.Add(this.label1);
            this.GroupBoxJoin.Location = new System.Drawing.Point(12, 106);
            this.GroupBoxJoin.Name = "GroupBoxJoin";
            this.GroupBoxJoin.Size = new System.Drawing.Size(185, 103);
            this.GroupBoxJoin.TabIndex = 5;
            this.GroupBoxJoin.TabStop = false;
            this.GroupBoxJoin.Text = "Вход";
            // 
            // GroupBoxSelect
            // 
            this.GroupBoxSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxSelect.Controls.Add(this.SearchBtn);
            this.GroupBoxSelect.Controls.Add(this.HereBtn);
            this.GroupBoxSelect.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxSelect.Name = "GroupBoxSelect";
            this.GroupBoxSelect.Size = new System.Drawing.Size(185, 76);
            this.GroupBoxSelect.TabIndex = 6;
            this.GroupBoxSelect.TabStop = false;
            this.GroupBoxSelect.Text = "Выбор БД";
            // 
            // HereBtn
            // 
            this.HereBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HereBtn.Location = new System.Drawing.Point(6, 19);
            this.HereBtn.MinimumSize = new System.Drawing.Size(154, 23);
            this.HereBtn.Name = "HereBtn";
            this.HereBtn.Size = new System.Drawing.Size(173, 23);
            this.HereBtn.TabIndex = 5;
            this.HereBtn.Text = "В дериктории с прогрммой";
            this.HereBtn.UseVisualStyleBackColor = true;
            this.HereBtn.Click += new System.EventHandler(this.HereBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBtn.Location = new System.Drawing.Point(6, 48);
            this.SearchBtn.MinimumSize = new System.Drawing.Size(154, 23);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(173, 23);
            this.SearchBtn.TabIndex = 6;
            this.SearchBtn.Text = "Выбрать файл БД";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 218);
            this.Controls.Add(this.GroupBoxSelect);
            this.Controls.Add(this.GroupBoxJoin);
            this.Name = "Form2";
            this.Text = "Вход";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.GroupBoxJoin.ResumeLayout(false);
            this.GroupBoxJoin.PerformLayout();
            this.GroupBoxSelect.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button JoinBtn;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PassTB;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox GroupBoxJoin;
        private System.Windows.Forms.GroupBox GroupBoxSelect;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button HereBtn;
    }
}