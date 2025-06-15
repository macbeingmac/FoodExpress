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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvgrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvgrid.Location = new System.Drawing.Point(105, 84);
            this.dgvgrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvgrid.Name = "dgvgrid";
            this.dgvgrid.RowHeadersWidth = 51;
            this.dgvgrid.RowTemplate.Height = 24;
            this.dgvgrid.Size = new System.Drawing.Size(400, 150);
            this.dgvgrid.TabIndex = 13;
            // 
            // lblmanagedeliveries
            // 
            this.lblmanagedeliveries.AutoSize = true;
            this.lblmanagedeliveries.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmanagedeliveries.Location = new System.Drawing.Point(220, 26);
            this.lblmanagedeliveries.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmanagedeliveries.Name = "lblmanagedeliveries";
            this.lblmanagedeliveries.Size = new System.Drawing.Size(238, 31);
            this.lblmanagedeliveries.TabIndex = 12;
            this.lblmanagedeliveries.Text = "Manage Deliveries";
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(242, 407);
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
            this.txtstatus.Location = new System.Drawing.Point(173, 373);
            this.txtstatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(218, 20);
            this.txtstatus.TabIndex = 21;
            // 
            // txtorderid
            // 
            this.txtorderid.Location = new System.Drawing.Point(178, 334);
            this.txtorderid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtorderid.Name = "txtorderid";
            this.txtorderid.Size = new System.Drawing.Size(218, 20);
            this.txtorderid.TabIndex = 20;
            // 
            // lbldeliveryid
            // 
            this.lbldeliveryid.AutoSize = true;
            this.lbldeliveryid.Location = new System.Drawing.Point(119, 339);
            this.lbldeliveryid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldeliveryid.Name = "lbldeliveryid";
            this.lbldeliveryid.Size = new System.Drawing.Size(59, 13);
            this.lbldeliveryid.TabIndex = 19;
            this.lbldeliveryid.Text = "Delivery ID";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(136, 375);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 18;
            this.lblStatus.Text = "Status";
            // 
            // lblupdatedeliverystatus
            // 
            this.lblupdatedeliverystatus.AutoSize = true;
            this.lblupdatedeliverystatus.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblupdatedeliverystatus.Location = new System.Drawing.Point(223, 288);
            this.lblupdatedeliverystatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblupdatedeliverystatus.Name = "lblupdatedeliverystatus";
            this.lblupdatedeliverystatus.Size = new System.Drawing.Size(169, 19);
            this.lblupdatedeliverystatus.TabIndex = 17;
            this.lblupdatedeliverystatus.Text = "Update Delivery Status";
            // 
            // btnassign
            // 
            this.btnassign.Location = new System.Drawing.Point(242, 637);
            this.btnassign.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnassign.Name = "btnassign";
            this.btnassign.Size = new System.Drawing.Size(68, 33);
            this.btnassign.TabIndex = 28;
            this.btnassign.Text = "Assign";
            this.btnassign.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 603);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 20);
            this.textBox1.TabIndex = 27;
            // 
            // txtdeliverystaffid
            // 
            this.txtdeliverystaffid.Location = new System.Drawing.Point(166, 564);
            this.txtdeliverystaffid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtdeliverystaffid.Name = "txtdeliverystaffid";
            this.txtdeliverystaffid.Size = new System.Drawing.Size(218, 20);
            this.txtdeliverystaffid.TabIndex = 26;
            // 
            // lbldeliverystaffid
            // 
            this.lbldeliverystaffid.AutoSize = true;
            this.lbldeliverystaffid.Location = new System.Drawing.Point(86, 569);
            this.lbldeliverystaffid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldeliverystaffid.Name = "lbldeliverystaffid";
            this.lbldeliverystaffid.Size = new System.Drawing.Size(84, 13);
            this.lbldeliverystaffid.TabIndex = 25;
            this.lbldeliverystaffid.Text = "Delivery Staff ID";
            // 
            // lblorderid
            // 
            this.lblorderid.AutoSize = true;
            this.lblorderid.Location = new System.Drawing.Point(119, 608);
            this.lblorderid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblorderid.Name = "lblorderid";
            this.lblorderid.Size = new System.Drawing.Size(47, 13);
            this.lblorderid.TabIndex = 24;
            this.lblorderid.Text = "Order ID";
            // 
            // lblassignstaff
            // 
            this.lblassignstaff.AutoSize = true;
            this.lblassignstaff.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblassignstaff.Location = new System.Drawing.Point(223, 518);
            this.lblassignstaff.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblassignstaff.Name = "lblassignstaff";
            this.lblassignstaff.Size = new System.Drawing.Size(182, 19);
            this.lblassignstaff.TabIndex = 23;
            this.lblassignstaff.Text = "Assign Staff For Delivery";
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(242, 804);
            this.btndelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(68, 33);
            this.btndelete.TabIndex = 32;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(173, 765);
            this.txtid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(218, 20);
            this.txtid.TabIndex = 31;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(115, 769);
            this.lblid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(59, 13);
            this.lblid.TabIndex = 30;
            this.lblid.Text = "Delivery ID";
            // 
            // lbldelete
            // 
            this.lbldelete.AutoSize = true;
            this.lbldelete.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldelete.Location = new System.Drawing.Point(223, 719);
            this.lbldelete.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldelete.Name = "lbldelete";
            this.lbldelete.Size = new System.Drawing.Size(115, 19);
            this.lbldelete.TabIndex = 29;
            this.lbldelete.Text = "Delete Delivery";
            // 
            // Managedeliveries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 749);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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