namespace RezerwacjaSal
{
    partial class ReservePatientRoom
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelReservePatientRoom = new System.Windows.Forms.Panel();
            this.groupBoxRequirements = new System.Windows.Forms.GroupBox();
            this.labelInfectious = new System.Windows.Forms.Label();
            this.comboBoxInfectious = new System.Windows.Forms.ComboBox();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.labelCheckInDate = new System.Windows.Forms.Label();
            this.dataGridViewRequiredEquipment = new System.Windows.Forms.DataGridView();
            this.RequiredEquipment = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dateTimePickerCheckInDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.labelBuilding = new System.Windows.Forms.Label();
            this.labelCheckOutDate = new System.Windows.Forms.Label();
            this.comboBoxBulding = new System.Windows.Forms.ComboBox();
            this.labelReservePatientRoom = new System.Windows.Forms.Label();
            this.groupBoxReservationData = new System.Windows.Forms.GroupBox();
            this.textBoxRoom = new System.Windows.Forms.TextBox();
            this.labelRoom = new System.Windows.Forms.Label();
            this.textBoxReservationNr = new System.Windows.Forms.TextBox();
            this.labelReservationNumber = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.labelSicknessName = new System.Windows.Forms.Label();
            this.labelFirstNme = new System.Windows.Forms.Label();
            this.comboBoxSicknessNr = new System.Windows.Forms.ComboBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelSicknessSymbol = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelPESEL = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelSecondName = new System.Windows.Forms.Label();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.dataGridViewPatientRooms = new System.Windows.Forms.DataGridView();
            this.panelReservationData = new System.Windows.Forms.Panel();
            this.panelReservePatientRoom.SuspendLayout();
            this.groupBoxRequirements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequiredEquipment)).BeginInit();
            this.groupBoxReservationData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatientRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // panelReservePatientRoom
            // 
            this.panelReservePatientRoom.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelReservePatientRoom.Controls.Add(this.groupBoxRequirements);
            this.panelReservePatientRoom.Controls.Add(this.groupBoxReservationData);
            this.panelReservePatientRoom.Controls.Add(this.labelReservePatientRoom);
            this.panelReservePatientRoom.Location = new System.Drawing.Point(334, 12);
            this.panelReservePatientRoom.Name = "panelReservePatientRoom";
            this.panelReservePatientRoom.Size = new System.Drawing.Size(1118, 286);
            this.panelReservePatientRoom.TabIndex = 4;
            // 
            // groupBoxRequirements
            // 
            this.groupBoxRequirements.Controls.Add(this.labelInfectious);
            this.groupBoxRequirements.Controls.Add(this.comboBoxInfectious);
            this.groupBoxRequirements.Controls.Add(this.buttonSelect);
            this.groupBoxRequirements.Controls.Add(this.labelCheckInDate);
            this.groupBoxRequirements.Controls.Add(this.dataGridViewRequiredEquipment);
            this.groupBoxRequirements.Controls.Add(this.dateTimePickerCheckInDate);
            this.groupBoxRequirements.Controls.Add(this.dateTimePickerCheckOutDate);
            this.groupBoxRequirements.Controls.Add(this.labelBuilding);
            this.groupBoxRequirements.Controls.Add(this.labelCheckOutDate);
            this.groupBoxRequirements.Controls.Add(this.comboBoxBulding);
            this.groupBoxRequirements.Location = new System.Drawing.Point(7, 33);
            this.groupBoxRequirements.Name = "groupBoxRequirements";
            this.groupBoxRequirements.Size = new System.Drawing.Size(666, 230);
            this.groupBoxRequirements.TabIndex = 24;
            this.groupBoxRequirements.TabStop = false;
            this.groupBoxRequirements.Text = "Wymagania";
            this.groupBoxRequirements.Enter += new System.EventHandler(this.groupBoxRequirements_Enter);
            // 
            // labelInfectious
            // 
            this.labelInfectious.AutoSize = true;
            this.labelInfectious.Location = new System.Drawing.Point(166, 73);
            this.labelInfectious.Name = "labelInfectious";
            this.labelInfectious.Size = new System.Drawing.Size(49, 13);
            this.labelInfectious.TabIndex = 44;
            this.labelInfectious.Text = "Zakaźna";
            // 
            // comboBoxInfectious
            // 
            this.comboBoxInfectious.FormattingEnabled = true;
            this.comboBoxInfectious.Items.AddRange(new object[] {
            "Tak",
            "Nie",
            "Wszystkie"});
            this.comboBoxInfectious.Location = new System.Drawing.Point(169, 89);
            this.comboBoxInfectious.Name = "comboBoxInfectious";
            this.comboBoxInfectious.Size = new System.Drawing.Size(135, 21);
            this.comboBoxInfectious.TabIndex = 43;
            this.comboBoxInfectious.Text = "Wszystkie";
            this.comboBoxInfectious.SelectedIndexChanged += new System.EventHandler(this.comboBoxInfectious_SelectedIndexChanged);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(14, 174);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(299, 34);
            this.buttonSelect.TabIndex = 42;
            this.buttonSelect.Text = "Wybierz";
            this.buttonSelect.UseVisualStyleBackColor = true;
            // 
            // labelCheckInDate
            // 
            this.labelCheckInDate.AutoSize = true;
            this.labelCheckInDate.Location = new System.Drawing.Point(10, 29);
            this.labelCheckInDate.Name = "labelCheckInDate";
            this.labelCheckInDate.Size = new System.Drawing.Size(78, 13);
            this.labelCheckInDate.TabIndex = 12;
            this.labelCheckInDate.Text = "Data przyjęcia*";
            // 
            // dataGridViewRequiredEquipment
            // 
            this.dataGridViewRequiredEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRequiredEquipment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RequiredEquipment,
            this.ColumnDelete});
            this.dataGridViewRequiredEquipment.Location = new System.Drawing.Point(332, 29);
            this.dataGridViewRequiredEquipment.Name = "dataGridViewRequiredEquipment";
            this.dataGridViewRequiredEquipment.Size = new System.Drawing.Size(296, 179);
            this.dataGridViewRequiredEquipment.TabIndex = 18;
            this.dataGridViewRequiredEquipment.VirtualMode = true;
            // 
            // RequiredEquipment
            // 
            this.RequiredEquipment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.NullValue = "wybierz sprzęt";
            this.RequiredEquipment.DefaultCellStyle = dataGridViewCellStyle1;
            this.RequiredEquipment.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.RequiredEquipment.FillWeight = 139.0863F;
            this.RequiredEquipment.HeaderText = "Wymagany sprzęt";
            this.RequiredEquipment.Items.AddRange(new object[] {
            "Respirator",
            "Basen",
            "Telewizor"});
            this.RequiredEquipment.Name = "RequiredEquipment";
            this.RequiredEquipment.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RequiredEquipment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "Usuń";
            this.ColumnDelete.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnDelete.FillWeight = 60.9137F;
            this.ColumnDelete.HeaderText = "";
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnDelete.Text = "Usun";
            this.ColumnDelete.UseColumnTextForButtonValue = true;
            // 
            // dateTimePickerCheckInDate
            // 
            this.dateTimePickerCheckInDate.Location = new System.Drawing.Point(13, 45);
            this.dateTimePickerCheckInDate.Name = "dateTimePickerCheckInDate";
            this.dateTimePickerCheckInDate.Size = new System.Drawing.Size(136, 20);
            this.dateTimePickerCheckInDate.TabIndex = 13;
            // 
            // dateTimePickerCheckOutDate
            // 
            this.dateTimePickerCheckOutDate.Location = new System.Drawing.Point(168, 45);
            this.dateTimePickerCheckOutDate.Name = "dateTimePickerCheckOutDate";
            this.dateTimePickerCheckOutDate.Size = new System.Drawing.Size(136, 20);
            this.dateTimePickerCheckOutDate.TabIndex = 14;
            // 
            // labelBuilding
            // 
            this.labelBuilding.AutoSize = true;
            this.labelBuilding.Location = new System.Drawing.Point(11, 73);
            this.labelBuilding.Name = "labelBuilding";
            this.labelBuilding.Size = new System.Drawing.Size(49, 13);
            this.labelBuilding.TabIndex = 21;
            this.labelBuilding.Text = "Budynek";
            // 
            // labelCheckOutDate
            // 
            this.labelCheckOutDate.AutoSize = true;
            this.labelCheckOutDate.Location = new System.Drawing.Point(165, 29);
            this.labelCheckOutDate.Name = "labelCheckOutDate";
            this.labelCheckOutDate.Size = new System.Drawing.Size(134, 13);
            this.labelCheckOutDate.TabIndex = 15;
            this.labelCheckOutDate.Text = "Przewidywana data wypisu";
            // 
            // comboBoxBulding
            // 
            this.comboBoxBulding.FormattingEnabled = true;
            this.comboBoxBulding.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "Wszystkie"});
            this.comboBoxBulding.Location = new System.Drawing.Point(14, 89);
            this.comboBoxBulding.Name = "comboBoxBulding";
            this.comboBoxBulding.Size = new System.Drawing.Size(135, 21);
            this.comboBoxBulding.TabIndex = 20;
            this.comboBoxBulding.Text = "Wszystkie";
            this.comboBoxBulding.SelectedIndexChanged += new System.EventHandler(this.comboBoxBulding_SelectedIndexChanged);
            // 
            // labelReservePatientRoom
            // 
            this.labelReservePatientRoom.AutoSize = true;
            this.labelReservePatientRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelReservePatientRoom.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelReservePatientRoom.Location = new System.Drawing.Point(3, 10);
            this.labelReservePatientRoom.Name = "labelReservePatientRoom";
            this.labelReservePatientRoom.Size = new System.Drawing.Size(188, 20);
            this.labelReservePatientRoom.TabIndex = 1;
            this.labelReservePatientRoom.Text = "Rezerwuj salę chorych";
            // 
            // groupBoxReservationData
            // 
            this.groupBoxReservationData.Controls.Add(this.button_back);
            this.groupBoxReservationData.Controls.Add(this.buttonSave);
            this.groupBoxReservationData.Controls.Add(this.textBoxRoom);
            this.groupBoxReservationData.Controls.Add(this.labelRoom);
            this.groupBoxReservationData.Controls.Add(this.textBoxReservationNr);
            this.groupBoxReservationData.Controls.Add(this.labelReservationNumber);
            this.groupBoxReservationData.Controls.Add(this.labelFrom);
            this.groupBoxReservationData.Controls.Add(this.textBoxFrom);
            this.groupBoxReservationData.Controls.Add(this.labelTo);
            this.groupBoxReservationData.Controls.Add(this.textBoxTo);
            this.groupBoxReservationData.Controls.Add(this.labelSicknessName);
            this.groupBoxReservationData.Controls.Add(this.labelFirstNme);
            this.groupBoxReservationData.Controls.Add(this.comboBoxSicknessNr);
            this.groupBoxReservationData.Controls.Add(this.textBoxFirstName);
            this.groupBoxReservationData.Controls.Add(this.labelSicknessSymbol);
            this.groupBoxReservationData.Controls.Add(this.labelSurname);
            this.groupBoxReservationData.Controls.Add(this.labelPESEL);
            this.groupBoxReservationData.Controls.Add(this.textBoxSurname);
            this.groupBoxReservationData.Controls.Add(this.textBoxId);
            this.groupBoxReservationData.Controls.Add(this.labelSecondName);
            this.groupBoxReservationData.Controls.Add(this.textBoxSecondName);
            this.groupBoxReservationData.Location = new System.Drawing.Point(700, 33);
            this.groupBoxReservationData.Name = "groupBoxReservationData";
            this.groupBoxReservationData.Size = new System.Drawing.Size(397, 230);
            this.groupBoxReservationData.TabIndex = 25;
            this.groupBoxReservationData.TabStop = false;
            this.groupBoxReservationData.Text = "Dane rezerwacji";
            // 
            // textBoxRoom
            // 
            this.textBoxRoom.Location = new System.Drawing.Point(108, 333);
            this.textBoxRoom.Name = "textBoxRoom";
            this.textBoxRoom.ReadOnly = true;
            this.textBoxRoom.Size = new System.Drawing.Size(123, 20);
            this.textBoxRoom.TabIndex = 39;
            this.textBoxRoom.Text = "751/C";
            // 
            // labelRoom
            // 
            this.labelRoom.AutoSize = true;
            this.labelRoom.Location = new System.Drawing.Point(16, 337);
            this.labelRoom.Name = "labelRoom";
            this.labelRoom.Size = new System.Drawing.Size(28, 13);
            this.labelRoom.TabIndex = 38;
            this.labelRoom.Text = "Sala";
            // 
            // textBoxReservationNr
            // 
            this.textBoxReservationNr.Location = new System.Drawing.Point(110, 34);
            this.textBoxReservationNr.Name = "textBoxReservationNr";
            this.textBoxReservationNr.ReadOnly = true;
            this.textBoxReservationNr.Size = new System.Drawing.Size(123, 20);
            this.textBoxReservationNr.TabIndex = 37;
            // 
            // labelReservationNumber
            // 
            this.labelReservationNumber.AutoSize = true;
            this.labelReservationNumber.Location = new System.Drawing.Point(16, 34);
            this.labelReservationNumber.Name = "labelReservationNumber";
            this.labelReservationNumber.Size = new System.Drawing.Size(88, 13);
            this.labelReservationNumber.TabIndex = 36;
            this.labelReservationNumber.Text = "Numer rezerwacji";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(16, 284);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(21, 13);
            this.labelFrom.TabIndex = 33;
            this.labelFrom.Text = "Od";
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(108, 281);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.ReadOnly = true;
            this.textBoxFrom.Size = new System.Drawing.Size(123, 20);
            this.textBoxFrom.TabIndex = 32;
            this.textBoxFrom.Text = "09/12/2020";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(16, 307);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(21, 13);
            this.labelTo.TabIndex = 34;
            this.labelTo.Text = "Do";
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(108, 307);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.ReadOnly = true;
            this.textBoxTo.Size = new System.Drawing.Size(123, 20);
            this.textBoxTo.TabIndex = 35;
            this.textBoxTo.Text = "09/12/2020";
            // 
            // labelSicknessName
            // 
            this.labelSicknessName.AutoSize = true;
            this.labelSicknessName.Location = new System.Drawing.Point(123, 195);
            this.labelSicknessName.Name = "labelSicknessName";
            this.labelSicknessName.Size = new System.Drawing.Size(85, 13);
            this.labelSicknessName.TabIndex = 31;
            this.labelSicknessName.Text = "Brak nogi - lewej";
            // 
            // labelFirstNme
            // 
            this.labelFirstNme.AutoSize = true;
            this.labelFirstNme.Location = new System.Drawing.Point(16, 67);
            this.labelFirstNme.Name = "labelFirstNme";
            this.labelFirstNme.Size = new System.Drawing.Size(70, 13);
            this.labelFirstNme.TabIndex = 22;
            this.labelFirstNme.Text = "Pierwsze imię";
            // 
            // comboBoxSicknessNr
            // 
            this.comboBoxSicknessNr.FormattingEnabled = true;
            this.comboBoxSicknessNr.Items.AddRange(new object[] {
            "BN-01L",
            "BN-02L",
            "BN-01P"});
            this.comboBoxSicknessNr.Location = new System.Drawing.Point(110, 171);
            this.comboBoxSicknessNr.Name = "comboBoxSicknessNr";
            this.comboBoxSicknessNr.Size = new System.Drawing.Size(123, 21);
            this.comboBoxSicknessNr.TabIndex = 30;
            this.comboBoxSicknessNr.Text = "BN-01L";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxFirstName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxFirstName.Location = new System.Drawing.Point(110, 60);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(123, 20);
            this.textBoxFirstName.TabIndex = 21;
            this.textBoxFirstName.TextChanged += new System.EventHandler(this.textBoxFirstName_TextChanged);
            // 
            // labelSicknessSymbol
            // 
            this.labelSicknessSymbol.AutoSize = true;
            this.labelSicknessSymbol.Location = new System.Drawing.Point(16, 174);
            this.labelSicknessSymbol.Name = "labelSicknessSymbol";
            this.labelSicknessSymbol.Size = new System.Drawing.Size(82, 13);
            this.labelSicknessSymbol.TabIndex = 29;
            this.labelSicknessSymbol.Text = "Symbol choroby";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(16, 120);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(53, 13);
            this.labelSurname.TabIndex = 23;
            this.labelSurname.Text = "Nazwisko";
            // 
            // labelPESEL
            // 
            this.labelPESEL.AutoSize = true;
            this.labelPESEL.Location = new System.Drawing.Point(16, 148);
            this.labelPESEL.Name = "labelPESEL";
            this.labelPESEL.Size = new System.Drawing.Size(82, 13);
            this.labelPESEL.TabIndex = 28;
            this.labelPESEL.Text = "Numer pacjenta";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(110, 115);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(123, 20);
            this.textBoxSurname.TabIndex = 24;
            this.textBoxSurname.Text = "Kowalski";
            // 
            // textBoxId
            // 
            this.textBoxId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxId.Location = new System.Drawing.Point(110, 145);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(123, 20);
            this.textBoxId.TabIndex = 27;
            this.textBoxId.Text = "76021309332";
            this.textBoxId.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
            // 
            // labelSecondName
            // 
            this.labelSecondName.AutoSize = true;
            this.labelSecondName.Location = new System.Drawing.Point(16, 93);
            this.labelSecondName.Name = "labelSecondName";
            this.labelSecondName.Size = new System.Drawing.Size(59, 13);
            this.labelSecondName.TabIndex = 25;
            this.labelSecondName.Text = "Drugie imię";
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.Location = new System.Drawing.Point(110, 89);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(123, 20);
            this.textBoxSecondName.TabIndex = 26;
            this.textBoxSecondName.Text = "Michał";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(248, 29);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(134, 47);
            this.buttonSave.TabIndex = 40;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(250, 93);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(141, 44);
            this.button_back.TabIndex = 41;
            this.button_back.Text = "Wstecz";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // dataGridViewPatientRooms
            // 
            this.dataGridViewPatientRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatientRooms.Location = new System.Drawing.Point(334, 304);
            this.dataGridViewPatientRooms.Name = "dataGridViewPatientRooms";
            this.dataGridViewPatientRooms.Size = new System.Drawing.Size(688, 387);
            this.dataGridViewPatientRooms.TabIndex = 3;
            this.dataGridViewPatientRooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPatientRooms_CellContentClick);
            // 
            // panelReservationData
            // 
            this.panelReservationData.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelReservationData.Location = new System.Drawing.Point(12, 28);
            this.panelReservationData.Name = "panelReservationData";
            this.panelReservationData.Size = new System.Drawing.Size(281, 663);
            this.panelReservationData.TabIndex = 25;
            // 
            // ReservePatientRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 736);
            this.Controls.Add(this.panelReservationData);
            this.Controls.Add(this.panelReservePatientRoom);
            this.Controls.Add(this.dataGridViewPatientRooms);
            this.Name = "ReservePatientRoom";
            this.Text = "Nowa rezerwacja sali chorych";
            this.Load += new System.EventHandler(this.ReservePatientRoom_Load);
            this.panelReservePatientRoom.ResumeLayout(false);
            this.panelReservePatientRoom.PerformLayout();
            this.groupBoxRequirements.ResumeLayout(false);
            this.groupBoxRequirements.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequiredEquipment)).EndInit();
            this.groupBoxReservationData.ResumeLayout(false);
            this.groupBoxReservationData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatientRooms)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelReservePatientRoom;
        private System.Windows.Forms.Label labelCheckOutDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckOutDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckInDate;
        private System.Windows.Forms.Label labelCheckInDate;
        private System.Windows.Forms.Label labelReservePatientRoom;
        private System.Windows.Forms.DataGridView dataGridViewPatientRooms;
        private System.Windows.Forms.DataGridView dataGridViewRequiredEquipment;
        private System.Windows.Forms.Label labelBuilding;
        private System.Windows.Forms.ComboBox comboBoxBulding;
        private System.Windows.Forms.GroupBox groupBoxReservationData;
        private System.Windows.Forms.TextBox textBoxRoom;
        private System.Windows.Forms.Label labelRoom;
        private System.Windows.Forms.TextBox textBoxReservationNr;
        private System.Windows.Forms.Label labelReservationNumber;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.Label labelSicknessName;
        private System.Windows.Forms.Label labelFirstNme;
        private System.Windows.Forms.ComboBox comboBoxSicknessNr;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelSicknessSymbol;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelPESEL;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelSecondName;
        private System.Windows.Forms.TextBox textBoxSecondName;
        private System.Windows.Forms.GroupBox groupBoxRequirements;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridViewComboBoxColumn RequiredEquipment;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDelete;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Panel panelReservationData;
        private System.Windows.Forms.Label labelInfectious;
        private System.Windows.Forms.ComboBox comboBoxInfectious;
    }
}