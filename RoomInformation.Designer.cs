namespace RezerwacjaSal
{
    partial class RoomInformation
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
            this.panelRoomInformation = new System.Windows.Forms.Panel();
            this.dataGridViewRoomInformation = new System.Windows.Forms.DataGridView();
            this.labelRoomInformation = new System.Windows.Forms.Label();
            this.panelPatientsList = new System.Windows.Forms.Panel();
            this.dataGridViewPatientsList = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelPatientData = new System.Windows.Forms.Panel();
            this.textBoxCheckInDate = new System.Windows.Forms.TextBox();
            this.labelCheckInDate = new System.Windows.Forms.Label();
            this.buttonFullData = new System.Windows.Forms.Button();
            this.labelSecondName = new System.Windows.Forms.Label();
            this.textBoxSecondName = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.textBoxSickness = new System.Windows.Forms.TextBox();
            this.labelSickness = new System.Windows.Forms.Label();
            this.textBoxPESEL = new System.Windows.Forms.TextBox();
            this.labelPESEL = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelPatientData = new System.Windows.Forms.Label();
            this.ColumnRoomNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAvailability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBuilding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnPlaceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnPESEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCheckInDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFreePlace = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelRoomInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoomInformation)).BeginInit();
            this.panelPatientsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatientsList)).BeginInit();
            this.panelPatientData.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRoomInformation
            // 
            this.panelRoomInformation.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelRoomInformation.Controls.Add(this.dataGridViewRoomInformation);
            this.panelRoomInformation.Controls.Add(this.labelRoomInformation);
            this.panelRoomInformation.Location = new System.Drawing.Point(12, 12);
            this.panelRoomInformation.Name = "panelRoomInformation";
            this.panelRoomInformation.Size = new System.Drawing.Size(717, 112);
            this.panelRoomInformation.TabIndex = 3;
            // 
            // dataGridViewRoomInformation
            // 
            this.dataGridViewRoomInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoomInformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnRoomNr,
            this.ColumnAvailability,
            this.ColumnDepartment,
            this.ColumnBuilding,
            this.ColumnType});
            this.dataGridViewRoomInformation.Location = new System.Drawing.Point(7, 42);
            this.dataGridViewRoomInformation.Name = "dataGridViewRoomInformation";
            this.dataGridViewRoomInformation.Size = new System.Drawing.Size(707, 60);
            this.dataGridViewRoomInformation.TabIndex = 4;
            // 
            // labelRoomInformation
            // 
            this.labelRoomInformation.AutoSize = true;
            this.labelRoomInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRoomInformation.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelRoomInformation.Location = new System.Drawing.Point(3, 10);
            this.labelRoomInformation.Name = "labelRoomInformation";
            this.labelRoomInformation.Size = new System.Drawing.Size(141, 20);
            this.labelRoomInformation.TabIndex = 1;
            this.labelRoomInformation.Text = "Informacje o sali";
            // 
            // panelPatientsList
            // 
            this.panelPatientsList.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelPatientsList.Controls.Add(this.dataGridViewPatientsList);
            this.panelPatientsList.Controls.Add(this.button1);
            this.panelPatientsList.Controls.Add(this.label2);
            this.panelPatientsList.Location = new System.Drawing.Point(12, 146);
            this.panelPatientsList.Name = "panelPatientsList";
            this.panelPatientsList.Size = new System.Drawing.Size(714, 380);
            this.panelPatientsList.TabIndex = 5;
            // 
            // dataGridViewPatientsList
            // 
            this.dataGridViewPatientsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatientsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumnPlaceID,
            this.dataGridViewTextBoxColumnNumber,
            this.dataGridViewTextBoxColumnSurname,
            this.dataGridViewTextBoxColumnName,
            this.dataGridViewTextBoxColumnPESEL,
            this.ColumnCheckInDate,
            this.ColumnFreePlace});
            this.dataGridViewPatientsList.Location = new System.Drawing.Point(7, 42);
            this.dataGridViewPatientsList.Name = "dataGridViewPatientsList";
            this.dataGridViewPatientsList.Size = new System.Drawing.Size(704, 335);
            this.dataGridViewPatientsList.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(445, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lista pacjentów";
            // 
            // panelPatientData
            // 
            this.panelPatientData.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelPatientData.Controls.Add(this.textBoxCheckInDate);
            this.panelPatientData.Controls.Add(this.labelCheckInDate);
            this.panelPatientData.Controls.Add(this.buttonFullData);
            this.panelPatientData.Controls.Add(this.labelSecondName);
            this.panelPatientData.Controls.Add(this.textBoxSecondName);
            this.panelPatientData.Controls.Add(this.textBoxNumber);
            this.panelPatientData.Controls.Add(this.labelNumber);
            this.panelPatientData.Controls.Add(this.textBoxSickness);
            this.panelPatientData.Controls.Add(this.labelSickness);
            this.panelPatientData.Controls.Add(this.textBoxPESEL);
            this.panelPatientData.Controls.Add(this.labelPESEL);
            this.panelPatientData.Controls.Add(this.textBoxAge);
            this.panelPatientData.Controls.Add(this.labelAge);
            this.panelPatientData.Controls.Add(this.textBoxSurname);
            this.panelPatientData.Controls.Add(this.labelSurname);
            this.panelPatientData.Controls.Add(this.labelName);
            this.panelPatientData.Controls.Add(this.textBoxName);
            this.panelPatientData.Controls.Add(this.labelPatientData);
            this.panelPatientData.Location = new System.Drawing.Point(735, 12);
            this.panelPatientData.Name = "panelPatientData";
            this.panelPatientData.Size = new System.Drawing.Size(306, 514);
            this.panelPatientData.TabIndex = 6;
            // 
            // textBoxCheckInDate
            // 
            this.textBoxCheckInDate.Location = new System.Drawing.Point(93, 273);
            this.textBoxCheckInDate.Name = "textBoxCheckInDate";
            this.textBoxCheckInDate.ReadOnly = true;
            this.textBoxCheckInDate.Size = new System.Drawing.Size(192, 20);
            this.textBoxCheckInDate.TabIndex = 18;
            // 
            // labelCheckInDate
            // 
            this.labelCheckInDate.AutoSize = true;
            this.labelCheckInDate.Location = new System.Drawing.Point(13, 276);
            this.labelCheckInDate.Name = "labelCheckInDate";
            this.labelCheckInDate.Size = new System.Drawing.Size(74, 13);
            this.labelCheckInDate.TabIndex = 17;
            this.labelCheckInDate.Text = "Data przyjęcia";
            // 
            // buttonFullData
            // 
            this.buttonFullData.Location = new System.Drawing.Point(71, 318);
            this.buttonFullData.Name = "buttonFullData";
            this.buttonFullData.Size = new System.Drawing.Size(176, 45);
            this.buttonFullData.TabIndex = 16;
            this.buttonFullData.Text = "Pobierz dane szczegółowe pacjenta z systemu zewnętrznego";
            this.buttonFullData.UseVisualStyleBackColor = true;
            // 
            // labelSecondName
            // 
            this.labelSecondName.AutoSize = true;
            this.labelSecondName.Location = new System.Drawing.Point(13, 108);
            this.labelSecondName.Name = "labelSecondName";
            this.labelSecondName.Size = new System.Drawing.Size(59, 13);
            this.labelSecondName.TabIndex = 15;
            this.labelSecondName.Text = "Drugie imię";
            // 
            // textBoxSecondName
            // 
            this.textBoxSecondName.Location = new System.Drawing.Point(93, 105);
            this.textBoxSecondName.Name = "textBoxSecondName";
            this.textBoxSecondName.ReadOnly = true;
            this.textBoxSecondName.Size = new System.Drawing.Size(192, 20);
            this.textBoxSecondName.TabIndex = 14;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(93, 42);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.ReadOnly = true;
            this.textBoxNumber.Size = new System.Drawing.Size(192, 20);
            this.textBoxNumber.TabIndex = 13;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(17, 45);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(38, 13);
            this.labelNumber.TabIndex = 12;
            this.labelNumber.Text = "Numer";
            // 
            // textBoxSickness
            // 
            this.textBoxSickness.Location = new System.Drawing.Point(93, 239);
            this.textBoxSickness.Name = "textBoxSickness";
            this.textBoxSickness.ReadOnly = true;
            this.textBoxSickness.Size = new System.Drawing.Size(192, 20);
            this.textBoxSickness.TabIndex = 11;
            // 
            // labelSickness
            // 
            this.labelSickness.AutoSize = true;
            this.labelSickness.Location = new System.Drawing.Point(14, 242);
            this.labelSickness.Name = "labelSickness";
            this.labelSickness.Size = new System.Drawing.Size(47, 13);
            this.labelSickness.TabIndex = 10;
            this.labelSickness.Text = "Choroba";
            // 
            // textBoxPESEL
            // 
            this.textBoxPESEL.Location = new System.Drawing.Point(93, 207);
            this.textBoxPESEL.Name = "textBoxPESEL";
            this.textBoxPESEL.ReadOnly = true;
            this.textBoxPESEL.Size = new System.Drawing.Size(192, 20);
            this.textBoxPESEL.TabIndex = 9;
            // 
            // labelPESEL
            // 
            this.labelPESEL.AutoSize = true;
            this.labelPESEL.Location = new System.Drawing.Point(14, 210);
            this.labelPESEL.Name = "labelPESEL";
            this.labelPESEL.Size = new System.Drawing.Size(41, 13);
            this.labelPESEL.TabIndex = 8;
            this.labelPESEL.Text = "PESEL";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(93, 172);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.ReadOnly = true;
            this.textBoxAge.Size = new System.Drawing.Size(192, 20);
            this.textBoxAge.TabIndex = 7;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(13, 175);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(32, 13);
            this.labelAge.TabIndex = 6;
            this.labelAge.Text = "Wiek";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(93, 138);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.ReadOnly = true;
            this.textBoxSurname.Size = new System.Drawing.Size(192, 20);
            this.textBoxSurname.TabIndex = 5;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(13, 141);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(53, 13);
            this.labelSurname.TabIndex = 4;
            this.labelSurname.Text = "Nazwisko";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(13, 75);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(70, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Pierwsze imię";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(93, 72);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(192, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // labelPatientData
            // 
            this.labelPatientData.AutoSize = true;
            this.labelPatientData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPatientData.ForeColor = System.Drawing.SystemColors.WindowText;
            this.labelPatientData.Location = new System.Drawing.Point(3, 10);
            this.labelPatientData.Name = "labelPatientData";
            this.labelPatientData.Size = new System.Drawing.Size(126, 20);
            this.labelPatientData.TabIndex = 1;
            this.labelPatientData.Text = "Dane pacjenta";
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
            // ColumnType
            // 
            this.ColumnType.HeaderText = "Typ sali";
            this.ColumnType.Name = "ColumnType";
            this.ColumnType.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnPlaceID
            // 
            this.dataGridViewTextBoxColumnPlaceID.FillWeight = 50F;
            this.dataGridViewTextBoxColumnPlaceID.HeaderText = "ID miejsca";
            this.dataGridViewTextBoxColumnPlaceID.MaxInputLength = 9999999;
            this.dataGridViewTextBoxColumnPlaceID.Name = "dataGridViewTextBoxColumnPlaceID";
            this.dataGridViewTextBoxColumnPlaceID.Width = 60;
            // 
            // dataGridViewTextBoxColumnNumber
            // 
            this.dataGridViewTextBoxColumnNumber.HeaderText = "Numer";
            this.dataGridViewTextBoxColumnNumber.Name = "dataGridViewTextBoxColumnNumber";
            this.dataGridViewTextBoxColumnNumber.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnSurname
            // 
            this.dataGridViewTextBoxColumnSurname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumnSurname.HeaderText = "Nazwisko";
            this.dataGridViewTextBoxColumnSurname.Name = "dataGridViewTextBoxColumnSurname";
            this.dataGridViewTextBoxColumnSurname.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnName
            // 
            this.dataGridViewTextBoxColumnName.HeaderText = "Imię";
            this.dataGridViewTextBoxColumnName.Name = "dataGridViewTextBoxColumnName";
            this.dataGridViewTextBoxColumnName.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnPESEL
            // 
            this.dataGridViewTextBoxColumnPESEL.HeaderText = "PESEL";
            this.dataGridViewTextBoxColumnPESEL.Name = "dataGridViewTextBoxColumnPESEL";
            this.dataGridViewTextBoxColumnPESEL.ReadOnly = true;
            // 
            // ColumnCheckInDate
            // 
            this.ColumnCheckInDate.HeaderText = "Data przyjęcia";
            this.ColumnCheckInDate.Name = "ColumnCheckInDate";
            this.ColumnCheckInDate.ReadOnly = true;
            // 
            // ColumnFreePlace
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "Zwolnij miejsce";
            this.ColumnFreePlace.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnFreePlace.HeaderText = "";
            this.ColumnFreePlace.Name = "ColumnFreePlace";
            // 
            // RoomInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 550);
            this.Controls.Add(this.panelPatientData);
            this.Controls.Add(this.panelPatientsList);
            this.Controls.Add(this.panelRoomInformation);
            this.Name = "RoomInformation";
            this.Text = "Obłożenie sali 110";
            this.panelRoomInformation.ResumeLayout(false);
            this.panelRoomInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoomInformation)).EndInit();
            this.panelPatientsList.ResumeLayout(false);
            this.panelPatientsList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatientsList)).EndInit();
            this.panelPatientData.ResumeLayout(false);
            this.panelPatientData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRoomInformation;
        private System.Windows.Forms.Label labelRoomInformation;
        private System.Windows.Forms.DataGridView dataGridViewRoomInformation;
        private System.Windows.Forms.Panel panelPatientsList;
        private System.Windows.Forms.DataGridView dataGridViewPatientsList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelPatientData;
        private System.Windows.Forms.Label labelPatientData;
        private System.Windows.Forms.Label labelSecondName;
        private System.Windows.Forms.TextBox textBoxSecondName;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.TextBox textBoxSickness;
        private System.Windows.Forms.Label labelSickness;
        private System.Windows.Forms.TextBox textBoxPESEL;
        private System.Windows.Forms.Label labelPESEL;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonFullData;
        private System.Windows.Forms.TextBox textBoxCheckInDate;
        private System.Windows.Forms.Label labelCheckInDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRoomNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAvailability;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBuilding;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnPlaceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnPESEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCheckInDate;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnFreePlace;
    }
}