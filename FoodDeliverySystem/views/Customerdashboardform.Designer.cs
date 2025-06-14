namespace FoodDeliverySystem.views
{
    partial class Customerdashboardform
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
            this.btnBrowseRestaurants = new System.Windows.Forms.Button();
            this.btnViewMenu = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.btnLeaveaReview = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(233, 27);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(127, 31);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome";
            // 
            // btnBrowseRestaurants
            // 
            this.btnBrowseRestaurants.Location = new System.Drawing.Point(237, 75);
            this.btnBrowseRestaurants.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowseRestaurants.Name = "btnBrowseRestaurants";
            this.btnBrowseRestaurants.Size = new System.Drawing.Size(114, 19);
            this.btnBrowseRestaurants.TabIndex = 1;
            this.btnBrowseRestaurants.Text = "Browse Restaurants";
            this.btnBrowseRestaurants.UseVisualStyleBackColor = true;
            this.btnBrowseRestaurants.Click += new System.EventHandler(this.btnBrowseRestaurants_Click);
            // 
            // btnViewMenu
            // 
            this.btnViewMenu.Location = new System.Drawing.Point(237, 111);
            this.btnViewMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewMenu.Name = "btnViewMenu";
            this.btnViewMenu.Size = new System.Drawing.Size(114, 19);
            this.btnViewMenu.TabIndex = 2;
            this.btnViewMenu.Text = "View Menu";
            this.btnViewMenu.UseVisualStyleBackColor = true;
            this.btnViewMenu.Click += new System.EventHandler(this.btnViewMenu_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(237, 150);
            this.btnPlaceOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(114, 19);
            this.btnPlaceOrder.TabIndex = 3;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.Location = new System.Drawing.Point(237, 189);
            this.btnViewOrders.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(114, 19);
            this.btnViewOrders.TabIndex = 4;
            this.btnViewOrders.Text = "View Orders";
            this.btnViewOrders.UseVisualStyleBackColor = true;
            this.btnViewOrders.Click += new System.EventHandler(this.btnViewOrders_Click);
            // 
            // btnLeaveaReview
            // 
            this.btnLeaveaReview.Location = new System.Drawing.Point(238, 229);
            this.btnLeaveaReview.Margin = new System.Windows.Forms.Padding(2);
            this.btnLeaveaReview.Name = "btnLeaveaReview";
            this.btnLeaveaReview.Size = new System.Drawing.Size(114, 19);
            this.btnLeaveaReview.TabIndex = 5;
            this.btnLeaveaReview.Text = "Leave a Review";
            this.btnLeaveaReview.UseVisualStyleBackColor = true;
            this.btnLeaveaReview.Click += new System.EventHandler(this.btnLeaveaReview_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(237, 269);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(114, 19);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Customerdashboardform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnLeaveaReview);
            this.Controls.Add(this.btnViewOrders);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnViewMenu);
            this.Controls.Add(this.btnBrowseRestaurants);
            this.Controls.Add(this.lblWelcome);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Customerdashboardform";
            this.Text = "Customerdashboardform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnBrowseRestaurants;
        private System.Windows.Forms.Button btnViewMenu;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.Button btnLeaveaReview;
        private System.Windows.Forms.Button btnLogout;
    }
}