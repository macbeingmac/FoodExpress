namespace FoodDeliverySystem.views
{
    partial class Manageorders
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
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.txtorderid = new System.Windows.Forms.TextBox();
            this.lblorderid = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dgvgrid = new System.Windows.Forms.DataGridView();
            this.lblUpdateOrderStatus = new System.Windows.Forms.Label();
            this.lblallorders = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.txtorder = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.lbldelete = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(342, 491);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(91, 41);
            this.btnupdate.TabIndex = 16;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            // 
            // txtstatus
            // 
            this.txtstatus.Location = new System.Drawing.Point(241, 449);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(289, 22);
            this.txtstatus.TabIndex = 15;
            // 
            // txtorderid
            // 
            this.txtorderid.Location = new System.Drawing.Point(240, 401);
            this.txtorderid.Name = "txtorderid";
            this.txtorderid.Size = new System.Drawing.Size(289, 22);
            this.txtorderid.TabIndex = 14;
            // 
            // lblorderid
            // 
            this.lblorderid.AutoSize = true;
            this.lblorderid.Location = new System.Drawing.Point(178, 407);
            this.lblorderid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblorderid.Name = "lblorderid";
            this.lblorderid.Size = new System.Drawing.Size(57, 16);
            this.lblorderid.TabIndex = 13;
            this.lblorderid.Text = "Order ID";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(191, 455);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 16);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Status";
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
            this.dgvgrid.Location = new System.Drawing.Point(147, 119);
            this.dgvgrid.Name = "dgvgrid";
            this.dgvgrid.RowHeadersWidth = 51;
            this.dgvgrid.RowTemplate.Height = 24;
            this.dgvgrid.Size = new System.Drawing.Size(527, 184);
            this.dgvgrid.TabIndex = 11;
            // 
            // lblUpdateOrderStatus
            // 
            this.lblUpdateOrderStatus.AutoSize = true;
            this.lblUpdateOrderStatus.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateOrderStatus.Location = new System.Drawing.Point(316, 344);
            this.lblUpdateOrderStatus.Name = "lblUpdateOrderStatus";
            this.lblUpdateOrderStatus.Size = new System.Drawing.Size(184, 24);
            this.lblUpdateOrderStatus.TabIndex = 10;
            this.lblUpdateOrderStatus.Text = "Update Order Status";
            // 
            // lblallorders
            // 
            this.lblallorders.AutoSize = true;
            this.lblallorders.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblallorders.Location = new System.Drawing.Point(323, 58);
            this.lblallorders.Name = "lblallorders";
            this.lblallorders.Size = new System.Drawing.Size(170, 40);
            this.lblallorders.TabIndex = 9;
            this.lblallorders.Text = "All Orders";
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(320, 715);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(91, 41);
            this.btndelete.TabIndex = 24;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // txtorder
            // 
            this.txtorder.Location = new System.Drawing.Point(228, 666);
            this.txtorder.Name = "txtorder";
            this.txtorder.Size = new System.Drawing.Size(289, 22);
            this.txtorder.TabIndex = 23;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(166, 672);
            this.lblid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(57, 16);
            this.lblid.TabIndex = 22;
            this.lblid.Text = "Order ID";
            // 
            // lbldelete
            // 
            this.lbldelete.AutoSize = true;
            this.lbldelete.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldelete.Location = new System.Drawing.Point(294, 610);
            this.lbldelete.Name = "lbldelete";
            this.lbldelete.Size = new System.Drawing.Size(145, 24);
            this.lbldelete.TabIndex = 21;
            this.lbldelete.Text = "Delete an Order";
            // 
            // Manageorders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 806);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.txtorder);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lbldelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.txtorderid);
            this.Controls.Add(this.lblorderid);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.dgvgrid);
            this.Controls.Add(this.lblUpdateOrderStatus);
            this.Controls.Add(this.lblallorders);
            this.Name = "Manageorders";
            this.Text = "Manageorders";
            ((System.ComponentModel.ISupportInitialize)(this.dgvgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtstatus;
        private System.Windows.Forms.TextBox txtorderid;
        private System.Windows.Forms.Label lblorderid;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridView dgvgrid;
        private System.Windows.Forms.Label lblUpdateOrderStatus;
        private System.Windows.Forms.Label lblallorders;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.TextBox txtorder;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lbldelete;
    }
}