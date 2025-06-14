namespace FoodDeliverySystem.views
{
    partial class Updatedetials
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
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtaddress1 = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lbladdress1 = new System.Windows.Forms.Label();
            this.lblupdate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(306, 296);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(91, 41);
            this.btnupdate.TabIndex = 28;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            // 
            // txtaddress1
            // 
            this.txtaddress1.Location = new System.Drawing.Point(230, 226);
            this.txtaddress1.Name = "txtaddress1";
            this.txtaddress1.Size = new System.Drawing.Size(289, 22);
            this.txtaddress1.TabIndex = 27;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(230, 161);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(289, 22);
            this.txtname.TabIndex = 26;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(166, 164);
            this.lblname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(44, 16);
            this.lblname.TabIndex = 25;
            this.lblname.Text = "Name";
            // 
            // lbladdress1
            // 
            this.lbladdress1.AutoSize = true;
            this.lbladdress1.Location = new System.Drawing.Point(152, 232);
            this.lbladdress1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbladdress1.Name = "lbladdress1";
            this.lbladdress1.Size = new System.Drawing.Size(58, 16);
            this.lbladdress1.TabIndex = 24;
            this.lbladdress1.Text = "Address";
            // 
            // lblupdate
            // 
            this.lblupdate.AutoSize = true;
            this.lblupdate.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblupdate.Location = new System.Drawing.Point(162, 62);
            this.lblupdate.Name = "lblupdate";
            this.lblupdate.Size = new System.Drawing.Size(471, 37);
            this.lblupdate.TabIndex = 23;
            this.lblupdate.Text = "Update / Edit Restaurant Details";
            // 
            // Updatedetials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 418);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.txtaddress1);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lbladdress1);
            this.Controls.Add(this.lblupdate);
            this.Name = "Updatedetials";
            this.Text = "Updatedetials";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtaddress1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbladdress1;
        private System.Windows.Forms.Label lblupdate;
    }
}