namespace Final_Rezerwacja_Hotelowa
{
    partial class LoginPanel
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
            this.cancel_button = new System.Windows.Forms.Button();
            this.login_button = new System.Windows.Forms.Button();
            this.password_box = new System.Windows.Forms.TextBox();
            this.login_box = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.login_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancel_button
            // 
            this.cancel_button.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cancel_button.Location = new System.Drawing.Point(232, 124);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 11;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // login_button
            // 
            this.login_button.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.login_button.AllowDrop = true;
            this.login_button.Location = new System.Drawing.Point(58, 124);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(75, 23);
            this.login_button.TabIndex = 10;
            this.login_button.Text = "Log in";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // password_box
            // 
            this.password_box.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.password_box.Location = new System.Drawing.Point(146, 78);
            this.password_box.Name = "password_box";
            this.password_box.PasswordChar = '*';
            this.password_box.Size = new System.Drawing.Size(161, 20);
            this.password_box.TabIndex = 9;
            // 
            // login_box
            // 
            this.login_box.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.login_box.Location = new System.Drawing.Point(146, 38);
            this.login_box.Name = "login_box";
            this.login_box.Size = new System.Drawing.Size(161, 20);
            this.login_box.TabIndex = 8;
            // 
            // password_label
            // 
            this.password_label.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(60, 78);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(56, 13);
            this.password_label.TabIndex = 7;
            this.password_label.Text = "Password:";
            // 
            // login_label
            // 
            this.login_label.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.login_label.Location = new System.Drawing.Point(60, 38);
            this.login_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(47, 17);
            this.login_label.TabIndex = 6;
            this.login_label.Text = "Login:";
            // 
            // LoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 185);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.login_box);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.login_label);
            this.Name = "LoginPanel";
            this.Text = "LoginPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.TextBox login_box;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label login_label;
    }
}