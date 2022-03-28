
namespace MyEntityCrud
{
    partial class frmMyApp
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
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.lblCountryId = new System.Windows.Forms.Label();
            this.lblCountryName = new System.Windows.Forms.Label();
            this.txtCountryId = new System.Windows.Forms.TextBox();
            this.txtCountryName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.Location = new System.Drawing.Point(0, 0);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(240, 150);
            this.dgvData.TabIndex = 7;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // 
            // lblCountryId
            // 
            this.lblCountryId.AutoSize = true;
            this.lblCountryId.Location = new System.Drawing.Point(321, 62);
            this.lblCountryId.Name = "lblCountryId";
            this.lblCountryId.Size = new System.Drawing.Size(64, 13);
            this.lblCountryId.TabIndex = 1;
            this.lblCountryId.Text = "Country Id : ";
            // 
            // lblCountryName
            // 
            this.lblCountryName.AutoSize = true;
            this.lblCountryName.Location = new System.Drawing.Point(302, 96);
            this.lblCountryName.Name = "lblCountryName";
            this.lblCountryName.Size = new System.Drawing.Size(83, 13);
            this.lblCountryName.TabIndex = 2;
            this.lblCountryName.Text = "Country Name : ";
            // 
            // txtCountryId
            // 
            this.txtCountryId.Location = new System.Drawing.Point(400, 59);
            this.txtCountryId.Name = "txtCountryId";
            this.txtCountryId.Size = new System.Drawing.Size(100, 20);
            this.txtCountryId.TabIndex = 3;
            // 
            // txtCountryName
            // 
            this.txtCountryName.Location = new System.Drawing.Point(400, 93);
            this.txtCountryName.Name = "txtCountryName";
            this.txtCountryName.Size = new System.Drawing.Size(100, 20);
            this.txtCountryName.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(310, 126);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(413, 126);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(285, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(413, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmMyApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 199);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtCountryName);
            this.Controls.Add(this.txtCountryId);
            this.Controls.Add(this.lblCountryName);
            this.Controls.Add(this.lblCountryId);
            this.Controls.Add(this.dgvData);
            this.Name = "frmMyApp";
            this.Text = "My App";
            this.Load += new System.EventHandler(this.frmMyApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label lblCountryId;
        private System.Windows.Forms.Label lblCountryName;
        private System.Windows.Forms.TextBox txtCountryId;
        private System.Windows.Forms.TextBox txtCountryName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}

