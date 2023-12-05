namespace Olympiad_5._0.Adding
{
    partial class AddCountryMedalStandings
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
            this.AddCountry = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddBronze = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddSilver = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddGold = new System.Windows.Forms.TextBox();
            this.AddGame = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(66, 290);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(101, 43);
            this.Add.TabIndex = 17;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // AddCountry
            // 
            this.AddCountry.Location = new System.Drawing.Point(15, 207);
            this.AddCountry.Name = "AddCountry";
            this.AddCountry.Size = new System.Drawing.Size(204, 20);
            this.AddCountry.TabIndex = 16;
            this.AddCountry.TextChanged += new System.EventHandler(this.AddCountry_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Country(Id):";
            // 
            // AddBronze
            // 
            this.AddBronze.Location = new System.Drawing.Point(15, 147);
            this.AddBronze.Name = "AddBronze";
            this.AddBronze.Size = new System.Drawing.Size(204, 20);
            this.AddBronze.TabIndex = 14;
            this.AddBronze.TextChanged += new System.EventHandler(this.AddBronze_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Bronze:";
            // 
            // AddSilver
            // 
            this.AddSilver.Location = new System.Drawing.Point(15, 84);
            this.AddSilver.Name = "AddSilver";
            this.AddSilver.Size = new System.Drawing.Size(204, 20);
            this.AddSilver.TabIndex = 12;
            this.AddSilver.TextChanged += new System.EventHandler(this.AddSilver_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Silver:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Gold:";
            // 
            // AddGold
            // 
            this.AddGold.Location = new System.Drawing.Point(15, 27);
            this.AddGold.Name = "AddGold";
            this.AddGold.Size = new System.Drawing.Size(204, 20);
            this.AddGold.TabIndex = 9;
            this.AddGold.TextChanged += new System.EventHandler(this.AddGold_TextChanged);
            // 
            // AddGame
            // 
            this.AddGame.Location = new System.Drawing.Point(15, 264);
            this.AddGame.Name = "AddGame";
            this.AddGame.Size = new System.Drawing.Size(204, 20);
            this.AddGame.TabIndex = 19;
            this.AddGame.TextChanged += new System.EventHandler(this.AddGame_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "OlympicGame(Id):";
            // 
            // AddCountryMedalStandings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(234, 353);
            this.Controls.Add(this.AddGame);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.AddCountry);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AddBronze);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddSilver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddGold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCountryMedalStandings";
            this.Text = "CountryMedalStandings";
            this.Load += new System.EventHandler(this.CountryMedalStandings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox AddCountry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AddBronze;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddSilver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddGold;
        private System.Windows.Forms.TextBox AddGame;
        private System.Windows.Forms.Label label5;
    }
}