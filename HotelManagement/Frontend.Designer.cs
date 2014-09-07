namespace Hotel_Manager
{
    partial class Frontend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frontend));
            this.resPanel = new MetroFramework.Controls.MetroTabControl();
            this.reservationPage = new MetroFramework.Controls.MetroTabPage();
            this.rightMPanel = new MetroFramework.Controls.MetroPanel();
            this.resEditButton = new MetroFramework.Controls.MetroComboBox();
            this.newButton = new MetroFramework.Controls.MetroButton();
            this.deleteButton = new MetroFramework.Controls.MetroButton();
            this.editButton = new MetroFramework.Controls.MetroButton();
            this.updateButton = new MetroFramework.Controls.MetroButton();
            this.middlePanel = new MetroFramework.Controls.MetroPanel();
            this.smsCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.foodSupplyCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.checkinCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.foodMenuButton = new MetroFramework.Controls.MetroButton();
            this.qtGuestComboBox = new MetroFramework.Controls.MetroComboBox();
            this.finalizeButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.submitButton = new MetroFramework.Controls.MetroButton();
            this.depDatePicker = new System.Windows.Forms.DateTimePicker();
            this.roomNComboBox = new MetroFramework.Controls.MetroComboBox();
            this.floorComboBox = new MetroFramework.Controls.MetroComboBox();
            this.entryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.entryLabel = new MetroFramework.Controls.MetroLabel();
            this.roomTypeComboBox = new MetroFramework.Controls.MetroComboBox();
            this.choiceLabel = new MetroFramework.Controls.MetroLabel();
            this.leftMPanel = new MetroFramework.Controls.MetroPanel();
            this.emailLabel = new MetroFramework.Controls.MetroLabel();
            this.nameLabel = new MetroFramework.Controls.MetroLabel();
            this.emailTextBox = new MetroFramework.Controls.MetroTextBox();
            this.yearTextBox = new MetroFramework.Controls.MetroTextBox();
            this.monthComboBox = new MetroFramework.Controls.MetroComboBox();
            this.genderComboBox = new MetroFramework.Controls.MetroComboBox();
            this.birthdayLabel = new MetroFramework.Controls.MetroLabel();
            this.dayComboBox = new MetroFramework.Controls.MetroComboBox();
            this.phoneNumberLabel = new MetroFramework.Controls.MetroLabel();
            this.firstNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.genderLabel = new MetroFramework.Controls.MetroLabel();
            this.zipComboBox = new MetroFramework.Controls.MetroTextBox();
            this.phoneNumberTextBox = new MetroFramework.Controls.MetroTextBox();
            this.stateComboBox = new MetroFramework.Controls.MetroComboBox();
            this.lastNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.cityTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.aptTextBox = new MetroFramework.Controls.MetroTextBox();
            this.addLabel = new MetroFramework.Controls.MetroTextBox();
            this.searchPage = new MetroFramework.Controls.MetroTabPage();
            this.SearchError = new MetroFramework.Controls.MetroLabel();
            this.searchDataGridView = new System.Windows.Forms.DataGridView();
            this.searchButton = new MetroFramework.Controls.MetroButton();
            this.searchTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.resTotalDataGridView = new System.Windows.Forms.DataGridView();
            this.roomPage = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.reservedLabel = new MetroFramework.Controls.MetroLabel();
            this.roomReservedListBox = new System.Windows.Forms.ListBox();
            this.roomOccupiedListBox = new System.Windows.Forms.ListBox();
            this.occupiedLabel = new MetroFramework.Controls.MetroLabel();
            this.resPanel.SuspendLayout();
            this.reservationPage.SuspendLayout();
            this.rightMPanel.SuspendLayout();
            this.middlePanel.SuspendLayout();
            this.leftMPanel.SuspendLayout();
            this.searchPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resTotalDataGridView)).BeginInit();
            this.roomPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // resPanel
            // 
            this.resPanel.Controls.Add(this.reservationPage);
            this.resPanel.Controls.Add(this.searchPage);
            this.resPanel.Controls.Add(this.metroTabPage2);
            this.resPanel.Controls.Add(this.roomPage);
            this.resPanel.Location = new System.Drawing.Point(8, 59);
            this.resPanel.Name = "resPanel";
            this.resPanel.SelectedIndex = 0;
            this.resPanel.Size = new System.Drawing.Size(984, 482);
            this.resPanel.Style = MetroFramework.MetroColorStyle.Green;
            this.resPanel.TabIndex = 0;
            this.resPanel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.resPanel.UseSelectable = true;
            // 
            // reservationPage
            // 
            this.reservationPage.Controls.Add(this.rightMPanel);
            this.reservationPage.Controls.Add(this.middlePanel);
            this.reservationPage.Controls.Add(this.leftMPanel);
            this.reservationPage.HorizontalScrollbarBarColor = true;
            this.reservationPage.HorizontalScrollbarHighlightOnWheel = false;
            this.reservationPage.HorizontalScrollbarSize = 10;
            this.reservationPage.Location = new System.Drawing.Point(4, 38);
            this.reservationPage.Name = "reservationPage";
            this.reservationPage.Size = new System.Drawing.Size(976, 440);
            this.reservationPage.Style = MetroFramework.MetroColorStyle.Green;
            this.reservationPage.TabIndex = 0;
            this.reservationPage.Text = "Reservation";
            this.reservationPage.Theme = MetroFramework.MetroThemeStyle.Light;
            this.reservationPage.VerticalScrollbarBarColor = true;
            this.reservationPage.VerticalScrollbarHighlightOnWheel = false;
            this.reservationPage.VerticalScrollbarSize = 10;
            // 
            // rightMPanel
            // 
            this.rightMPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.rightMPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rightMPanel.Controls.Add(this.resEditButton);
            this.rightMPanel.Controls.Add(this.newButton);
            this.rightMPanel.Controls.Add(this.deleteButton);
            this.rightMPanel.Controls.Add(this.editButton);
            this.rightMPanel.Controls.Add(this.updateButton);
            this.rightMPanel.HorizontalScrollbarBarColor = true;
            this.rightMPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.rightMPanel.HorizontalScrollbarSize = 10;
            this.rightMPanel.Location = new System.Drawing.Point(708, 14);
            this.rightMPanel.Name = "rightMPanel";
            this.rightMPanel.Size = new System.Drawing.Size(265, 421);
            this.rightMPanel.TabIndex = 34;
            this.rightMPanel.UseCustomBackColor = true;
            this.rightMPanel.UseCustomForeColor = true;
            this.rightMPanel.UseStyleColors = true;
            this.rightMPanel.VerticalScrollbarBarColor = true;
            this.rightMPanel.VerticalScrollbarHighlightOnWheel = false;
            this.rightMPanel.VerticalScrollbarSize = 10;
            // 
            // resEditButton
            // 
            this.resEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resEditButton.ForeColor = System.Drawing.Color.Green;
            this.resEditButton.FormattingEnabled = true;
            this.resEditButton.ItemHeight = 23;
            this.resEditButton.Items.AddRange(new object[] {
            "[ID]    [NAME]    [PHONE NUMBER]"});
            this.resEditButton.Location = new System.Drawing.Point(10, 30);
            this.resEditButton.Name = "resEditButton";
            this.resEditButton.PromptText = "Select reservation to edit";
            this.resEditButton.Size = new System.Drawing.Size(252, 29);
            this.resEditButton.TabIndex = 20;
            this.resEditButton.UseCustomForeColor = true;
            this.resEditButton.UseSelectable = true;
            this.resEditButton.UseStyleColors = true;
            this.resEditButton.Visible = false;
            this.resEditButton.SelectedIndexChanged += new System.EventHandler(this.resEditButton_SelectedIndexChanged);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(10, 375);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(245, 32);
            this.newButton.Style = MetroFramework.MetroColorStyle.Green;
            this.newButton.TabIndex = 22;
            this.newButton.Text = "New reservation";
            this.newButton.UseSelectable = true;
            this.newButton.UseStyleColors = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Highlight = true;
            this.deleteButton.Location = new System.Drawing.Point(10, 288);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(245, 34);
            this.deleteButton.Style = MetroFramework.MetroColorStyle.Red;
            this.deleteButton.TabIndex = 23;
            this.deleteButton.Text = "Delete";
            this.deleteButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.deleteButton.UseSelectable = true;
            this.deleteButton.UseStyleColors = true;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(10, 335);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(245, 32);
            this.editButton.Style = MetroFramework.MetroColorStyle.Green;
            this.editButton.TabIndex = 18;
            this.editButton.Text = "Edit existing Reservation";
            this.editButton.UseSelectable = true;
            this.editButton.UseStyleColors = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Enabled = false;
            this.updateButton.Highlight = true;
            this.updateButton.Location = new System.Drawing.Point(10, 245);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(245, 34);
            this.updateButton.Style = MetroFramework.MetroColorStyle.Green;
            this.updateButton.TabIndex = 19;
            this.updateButton.Text = "Update";
            this.updateButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.updateButton.UseSelectable = true;
            this.updateButton.UseStyleColors = true;
            this.updateButton.Visible = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // middlePanel
            // 
            this.middlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.middlePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.middlePanel.Controls.Add(this.smsCheckBox);
            this.middlePanel.Controls.Add(this.foodSupplyCheckBox);
            this.middlePanel.Controls.Add(this.checkinCheckBox);
            this.middlePanel.Controls.Add(this.foodMenuButton);
            this.middlePanel.Controls.Add(this.qtGuestComboBox);
            this.middlePanel.Controls.Add(this.finalizeButton);
            this.middlePanel.Controls.Add(this.metroLabel12);
            this.middlePanel.Controls.Add(this.submitButton);
            this.middlePanel.Controls.Add(this.depDatePicker);
            this.middlePanel.Controls.Add(this.roomNComboBox);
            this.middlePanel.Controls.Add(this.floorComboBox);
            this.middlePanel.Controls.Add(this.entryDatePicker);
            this.middlePanel.Controls.Add(this.entryLabel);
            this.middlePanel.Controls.Add(this.roomTypeComboBox);
            this.middlePanel.Controls.Add(this.choiceLabel);
            this.middlePanel.HorizontalScrollbarBarColor = true;
            this.middlePanel.HorizontalScrollbarHighlightOnWheel = false;
            this.middlePanel.HorizontalScrollbarSize = 10;
            this.middlePanel.Location = new System.Drawing.Point(355, 14);
            this.middlePanel.Name = "middlePanel";
            this.middlePanel.Size = new System.Drawing.Size(345, 421);
            this.middlePanel.TabIndex = 16;
            this.middlePanel.UseCustomBackColor = true;
            this.middlePanel.UseCustomForeColor = true;
            this.middlePanel.UseStyleColors = true;
            this.middlePanel.VerticalScrollbarBarColor = true;
            this.middlePanel.VerticalScrollbarHighlightOnWheel = false;
            this.middlePanel.VerticalScrollbarSize = 10;
            // 
            // smsCheckBox
            // 
            this.smsCheckBox.AutoSize = true;
            this.smsCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.smsCheckBox.Location = new System.Drawing.Point(105, 291);
            this.smsCheckBox.Name = "smsCheckBox";
            this.smsCheckBox.Size = new System.Drawing.Size(78, 15);
            this.smsCheckBox.Style = MetroFramework.MetroColorStyle.Green;
            this.smsCheckBox.TabIndex = 35;
            this.smsCheckBox.Text = "Send sms?";
            this.smsCheckBox.UseCustomBackColor = true;
            this.smsCheckBox.UseSelectable = true;
            // 
            // foodSupplyCheckBox
            // 
            this.foodSupplyCheckBox.AutoSize = true;
            this.foodSupplyCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.foodSupplyCheckBox.Location = new System.Drawing.Point(194, 290);
            this.foodSupplyCheckBox.Name = "foodSupplyCheckBox";
            this.foodSupplyCheckBox.Size = new System.Drawing.Size(133, 15);
            this.foodSupplyCheckBox.Style = MetroFramework.MetroColorStyle.Green;
            this.foodSupplyCheckBox.TabIndex = 34;
            this.foodSupplyCheckBox.Text = "Food/Supply status ?";
            this.foodSupplyCheckBox.UseCustomBackColor = true;
            this.foodSupplyCheckBox.UseSelectable = true;
            this.foodSupplyCheckBox.CheckedChanged += new System.EventHandler(this.foodSupplyCheckBox_CheckedChanged);
            // 
            // checkinCheckBox
            // 
            this.checkinCheckBox.AutoSize = true;
            this.checkinCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.checkinCheckBox.Location = new System.Drawing.Point(16, 291);
            this.checkinCheckBox.Name = "checkinCheckBox";
            this.checkinCheckBox.Size = new System.Drawing.Size(77, 15);
            this.checkinCheckBox.Style = MetroFramework.MetroColorStyle.Green;
            this.checkinCheckBox.TabIndex = 33;
            this.checkinCheckBox.Text = "Check in ?";
            this.checkinCheckBox.UseCustomBackColor = true;
            this.checkinCheckBox.UseSelectable = true;
            this.checkinCheckBox.CheckedChanged += new System.EventHandler(this.checkinCheckBox_CheckedChanged);
            // 
            // foodMenuButton
            // 
            this.foodMenuButton.Location = new System.Drawing.Point(16, 243);
            this.foodMenuButton.Name = "foodMenuButton";
            this.foodMenuButton.Size = new System.Drawing.Size(314, 34);
            this.foodMenuButton.Style = MetroFramework.MetroColorStyle.Green;
            this.foodMenuButton.TabIndex = 23;
            this.foodMenuButton.Text = "Food and menu";
            this.foodMenuButton.UseSelectable = true;
            this.foodMenuButton.UseStyleColors = true;
            this.foodMenuButton.Click += new System.EventHandler(this.foodMenuButton_Click);
            // 
            // qtGuestComboBox
            // 
            this.qtGuestComboBox.FormattingEnabled = true;
            this.qtGuestComboBox.ItemHeight = 23;
            this.qtGuestComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.qtGuestComboBox.Location = new System.Drawing.Point(16, 30);
            this.qtGuestComboBox.Name = "qtGuestComboBox";
            this.qtGuestComboBox.PromptText = "# of guests";
            this.qtGuestComboBox.Size = new System.Drawing.Size(151, 29);
            this.qtGuestComboBox.TabIndex = 25;
            this.qtGuestComboBox.UseSelectable = true;
            // 
            // finalizeButton
            // 
            this.finalizeButton.Location = new System.Drawing.Point(16, 337);
            this.finalizeButton.Name = "finalizeButton";
            this.finalizeButton.Size = new System.Drawing.Size(314, 31);
            this.finalizeButton.Style = MetroFramework.MetroColorStyle.Green;
            this.finalizeButton.TabIndex = 22;
            this.finalizeButton.Text = "Finalize bill";
            this.finalizeButton.UseSelectable = true;
            this.finalizeButton.UseStyleColors = true;
            this.finalizeButton.Click += new System.EventHandler(this.finalizeButton_Click);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel12.Location = new System.Drawing.Point(16, 169);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(110, 19);
            this.metroLabel12.TabIndex = 32;
            this.metroLabel12.Text = "Deperture [date]";
            this.metroLabel12.UseCustomBackColor = true;
            this.metroLabel12.UseCustomForeColor = true;
            // 
            // submitButton
            // 
            this.submitButton.Highlight = true;
            this.submitButton.Location = new System.Drawing.Point(16, 372);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(314, 36);
            this.submitButton.Style = MetroFramework.MetroColorStyle.Green;
            this.submitButton.TabIndex = 17;
            this.submitButton.Text = "Submit";
            this.submitButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.submitButton.UseSelectable = true;
            this.submitButton.UseStyleColors = true;
            this.submitButton.Visible = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // depDatePicker
            // 
            this.depDatePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depDatePicker.CustomFormat = "MM-dd-yyyy";
            this.depDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.depDatePicker.Location = new System.Drawing.Point(16, 191);
            this.depDatePicker.MaxDate = new System.DateTime(2015, 4, 27, 23, 59, 0, 0);
            this.depDatePicker.MinDate = new System.DateTime(2014, 4, 27, 0, 0, 0, 0);
            this.depDatePicker.Name = "depDatePicker";
            this.depDatePicker.Size = new System.Drawing.Size(316, 26);
            this.depDatePicker.TabIndex = 31;
            this.depDatePicker.Value = new System.DateTime(2014, 4, 27, 0, 0, 0, 0);
            // 
            // roomNComboBox
            // 
            this.roomNComboBox.FormattingEnabled = true;
            this.roomNComboBox.ItemHeight = 23;
            this.roomNComboBox.Items.AddRange(new object[] {
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "201",
            "202",
            "203",
            "204",
            "205",
            "206",
            "207",
            "208",
            "209",
            "210",
            "301",
            "302",
            "303",
            "304",
            "305",
            "306",
            "307",
            "308",
            "309",
            "310",
            "401",
            "402",
            "403",
            "404",
            "405",
            "406",
            "407",
            "408",
            "409",
            "410",
            "501",
            "502",
            "503",
            "504",
            "505",
            "506",
            "507",
            "508",
            "509",
            "510"});
            this.roomNComboBox.Location = new System.Drawing.Point(173, 83);
            this.roomNComboBox.Name = "roomNComboBox";
            this.roomNComboBox.PromptText = "#";
            this.roomNComboBox.Size = new System.Drawing.Size(159, 29);
            this.roomNComboBox.TabIndex = 24;
            this.roomNComboBox.UseSelectable = true;
            // 
            // floorComboBox
            // 
            this.floorComboBox.FormattingEnabled = true;
            this.floorComboBox.ItemHeight = 23;
            this.floorComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.floorComboBox.Location = new System.Drawing.Point(16, 83);
            this.floorComboBox.Name = "floorComboBox";
            this.floorComboBox.PromptText = "Floor";
            this.floorComboBox.Size = new System.Drawing.Size(151, 29);
            this.floorComboBox.TabIndex = 23;
            this.floorComboBox.UseSelectable = true;
            // 
            // entryDatePicker
            // 
            this.entryDatePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryDatePicker.CustomFormat = "MM-dd-yyyy";
            this.entryDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.entryDatePicker.Location = new System.Drawing.Point(16, 140);
            this.entryDatePicker.MaxDate = new System.DateTime(2015, 4, 27, 23, 59, 0, 0);
            this.entryDatePicker.MinDate = new System.DateTime(2014, 5, 11, 0, 0, 0, 0);
            this.entryDatePicker.Name = "entryDatePicker";
            this.entryDatePicker.Size = new System.Drawing.Size(314, 26);
            this.entryDatePicker.TabIndex = 26;
            this.entryDatePicker.Value = new System.DateTime(2014, 5, 11, 0, 0, 0, 0);
            // 
            // entryLabel
            // 
            this.entryLabel.AutoSize = true;
            this.entryLabel.BackColor = System.Drawing.Color.Transparent;
            this.entryLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.entryLabel.Location = new System.Drawing.Point(16, 118);
            this.entryLabel.Name = "entryLabel";
            this.entryLabel.Size = new System.Drawing.Size(80, 19);
            this.entryLabel.TabIndex = 30;
            this.entryLabel.Text = "Entry [date]";
            this.entryLabel.UseCustomBackColor = true;
            this.entryLabel.UseCustomForeColor = true;
            // 
            // roomTypeComboBox
            // 
            this.roomTypeComboBox.FormattingEnabled = true;
            this.roomTypeComboBox.ItemHeight = 23;
            this.roomTypeComboBox.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Twin",
            "Duplex",
            "Suite"});
            this.roomTypeComboBox.Location = new System.Drawing.Point(173, 29);
            this.roomTypeComboBox.Name = "roomTypeComboBox";
            this.roomTypeComboBox.PromptText = "Room type";
            this.roomTypeComboBox.Size = new System.Drawing.Size(159, 29);
            this.roomTypeComboBox.TabIndex = 22;
            this.roomTypeComboBox.UseSelectable = true;
            this.roomTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.roomTypeComboBox_SelectedIndexChanged);
            // 
            // choiceLabel
            // 
            this.choiceLabel.AutoSize = true;
            this.choiceLabel.BackColor = System.Drawing.Color.Transparent;
            this.choiceLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.choiceLabel.Location = new System.Drawing.Point(16, 8);
            this.choiceLabel.Name = "choiceLabel";
            this.choiceLabel.Size = new System.Drawing.Size(86, 19);
            this.choiceLabel.TabIndex = 21;
            this.choiceLabel.Text = "Your choices";
            this.choiceLabel.UseCustomBackColor = true;
            this.choiceLabel.UseCustomForeColor = true;
            // 
            // leftMPanel
            // 
            this.leftMPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.leftMPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.leftMPanel.Controls.Add(this.emailLabel);
            this.leftMPanel.Controls.Add(this.nameLabel);
            this.leftMPanel.Controls.Add(this.emailTextBox);
            this.leftMPanel.Controls.Add(this.yearTextBox);
            this.leftMPanel.Controls.Add(this.monthComboBox);
            this.leftMPanel.Controls.Add(this.genderComboBox);
            this.leftMPanel.Controls.Add(this.birthdayLabel);
            this.leftMPanel.Controls.Add(this.dayComboBox);
            this.leftMPanel.Controls.Add(this.phoneNumberLabel);
            this.leftMPanel.Controls.Add(this.firstNameTextBox);
            this.leftMPanel.Controls.Add(this.genderLabel);
            this.leftMPanel.Controls.Add(this.zipComboBox);
            this.leftMPanel.Controls.Add(this.phoneNumberTextBox);
            this.leftMPanel.Controls.Add(this.stateComboBox);
            this.leftMPanel.Controls.Add(this.lastNameTextBox);
            this.leftMPanel.Controls.Add(this.cityTextBox);
            this.leftMPanel.Controls.Add(this.metroLabel6);
            this.leftMPanel.Controls.Add(this.aptTextBox);
            this.leftMPanel.Controls.Add(this.addLabel);
            this.leftMPanel.HorizontalScrollbarBarColor = true;
            this.leftMPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.leftMPanel.HorizontalScrollbarSize = 10;
            this.leftMPanel.Location = new System.Drawing.Point(3, 15);
            this.leftMPanel.Name = "leftMPanel";
            this.leftMPanel.Size = new System.Drawing.Size(345, 421);
            this.leftMPanel.TabIndex = 4;
            this.leftMPanel.UseCustomBackColor = true;
            this.leftMPanel.UseCustomForeColor = true;
            this.leftMPanel.UseStyleColors = true;
            this.leftMPanel.VerticalScrollbarBarColor = true;
            this.leftMPanel.VerticalScrollbarHighlightOnWheel = false;
            this.leftMPanel.VerticalScrollbarSize = 10;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.emailLabel.Location = new System.Drawing.Point(15, 225);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(131, 19);
            this.emailLabel.TabIndex = 15;
            this.emailLabel.Text = "Your e-mail address";
            this.emailLabel.UseCustomBackColor = true;
            this.emailLabel.UseCustomForeColor = true;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.nameLabel.Location = new System.Drawing.Point(14, 7);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 19);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name";
            this.nameLabel.UseCustomBackColor = true;
            this.nameLabel.UseCustomForeColor = true;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.White;
            this.emailTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.emailTextBox.Lines = new string[0];
            this.emailTextBox.Location = new System.Drawing.Point(15, 247);
            this.emailTextBox.MaxLength = 32767;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PasswordChar = '\0';
            this.emailTextBox.PromptText = "first.last@example.com";
            this.emailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emailTextBox.SelectedText = "";
            this.emailTextBox.Size = new System.Drawing.Size(316, 29);
            this.emailTextBox.Style = MetroFramework.MetroColorStyle.White;
            this.emailTextBox.TabIndex = 14;
            this.emailTextBox.UseCustomBackColor = true;
            this.emailTextBox.UseSelectable = true;
            // 
            // yearTextBox
            // 
            this.yearTextBox.BackColor = System.Drawing.Color.White;
            this.yearTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.yearTextBox.Lines = new string[0];
            this.yearTextBox.Location = new System.Drawing.Point(230, 84);
            this.yearTextBox.MaxLength = 32767;
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.PasswordChar = '\0';
            this.yearTextBox.PromptText = "Year";
            this.yearTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.yearTextBox.SelectedText = "";
            this.yearTextBox.Size = new System.Drawing.Size(101, 29);
            this.yearTextBox.Style = MetroFramework.MetroColorStyle.White;
            this.yearTextBox.TabIndex = 9;
            this.yearTextBox.UseCustomBackColor = true;
            this.yearTextBox.UseSelectable = true;
            // 
            // monthComboBox
            // 
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.ItemHeight = 23;
            this.monthComboBox.Items.AddRange(new object[] {
            "January ",
            "February ",
            "March ",
            "April ",
            "May ",
            "June ",
            "July ",
            "August ",
            "September ",
            "October ",
            "November ",
            "December"});
            this.monthComboBox.Location = new System.Drawing.Point(15, 84);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.PromptText = "Month";
            this.monthComboBox.Size = new System.Drawing.Size(120, 29);
            this.monthComboBox.TabIndex = 6;
            this.monthComboBox.UseSelectable = true;
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.ItemHeight = 23;
            this.genderComboBox.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Other"});
            this.genderComboBox.Location = new System.Drawing.Point(15, 140);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.PromptText = "........";
            this.genderComboBox.Size = new System.Drawing.Size(315, 29);
            this.genderComboBox.TabIndex = 11;
            this.genderComboBox.UseSelectable = true;
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.BackColor = System.Drawing.Color.Transparent;
            this.birthdayLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.birthdayLabel.Location = new System.Drawing.Point(12, 63);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(60, 19);
            this.birthdayLabel.TabIndex = 5;
            this.birthdayLabel.Text = "Birthday";
            this.birthdayLabel.UseCustomBackColor = true;
            this.birthdayLabel.UseCustomForeColor = true;
            // 
            // dayComboBox
            // 
            this.dayComboBox.FormattingEnabled = true;
            this.dayComboBox.ItemHeight = 23;
            this.dayComboBox.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.dayComboBox.Location = new System.Drawing.Point(141, 84);
            this.dayComboBox.Name = "dayComboBox";
            this.dayComboBox.PromptText = "Day";
            this.dayComboBox.Size = new System.Drawing.Size(83, 29);
            this.dayComboBox.TabIndex = 8;
            this.dayComboBox.UseSelectable = true;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.phoneNumberLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.phoneNumberLabel.Location = new System.Drawing.Point(14, 171);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(100, 19);
            this.phoneNumberLabel.TabIndex = 12;
            this.phoneNumberLabel.Text = "Phone number";
            this.phoneNumberLabel.UseCustomBackColor = true;
            this.phoneNumberLabel.UseCustomForeColor = true;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BackColor = System.Drawing.Color.White;
            this.firstNameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.firstNameTextBox.Lines = new string[0];
            this.firstNameTextBox.Location = new System.Drawing.Point(15, 27);
            this.firstNameTextBox.MaxLength = 32767;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.PasswordChar = '\0';
            this.firstNameTextBox.PromptText = "First";
            this.firstNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.firstNameTextBox.SelectedText = "";
            this.firstNameTextBox.Size = new System.Drawing.Size(155, 29);
            this.firstNameTextBox.Style = MetroFramework.MetroColorStyle.White;
            this.firstNameTextBox.TabIndex = 2;
            this.firstNameTextBox.UseCustomBackColor = true;
            this.firstNameTextBox.UseSelectable = true;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.BackColor = System.Drawing.Color.Transparent;
            this.genderLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.genderLabel.Location = new System.Drawing.Point(13, 118);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(54, 19);
            this.genderLabel.TabIndex = 10;
            this.genderLabel.Text = "Gender";
            this.genderLabel.UseCustomBackColor = true;
            this.genderLabel.UseCustomForeColor = true;
            // 
            // zipComboBox
            // 
            this.zipComboBox.BackColor = System.Drawing.Color.White;
            this.zipComboBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.zipComboBox.Lines = new string[0];
            this.zipComboBox.Location = new System.Drawing.Point(172, 378);
            this.zipComboBox.MaxLength = 32767;
            this.zipComboBox.Name = "zipComboBox";
            this.zipComboBox.PasswordChar = '\0';
            this.zipComboBox.PromptText = "Zip code";
            this.zipComboBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.zipComboBox.SelectedText = "";
            this.zipComboBox.Size = new System.Drawing.Size(159, 29);
            this.zipComboBox.Style = MetroFramework.MetroColorStyle.White;
            this.zipComboBox.TabIndex = 20;
            this.zipComboBox.UseCustomBackColor = true;
            this.zipComboBox.UseSelectable = true;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.BackColor = System.Drawing.Color.White;
            this.phoneNumberTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.phoneNumberTextBox.Lines = new string[0];
            this.phoneNumberTextBox.Location = new System.Drawing.Point(14, 193);
            this.phoneNumberTextBox.MaxLength = 32767;
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.PasswordChar = '\0';
            this.phoneNumberTextBox.PromptText = "(999) 999-999";
            this.phoneNumberTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.phoneNumberTextBox.SelectedText = "";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(316, 29);
            this.phoneNumberTextBox.Style = MetroFramework.MetroColorStyle.White;
            this.phoneNumberTextBox.TabIndex = 13;
            this.phoneNumberTextBox.UseCustomBackColor = true;
            this.phoneNumberTextBox.UseSelectable = true;
            this.phoneNumberTextBox.Leave += new System.EventHandler(this.phoneNumberTextBox_Leave);
            // 
            // stateComboBox
            // 
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.ItemHeight = 23;
            this.stateComboBox.Items.AddRange(new object[] {
            "Alabama ",
            "Alaska ",
            "Arizona ",
            "Arkansas ",
            "California ",
            "Colorado ",
            "Connecticut ",
            "Delaware ",
            "Florida ",
            "Georgia ",
            "Hawaii ",
            "Idaho ",
            "Illinois Indiana ",
            "Iowa ",
            "Kansas ",
            "Kentucky ",
            "Louisiana ",
            "Maine ",
            "Maryland ",
            "Massachusetts ",
            "Michigan ",
            "Minnesota ",
            "Mississippi ",
            "Missouri ",
            "Montana Nebraska ",
            "Nevada ",
            "New Hampshire ",
            "New Jersey ",
            "New Mexico ",
            "New York ",
            "North Carolina ",
            "North Dakota ",
            "Ohio ",
            "Oklahoma ",
            "Oregon ",
            "Pennsylvania Rhode Island ",
            "South Carolina ",
            "South Dakota ",
            "Tennessee ",
            "Texas ",
            "Utah ",
            "Vermont ",
            "Virginia ",
            "Washington ",
            "West Virginia ",
            "Wisconsin ",
            "Wyoming"});
            this.stateComboBox.Location = new System.Drawing.Point(15, 378);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.PromptText = "State";
            this.stateComboBox.Size = new System.Drawing.Size(150, 29);
            this.stateComboBox.TabIndex = 19;
            this.stateComboBox.UseSelectable = true;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BackColor = System.Drawing.Color.White;
            this.lastNameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.lastNameTextBox.Lines = new string[0];
            this.lastNameTextBox.Location = new System.Drawing.Point(176, 27);
            this.lastNameTextBox.MaxLength = 32767;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.PasswordChar = '\0';
            this.lastNameTextBox.PromptText = "Last";
            this.lastNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lastNameTextBox.SelectedText = "";
            this.lastNameTextBox.Size = new System.Drawing.Size(155, 29);
            this.lastNameTextBox.TabIndex = 3;
            this.lastNameTextBox.UseCustomBackColor = true;
            this.lastNameTextBox.UseSelectable = true;
            // 
            // cityTextBox
            // 
            this.cityTextBox.BackColor = System.Drawing.Color.White;
            this.cityTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.cityTextBox.Lines = new string[0];
            this.cityTextBox.Location = new System.Drawing.Point(171, 336);
            this.cityTextBox.MaxLength = 32767;
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.PasswordChar = '\0';
            this.cityTextBox.PromptText = "City";
            this.cityTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cityTextBox.SelectedText = "";
            this.cityTextBox.Size = new System.Drawing.Size(159, 29);
            this.cityTextBox.Style = MetroFramework.MetroColorStyle.White;
            this.cityTextBox.TabIndex = 18;
            this.cityTextBox.UseCustomBackColor = true;
            this.cityTextBox.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(14, 247);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(89, 19);
            this.metroLabel6.TabIndex = 16;
            this.metroLabel6.Text = "Your address";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // aptTextBox
            // 
            this.aptTextBox.BackColor = System.Drawing.Color.White;
            this.aptTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.aptTextBox.Lines = new string[0];
            this.aptTextBox.Location = new System.Drawing.Point(14, 335);
            this.aptTextBox.MaxLength = 32767;
            this.aptTextBox.Name = "aptTextBox";
            this.aptTextBox.PasswordChar = '\0';
            this.aptTextBox.PromptText = "Apt./Suite";
            this.aptTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.aptTextBox.SelectedText = "";
            this.aptTextBox.Size = new System.Drawing.Size(151, 29);
            this.aptTextBox.Style = MetroFramework.MetroColorStyle.White;
            this.aptTextBox.TabIndex = 17;
            this.aptTextBox.UseCustomBackColor = true;
            this.aptTextBox.UseSelectable = true;
            // 
            // addLabel
            // 
            this.addLabel.BackColor = System.Drawing.Color.White;
            this.addLabel.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.addLabel.Lines = new string[0];
            this.addLabel.Location = new System.Drawing.Point(13, 290);
            this.addLabel.MaxLength = 32767;
            this.addLabel.Name = "addLabel";
            this.addLabel.PasswordChar = '\0';
            this.addLabel.PromptText = "Street address";
            this.addLabel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.addLabel.SelectedText = "";
            this.addLabel.Size = new System.Drawing.Size(316, 29);
            this.addLabel.Style = MetroFramework.MetroColorStyle.White;
            this.addLabel.TabIndex = 15;
            this.addLabel.UseCustomBackColor = true;
            this.addLabel.UseSelectable = true;
            // 
            // searchPage
            // 
            this.searchPage.Controls.Add(this.SearchError);
            this.searchPage.Controls.Add(this.searchDataGridView);
            this.searchPage.Controls.Add(this.searchButton);
            this.searchPage.Controls.Add(this.searchTextBox);
            this.searchPage.HorizontalScrollbarBarColor = true;
            this.searchPage.HorizontalScrollbarHighlightOnWheel = false;
            this.searchPage.HorizontalScrollbarSize = 10;
            this.searchPage.Location = new System.Drawing.Point(4, 38);
            this.searchPage.Name = "searchPage";
            this.searchPage.Size = new System.Drawing.Size(976, 440);
            this.searchPage.TabIndex = 4;
            this.searchPage.Text = "Universal Search";
            this.searchPage.VerticalScrollbarBarColor = true;
            this.searchPage.VerticalScrollbarHighlightOnWheel = false;
            this.searchPage.VerticalScrollbarSize = 10;
            // 
            // SearchError
            // 
            this.SearchError.AutoSize = true;
            this.SearchError.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.SearchError.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.SearchError.Location = new System.Drawing.Point(270, 37);
            this.SearchError.Name = "SearchError";
            this.SearchError.Size = new System.Drawing.Size(315, 150);
            this.SearchError.Style = MetroFramework.MetroColorStyle.Green;
            this.SearchError.TabIndex = 19;
            this.SearchError.Text = "I ran out of entries :( SORRY DUDE.\r\n\r\nYou know, we can make another deal. \r\n\r\nI " +
    "sure will find something.\r\n";
            this.SearchError.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SearchError.Visible = false;
            // 
            // searchDataGridView
            // 
            this.searchDataGridView.AllowUserToAddRows = false;
            this.searchDataGridView.AllowUserToDeleteRows = false;
            this.searchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchDataGridView.Location = new System.Drawing.Point(68, 41);
            this.searchDataGridView.Name = "searchDataGridView";
            this.searchDataGridView.ReadOnly = true;
            this.searchDataGridView.Size = new System.Drawing.Size(730, 236);
            this.searchDataGridView.TabIndex = 18;
            this.searchDataGridView.Visible = false;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Transparent;
            this.searchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchButton.BackgroundImage")));
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchButton.Location = new System.Drawing.Point(759, 197);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(46, 29);
            this.searchButton.TabIndex = 17;
            this.searchButton.UseCustomBackColor = true;
            this.searchButton.UseSelectable = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.Color.White;
            this.searchTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.searchTextBox.Icon = ((System.Drawing.Image)(resources.GetObject("searchTextBox.Icon")));
            this.searchTextBox.IconRight = true;
            this.searchTextBox.Lines = new string[0];
            this.searchTextBox.Location = new System.Drawing.Point(75, 197);
            this.searchTextBox.MaxLength = 32767;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PasswordChar = '\0';
            this.searchTextBox.PromptText = "Search";
            this.searchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchTextBox.SelectedText = "";
            this.searchTextBox.Size = new System.Drawing.Size(713, 29);
            this.searchTextBox.Style = MetroFramework.MetroColorStyle.White;
            this.searchTextBox.TabIndex = 15;
            this.searchTextBox.UseCustomBackColor = true;
            this.searchTextBox.UseSelectable = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.AutoScroll = true;
            this.metroTabPage2.Controls.Add(this.resTotalDataGridView);
            this.metroTabPage2.HorizontalScrollbar = true;
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(976, 440);
            this.metroTabPage2.TabIndex = 3;
            this.metroTabPage2.Text = "Reservation Adv. view";
            this.metroTabPage2.VerticalScrollbar = true;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // resTotalDataGridView
            // 
            this.resTotalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resTotalDataGridView.Location = new System.Drawing.Point(0, 3);
            this.resTotalDataGridView.Name = "resTotalDataGridView";
            this.resTotalDataGridView.Size = new System.Drawing.Size(976, 434);
            this.resTotalDataGridView.TabIndex = 2;
            // 
            // roomPage
            // 
            this.roomPage.Controls.Add(this.metroLabel13);
            this.roomPage.Controls.Add(this.metroLabel11);
            this.roomPage.Controls.Add(this.reservedLabel);
            this.roomPage.Controls.Add(this.roomReservedListBox);
            this.roomPage.Controls.Add(this.roomOccupiedListBox);
            this.roomPage.Controls.Add(this.occupiedLabel);
            this.roomPage.HorizontalScrollbarBarColor = true;
            this.roomPage.HorizontalScrollbarHighlightOnWheel = false;
            this.roomPage.HorizontalScrollbarSize = 10;
            this.roomPage.Location = new System.Drawing.Point(4, 38);
            this.roomPage.Name = "roomPage";
            this.roomPage.Size = new System.Drawing.Size(976, 440);
            this.roomPage.TabIndex = 2;
            this.roomPage.Text = "Room availibility";
            this.roomPage.VerticalScrollbarBarColor = true;
            this.roomPage.VerticalScrollbarHighlightOnWheel = false;
            this.roomPage.VerticalScrollbarSize = 10;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel13.Location = new System.Drawing.Point(459, 28);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(479, 19);
            this.metroLabel13.TabIndex = 10;
            this.metroLabel13.Text = "Room#| Type  |  ID#   |       Name      |      Phone #      |     Entry       |  " +
    "  Depart";
            this.metroLabel13.UseCustomBackColor = true;
            this.metroLabel13.UseCustomForeColor = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(-3, 28);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(311, 19);
            this.metroLabel11.TabIndex = 9;
            this.metroLabel11.Text = "Room#| Type  |  ID#   |       Name      |      Phone #";
            this.metroLabel11.UseCustomBackColor = true;
            this.metroLabel11.UseCustomForeColor = true;
            // 
            // reservedLabel
            // 
            this.reservedLabel.AutoSize = true;
            this.reservedLabel.BackColor = System.Drawing.Color.Transparent;
            this.reservedLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.reservedLabel.Location = new System.Drawing.Point(459, 4);
            this.reservedLabel.Name = "reservedLabel";
            this.reservedLabel.Size = new System.Drawing.Size(64, 19);
            this.reservedLabel.TabIndex = 8;
            this.reservedLabel.Text = "Reserved";
            this.reservedLabel.UseCustomBackColor = true;
            this.reservedLabel.UseCustomForeColor = true;
            // 
            // roomReservedListBox
            // 
            this.roomReservedListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.roomReservedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roomReservedListBox.FormattingEnabled = true;
            this.roomReservedListBox.HorizontalScrollbar = true;
            this.roomReservedListBox.IntegralHeight = false;
            this.roomReservedListBox.Location = new System.Drawing.Point(460, 50);
            this.roomReservedListBox.Name = "roomReservedListBox";
            this.roomReservedListBox.Size = new System.Drawing.Size(516, 387);
            this.roomReservedListBox.TabIndex = 7;
            // 
            // roomOccupiedListBox
            // 
            this.roomOccupiedListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.roomOccupiedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roomOccupiedListBox.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomOccupiedListBox.FormattingEnabled = true;
            this.roomOccupiedListBox.HorizontalScrollbar = true;
            this.roomOccupiedListBox.IntegralHeight = false;
            this.roomOccupiedListBox.Location = new System.Drawing.Point(0, 50);
            this.roomOccupiedListBox.Name = "roomOccupiedListBox";
            this.roomOccupiedListBox.Size = new System.Drawing.Size(454, 387);
            this.roomOccupiedListBox.TabIndex = 6;
            // 
            // occupiedLabel
            // 
            this.occupiedLabel.AutoSize = true;
            this.occupiedLabel.BackColor = System.Drawing.Color.Transparent;
            this.occupiedLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.occupiedLabel.Location = new System.Drawing.Point(-3, 4);
            this.occupiedLabel.Name = "occupiedLabel";
            this.occupiedLabel.Size = new System.Drawing.Size(66, 19);
            this.occupiedLabel.TabIndex = 5;
            this.occupiedLabel.Text = "Occupied";
            this.occupiedLabel.UseCustomBackColor = true;
            this.occupiedLabel.UseCustomForeColor = true;
            // 
            // Frontend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackImage = ((System.Drawing.Image)(resources.GetObject("$this.BackImage")));
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(998, 545);
            this.Controls.Add(this.resPanel);
            this.Name = "Frontend";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Frontend";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frontend_FormClosing);
            this.Load += new System.EventHandler(this.MainTab_Load);
            this.resPanel.ResumeLayout(false);
            this.reservationPage.ResumeLayout(false);
            this.rightMPanel.ResumeLayout(false);
            this.middlePanel.ResumeLayout(false);
            this.middlePanel.PerformLayout();
            this.leftMPanel.ResumeLayout(false);
            this.leftMPanel.PerformLayout();
            this.searchPage.ResumeLayout(false);
            this.searchPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resTotalDataGridView)).EndInit();
            this.roomPage.ResumeLayout(false);
            this.roomPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

       

        private MetroFramework.Controls.MetroTabControl resPanel;
        private MetroFramework.Controls.MetroTabPage reservationPage;
        private MetroFramework.Controls.MetroPanel leftMPanel;
        private MetroFramework.Controls.MetroTextBox firstNameTextBox;
        private MetroFramework.Controls.MetroTextBox lastNameTextBox;
        private MetroFramework.Controls.MetroLabel birthdayLabel;
        private MetroFramework.Controls.MetroLabel nameLabel;
        private MetroFramework.Controls.MetroComboBox monthComboBox;
        private MetroFramework.Controls.MetroTextBox yearTextBox;
        private MetroFramework.Controls.MetroComboBox dayComboBox;
        private MetroFramework.Controls.MetroTextBox phoneNumberTextBox;
        private MetroFramework.Controls.MetroLabel genderLabel;
        private MetroFramework.Controls.MetroLabel phoneNumberLabel;
        private MetroFramework.Controls.MetroComboBox genderComboBox;
        private MetroFramework.Controls.MetroLabel emailLabel;
        private MetroFramework.Controls.MetroTextBox emailTextBox;
        private MetroFramework.Controls.MetroPanel middlePanel;
        private MetroFramework.Controls.MetroTextBox zipComboBox;
        private MetroFramework.Controls.MetroComboBox stateComboBox;
        private MetroFramework.Controls.MetroTextBox cityTextBox;
        private MetroFramework.Controls.MetroTextBox aptTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox addLabel;
        private MetroFramework.Controls.MetroComboBox roomTypeComboBox;
        private MetroFramework.Controls.MetroLabel choiceLabel;
        private MetroFramework.Controls.MetroComboBox roomNComboBox;
        private MetroFramework.Controls.MetroComboBox floorComboBox;
        private MetroFramework.Controls.MetroButton submitButton;
        private MetroFramework.Controls.MetroButton updateButton;
        private MetroFramework.Controls.MetroButton editButton;
        private MetroFramework.Controls.MetroButton finalizeButton;
        private MetroFramework.Controls.MetroButton newButton;
        private System.Windows.Forms.DateTimePicker entryDatePicker;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private System.Windows.Forms.DateTimePicker depDatePicker;
        private MetroFramework.Controls.MetroLabel entryLabel;
        private MetroFramework.Controls.MetroButton foodMenuButton;
        private MetroFramework.Controls.MetroButton deleteButton;
        private MetroFramework.Controls.MetroCheckBox checkinCheckBox;
        private MetroFramework.Controls.MetroComboBox resEditButton;
        private MetroFramework.Controls.MetroPanel rightMPanel;

        private MetroFramework.Controls.MetroTabPage roomPage;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
      
        private System.Windows.Forms.DataGridView resTotalDataGridView;
        private MetroFramework.Controls.MetroCheckBox foodSupplyCheckBox;
        private System.Windows.Forms.ListBox roomOccupiedListBox;
        private MetroFramework.Controls.MetroLabel occupiedLabel;
        private MetroFramework.Controls.MetroLabel reservedLabel;
        private System.Windows.Forms.ListBox roomReservedListBox;
        private MetroFramework.Controls.MetroTabPage searchPage;
        private MetroFramework.Controls.MetroTextBox searchTextBox;
        private MetroFramework.Controls.MetroComboBox qtGuestComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.DataGridView searchDataGridView;
        private MetroFramework.Controls.MetroButton searchButton;
        private MetroFramework.Controls.MetroLabel SearchError;
        private MetroFramework.Controls.MetroCheckBox smsCheckBox;


     
    }
}