namespace FoodDeliverySystem.views
{
    partial class Customerregisterform
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
            this.lblCustomerRegister = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhonenumber = new System.Windows.Forms.Label();
            this.lblCreatePassword = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhonenumber = new System.Windows.Forms.TextBox();
            this.txtCreatePassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCustomerRegister
            // 
            this.lblCustomerRegister.AutoSize = true;
            this.lblCustomerRegister.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCustomerRegister.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerRegister.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblCustomerRegister.Location = new System.Drawing.Point(144, 36);
            this.lblCustomerRegister.Name = "lblCustomerRegister";
            this.lblCustomerRegister.Size = new System.Drawing.Size(383, 40);
            this.lblCustomerRegister.TabIndex = 0;
            this.lblCustomerRegister.Text = "Customer Register Form";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(142, 113);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(142, 165);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 16);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address";
            // 
            // lblPhonenumber
            // 
            this.lblPhonenumber.AutoSize = true;
            this.lblPhonenumber.Location = new System.Drawing.Point(142, 214);
            this.lblPhonenumber.Name = "lblPhonenumber";
            this.lblPhonenumber.Size = new System.Drawing.Size(97, 16);
            this.lblPhonenumber.TabIndex = 3;
            this.lblPhonenumber.Text = "Phone Number";
            // 
            // lblCreatePassword
            // 
            this.lblCreatePassword.AutoSize = true;
            this.lblCreatePassword.Location = new System.Drawing.Point(142, 261);
            this.lblCreatePassword.Name = "lblCreatePassword";
            this.lblCreatePassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCreatePassword.Size = new System.Drawing.Size(110, 16);
            this.lblCreatePassword.TabIndex = 4;
            this.lblCreatePassword.Text = "Create Password";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(271, 113);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(256, 22);
            this.txtName.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(271, 162);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(256, 22);
            this.txtAddress.TabIndex = 6;
            // 
            // txtPhonenumber
            // 
            this.txtPhonenumber.Location = new System.Drawing.Point(271, 214);
            this.txtPhonenumber.Name = "txtPhonenumber";
            this.txtPhonenumber.Size = new System.Drawing.Size(256, 22);
            this.txtPhonenumber.TabIndex = 7;
            // 
            // txtCreatePassword
            // 
            this.txtCreatePassword.Location = new System.Drawing.Point(271, 261);
            this.txtCreatePassword.Name = "txtCreatePassword";
            this.txtCreatePassword.Size = new System.Drawing.Size(256, 22);
            this.txtCreatePassword.TabIndex = 8;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.Info;
            this.btnRegister.Location = new System.Drawing.Point(271, 321);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(93, 41);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // Customerregisterform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtCreatePassword);
            this.Controls.Add(this.txtPhonenumber);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCreatePassword);
            this.Controls.Add(this.lblPhonenumber);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCustomerRegister);
            this.Name = "Customerregisterform";
            this.Text = "Customerregisterform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerRegister;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhonenumber;
        private System.Windows.Forms.Label lblCreatePassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhonenumber;
        private System.Windows.Forms.TextBox txtCreatePassword;
        private System.Windows.Forms.Button btnRegister;
    }
}