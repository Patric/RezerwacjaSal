namespace RezerwacjaSal
{
    partial class ReserveIsolationRoom
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewPatientRooms = new System.Windows.Forms.DataGridView();
            this.ColumnRoomNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAvailablePlaces = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBuilding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInfectious = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxRoom = new System.Windows.Forms.TextBox();
            this.labelRoom = new System.Windows.Forms.Label();
            this.textBoxReservationNr = new System.Windows.Forms.TextBox();
            this.labelReservationNumber = new System.Windows.Forms.Label();
            this.labelReservePatientRoom = new System.Windows.Forms.Label();
            this.labelFirstNme = new System.Windows.Forms.Label();
            this.comboBoxSicknessNr = new System.Windows.Forms.ComboBox();
            this.labelCheckOutDate = new System.Windows.Forms.Label();
            this.comboBoxBulding = new System.Windows.Forms.ComboBox();
            this.labelSicknessName = new System.Windows.Forms.Label();
            this.dateTimePickerCheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelSicknessSymbol = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelPESEL = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxPESEL = new System.Windows.Forms.TextBox();
            this.labelBuilding = new System.Windows.Forms.Label();
            this.dateTimePickerCheckInDate = new System.Windows.Forms.DateTimePicker();
            this.labelCheckInDate = new System.Windows.Forms.Label();
            this.groupBoxReservationData = new System.Windows.Forms.GroupBox();
            this.panelReservePatientRoom = new System.Windows.Forms.Panel();
            this.groupBoxRequirements = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxInfectious = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatientRooms)).BeginInit();
            this.groupBoxReservationData.SuspendLayout();
            this.panelReservePatientRoom.SuspendLayout();
            this.groupBoxRequirements.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPatientRooms
            // 
            this.dataGridViewPatientRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatientRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnRoomNr,
            this.ColumnAvailablePlaces,
            this.ColumnDepartment,
            this.ColumnBuilding,
            this.ColumnInfectious,
            this.Column5});
            this.dataGridViewPatientRooms.Location = new System.Drawing.Point(12, 410);
            this.dataGridViewPatientRooms.Name = "dataGridViewPatientRooms";
            this.dataGridViewPatientRooms.Size = new System.Drawing.Size(699, 208);
            this.dataGridViewPatientRooms.TabIndex = 5;
            // 
            // ColumnRoomNr
            // 
            this.ColumnRoomNr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle11.NullValue = "751";
            this.ColumnRoomNr.DefaultCellStyle = dataGridViewCellStyle11;
            this.ColumnRoomNr.FillWeight = 50F;
            this.ColumnRoomNr.HeaderText = "Numer sali";
            this.ColumnRoomNr.MaxInputLength = 9999999;
            this.ColumnRoomNr.Name = "ColumnRoomNr";
            this.ColumnRoomNr.Width = 81;
            // 
            // ColumnAvailablePlaces
            // 
            dataGridViewCellStyle12.NullValue = "Tak";
            this.ColumnAvailablePlaces.DefaultCellStyle = dataGridViewCellStyle12;
            this.ColumnAvailablePlaces.HeaderText = "Wolne miejsca";
            this.ColumnAvailablePlaces.Name = "ColumnAvailablePlaces";
            this.ColumnAvailablePlaces.ReadOnly = true;
            // 
            // ColumnDepartment
            // 
            this.ColumnDepartment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle13.NullValue = "Onkologia";
            this.ColumnDepartment.DefaultCellStyle = dataGridViewCellStyle13;
            this.ColumnDepartment.HeaderText = "Oddział";
            this.ColumnDepartment.Name = "ColumnDepartment";
            this.ColumnDepartment.ReadOnly = true;
            this.ColumnDepartment.Width = 69;
            // 
            // ColumnBuilding
            // 
            this.ColumnBuilding.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle14.NullValue = "C";
            this.ColumnBuilding.DefaultCellStyle = dataGridViewCellStyle14;
            this.ColumnBuilding.HeaderText = "Budynek";
            this.ColumnBuilding.Name = "ColumnBuilding";
            this.ColumnBuilding.ReadOnly = true;
            // 
            // ColumnInfectious
            // 
            this.ColumnInfectious.HeaderText = "Zakaźna";
            this.ColumnInfectious.Name = "ColumnInfectious";
            this.ColumnInfectious.ReadOnly = true;
            // 
            // Column5
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.NullValue = "Wybierz";
            this.Column5.DefaultCellStyle = dataGridViewCellStyle15;
            this.Column5.HeaderText = "";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column5.Text = "Wybierz";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(19, 300);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(212, 27);
            this.buttonSave.TabIndex = 40;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxRoom
            // 
            this.textBoxRoom.Location = new System.Drawing.Point(108, 274);
            this.textBoxRoom.Name = "textBoxRoom";
            this.textBoxRoom.ReadOnly = true;
            this.textBoxRoom.Size = new System.Drawing.Size(123, 20);
            this.textBoxRoom.TabIndex = 39;
            this.textBoxRoom.Text = "751/C";
            // 
            // labelRoom
            // 
            this.labelRoom.AutoSize = true;
            this.labelRoom.Location = new System.Drawing.Point(16, 281);
            this.labelRoom.Name = "labelRoom";
            this.labelRoom.Size = new System.Drawing.Size(28, 13);
            this.labelRoom.TabIndex = 38;
            this.labelRoom.Text = "Sala";
            // 
            // textBoxReservationNr
            // 
            this.textBoxReservationNr.Location = new System.Drawing.Point(108, 26);
            this.textBoxReservationNr.Name = "textBoxReservationNr";
            this.textBoxReservationNr.ReadOnly = true;
            this.textBoxReservationNr.Size = new System.Drawing.Size(123, 20);
            this.textBoxReservationNr.TabIndex = 37;
            // 
            // labelReservationNumber
            // 
            this.labelReservationNumber.AutoSize = true;
            this.labelReservationNumber.Location = new System.Drawing.Point(16, 29);
            this.labelReservationNumber.Name = "labelReservationNumber";
            this.labelReservationNumber.Size = new System.Drawing.Size(88, 13);
            this.labelReservationNumber.TabIndex = 36;
            this.labelReservationNumber.Text = "Numer rezerwacji";
            // 
            // labelReservePatientRoom
            // 
            this.labelReservePatientRoom.AutoSize = true;
            this.labelReservePatientRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelReservePatientRoom.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelReservePatientRoom.Location = new System.Drawing.Point(3, 10);
            this.labelReservePatientRoom.Name = "labelReservePatientRoom";
            this.labelReservePatientRoom.Size = new System.Drawing.Size(150, 20);
            this.labelReservePatientRoom.TabIndex = 1;
            this.labelReservePatientRoom.Text = "Rezerwuj izolatkę";
            this.labelReservePatientRoom.Click += new System.EventHandler(this.labelReservePatientRoom_Click);
            // 
            // labelFirstNme
            // 
            this.labelFirstNme.AutoSize = true;
            this.labelFirstNme.Location = new System.Drawing.Point(16, 52);
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
            this.comboBoxSicknessNr.Location = new System.Drawing.Point(108, 229);
            this.comboBoxSicknessNr.Name = "comboBoxSicknessNr";
            this.comboBoxSicknessNr.Size = new System.Drawing.Size(123, 21);
            this.comboBoxSicknessNr.TabIndex = 30;
            this.comboBoxSicknessNr.Text = "BN-01L";
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
            "E"});
            this.comboBoxBulding.Location = new System.Drawing.Point(14, 89);
            this.comboBoxBulding.Name = "comboBoxBulding";
            this.comboBoxBulding.Size = new System.Drawing.Size(135, 21);
            this.comboBoxBulding.TabIndex = 20;
            // 
            // labelSicknessName
            // 
            this.labelSicknessName.AutoSize = true;
            this.labelSicknessName.Location = new System.Drawing.Point(105, 249);
            this.labelSicknessName.Name = "labelSicknessName";
            this.labelSicknessName.Size = new System.Drawing.Size(85, 13);
            this.labelSicknessName.TabIndex = 31;
            this.labelSicknessName.Text = "Brak nogi - lewej";
            // 
            // dateTimePickerCheckOutDate
            // 
            this.dateTimePickerCheckOutDate.Location = new System.Drawing.Point(168, 45);
            this.dateTimePickerCheckOutDate.Name = "dateTimePickerCheckOutDate";
            this.dateTimePickerCheckOutDate.Size = new System.Drawing.Size(136, 20);
            this.dateTimePickerCheckOutDate.TabIndex = 14;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(108, 49);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(123, 20);
            this.textBoxFirstName.TabIndex = 21;
            this.textBoxFirstName.Text = "Jan";
            // 
            // labelSicknessSymbol
            // 
            this.labelSicknessSymbol.AutoSize = true;
            this.labelSicknessSymbol.Location = new System.Drawing.Point(6, 229);
            this.labelSicknessSymbol.Name = "labelSicknessSymbol";
            this.labelSicknessSymbol.Size = new System.Drawing.Size(82, 13);
            this.labelSicknessSymbol.TabIndex = 29;
            this.labelSicknessSymbol.Text = "Symbol choroby";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(16, 78);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(53, 13);
            this.labelSurname.TabIndex = 23;
            this.labelSurname.Text = "Nazwisko";
            // 
            // labelPESEL
            // 
            this.labelPESEL.AutoSize = true;
            this.labelPESEL.Location = new System.Drawing.Point(6, 203);
            this.labelPESEL.Name = "labelPESEL";
            this.labelPESEL.Size = new System.Drawing.Size(83, 13);
            this.labelPESEL.TabIndex = 28;
            this.labelPESEL.Text = "Numer Pacjenta";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(108, 75);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(123, 20);
            this.textBoxSurname.TabIndex = 24;
            this.textBoxSurname.Text = "Kowalski";
            this.textBoxSurname.TextChanged += new System.EventHandler(this.textBoxSurname_TextChanged);
            // 
            // textBoxPESEL
            // 
            this.textBoxPESEL.Location = new System.Drawing.Point(108, 200);
            this.textBoxPESEL.Name = "textBoxPESEL";
            this.textBoxPESEL.Size = new System.Drawing.Size(123, 20);
            this.textBoxPESEL.TabIndex = 27;
            this.textBoxPESEL.Text = "76021309332";
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
            // dateTimePickerCheckInDate
            // 
            this.dateTimePickerCheckInDate.Location = new System.Drawing.Point(13, 45);
            this.dateTimePickerCheckInDate.Name = "dateTimePickerCheckInDate";
            this.dateTimePickerCheckInDate.Size = new System.Drawing.Size(136, 20);
            this.dateTimePickerCheckInDate.TabIndex = 13;
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
            // groupBoxReservationData
            // 
            this.groupBoxReservationData.Controls.Add(this.buttonSave);
            this.groupBoxReservationData.Controls.Add(this.textBoxRoom);
            this.groupBoxReservationData.Controls.Add(this.labelRoom);
            this.groupBoxReservationData.Controls.Add(this.textBoxReservationNr);
            this.groupBoxReservationData.Controls.Add(this.labelReservationNumber);
            this.groupBoxReservationData.Controls.Add(this.labelSicknessName);
            this.groupBoxReservationData.Controls.Add(this.labelFirstNme);
            this.groupBoxReservationData.Controls.Add(this.comboBoxSicknessNr);
            this.groupBoxReservationData.Controls.Add(this.textBoxFirstName);
            this.groupBoxReservationData.Controls.Add(this.labelSicknessSymbol);
            this.groupBoxReservationData.Controls.Add(this.labelSurname);
            this.groupBoxReservationData.Controls.Add(this.labelPESEL);
            this.groupBoxReservationData.Controls.Add(this.textBoxSurname);
            this.groupBoxReservationData.Controls.Add(this.textBoxPESEL);
            this.groupBoxReservationData.Location = new System.Drawing.Point(447, 33);
            this.groupBoxReservationData.Name = "groupBoxReservationData";
            this.groupBoxReservationData.Size = new System.Drawing.Size(252, 342);
            this.groupBoxReservationData.TabIndex = 25;
            this.groupBoxReservationData.TabStop = false;
            this.groupBoxReservationData.Text = "Dane rezerwacji";
            // 
            // panelReservePatientRoom
            // 
            this.panelReservePatientRoom.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelReservePatientRoom.Controls.Add(this.groupBoxReservationData);
            this.panelReservePatientRoom.Controls.Add(this.groupBoxRequirements);
            this.panelReservePatientRoom.Controls.Add(this.labelReservePatientRoom);
            this.panelReservePatientRoom.Location = new System.Drawing.Point(12, 12);
            this.panelReservePatientRoom.Name = "panelReservePatientRoom";
            this.panelReservePatientRoom.Size = new System.Drawing.Size(699, 392);
            this.panelReservePatientRoom.TabIndex = 6;
            // 
            // groupBoxRequirements
            // 
            this.groupBoxRequirements.Controls.Add(this.checkedListBox1);
            this.groupBoxRequirements.Controls.Add(this.label1);
            this.groupBoxRequirements.Controls.Add(this.labelCheckInDate);
            this.groupBoxRequirements.Controls.Add(this.dateTimePickerCheckInDate);
            this.groupBoxRequirements.Controls.Add(this.dateTimePickerCheckOutDate);
            this.groupBoxRequirements.Controls.Add(this.labelBuilding);
            this.groupBoxRequirements.Controls.Add(this.labelCheckOutDate);
            this.groupBoxRequirements.Controls.Add(this.comboBoxBulding);
            this.groupBoxRequirements.Controls.Add(this.checkBoxInfectious);
            this.groupBoxRequirements.Location = new System.Drawing.Point(7, 33);
            this.groupBoxRequirements.Name = "groupBoxRequirements";
            this.groupBoxRequirements.Size = new System.Drawing.Size(434, 342);
            this.groupBoxRequirements.TabIndex = 24;
            this.groupBoxRequirements.TabStop = false;
            this.groupBoxRequirements.Text = "Wymagania";
            this.groupBoxRequirements.Enter += new System.EventHandler(this.groupBoxRequirements_Enter);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(179, 122);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(240, 79);
            this.checkedListBox1.TabIndex = 26;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Wymagany sprzęt";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkBoxInfectious
            // 
            this.checkBoxInfectious.AutoSize = true;
            this.checkBoxInfectious.Location = new System.Drawing.Point(14, 127);
            this.checkBoxInfectious.Name = "checkBoxInfectious";
            this.checkBoxInfectious.Size = new System.Drawing.Size(68, 17);
            this.checkBoxInfectious.TabIndex = 19;
            this.checkBoxInfectious.Text = "Zakaźna";
            this.checkBoxInfectious.UseVisualStyleBackColor = true;
            // 
            // ReserveIsolationRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 625);
            this.Controls.Add(this.dataGridViewPatientRooms);
            this.Controls.Add(this.panelReservePatientRoom);
            this.Name = "ReserveIsolationRoom";
            this.Text = "ReserveIsolationRoom";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatientRooms)).EndInit();
            this.groupBoxReservationData.ResumeLayout(false);
            this.groupBoxReservationData.PerformLayout();
            this.panelReservePatientRoom.ResumeLayout(false);
            this.panelReservePatientRoom.PerformLayout();
            this.groupBoxRequirements.ResumeLayout(false);
            this.groupBoxRequirements.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewPatientRooms;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxRoom;
        private System.Windows.Forms.Label labelRoom;
        private System.Windows.Forms.TextBox textBoxReservationNr;
        private System.Windows.Forms.Label labelReservationNumber;
        private System.Windows.Forms.Label labelReservePatientRoom;
        private System.Windows.Forms.Label labelFirstNme;
        private System.Windows.Forms.ComboBox comboBoxSicknessNr;
        private System.Windows.Forms.Label labelCheckOutDate;
        private System.Windows.Forms.ComboBox comboBoxBulding;
        private System.Windows.Forms.Label labelSicknessName;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckOutDate;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelSicknessSymbol;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelPESEL;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxPESEL;
        private System.Windows.Forms.Label labelBuilding;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckInDate;
        private System.Windows.Forms.Label labelCheckInDate;
        private System.Windows.Forms.GroupBox groupBoxReservationData;
        private System.Windows.Forms.Panel panelReservePatientRoom;
        private System.Windows.Forms.GroupBox groupBoxRequirements;
        private System.Windows.Forms.CheckBox checkBoxInfectious;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRoomNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAvailablePlaces;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBuilding;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnInfectious;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
    }
}