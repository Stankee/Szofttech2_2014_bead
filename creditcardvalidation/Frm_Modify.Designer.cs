namespace CreditCardValidation
{
    partial class Frm_Modify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Modify));
            this.txt_vnevM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_knevM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_change = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_kartya4 = new System.Windows.Forms.TextBox();
            this.txt_kartya3 = new System.Windows.Forms.TextBox();
            this.txt_kartya2 = new System.Windows.Forms.TextBox();
            this.txt_kartya1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_vnevM
            // 
            this.txt_vnevM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_vnevM.Location = new System.Drawing.Point(85, 11);
            this.txt_vnevM.Name = "txt_vnevM";
            this.txt_vnevM.Size = new System.Drawing.Size(162, 20);
            this.txt_vnevM.TabIndex = 1;
            this.txt_vnevM.TextChanged += new System.EventHandler(this.txt_vnev_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vezetéknév:";
            // 
            // txt_knevM
            // 
            this.txt_knevM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_knevM.Location = new System.Drawing.Point(85, 37);
            this.txt_knevM.Name = "txt_knevM";
            this.txt_knevM.Size = new System.Drawing.Size(162, 20);
            this.txt_knevM.TabIndex = 2;
            this.txt_knevM.TextChanged += new System.EventHandler(this.txt_knev_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Keresztnév:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kártyaszám";
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(131, 98);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(75, 23);
            this.btn_change.TabIndex = 7;
            this.btn_change.Text = "Módosítás";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CreditCardValidation.Properties.Resources.red_cross;
            this.pictureBox1.Location = new System.Drawing.Point(309, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // txt_kartya4
            // 
            this.txt_kartya4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_kartya4.Location = new System.Drawing.Point(253, 63);
            this.txt_kartya4.MaxLength = 4;
            this.txt_kartya4.Name = "txt_kartya4";
            this.txt_kartya4.Size = new System.Drawing.Size(50, 20);
            this.txt_kartya4.TabIndex = 6;
            this.txt_kartya4.TextChanged += new System.EventHandler(this.txt_kartya4_TextChanged);
            // 
            // txt_kartya3
            // 
            this.txt_kartya3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_kartya3.Location = new System.Drawing.Point(197, 63);
            this.txt_kartya3.MaxLength = 4;
            this.txt_kartya3.Name = "txt_kartya3";
            this.txt_kartya3.Size = new System.Drawing.Size(50, 20);
            this.txt_kartya3.TabIndex = 5;
            this.txt_kartya3.TextChanged += new System.EventHandler(this.txt_kartya3_TextChanged);
            // 
            // txt_kartya2
            // 
            this.txt_kartya2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_kartya2.Location = new System.Drawing.Point(141, 63);
            this.txt_kartya2.MaxLength = 4;
            this.txt_kartya2.Name = "txt_kartya2";
            this.txt_kartya2.Size = new System.Drawing.Size(50, 20);
            this.txt_kartya2.TabIndex = 4;
            this.txt_kartya2.TextChanged += new System.EventHandler(this.txt_kartya2_TextChanged);
            // 
            // txt_kartya1
            // 
            this.txt_kartya1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_kartya1.Location = new System.Drawing.Point(85, 63);
            this.txt_kartya1.MaxLength = 4;
            this.txt_kartya1.Name = "txt_kartya1";
            this.txt_kartya1.Size = new System.Drawing.Size(50, 20);
            this.txt_kartya1.TabIndex = 3;
            this.txt_kartya1.TextChanged += new System.EventHandler(this.txt_kartya1_TextChanged);
            // 
            // Frm_Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 132);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_kartya4);
            this.Controls.Add(this.txt_kartya3);
            this.Controls.Add(this.txt_kartya2);
            this.Controls.Add(this.txt_kartya1);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_knevM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_vnevM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Frm_Modify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Módosítás";
            this.Load += new System.EventHandler(this.Frm_Modify_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_Modify_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_vnevM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_knevM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_kartya4;
        private System.Windows.Forms.TextBox txt_kartya3;
        private System.Windows.Forms.TextBox txt_kartya2;
        private System.Windows.Forms.TextBox txt_kartya1;
    }
}