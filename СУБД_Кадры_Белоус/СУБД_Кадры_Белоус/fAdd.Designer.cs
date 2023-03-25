namespace СУБД_Кадры_Белоус
{
    partial class fAdd
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
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label patronymicLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAdd));
            this.pLogo = new System.Windows.Forms.Panel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.TbxEmail = new System.Windows.Forms.TextBox();
            this.TbxPhone = new System.Windows.Forms.TextBox();
            this.TbxPatronymic = new System.Windows.Forms.TextBox();
            this.TbxFirstName = new System.Windows.Forms.TextBox();
            this.TbxLastName = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.DtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.RbtFemale = new System.Windows.Forms.RadioButton();
            this.RbtMale = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.LblGenderCode = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            patronymicLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            this.pLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(45, 246);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(105, 15);
            birthdayLabel.TabIndex = 23;
            birthdayLabel.Text = "Дата рождения:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(88, 220);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(56, 15);
            emailLabel.TabIndex = 21;
            emailLabel.Text = "E-mail:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(81, 190);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(63, 15);
            phoneLabel.TabIndex = 19;
            phoneLabel.Text = "Телефон:";
            // 
            // patronymicLabel
            // 
            patronymicLabel.AutoSize = true;
            patronymicLabel.Location = new System.Drawing.Point(74, 163);
            patronymicLabel.Name = "patronymicLabel";
            patronymicLabel.Size = new System.Drawing.Size(70, 15);
            patronymicLabel.TabIndex = 17;
            patronymicLabel.Text = "Отчество:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(109, 136);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(35, 15);
            firstNameLabel.TabIndex = 15;
            firstNameLabel.Text = "Имя:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(81, 109);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(63, 15);
            lastNameLabel.TabIndex = 13;
            lastNameLabel.Text = "Фамилия:";
            // 
            // pLogo
            // 
            this.pLogo.BackColor = System.Drawing.Color.Moccasin;
            this.pLogo.Controls.Add(this.LblTitle);
            this.pLogo.Controls.Add(this.pbIcon);
            this.pLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLogo.Location = new System.Drawing.Point(0, 0);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(490, 100);
            this.pLogo.TabIndex = 2;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblTitle.Location = new System.Drawing.Point(117, 37);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(218, 23);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "Добавление кадра";
            // 
            // pbIcon
            // 
            this.pbIcon.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbIcon.Image")));
            this.pbIcon.Location = new System.Drawing.Point(390, 0);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(100, 100);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcon.TabIndex = 0;
            this.pbIcon.TabStop = false;
            // 
            // TbxEmail
            // 
            this.TbxEmail.Location = new System.Drawing.Point(155, 214);
            this.TbxEmail.Name = "TbxEmail";
            this.TbxEmail.Size = new System.Drawing.Size(199, 21);
            this.TbxEmail.TabIndex = 22;
            // 
            // TbxPhone
            // 
            this.TbxPhone.Location = new System.Drawing.Point(156, 187);
            this.TbxPhone.Name = "TbxPhone";
            this.TbxPhone.Size = new System.Drawing.Size(199, 21);
            this.TbxPhone.TabIndex = 20;
            // 
            // TbxPatronymic
            // 
            this.TbxPatronymic.Location = new System.Drawing.Point(155, 160);
            this.TbxPatronymic.MaxLength = 50;
            this.TbxPatronymic.Name = "TbxPatronymic";
            this.TbxPatronymic.Size = new System.Drawing.Size(199, 21);
            this.TbxPatronymic.TabIndex = 18;
            this.TbxPatronymic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxLastName_KeyPress);
            // 
            // TbxFirstName
            // 
            this.TbxFirstName.Location = new System.Drawing.Point(155, 133);
            this.TbxFirstName.MaxLength = 50;
            this.TbxFirstName.Name = "TbxFirstName";
            this.TbxFirstName.Size = new System.Drawing.Size(199, 21);
            this.TbxFirstName.TabIndex = 16;
            this.TbxFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxLastName_KeyPress);
            // 
            // TbxLastName
            // 
            this.TbxLastName.Location = new System.Drawing.Point(156, 106);
            this.TbxLastName.MaxLength = 50;
            this.TbxLastName.Name = "TbxLastName";
            this.TbxLastName.Size = new System.Drawing.Size(199, 21);
            this.TbxLastName.TabIndex = 14;
            this.TbxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxLastName_KeyPress);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.Moccasin;
            this.BtnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnSave.Location = new System.Drawing.Point(0, 332);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(490, 30);
            this.BtnSave.TabIndex = 26;
            this.BtnSave.Text = "Сохранить";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.Moccasin;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnCancel.Location = new System.Drawing.Point(0, 362);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(490, 30);
            this.BtnCancel.TabIndex = 25;
            this.BtnCancel.Text = "Отменить";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // DtpBirthday
            // 
            this.DtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpBirthday.Location = new System.Drawing.Point(156, 241);
            this.DtpBirthday.Name = "DtpBirthday";
            this.DtpBirthday.Size = new System.Drawing.Size(200, 21);
            this.DtpBirthday.TabIndex = 28;
            // 
            // RbtFemale
            // 
            this.RbtFemale.AutoSize = true;
            this.RbtFemale.Location = new System.Drawing.Point(276, 279);
            this.RbtFemale.Name = "RbtFemale";
            this.RbtFemale.Size = new System.Drawing.Size(74, 19);
            this.RbtFemale.TabIndex = 31;
            this.RbtFemale.Text = "женский";
            this.RbtFemale.UseVisualStyleBackColor = true;
            this.RbtFemale.CheckedChanged += new System.EventHandler(this.RbtFemale_CheckedChanged);
            // 
            // RbtMale
            // 
            this.RbtMale.AutoSize = true;
            this.RbtMale.Checked = true;
            this.RbtMale.Location = new System.Drawing.Point(196, 279);
            this.RbtMale.Name = "RbtMale";
            this.RbtMale.Size = new System.Drawing.Size(74, 19);
            this.RbtMale.TabIndex = 30;
            this.RbtMale.TabStop = true;
            this.RbtMale.Text = "мужской";
            this.RbtMale.UseVisualStyleBackColor = true;
            this.RbtMale.CheckedChanged += new System.EventHandler(this.RbtMale_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Пол:";
            // 
            // LblGenderCode
            // 
            this.LblGenderCode.AutoSize = true;
            this.LblGenderCode.Location = new System.Drawing.Point(371, 301);
            this.LblGenderCode.Name = "LblGenderCode";
            this.LblGenderCode.Size = new System.Drawing.Size(14, 15);
            this.LblGenderCode.TabIndex = 32;
            this.LblGenderCode.Text = "м";
            this.LblGenderCode.Visible = false;
            // 
            // fAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(490, 392);
            this.Controls.Add(this.LblGenderCode);
            this.Controls.Add(this.RbtFemale);
            this.Controls.Add(this.RbtMale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DtpBirthday);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(birthdayLabel);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.TbxEmail);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.TbxPhone);
            this.Controls.Add(patronymicLabel);
            this.Controls.Add(this.TbxPatronymic);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.TbxFirstName);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.TbxLastName);
            this.Controls.Add(this.pLogo);
            this.Font = new System.Drawing.Font("Courier New", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "fAdd";
            this.Text = "Добавление кадра";
            this.pLogo.ResumeLayout(false);
            this.pLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pLogo;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.TextBox TbxEmail;
        private System.Windows.Forms.TextBox TbxPhone;
        private System.Windows.Forms.TextBox TbxPatronymic;
        private System.Windows.Forms.TextBox TbxFirstName;
        private System.Windows.Forms.TextBox TbxLastName;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.DateTimePicker DtpBirthday;
        private System.Windows.Forms.RadioButton RbtFemale;
        private System.Windows.Forms.RadioButton RbtMale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblGenderCode;
    }
}