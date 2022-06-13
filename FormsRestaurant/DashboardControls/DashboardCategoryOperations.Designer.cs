
namespace restaurantInterf.DashboardControls
{
    partial class DashboardCategoryOperations
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAddCategoryName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.dataGridViewCategories = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxSearchCategory = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonUpdateCategory = new System.Windows.Forms.Button();
            this.buttonDeleteCategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(268, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manager Categorii";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxAddCategoryName
            // 
            this.textBoxAddCategoryName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxAddCategoryName.ForeColor = System.Drawing.Color.Black;
            this.textBoxAddCategoryName.Location = new System.Drawing.Point(56, 333);
            this.textBoxAddCategoryName.Name = "textBoxAddCategoryName";
            this.textBoxAddCategoryName.Size = new System.Drawing.Size(331, 35);
            this.textBoxAddCategoryName.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(30, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 33);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nume categorie";
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.BackColor = System.Drawing.Color.Peru;
            this.buttonAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCategory.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddCategory.Location = new System.Drawing.Point(56, 465);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(120, 49);
            this.buttonAddCategory.TabIndex = 9;
            this.buttonAddCategory.Text = "Adaugă";
            this.buttonAddCategory.UseVisualStyleBackColor = false;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // dataGridViewCategories
            // 
            this.dataGridViewCategories.AllowUserToAddRows = false;
            this.dataGridViewCategories.AllowUserToDeleteRows = false;
            this.dataGridViewCategories.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCategories.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridViewCategories.Location = new System.Drawing.Point(744, 297);
            this.dataGridViewCategories.MultiSelect = false;
            this.dataGridViewCategories.Name = "dataGridViewCategories";
            this.dataGridViewCategories.ReadOnly = true;
            this.dataGridViewCategories.RowHeadersWidth = 51;
            this.dataGridViewCategories.RowTemplate.Height = 24;
            this.dataGridViewCategories.Size = new System.Drawing.Size(421, 284);
            this.dataGridViewCategories.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Nume categorie";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // textBoxSearchCategory
            // 
            this.textBoxSearchCategory.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSearchCategory.ForeColor = System.Drawing.Color.Black;
            this.textBoxSearchCategory.Location = new System.Drawing.Point(834, 203);
            this.textBoxSearchCategory.Name = "textBoxSearchCategory";
            this.textBoxSearchCategory.Size = new System.Drawing.Size(331, 35);
            this.textBoxSearchCategory.TabIndex = 14;
            this.textBoxSearchCategory.TextChanged += new System.EventHandler(this.textBoxSearchCategory_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(738, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 33);
            this.label7.TabIndex = 13;
            this.label7.Text = "Caută:";
            // 
            // buttonUpdateCategory
            // 
            this.buttonUpdateCategory.BackColor = System.Drawing.Color.Peru;
            this.buttonUpdateCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateCategory.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUpdateCategory.Location = new System.Drawing.Point(211, 465);
            this.buttonUpdateCategory.Name = "buttonUpdateCategory";
            this.buttonUpdateCategory.Size = new System.Drawing.Size(176, 49);
            this.buttonUpdateCategory.TabIndex = 15;
            this.buttonUpdateCategory.Text = "Actualizare";
            this.buttonUpdateCategory.UseVisualStyleBackColor = false;
            this.buttonUpdateCategory.Click += new System.EventHandler(this.buttonUpdateCategory_Click);
            // 
            // buttonDeleteCategory
            // 
            this.buttonDeleteCategory.BackColor = System.Drawing.Color.Peru;
            this.buttonDeleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteCategory.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDeleteCategory.Location = new System.Drawing.Point(429, 465);
            this.buttonDeleteCategory.Name = "buttonDeleteCategory";
            this.buttonDeleteCategory.Size = new System.Drawing.Size(145, 49);
            this.buttonDeleteCategory.TabIndex = 17;
            this.buttonDeleteCategory.Text = "Șterge";
            this.buttonDeleteCategory.UseVisualStyleBackColor = false;
            this.buttonDeleteCategory.Click += new System.EventHandler(this.buttonDeleteCategory_Click);
            // 
            // DashboardCategoryOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.buttonDeleteCategory);
            this.Controls.Add(this.buttonUpdateCategory);
            this.Controls.Add(this.textBoxSearchCategory);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridViewCategories);
            this.Controls.Add(this.buttonAddCategory);
            this.Controls.Add(this.textBoxAddCategoryName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "DashboardCategoryOperations";
            this.Size = new System.Drawing.Size(1347, 880);
            this.Load += new System.EventHandler(this.CategoryOperations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAddCategoryName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.DataGridView dataGridViewCategories;
        private System.Windows.Forms.TextBox textBoxSearchCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonUpdateCategory;
        private System.Windows.Forms.Button buttonDeleteCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}
