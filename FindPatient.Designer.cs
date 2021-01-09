namespace RezerwacjaSal

{
    partial class FindPatient
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
            this.dataGridViewFindPatient = new System.Windows.Forms.DataGridView();
            this.ColumnRoomNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAvailability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBuilding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFilters = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelMinAvailablePlaces = new System.Windows.Forms.Label();
            this.numericUpDownAvailablePlaces = new System.Windows.Forms.NumericUpDown();
            this.labelDateTo = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.labelDateFrom = new System.Windows.Forms.Label();
            this.labelNumer = new System.Windows.Forms.Label();
            this.textBoxRoomNumber = new System.Windows.Forms.TextBox();
            this.labelFindPatientRoom = new System.Windows.Forms.Label();
            this.labelPESEL = new System.Windows.Forms.Label();
            this.textBoxPESEL = new System.Windows.Forms.TextBox();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.labelSecondName = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFindPatient)).BeginInit();
            this.panelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAvailablePlaces)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFindPatient
            // 
            this.dataGridViewFindPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFindPatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnRoomNr,
            this.ColumnAvailability,
            this.ColumnDepartment,
            this.ColumnBuilding,
            this.ColumnRoomType});
            this.dataGridViewFindPatient.Location = new System.Drawing.Point(12, 187);
            this.dataGridViewFindPatient.Name = "dataGridViewFindPatient";
            this.dataGridViewFindPatient.Size = new System.Drawing.Size(625, 328);
            this.dataGridViewFindPatient.TabIndex = 0;
            // 
            // ColumnRoomNr
            // 
            this.ColumnRoomNr.FillWeight = 50F;
            this.ColumnRoomNr.HeaderText = "Numer sali";
            this.ColumnRoomNr.MaxInputLength = 9999999;
            this.ColumnRoomNr.Name = "ColumnRoomNr";
            this.ColumnRoomNr.Width = 60;
            // 
            // ColumnAvailability
            // 
            this.ColumnAvailability.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnAvailability.HeaderText = "Miejsca (Zajęte/Wszystkie)";
            this.ColumnAvailability.Name = "ColumnAvailability";
            this.ColumnAvailability.ReadOnly = true;
            // 
            // ColumnDepartment
            // 
            this.ColumnDepartment.HeaderText = "Oddział";
            this.ColumnDepartment.Name = "ColumnDepartment";
            this.ColumnDepartment.ReadOnly = true;
            // 
            // ColumnBuilding
            // 
            this.ColumnBuilding.HeaderText = "Budynek";
            this.ColumnBuilding.Name = "ColumnBuilding";
            this.ColumnBuilding.ReadOnly = true;
            // 
            // ColumnRoomType
            // 
            this.ColumnRoomType.HeaderText = "Typ sali";
            this.ColumnRoomType.Name = "ColumnRoomType";
            this.ColumnRoomType.ReadOnly = true;
            // 
            // panelFilters
            // 
            this.panelFilters.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelFilters.Controls.Add(this.buttonSearch);
            this.panelFilters.Controls.Add(this.labelMinAvailablePlaces);
            this.panelFilters.Controls.Add(this.numericUpDownAvailablePlaces);
            this.panelFilters.Controls.Add(this.labelDateTo);
            this.panelFilters.Controls.Add(this.dateTimePickerTo);
            this.panelFilters.Controls.Add(this.dateTimePickerFrom);
            this.panelFilters.Controls.Add(this.labelDateFrom);
            this.panelFilters.Controls.Add(this.labelNumer);
            this.panelFilters.Controls.Add(this.textBoxRoomNumber);
            this.panelFilters.Controls.Add(this.labelFindPatientRoom);
            this.panelFilters.Controls.Add(this.labelPESEL);
            this.panelFilters.Controls.Add(this.textBoxPESEL);
            this.panelFilters.Controls.Add(this.textBoxSecondName);
            this.panelFilters.Controls.Add(this.labelSecondName);
            this.panelFilters.Controls.Add(this.textBoxSurname);
            this.panelFilters.Controls.Add(this.labelSurname);
            this.panelFilters.Controls.Add(this.labelFirstName);
            this.panelFilters.Controls.Add(this.textBoxFirstName);
            this.panelFilters.Location = new System.Drawing.Point(12, 12);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(625, 169);
            this.panelFilters.TabIndex = 2;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(7, 132);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(225, 34);
            this.buttonSearch.TabIndex = 18;
            this.buttonSearch.Text = "Szukaj";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // labelMinAvailablePlaces
            // 
            this.labelMinAvailablePlaces.AutoSize = true;
            this.labelMinAvailablePlaces.Location = new System.Drawing.Point(466, 51);
            this.labelMinAvailablePlaces.Name = "labelMinAvailablePlaces";
            this.labelMinAvailablePlaces.Size = new System.Drawing.Size(152, 13);
            this.labelMinAvailablePlaces.TabIndex = 17;
            this.labelMinAvailablePlaces.Text = "Minimalna ilość wolnych miejsc";
            // 
            // numericUpDownAvailablePlaces
            // 
            this.numericUpDownAvailablePlaces.Location = new System.Drawing.Point(469, 67);
            this.numericUpDownAvailablePlaces.Name = "numericUpDownAvailablePlaces";
            this.numericUpDownAvailablePlaces.Size = new System.Drawing.Size(123, 20);
            this.numericUpDownAvailablePlaces.TabIndex = 16;
            this.numericUpDownAvailablePlaces.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // labelDateTo
            // 
            this.labelDateTo.AutoSize = true;
            this.labelDateTo.Location = new System.Drawing.Point(313, 51);
            this.labelDateTo.Name = "labelDateTo";
            this.labelDateTo.Size = new System.Drawing.Size(89, 13);
            this.labelDateTo.TabIndex = 15;
            this.labelDateTo.Text = "Data przyjęcia do";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(316, 67);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(136, 20);
            this.dateTimePickerTo.TabIndex = 14;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(161, 67);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(136, 20);
            this.dateTimePickerFrom.TabIndex = 13;
            // 
            // labelDateFrom
            // 
            this.labelDateFrom.AutoSize = true;
            this.labelDateFrom.Location = new System.Drawing.Point(158, 51);
            this.labelDateFrom.Name = "labelDateFrom";
            this.labelDateFrom.Size = new System.Drawing.Size(89, 13);
            this.labelDateFrom.TabIndex = 12;
            this.labelDateFrom.Text = "Data przyjęcia od";
            // 
            // labelNumer
            // 
            this.labelNumer.AutoSize = true;
            this.labelNumer.Location = new System.Drawing.Point(6, 51);
            this.labelNumer.Name = "labelNumer";
            this.labelNumer.Size = new System.Drawing.Size(38, 13);
            this.labelNumer.TabIndex = 11;
            this.labelNumer.Text = "Numer";
            // 
            // textBoxRoomNumber
            // 
            this.textBoxRoomNumber.Location = new System.Drawing.Point(9, 67);
            this.textBoxRoomNumber.Name = "textBoxRoomNumber";
            this.textBoxRoomNumber.Size = new System.Drawing.Size(123, 20);
            this.textBoxRoomNumber.TabIndex = 10;
            this.textBoxRoomNumber.Text = "23832";
            // 
            // labelFindPatientRoom
            // 
            this.labelFindPatientRoom.AutoSize = true;
            this.labelFindPatientRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFindPatientRoom.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelFindPatientRoom.Location = new System.Drawing.Point(3, 10);
            this.labelFindPatientRoom.Name = "labelFindPatientRoom";
            this.labelFindPatientRoom.Size = new System.Drawing.Size(175, 20);
            this.labelFindPatientRoom.TabIndex = 1;
            this.labelFindPatientRoom.Text = "Znajdź salę pacjenta";
            // 
            // labelPESEL
            // 
            this.labelPESEL.AutoSize = true;
            this.labelPESEL.Location = new System.Drawing.Point(466, 90);
            this.labelPESEL.Name = "labelPESEL";
            this.labelPESEL.Size = new System.Drawing.Size(41, 13);
            this.labelPESEL.TabIndex = 9;
            this.labelPESEL.Text = "PESEL";
            // 
            // textBoxPESEL
            // 
            this.textBoxPESEL.Location = new System.Drawing.Point(469, 106);
            this.textBoxPESEL.Name = "textBoxPESEL";
            this.textBoxPESEL.Size = new System.Drawing.Size(123, 20);
            this.textBoxPESEL.TabIndex = 8;
            this.textBoxPESEL.Text = "76021309331";
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.Location = new System.Drawing.Point(161, 106);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.Size = new System.Drawing.Size(123, 20);
            this.textBoxSecondName.TabIndex = 7;
            this.textBoxSecondName.Text = "Michał";
            // 
            // labelSecondName
            // 
            this.labelSecondName.AutoSize = true;
            this.labelSecondName.Location = new System.Drawing.Point(158, 90);
            this.labelSecondName.Name = "labelSecondName";
            this.labelSecondName.Size = new System.Drawing.Size(59, 13);
            this.labelSecondName.TabIndex = 6;
            this.labelSecondName.Text = "Drugie imię";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(316, 106);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(123, 20);
            this.textBoxSurname.TabIndex = 5;
            this.textBoxSurname.Text = "Kowalski";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(313, 90);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(53, 13);
            this.labelSurname.TabIndex = 4;
            this.labelSurname.Text = "Nazwisko";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(6, 90);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(70, 13);
            this.labelFirstName.TabIndex = 3;
            this.labelFirstName.Text = "Pierwsze imię";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(9, 106);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(123, 20);
            this.textBoxFirstName.TabIndex = 0;
            this.textBoxFirstName.Text = "Jan";
            // 
            // FindPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 527);
            this.Controls.Add(this.panelFilters);
            this.Controls.Add(this.dataGridViewFindPatient);
            this.Name = "FindPatient";
            this.Text = "Obłożenie sal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFindPatient)).EndInit();
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAvailablePlaces)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFindPatient;
        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.Label labelFindPatientRoom;
        private System.Windows.Forms.Label labelPESEL;
        private System.Windows.Forms.TextBox textBoxPESEL;
        private System.Windows.Forms.TextBox textBoxSecondName;
        private System.Windows.Forms.Label labelSecondName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelNumer;
        private System.Windows.Forms.TextBox textBoxRoomNumber;
        private System.Windows.Forms.Label labelMinAvailablePlaces;
        private System.Windows.Forms.NumericUpDown numericUpDownAvailablePlaces;
        private System.Windows.Forms.Label labelDateTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label labelDateFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRoomNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAvailability;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBuilding;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRoomType;
        private System.Windows.Forms.Button buttonSearch;
    }
}

