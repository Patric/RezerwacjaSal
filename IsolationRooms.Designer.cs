
namespace RezerwacjaSal
{
    partial class IsolationRooms
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
            this.buttonUndo = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonReserve = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelLoggedAs = new System.Windows.Forms.Label();
            this.dataGridViewDataIsolation = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataIsolation)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUndo
            // 
            this.buttonUndo.Location = new System.Drawing.Point(673, 373);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(92, 44);
            this.buttonUndo.TabIndex = 0;
            this.buttonUndo.Text = "Cofnij";
            this.buttonUndo.UseVisualStyleBackColor = true;
            this.buttonUndo.Click += new System.EventHandler(this.buttonUndo_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(673, 155);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(92, 50);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Usuń rezerwację";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(673, 99);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(92, 50);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Edytuj rezerwację";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonReserve
            // 
            this.buttonReserve.Location = new System.Drawing.Point(673, 43);
            this.buttonReserve.Name = "buttonReserve";
            this.buttonReserve.Size = new System.Drawing.Size(92, 50);
            this.buttonReserve.TabIndex = 3;
            this.buttonReserve.Text = "Zarezerwuj izolatkę dla pacjenta";
            this.buttonReserve.UseVisualStyleBackColor = true;
            this.buttonReserve.Click += new System.EventHandler(this.buttonReserve_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(21, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(241, 20);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Panel zarządzania izolatkami";
            // 
            // labelLoggedAs
            // 
            this.labelLoggedAs.AutoSize = true;
            this.labelLoggedAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLoggedAs.Location = new System.Drawing.Point(455, 14);
            this.labelLoggedAs.Name = "labelLoggedAs";
            this.labelLoggedAs.Size = new System.Drawing.Size(203, 13);
            this.labelLoggedAs.TabIndex = 5;
            this.labelLoggedAs.Text = "Zalogowany jako: Imie + Nazwisko";
            this.labelLoggedAs.Click += new System.EventHandler(this.labelLoggedAs_Click);
            // 
            // dataGridViewDataIsolation
            // 
            this.dataGridViewDataIsolation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDataIsolation.Location = new System.Drawing.Point(25, 43);
            this.dataGridViewDataIsolation.Name = "dataGridViewDataIsolation";
            this.dataGridViewDataIsolation.Size = new System.Drawing.Size(633, 374);
            this.dataGridViewDataIsolation.TabIndex = 6;
            // 
            // IsolationRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewDataIsolation);
            this.Controls.Add(this.labelLoggedAs);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonReserve);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUndo);
            this.Name = "IsolationRooms";
            this.Text = "IsolationRooms";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataIsolation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUndo;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonReserve;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelLoggedAs;
        private System.Windows.Forms.DataGridView dataGridViewDataIsolation;
    }
}