namespace Browse_Restaurants
{
    partial class Form1
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
            this.lblAvailableRestaurants = new System.Windows.Forms.Label();
            this.lblselect = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblRestaurantList = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lstRestaurants = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAvailableRestaurants
            // 
            this.lblAvailableRestaurants.AutoSize = true;
            this.lblAvailableRestaurants.Location = new System.Drawing.Point(213, 20);
            this.lblAvailableRestaurants.Name = "lblAvailableRestaurants";
            this.lblAvailableRestaurants.Size = new System.Drawing.Size(139, 16);
            this.lblAvailableRestaurants.TabIndex = 0;
            this.lblAvailableRestaurants.Text = "Available Restaurants";
            // 
            // lblselect
            // 
            this.lblselect.AutoSize = true;
            this.lblselect.Location = new System.Drawing.Point(109, 166);
            this.lblselect.Name = "lblselect";
            this.lblselect.Size = new System.Drawing.Size(214, 16);
            this.lblselect.TabIndex = 2;
            this.lblselect.Text = "Select a restaurant to view its menu";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(112, 303);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // lblRestaurantList
            // 
            this.lblRestaurantList.AutoSize = true;
            this.lblRestaurantList.Location = new System.Drawing.Point(109, 42);
            this.lblRestaurantList.Name = "lblRestaurantList";
            this.lblRestaurantList.Size = new System.Drawing.Size(95, 16);
            this.lblRestaurantList.TabIndex = 1;
            this.lblRestaurantList.Text = "Restaurant List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(112, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 39);
            this.dataGridView1.TabIndex = 6;
            // 
            // lstRestaurants
            // 
            this.lstRestaurants.HideSelection = false;
            this.lstRestaurants.Location = new System.Drawing.Point(112, 78);
            this.lstRestaurants.Name = "lstRestaurants";
            this.lstRestaurants.Size = new System.Drawing.Size(121, 25);
            this.lstRestaurants.TabIndex = 7;
            this.lstRestaurants.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstRestaurants);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblselect);
            this.Controls.Add(this.lblRestaurantList);
            this.Controls.Add(this.lblAvailableRestaurants);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAvailableRestaurants;
        private System.Windows.Forms.Label lblselect;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblRestaurantList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListView lstRestaurants;
    }
}

