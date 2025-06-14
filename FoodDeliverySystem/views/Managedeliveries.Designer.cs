namespace FoodDeliverySystem.views
{
    partial class Managedeliveries
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvgrid = new System.Windows.Forms.DataGridView();
            this.lblmanagedeliveries = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.txtorderid = new System.Windows.Forms.TextBox();
            this.lbldeliveryid = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblupdatedeliverystatus = new System.Windows.Forms.Label();
            this.btnassign = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtdeliverystaffid = new System.Windows.Forms.TextBox();
            this.lbldeliverystaffid = new System.Windows.Forms.Label();
            this.lblorderid = new System.Windows.Forms.Label();
            this.lblassignstaff = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.lbldelete = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvgrid
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvgrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvgrid.Location = new System.Drawing.Point(140, 104);
            this.dgvgrid.Name = "dgvgrid";
            this.dgvgrid.RowHeadersWidth = 51;
            this.dgvgrid.RowTemplate.Height = 24;
            this.dgvgrid.Size = new System.Drawing.Size(533, 184);
            this.dgvgrid.TabIndex = 13;
            // 
            // lblmanagedeliveries
            // 
            this.lblmanagedeliveries.AutoSize = true;
            this.lblmanagedeliveries.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmanagedeliveries.Location = new System.Drawing.Point(294, 32);
            this.lblmanagedeliveries.Name = "lblmanagedeliveries";
            this.lblmanagedeliveries.Size = new System.Drawing.Size(294, 40);
            this.lblmanagedeliveries.TabIndex = 12;
            this.lblmanagedeliveries.Text = "Manage Deliveries";
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(323, 501);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(91, 41);
            this.btnupdate.TabIndex = 22;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            // 
            // txtstatus
            // 
            this.txtstatus.Location = new System.Drawing.Point(231, 459);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(289, 22);
            this.txtstatus.TabIndex = 21;
            // 
            // txtorderid
            // 
            this.txtorderid.Location = new System.Drawing.Point(237, 411);
            this.txtorderid.Name = "txtorderid";
            this.txtorderid.Size = new System.Drawing.Size(289, 22);
            this.txtorderid.TabIndex = 20;
            // 
            // lbldeliveryid
            // 
            this.lbldeliveryid.AutoSize = true;
            this.lbldeliveryid.Location = new System.Drawing.Point(159, 417);
            this.lbldeliveryid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldeliveryid.Name = "lbldeliveryid";
            this.lbldeliveryid.Size = new System.Drawing.Size(73, 16);
            this.lbldeliveryid.TabIndex = 19;
            this.lbldeliveryid.Text = "Delivery ID";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(182, 462);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 16);
            this.lblStatus.TabIndex = 18;
            this.lblStatus.Text = "Status";
            // 
            // lblupdatedeliverystatus
            // 
            this.lblupdatedeliverystatus.AutoSize = true;
            this.lblupdatedeliverystatus.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblupdatedeliverystatus.Location = new System.Drawing.Point(297, 354);
            this.lblupdatedeliverystatus.Name = "lblupdatedeliverystatus";
            this.lblupdatedeliverystatus.Size = new System.Drawing.Size(205, 24);
            this.lblupdatedeliverystatus.TabIndex = 17;
            this.lblupdatedeliverystatus.Text = "Update Delivery Status";
            // 
            // btnassign
            // 
            this.btnassign.Location = new System.Drawing.Point(323, 784);
            this.btnassign.Name = "btnassign";
            this.btnassign.Size = new System.Drawing.Size(91, 41);
            this.btnassign.TabIndex = 28;
            this.btnassign.Text = "Assign";
            this.btnassign.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(222, 742);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 22);
            this.textBox1.TabIndex = 27;
            // 
            // txtdeliverystaffid
            // 
            this.txtdeliverystaffid.Location = new System.Drawing.Point(221, 694);
            this.txtdeliverystaffid.Name = "txtdeliverystaffid";
            this.txtdeliverystaffid.Size = new System.Drawing.Size(289, 22);
            this.txtdeliverystaffid.TabIndex = 26;
            // 
            // lbldeliverystaffid
            // 
            this.lbldeliverystaffid.AutoSize = true;
            this.lbldeliverystaffid.Location = new System.Drawing.Point(114, 700);
            this.lbldeliverystaffid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldeliverystaffid.Name = "lbldeliverystaffid";
            this.lbldeliverystaffid.Size = new System.Drawing.Size(102, 16);
            this.lbldeliverystaffid.TabIndex = 25;
            this.lbldeliverystaffid.Text = "Delivery Staff ID";
            // 
            // lblorderid
            // 
            this.lblorderid.AutoSize = true;
            this.lblorderid.Location = new System.Drawing.Point(159, 748);
            this.lblorderid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblorderid.Name = "lblorderid";
            this.lblorderid.Size = new System.Drawing.Size(57, 16);
            this.lblorderid.TabIndex = 24;
            this.lblorderid.Text = "Order ID";
            // 
            // lblassignstaff
            // 
            this.lblassignstaff.AutoSize = true;
            this.lblassignstaff.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblassignstaff.Location = new System.Drawing.Point(297, 637);
            this.lblassignstaff.Name = "lblassignstaff";
            this.lblassignstaff.Size = new System.Drawing.Size(219, 24);
            this.lblassignstaff.TabIndex = 23;
            this.lblassignstaff.Text = "Assign Staff For Delivery";
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(323, 990);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(91, 41);
            this.btndelete.TabIndex = 32;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(231, 941);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(289, 22);
            this.txtid.TabIndex = 31;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(153, 947);
            this.lblid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(73, 16);
            this.lblid.TabIndex = 30;
            this.lblid.Text = "Delivery ID";
            // 
            // lbldelete
            // 
            this.lbldelete.AutoSize = true;
            this.lbldelete.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldelete.Location = new System.Drawing.Point(297, 885);
            this.lbldelete.Name = "lbldelete";
            this.lbldelete.Size = new System.Drawing.Size(140, 24);
            this.lbldelete.TabIndex = 29;
            this.lbldelete.Text = "Delete Delivery";
            // 
            // Managedeliveries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 1055);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lbldelete);
            this.Controls.Add(this.btnassign);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtdeliverystaffid);
            this.Controls.Add(this.lbldeliverystaffid);
            this.Controls.Add(this.lblorderid);
            this.Controls.Add(this.lblassignstaff);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.txtorderid);
            this.Controls.Add(this.lbldeliveryid);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblupdatedeliverystatus);
            this.Controls.Add(this.dgvgrid);
            this.Controls.Add(this.lblmanagedeliveries);
            this.Name = "Managedeliveries";
            this.Text = "Managedeliveries";
            ((System.ComponentModel.ISupportInitialize)(this.dgvgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvgrid;
        private System.Windows.Forms.Label lblmanagedeliveries;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtstatus;
        private System.Windows.Forms.TextBox txtorderid;
        private System.Windows.Forms.Label lbldeliveryid;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblupdatedeliverystatus;
        private System.Windows.Forms.Button btnassign;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtdeliverystaffid;
        private System.Windows.Forms.Label lbldeliverystaffid;
        private System.Windows.Forms.Label lblorderid;
        private System.Windows.Forms.Label lblassignstaff;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lbldelete;
    }
}