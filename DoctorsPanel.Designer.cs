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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorsPanel));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonMeetingShowAddReservation = new System.Windows.Forms.Button();
            this.buttonMeetingShowMyReserv = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSickRoomOccupation = new System.Windows.Forms.Button();
            this.buttonSickAddReservation = new System.Windows.Forms.Button();
            this.buttonSickMyReservation = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonIsolationAddReservation = new System.Windows.Forms.Button();
            this.buttonIsolationMyReservations = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 192);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonMeetingShowAddReservation);
            this.groupBox1.Controls.Add(this.buttonMeetingShowMyReserv);
            this.groupBox1.Location = new System.Drawing.Point(38, 231);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(180, 192);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sale Spotkań i Sale Pokazowe";
            // 
            // buttonMeetingShowAddReservation
            // 
            this.buttonMeetingShowAddReservation.Location = new System.Drawing.Point(21, 102);
            this.buttonMeetingShowAddReservation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonMeetingShowAddReservation.Name = "buttonMeetingShowAddReservation";
            this.buttonMeetingShowAddReservation.Size = new System.Drawing.Size(135, 57);
            this.buttonMeetingShowAddReservation.TabIndex = 1;
            this.buttonMeetingShowAddReservation.Text = "Dodaj rezerwację";
            this.buttonMeetingShowAddReservation.UseVisualStyleBackColor = true;
            // 
            // buttonMeetingShowMyReserv
            // 
            this.buttonMeetingShowMyReserv.Location = new System.Drawing.Point(21, 27);
            this.buttonMeetingShowMyReserv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonMeetingShowMyReserv.Name = "buttonMeetingShowMyReserv";
            this.buttonMeetingShowMyReserv.Size = new System.Drawing.Size(135, 57);
            this.buttonMeetingShowMyReserv.TabIndex = 0;
            this.buttonMeetingShowMyReserv.Text = "Moje Rezerwacje";
            this.buttonMeetingShowMyReserv.UseVisualStyleBackColor = true;
            this.buttonMeetingShowMyReserv.Click += new System.EventHandler(this.button8_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSickRoomOccupation);
            this.groupBox2.Controls.Add(this.buttonSickAddReservation);
            this.groupBox2.Controls.Add(this.buttonSickMyReservation);
            this.groupBox2.Location = new System.Drawing.Point(264, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(174, 168);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sale Chorych";
            // 
            // buttonSickRoomOccupation
            // 
            this.buttonSickRoomOccupation.Location = new System.Drawing.Point(35, 106);
            this.buttonSickRoomOccupation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSickRoomOccupation.Name = "buttonSickRoomOccupation";
            this.buttonSickRoomOccupation.Size = new System.Drawing.Size(102, 47);
            this.buttonSickRoomOccupation.TabIndex = 3;
            this.buttonSickRoomOccupation.Text = "Wyświetl obłożenie sal chorych";
            this.buttonSickRoomOccupation.UseVisualStyleBackColor = true;
            this.buttonSickRoomOccupation.Click += new System.EventHandler(this.buttonSickRoomOccupation_Click);
            // 
            // buttonSickAddReservation
            // 
            this.buttonSickAddReservation.Location = new System.Drawing.Point(35, 61);
            this.buttonSickAddReservation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSickAddReservation.Name = "buttonSickAddReservation";
            this.buttonSickAddReservation.Size = new System.Drawing.Size(104, 41);
            this.buttonSickAddReservation.TabIndex = 1;
            this.buttonSickAddReservation.Text = "Dodaj Rezerwację";
            this.buttonSickAddReservation.UseVisualStyleBackColor = true;
            this.buttonSickAddReservation.Click += new System.EventHandler(this.buttonSickAddReservation_Click);
            // 
            // buttonSickMyReservation
            // 
            this.buttonSickMyReservation.Location = new System.Drawing.Point(35, 17);
            this.buttonSickMyReservation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSickMyReservation.Name = "buttonSickMyReservation";
            this.buttonSickMyReservation.Size = new System.Drawing.Size(104, 40);
            this.buttonSickMyReservation.TabIndex = 0;
            this.buttonSickMyReservation.Text = "Moje Rezerwacje";
            this.buttonSickMyReservation.UseVisualStyleBackColor = true;
            this.buttonSickMyReservation.Click += new System.EventHandler(this.buttonSickMyReservation_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonIsolationAddReservation);
            this.groupBox3.Controls.Add(this.buttonIsolationMyReservations);
            this.groupBox3.Location = new System.Drawing.Point(264, 231);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(174, 192);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Izolatki";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // buttonIsolationAddReservation
            // 
            this.buttonIsolationAddReservation.Location = new System.Drawing.Point(35, 97);
            this.buttonIsolationAddReservation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonIsolationAddReservation.Name = "buttonIsolationAddReservation";
            this.buttonIsolationAddReservation.Size = new System.Drawing.Size(95, 62);
            this.buttonIsolationAddReservation.TabIndex = 1;
            this.buttonIsolationAddReservation.Text = "Dodaj Rezerwację";
            this.buttonIsolationAddReservation.UseVisualStyleBackColor = true;
            this.buttonIsolationAddReservation.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonIsolationMyReservations
            // 
            this.buttonIsolationMyReservations.Location = new System.Drawing.Point(37, 27);
            this.buttonIsolationMyReservations.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonIsolationMyReservations.Name = "buttonIsolationMyReservations";
            this.buttonIsolationMyReservations.Size = new System.Drawing.Size(93, 57);
            this.buttonIsolationMyReservations.TabIndex = 0;
            this.buttonIsolationMyReservations.Text = "Moje Rezerwacje";
            this.buttonIsolationMyReservations.UseVisualStyleBackColor = true;
            this.buttonIsolationMyReservations.Click += new System.EventHandler(this.buttonIsolationMyReservations_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(197, 440);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(83, 35);
            this.buttonLogout.TabIndex = 4;
            this.buttonLogout.Text = "Wyloguj";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // DoctorsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 531);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button buttonMeetingShowAddReservation;
        private System.Windows.Forms.Button buttonMeetingShowMyReserv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonSickRoomOccupation;
        private System.Windows.Forms.Button buttonSickAddReservation;
        private System.Windows.Forms.Button buttonSickMyReservation;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonIsolationAddReservation;
        private System.Windows.Forms.Button buttonIsolationMyReservations;
        private System.Windows.Forms.Button buttonLogout;
    }
}