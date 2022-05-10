namespace UrunTakip_PostgreSQL
{
    partial class FrmCustomerPurchaseHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomerPurchaseHistory));
            this.dataGridPurchaseHistory = new System.Windows.Forms.DataGridView();
            this.lblCustomerID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPurchaseHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPurchaseHistory
            // 
            this.dataGridPurchaseHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPurchaseHistory.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGridPurchaseHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPurchaseHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridPurchaseHistory.Location = new System.Drawing.Point(0, 0);
            this.dataGridPurchaseHistory.Name = "dataGridPurchaseHistory";
            this.dataGridPurchaseHistory.RowHeadersWidth = 51;
            this.dataGridPurchaseHistory.RowTemplate.Height = 24;
            this.dataGridPurchaseHistory.Size = new System.Drawing.Size(646, 313);
            this.dataGridPurchaseHistory.TabIndex = 0;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(606, 284);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(40, 29);
            this.lblCustomerID.TabIndex = 1;
            this.lblCustomerID.Text = "...";
            this.lblCustomerID.Visible = false;
            // 
            // FrmCustomerPurchaseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(646, 313);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.dataGridPurchaseHistory);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCustomerPurchaseHistory";
            this.Text = "Customer Purchase History";
            this.Load += new System.EventHandler(this.FrmCustomerPurchaseHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPurchaseHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPurchaseHistory;
        private System.Windows.Forms.Label lblCustomerID;
    }
}