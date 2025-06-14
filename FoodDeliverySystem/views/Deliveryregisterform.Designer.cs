namespace FoodDeliverySystem.views
{
    partial class Deliveryregisterform
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
            this.lblDeliveryregisterform = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblVehicleType = new System.Windows.Forms.Label();
            this.lblCreatePassword = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtVehicleType = new System.Windows.Forms.TextBox();
            this.txtCreatePassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDeliveryregisterform
            // 
            this.lblDeliveryregisterform.AutoSize = true;
            this.lblDeliveryregisterform.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryregisterform.Location = new System.Drawing.Point(190, 49);
            this.lblDeliveryregisterform.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeliveryregisterform.Name = "lblDeliveryregisterform";
            this.lblDeliveryregisterform.Size = new System.Drawing.Size(220, 31);
            this.lblDeliveryregisterform.TabIndex = 0;
            this.lblDeliveryregisterform.Text = "Delivery Register";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(130, 115);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblVehicleType
            // 
            this.lblVehicleType.AutoSize = true;
            this.lblVehicleType.Location = new System.Drawing.Point(98, 148);
            this.lblVehicleType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVehicleType.Name = "lblVehicleType";
            this.lblVehicleType.Size = new System.Drawing.Size(69, 13);
            this.lblVehicleType.TabIndex = 2;
            this.lblVehicleType.Text = "Vehicle Type";
            // 
            // lblCreatePassword
            // 
            this.lblCreatePassword.AutoSize = true;
            this.lblCreatePassword.Location = new System.Drawing.Point(81, 184);
            this.lblCreatePassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreatePassword.Name = "lblCreatePassword";
            this.lblCreatePassword.Size = new System.Drawing.Size(87, 13);
            this.lblCreatePassword.TabIndex = 3;
            this.lblCreatePassword.Text = "Create Password";
            this.lblCreatePassword.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(195, 113);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtVehicleType
            // 
            this.txtVehicleType.Location = new System.Drawing.Point(195, 148);
            this.txtVehicleType.Margin = new System.Windows.Forms.Padding(2);
            this.txtVehicleType.Name = "txtVehicleType";
            this.txtVehicleType.Size = new System.Drawing.Size(200, 20);
            this.txtVehicleType.TabIndex = 5;
            this.txtVehicleType.TextChanged += new System.EventHandler(this.txtVehicleType_TextChanged);
            // 
            // txtCreatePassword
            // 
            this.txtCreatePassword.Location = new System.Drawing.Point(195, 184);
            this.txtCreatePassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtCreatePassword.Name = "txtCreatePassword";
            this.txtCreatePassword.Size = new System.Drawing.Size(200, 20);
            this.txtCreatePassword.TabIndex = 6;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.Info;
            this.btnRegister.Location = new System.Drawing.Point(254, 243);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(65, 30);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // Deliveryregisterform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtCreatePassword);
            this.Controls.Add(this.txtVehicleType);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCreatePassword);
            this.Controls.Add(this.lblVehicleType);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDeliveryregisterform);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Deliveryregisterform";
            this.Text = "Deliveryregisterform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeliveryregisterform;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblVehicleType;
        private System.Windows.Forms.Label lblCreatePassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtVehicleType;
        private System.Windows.Forms.TextBox txtCreatePassword;
        private System.Windows.Forms.Button btnRegister;
    }
}