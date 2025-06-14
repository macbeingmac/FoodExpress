namespace FoodDeliverySystem.views
{
    partial class Managerestaurantsform
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
            this.lblmanagerestaurant = new System.Windows.Forms.Label();
            this.lblAddaRestaurant = new System.Windows.Forms.Label();
            this.dgvgrid = new System.Windows.Forms.DataGridView();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblRestaurantName = new System.Windows.Forms.Label();
            this.txtRestaurantName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtaddress1 = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lbladdress1 = new System.Windows.Forms.Label();
            this.lblupdaterestaurent = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.lbldelete = new System.Windows.Forms.Label();
            this.txtid1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblmanagerestaurant
            // 
            this.lblmanagerestaurant.AutoSize = true;
            this.lblmanagerestaurant.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmanagerestaurant.Location = new System.Drawing.Point(286, 45);
            this.lblmanagerestaurant.Name = "lblmanagerestaurant";
            this.lblmanagerestaurant.Size = new System.Drawing.Size(309, 40);
            this.lblmanagerestaurant.TabIndex = 0;
            this.lblmanagerestaurant.Text = "Manage Restaurant";
            // 
            // lblAddaRestaurant
            // 
            this.lblAddaRestaurant.AutoSize = true;
            this.lblAddaRestaurant.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddaRestaurant.Location = new System.Drawing.Point(343, 327);
            this.lblAddaRestaurant.Name = "lblAddaRestaurant";
            this.lblAddaRestaurant.Size = new System.Drawing.Size(158, 24);
            this.lblAddaRestaurant.TabIndex = 1;
            this.lblAddaRestaurant.Text = "Add a Restaurant";
            this.lblAddaRestaurant.Click += new System.EventHandler(this.lblAddaRestaurant_Click);
            // 
            // dgvgrid
            // 
            this.dgvgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvgrid.Location = new System.Drawing.Point(156, 108);
            this.dgvgrid.Name = "dgvgrid";
            this.dgvgrid.RowHeadersWidth = 51;
            this.dgvgrid.RowTemplate.Height = 24;
            this.dgvgrid.Size = new System.Drawing.Size(527, 184);
            this.dgvgrid.TabIndex = 2;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(204, 438);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 16);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address";
            // 
            // lblRestaurantName
            // 
            this.lblRestaurantName.AutoSize = true;
            this.lblRestaurantName.Location = new System.Drawing.Point(150, 390);
            this.lblRestaurantName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRestaurantName.Name = "lblRestaurantName";
            this.lblRestaurantName.Size = new System.Drawing.Size(112, 16);
            this.lblRestaurantName.TabIndex = 5;
            this.lblRestaurantName.Text = "Restaurant Name";
            // 
            // txtRestaurantName
            // 
            this.txtRestaurantName.Location = new System.Drawing.Point(267, 384);
            this.txtRestaurantName.Name = "txtRestaurantName";
            this.txtRestaurantName.Size = new System.Drawing.Size(289, 22);
            this.txtRestaurantName.TabIndex = 6;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(268, 432);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(289, 22);
            this.txtAddress.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(369, 474);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 41);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(369, 760);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(91, 41);
            this.btnupdate.TabIndex = 14;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            // 
            // txtaddress1
            // 
            this.txtaddress1.Location = new System.Drawing.Point(268, 670);
            this.txtaddress1.Name = "txtaddress1";
            this.txtaddress1.Size = new System.Drawing.Size(289, 22);
            this.txtaddress1.TabIndex = 13;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(267, 622);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(289, 22);
            this.txtname.TabIndex = 12;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(218, 628);
            this.lblname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(44, 16);
            this.lblname.TabIndex = 11;
            this.lblname.Text = "Name";
            // 
            // lbladdress1
            // 
            this.lbladdress1.AutoSize = true;
            this.lbladdress1.Location = new System.Drawing.Point(204, 673);
            this.lbladdress1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbladdress1.Name = "lbladdress1";
            this.lbladdress1.Size = new System.Drawing.Size(58, 16);
            this.lbladdress1.TabIndex = 10;
            this.lbladdress1.Text = "Address";
            // 
            // lblupdaterestaurent
            // 
            this.lblupdaterestaurent.AutoSize = true;
            this.lblupdaterestaurent.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblupdaterestaurent.Location = new System.Drawing.Point(343, 565);
            this.lblupdaterestaurent.Name = "lblupdaterestaurent";
            this.lblupdaterestaurent.Size = new System.Drawing.Size(170, 24);
            this.lblupdaterestaurent.TabIndex = 9;
            this.lblupdaterestaurent.Text = "Update Restaurant";
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(369, 948);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(91, 41);
            this.btndelete.TabIndex = 20;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(277, 899);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(289, 22);
            this.txtid.TabIndex = 18;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(242, 905);
            this.lblid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(20, 16);
            this.lblid.TabIndex = 17;
            this.lblid.Text = "ID";
            // 
            // lbldelete
            // 
            this.lbldelete.AutoSize = true;
            this.lbldelete.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldelete.Location = new System.Drawing.Point(343, 843);
            this.lbldelete.Name = "lbldelete";
            this.lbldelete.Size = new System.Drawing.Size(178, 24);
            this.lbldelete.TabIndex = 15;
            this.lbldelete.Text = "Delete a Restaurant";
            // 
            // txtid1
            // 
            this.txtid1.Location = new System.Drawing.Point(267, 718);
            this.txtid1.Name = "txtid1";
            this.txtid1.Size = new System.Drawing.Size(289, 22);
            this.txtid1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 724);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "ID";
            // 
            // Managerestaurantsform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 1028);
            this.Controls.Add(this.txtid1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lbldelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.txtaddress1);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lbladdress1);
            this.Controls.Add(this.lblupdaterestaurent);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtRestaurantName);
            this.Controls.Add(this.lblRestaurantName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.dgvgrid);
            this.Controls.Add(this.lblAddaRestaurant);
            this.Controls.Add(this.lblmanagerestaurant);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Managerestaurantsform";
            this.Text = "Managerestaurantsform";
            this.Load += new System.EventHandler(this.Managerestaurantsform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmanagerestaurant;
        private System.Windows.Forms.Label lblAddaRestaurant;
        private System.Windows.Forms.DataGridView dgvgrid;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblRestaurantName;
        private System.Windows.Forms.TextBox txtRestaurantName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtaddress1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbladdress1;
        private System.Windows.Forms.Label lblupdaterestaurent;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lbldelete;
        private System.Windows.Forms.TextBox txtid1;
        private System.Windows.Forms.Label label1;
    }
}