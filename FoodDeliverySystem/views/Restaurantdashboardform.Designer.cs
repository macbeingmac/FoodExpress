namespace FoodDeliverySystem.views
{
    partial class Restaurantdashboardform
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
            this.btnUpdateDetails = new System.Windows.Forms.Button();
            this.btnManageMenu = new System.Windows.Forms.Button();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.btnViewReviews = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(263, 50);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(127, 31);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome";
            // 
            // btnUpdateDetails
            // 
            this.btnUpdateDetails.Location = new System.Drawing.Point(266, 109);
            this.btnUpdateDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateDetails.Name = "btnUpdateDetails";
            this.btnUpdateDetails.Size = new System.Drawing.Size(116, 19);
            this.btnUpdateDetails.TabIndex = 1;
            this.btnUpdateDetails.Text = "Edit / Update Details";
            this.btnUpdateDetails.UseVisualStyleBackColor = true;
            this.btnUpdateDetails.Click += new System.EventHandler(this.btnUpdateDetails_Click);
            // 
            // btnManageMenu
            // 
            this.btnManageMenu.Location = new System.Drawing.Point(266, 150);
            this.btnManageMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnManageMenu.Name = "btnManageMenu";
            this.btnManageMenu.Size = new System.Drawing.Size(116, 19);
            this.btnManageMenu.TabIndex = 2;
            this.btnManageMenu.Text = "Manage Menu";
            this.btnManageMenu.UseVisualStyleBackColor = true;
            this.btnManageMenu.Click += new System.EventHandler(this.btnManageMenu_Click);
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.Location = new System.Drawing.Point(266, 189);
            this.btnViewOrders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(116, 19);
            this.btnViewOrders.TabIndex = 3;
            this.btnViewOrders.Text = "View Orders";
            this.btnViewOrders.UseVisualStyleBackColor = true;
            this.btnViewOrders.Click += new System.EventHandler(this.btnViewOrders_Click);
            // 
            // btnViewReviews
            // 
            this.btnViewReviews.Location = new System.Drawing.Point(266, 235);
            this.btnViewReviews.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewReviews.Name = "btnViewReviews";
            this.btnViewReviews.Size = new System.Drawing.Size(116, 19);
            this.btnViewReviews.TabIndex = 4;
            this.btnViewReviews.Text = "View Reviews";
            this.btnViewReviews.UseVisualStyleBackColor = true;
            this.btnViewReviews.Click += new System.EventHandler(this.btnViewReviews_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(266, 280);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(116, 19);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Restaurantdashboardform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnViewReviews);
            this.Controls.Add(this.btnViewOrders);
            this.Controls.Add(this.btnManageMenu);
            this.Controls.Add(this.btnUpdateDetails);
            this.Controls.Add(this.lblWelcome);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Restaurantdashboardform";
            this.Text = "Restaurantdashboardform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnUpdateDetails;
        private System.Windows.Forms.Button btnManageMenu;
        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.Button btnViewReviews;
        private System.Windows.Forms.Button btnLogout;
    }
}