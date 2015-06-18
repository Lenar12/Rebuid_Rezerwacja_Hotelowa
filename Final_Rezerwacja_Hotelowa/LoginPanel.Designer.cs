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
            this.cancel_button.Location = new System.Drawing.Point(206, 134);
            this.cancel_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(112, 32);
            this.cancel_button.TabIndex = 11;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // login_button
            // 
            this.login_button.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.login_button.AllowDrop = true;
            this.login_button.Location = new System.Drawing.Point(32, 134);
            this.login_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(112, 32);
            this.login_button.TabIndex = 10;
            this.login_button.Text = "Log in";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // password_box
            // 
            this.password_box.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.password_box.Location = new System.Drawing.Point(116, 81);
            this.password_box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.password_box.Name = "password_box";
            this.password_box.PasswordChar = '*';
            this.password_box.Size = new System.Drawing.Size(202, 24);
            this.password_box.TabIndex = 9;
            // 
            // login_box
            // 
            this.login_box.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.login_box.Location = new System.Drawing.Point(116, 26);
            this.login_box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.login_box.Name = "login_box";
            this.login_box.Size = new System.Drawing.Size(202, 24);
            this.login_box.TabIndex = 8;
            // 
            // password_label
            // 
            this.password_label.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(29, 81);
            this.password_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(79, 18);
            this.password_label.TabIndex = 7;
            this.password_label.Text = "Password:";
            // 
            // login_label
            // 
            this.login_label.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.login_label.Location = new System.Drawing.Point(29, 26);
            this.login_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(47, 17);
            this.login_label.TabIndex = 6;
            this.login_label.Text = "Login:";
            // 
            // LoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 196);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.login_box);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.login_label);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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