﻿namespace Final_Rezerwacja_Hotelowa
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
            this.label1 = new System.Windows.Forms.Label();
            this.numroom_box = new System.Windows.Forms.TextBox();
            this.datefrom = new System.Windows.Forms.DateTimePicker();
            this.dateto = new System.Windows.Forms.DateTimePicker();
            this.Tick_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(458, 259);
            this.Check.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(112, 32);
            this.Check.TabIndex = 40;
            this.Check.Text = "Check";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // MakeAcc
            // 
            this.MakeAcc.Location = new System.Drawing.Point(27, 261);
            this.MakeAcc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MakeAcc.Name = "MakeAcc";
            this.MakeAcc.Size = new System.Drawing.Size(158, 29);
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
            this.NewAcc_rbutton.Location = new System.Drawing.Point(27, 217);
            this.NewAcc_rbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewAcc_rbutton.Name = "NewAcc_rbutton";
            this.NewAcc_rbutton.Size = new System.Drawing.Size(127, 22);
            this.NewAcc_rbutton.TabIndex = 38;
            this.NewAcc_rbutton.TabStop = true;
            this.NewAcc_rbutton.Text = "Nie mam konta";
            this.NewAcc_rbutton.UseVisualStyleBackColor = true;
            this.NewAcc_rbutton.CheckedChanged += new System.EventHandler(this.NewAcc_rbutton_CheckedChanged);
            // 
            // ExistAcc_rbutton
            // 
            this.ExistAcc_rbutton.AutoSize = true;
            this.ExistAcc_rbutton.CausesValidation = false;
            this.ExistAcc_rbutton.Location = new System.Drawing.Point(285, 217);
            this.ExistAcc_rbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ExistAcc_rbutton.Name = "ExistAcc_rbutton";
            this.ExistAcc_rbutton.Size = new System.Drawing.Size(102, 22);
            this.ExistAcc_rbutton.TabIndex = 37;
            this.ExistAcc_rbutton.Text = "Mam konto";
            this.ExistAcc_rbutton.UseVisualStyleBackColor = true;
            this.ExistAcc_rbutton.CheckedChanged += new System.EventHandler(this.ExistAcc_rbutton_CheckedChanged);
            // 
            // Reserve
            // 
            this.Reserve.Location = new System.Drawing.Point(392, 324);
            this.Reserve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Reserve.Name = "Reserve";
            this.Reserve.Size = new System.Drawing.Size(135, 48);
            this.Reserve.TabIndex = 36;
            this.Reserve.Text = "OK";
            this.Reserve.UseVisualStyleBackColor = true;
            this.Reserve.Click += new System.EventHandler(this.Reserve_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(134, 324);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(135, 48);
            this.Cancel.TabIndex = 35;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(215, 269);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 18);
            this.label7.TabIndex = 34;
            this.label7.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "Rezerwacja do";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 32;
            this.label2.Text = "Rezerwacja od";
            // 
            // Login_box
            // 
            this.Login_box.Location = new System.Drawing.Point(285, 263);
            this.Login_box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Login_box.Name = "Login_box";
            this.Login_box.Size = new System.Drawing.Size(148, 24);
            this.Login_box.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 29;
            this.label1.Text = "Numer pokoju";
            // 
            // numroom_box
            // 
            this.numroom_box.Location = new System.Drawing.Point(153, 41);
            this.numroom_box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numroom_box.Name = "numroom_box";
            this.numroom_box.Size = new System.Drawing.Size(148, 24);
            this.numroom_box.TabIndex = 28;
            // 
            // datefrom
            // 
            this.datefrom.Location = new System.Drawing.Point(153, 100);
            this.datefrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datefrom.Name = "datefrom";
            this.datefrom.Size = new System.Drawing.Size(195, 24);
            this.datefrom.TabIndex = 45;
            // 
            // dateto
            // 
            this.dateto.Location = new System.Drawing.Point(153, 149);
            this.dateto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateto.Name = "dateto";
            this.dateto.Size = new System.Drawing.Size(195, 24);
            this.dateto.TabIndex = 46;
            // 
            // Tick_label
            // 
            this.Tick_label.Location = new System.Drawing.Point(578, 263);
            this.Tick_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Tick_label.Name = "Tick_label";
            this.Tick_label.Size = new System.Drawing.Size(46, 25);
            this.Tick_label.TabIndex = 41;
            // 
            // ReserveFormular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 385);
            this.Controls.Add(this.dateto);
            this.Controls.Add(this.datefrom);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numroom_box);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReserveFormular";
            this.Text = "ReservationPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numroom_box;
        private System.Windows.Forms.DateTimePicker datefrom;
        private System.Windows.Forms.DateTimePicker dateto;
        private System.Windows.Forms.Label Tick_label;
    }
}