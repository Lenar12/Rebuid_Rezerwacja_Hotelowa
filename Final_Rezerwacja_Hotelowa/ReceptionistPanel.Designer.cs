namespace Final_Rezerwacja_Hotelowa
{
    partial class ReceptionistPanel
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
            this.components = new System.ComponentModel.Container();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ChooseUser = new System.Windows.Forms.Button();
            this.NewUser = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Logout = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Details = new System.Windows.Forms.Button();
            this.ReserveRoom = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            //
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ChooseUser);
            this.tabPage2.Controls.Add(this.NewUser);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(740, 362);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Użytkownicy";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ChooseUser
            // 
            this.ChooseUser.Location = new System.Drawing.Point(242, 307);
            this.ChooseUser.Name = "ChooseUser";
            this.ChooseUser.Size = new System.Drawing.Size(177, 40);
            this.ChooseUser.TabIndex = 2;
            this.ChooseUser.Text = "Wybierz użytkownika";
            this.ChooseUser.UseVisualStyleBackColor = true;
            this.ChooseUser.Click += new System.EventHandler(this.ChooseUser_Click);
            // 
            // NewUser
            // 
            this.NewUser.Location = new System.Drawing.Point(24, 307);
            this.NewUser.Name = "NewUser";
            this.NewUser.Size = new System.Drawing.Size(174, 41);
            this.NewUser.TabIndex = 1;
            this.NewUser.Text = "Nowy użytkownik";
            this.NewUser.UseVisualStyleBackColor = true;
            this.NewUser.Click += new System.EventHandler(this.NewUser_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(735, 285);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.Details);
            this.tabPage1.Controls.Add(this.ReserveRoom);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(740, 362);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pokoje";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(722, 193);
            this.dataGridView1.TabIndex = 0;
            // 
            // Details
            // 
            this.Details.Location = new System.Drawing.Point(246, 221);
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(175, 36);
            this.Details.TabIndex = 8;
            this.Details.Text = "Więcej informacji";
            this.Details.UseVisualStyleBackColor = true;
            this.Details.Click += new System.EventHandler(this.Details_Click);
            // 
            // ReserveRoom
            // 
            this.ReserveRoom.Location = new System.Drawing.Point(39, 221);
            this.ReserveRoom.Name = "ReserveRoom";
            this.ReserveRoom.Size = new System.Drawing.Size(172, 36);
            this.ReserveRoom.TabIndex = 7;
            this.ReserveRoom.Text = "Rezerwuj pokoj";
            this.ReserveRoom.UseVisualStyleBackColor = true;
            this.ReserveRoom.Click += new System.EventHandler(this.ReserveRoom_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(748, 388);
            this.tabControl1.TabIndex = 10;
            // 
            // ReceptionistPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 407);
            this.Controls.Add(this.tabControl1);
            this.Name = "ReceptionistPanel";
            this.Text = "ReceptionistPanel";
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

     
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button ChooseUser;
        private System.Windows.Forms.Button NewUser;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Details;
        private System.Windows.Forms.Button ReserveRoom;
        private System.Windows.Forms.TabControl tabControl1;

    }
}