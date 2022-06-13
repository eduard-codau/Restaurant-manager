
namespace restaurantInterf
{
    partial class FormOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonExitOrder = new System.Windows.Forms.Button();
            this.textBoxOrderOperator = new System.Windows.Forms.TextBox();
            this.textBoxOrderTable = new System.Windows.Forms.TextBox();
            this.textBoxOrderNumber = new System.Windows.Forms.TextBox();
            this.labelOrderOperator = new System.Windows.Forms.Label();
            this.labelOrderTable = new System.Windows.Forms.Label();
            this.labelOrderNumber = new System.Windows.Forms.Label();
            this.buttonAddOrderItem = new System.Windows.Forms.Button();
            this.buttonCancelOrder = new System.Windows.Forms.Button();
            this.buttonApplyOrder = new System.Windows.Forms.Button();
            this.buttonPrintOrder = new System.Windows.Forms.Button();
            this.dataGridViewProduse = new System.Windows.Forms.DataGridView();
            this.buttonDeleteOrderItem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduse)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExitOrder
            // 
            this.buttonExitOrder.BackColor = System.Drawing.Color.Red;
            this.buttonExitOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitOrder.ForeColor = System.Drawing.Color.Black;
            this.buttonExitOrder.Location = new System.Drawing.Point(925, -1);
            this.buttonExitOrder.Name = "buttonExitOrder";
            this.buttonExitOrder.Size = new System.Drawing.Size(41, 38);
            this.buttonExitOrder.TabIndex = 30;
            this.buttonExitOrder.Text = "X";
            this.buttonExitOrder.UseVisualStyleBackColor = false;
            this.buttonExitOrder.Click += new System.EventHandler(this.buttonExitOrder_Click);
            // 
            // textBoxOrderOperator
            // 
            this.textBoxOrderOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxOrderOperator.ForeColor = System.Drawing.Color.Black;
            this.textBoxOrderOperator.Location = new System.Drawing.Point(702, 55);
            this.textBoxOrderOperator.Name = "textBoxOrderOperator";
            this.textBoxOrderOperator.ReadOnly = true;
            this.textBoxOrderOperator.Size = new System.Drawing.Size(217, 30);
            this.textBoxOrderOperator.TabIndex = 29;
            // 
            // textBoxOrderTable
            // 
            this.textBoxOrderTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxOrderTable.ForeColor = System.Drawing.Color.Black;
            this.textBoxOrderTable.Location = new System.Drawing.Point(149, 80);
            this.textBoxOrderTable.Name = "textBoxOrderTable";
            this.textBoxOrderTable.ReadOnly = true;
            this.textBoxOrderTable.Size = new System.Drawing.Size(217, 30);
            this.textBoxOrderTable.TabIndex = 28;
            // 
            // textBoxOrderNumber
            // 
            this.textBoxOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxOrderNumber.ForeColor = System.Drawing.Color.Black;
            this.textBoxOrderNumber.Location = new System.Drawing.Point(149, 31);
            this.textBoxOrderNumber.Name = "textBoxOrderNumber";
            this.textBoxOrderNumber.ReadOnly = true;
            this.textBoxOrderNumber.Size = new System.Drawing.Size(217, 30);
            this.textBoxOrderNumber.TabIndex = 27;
            // 
            // labelOrderOperator
            // 
            this.labelOrderOperator.AutoSize = true;
            this.labelOrderOperator.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOrderOperator.ForeColor = System.Drawing.Color.Black;
            this.labelOrderOperator.Location = new System.Drawing.Point(598, 52);
            this.labelOrderOperator.Name = "labelOrderOperator";
            this.labelOrderOperator.Size = new System.Drawing.Size(98, 34);
            this.labelOrderOperator.TabIndex = 26;
            this.labelOrderOperator.Text = "Ospătar :";
            // 
            // labelOrderTable
            // 
            this.labelOrderTable.AutoSize = true;
            this.labelOrderTable.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderTable.ForeColor = System.Drawing.Color.Black;
            this.labelOrderTable.Location = new System.Drawing.Point(60, 77);
            this.labelOrderTable.Name = "labelOrderTable";
            this.labelOrderTable.Size = new System.Drawing.Size(68, 34);
            this.labelOrderTable.TabIndex = 25;
            this.labelOrderTable.Text = "Masa:";
            // 
            // labelOrderNumber
            // 
            this.labelOrderNumber.AutoSize = true;
            this.labelOrderNumber.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderNumber.ForeColor = System.Drawing.Color.Black;
            this.labelOrderNumber.Location = new System.Drawing.Point(37, 28);
            this.labelOrderNumber.Name = "labelOrderNumber";
            this.labelOrderNumber.Size = new System.Drawing.Size(106, 34);
            this.labelOrderNumber.TabIndex = 24;
            this.labelOrderNumber.Text = "Comanda:";
            // 
            // buttonAddOrderItem
            // 
            this.buttonAddOrderItem.BackColor = System.Drawing.Color.Peru;
            this.buttonAddOrderItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddOrderItem.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddOrderItem.Location = new System.Drawing.Point(23, 221);
            this.buttonAddOrderItem.Name = "buttonAddOrderItem";
            this.buttonAddOrderItem.Size = new System.Drawing.Size(120, 49);
            this.buttonAddOrderItem.TabIndex = 31;
            this.buttonAddOrderItem.Text = "Adaugă";
            this.buttonAddOrderItem.UseVisualStyleBackColor = false;
            this.buttonAddOrderItem.Click += new System.EventHandler(this.buttonAddOrderItem_Click);
            // 
            // buttonCancelOrder
            // 
            this.buttonCancelOrder.BackColor = System.Drawing.Color.Red;
            this.buttonCancelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelOrder.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCancelOrder.Location = new System.Drawing.Point(751, 481);
            this.buttonCancelOrder.Name = "buttonCancelOrder";
            this.buttonCancelOrder.Size = new System.Drawing.Size(168, 80);
            this.buttonCancelOrder.TabIndex = 32;
            this.buttonCancelOrder.Text = "Anulează Comanda";
            this.buttonCancelOrder.UseVisualStyleBackColor = false;
            this.buttonCancelOrder.Click += new System.EventHandler(this.buttonCancelOrder_Click);
            // 
            // buttonApplyOrder
            // 
            this.buttonApplyOrder.BackColor = System.Drawing.Color.Peru;
            this.buttonApplyOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApplyOrder.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonApplyOrder.Location = new System.Drawing.Point(23, 403);
            this.buttonApplyOrder.Name = "buttonApplyOrder";
            this.buttonApplyOrder.Size = new System.Drawing.Size(120, 49);
            this.buttonApplyOrder.TabIndex = 33;
            this.buttonApplyOrder.Text = "Aplică";
            this.buttonApplyOrder.UseVisualStyleBackColor = false;
            this.buttonApplyOrder.Click += new System.EventHandler(this.buttonApplyOrder_Click);
            // 
            // buttonPrintOrder
            // 
            this.buttonPrintOrder.BackColor = System.Drawing.Color.Peru;
            this.buttonPrintOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrintOrder.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPrintOrder.Location = new System.Drawing.Point(23, 481);
            this.buttonPrintOrder.Name = "buttonPrintOrder";
            this.buttonPrintOrder.Size = new System.Drawing.Size(168, 80);
            this.buttonPrintOrder.TabIndex = 34;
            this.buttonPrintOrder.Text = "Nota de Plată";
            this.buttonPrintOrder.UseVisualStyleBackColor = false;
            this.buttonPrintOrder.Click += new System.EventHandler(this.buttonPrintOrder_Click);
            // 
            // dataGridViewProduse
            // 
            this.dataGridViewProduse.AllowUserToAddRows = false;
            this.dataGridViewProduse.AllowUserToDeleteRows = false;
            this.dataGridViewProduse.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProduse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewProduse.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProduse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProduse.ColumnHeadersHeight = 40;
            this.dataGridViewProduse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewProduse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3});
            this.dataGridViewProduse.GridColor = System.Drawing.Color.Black;
            this.dataGridViewProduse.Location = new System.Drawing.Point(183, 170);
            this.dataGridViewProduse.MultiSelect = false;
            this.dataGridViewProduse.Name = "dataGridViewProduse";
            this.dataGridViewProduse.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProduse.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewProduse.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataGridViewProduse.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewProduse.RowTemplate.Height = 24;
            this.dataGridViewProduse.RowTemplate.ReadOnly = true;
            this.dataGridViewProduse.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProduse.Size = new System.Drawing.Size(736, 282);
            this.dataGridViewProduse.TabIndex = 50;
            // 
            // buttonDeleteOrderItem
            // 
            this.buttonDeleteOrderItem.BackColor = System.Drawing.Color.Peru;
            this.buttonDeleteOrderItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteOrderItem.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDeleteOrderItem.Location = new System.Drawing.Point(23, 312);
            this.buttonDeleteOrderItem.Name = "buttonDeleteOrderItem";
            this.buttonDeleteOrderItem.Size = new System.Drawing.Size(120, 49);
            this.buttonDeleteOrderItem.TabIndex = 51;
            this.buttonDeleteOrderItem.Text = "Șterge";
            this.buttonDeleteOrderItem.UseVisualStyleBackColor = false;
            this.buttonDeleteOrderItem.Click += new System.EventHandler(this.buttonDeleteOrderItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(453, 465);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 34);
            this.label1.TabIndex = 52;
            this.label1.Text = "Total";
            // 
            // labelTotal
            // 
            this.labelTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelTotal.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.Black;
            this.labelTotal.Location = new System.Drawing.Point(425, 499);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(112, 58);
            this.labelTotal.TabIndex = 53;
            this.labelTotal.Text = "0";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Nume produs";
            this.Column1.MinimumWidth = 180;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 180;
            // 
            // Column2
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "Pret unitate";
            this.Column2.MinimumWidth = 160;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 160;
            // 
            // Column4
            // 
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column4.HeaderText = "Cantitate";
            this.Column4.MinimumWidth = 160;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 160;
            // 
            // Column3
            // 
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column3.HeaderText = "Pret";
            this.Column3.MinimumWidth = 180;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 180;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(963, 589);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDeleteOrderItem);
            this.Controls.Add(this.dataGridViewProduse);
            this.Controls.Add(this.buttonPrintOrder);
            this.Controls.Add(this.buttonApplyOrder);
            this.Controls.Add(this.buttonCancelOrder);
            this.Controls.Add(this.buttonAddOrderItem);
            this.Controls.Add(this.buttonExitOrder);
            this.Controls.Add(this.textBoxOrderOperator);
            this.Controls.Add(this.textBoxOrderTable);
            this.Controls.Add(this.textBoxOrderNumber);
            this.Controls.Add(this.labelOrderOperator);
            this.Controls.Add(this.labelOrderTable);
            this.Controls.Add(this.labelOrderNumber);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formular Comandă";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExitOrder;
        private System.Windows.Forms.TextBox textBoxOrderOperator;
        private System.Windows.Forms.TextBox textBoxOrderTable;
        private System.Windows.Forms.TextBox textBoxOrderNumber;
        private System.Windows.Forms.Label labelOrderOperator;
        private System.Windows.Forms.Label labelOrderTable;
        private System.Windows.Forms.Label labelOrderNumber;
        private System.Windows.Forms.Button buttonAddOrderItem;
        private System.Windows.Forms.Button buttonCancelOrder;
        private System.Windows.Forms.Button buttonApplyOrder;
        private System.Windows.Forms.Button buttonPrintOrder;
        private System.Windows.Forms.DataGridView dataGridViewProduse;
        private System.Windows.Forms.Button buttonDeleteOrderItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}