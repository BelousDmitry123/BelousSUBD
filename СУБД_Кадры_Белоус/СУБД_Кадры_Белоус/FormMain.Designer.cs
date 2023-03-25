namespace СУБД_Кадры_Белоус
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pLogo = new System.Windows.Forms.Panel();
            this.lListClients = new System.Windows.Forms.Label();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.DgvClients = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmbSort = new System.Windows.Forms.ComboBox();
            this.CmbFilter = new System.Windows.Forms.ComboBox();
            this.TbFind = new System.Windows.Forms.TextBox();
            this.lSort = new System.Windows.Forms.Label();
            this.lGender = new System.Windows.Forms.Label();
            this.lTextFind = new System.Windows.Forms.Label();
            this.LblNext = new System.Windows.Forms.Label();
            this.LblBack = new System.Windows.Forms.Label();
            this.PanelPages = new System.Windows.Forms.Panel();
            this.BtnDel = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.CmbFind = new System.Windows.Forms.ComboBox();
            this.lFind = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TslInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.pLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClients)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pLogo
            // 
            this.pLogo.BackColor = System.Drawing.Color.Moccasin;
            this.pLogo.Controls.Add(this.lListClients);
            this.pLogo.Controls.Add(this.pbIcon);
            this.pLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLogo.Location = new System.Drawing.Point(0, 0);
            this.pLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(981, 115);
            this.pLogo.TabIndex = 1;
            // 
            // lListClients
            // 
            this.lListClients.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lListClients.AutoSize = true;
            this.lListClients.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lListClients.Location = new System.Drawing.Point(366, 46);
            this.lListClients.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lListClients.Name = "lListClients";
            this.lListClients.Size = new System.Drawing.Size(179, 23);
            this.lListClients.TabIndex = 1;
            this.lListClients.Text = "Список кадров";
            this.lListClients.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbIcon
            // 
            this.pbIcon.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbIcon.Image")));
            this.pbIcon.Location = new System.Drawing.Point(864, 0);
            this.pbIcon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(117, 115);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcon.TabIndex = 0;
            this.pbIcon.TabStop = false;
            // 
            // DgvClients
            // 
            this.DgvClients.AllowUserToAddRows = false;
            this.DgvClients.AllowUserToDeleteRows = false;
            this.DgvClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvClients.BackgroundColor = System.Drawing.Color.White;
            this.DgvClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvClients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClients.ColumnHeadersVisible = false;
            this.DgvClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3});
            this.DgvClients.GridColor = System.Drawing.Color.White;
            this.DgvClients.Location = new System.Drawing.Point(29, 191);
            this.DgvClients.MultiSelect = false;
            this.DgvClients.Name = "DgvClients";
            this.DgvClients.ReadOnly = true;
            this.DgvClients.RowHeadersVisible = false;
            this.DgvClients.RowHeadersWidth = 51;
            this.DgvClients.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvClients.RowTemplate.DividerHeight = 10;
            this.DgvClients.RowTemplate.Height = 70;
            this.DgvClients.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvClients.Size = new System.Drawing.Size(920, 320);
            this.DgvClients.TabIndex = 12;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // CmbSort
            // 
            this.CmbSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSort.FormattingEnabled = true;
            this.CmbSort.Items.AddRange(new object[] {
            "Без сортировки",
            "Фамилии",
            "Дате рождения"});
            this.CmbSort.Location = new System.Drawing.Point(642, 146);
            this.CmbSort.Name = "CmbSort";
            this.CmbSort.Size = new System.Drawing.Size(199, 23);
            this.CmbSort.TabIndex = 18;
            this.CmbSort.SelectedIndexChanged += new System.EventHandler(this.CmbSort_SelectedIndexChanged);
            // 
            // CmbFilter
            // 
            this.CmbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbFilter.BackColor = System.Drawing.Color.Moccasin;
            this.CmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFilter.FormattingEnabled = true;
            this.CmbFilter.Items.AddRange(new object[] {
            "без фильтрации",
            "мужской",
            "женский"});
            this.CmbFilter.Location = new System.Drawing.Point(465, 146);
            this.CmbFilter.Name = "CmbFilter";
            this.CmbFilter.Size = new System.Drawing.Size(159, 23);
            this.CmbFilter.TabIndex = 17;
            this.CmbFilter.SelectedIndexChanged += new System.EventHandler(this.CmbFilter_SelectedIndexChanged);
            // 
            // TbFind
            // 
            this.TbFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbFind.BackColor = System.Drawing.Color.Moccasin;
            this.TbFind.Location = new System.Drawing.Point(160, 146);
            this.TbFind.Name = "TbFind";
            this.TbFind.Size = new System.Drawing.Size(292, 21);
            this.TbFind.TabIndex = 16;
            this.TbFind.TextChanged += new System.EventHandler(this.TbFind_TextChanged);
            // 
            // lSort
            // 
            this.lSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lSort.AutoSize = true;
            this.lSort.Location = new System.Drawing.Point(639, 128);
            this.lSort.Name = "lSort";
            this.lSort.Size = new System.Drawing.Size(112, 15);
            this.lSort.TabIndex = 15;
            this.lSort.Text = "Сортировать по:";
            // 
            // lGender
            // 
            this.lGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lGender.AutoSize = true;
            this.lGender.Location = new System.Drawing.Point(462, 128);
            this.lGender.Name = "lGender";
            this.lGender.Size = new System.Drawing.Size(140, 15);
            this.lGender.TabIndex = 14;
            this.lGender.Text = "Фильтрация по полу:";
            // 
            // lTextFind
            // 
            this.lTextFind.AutoSize = true;
            this.lTextFind.Location = new System.Drawing.Point(157, 128);
            this.lTextFind.Name = "lTextFind";
            this.lTextFind.Size = new System.Drawing.Size(182, 15);
            this.lTextFind.TabIndex = 13;
            this.lTextFind.Text = "Введите текст для поиска:";
            // 
            // LblNext
            // 
            this.LblNext.AutoSize = true;
            this.LblNext.Location = new System.Drawing.Point(203, 589);
            this.LblNext.Name = "LblNext";
            this.LblNext.Size = new System.Drawing.Size(14, 15);
            this.LblNext.TabIndex = 26;
            this.LblNext.Text = ">";
            this.LblNext.Click += new System.EventHandler(this.LblNext_Click);
            // 
            // LblBack
            // 
            this.LblBack.AutoSize = true;
            this.LblBack.Location = new System.Drawing.Point(36, 589);
            this.LblBack.Name = "LblBack";
            this.LblBack.Size = new System.Drawing.Size(14, 15);
            this.LblBack.TabIndex = 25;
            this.LblBack.Text = "<";
            this.LblBack.Click += new System.EventHandler(this.LblBack_Click);
            // 
            // PanelPages
            // 
            this.PanelPages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelPages.Location = new System.Drawing.Point(0, 607);
            this.PanelPages.Name = "PanelPages";
            this.PanelPages.Size = new System.Drawing.Size(981, 39);
            this.PanelPages.TabIndex = 24;
            // 
            // BtnDel
            // 
            this.BtnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDel.BackColor = System.Drawing.Color.Moccasin;
            this.BtnDel.Location = new System.Drawing.Point(791, 546);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(178, 30);
            this.BtnDel.TabIndex = 23;
            this.BtnDel.Text = "Удалить";
            this.BtnDel.UseVisualStyleBackColor = false;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAdd.BackColor = System.Drawing.Color.Moccasin;
            this.BtnAdd.Location = new System.Drawing.Point(579, 546);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(178, 30);
            this.BtnAdd.TabIndex = 21;
            this.BtnAdd.Text = "Добавить";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // CmbFind
            // 
            this.CmbFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFind.FormattingEnabled = true;
            this.CmbFind.Items.AddRange(new object[] {
            "Фамилии",
            "Имени",
            "Отчеству"});
            this.CmbFind.Location = new System.Drawing.Point(33, 144);
            this.CmbFind.Name = "CmbFind";
            this.CmbFind.Size = new System.Drawing.Size(118, 23);
            this.CmbFind.TabIndex = 28;
            // 
            // lFind
            // 
            this.lFind.AutoSize = true;
            this.lFind.Location = new System.Drawing.Point(30, 128);
            this.lFind.Name = "lFind";
            this.lFind.Size = new System.Drawing.Size(70, 15);
            this.lFind.TabIndex = 27;
            this.lFind.Text = "Поиск по:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TslInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 627);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(981, 22);
            this.statusStrip1.TabIndex = 29;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TslInfo
            // 
            this.TslInfo.Name = "TslInfo";
            this.TslInfo.Size = new System.Drawing.Size(118, 17);
            this.TslInfo.Text = "toolStripStatusLabel1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(981, 649);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.CmbFind);
            this.Controls.Add(this.lFind);
            this.Controls.Add(this.LblNext);
            this.Controls.Add(this.LblBack);
            this.Controls.Add(this.PanelPages);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.CmbSort);
            this.Controls.Add(this.CmbFilter);
            this.Controls.Add(this.TbFind);
            this.Controls.Add(this.lSort);
            this.Controls.Add(this.lGender);
            this.Controls.Add(this.lTextFind);
            this.Controls.Add(this.DgvClients);
            this.Controls.Add(this.pLogo);
            this.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СУБД \"Кадры\"";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.pLogo.ResumeLayout(false);
            this.pLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClients)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pLogo;
        private System.Windows.Forms.Label lListClients;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.DataGridView DgvClients;
        private System.Windows.Forms.ComboBox CmbSort;
        private System.Windows.Forms.ComboBox CmbFilter;
        private System.Windows.Forms.TextBox TbFind;
        private System.Windows.Forms.Label lSort;
        private System.Windows.Forms.Label lGender;
        private System.Windows.Forms.Label lTextFind;
        private System.Windows.Forms.Label LblNext;
        private System.Windows.Forms.Label LblBack;
        private System.Windows.Forms.Panel PanelPages;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ComboBox CmbFind;
        private System.Windows.Forms.Label lFind;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TslInfo;
    }
}

