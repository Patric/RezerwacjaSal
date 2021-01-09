
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
            this.button1chuj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1chuj
            // 
            this.button1chuj.Location = new System.Drawing.Point(286, 207);
            this.button1chuj.Name = "button1chuj";
            this.button1chuj.Size = new System.Drawing.Size(75, 23);
            this.button1chuj.TabIndex = 0;
            this.button1chuj.Text = "button1";
            this.button1chuj.UseVisualStyleBackColor = true;
            // 
            // ReserveIsolationRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1chuj);
            this.Name = "ReserveIsolationRoom";
            this.Text = "ReserveIsolationRoom";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1chuj;
    }
}