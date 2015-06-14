namespace Final_Rezerwacja_Hotelowa
{
    partial class ReserveFormular
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
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.Tick_label = new System.Windows.Forms.Label();
            this.Check = new System.Windows.Forms.Button();
            this.MakeAcc = new System.Windows.Forms.Button();
            this.NewAcc_rbutton = new System.Windows.Forms.RadioButton();
            this.ExistAcc_rbutton = new System.Windows.Forms.RadioButton();
            this.Reserve = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Login_box = new System.Windows.Forms.TextBox();
            this.Torez_box = new System.Windows.Forms.TextBox();
            this.fromrez_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numroom_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(66, 137);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 44;
            this.monthCalendar2.Visible = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(258, 137);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 42;
            this.monthCalendar1.Visible = false;
            // 
            // Tick_label
            // 
            this.Tick_label.Location = new System.Drawing.Point(341, 202);
            this.Tick_label.Name = "Tick_label";
            this.Tick_label.Size = new System.Drawing.Size(31, 18);
            this.Tick_label.TabIndex = 41;
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(377, 201);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(75, 23);
            this.Check.TabIndex = 40;
            this.Check.Text = "Check";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // MakeAcc
            // 
            this.MakeAcc.Location = new System.Drawing.Point(21, 202);
            this.MakeAcc.Name = "MakeAcc";
            this.MakeAcc.Size = new System.Drawing.Size(105, 21);
            this.MakeAcc.TabIndex = 39;
            this.MakeAcc.Text = "Stwórz konto";
            this.MakeAcc.UseVisualStyleBackColor = true;
            this.MakeAcc.Click += new System.EventHandler(this.MakeAcc_Click);
            // 
            // NewAcc_rbutton
            // 
            this.NewAcc_rbutton.AutoSize = true;
            this.NewAcc_rbutton.CausesValidation = false;
            this.NewAcc_rbutton.Checked = true;
            this.NewAcc_rbutton.Location = new System.Drawing.Point(21, 169);
            this.NewAcc_rbutton.Name = "NewAcc_rbutton";
            this.NewAcc_rbutton.Size = new System.Drawing.Size(96, 17);
            this.NewAcc_rbutton.TabIndex = 38;
            this.NewAcc_rbutton.TabStop = true;
            this.NewAcc_rbutton.Text = "Nie mam konta";
            this.NewAcc_rbutton.UseVisualStyleBackColor = true;
            // 
            // ExistAcc_rbutton
            // 
            this.ExistAcc_rbutton.AutoSize = true;
            this.ExistAcc_rbutton.CausesValidation = false;
            this.ExistAcc_rbutton.Location = new System.Drawing.Point(235, 169);
            this.ExistAcc_rbutton.Name = "ExistAcc_rbutton";
            this.ExistAcc_rbutton.Size = new System.Drawing.Size(78, 17);
            this.ExistAcc_rbutton.TabIndex = 37;
            this.ExistAcc_rbutton.Text = "Mam konto";
            this.ExistAcc_rbutton.UseVisualStyleBackColor = true;
            // 
            // Reserve
            // 
            this.Reserve.Location = new System.Drawing.Point(272, 286);
            this.Reserve.Name = "Reserve";
            this.Reserve.Size = new System.Drawing.Size(75, 23);
            this.Reserve.TabIndex = 36;
            this.Reserve.Text = "OK";
            this.Reserve.UseVisualStyleBackColor = true;
            this.Reserve.Click += new System.EventHandler(this.Reserve_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(101, 286);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 35;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Do";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Rezerwacja Od";
            // 
            // Login_box
            // 
            this.Login_box.Location = new System.Drawing.Point(235, 202);
            this.Login_box.Name = "Login_box";
            this.Login_box.Size = new System.Drawing.Size(100, 20);
            this.Login_box.TabIndex = 31;
            // 
            // Torez_box
            // 
            this.Torez_box.Location = new System.Drawing.Point(258, 118);
            this.Torez_box.Name = "Torez_box";
            this.Torez_box.Size = new System.Drawing.Size(100, 20);
            this.Torez_box.TabIndex = 30;
            // 
            // fromrez_box
            // 
            this.fromrez_box.Location = new System.Drawing.Point(101, 118);
            this.fromrez_box.Name = "fromrez_box";
            this.fromrez_box.Size = new System.Drawing.Size(100, 20);
            this.fromrez_box.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Numer Pokoju";
            // 
            // numroom_box
            // 
            this.numroom_box.Location = new System.Drawing.Point(101, 74);
            this.numroom_box.Name = "numroom_box";
            this.numroom_box.Size = new System.Drawing.Size(100, 20);
            this.numroom_box.TabIndex = 28;
            // 
            // ReservationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 382);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.Tick_label);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.MakeAcc);
            this.Controls.Add(this.NewAcc_rbutton);
            this.Controls.Add(this.ExistAcc_rbutton);
            this.Controls.Add(this.Reserve);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Login_box);
            this.Controls.Add(this.Torez_box);
            this.Controls.Add(this.fromrez_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numroom_box);
            this.Name = "ReservationPanel";
            this.Text = "ReservationPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label Tick_label;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.Button MakeAcc;
        private System.Windows.Forms.RadioButton NewAcc_rbutton;
        private System.Windows.Forms.RadioButton ExistAcc_rbutton;
        private System.Windows.Forms.Button Reserve;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Login_box;
        private System.Windows.Forms.TextBox Torez_box;
        private System.Windows.Forms.TextBox fromrez_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numroom_box;
    }
}