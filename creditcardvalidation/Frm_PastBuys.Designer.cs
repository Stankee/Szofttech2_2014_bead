namespace CreditCardValidation
{
    partial class Frm_PastBuys
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PastBuys));
            this.label1 = new System.Windows.Forms.Label();
            this.cb_vasarlok = new System.Windows.Forms.ComboBox();
            this.grid_vasarlasok = new System.Windows.Forms.DataGridView();
            this.cb_csoport = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_vasarlasok)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vásárló";
            // 
            // cb_vasarlok
            // 
            this.cb_vasarlok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_vasarlok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_vasarlok.FormattingEnabled = true;
            this.cb_vasarlok.Location = new System.Drawing.Point(15, 27);
            this.cb_vasarlok.Name = "cb_vasarlok";
            this.cb_vasarlok.Size = new System.Drawing.Size(237, 21);
            this.cb_vasarlok.TabIndex = 4;
            this.cb_vasarlok.SelectedIndexChanged += new System.EventHandler(this.cb_vasarlok_SelectedIndexChanged);
            // 
            // grid_vasarlasok
            // 
            this.grid_vasarlasok.AllowUserToAddRows = false;
            this.grid_vasarlasok.AllowUserToDeleteRows = false;
            this.grid_vasarlasok.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_vasarlasok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_vasarlasok.BackgroundColor = System.Drawing.Color.White;
            this.grid_vasarlasok.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_vasarlasok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_vasarlasok.Location = new System.Drawing.Point(15, 64);
            this.grid_vasarlasok.Name = "grid_vasarlasok";
            this.grid_vasarlasok.ReadOnly = true;
            this.grid_vasarlasok.Size = new System.Drawing.Size(778, 367);
            this.grid_vasarlasok.TabIndex = 6;
            // 
            // cb_csoport
            // 
            this.cb_csoport.AutoSize = true;
            this.cb_csoport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_csoport.Location = new System.Drawing.Point(705, 31);
            this.cb_csoport.Name = "cb_csoport";
            this.cb_csoport.Size = new System.Drawing.Size(89, 17);
            this.cb_csoport.TabIndex = 7;
            this.cb_csoport.Text = "Csoportosítás";
            this.cb_csoport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_csoport.UseVisualStyleBackColor = true;
            this.cb_csoport.CheckedChanged += new System.EventHandler(this.cb_csoport_CheckedChanged);
            // 
            // Frm_PastBuys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 443);
            this.Controls.Add(this.cb_csoport);
            this.Controls.Add(this.grid_vasarlasok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_vasarlok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_PastBuys";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Korábbi vásárlások";
            this.Load += new System.EventHandler(this.Frm_PastBuys_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_vasarlasok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_vasarlok;
        private System.Windows.Forms.DataGridView grid_vasarlasok;
        private System.Windows.Forms.CheckBox cb_csoport;
    }
}