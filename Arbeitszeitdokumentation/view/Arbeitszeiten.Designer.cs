namespace Arbeitszeitdokumentation_v0._1.view
{
    partial class Arbeitszeiten
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
            this.tB2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tB3 = new System.Windows.Forms.TextBox();
            this.b14 = new System.Windows.Forms.Button();
            this.b15 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tB1 = new System.Windows.Forms.TextBox();
            this.tB4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tB2
            // 
            this.tB2.Location = new System.Drawing.Point(123, 68);
            this.tB2.Name = "tB2";
            this.tB2.Size = new System.Drawing.Size(100, 20);
            this.tB2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Arbeitszeit Beginn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Arbeitszeit Ende:";
            // 
            // tB3
            // 
            this.tB3.Location = new System.Drawing.Point(123, 109);
            this.tB3.Name = "tB3";
            this.tB3.Size = new System.Drawing.Size(100, 20);
            this.tB3.TabIndex = 2;
            // 
            // b14
            // 
            this.b14.Location = new System.Drawing.Point(17, 183);
            this.b14.Name = "b14";
            this.b14.Size = new System.Drawing.Size(75, 23);
            this.b14.TabIndex = 4;
            this.b14.Text = "Speichern";
            this.b14.UseVisualStyleBackColor = true;
            this.b14.Click += new System.EventHandler(this.b14_Click);
            // 
            // b15
            // 
            this.b15.Location = new System.Drawing.Point(148, 183);
            this.b15.Name = "b15";
            this.b15.Size = new System.Drawing.Size(75, 23);
            this.b15.TabIndex = 5;
            this.b15.Text = "Abbrechen";
            this.b15.UseVisualStyleBackColor = true;
            this.b15.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mitarbeiter-ID: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Projekt-ID:";
            // 
            // tB1
            // 
            this.tB1.Location = new System.Drawing.Point(123, 27);
            this.tB1.Name = "tB1";
            this.tB1.Size = new System.Drawing.Size(100, 20);
            this.tB1.TabIndex = 0;
            // 
            // tB4
            // 
            this.tB4.Location = new System.Drawing.Point(123, 148);
            this.tB4.Name = "tB4";
            this.tB4.Size = new System.Drawing.Size(100, 20);
            this.tB4.TabIndex = 3;
            // 
            // Arbeitszeiten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 216);
            this.Controls.Add(this.tB4);
            this.Controls.Add(this.tB1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.b15);
            this.Controls.Add(this.b14);
            this.Controls.Add(this.tB3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tB2);
            this.Name = "Arbeitszeiten";
            this.Text = "Arbeitszeiten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tB2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tB3;
        private System.Windows.Forms.Button b14;
        private System.Windows.Forms.Button b15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tB1;
        private System.Windows.Forms.TextBox tB4;
    }
}