namespace FoodDeliverySystem.views
{
    partial class AdminRegisterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.lblAdminPassword = new System.Windows.Forms.Label();
            this.lblConfirmpassword = new System.Windows.Forms.Label();
            this.txtAdminName = new System.Windows.Forms.TextBox();
            this.txtAdminPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmpassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Register Form";
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Location = new System.Drawing.Point(149, 108);
            this.lblAdminName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(67, 13);
            this.lblAdminName.TabIndex = 1;
            this.lblAdminName.Text = "Admin Name";
            // 
            // lblAdminPassword
            // 
            this.lblAdminPassword.AutoSize = true;
            this.lblAdminPassword.Location = new System.Drawing.Point(132, 162);
            this.lblAdminPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdminPassword.Name = "lblAdminPassword";
            this.lblAdminPassword.Size = new System.Drawing.Size(85, 13);
            this.lblAdminPassword.TabIndex = 2;
            this.lblAdminPassword.Text = "Admin Password";
            // 
            // lblConfirmpassword
            // 
            this.lblConfirmpassword.AutoSize = true;
            this.lblConfirmpassword.Location = new System.Drawing.Point(132, 216);
            this.lblConfirmpassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirmpassword.Name = "lblConfirmpassword";
            this.lblConfirmpassword.Size = new System.Drawing.Size(90, 13);
            this.lblConfirmpassword.TabIndex = 3;
            this.lblConfirmpassword.Text = "Confirm password";
            // 
            // txtAdminName
            // 
            this.txtAdminName.Location = new System.Drawing.Point(222, 103);
            this.txtAdminName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAdminName.Name = "txtAdminName";
            this.txtAdminName.Size = new System.Drawing.Size(203, 20);
            this.txtAdminName.TabIndex = 4;
            // 
            // txtAdminPassword
            // 
            this.txtAdminPassword.Location = new System.Drawing.Point(222, 162);
            this.txtAdminPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAdminPassword.Name = "txtAdminPassword";
            this.txtAdminPassword.Size = new System.Drawing.Size(203, 20);
            this.txtAdminPassword.TabIndex = 5;
            // 
            // txtConfirmpassword
            // 
            this.txtConfirmpassword.Location = new System.Drawing.Point(222, 214);
            this.txtConfirmpassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtConfirmpassword.Name = "txtConfirmpassword";
            this.txtConfirmpassword.Size = new System.Drawing.Size(203, 20);
            this.txtConfirmpassword.TabIndex = 6;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.Info;
            this.btnRegister.Location = new System.Drawing.Point(222, 271);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(64, 28);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // AdminRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtConfirmpassword);
            this.Controls.Add(this.txtAdminPassword);
            this.Controls.Add(this.txtAdminName);
            this.Controls.Add(this.lblConfirmpassword);
            this.Controls.Add(this.lblAdminPassword);
            this.Controls.Add(this.lblAdminName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminRegisterForm";
            this.Text = "AdminRegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.Label lblAdminPassword;
        private System.Windows.Forms.Label lblConfirmpassword;
        private System.Windows.Forms.TextBox txtAdminName;
        private System.Windows.Forms.TextBox txtAdminPassword;
        private System.Windows.Forms.TextBox txtConfirmpassword;
        private System.Windows.Forms.Button btnRegister;
    }
}