
namespace restaurantInterf
{
    partial class FormAddItem
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
            this.buttonAddItemToList = new System.Windows.Forms.Button();
            this.buttonExitItemList = new System.Windows.Forms.Button();
            this.textBoxItemSearch = new System.Windows.Forms.TextBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownItemQuantity = new System.Windows.Forms.NumericUpDown();
            this.listBoxItems = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownItemQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddItemToList
            // 
            this.buttonAddItemToList.BackColor = System.Drawing.Color.Peru;
            this.buttonAddItemToList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddItemToList.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddItemToList.Location = new System.Drawing.Point(52, 456);
            this.buttonAddItemToList.Name = "buttonAddItemToList";
            this.buttonAddItemToList.Size = new System.Drawing.Size(98, 37);
            this.buttonAddItemToList.TabIndex = 32;
            this.buttonAddItemToList.Text = "OK";
            this.buttonAddItemToList.UseVisualStyleBackColor = false;
            this.buttonAddItemToList.Click += new System.EventHandler(this.buttonAddItemToList_Click);
            // 
            // buttonExitItemList
            // 
            this.buttonExitItemList.BackColor = System.Drawing.Color.Peru;
            this.buttonExitItemList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitItemList.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonExitItemList.Location = new System.Drawing.Point(310, 456);
            this.buttonExitItemList.Name = "buttonExitItemList";
            this.buttonExitItemList.Size = new System.Drawing.Size(98, 37);
            this.buttonExitItemList.TabIndex = 33;
            this.buttonExitItemList.Text = "Ieșire";
            this.buttonExitItemList.UseVisualStyleBackColor = false;
            this.buttonExitItemList.Click += new System.EventHandler(this.buttonExitItemList_Click);
            // 
            // textBoxItemSearch
            // 
            this.textBoxItemSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxItemSearch.ForeColor = System.Drawing.Color.Black;
            this.textBoxItemSearch.Location = new System.Drawing.Point(168, 87);
            this.textBoxItemSearch.Name = "textBoxItemSearch";
            this.textBoxItemSearch.Size = new System.Drawing.Size(240, 30);
            this.textBoxItemSearch.TabIndex = 37;
            this.textBoxItemSearch.TextChanged += new System.EventHandler(this.textBoxItemSearch_TextChanged);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxCategory.ForeColor = System.Drawing.Color.Black;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Bautura",
            "Pizza"});
            this.comboBoxCategory.Location = new System.Drawing.Point(168, 30);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(240, 33);
            this.comboBoxCategory.TabIndex = 36;
            this.comboBoxCategory.SelectedValueChanged += new System.EventHandler(this.comboBoxCategory_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(47, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 28);
            this.label4.TabIndex = 35;
            this.label4.Text = "Categorie:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(62, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 28);
            this.label3.TabIndex = 34;
            this.label3.Text = "Caută:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(47, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 28);
            this.label1.TabIndex = 38;
            this.label1.Text = "Cantitate:";
            // 
            // numericUpDownItemQuantity
            // 
            this.numericUpDownItemQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDownItemQuantity.Location = new System.Drawing.Point(168, 385);
            this.numericUpDownItemQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownItemQuantity.Name = "numericUpDownItemQuantity";
            this.numericUpDownItemQuantity.Size = new System.Drawing.Size(240, 30);
            this.numericUpDownItemQuantity.TabIndex = 40;
            this.numericUpDownItemQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // listBoxItems
            // 
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.ItemHeight = 16;
            this.listBoxItems.Location = new System.Drawing.Point(168, 156);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.Size = new System.Drawing.Size(240, 180);
            this.listBoxItems.TabIndex = 41;
            // 
            // FormAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(483, 525);
            this.Controls.Add(this.listBoxItems);
            this.Controls.Add(this.numericUpDownItemQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxItemSearch);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonExitItemList);
            this.Controls.Add(this.buttonAddItemToList);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddItemForm";
            this.Load += new System.EventHandler(this.AddItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownItemQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddItemToList;
        private System.Windows.Forms.Button buttonExitItemList;
        private System.Windows.Forms.TextBox textBoxItemSearch;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownItemQuantity;
        private System.Windows.Forms.ListBox listBoxItems;
    }
}