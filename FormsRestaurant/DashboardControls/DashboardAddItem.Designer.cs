
namespace restaurantInterf.DashboardControls
{
    partial class DashboardAddItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.textBoxItemName = new System.Windows.Forms.TextBox();
            this.textBoxItemPrice = new System.Windows.Forms.TextBox();
            this.comboBoxMasura = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxGramaj = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(175, 496);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Preț";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(175, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nume produs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(175, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Categorie";
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.BackColor = System.Drawing.Color.Peru;
            this.buttonAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddItem.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddItem.Location = new System.Drawing.Point(606, 696);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(120, 49);
            this.buttonAddItem.TabIndex = 4;
            this.buttonAddItem.Text = "Adaugă";
            this.buttonAddItem.UseVisualStyleBackColor = false;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxCategory.ForeColor = System.Drawing.Color.Black;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Bautura",
            "Pizza"});
            this.comboBoxCategory.Location = new System.Drawing.Point(210, 309);
            this.comboBoxCategory.MaxDropDownItems = 20;
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(416, 33);
            this.comboBoxCategory.TabIndex = 5;
            this.comboBoxCategory.SelectedValueChanged += new System.EventHandler(this.comboBoxCategory_SelectedValueChanged);
            // 
            // textBoxItemName
            // 
            this.textBoxItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxItemName.ForeColor = System.Drawing.Color.Black;
            this.textBoxItemName.Location = new System.Drawing.Point(210, 440);
            this.textBoxItemName.Name = "textBoxItemName";
            this.textBoxItemName.Size = new System.Drawing.Size(416, 30);
            this.textBoxItemName.TabIndex = 6;
            // 
            // textBoxItemPrice
            // 
            this.textBoxItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxItemPrice.ForeColor = System.Drawing.Color.Black;
            this.textBoxItemPrice.Location = new System.Drawing.Point(210, 548);
            this.textBoxItemPrice.Name = "textBoxItemPrice";
            this.textBoxItemPrice.Size = new System.Drawing.Size(416, 30);
            this.textBoxItemPrice.TabIndex = 7;
            // 
            // comboBoxMasura
            // 
            this.comboBoxMasura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMasura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxMasura.ForeColor = System.Drawing.Color.Black;
            this.comboBoxMasura.FormattingEnabled = true;
            this.comboBoxMasura.Items.AddRange(new object[] {
            "Bautura",
            "Pizza"});
            this.comboBoxMasura.Location = new System.Drawing.Point(727, 309);
            this.comboBoxMasura.Name = "comboBoxMasura";
            this.comboBoxMasura.Size = new System.Drawing.Size(416, 33);
            this.comboBoxMasura.TabIndex = 9;
            this.comboBoxMasura.SelectedValueChanged += new System.EventHandler(this.comboBoxMasura_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(692, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 33);
            this.label5.TabIndex = 8;
            this.label5.Text = "Măsura";
            // 
            // textBoxGramaj
            // 
            this.textBoxGramaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxGramaj.ForeColor = System.Drawing.Color.Black;
            this.textBoxGramaj.Location = new System.Drawing.Point(727, 440);
            this.textBoxGramaj.Name = "textBoxGramaj";
            this.textBoxGramaj.Size = new System.Drawing.Size(416, 30);
            this.textBoxGramaj.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(692, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 33);
            this.label6.TabIndex = 10;
            this.label6.Text = "Gramaj";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(29, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 42);
            this.label7.TabIndex = 12;
            this.label7.Text = "Adaugă Produs";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DashboardAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxGramaj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxMasura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxItemPrice);
            this.Controls.Add(this.textBoxItemName);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.buttonAddItem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "DashboardAddItem";
            this.Size = new System.Drawing.Size(1347, 880);
            this.Load += new System.EventHandler(this.AddItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.TextBox textBoxItemName;
        private System.Windows.Forms.TextBox textBoxItemPrice;
        private System.Windows.Forms.ComboBox comboBoxMasura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxGramaj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
