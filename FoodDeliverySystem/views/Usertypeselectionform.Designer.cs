namespace FoodDeliverySystem.views
{
    partial class Usertypeselectionform
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
            this.lblUserTypePrompt = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnDeliveryStaff = new System.Windows.Forms.Button();
            this.btnRestaurant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUserTypePrompt
            // 
            this.lblUserTypePrompt.AutoSize = true;
            this.lblUserTypePrompt.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserTypePrompt.Location = new System.Drawing.Point(286, 83);
            this.lblUserTypePrompt.Name = "lblUserTypePrompt";
            this.lblUserTypePrompt.Size = new System.Drawing.Size(394, 37);
            this.lblUserTypePrompt.TabIndex = 0;
            this.lblUserTypePrompt.Text = "Select user type to register";
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(336, 160);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(141, 37);
            this.btnAdmin.TabIndex = 6;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(336, 216);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(141, 40);
            this.btnCustomer.TabIndex = 7;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            // 
            // btnDeliveryStaff
            // 
            this.btnDeliveryStaff.Location = new System.Drawing.Point(336, 274);
            this.btnDeliveryStaff.Name = "btnDeliveryStaff";
            this.btnDeliveryStaff.Size = new System.Drawing.Size(141, 42);
            this.btnDeliveryStaff.TabIndex = 8;
            this.btnDeliveryStaff.Text = "Delivery Staff";
            this.btnDeliveryStaff.UseVisualStyleBackColor = true;
            // 
            // btnRestaurant
            // 
            this.btnRestaurant.Location = new System.Drawing.Point(336, 331);
            this.btnRestaurant.Name = "btnRestaurant";
            this.btnRestaurant.Size = new System.Drawing.Size(141, 38);
            this.btnRestaurant.TabIndex = 9;
            this.btnRestaurant.Text = "Restaurant";
            this.btnRestaurant.UseVisualStyleBackColor = true;
            // 
            // Usertypeselectionform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRestaurant);
            this.Controls.Add(this.btnDeliveryStaff);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.lblUserTypePrompt);
            this.Name = "Usertypeselectionform";
            this.Text = "Usertypeselectionform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserTypePrompt;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnDeliveryStaff;
        private System.Windows.Forms.Button btnRestaurant;
    }
}