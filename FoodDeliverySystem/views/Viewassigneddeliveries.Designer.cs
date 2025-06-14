namespace FoodDeliverySystem.views
{
    partial class Viewassigneddeliveries
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
            this.lblmanagerestaurant = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvgrid1
            // 
            this.dgvgrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvgrid1.Location = new System.Drawing.Point(137, 165);
            this.dgvgrid1.Name = "dgvgrid1";
            this.dgvgrid1.RowHeadersWidth = 51;
            this.dgvgrid1.RowTemplate.Height = 24;
            this.dgvgrid1.Size = new System.Drawing.Size(527, 184);
            this.dgvgrid1.TabIndex = 27;
            // 
            // lblmanagerestaurant
            // 
            this.lblmanagerestaurant.AutoSize = true;
            this.lblmanagerestaurant.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmanagerestaurant.Location = new System.Drawing.Point(224, 98);
            this.lblmanagerestaurant.Name = "lblmanagerestaurant";
            this.lblmanagerestaurant.Size = new System.Drawing.Size(368, 40);
            this.lblmanagerestaurant.TabIndex = 26;
            this.lblmanagerestaurant.Text = "My Assigned Deliveries";
            // 
            // Viewassigneddeliveries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvgrid1);
            this.Controls.Add(this.lblmanagerestaurant);
            this.Name = "Viewassigneddeliveries";
            this.Text = "Viewassigneddeliveries";
            ((System.ComponentModel.ISupportInitialize)(this.dgvgrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvgrid1;
        private System.Windows.Forms.Label lblmanagerestaurant;
    }
}