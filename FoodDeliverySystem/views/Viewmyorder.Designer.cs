namespace FoodDeliverySystem.views
{
    partial class Viewmyorder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvgrid = new System.Windows.Forms.DataGridView();
            this.lblMyorders = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvgrid
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvgrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvgrid.Location = new System.Drawing.Point(102, 128);
            this.dgvgrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvgrid.Name = "dgvgrid";
            this.dgvgrid.RowHeadersWidth = 51;
            this.dgvgrid.RowTemplate.Height = 24;
            this.dgvgrid.Size = new System.Drawing.Size(400, 150);
            this.dgvgrid.TabIndex = 19;
            this.dgvgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvgrid_CellContentClick);
            // 
            // lblMyorders
            // 
            this.lblMyorders.AutoSize = true;
            this.lblMyorders.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyorders.Location = new System.Drawing.Point(243, 58);
            this.lblMyorders.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMyorders.Name = "lblMyorders";
            this.lblMyorders.Size = new System.Drawing.Size(142, 31);
            this.lblMyorders.TabIndex = 18;
            this.lblMyorders.Text = "My Orders";
            // 
            // Viewmyorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dgvgrid);
            this.Controls.Add(this.lblMyorders);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Viewmyorder";
            this.Text = "Viewmyorder";
            ((System.ComponentModel.ISupportInitialize)(this.dgvgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvgrid;
        private System.Windows.Forms.Label lblMyorders;
    }
}