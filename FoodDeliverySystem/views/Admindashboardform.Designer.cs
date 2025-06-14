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
            this.lblWelcome.Location = new System.Drawing.Point(205, 58);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(127, 31);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome";
            // 
            // btnManageRestaurants
            // 
            this.btnManageRestaurants.Location = new System.Drawing.Point(210, 110);
            this.btnManageRestaurants.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnManageRestaurants.Name = "btnManageRestaurants";
            this.btnManageRestaurants.Size = new System.Drawing.Size(112, 34);
            this.btnManageRestaurants.TabIndex = 1;
            this.btnManageRestaurants.Text = "Manage restaurants";
            this.btnManageRestaurants.UseVisualStyleBackColor = true;
            this.btnManageRestaurants.Click += new System.EventHandler(this.btnManageRestaurants_Click);
            // 
            // btnManageMenu
            // 
            this.btnManageMenu.Location = new System.Drawing.Point(210, 150);
            this.btnManageMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnManageMenu.Name = "btnManageMenu";
            this.btnManageMenu.Size = new System.Drawing.Size(112, 29);
            this.btnManageMenu.TabIndex = 2;
            this.btnManageMenu.Text = "Manage Menu Items";
            this.btnManageMenu.UseVisualStyleBackColor = true;
            this.btnManageMenu.Click += new System.EventHandler(this.btnManageMenu_Click);
            // 
            // btnManageOrders
            // 
            this.btnManageOrders.Location = new System.Drawing.Point(210, 184);
            this.btnManageOrders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnManageOrders.Name = "btnManageOrders";
            this.btnManageOrders.Size = new System.Drawing.Size(112, 28);
            this.btnManageOrders.TabIndex = 3;
            this.btnManageOrders.Text = "Manage Orders";
            this.btnManageOrders.UseVisualStyleBackColor = true;
            this.btnManageOrders.Click += new System.EventHandler(this.btnManageOrders_Click);
            // 
            // btnManageDeliveries
            // 
            this.btnManageDeliveries.Location = new System.Drawing.Point(210, 217);
            this.btnManageDeliveries.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnManageDeliveries.Name = "btnManageDeliveries";
            this.btnManageDeliveries.Size = new System.Drawing.Size(112, 26);
            this.btnManageDeliveries.TabIndex = 4;
            this.btnManageDeliveries.Text = "Manage Deliveries";
            this.btnManageDeliveries.UseVisualStyleBackColor = true;
            this.btnManageDeliveries.Click += new System.EventHandler(this.btnManageDeliveries_Click);
            // 
            // btnManageReviews
            // 
            this.btnManageReviews.Location = new System.Drawing.Point(210, 248);
            this.btnManageReviews.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnManageReviews.Name = "btnManageReviews";
            this.btnManageReviews.Size = new System.Drawing.Size(112, 25);
            this.btnManageReviews.TabIndex = 5;
            this.btnManageReviews.Text = "Manage Reviews";
            this.btnManageReviews.UseVisualStyleBackColor = true;
            this.btnManageReviews.Click += new System.EventHandler(this.btnManageReviews_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.Info;
            this.btnLogout.Location = new System.Drawing.Point(219, 287);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(92, 32);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Admindashboardform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnManageReviews);
            this.Controls.Add(this.btnManageDeliveries);
            this.Controls.Add(this.btnManageOrders);
            this.Controls.Add(this.btnManageMenu);
            this.Controls.Add(this.btnManageRestaurants);
            this.Controls.Add(this.lblWelcome);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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