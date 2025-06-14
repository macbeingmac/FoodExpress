namespace FoodDeliverySystem.views
{
    partial class Updatedetails
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
            this.Price = new System.Windows.Forms.TextBox();
            this.txtname1 = new System.Windows.Forms.TextBox();
            this.lblName1 = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lbledit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(365, 245);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(91, 41);
            this.btnupdate.TabIndex = 36;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(264, 203);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(289, 22);
            this.Price.TabIndex = 35;
            // 
            // txtname1
            // 
            this.txtname1.Location = new System.Drawing.Point(263, 155);
            this.txtname1.Name = "txtname1";
            this.txtname1.Size = new System.Drawing.Size(289, 22);
            this.txtname1.TabIndex = 34;
            // 
            // lblName1
            // 
            this.lblName1.AutoSize = true;
            this.lblName1.Location = new System.Drawing.Point(214, 158);
            this.lblName1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(44, 16);
            this.lblName1.TabIndex = 33;
            this.lblName1.Text = "Name";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Location = new System.Drawing.Point(201, 209);
            this.lbladdress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(58, 16);
            this.lbladdress.TabIndex = 32;
            this.lbladdress.Text = "Address";
            // 
            // lbledit
            // 
            this.lbledit.AutoSize = true;
            this.lbledit.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbledit.Location = new System.Drawing.Point(256, 70);
            this.lbledit.Name = "lbledit";
            this.lbledit.Size = new System.Drawing.Size(328, 40);
            this.lbledit.TabIndex = 31;
            this.lbledit.Text = "Edit / Update Details";
            // 
            // Updatedetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.txtname1);
            this.Controls.Add(this.lblName1);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lbledit);
            this.Name = "Updatedetails";
            this.Text = "Updatedetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox txtname1;
        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lbledit;
    }
}