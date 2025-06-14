namespace FoodDeliverySystem.views
{
    partial class Deliverystaffdashboardform
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnViewAssignedDeliveries = new System.Windows.Forms.Button();
            this.btnUpdateDeliveryStatus = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(354, 65);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(157, 40);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome";
            // 
            // btnViewAssignedDeliveries
            // 
            this.btnViewAssignedDeliveries.Location = new System.Drawing.Point(348, 140);
            this.btnViewAssignedDeliveries.Name = "btnViewAssignedDeliveries";
            this.btnViewAssignedDeliveries.Size = new System.Drawing.Size(184, 23);
            this.btnViewAssignedDeliveries.TabIndex = 1;
            this.btnViewAssignedDeliveries.Text = "View Assigned Deliveries";
            this.btnViewAssignedDeliveries.UseVisualStyleBackColor = true;
            // 
            // btnUpdateDeliveryStatus
            // 
            this.btnUpdateDeliveryStatus.Location = new System.Drawing.Point(348, 207);
            this.btnUpdateDeliveryStatus.Name = "btnUpdateDeliveryStatus";
            this.btnUpdateDeliveryStatus.Size = new System.Drawing.Size(184, 23);
            this.btnUpdateDeliveryStatus.TabIndex = 2;
            this.btnUpdateDeliveryStatus.Text = "Update Delivery Status";
            this.btnUpdateDeliveryStatus.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(348, 275);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(184, 23);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // Deliverystaffdashboardform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnUpdateDeliveryStatus);
            this.Controls.Add(this.btnViewAssignedDeliveries);
            this.Controls.Add(this.lblWelcome);
            this.Name = "Deliverystaffdashboardform";
            this.Text = "Deliverystaffdashboardform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnViewAssignedDeliveries;
        private System.Windows.Forms.Button btnUpdateDeliveryStatus;
        private System.Windows.Forms.Button btnLogout;
    }
}