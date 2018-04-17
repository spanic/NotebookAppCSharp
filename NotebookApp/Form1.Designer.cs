namespace NotebookApp {

    partial class MainForm {

        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainLabel = new System.Windows.Forms.Label();
            this.contactDataGroupBox = new System.Windows.Forms.GroupBox();
            this.commentsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.commentsLabel = new System.Windows.Forms.Label();
            this.birthbayDTPicker = new System.Windows.Forms.DateTimePicker();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.groupLabel = new System.Windows.Forms.Label();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.fathersNameTextBox = new System.Windows.Forms.TextBox();
            this.fathersNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.secondNameTextBox = new System.Windows.Forms.TextBox();
            this.secondNameLabel = new System.Windows.Forms.Label();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phonesGroupBox = new System.Windows.Forms.GroupBox();
            this.secondPhoneNumTextBox = new System.Windows.Forms.TextBox();
            this.secondPhoneNumLabel = new System.Windows.Forms.Label();
            this.mainPhoneNumTextBox = new System.Windows.Forms.TextBox();
            this.mainPhoneNumLabel = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.contactDataGroupBox.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.phonesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.mainLabel.Location = new System.Drawing.Point(12, 36);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(232, 13);
            this.mainLabel.TabIndex = 0;
            this.mainLabel.Text = "Добавьте или измените данные о контакте:";
            this.mainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contactDataGroupBox
            // 
            this.contactDataGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactDataGroupBox.Controls.Add(this.commentsRichTextBox);
            this.contactDataGroupBox.Controls.Add(this.commentsLabel);
            this.contactDataGroupBox.Controls.Add(this.birthbayDTPicker);
            this.contactDataGroupBox.Controls.Add(this.birthdayLabel);
            this.contactDataGroupBox.Controls.Add(this.groupLabel);
            this.contactDataGroupBox.Controls.Add(this.groupComboBox);
            this.contactDataGroupBox.Controls.Add(this.fathersNameTextBox);
            this.contactDataGroupBox.Controls.Add(this.fathersNameLabel);
            this.contactDataGroupBox.Controls.Add(this.firstNameTextBox);
            this.contactDataGroupBox.Controls.Add(this.firstNameLabel);
            this.contactDataGroupBox.Controls.Add(this.secondNameTextBox);
            this.contactDataGroupBox.Controls.Add(this.secondNameLabel);
            this.contactDataGroupBox.Location = new System.Drawing.Point(12, 56);
            this.contactDataGroupBox.Name = "contactDataGroupBox";
            this.contactDataGroupBox.Size = new System.Drawing.Size(576, 212);
            this.contactDataGroupBox.TabIndex = 1;
            this.contactDataGroupBox.TabStop = false;
            // 
            // commentsRichTextBox
            // 
            this.commentsRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.commentsRichTextBox.Location = new System.Drawing.Point(92, 122);
            this.commentsRichTextBox.Name = "commentsRichTextBox";
            this.commentsRichTextBox.Size = new System.Drawing.Size(475, 78);
            this.commentsRichTextBox.TabIndex = 6;
            this.commentsRichTextBox.Text = "";
            // 
            // commentsLabel
            // 
            this.commentsLabel.AutoSize = true;
            this.commentsLabel.Location = new System.Drawing.Point(6, 125);
            this.commentsLabel.Name = "commentsLabel";
            this.commentsLabel.Size = new System.Drawing.Size(80, 13);
            this.commentsLabel.TabIndex = 9;
            this.commentsLabel.Text = "Комментарии:";
            // 
            // birthbayDTPicker
            // 
            this.birthbayDTPicker.CustomFormat = "dd.MM.yyyy";
            this.birthbayDTPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthbayDTPicker.Location = new System.Drawing.Point(102, 85);
            this.birthbayDTPicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.birthbayDTPicker.Name = "birthbayDTPicker";
            this.birthbayDTPicker.Size = new System.Drawing.Size(93, 20);
            this.birthbayDTPicker.TabIndex = 4;
            this.birthbayDTPicker.Value = new System.DateTime(2018, 4, 14, 22, 21, 8, 0);
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.Location = new System.Drawing.Point(6, 88);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(90, 13);
            this.birthdayLabel.TabIndex = 8;
            this.birthdayLabel.Text = "День рождения:";
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Location = new System.Drawing.Point(217, 88);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(45, 13);
            this.groupLabel.TabIndex = 7;
            this.groupLabel.Text = "Группа:";
            // 
            // groupComboBox
            // 
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Items.AddRange(new object[] {
            "Семья",
            "Друзья",
            "Школа",
            "Университет",
            "Работа",
            "Хобби",
            "Отдых",
            "Услуги",
            "Товары",
            ""});
            this.groupComboBox.Location = new System.Drawing.Point(268, 85);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(193, 21);
            this.groupComboBox.TabIndex = 5;
            // 
            // fathersNameTextBox
            // 
            this.fathersNameTextBox.Location = new System.Drawing.Point(140, 48);
            this.fathersNameTextBox.Name = "fathersNameTextBox";
            this.fathersNameTextBox.Size = new System.Drawing.Size(186, 20);
            this.fathersNameTextBox.TabIndex = 3;
            // 
            // fathersNameLabel
            // 
            this.fathersNameLabel.AutoSize = true;
            this.fathersNameLabel.Location = new System.Drawing.Point(6, 51);
            this.fathersNameLabel.Name = "fathersNameLabel";
            this.fathersNameLabel.Size = new System.Drawing.Size(128, 13);
            this.fathersNameLabel.TabIndex = 4;
            this.fathersNameLabel.Text = "Отчество (при наличии):";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(347, 13);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(220, 20);
            this.firstNameTextBox.TabIndex = 2;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(309, 16);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(32, 13);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "Имя:";
            // 
            // secondNameTextBox
            // 
            this.secondNameTextBox.Location = new System.Drawing.Point(71, 13);
            this.secondNameTextBox.Name = "secondNameTextBox";
            this.secondNameTextBox.Size = new System.Drawing.Size(220, 20);
            this.secondNameTextBox.TabIndex = 1;
            // 
            // secondNameLabel
            // 
            this.secondNameLabel.AutoSize = true;
            this.secondNameLabel.Location = new System.Drawing.Point(6, 16);
            this.secondNameLabel.Name = "secondNameLabel";
            this.secondNameLabel.Size = new System.Drawing.Size(59, 13);
            this.secondNameLabel.TabIndex = 0;
            this.secondNameLabel.Text = "Фамилия:";
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(600, 24);
            this.mainMenuStrip.TabIndex = 2;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.programToolStripMenuItem.Text = "Программа";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.infoToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.infoToolStripMenuItem.Text = "Информация";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // phonesGroupBox
            // 
            this.phonesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phonesGroupBox.Controls.Add(this.secondPhoneNumTextBox);
            this.phonesGroupBox.Controls.Add(this.secondPhoneNumLabel);
            this.phonesGroupBox.Controls.Add(this.mainPhoneNumTextBox);
            this.phonesGroupBox.Controls.Add(this.mainPhoneNumLabel);
            this.phonesGroupBox.Location = new System.Drawing.Point(12, 274);
            this.phonesGroupBox.Name = "phonesGroupBox";
            this.phonesGroupBox.Size = new System.Drawing.Size(576, 41);
            this.phonesGroupBox.TabIndex = 3;
            this.phonesGroupBox.TabStop = false;
            // 
            // secondPhoneNumTextBox
            // 
            this.secondPhoneNumTextBox.Location = new System.Drawing.Point(386, 13);
            this.secondPhoneNumTextBox.Name = "secondPhoneNumTextBox";
            this.secondPhoneNumTextBox.Size = new System.Drawing.Size(181, 20);
            this.secondPhoneNumTextBox.TabIndex = 2;
            // 
            // secondPhoneNumLabel
            // 
            this.secondPhoneNumLabel.AutoSize = true;
            this.secondPhoneNumLabel.Location = new System.Drawing.Point(309, 16);
            this.secondPhoneNumLabel.Name = "secondPhoneNumLabel";
            this.secondPhoneNumLabel.Size = new System.Drawing.Size(71, 13);
            this.secondPhoneNumLabel.TabIndex = 2;
            this.secondPhoneNumLabel.Text = "Доп. тел. №:";
            // 
            // mainPhoneNumTextBox
            // 
            this.mainPhoneNumTextBox.Location = new System.Drawing.Point(109, 13);
            this.mainPhoneNumTextBox.Name = "mainPhoneNumTextBox";
            this.mainPhoneNumTextBox.Size = new System.Drawing.Size(182, 20);
            this.mainPhoneNumTextBox.TabIndex = 1;
            // 
            // mainPhoneNumLabel
            // 
            this.mainPhoneNumLabel.AutoSize = true;
            this.mainPhoneNumLabel.Location = new System.Drawing.Point(6, 16);
            this.mainPhoneNumLabel.Name = "mainPhoneNumLabel";
            this.mainPhoneNumLabel.Size = new System.Drawing.Size(97, 13);
            this.mainPhoneNumLabel.TabIndex = 0;
            this.mainPhoneNumLabel.Text = "Основной тел. №:";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 350);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(576, 347);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView_RowHeaderMouseClick);
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(304, 321);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(223, 321);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(385, 321);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(203, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Выход из режима редактирования";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 709);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.phonesGroupBox);
            this.Controls.Add(this.contactDataGroupBox);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notebook App";
            this.contactDataGroupBox.ResumeLayout(false);
            this.contactDataGroupBox.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.phonesGroupBox.ResumeLayout(false);
            this.phonesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.GroupBox contactDataGroupBox;
        private System.Windows.Forms.TextBox secondNameTextBox;
        private System.Windows.Forms.Label secondNameLabel;
        private System.Windows.Forms.TextBox fathersNameTextBox;
        private System.Windows.Forms.Label fathersNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.GroupBox phonesGroupBox;
        private System.Windows.Forms.Label secondPhoneNumLabel;
        private System.Windows.Forms.TextBox mainPhoneNumTextBox;
        private System.Windows.Forms.Label mainPhoneNumLabel;
        private System.Windows.Forms.DateTimePicker birthbayDTPicker;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.ComboBox groupComboBox;
        private System.Windows.Forms.TextBox secondPhoneNumTextBox;
        private System.Windows.Forms.RichTextBox commentsRichTextBox;
        private System.Windows.Forms.Label commentsLabel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }

}
