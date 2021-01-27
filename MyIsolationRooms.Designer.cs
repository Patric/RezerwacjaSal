
namespace RezerwacjaSal
{
    partial class MyIsolationRooms
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
            this.dataGridViewDataMyIsolation = new System.Windows.Forms.DataGridView();
            this.labelLoggedAs = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonReserve = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUndo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataMyIsolation)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDataMyIsolation
            // 
            this.dataGridViewDataMyIsolation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDataMyIsolation.Location = new System.Drawing.Point(32, 55);
            this.dataGridViewDataMyIsolation.Name = "dataGridViewDataMyIsolation";
            this.dataGridViewDataMyIsolation.Size = new System.Drawing.Size(633, 374);
            this.dataGridViewDataMyIsolation.TabIndex = 13;
            // 
            // labelLoggedAs
            // 
            this.labelLoggedAs.AutoSize = true;
            this.labelLoggedAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLoggedAs.Location = new System.Drawing.Point(462, 26);
            this.labelLoggedAs.Name = "labelLoggedAs";
            this.labelLoggedAs.Size = new System.Drawing.Size(203, 13);
            this.labelLoggedAs.TabIndex = 12;
            this.labelLoggedAs.Text = "Zalogowany jako: Imie + Nazwisko";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(28, 21);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(205, 20);
            this.labelTitle.TabIndex = 11;
            this.labelTitle.Text = "Moje rezerwacje izolatek";
            // 
            // buttonReserve
            // 
            this.buttonReserve.Location = new System.Drawing.Point(680, 55);
            this.buttonReserve.Name = "buttonReserve";
            this.buttonReserve.Size = new System.Drawing.Size(92, 50);
            this.buttonReserve.TabIndex = 10;
            this.buttonReserve.Text = "Zarezerwuj izolatkę dla pacjenta";
            this.buttonReserve.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(680, 111);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(92, 50);
            this.buttonEdit.TabIndex = 9;
            this.buttonEdit.Text = "Edytuj rezerwację";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(680, 167);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(92, 50);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Usuń rezerwację";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonUndo
            // 
            this.buttonUndo.Location = new System.Drawing.Point(680, 385);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(92, 44);
            this.buttonUndo.TabIndex = 7;
            this.buttonUndo.Text = "Cofnij";
            this.buttonUndo.UseVisualStyleBackColor = true;
            this.buttonUndo.Click += new System.EventHandler(this.buttonUndo_Click);
            // 
            // MyIsolationRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewDataMyIsolation);
            this.Controls.Add(this.labelLoggedAs);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonReserve);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUndo);
            this.Name = "MyIsolationRooms";
            this.Text = "MyIsolationRooms";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataMyIsolation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDataMyIsolation;
        private System.Windows.Forms.Label labelLoggedAs;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonReserve;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUndo;
    }
}