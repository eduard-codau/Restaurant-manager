
namespace restaurantInterf
{
    partial class FormUserView
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
            this.tables1 = new restaurantInterf.DashboardTables();
            this.userWelcome1 = new restaurantInterf.DashboardControls.DashboardUserWelcome();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonRestaurant = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tables1
            // 
            this.tables1.BackColor = System.Drawing.Color.LightGray;
            this.tables1.Location = new System.Drawing.Point(164, 10);
            this.tables1.Name = "tables1";
            this.tables1.Size = new System.Drawing.Size(1006, 704);
            this.tables1.TabIndex = 3;
            // 
            // userWelcome1
            // 
            this.userWelcome1.BackColor = System.Drawing.Color.White;
            this.userWelcome1.Location = new System.Drawing.Point(164, 10);
            this.userWelcome1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userWelcome1.Name = "userWelcome1";
            this.userWelcome1.Size = new System.Drawing.Size(1006, 704);
            this.userWelcome1.TabIndex = 1;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.Peru;
            this.buttonLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonLogOut.FlatAppearance.BorderSize = 0;
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLogOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLogOut.Location = new System.Drawing.Point(2, 676);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(148, 39);
            this.buttonLogOut.TabIndex = 1;
            this.buttonLogOut.Text = "LogOut";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonRestaurant
            // 
            this.buttonRestaurant.BackColor = System.Drawing.Color.Peru;
            this.buttonRestaurant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonRestaurant.FlatAppearance.BorderSize = 0;
            this.buttonRestaurant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRestaurant.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRestaurant.Location = new System.Drawing.Point(2, 25);
            this.buttonRestaurant.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRestaurant.Name = "buttonRestaurant";
            this.buttonRestaurant.Size = new System.Drawing.Size(148, 39);
            this.buttonRestaurant.TabIndex = 0;
            this.buttonRestaurant.Text = "Restaurant";
            this.buttonRestaurant.UseVisualStyleBackColor = false;
            this.buttonRestaurant.Click += new System.EventHandler(this.buttonRestaurant_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.buttonHelp);
            this.panel1.Controls.Add(this.buttonRestaurant);
            this.panel1.Controls.Add(this.buttonLogOut);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 715);
            this.panel1.TabIndex = 0;
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.Peru;
            this.buttonHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonHelp.FlatAppearance.BorderSize = 0;
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonHelp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonHelp.Location = new System.Drawing.Point(2, 630);
            this.buttonHelp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(148, 39);
            this.buttonHelp.TabIndex = 2;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // FormUserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1214, 734);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tables1);
            this.Controls.Add(this.userWelcome1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormUserView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserDashboard";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DashboardControls.DashboardUserWelcome userWelcome1;
        private DashboardTables tables1;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonRestaurant;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonHelp;
    }
}