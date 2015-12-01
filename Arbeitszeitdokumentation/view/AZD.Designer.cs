namespace Arbeitszeitdokumentation.view
{
    partial class AZD
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
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b10 = new System.Windows.Forms.Button();
            this.b11 = new System.Windows.Forms.Button();
            this.GridEmployees = new System.Windows.Forms.DataGridView();
            this.GridProjects = new System.Windows.Forms.DataGridView();
            this.GridWorklog = new System.Windows.Forms.DataGridView();
            this.b12 = new System.Windows.Forms.Button();
            this.b13 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridWorklog)).BeginInit();
            this.SuspendLayout();
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(13, 13);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(141, 23);
            this.b1.TabIndex = 0;
            this.b1.Text = "Mitarbeiter auflisten";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(13, 204);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(141, 23);
            this.b2.TabIndex = 2;
            this.b2.Text = "Mitarbeiter hinzufügen";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(13, 238);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(141, 23);
            this.b4.TabIndex = 4;
            this.b4.Text = "Mitarbeiter löschen";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(265, 204);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(141, 23);
            this.b5.TabIndex = 5;
            this.b5.Text = "Projekt hinzufügen";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(265, 238);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(141, 23);
            this.b7.TabIndex = 7;
            this.b7.Text = "Projekt löschen";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(512, 204);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(141, 23);
            this.b8.TabIndex = 8;
            this.b8.Text = "Arbeitszeiten hinzufügen";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b10
            // 
            this.b10.Location = new System.Drawing.Point(512, 239);
            this.b10.Name = "b10";
            this.b10.Size = new System.Drawing.Size(141, 23);
            this.b10.TabIndex = 10;
            this.b10.Text = "Arbeitszeiten löschen";
            this.b10.UseVisualStyleBackColor = true;
            this.b10.Click += new System.EventHandler(this.b10_Click);
            // 
            // b11
            // 
            this.b11.Location = new System.Drawing.Point(666, 270);
            this.b11.Name = "b11";
            this.b11.Size = new System.Drawing.Size(75, 23);
            this.b11.TabIndex = 11;
            this.b11.Text = "Schließen";
            this.b11.UseVisualStyleBackColor = true;
            this.b11.Click += new System.EventHandler(this.b11_Click);
            // 
            // GridEmployees
            // 
            this.GridEmployees.AllowUserToAddRows = false;
            this.GridEmployees.AllowUserToDeleteRows = false;
            this.GridEmployees.AllowUserToOrderColumns = true;
            this.GridEmployees.AllowUserToResizeRows = false;
            this.GridEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEmployees.Location = new System.Drawing.Point(13, 43);
            this.GridEmployees.MultiSelect = false;
            this.GridEmployees.Name = "GridEmployees";
            this.GridEmployees.ReadOnly = true;
            this.GridEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridEmployees.Size = new System.Drawing.Size(225, 150);
            this.GridEmployees.TabIndex = 12;
            // 
            // GridProjects
            // 
            this.GridProjects.AllowUserToAddRows = false;
            this.GridProjects.AllowUserToDeleteRows = false;
            this.GridProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProjects.Location = new System.Drawing.Point(265, 43);
            this.GridProjects.MultiSelect = false;
            this.GridProjects.Name = "GridProjects";
            this.GridProjects.ReadOnly = true;
            this.GridProjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridProjects.Size = new System.Drawing.Size(225, 150);
            this.GridProjects.TabIndex = 13;
            // 
            // GridWorklog
            // 
            this.GridWorklog.AllowUserToAddRows = false;
            this.GridWorklog.AllowUserToDeleteRows = false;
            this.GridWorklog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridWorklog.Location = new System.Drawing.Point(512, 43);
            this.GridWorklog.MultiSelect = false;
            this.GridWorklog.Name = "GridWorklog";
            this.GridWorklog.ReadOnly = true;
            this.GridWorklog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridWorklog.Size = new System.Drawing.Size(223, 150);
            this.GridWorklog.TabIndex = 14;
            // 
            // b12
            // 
            this.b12.Location = new System.Drawing.Point(265, 13);
            this.b12.Name = "b12";
            this.b12.Size = new System.Drawing.Size(141, 23);
            this.b12.TabIndex = 15;
            this.b12.Text = "Projekte auflisten";
            this.b12.UseVisualStyleBackColor = true;
            this.b12.Click += new System.EventHandler(this.b12_Click);
            // 
            // b13
            // 
            this.b13.Location = new System.Drawing.Point(512, 13);
            this.b13.Name = "b13";
            this.b13.Size = new System.Drawing.Size(141, 23);
            this.b13.TabIndex = 16;
            this.b13.Text = "Arbeitszeiten auflisten";
            this.b13.UseVisualStyleBackColor = true;
            this.b13.Click += new System.EventHandler(this.b13_Click);
            // 
            // AZD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 302);
            this.Controls.Add(this.b13);
            this.Controls.Add(this.b12);
            this.Controls.Add(this.GridWorklog);
            this.Controls.Add(this.GridProjects);
            this.Controls.Add(this.GridEmployees);
            this.Controls.Add(this.b11);
            this.Controls.Add(this.b10);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Name = "AZD";
            this.Text = "AZD";
            ((System.ComponentModel.ISupportInitialize)(this.GridEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridWorklog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b10;
        private System.Windows.Forms.Button b11;
        private System.Windows.Forms.DataGridView GridEmployees;
        private System.Windows.Forms.DataGridView GridProjects;
        private System.Windows.Forms.DataGridView GridWorklog;
        private System.Windows.Forms.Button b12;
        private System.Windows.Forms.Button b13;
    }
}