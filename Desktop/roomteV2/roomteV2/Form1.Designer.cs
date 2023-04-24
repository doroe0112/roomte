namespace roomteV2
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
            this.btn_aus = new System.Windows.Forms.Button();
            this.btn_an = new System.Windows.Forms.Button();
            this.lbl_kuche = new System.Windows.Forms.Label();
            this.btn_barAn = new System.Windows.Forms.Button();
            this.btn_barAus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_rolladenHoch = new System.Windows.Forms.Button();
            this.btn_rolladenRunter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_setup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_aus
            // 
            this.btn_aus.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aus.Location = new System.Drawing.Point(12, 318);
            this.btn_aus.Name = "btn_aus";
            this.btn_aus.Size = new System.Drawing.Size(306, 176);
            this.btn_aus.TabIndex = 1;
            this.btn_aus.Text = "AUS";
            this.btn_aus.UseVisualStyleBackColor = true;
            this.btn_aus.Click += new System.EventHandler(this.btn_aus_Click);
            // 
            // btn_an
            // 
            this.btn_an.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_an.Location = new System.Drawing.Point(12, 126);
            this.btn_an.Name = "btn_an";
            this.btn_an.Size = new System.Drawing.Size(306, 186);
            this.btn_an.TabIndex = 2;
            this.btn_an.Text = "AN";
            this.btn_an.UseVisualStyleBackColor = true;
            this.btn_an.Click += new System.EventHandler(this.btn_an_Click);
            // 
            // lbl_kuche
            // 
            this.lbl_kuche.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kuche.Location = new System.Drawing.Point(31, 9);
            this.lbl_kuche.Name = "lbl_kuche";
            this.lbl_kuche.Size = new System.Drawing.Size(264, 112);
            this.lbl_kuche.TabIndex = 3;
            this.lbl_kuche.Text = "Esstisch";
            this.lbl_kuche.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_barAn
            // 
            this.btn_barAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_barAn.Location = new System.Drawing.Point(410, 126);
            this.btn_barAn.Name = "btn_barAn";
            this.btn_barAn.Size = new System.Drawing.Size(306, 186);
            this.btn_barAn.TabIndex = 4;
            this.btn_barAn.Text = "AN";
            this.btn_barAn.UseVisualStyleBackColor = true;
            this.btn_barAn.Click += new System.EventHandler(this.btn_barAn_Click_1);
            // 
            // btn_barAus
            // 
            this.btn_barAus.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_barAus.Location = new System.Drawing.Point(410, 318);
            this.btn_barAus.Name = "btn_barAus";
            this.btn_barAus.Size = new System.Drawing.Size(306, 176);
            this.btn_barAus.TabIndex = 5;
            this.btn_barAus.Text = "AUS";
            this.btn_barAus.UseVisualStyleBackColor = true;
            this.btn_barAus.Click += new System.EventHandler(this.btn_barAus_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 112);
            this.label1.TabIndex = 6;
            this.label1.Text = "BarLicht";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_rolladenHoch
            // 
            this.btn_rolladenHoch.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rolladenHoch.Location = new System.Drawing.Point(827, 126);
            this.btn_rolladenHoch.Name = "btn_rolladenHoch";
            this.btn_rolladenHoch.Size = new System.Drawing.Size(306, 186);
            this.btn_rolladenHoch.TabIndex = 7;
            this.btn_rolladenHoch.Text = "Hoch";
            this.btn_rolladenHoch.UseVisualStyleBackColor = true;
            this.btn_rolladenHoch.Click += new System.EventHandler(this.btn_rolladenHoch_Click);
            // 
            // btn_rolladenRunter
            // 
            this.btn_rolladenRunter.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rolladenRunter.Location = new System.Drawing.Point(827, 318);
            this.btn_rolladenRunter.Name = "btn_rolladenRunter";
            this.btn_rolladenRunter.Size = new System.Drawing.Size(306, 176);
            this.btn_rolladenRunter.TabIndex = 8;
            this.btn_rolladenRunter.Text = "Runter";
            this.btn_rolladenRunter.UseVisualStyleBackColor = true;
            this.btn_rolladenRunter.Click += new System.EventHandler(this.btn_rolladenRunter_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(852, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 112);
            this.label2.TabIndex = 9;
            this.label2.Text = "Rolladen";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_setup
            // 
            this.btn_setup.Location = new System.Drawing.Point(827, 500);
            this.btn_setup.Name = "btn_setup";
            this.btn_setup.Size = new System.Drawing.Size(160, 34);
            this.btn_setup.TabIndex = 10;
            this.btn_setup.Text = "Setup";
            this.btn_setup.UseVisualStyleBackColor = true;
            this.btn_setup.Click += new System.EventHandler(this.btn_setup_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.btn_setup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_rolladenRunter);
            this.Controls.Add(this.btn_rolladenHoch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_barAus);
            this.Controls.Add(this.btn_barAn);
            this.Controls.Add(this.lbl_kuche);
            this.Controls.Add(this.btn_an);
            this.Controls.Add(this.btn_aus);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btn_setup;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button btn_rolladenRunter;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_rolladenHoch;

        private System.Windows.Forms.Button btn_barAus;

        private System.Windows.Forms.Button btn_barAn;

        private System.Windows.Forms.Label lbl_kuche;

        private System.Windows.Forms.Button btn_an;

        private System.Windows.Forms.Button btn_aus;

        #endregion
    }
}