namespace RezerwacjaSal
{
    partial class PatientRoomReservations
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
            this.dataGridViewAllPatientRoomReservations = new System.Windows.Forms.DataGridView();
            this.panelAllPatientRoomReservations = new System.Windows.Forms.Panel();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonNewReservation = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelWithin = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.groupBoxFilter = new System.Windows.Forms.GroupBox();
            this.radioButtonBetween = new System.Windows.Forms.RadioButton();
            this.radioButtonEnding = new System.Windows.Forms.RadioButton();
            this.radioButtonStarting = new System.Windows.Forms.RadioButton();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.labelRoomNumber = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.textBoxRoomNumber = new System.Windows.Forms.TextBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.comboBoxBuilding = new System.Windows.Forms.ComboBox();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.labelBuilding = new System.Windows.Forms.Label();
            this.textBoxDoctorName = new System.Windows.Forms.TextBox();
            this.buttonShowReservations = new System.Windows.Forms.Button();
            this.labelDoctorName = new System.Windows.Forms.Label();
            this.textBoxReservationNumber = new System.Windows.Forms.TextBox();
            this.textBoxDoctorSurname = new System.Windows.Forms.TextBox();
            this.labelReservationNumber = new System.Windows.Forms.Label();
            this.labelDoctorSurname = new System.Windows.Forms.Label();
            this.labelPatientSurname = new System.Windows.Forms.Label();
            this.textBoxPatientPESEL = new System.Windows.Forms.TextBox();
            this.textBoxPatientSurname = new System.Windows.Forms.TextBox();
            this.labelPatientPESEL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllPatientRoomReservations)).BeginInit();
            this.panelAllPatientRoomReservations.SuspendLayout();
            this.groupBoxMenu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewAllPatientRoomReservations
            // 
            this.dataGridViewAllPatientRoomReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllPatientRoomReservations.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewAllPatientRoomReservations.Location = new System.Drawing.Point(12, 312);
            this.dataGridViewAllPatientRoomReservations.MultiSelect = false;
            this.dataGridViewAllPatientRoomReservations.Name = "dataGridViewAllPatientRoomReservations";
            this.dataGridViewAllPatientRoomReservations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAllPatientRoomReservations.Size = new System.Drawing.Size(1086, 397);
            this.dataGridViewAllPatientRoomReservations.TabIndex = 4;
            this.dataGridViewAllPatientRoomReservations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAllPatientRoomReservations_CellClick);
            this.dataGridViewAllPatientRoomReservations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAllPatientRoomReservations_CellContentClick);
            this.dataGridViewAllPatientRoomReservations.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dataGridViewAllPatientRoomReservations_CellStateChanged);
            this.dataGridViewAllPatientRoomReservations.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAllPatientRoomReservations_CellValueChanged);
            this.dataGridViewAllPatientRoomReservations.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewAllPatientRoomReservations_EditingControlShowing);
            // 
            // panelAllPatientRoomReservations
            // 
            this.panelAllPatientRoomReservations.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelAllPatientRoomReservations.Controls.Add(this.groupBoxMenu);
            this.panelAllPatientRoomReservations.Controls.Add(this.groupBox2);
            this.panelAllPatientRoomReservations.Location = new System.Drawing.Point(12, 12);
            this.panelAllPatientRoomReservations.Name = "panelAllPatientRoomReservations";
            this.panelAllPatientRoomReservations.Size = new System.Drawing.Size(1086, 281);
            this.panelAllPatientRoomReservations.TabIndex = 5;
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Controls.Add(this.buttonBack);
            this.groupBoxMenu.Controls.Add(this.buttonEdit);
            this.groupBoxMenu.Controls.Add(this.buttonDelete);
            this.groupBoxMenu.Controls.Add(this.buttonNewReservation);
            this.groupBoxMenu.Location = new System.Drawing.Point(787, 13);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(282, 256);
            this.groupBoxMenu.TabIndex = 47;
            this.groupBoxMenu.TabStop = false;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(18, 188);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(248, 36);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "Powrót";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(18, 77);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(248, 36);
            this.buttonEdit.TabIndex = 8;
            this.buttonEdit.Text = "Edytuj";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.AllowDrop = true;
            this.buttonDelete.Location = new System.Drawing.Point(18, 132);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(248, 36);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Usuń";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonNewReservation
            // 
            this.buttonNewReservation.Location = new System.Drawing.Point(18, 23);
            this.buttonNewReservation.Name = "buttonNewReservation";
            this.buttonNewReservation.Size = new System.Drawing.Size(248, 36);
            this.buttonNewReservation.TabIndex = 6;
            this.buttonNewReservation.Text = "Nowa rezerwacja";
            this.buttonNewReservation.UseVisualStyleBackColor = true;
            this.buttonNewReservation.Click += new System.EventHandler(this.buttonNewReservation_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.labelWithin);
            this.groupBox2.Controls.Add(this.labelFrom);
            this.groupBox2.Controls.Add(this.groupBoxFilter);
            this.groupBox2.Controls.Add(this.dateTimePickerFrom);
            this.groupBox2.Controls.Add(this.labelRoomNumber);
            this.groupBox2.Controls.Add(this.dateTimePickerTo);
            this.groupBox2.Controls.Add(this.textBoxRoomNumber);
            this.groupBox2.Controls.Add(this.labelTo);
            this.groupBox2.Controls.Add(this.comboBoxDepartment);
            this.groupBox2.Controls.Add(this.comboBoxBuilding);
            this.groupBox2.Controls.Add(this.labelDepartment);
            this.groupBox2.Controls.Add(this.labelBuilding);
            this.groupBox2.Controls.Add(this.textBoxDoctorName);
            this.groupBox2.Controls.Add(this.buttonShowReservations);
            this.groupBox2.Controls.Add(this.labelDoctorName);
            this.groupBox2.Controls.Add(this.textBoxReservationNumber);
            this.groupBox2.Controls.Add(this.textBoxDoctorSurname);
            this.groupBox2.Controls.Add(this.labelReservationNumber);
            this.groupBox2.Controls.Add(this.labelDoctorSurname);
            this.groupBox2.Controls.Add(this.labelPatientSurname);
            this.groupBox2.Controls.Add(this.textBoxPatientPESEL);
            this.groupBox2.Controls.Add(this.textBoxPatientSurname);
            this.groupBox2.Controls.Add(this.labelPatientPESEL);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(754, 256);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(5, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Moje rezerwacje sal chorych";
            // 
            // labelWithin
            // 
            this.labelWithin.AutoSize = true;
            this.labelWithin.Location = new System.Drawing.Point(321, 110);
            this.labelWithin.Name = "labelWithin";
            this.labelWithin.Size = new System.Drawing.Size(54, 13);
            this.labelWithin.TabIndex = 45;
            this.labelWithin.Text = "w terminie";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(317, 132);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(21, 13);
            this.labelFrom.TabIndex = 12;
            this.labelFrom.Text = "Od";
            // 
            // groupBoxFilter
            // 
            this.groupBoxFilter.Controls.Add(this.radioButtonBetween);
            this.groupBoxFilter.Controls.Add(this.radioButtonEnding);
            this.groupBoxFilter.Controls.Add(this.radioButtonStarting);
            this.groupBoxFilter.Location = new System.Drawing.Point(318, 39);
            this.groupBoxFilter.Name = "groupBoxFilter";
            this.groupBoxFilter.Size = new System.Drawing.Size(416, 57);
            this.groupBoxFilter.TabIndex = 44;
            this.groupBoxFilter.TabStop = false;
            this.groupBoxFilter.Text = "Pokazuj rezerwacje";
            // 
            // radioButtonBetween
            // 
            this.radioButtonBetween.AutoSize = true;
            this.radioButtonBetween.Location = new System.Drawing.Point(282, 19);
            this.radioButtonBetween.Name = "radioButtonBetween";
            this.radioButtonBetween.Size = new System.Drawing.Size(97, 17);
            this.radioButtonBetween.TabIndex = 45;
            this.radioButtonBetween.TabStop = true;
            this.radioButtonBetween.Text = "zawierające się";
            this.radioButtonBetween.UseVisualStyleBackColor = true;
            // 
            // radioButtonEnding
            // 
            this.radioButtonEnding.AutoSize = true;
            this.radioButtonEnding.Location = new System.Drawing.Point(155, 19);
            this.radioButtonEnding.Name = "radioButtonEnding";
            this.radioButtonEnding.Size = new System.Drawing.Size(88, 17);
            this.radioButtonEnding.TabIndex = 44;
            this.radioButtonEnding.TabStop = true;
            this.radioButtonEnding.Text = "kończące się";
            this.radioButtonEnding.UseVisualStyleBackColor = true;
            // 
            // radioButtonStarting
            // 
            this.radioButtonStarting.AutoSize = true;
            this.radioButtonStarting.Location = new System.Drawing.Point(6, 19);
            this.radioButtonStarting.Name = "radioButtonStarting";
            this.radioButtonStarting.Size = new System.Drawing.Size(115, 17);
            this.radioButtonStarting.TabIndex = 43;
            this.radioButtonStarting.TabStop = true;
            this.radioButtonStarting.Text = "rozpoczynające się";
            this.radioButtonStarting.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(320, 148);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(136, 20);
            this.dateTimePickerFrom.TabIndex = 13;
            // 
            // labelRoomNumber
            // 
            this.labelRoomNumber.AutoSize = true;
            this.labelRoomNumber.Location = new System.Drawing.Point(6, 226);
            this.labelRoomNumber.Name = "labelRoomNumber";
            this.labelRoomNumber.Size = new System.Drawing.Size(56, 13);
            this.labelRoomNumber.TabIndex = 41;
            this.labelRoomNumber.Text = "Numer sali";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(489, 148);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(136, 20);
            this.dateTimePickerTo.TabIndex = 14;
            // 
            // textBoxRoomNumber
            // 
            this.textBoxRoomNumber.Location = new System.Drawing.Point(114, 226);
            this.textBoxRoomNumber.Name = "textBoxRoomNumber";
            this.textBoxRoomNumber.Size = new System.Drawing.Size(180, 20);
            this.textBoxRoomNumber.TabIndex = 40;
            this.textBoxRoomNumber.TextChanged += new System.EventHandler(this.textBoxRoomNumber_TextChanged);
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(486, 132);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(21, 13);
            this.labelTo.TabIndex = 15;
            this.labelTo.Text = "Do";
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.comboBoxDepartment.Location = new System.Drawing.Point(114, 197);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(180, 21);
            this.comboBoxDepartment.TabIndex = 39;
            // 
            // comboBoxBuilding
            // 
            this.comboBoxBuilding.FormattingEnabled = true;
            this.comboBoxBuilding.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.comboBoxBuilding.Location = new System.Drawing.Point(114, 171);
            this.comboBoxBuilding.Name = "comboBoxBuilding";
            this.comboBoxBuilding.Size = new System.Drawing.Size(180, 21);
            this.comboBoxBuilding.TabIndex = 20;
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Location = new System.Drawing.Point(6, 200);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(44, 13);
            this.labelDepartment.TabIndex = 38;
            this.labelDepartment.Text = "Oddział";
            // 
            // labelBuilding
            // 
            this.labelBuilding.AutoSize = true;
            this.labelBuilding.Location = new System.Drawing.Point(6, 174);
            this.labelBuilding.Name = "labelBuilding";
            this.labelBuilding.Size = new System.Drawing.Size(49, 13);
            this.labelBuilding.TabIndex = 21;
            this.labelBuilding.Text = "Budynek";
            // 
            // textBoxDoctorName
            // 
            this.textBoxDoctorName.Location = new System.Drawing.Point(114, 145);
            this.textBoxDoctorName.Name = "textBoxDoctorName";
            this.textBoxDoctorName.Size = new System.Drawing.Size(180, 20);
            this.textBoxDoctorName.TabIndex = 37;
            // 
            // buttonShowReservations
            // 
            this.buttonShowReservations.Location = new System.Drawing.Point(318, 210);
            this.buttonShowReservations.Name = "buttonShowReservations";
            this.buttonShowReservations.Size = new System.Drawing.Size(416, 36);
            this.buttonShowReservations.TabIndex = 22;
            this.buttonShowReservations.Text = "Pokaż rezerwacje";
            this.buttonShowReservations.UseVisualStyleBackColor = true;
            this.buttonShowReservations.Click += new System.EventHandler(this.buttonShowReservations_Click);
            // 
            // labelDoctorName
            // 
            this.labelDoctorName.AutoSize = true;
            this.labelDoctorName.Location = new System.Drawing.Point(6, 148);
            this.labelDoctorName.Name = "labelDoctorName";
            this.labelDoctorName.Size = new System.Drawing.Size(63, 13);
            this.labelDoctorName.TabIndex = 36;
            this.labelDoctorName.Text = "Imię lekarza";
            // 
            // textBoxReservationNumber
            // 
            this.textBoxReservationNumber.Location = new System.Drawing.Point(114, 39);
            this.textBoxReservationNumber.Name = "textBoxReservationNumber";
            this.textBoxReservationNumber.Size = new System.Drawing.Size(180, 20);
            this.textBoxReservationNumber.TabIndex = 28;
            this.textBoxReservationNumber.TextChanged += new System.EventHandler(this.textBoxReservationNumber_TextChanged);
            // 
            // textBoxDoctorSurname
            // 
            this.textBoxDoctorSurname.Location = new System.Drawing.Point(114, 119);
            this.textBoxDoctorSurname.Name = "textBoxDoctorSurname";
            this.textBoxDoctorSurname.Size = new System.Drawing.Size(180, 20);
            this.textBoxDoctorSurname.TabIndex = 35;
            // 
            // labelReservationNumber
            // 
            this.labelReservationNumber.AutoSize = true;
            this.labelReservationNumber.Location = new System.Drawing.Point(6, 39);
            this.labelReservationNumber.Name = "labelReservationNumber";
            this.labelReservationNumber.Size = new System.Drawing.Size(88, 13);
            this.labelReservationNumber.TabIndex = 29;
            this.labelReservationNumber.Text = "Numer rezerwacji";
            // 
            // labelDoctorSurname
            // 
            this.labelDoctorSurname.AutoSize = true;
            this.labelDoctorSurname.Location = new System.Drawing.Point(6, 122);
            this.labelDoctorSurname.Name = "labelDoctorSurname";
            this.labelDoctorSurname.Size = new System.Drawing.Size(90, 13);
            this.labelDoctorSurname.TabIndex = 34;
            this.labelDoctorSurname.Text = "Nazwisko lekarza";
            // 
            // labelPatientSurname
            // 
            this.labelPatientSurname.AutoSize = true;
            this.labelPatientSurname.Location = new System.Drawing.Point(6, 67);
            this.labelPatientSurname.Name = "labelPatientSurname";
            this.labelPatientSurname.Size = new System.Drawing.Size(97, 13);
            this.labelPatientSurname.TabIndex = 30;
            this.labelPatientSurname.Text = "Nazwisko pacjenta";
            // 
            // textBoxPatientPESEL
            // 
            this.textBoxPatientPESEL.Location = new System.Drawing.Point(114, 93);
            this.textBoxPatientPESEL.Name = "textBoxPatientPESEL";
            this.textBoxPatientPESEL.Size = new System.Drawing.Size(180, 20);
            this.textBoxPatientPESEL.TabIndex = 33;
            // 
            // textBoxPatientSurname
            // 
            this.textBoxPatientSurname.Location = new System.Drawing.Point(114, 64);
            this.textBoxPatientSurname.Name = "textBoxPatientSurname";
            this.textBoxPatientSurname.Size = new System.Drawing.Size(180, 20);
            this.textBoxPatientSurname.TabIndex = 31;
            // 
            // labelPatientPESEL
            // 
            this.labelPatientPESEL.AutoSize = true;
            this.labelPatientPESEL.Location = new System.Drawing.Point(6, 96);
            this.labelPatientPESEL.Name = "labelPatientPESEL";
            this.labelPatientPESEL.Size = new System.Drawing.Size(85, 13);
            this.labelPatientPESEL.TabIndex = 32;
            this.labelPatientPESEL.Text = "PESEL pacjenta";
            // 
            // PatientRoomReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 721);
            this.Controls.Add(this.panelAllPatientRoomReservations);
            this.Controls.Add(this.dataGridViewAllPatientRoomReservations);
            this.Name = "PatientRoomReservations";
            this.Text = "Wszystkie rezerwacje sal chorych";
            this.Load += new System.EventHandler(this.PatientRoomReservations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllPatientRoomReservations)).EndInit();
            this.panelAllPatientRoomReservations.ResumeLayout(false);
            this.groupBoxMenu.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxFilter.ResumeLayout(false);
            this.groupBoxFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAllPatientRoomReservations;
        private System.Windows.Forms.Panel panelAllPatientRoomReservations;
        private System.Windows.Forms.Button buttonShowReservations;
        private System.Windows.Forms.Label labelBuilding;
        private System.Windows.Forms.ComboBox comboBoxBuilding;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelReservationNumber;
        private System.Windows.Forms.TextBox textBoxReservationNumber;
        private System.Windows.Forms.Label labelPatientSurname;
        private System.Windows.Forms.GroupBox groupBoxFilter;
        private System.Windows.Forms.RadioButton radioButtonBetween;
        private System.Windows.Forms.RadioButton radioButtonEnding;
        private System.Windows.Forms.RadioButton radioButtonStarting;
        private System.Windows.Forms.Label labelRoomNumber;
        private System.Windows.Forms.TextBox textBoxRoomNumber;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.TextBox textBoxDoctorName;
        private System.Windows.Forms.Label labelDoctorName;
        private System.Windows.Forms.TextBox textBoxDoctorSurname;
        private System.Windows.Forms.Label labelDoctorSurname;
        private System.Windows.Forms.TextBox textBoxPatientPESEL;
        private System.Windows.Forms.Label labelPatientPESEL;
        private System.Windows.Forms.TextBox textBoxPatientSurname;
        private System.Windows.Forms.Label labelWithin;
        private System.Windows.Forms.Button buttonNewReservation;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
    }
}