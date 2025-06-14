namespace FoodDeliverySystem.views
{
    partial class Admindashboardform
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
            this.btnManageRestaurants = new System.Windows.Forms.Button();
            this.btnManageMenu = new System.Windows.Forms.Button();
            this.btnManageOrders = new System.Windows.Forms.Button();
            this.btnManageDeliveries = new System.Windows.Forms.Button();
            this.btnManageReviews = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(273, 71);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(157, 40);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome";
            // 
            // btnManageRestaurants
            // 
            this.btnManageRestaurants.Location = new System.Drawing.Point(280, 136);
            this.btnManageRestaurants.Name = "btnManageRestaurants";
            this.btnManageRestaurants.Size = new System.Drawing.Size(150, 42);
            this.btnManageRestaurants.TabIndex = 1;
            this.btnManageRestaurants.Text = "Manage restaurants";
            this.btnManageRestaurants.UseVisualStyleBackColor = true;
            // 
            // btnManageMenu
            // 
            this.btnManageMenu.Location = new System.Drawing.Point(280, 184);
            this.btnManageMenu.Name = "btnManageMenu";
            this.btnManageMenu.Size = new System.Drawing.Size(150, 36);
            this.btnManageMenu.TabIndex = 2;
            this.btnManageMenu.Text = "Manage Menu Items";
            this.btnManageMenu.UseVisualStyleBackColor = true;
            // 
            // btnManageOrders
            // 
            this.btnManageOrders.Location = new System.Drawing.Point(280, 226);
            this.btnManageOrders.Name = "btnManageOrders";
            this.btnManageOrders.Size = new System.Drawing.Size(150, 35);
            this.btnManageOrders.TabIndex = 3;
            this.btnManageOrders.Text = "Manage Orders";
            this.btnManageOrders.UseVisualStyleBackColor = true;
            // 
            // btnManageDeliveries
            // 
            this.btnManageDeliveries.Location = new System.Drawing.Point(280, 267);
            this.btnManageDeliveries.Name = "btnManageDeliveries";
            this.btnManageDeliveries.Size = new System.Drawing.Size(150, 32);
            this.btnManageDeliveries.TabIndex = 4;
            this.btnManageDeliveries.Text = "Manage Deliveries";
            this.btnManageDeliveries.UseVisualStyleBackColor = true;
            // 
            // btnManageReviews
            // 
            this.btnManageReviews.Location = new System.Drawing.Point(280, 305);
            this.btnManageReviews.Name = "btnManageReviews";
            this.btnManageReviews.Size = new System.Drawing.Size(150, 31);
            this.btnManageReviews.TabIndex = 5;
            this.btnManageReviews.Text = "Manage Reviews";
            this.btnManageReviews.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.Info;
            this.btnLogout.Location = new System.Drawing.Point(292, 353);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(123, 40);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // Admindashboardform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnManageReviews);
            this.Controls.Add(this.btnManageDeliveries);
            this.Controls.Add(this.btnManageOrders);
            this.Controls.Add(this.btnManageMenu);
            this.Controls.Add(this.btnManageRestaurants);
            this.Controls.Add(this.lblWelcome);
            this.Name = "Admindashboardform";
            this.Text = "Admindashboardform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnManageRestaurants;
        private System.Windows.Forms.Button btnManageMenu;
        private System.Windows.Forms.Button btnManageOrders;
        private System.Windows.Forms.Button btnManageDeliveries;
        private System.Windows.Forms.Button btnManageReviews;
        private System.Windows.Forms.Button btnLogout;
    }
}