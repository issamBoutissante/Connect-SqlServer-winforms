namespace connectionToDataBase
{
    partial class Form1
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
            this.Ouvrire_Connection = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Etat_de_Connection = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ouvrire_Connection
            // 
            this.Ouvrire_Connection.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Ouvrire_Connection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ouvrire_Connection.ForeColor = System.Drawing.Color.White;
            this.Ouvrire_Connection.Location = new System.Drawing.Point(461, 153);
            this.Ouvrire_Connection.Name = "Ouvrire_Connection";
            this.Ouvrire_Connection.Size = new System.Drawing.Size(207, 44);
            this.Ouvrire_Connection.TabIndex = 0;
            this.Ouvrire_Connection.Text = "Ouvrire Connection";
            this.Ouvrire_Connection.UseVisualStyleBackColor = false;
            this.Ouvrire_Connection.Click += new System.EventHandler(this.Ouvrire_Connection_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(155, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Fermer Connection";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Etat_de_Connection
            // 
            this.Etat_de_Connection.AutoSize = true;
            this.Etat_de_Connection.BackColor = System.Drawing.Color.Green;
            this.Etat_de_Connection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etat_de_Connection.ForeColor = System.Drawing.Color.White;
            this.Etat_de_Connection.Location = new System.Drawing.Point(275, 295);
            this.Etat_de_Connection.Name = "Etat_de_Connection";
            this.Etat_de_Connection.Size = new System.Drawing.Size(170, 20);
            this.Etat_de_Connection.TabIndex = 2;
            this.Etat_de_Connection.Text = "La Connection est : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Etat_de_Connection);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Ouvrire_Connection);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ouvrire_Connection;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Etat_de_Connection;
    }
}

