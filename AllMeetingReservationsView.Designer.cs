
namespace RezerwacjaSal
{
    partial class AllMeetingReservationsView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonParticipantsListDisplay = new System.Windows.Forms.Button();
            this.buttonAddReservation = new System.Windows.Forms.Button();
            this.buttonReservationEdit = new System.Windows.Forms.Button();
            this.buttonReservationDelete = new System.Windows.Forms.Button();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1123, 697);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonParticipantsListDisplay
            // 
            this.buttonParticipantsListDisplay.Location = new System.Drawing.Point(12, 734);
            this.buttonParticipantsListDisplay.Name = "buttonParticipantsListDisplay";
            this.buttonParticipantsListDisplay.Size = new System.Drawing.Size(133, 57);
            this.buttonParticipantsListDisplay.TabIndex = 1;
            this.buttonParticipantsListDisplay.Text = "Wyświetl Listę Uczestników";
            this.buttonParticipantsListDisplay.UseVisualStyleBackColor = true;
            // 
            // buttonAddReservation
            // 
            this.buttonAddReservation.Location = new System.Drawing.Point(160, 734);
            this.buttonAddReservation.Name = "buttonAddReservation";
            this.buttonAddReservation.Size = new System.Drawing.Size(126, 57);
            this.buttonAddReservation.TabIndex = 2;
            this.buttonAddReservation.Text = "Dodaj nową rezerwację";
            this.buttonAddReservation.UseVisualStyleBackColor = true;
            // 
            // buttonReservationEdit
            // 
            this.buttonReservationEdit.Location = new System.Drawing.Point(301, 734);
            this.buttonReservationEdit.Name = "buttonReservationEdit";
            this.buttonReservationEdit.Size = new System.Drawing.Size(123, 57);
            this.buttonReservationEdit.TabIndex = 3;
            this.buttonReservationEdit.Text = "Edytuj Rezerwację";
            this.buttonReservationEdit.UseVisualStyleBackColor = true;
            // 
            // buttonReservationDelete
            // 
            this.buttonReservationDelete.Location = new System.Drawing.Point(444, 734);
            this.buttonReservationDelete.Name = "buttonReservationDelete";
            this.buttonReservationDelete.Size = new System.Drawing.Size(146, 57);
            this.buttonReservationDelete.TabIndex = 4;
            this.buttonReservationDelete.Text = "Usuń rezerwację";
            this.buttonReservationDelete.UseVisualStyleBackColor = true;
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.Location = new System.Drawing.Point(991, 768);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(110, 43);
            this.buttonGoBack.TabIndex = 5;
            this.buttonGoBack.Text = "Powrót";
            this.buttonGoBack.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1123, 697);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Data rozpoczęcia";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Liczba Uczestników";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Numer sali";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Rodzaj sali";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Data zakończenia";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Rezerwacja wykonana przez";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // AllMeetingReservationsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 823);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.buttonReservationDelete);
            this.Controls.Add(this.buttonReservationEdit);
            this.Controls.Add(this.buttonAddReservation);
            this.Controls.Add(this.buttonParticipantsListDisplay);
            this.Controls.Add(this.panel1);
            this.Name = "AllMeetingReservationsView";
            this.Text = "AllMeetingReservationsView";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button buttonParticipantsListDisplay;
        private System.Windows.Forms.Button buttonAddReservation;
        private System.Windows.Forms.Button buttonReservationEdit;
        private System.Windows.Forms.Button buttonReservationDelete;
        private System.Windows.Forms.Button buttonGoBack;
    }
}