namespace FoodDeliverySystem.views
{
    partial class Leaveareview
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
            this.txtrating = new System.Windows.Forms.TextBox();
            this.lblrating = new System.Windows.Forms.Label();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.txtcomment = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblreviewername = new System.Windows.Forms.Label();
            this.lblcomment = new System.Windows.Forms.Label();
            this.lblupdateamenuitem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtrating
            // 
            this.txtrating.Location = new System.Drawing.Point(260, 248);
            this.txtrating.Name = "txtrating";
            this.txtrating.Size = new System.Drawing.Size(289, 22);
            this.txtrating.TabIndex = 50;
            // 
            // lblrating
            // 
            this.lblrating.AutoSize = true;
            this.lblrating.Location = new System.Drawing.Point(209, 254);
            this.lblrating.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblrating.Name = "lblrating";
            this.lblrating.Size = new System.Drawing.Size(46, 16);
            this.lblrating.TabIndex = 49;
            this.lblrating.Text = "Rating";
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(362, 290);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(91, 41);
            this.btnsubmit.TabIndex = 48;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            // 
            // txtcomment
            // 
            this.txtcomment.Location = new System.Drawing.Point(261, 200);
            this.txtcomment.Name = "txtcomment";
            this.txtcomment.Size = new System.Drawing.Size(289, 22);
            this.txtcomment.TabIndex = 47;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(260, 152);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(289, 22);
            this.txtname.TabIndex = 46;
            // 
            // lblreviewername
            // 
            this.lblreviewername.AutoSize = true;
            this.lblreviewername.Location = new System.Drawing.Point(159, 155);
            this.lblreviewername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblreviewername.Name = "lblreviewername";
            this.lblreviewername.Size = new System.Drawing.Size(96, 16);
            this.lblreviewername.TabIndex = 45;
            this.lblreviewername.Text = "Reviwer Name";
            // 
            // lblcomment
            // 
            this.lblcomment.AutoSize = true;
            this.lblcomment.Location = new System.Drawing.Point(191, 203);
            this.lblcomment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcomment.Name = "lblcomment";
            this.lblcomment.Size = new System.Drawing.Size(64, 16);
            this.lblcomment.TabIndex = 44;
            this.lblcomment.Text = "Comment";
            // 
            // lblupdateamenuitem
            // 
            this.lblupdateamenuitem.AutoSize = true;
            this.lblupdateamenuitem.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblupdateamenuitem.Location = new System.Drawing.Point(274, 64);
            this.lblupdateamenuitem.Name = "lblupdateamenuitem";
            this.lblupdateamenuitem.Size = new System.Drawing.Size(243, 40);
            this.lblupdateamenuitem.TabIndex = 43;
            this.lblupdateamenuitem.Text = "Leave a Review";
            // 
            // Leaveareview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtrating);
            this.Controls.Add(this.lblrating);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.txtcomment);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblreviewername);
            this.Controls.Add(this.lblcomment);
            this.Controls.Add(this.lblupdateamenuitem);
            this.Name = "Leaveareview";
            this.Text = "Leaveareview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtrating;
        private System.Windows.Forms.Label lblrating;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.TextBox txtcomment;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblreviewername;
        private System.Windows.Forms.Label lblcomment;
        private System.Windows.Forms.Label lblupdateamenuitem;
    }
}