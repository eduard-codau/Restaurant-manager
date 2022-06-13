
namespace restaurantInterf.DashboardControls
{
    partial class DashboardUpdateItem
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearchUpdateItem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxGramaj = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxMasura = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxItemPrice = new System.Windows.Forms.TextBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.buttonUpdateItem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewUpdateItem = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpdateItem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(29, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Actualizare Produs";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxSearchUpdateItem
            // 
            this.textBoxSearchUpdateItem.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSearchUpdateItem.ForeColor = System.Drawing.Color.Black;
            this.textBoxSearchUpdateItem.Location = new System.Drawing.Point(934, 118);
            this.textBoxSearchUpdateItem.Name = "textBoxSearchUpdateItem";
            this.textBoxSearchUpdateItem.Size = new System.Drawing.Size(331, 35);
            this.textBoxSearchUpdateItem.TabIndex = 10;
            this.textBoxSearchUpdateItem.TextChanged += new System.EventHandler(this.textBoxSearchUpdateItem_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(751, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 33);
            this.label5.TabIndex = 9;
            this.label5.Text = "Caută Produs:";
            // 
            // textBoxGramaj
            // 
            this.textBoxGramaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxGramaj.ForeColor = System.Drawing.Color.Black;
            this.textBoxGramaj.Location = new System.Drawing.Point(786, 700);
            this.textBoxGramaj.Name = "textBoxGramaj";
            this.textBoxGramaj.Size = new System.Drawing.Size(416, 30);
            this.textBoxGramaj.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(751, 633);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 33);
            this.label6.TabIndex = 21;
            this.label6.Text = "Gramaj";
            // 
            // comboBoxMasura
            // 
            this.comboBoxMasura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxMasura.ForeColor = System.Drawing.Color.Black;
            this.comboBoxMasura.FormattingEnabled = true;
            this.comboBoxMasura.Items.AddRange(new object[] {
            "Bautura",
            "Pizza"});
            this.comboBoxMasura.Location = new System.Drawing.Point(786, 569);
            this.comboBoxMasura.Name = "comboBoxMasura";
            this.comboBoxMasura.Size = new System.Drawing.Size(416, 33);
            this.comboBoxMasura.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(751, 514);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 33);
            this.label2.TabIndex = 19;
            this.label2.Text = "Măsura";
            // 
            // textBoxItemPrice
            // 
            this.textBoxItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxItemPrice.ForeColor = System.Drawing.Color.Black;
            this.textBoxItemPrice.Location = new System.Drawing.Point(104, 700);
            this.textBoxItemPrice.Name = "textBoxItemPrice";
            this.textBoxItemPrice.Size = new System.Drawing.Size(416, 30);
            this.textBoxItemPrice.TabIndex = 18;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxCategory.ForeColor = System.Drawing.Color.Black;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Bautura",
            "Pizza"});
            this.comboBoxCategory.Location = new System.Drawing.Point(104, 569);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(416, 33);
            this.comboBoxCategory.TabIndex = 16;
            // 
            // buttonUpdateItem
            // 
            this.buttonUpdateItem.BackColor = System.Drawing.Color.Peru;
            this.buttonUpdateItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateItem.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUpdateItem.Location = new System.Drawing.Point(910, 798);
            this.buttonUpdateItem.Name = "buttonUpdateItem";
            this.buttonUpdateItem.Size = new System.Drawing.Size(176, 49);
            this.buttonUpdateItem.TabIndex = 15;
            this.buttonUpdateItem.Text = "Actualizare";
            this.buttonUpdateItem.UseVisualStyleBackColor = false;
            this.buttonUpdateItem.Click += new System.EventHandler(this.buttonUpdateItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(69, 514);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 33);
            this.label4.TabIndex = 14;
            this.label4.Text = "Categorie";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(69, 648);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 33);
            this.label7.TabIndex = 12;
            this.label7.Text = "Preț";
            // 
            // dataGridViewUpdateItem
            // 
            this.dataGridViewUpdateItem.AllowUserToAddRows = false;
            this.dataGridViewUpdateItem.AllowUserToDeleteRows = false;
            this.dataGridViewUpdateItem.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewUpdateItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUpdateItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewUpdateItem.Location = new System.Drawing.Point(91, 185);
            this.dataGridViewUpdateItem.MultiSelect = false;
            this.dataGridViewUpdateItem.Name = "dataGridViewUpdateItem";
            this.dataGridViewUpdateItem.ReadOnly = true;
            this.dataGridViewUpdateItem.RowHeadersWidth = 51;
            this.dataGridViewUpdateItem.RowTemplate.Height = 24;
            this.dataGridViewUpdateItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUpdateItem.Size = new System.Drawing.Size(1174, 299);
            this.dataGridViewUpdateItem.TabIndex = 23;
            this.dataGridViewUpdateItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUpdateItem_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Categorie";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Nume Produs";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Preț";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Măsura";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Gramaj";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // DashboardUpdateItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridViewUpdateItem);
            this.Controls.Add(this.textBoxGramaj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxMasura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxItemPrice);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.buttonUpdateItem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxSearchUpdateItem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "DashboardUpdateItem";
            this.Size = new System.Drawing.Size(1347, 880);
            this.Load += new System.EventHandler(this.UpdateItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpdateItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearchUpdateItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxGramaj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxMasura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxItemPrice;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Button buttonUpdateItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewUpdateItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
