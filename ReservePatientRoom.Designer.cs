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
            this.panelReservePatientRoom = new System.Windows.Forms.Panel();
            this.groupBoxRequirements = new System.Windows.Forms.GroupBox();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.textBoxDepartment = new System.Windows.Forms.TextBox();
            this.labelEquipment = new System.Windows.Forms.Label();
            this.checkedListBoxEquipment = new System.Windows.Forms.CheckedListBox();
            this.labelRoom_number = new System.Windows.Forms.Label();
            this.textBoxRoomNr = new System.Windows.Forms.TextBox();
            this.labelCheckInDate = new System.Windows.Forms.Label();
            this.dateTimePickerCheckInDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.labelBuilding = new System.Windows.Forms.Label();
            this.labelCheckOutDate = new System.Windows.Forms.Label();
            this.comboBoxBulding = new System.Windows.Forms.ComboBox();
            this.groupBoxReservationData = new System.Windows.Forms.GroupBox();
            this.labelSickness = new System.Windows.Forms.Label();
            this.textBoxIllness = new System.Windows.Forms.TextBox();
            this.labelFilters = new System.Windows.Forms.Label();
            this.labelRoomNumberRes = new System.Windows.Forms.Label();
            this.textBoxRoomNrRes = new System.Windows.Forms.TextBox();
            this.button_back = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxRoom = new System.Windows.Forms.TextBox();
            this.labelRoom = new System.Windows.Forms.Label();
            this.textBoxReservationNr = new System.Windows.Forms.TextBox();
            this.labelReservationNumber = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.labelFirstNme = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelPESEL = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelReservePatientRoom = new System.Windows.Forms.Label();
            this.dataGridViewPatientRooms = new System.Windows.Forms.DataGridView();
            this.dataGridViewPatients = new System.Windows.Forms.DataGridView();
            this.panelReservePatientRoom.SuspendLayout();
            this.groupBoxRequirements.SuspendLayout();
            this.groupBoxReservationData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatientRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // panelReservePatientRoom
            // 
            this.panelReservePatientRoom.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelReservePatientRoom.Controls.Add(this.groupBoxRequirements);
            this.panelReservePatientRoom.Controls.Add(this.groupBoxReservationData);
            this.panelReservePatientRoom.Controls.Add(this.labelReservePatientRoom);
            this.panelReservePatientRoom.Location = new System.Drawing.Point(12, 12);
            this.panelReservePatientRoom.Name = "panelReservePatientRoom";
            this.panelReservePatientRoom.Size = new System.Drawing.Size(1118, 286);
            this.panelReservePatientRoom.TabIndex = 4;
            // 
            // groupBoxRequirements
            // 
            this.groupBoxRequirements.Controls.Add(this.labelDepartment);
            this.groupBoxRequirements.Controls.Add(this.textBoxDepartment);
            this.groupBoxRequirements.Controls.Add(this.labelEquipment);
            this.groupBoxRequirements.Controls.Add(this.checkedListBoxEquipment);
            this.groupBoxRequirements.Controls.Add(this.labelRoom_number);
            this.groupBoxRequirements.Controls.Add(this.textBoxRoomNr);
            this.groupBoxRequirements.Controls.Add(this.labelCheckInDate);
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
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Location = new System.Drawing.Point(165, 73);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(44, 13);
            this.labelDepartment.TabIndex = 53;
            this.labelDepartment.Text = "Oddział";
            // 
            // textBoxDepartment
            // 
            this.textBoxDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxDepartment.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxDepartment.Location = new System.Drawing.Point(168, 89);
            this.textBoxDepartment.Name = "textBoxDepartment";
            this.textBoxDepartment.Size = new System.Drawing.Size(136, 20);
            this.textBoxDepartment.TabIndex = 52;
            this.textBoxDepartment.TextChanged += new System.EventHandler(this.textBoxDepartment_TextChanged);
            // 
            // labelEquipment
            // 
            this.labelEquipment.AutoSize = true;
            this.labelEquipment.Location = new System.Drawing.Point(338, 29);
            this.labelEquipment.Name = "labelEquipment";
            this.labelEquipment.Size = new System.Drawing.Size(91, 13);
            this.labelEquipment.TabIndex = 51;
            this.labelEquipment.Text = "Wymagany sprzęt";
            // 
            // checkedListBoxEquipment
            // 
            this.checkedListBoxEquipment.FormattingEnabled = true;
            this.checkedListBoxEquipment.Location = new System.Drawing.Point(332, 45);
            this.checkedListBoxEquipment.Name = "checkedListBoxEquipment";
            this.checkedListBoxEquipment.Size = new System.Drawing.Size(306, 169);
            this.checkedListBoxEquipment.TabIndex = 50;
            // 
            // labelRoom_number
            // 
            this.labelRoom_number.AutoSize = true;
            this.labelRoom_number.Location = new System.Drawing.Point(11, 124);
            this.labelRoom_number.Name = "labelRoom_number";
            this.labelRoom_number.Size = new System.Drawing.Size(56, 13);
            this.labelRoom_number.TabIndex = 49;
            this.labelRoom_number.Text = "Numer sali";
            // 
            // textBoxRoomNr
            // 
            this.textBoxRoomNr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxRoomNr.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxRoomNr.Location = new System.Drawing.Point(13, 140);
            this.textBoxRoomNr.Name = "textBoxRoomNr";
            this.textBoxRoomNr.Size = new System.Drawing.Size(123, 20);
            this.textBoxRoomNr.TabIndex = 48;
            this.textBoxRoomNr.TextChanged += new System.EventHandler(this.textBoxRoomNr_TextChanged);
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
            // dateTimePickerCheckInDate
            // 
            this.dateTimePickerCheckInDate.Location = new System.Drawing.Point(13, 45);
            this.dateTimePickerCheckInDate.Name = "dateTimePickerCheckInDate";
            this.dateTimePickerCheckInDate.Size = new System.Drawing.Size(136, 20);
            this.dateTimePickerCheckInDate.TabIndex = 13;
            this.dateTimePickerCheckInDate.Value = new System.DateTime(2021, 1, 28, 21, 28, 0, 0);
            this.dateTimePickerCheckInDate.ValueChanged += new System.EventHandler(this.dateTimePickerCheckInDate_ValueChanged);
            // 
            // dateTimePickerCheckOutDate
            // 
            this.dateTimePickerCheckOutDate.Location = new System.Drawing.Point(168, 45);
            this.dateTimePickerCheckOutDate.Name = "dateTimePickerCheckOutDate";
            this.dateTimePickerCheckOutDate.Size = new System.Drawing.Size(136, 20);
            this.dateTimePickerCheckOutDate.TabIndex = 14;
            this.dateTimePickerCheckOutDate.ValueChanged += new System.EventHandler(this.dateTimePickerCheckOutDate_ValueChanged);
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
            // groupBoxReservationData
            // 
            this.groupBoxReservationData.Controls.Add(this.labelSickness);
            this.groupBoxReservationData.Controls.Add(this.textBoxIllness);
            this.groupBoxReservationData.Controls.Add(this.labelFilters);
            this.groupBoxReservationData.Controls.Add(this.labelRoomNumberRes);
            this.groupBoxReservationData.Controls.Add(this.textBoxRoomNrRes);
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
            this.groupBoxReservationData.Controls.Add(this.labelFirstNme);
            this.groupBoxReservationData.Controls.Add(this.textBoxFirstName);
            this.groupBoxReservationData.Controls.Add(this.labelSurname);
            this.groupBoxReservationData.Controls.Add(this.labelPESEL);
            this.groupBoxReservationData.Controls.Add(this.textBoxSurname);
            this.groupBoxReservationData.Controls.Add(this.textBoxId);
            this.groupBoxReservationData.Location = new System.Drawing.Point(700, 33);
            this.groupBoxReservationData.Name = "groupBoxReservationData";
            this.groupBoxReservationData.Size = new System.Drawing.Size(397, 230);
            this.groupBoxReservationData.TabIndex = 25;
            this.groupBoxReservationData.TabStop = false;
            this.groupBoxReservationData.Text = "Dane rezerwacji";
            // 
            // labelSickness
            // 
            this.labelSickness.AutoSize = true;
            this.labelSickness.Location = new System.Drawing.Point(16, 191);
            this.labelSickness.Name = "labelSickness";
            this.labelSickness.Size = new System.Drawing.Size(47, 13);
            this.labelSickness.TabIndex = 47;
            this.labelSickness.Text = "Choroba";
            // 
            // textBoxIllness
            // 
            this.textBoxIllness.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxIllness.Location = new System.Drawing.Point(108, 188);
            this.textBoxIllness.Name = "textBoxIllness";
            this.textBoxIllness.Size = new System.Drawing.Size(123, 20);
            this.textBoxIllness.TabIndex = 46;
            this.textBoxIllness.TextChanged += new System.EventHandler(this.textBoxIllness_TextChanged);
            // 
            // labelFilters
            // 
            this.labelFilters.AutoSize = true;
            this.labelFilters.Location = new System.Drawing.Point(16, 89);
            this.labelFilters.Name = "labelFilters";
            this.labelFilters.Size = new System.Drawing.Size(28, 13);
            this.labelFilters.TabIndex = 45;
            this.labelFilters.Text = "Filtry";
            // 
            // labelRoomNumberRes
            // 
            this.labelRoomNumberRes.AutoSize = true;
            this.labelRoomNumberRes.Location = new System.Drawing.Point(16, 46);
            this.labelRoomNumberRes.Name = "labelRoomNumberRes";
            this.labelRoomNumberRes.Size = new System.Drawing.Size(56, 13);
            this.labelRoomNumberRes.TabIndex = 43;
            this.labelRoomNumberRes.Text = "Numer sali";
            // 
            // textBoxRoomNrRes
            // 
            this.textBoxRoomNrRes.Location = new System.Drawing.Point(108, 43);
            this.textBoxRoomNrRes.Name = "textBoxRoomNrRes";
            this.textBoxRoomNrRes.ReadOnly = true;
            this.textBoxRoomNrRes.Size = new System.Drawing.Size(123, 20);
            this.textBoxRoomNrRes.TabIndex = 42;
            this.textBoxRoomNrRes.TextChanged += new System.EventHandler(this.textBoxRoomNrRes_TextChanged);
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(248, 65);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(134, 37);
            this.button_back.TabIndex = 41;
            this.button_back.Text = "Wstecz";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(248, 19);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(134, 40);
            this.buttonSave.TabIndex = 40;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
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
            this.textBoxReservationNr.Location = new System.Drawing.Point(108, 19);
            this.textBoxReservationNr.Name = "textBoxReservationNr";
            this.textBoxReservationNr.ReadOnly = true;
            this.textBoxReservationNr.Size = new System.Drawing.Size(123, 20);
            this.textBoxReservationNr.TabIndex = 37;
            this.textBoxReservationNr.TextChanged += new System.EventHandler(this.textBoxReservationNr_TextChanged);
            // 
            // labelReservationNumber
            // 
            this.labelReservationNumber.AutoSize = true;
            this.labelReservationNumber.Location = new System.Drawing.Point(16, 26);
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
            // labelFirstNme
            // 
            this.labelFirstNme.AutoSize = true;
            this.labelFirstNme.Location = new System.Drawing.Point(16, 117);
            this.labelFirstNme.Name = "labelFirstNme";
            this.labelFirstNme.Size = new System.Drawing.Size(70, 13);
            this.labelFirstNme.TabIndex = 22;
            this.labelFirstNme.Text = "Pierwsze imię";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxFirstName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxFirstName.Location = new System.Drawing.Point(108, 110);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(123, 20);
            this.textBoxFirstName.TabIndex = 21;
            this.textBoxFirstName.TextChanged += new System.EventHandler(this.textBoxFirstName_TextChanged);
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(16, 143);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(53, 13);
            this.labelSurname.TabIndex = 23;
            this.labelSurname.Text = "Nazwisko";
            // 
            // labelPESEL
            // 
            this.labelPESEL.AutoSize = true;
            this.labelPESEL.Location = new System.Drawing.Point(16, 169);
            this.labelPESEL.Name = "labelPESEL";
            this.labelPESEL.Size = new System.Drawing.Size(82, 13);
            this.labelPESEL.TabIndex = 28;
            this.labelPESEL.Text = "Numer pacjenta";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(108, 136);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(123, 20);
            this.textBoxSurname.TabIndex = 24;
            this.textBoxSurname.TextChanged += new System.EventHandler(this.textBoxSurname_TextChanged);
            // 
            // textBoxId
            // 
            this.textBoxId.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxId.Location = new System.Drawing.Point(108, 162);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(123, 20);
            this.textBoxId.TabIndex = 27;
            this.textBoxId.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
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
            // dataGridViewPatientRooms
            // 
            this.dataGridViewPatientRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatientRooms.Location = new System.Drawing.Point(12, 304);
            this.dataGridViewPatientRooms.MultiSelect = false;
            this.dataGridViewPatientRooms.Name = "dataGridViewPatientRooms";
            this.dataGridViewPatientRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPatientRooms.Size = new System.Drawing.Size(688, 387);
            this.dataGridViewPatientRooms.TabIndex = 3;
            this.dataGridViewPatientRooms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPatientRooms_CellClick);
            this.dataGridViewPatientRooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPatientRooms_CellContentClick);
            this.dataGridViewPatientRooms.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPatientRooms_RowEnter);
            this.dataGridViewPatientRooms.SelectionChanged += new System.EventHandler(this.dataGridViewPatientRooms_SelectionChanged);
            // 
            // dataGridViewPatients
            // 
            this.dataGridViewPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatients.Location = new System.Drawing.Point(712, 304);
            this.dataGridViewPatients.MultiSelect = false;
            this.dataGridViewPatients.Name = "dataGridViewPatients";
            this.dataGridViewPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPatients.Size = new System.Drawing.Size(418, 387);
            this.dataGridViewPatients.TabIndex = 26;
            this.dataGridViewPatients.SelectionChanged += new System.EventHandler(this.dataGridViewPatients_SelectionChanged);
            // 
            // ReservePatientRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 736);
            this.Controls.Add(this.dataGridViewPatients);
            this.Controls.Add(this.panelReservePatientRoom);
            this.Controls.Add(this.dataGridViewPatientRooms);
            this.Name = "ReservePatientRoom";
            this.Text = "Nowa rezerwacja sali chorych";
            this.Load += new System.EventHandler(this.ReservePatientRoom_Load);
            this.panelReservePatientRoom.ResumeLayout(false);
            this.panelReservePatientRoom.PerformLayout();
            this.groupBoxRequirements.ResumeLayout(false);
            this.groupBoxRequirements.PerformLayout();
            this.groupBoxReservationData.ResumeLayout(false);
            this.groupBoxReservationData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatientRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelReservePatientRoom;
        private System.Windows.Forms.Label labelCheckOutDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckOutDate;
        private System.Windows.Forms.Label labelCheckInDate;
        private System.Windows.Forms.Label labelReservePatientRoom;
        private System.Windows.Forms.DataGridView dataGridViewPatientRooms;
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
        private System.Windows.Forms.Label labelFirstNme;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelPESEL;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.GroupBox groupBoxRequirements;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.DataGridView dataGridViewPatients;
        private System.Windows.Forms.TextBox textBoxRoomNrRes;
        private System.Windows.Forms.Label labelRoomNumberRes;
        private System.Windows.Forms.Label labelFilters;
        private System.Windows.Forms.Label labelSickness;
        private System.Windows.Forms.TextBox textBoxIllness;
        private System.Windows.Forms.Label labelRoom_number;
        private System.Windows.Forms.TextBox textBoxRoomNr;
        private System.Windows.Forms.Label labelEquipment;
        private System.Windows.Forms.CheckedListBox checkedListBoxEquipment;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckInDate;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.TextBox textBoxDepartment;
    }
}