namespace Olympiad_5._0.Adding
{
    partial class AddOlympicGames
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
            this.Add = new System.Windows.Forms.Button();
            this.AddSport = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddCountry = new System.Windows.Forms.TextBox();
            this.AddCity = new System.Windows.Forms.Label();
            this.AddCountry1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddYear = new System.Windows.Forms.TextBox();
            this.IsWinter = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(61, 288);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(101, 43);
            this.Add.TabIndex = 17;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // AddSport
            // 
            this.AddSport.Location = new System.Drawing.Point(12, 262);
            this.AddSport.Name = "AddSport";
            this.AddSport.Size = new System.Drawing.Size(204, 20);
            this.AddSport.TabIndex = 16;
            this.AddSport.TextChanged += new System.EventHandler(this.AddSport_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Sport Type:";
            // 
            // AddCountry
            // 
            this.AddCountry.Location = new System.Drawing.Point(12, 205);
            this.AddCountry.Name = "AddCountry";
            this.AddCountry.Size = new System.Drawing.Size(204, 20);
            this.AddCountry.TabIndex = 14;
            this.AddCountry.TextChanged += new System.EventHandler(this.AddCountry_TextChanged);
            // 
            // AddCity
            // 
            this.AddCity.AutoSize = true;
            this.AddCity.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCity.Location = new System.Drawing.Point(9, 187);
            this.AddCity.Name = "AddCity";
            this.AddCity.Size = new System.Drawing.Size(42, 15);
            this.AddCity.TabIndex = 13;
            this.AddCity.Text = "City:";
            // 
            // AddCountry1
            // 
            this.AddCountry1.Location = new System.Drawing.Point(12, 152);
            this.AddCountry1.Name = "AddCountry1";
            this.AddCountry1.Size = new System.Drawing.Size(204, 20);
            this.AddCountry1.TabIndex = 12;
            this.AddCountry1.TextChanged += new System.EventHandler(this.AddCountry1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Country:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Year:";
            // 
            // AddYear
            // 
            this.AddYear.Location = new System.Drawing.Point(15, 54);
            this.AddYear.Name = "AddYear";
            this.AddYear.Size = new System.Drawing.Size(204, 20);
            this.AddYear.TabIndex = 9;
            this.AddYear.TextChanged += new System.EventHandler(this.AddYear_TextChanged);
            // 
            // IsWinter
            // 
            this.IsWinter.AutoSize = true;
            this.IsWinter.Location = new System.Drawing.Point(15, 96);
            this.IsWinter.Name = "IsWinter";
            this.IsWinter.Size = new System.Drawing.Size(65, 17);
            this.IsWinter.TabIndex = 18;
            this.IsWinter.Text = "IsWinter";
            this.IsWinter.UseVisualStyleBackColor = true;
            this.IsWinter.CheckedChanged += new System.EventHandler(this.IsWinter_CheckedChanged);
            // 
            // AddOlympicGames
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(232, 358);
            this.Controls.Add(this.IsWinter);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.AddSport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AddCountry);
            this.Controls.Add(this.AddCity);
            this.Controls.Add(this.AddCountry1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddYear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddOlympicGames";
            this.Text = "OlympicGames";
            this.Load += new System.EventHandler(this.OlympicGames_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox AddSport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AddCountry;
        private System.Windows.Forms.Label AddCity;
        private System.Windows.Forms.TextBox AddCountry1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddYear;
        private System.Windows.Forms.CheckBox IsWinter;
    }
}