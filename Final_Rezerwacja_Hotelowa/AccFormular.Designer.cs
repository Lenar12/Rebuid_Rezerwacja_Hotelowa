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
            this.Nazwisko_box = new System.Windows.Forms.TextBox();
            this.Imie_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Adres = new System.Windows.Forms.Label();
            this.Adres_Box = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(39, 292);
            this.Cancel_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(112, 32);
            this.Cancel_button.TabIndex = 19;
            this.Cancel_button.Text = "Anuluj";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // create_button
            // 
            this.create_button.Location = new System.Drawing.Point(227, 292);
            this.create_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(112, 32);
            this.create_button.TabIndex = 18;
            this.create_button.Text = "Stwórz";
            this.create_button.UseVisualStyleBackColor = true;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // Nazwisko_box
            // 
            this.Nazwisko_box.Location = new System.Drawing.Point(139, 76);
            this.Nazwisko_box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Nazwisko_box.Name = "Nazwisko_box";
            this.Nazwisko_box.Size = new System.Drawing.Size(200, 24);
            this.Nazwisko_box.TabIndex = 15;
            // 
            // Imie_box
            // 
            this.Imie_box.Location = new System.Drawing.Point(139, 34);
            this.Imie_box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Imie_box.Name = "Imie_box";
            this.Imie_box.Size = new System.Drawing.Size(200, 24);
            this.Imie_box.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nazwisko";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Imie";
            // 
            // Adres
            // 
            this.Adres.AutoSize = true;
            this.Adres.Location = new System.Drawing.Point(36, 124);
            this.Adres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(142, 18);
            this.Adres.TabIndex = 20;
            this.Adres.Text = "Adres Zamieszkania";
            // 
            // Adres_Box
            // 
            this.Adres_Box.Location = new System.Drawing.Point(39, 155);
            this.Adres_Box.Name = "Adres_Box";
            this.Adres_Box.Size = new System.Drawing.Size(300, 96);
            this.Adres_Box.TabIndex = 21;
            this.Adres_Box.Text = "";
            // 
            // AccFormular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 356);
            this.Controls.Add(this.Adres_Box);
            this.Controls.Add(this.Adres);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.create_button);
            this.Controls.Add(this.Nazwisko_box);
            this.Controls.Add(this.Imie_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AccFormular";
            this.Text = "AccFormular";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.TextBox Nazwisko_box;
        private System.Windows.Forms.TextBox Imie_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Adres;
        private System.Windows.Forms.RichTextBox Adres_Box;
    }
}