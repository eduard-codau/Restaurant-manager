
namespace restaurantInterf
{
    partial class FormAdminView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonUsersManager = new System.Windows.Forms.Button();
            this.buttonCategoryManager = new System.Windows.Forms.Button();
            this.buttonDeleteItem = new System.Windows.Forms.Button();
            this.buttonUpdateItem = new System.Windows.Forms.Button();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.removeItem1 = new restaurantInterf.DashboardControls.DashboardRemoveItem();
            this.updateItem1 = new restaurantInterf.DashboardControls.DashboardUpdateItem();
            this.categoryOperations1 = new restaurantInterf.DashboardControls.DashboardCategoryOperations();
            this.addItem1 = new restaurantInterf.DashboardControls.DashboardAddItem();
            this.userWelcome1 = new restaurantInterf.DashboardControls.DashboardUserWelcome();
            this.usersOperations1 = new restaurantInterf.DashboardControls.DashboardUsersOperations();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.buttonHelp);
            this.panel1.Controls.Add(this.buttonUsersManager);
            this.panel1.Controls.Add(this.buttonCategoryManager);
            this.panel1.Controls.Add(this.buttonDeleteItem);
            this.panel1.Controls.Add(this.buttonUpdateItem);
            this.panel1.Controls.Add(this.buttonAddItem);
            this.panel1.Controls.Add(this.buttonLogOut);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 715);
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
            this.buttonHelp.Location = new System.Drawing.Point(10, 630);
            this.buttonHelp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(148, 39);
            this.buttonHelp.TabIndex = 9;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonUsersManager
            // 
            this.buttonUsersManager.BackColor = System.Drawing.Color.Peru;
            this.buttonUsersManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonUsersManager.FlatAppearance.BorderSize = 0;
            this.buttonUsersManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsersManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUsersManager.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonUsersManager.Location = new System.Drawing.Point(2, 275);
            this.buttonUsersManager.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUsersManager.Name = "buttonUsersManager";
            this.buttonUsersManager.Size = new System.Drawing.Size(156, 39);
            this.buttonUsersManager.TabIndex = 7;
            this.buttonUsersManager.Text = "Manager Utilizatori";
            this.buttonUsersManager.UseVisualStyleBackColor = false;
            this.buttonUsersManager.Click += new System.EventHandler(this.buttonUsersManager_Click);
            // 
            // buttonCategoryManager
            // 
            this.buttonCategoryManager.BackColor = System.Drawing.Color.Peru;
            this.buttonCategoryManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCategoryManager.FlatAppearance.BorderSize = 0;
            this.buttonCategoryManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCategoryManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCategoryManager.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCategoryManager.Location = new System.Drawing.Point(10, 15);
            this.buttonCategoryManager.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCategoryManager.Name = "buttonCategoryManager";
            this.buttonCategoryManager.Size = new System.Drawing.Size(148, 39);
            this.buttonCategoryManager.TabIndex = 6;
            this.buttonCategoryManager.Text = "Manager Categorii";
            this.buttonCategoryManager.UseVisualStyleBackColor = false;
            this.buttonCategoryManager.Click += new System.EventHandler(this.buttonModifyCategory_Click);
            // 
            // buttonDeleteItem
            // 
            this.buttonDeleteItem.BackColor = System.Drawing.Color.Peru;
            this.buttonDeleteItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonDeleteItem.FlatAppearance.BorderSize = 0;
            this.buttonDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDeleteItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDeleteItem.Location = new System.Drawing.Point(10, 210);
            this.buttonDeleteItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDeleteItem.Name = "buttonDeleteItem";
            this.buttonDeleteItem.Size = new System.Drawing.Size(141, 39);
            this.buttonDeleteItem.TabIndex = 4;
            this.buttonDeleteItem.Text = "Șterge Produs";
            this.buttonDeleteItem.UseVisualStyleBackColor = false;
            this.buttonDeleteItem.Click += new System.EventHandler(this.buttonDeleteItem_Click);
            // 
            // buttonUpdateItem
            // 
            this.buttonUpdateItem.BackColor = System.Drawing.Color.Peru;
            this.buttonUpdateItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonUpdateItem.FlatAppearance.BorderSize = 0;
            this.buttonUpdateItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUpdateItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonUpdateItem.Location = new System.Drawing.Point(10, 145);
            this.buttonUpdateItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUpdateItem.Name = "buttonUpdateItem";
            this.buttonUpdateItem.Size = new System.Drawing.Size(141, 46);
            this.buttonUpdateItem.TabIndex = 3;
            this.buttonUpdateItem.Text = "Update Produs";
            this.buttonUpdateItem.UseVisualStyleBackColor = false;
            this.buttonUpdateItem.Click += new System.EventHandler(this.buttonUpdateItem_Click);
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.BackColor = System.Drawing.Color.Peru;
            this.buttonAddItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAddItem.FlatAppearance.BorderSize = 0;
            this.buttonAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAddItem.Location = new System.Drawing.Point(10, 80);
            this.buttonAddItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(141, 39);
            this.buttonAddItem.TabIndex = 2;
            this.buttonAddItem.Text = "Adaugă Produs";
            this.buttonAddItem.UseVisualStyleBackColor = false;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItemMenu_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.Peru;
            this.buttonLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonLogOut.FlatAppearance.BorderSize = 0;
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLogOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLogOut.Location = new System.Drawing.Point(10, 674);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(148, 39);
            this.buttonLogOut.TabIndex = 1;
            this.buttonLogOut.Text = "LogOut";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // removeItem1
            // 
            this.removeItem1.BackColor = System.Drawing.Color.White;
            this.removeItem1.Location = new System.Drawing.Point(182, 10);
            this.removeItem1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.removeItem1.Name = "removeItem1";
            this.removeItem1.Size = new System.Drawing.Size(1010, 715);
            this.removeItem1.TabIndex = 6;
            // 
            // updateItem1
            // 
            this.updateItem1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.updateItem1.BackColor = System.Drawing.Color.White;
            this.updateItem1.Location = new System.Drawing.Point(182, 11);
            this.updateItem1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateItem1.Name = "updateItem1";
            this.updateItem1.Size = new System.Drawing.Size(1010, 715);
            this.updateItem1.TabIndex = 5;
            // 
            // categoryOperations1
            // 
            this.categoryOperations1.BackColor = System.Drawing.Color.White;
            this.categoryOperations1.Location = new System.Drawing.Point(182, 11);
            this.categoryOperations1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.categoryOperations1.Name = "categoryOperations1";
            this.categoryOperations1.Size = new System.Drawing.Size(1010, 715);
            this.categoryOperations1.TabIndex = 4;
            // 
            // addItem1
            // 
            this.addItem1.BackColor = System.Drawing.Color.White;
            this.addItem1.Location = new System.Drawing.Point(181, 10);
            this.addItem1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addItem1.Name = "addItem1";
            this.addItem1.Size = new System.Drawing.Size(1010, 715);
            this.addItem1.TabIndex = 2;
            // 
            // userWelcome1
            // 
            this.userWelcome1.BackColor = System.Drawing.Color.White;
            this.userWelcome1.Location = new System.Drawing.Point(181, 10);
            this.userWelcome1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userWelcome1.Name = "userWelcome1";
            this.userWelcome1.Size = new System.Drawing.Size(1010, 715);
            this.userWelcome1.TabIndex = 1;
            // 
            // usersOperations1
            // 
            this.usersOperations1.BackColor = System.Drawing.Color.White;
            this.usersOperations1.Location = new System.Drawing.Point(182, 11);
            this.usersOperations1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usersOperations1.Name = "usersOperations1";
            this.usersOperations1.Size = new System.Drawing.Size(1010, 715);
            this.usersOperations1.TabIndex = 7;
            // 
            // FormAdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1200, 734);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userWelcome1);
            this.Controls.Add(this.usersOperations1);
            this.Controls.Add(this.removeItem1);
            this.Controls.Add(this.updateItem1);
            this.Controls.Add(this.categoryOperations1);
            this.Controls.Add(this.addItem1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAdminView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserDashboard";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonAddItem;
        private DashboardControls.DashboardUserWelcome userWelcome1;
        private DashboardControls.DashboardAddItem addItem1;
        private System.Windows.Forms.Button buttonCategoryManager;
        private System.Windows.Forms.Button buttonDeleteItem;
        private System.Windows.Forms.Button buttonUpdateItem;
        private DashboardControls.DashboardCategoryOperations categoryOperations1;
        private System.Windows.Forms.Button buttonUsersManager;
        private DashboardControls.DashboardUsersOperations usersOperations1;

        public DashboardControls.DashboardUpdateItem updateItem1;
        private System.Windows.Forms.Button buttonHelp;
        public DashboardControls.DashboardRemoveItem removeItem1;
    }
}