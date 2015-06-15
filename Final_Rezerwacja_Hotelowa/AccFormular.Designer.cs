namespace Final_Rezerwacja_Hotelowa
{
    partial class AccFormular
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
            this.Cancel_button = new System.Windows.Forms.Button();
            this.create_button = new System.Windows.Forms.Button();
            this.Pesel_box = new System.Windows.Forms.TextBox();
            this.Login_box = new System.Windows.Forms.TextBox();
            this.Nazwisko_box = new System.Windows.Forms.TextBox();
            this.Imie_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Adres = new System.Windows.Forms.Label();
            this.Adres_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(99, 211);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_button.TabIndex = 19;
            this.Cancel_button.Text = "Anuluj";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // create_button
            // 
            this.create_button.Location = new System.Drawing.Point(301, 211);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(75, 23);
            this.create_button.TabIndex = 18;
            this.create_button.Text = "Stwórz";
            this.create_button.UseVisualStyleBackColor = true;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // Pesel_box
            // 
            this.Pesel_box.Location = new System.Drawing.Point(80, 78);
            this.Pesel_box.Name = "Pesel_box";
            this.Pesel_box.Size = new System.Drawing.Size(135, 20);
            this.Pesel_box.TabIndex = 17;
            // 
            // Login_box
            // 
            this.Login_box.Location = new System.Drawing.Point(321, 78);
            this.Login_box.Name = "Login_box";
            this.Login_box.Size = new System.Drawing.Size(131, 20);
            this.Login_box.TabIndex = 16;
            // 
            // Nazwisko_box
            // 
            this.Nazwisko_box.Location = new System.Drawing.Point(321, 26);
            this.Nazwisko_box.Name = "Nazwisko_box";
            this.Nazwisko_box.Size = new System.Drawing.Size(131, 20);
            this.Nazwisko_box.TabIndex = 15;
            // 
            // Imie_box
            // 
            this.Imie_box.Location = new System.Drawing.Point(80, 26);
            this.Imie_box.Name = "Imie_box";
            this.Imie_box.Size = new System.Drawing.Size(135, 20);
            this.Imie_box.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Pesel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nazwisko";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Imie";
            // 
            // Adres
            // 
            this.Adres.AutoSize = true;
            this.Adres.Location = new System.Drawing.Point(24, 122);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(102, 13);
            this.Adres.TabIndex = 20;
            this.Adres.Text = "Adres Zamieszkania";
            // 
            // Adres_box
            // 
            this.Adres_box.Location = new System.Drawing.Point(80, 149);
            this.Adres_box.Name = "Adres_box";
            this.Adres_box.Size = new System.Drawing.Size(229, 20);
            this.Adres_box.TabIndex = 21;
            // 
            // AccFormular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 296);
            this.Controls.Add(this.Adres_box);
            this.Controls.Add(this.Adres);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.create_button);
            this.Controls.Add(this.Pesel_box);
            this.Controls.Add(this.Login_box);
            this.Controls.Add(this.Nazwisko_box);
            this.Controls.Add(this.Imie_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AccFormular";
            this.Text = "AccFormular";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.TextBox Pesel_box;
        private System.Windows.Forms.TextBox Login_box;
        private System.Windows.Forms.TextBox Nazwisko_box;
        private System.Windows.Forms.TextBox Imie_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Adres;
        private System.Windows.Forms.TextBox Adres_box;
    }
}