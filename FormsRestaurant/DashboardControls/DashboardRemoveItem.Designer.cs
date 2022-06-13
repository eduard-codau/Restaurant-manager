
namespace restaurantInterf.DashboardControls
{
    partial class DashboardRemoveItem
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
            this.textBoxSearchRemoveItem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonDeleteItem = new System.Windows.Forms.Button();
            this.dataGridViewRemoveItem = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRemoveItem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(22, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Șterge Produs";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxSearchRemoveItem
            // 
            this.textBoxSearchRemoveItem.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSearchRemoveItem.ForeColor = System.Drawing.Color.Black;
            this.textBoxSearchRemoveItem.Location = new System.Drawing.Point(696, 113);
            this.textBoxSearchRemoveItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSearchRemoveItem.Name = "textBoxSearchRemoveItem";
            this.textBoxSearchRemoveItem.Size = new System.Drawing.Size(249, 30);
            this.textBoxSearchRemoveItem.TabIndex = 13;
            this.textBoxSearchRemoveItem.TextChanged += new System.EventHandler(this.textBoxSearchRemoveItem_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(562, 113);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "Caută Produs:";
            // 
            // buttonDeleteItem
            // 
            this.buttonDeleteItem.BackColor = System.Drawing.Color.Peru;
            this.buttonDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteItem.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDeleteItem.Location = new System.Drawing.Point(419, 527);
            this.buttonDeleteItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDeleteItem.Name = "buttonDeleteItem";
            this.buttonDeleteItem.Size = new System.Drawing.Size(182, 40);
            this.buttonDeleteItem.TabIndex = 16;
            this.buttonDeleteItem.Text = "Șterge";
            this.buttonDeleteItem.UseVisualStyleBackColor = false;
            this.buttonDeleteItem.Click += new System.EventHandler(this.buttonDeleteItem_Click);
            // 
            // dataGridViewRemoveItem
            // 
            this.dataGridViewRemoveItem.AllowUserToAddRows = false;
            this.dataGridViewRemoveItem.AllowUserToDeleteRows = false;
            this.dataGridViewRemoveItem.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRemoveItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRemoveItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewRemoveItem.Location = new System.Drawing.Point(64, 198);
            this.dataGridViewRemoveItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewRemoveItem.MultiSelect = false;
            this.dataGridViewRemoveItem.Name = "dataGridViewRemoveItem";
            this.dataGridViewRemoveItem.ReadOnly = true;
            this.dataGridViewRemoveItem.RowHeadersWidth = 51;
            this.dataGridViewRemoveItem.RowTemplate.Height = 24;
            this.dataGridViewRemoveItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRemoveItem.Size = new System.Drawing.Size(880, 243);
            this.dataGridViewRemoveItem.TabIndex = 24;
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
            // DashboardRemoveItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridViewRemoveItem);
            this.Controls.Add(this.buttonDeleteItem);
            this.Controls.Add(this.textBoxSearchRemoveItem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DashboardRemoveItem";
            this.Size = new System.Drawing.Size(1010, 715);
            this.Load += new System.EventHandler(this.RemoveItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRemoveItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearchRemoveItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonDeleteItem;
        private System.Windows.Forms.DataGridView dataGridViewRemoveItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
