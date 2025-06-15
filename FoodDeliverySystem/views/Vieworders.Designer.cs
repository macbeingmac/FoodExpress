namespace FoodDeliverySystem.views
{
    partial class Vieworders
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
            this.dgvgrid1 = new System.Windows.Forms.DataGridView();
            this.lblreceivedorders = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvgrid1
            // 
            this.dgvgrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvgrid1.Location = new System.Drawing.Point(103, 134);
            this.dgvgrid1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvgrid1.Name = "dgvgrid1";
            this.dgvgrid1.RowHeadersWidth = 51;
            this.dgvgrid1.RowTemplate.Height = 24;
            this.dgvgrid1.Size = new System.Drawing.Size(395, 150);
            this.dgvgrid1.TabIndex = 27;
            this.dgvgrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvgrid1_CellContentClick);
            // 
            // lblreceivedorders
            // 
            this.lblreceivedorders.AutoSize = true;
            this.lblreceivedorders.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreceivedorders.Location = new System.Drawing.Point(200, 83);
            this.lblreceivedorders.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblreceivedorders.Name = "lblreceivedorders";
            this.lblreceivedorders.Size = new System.Drawing.Size(211, 31);
            this.lblreceivedorders.TabIndex = 26;
            this.lblreceivedorders.Text = "Received Orders";
            // 
            // Vieworders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dgvgrid1);
            this.Controls.Add(this.lblreceivedorders);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Vieworders";
            this.Text = "Vieworders";
            ((System.ComponentModel.ISupportInitialize)(this.dgvgrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvgrid1;
        private System.Windows.Forms.Label lblreceivedorders;
    }
}