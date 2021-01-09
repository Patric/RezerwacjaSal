
namespace RezerwacjaSal
{
    partial class DoctorsPanel
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonSickMyReservation = new System.Windows.Forms.Button();
            this.buttonSickAddReservation = new System.Windows.Forms.Button();
            this.buttonSickAllReservation = new System.Windows.Forms.Button();
            this.buttonSickRoomOccupation = new System.Windows.Forms.Button();
            this.buttonIsolationMyReservations = new System.Windows.Forms.Button();
            this.buttonIsolationAddReservation = new System.Windows.Forms.Button();
            this.buttonIsolationAllReservation = new System.Windows.Forms.Button();
            this.buttonMeetingShowMyReserv = new System.Windows.Forms.Button();
            this.buttonMeetingShowAddReservation = new System.Windows.Forms.Button();
            this.buttonMeetingShowAllReservations = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(57, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 258);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonMeetingShowAllReservations);
            this.groupBox1.Controls.Add(this.buttonMeetingShowAddReservation);
            this.groupBox1.Controls.Add(this.buttonMeetingShowMyReserv);
            this.groupBox1.Location = new System.Drawing.Point(57, 341);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 296);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sale Spotkań i Sale Pokazowe";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSickRoomOccupation);
            this.groupBox2.Controls.Add(this.buttonSickAllReservation);
            this.groupBox2.Controls.Add(this.buttonSickAddReservation);
            this.groupBox2.Controls.Add(this.buttonSickMyReservation);
            this.groupBox2.Location = new System.Drawing.Point(570, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 258);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sale Chorych";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonIsolationAllReservation);
            this.groupBox3.Controls.Add(this.buttonIsolationAddReservation);
            this.groupBox3.Controls.Add(this.buttonIsolationMyReservations);
            this.groupBox3.Location = new System.Drawing.Point(570, 341);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 270);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Izolatki";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // buttonSickMyReservation
            // 
            this.buttonSickMyReservation.Location = new System.Drawing.Point(45, 34);
            this.buttonSickMyReservation.Name = "buttonSickMyReservation";
            this.buttonSickMyReservation.Size = new System.Drawing.Size(146, 39);
            this.buttonSickMyReservation.TabIndex = 0;
            this.buttonSickMyReservation.Text = "Moje Rezerwacje";
            this.buttonSickMyReservation.UseVisualStyleBackColor = true;
            // 
            // buttonSickAddReservation
            // 
            this.buttonSickAddReservation.Location = new System.Drawing.Point(45, 79);
            this.buttonSickAddReservation.Name = "buttonSickAddReservation";
            this.buttonSickAddReservation.Size = new System.Drawing.Size(146, 41);
            this.buttonSickAddReservation.TabIndex = 1;
            this.buttonSickAddReservation.Text = "Dodaj Rezerwację";
            this.buttonSickAddReservation.UseVisualStyleBackColor = true;
            // 
            // buttonSickAllReservation
            // 
            this.buttonSickAllReservation.Location = new System.Drawing.Point(45, 126);
            this.buttonSickAllReservation.Name = "buttonSickAllReservation";
            this.buttonSickAllReservation.Size = new System.Drawing.Size(146, 48);
            this.buttonSickAllReservation.TabIndex = 2;
            this.buttonSickAllReservation.Text = "Wszystkie Rezerwacje";
            this.buttonSickAllReservation.UseVisualStyleBackColor = true;
            // 
            // buttonSickRoomOccupation
            // 
            this.buttonSickRoomOccupation.Location = new System.Drawing.Point(45, 180);
            this.buttonSickRoomOccupation.Name = "buttonSickRoomOccupation";
            this.buttonSickRoomOccupation.Size = new System.Drawing.Size(146, 72);
            this.buttonSickRoomOccupation.TabIndex = 3;
            this.buttonSickRoomOccupation.Text = "Wyświetl obłożenie sal chorych";
            this.buttonSickRoomOccupation.UseVisualStyleBackColor = true;
            // 
            // buttonIsolationMyReservations
            // 
            this.buttonIsolationMyReservations.Location = new System.Drawing.Point(55, 42);
            this.buttonIsolationMyReservations.Name = "buttonIsolationMyReservations";
            this.buttonIsolationMyReservations.Size = new System.Drawing.Size(142, 52);
            this.buttonIsolationMyReservations.TabIndex = 0;
            this.buttonIsolationMyReservations.Text = "Moje Rezerwacje";
            this.buttonIsolationMyReservations.UseVisualStyleBackColor = true;
            // 
            // buttonIsolationAddReservation
            // 
            this.buttonIsolationAddReservation.Location = new System.Drawing.Point(55, 109);
            this.buttonIsolationAddReservation.Name = "buttonIsolationAddReservation";
            this.buttonIsolationAddReservation.Size = new System.Drawing.Size(142, 57);
            this.buttonIsolationAddReservation.TabIndex = 1;
            this.buttonIsolationAddReservation.Text = "Dodaj Rezerwację";
            this.buttonIsolationAddReservation.UseVisualStyleBackColor = true;
            this.buttonIsolationAddReservation.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonIsolationAllReservation
            // 
            this.buttonIsolationAllReservation.Location = new System.Drawing.Point(55, 181);
            this.buttonIsolationAllReservation.Name = "buttonIsolationAllReservation";
            this.buttonIsolationAllReservation.Size = new System.Drawing.Size(142, 58);
            this.buttonIsolationAllReservation.TabIndex = 2;
            this.buttonIsolationAllReservation.Text = "Wszystkie Rezerwacje";
            this.buttonIsolationAllReservation.UseVisualStyleBackColor = true;
            // 
            // buttonMeetingShowMyReserv
            // 
            this.buttonMeetingShowMyReserv.Location = new System.Drawing.Point(31, 42);
            this.buttonMeetingShowMyReserv.Name = "buttonMeetingShowMyReserv";
            this.buttonMeetingShowMyReserv.Size = new System.Drawing.Size(203, 52);
            this.buttonMeetingShowMyReserv.TabIndex = 0;
            this.buttonMeetingShowMyReserv.Text = "Moje Rezerwacje";
            this.buttonMeetingShowMyReserv.UseVisualStyleBackColor = true;
            this.buttonMeetingShowMyReserv.Click += new System.EventHandler(this.button8_Click);
            // 
            // buttonMeetingShowAddReservation
            // 
            this.buttonMeetingShowAddReservation.Location = new System.Drawing.Point(31, 100);
            this.buttonMeetingShowAddReservation.Name = "buttonMeetingShowAddReservation";
            this.buttonMeetingShowAddReservation.Size = new System.Drawing.Size(203, 57);
            this.buttonMeetingShowAddReservation.TabIndex = 1;
            this.buttonMeetingShowAddReservation.Text = "Dodaj rezerwację";
            this.buttonMeetingShowAddReservation.UseVisualStyleBackColor = true;
            // 
            // buttonMeetingShowAllReservations
            // 
            this.buttonMeetingShowAllReservations.Location = new System.Drawing.Point(31, 163);
            this.buttonMeetingShowAllReservations.Name = "buttonMeetingShowAllReservations";
            this.buttonMeetingShowAllReservations.Size = new System.Drawing.Size(203, 58);
            this.buttonMeetingShowAllReservations.TabIndex = 2;
            this.buttonMeetingShowAllReservations.Text = "Wszystkie Rezerwacje";
            this.buttonMeetingShowAllReservations.UseVisualStyleBackColor = true;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(380, 557);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(124, 54);
            this.buttonLogout.TabIndex = 4;
            this.buttonLogout.Text = "Wyloguj";
            this.buttonLogout.UseVisualStyleBackColor = true;
            // 
            // DoctorsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 658);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DoctorsPanel";
            this.Text = "DoctorsPanel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonMeetingShowAllReservations;
        private System.Windows.Forms.Button buttonMeetingShowAddReservation;
        private System.Windows.Forms.Button buttonMeetingShowMyReserv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonSickRoomOccupation;
        private System.Windows.Forms.Button buttonSickAllReservation;
        private System.Windows.Forms.Button buttonSickAddReservation;
        private System.Windows.Forms.Button buttonSickMyReservation;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonIsolationAllReservation;
        private System.Windows.Forms.Button buttonIsolationAddReservation;
        private System.Windows.Forms.Button buttonIsolationMyReservations;
        private System.Windows.Forms.Button buttonLogout;
    }
}