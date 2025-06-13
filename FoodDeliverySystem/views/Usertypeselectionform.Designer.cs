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
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.rbCustomer = new System.Windows.Forms.RadioButton();
            this.rbDeliveryStaff = new System.Windows.Forms.RadioButton();
            this.rbRestaurant = new System.Windows.Forms.RadioButton();
            this.btnContinue = new System.Windows.Forms.Button();
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
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Location = new System.Drawing.Point(335, 172);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(66, 20);
            this.rbAdmin.TabIndex = 1;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "Admin";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // rbCustomer
            // 
            this.rbCustomer.AutoSize = true;
            this.rbCustomer.Location = new System.Drawing.Point(335, 213);
            this.rbCustomer.Name = "rbCustomer";
            this.rbCustomer.Size = new System.Drawing.Size(85, 20);
            this.rbCustomer.TabIndex = 2;
            this.rbCustomer.TabStop = true;
            this.rbCustomer.Text = "Customer";
            this.rbCustomer.UseVisualStyleBackColor = true;
            // 
            // rbDeliveryStaff
            // 
            this.rbDeliveryStaff.AutoSize = true;
            this.rbDeliveryStaff.Location = new System.Drawing.Point(335, 253);
            this.rbDeliveryStaff.Name = "rbDeliveryStaff";
            this.rbDeliveryStaff.Size = new System.Drawing.Size(107, 20);
            this.rbDeliveryStaff.TabIndex = 3;
            this.rbDeliveryStaff.TabStop = true;
            this.rbDeliveryStaff.Text = "Delivery Staff";
            this.rbDeliveryStaff.UseVisualStyleBackColor = true;
            // 
            // rbRestaurant
            // 
            this.rbRestaurant.AutoSize = true;
            this.rbRestaurant.Location = new System.Drawing.Point(335, 291);
            this.rbRestaurant.Name = "rbRestaurant";
            this.rbRestaurant.Size = new System.Drawing.Size(93, 20);
            this.rbRestaurant.TabIndex = 4;
            this.rbRestaurant.TabStop = true;
            this.rbRestaurant.Text = "Restaurant";
            this.rbRestaurant.UseVisualStyleBackColor = true;
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.SystemColors.Info;
            this.btnContinue.Location = new System.Drawing.Point(336, 352);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(85, 39);
            this.btnContinue.TabIndex = 5;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = false;
            // 
            // Usertypeselectionform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.rbRestaurant);
            this.Controls.Add(this.rbDeliveryStaff);
            this.Controls.Add(this.rbCustomer);
            this.Controls.Add(this.rbAdmin);
            this.Controls.Add(this.lblUserTypePrompt);
            this.Name = "Usertypeselectionform";
            this.Text = "Usertypeselectionform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserTypePrompt;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.RadioButton rbCustomer;
        private System.Windows.Forms.RadioButton rbDeliveryStaff;
        private System.Windows.Forms.RadioButton rbRestaurant;
        private System.Windows.Forms.Button btnContinue;
    }
}