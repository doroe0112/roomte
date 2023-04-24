namespace Voice_Recognition_Test1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnEin = new System.Windows.Forms.Button();
            this.btnAus = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lblText = new System.Windows.Forms.Label();
            this.btnSetup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEin
            // 
            this.btnEin.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEin.Location = new System.Drawing.Point(50, 146);
            this.btnEin.Name = "btnEin";
            this.btnEin.Size = new System.Drawing.Size(147, 79);
            this.btnEin.TabIndex = 0;
            this.btnEin.Text = "An";
            this.btnEin.UseVisualStyleBackColor = true;
            this.btnEin.Click += new System.EventHandler(this.btnEin_Click_1);
            // 
            // btnAus
            // 
            this.btnAus.Enabled = false;
            this.btnAus.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F);
            this.btnAus.Location = new System.Drawing.Point(353, 146);
            this.btnAus.Name = "btnAus";
            this.btnAus.Size = new System.Drawing.Size(147, 79);
            this.btnAus.TabIndex = 1;
            this.btnAus.Text = "Aus";
            this.btnAus.UseVisualStyleBackColor = true;
            this.btnAus.Click += new System.EventHandler(this.btnAus_Click_1);
            // 
            // lblText
            // 
            this.lblText.Location = new System.Drawing.Point(50, 46);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(450, 76);
            this.lblText.TabIndex = 2;
            // 
            // btnSetup
            // 
            this.btnSetup.Location = new System.Drawing.Point(235, 202);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(75, 23);
            this.btnSetup.TabIndex = 3;
            this.btnSetup.Text = "Setup";
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 251);
            this.Controls.Add(this.btnSetup);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnAus);
            this.Controls.Add(this.btnEin);
            this.Name = "Form1";
            this.Text = "Sprachsteuerung";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEin;
        private System.Windows.Forms.Button btnAus;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnSetup;
    }
}

