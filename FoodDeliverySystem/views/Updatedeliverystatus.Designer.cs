namespace FoodDeliverySystem.views
{
    partial class Updatedeliverystatus
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
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.txtdeliveryid = new System.Windows.Forms.TextBox();
            this.lbldeliveryid = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblUpdateDeliveryStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(291, 226);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(68, 33);
            this.btnupdate.TabIndex = 22;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtstatus
            // 
            this.txtstatus.Location = new System.Drawing.Point(215, 192);
            this.txtstatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(218, 20);
            this.txtstatus.TabIndex = 21;
            // 
            // txtdeliveryid
            // 
            this.txtdeliveryid.Location = new System.Drawing.Point(214, 153);
            this.txtdeliveryid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtdeliveryid.Name = "txtdeliveryid";
            this.txtdeliveryid.Size = new System.Drawing.Size(218, 20);
            this.txtdeliveryid.TabIndex = 20;
            // 
            // lbldeliveryid
            // 
            this.lbldeliveryid.AutoSize = true;
            this.lbldeliveryid.Location = new System.Drawing.Point(156, 158);
            this.lbldeliveryid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldeliveryid.Name = "lbldeliveryid";
            this.lbldeliveryid.Size = new System.Drawing.Size(59, 13);
            this.lbldeliveryid.TabIndex = 19;
            this.lbldeliveryid.Text = "Delivery ID";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(178, 197);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 18;
            this.lblStatus.Text = "Status";
            // 
            // lblUpdateDeliveryStatus
            // 
            this.lblUpdateDeliveryStatus.AutoSize = true;
            this.lblUpdateDeliveryStatus.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateDeliveryStatus.Location = new System.Drawing.Point(272, 106);
            this.lblUpdateDeliveryStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdateDeliveryStatus.Name = "lblUpdateDeliveryStatus";
            this.lblUpdateDeliveryStatus.Size = new System.Drawing.Size(169, 19);
            this.lblUpdateDeliveryStatus.TabIndex = 17;
            this.lblUpdateDeliveryStatus.Text = "Update Delivery Status";
            // 
            // Updatedeliverystatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.txtdeliveryid);
            this.Controls.Add(this.lbldeliveryid);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblUpdateDeliveryStatus);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Updatedeliverystatus";
            this.Text = "Updatedeliverystatus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtstatus;
        private System.Windows.Forms.TextBox txtdeliveryid;
        private System.Windows.Forms.Label lbldeliveryid;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblUpdateDeliveryStatus;
    }
}