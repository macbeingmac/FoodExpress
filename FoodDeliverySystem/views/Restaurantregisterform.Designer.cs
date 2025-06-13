namespace FoodDeliverySystem.views
{
    partial class Restaurantregisterform
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
            this.lblrestaurantregisterform = new System.Windows.Forms.Label();
            this.lblRestaurantName = new System.Windows.Forms.Label();
            this.lblRestaurantAddress = new System.Windows.Forms.Label();
            this.lblCreatepassword = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtRestaurantName = new System.Windows.Forms.TextBox();
            this.txtRestaurantAddress = new System.Windows.Forms.TextBox();
            this.txtCreatepassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblrestaurantregisterform
            // 
            this.lblrestaurantregisterform.AutoSize = true;
            this.lblrestaurantregisterform.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblrestaurantregisterform.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrestaurantregisterform.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblrestaurantregisterform.Location = new System.Drawing.Point(254, 41);
            this.lblrestaurantregisterform.Name = "lblrestaurantregisterform";
            this.lblrestaurantregisterform.Size = new System.Drawing.Size(400, 40);
            this.lblrestaurantregisterform.TabIndex = 0;
            this.lblrestaurantregisterform.Text = "Restaurant Register Form";
            // 
            // lblRestaurantName
            // 
            this.lblRestaurantName.AutoSize = true;
            this.lblRestaurantName.Location = new System.Drawing.Point(213, 130);
            this.lblRestaurantName.Name = "lblRestaurantName";
            this.lblRestaurantName.Size = new System.Drawing.Size(112, 16);
            this.lblRestaurantName.TabIndex = 1;
            this.lblRestaurantName.Text = "Restaurant Name";
            // 
            // lblRestaurantAddress
            // 
            this.lblRestaurantAddress.AutoSize = true;
            this.lblRestaurantAddress.Location = new System.Drawing.Point(213, 192);
            this.lblRestaurantAddress.Name = "lblRestaurantAddress";
            this.lblRestaurantAddress.Size = new System.Drawing.Size(126, 16);
            this.lblRestaurantAddress.TabIndex = 2;
            this.lblRestaurantAddress.Text = "Restaurant Address";
            // 
            // lblCreatepassword
            // 
            this.lblCreatepassword.AutoSize = true;
            this.lblCreatepassword.Location = new System.Drawing.Point(213, 254);
            this.lblCreatepassword.Name = "lblCreatepassword";
            this.lblCreatepassword.Size = new System.Drawing.Size(110, 16);
            this.lblCreatepassword.TabIndex = 3;
            this.lblCreatepassword.Text = "Create Password";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.Info;
            this.btnRegister.Location = new System.Drawing.Point(369, 317);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(89, 38);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // txtRestaurantName
            // 
            this.txtRestaurantName.Location = new System.Drawing.Point(369, 124);
            this.txtRestaurantName.Name = "txtRestaurantName";
            this.txtRestaurantName.Size = new System.Drawing.Size(218, 22);
            this.txtRestaurantName.TabIndex = 6;
            // 
            // txtRestaurantAddress
            // 
            this.txtRestaurantAddress.Location = new System.Drawing.Point(369, 186);
            this.txtRestaurantAddress.Name = "txtRestaurantAddress";
            this.txtRestaurantAddress.Size = new System.Drawing.Size(218, 22);
            this.txtRestaurantAddress.TabIndex = 7;
            // 
            // txtCreatepassword
            // 
            this.txtCreatepassword.Location = new System.Drawing.Point(369, 248);
            this.txtCreatepassword.Name = "txtCreatepassword";
            this.txtCreatepassword.Size = new System.Drawing.Size(218, 22);
            this.txtCreatepassword.TabIndex = 8;
            // 
            // Restaurantregisterform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCreatepassword);
            this.Controls.Add(this.txtRestaurantAddress);
            this.Controls.Add(this.txtRestaurantName);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblCreatepassword);
            this.Controls.Add(this.lblRestaurantAddress);
            this.Controls.Add(this.lblRestaurantName);
            this.Controls.Add(this.lblrestaurantregisterform);
            this.Name = "Restaurantregisterform";
            this.Text = "Restaurantregisterform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblrestaurantregisterform;
        private System.Windows.Forms.Label lblRestaurantName;
        private System.Windows.Forms.Label lblRestaurantAddress;
        private System.Windows.Forms.Label lblCreatepassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtRestaurantName;
        private System.Windows.Forms.TextBox txtRestaurantAddress;
        private System.Windows.Forms.TextBox txtCreatepassword;
    }
}