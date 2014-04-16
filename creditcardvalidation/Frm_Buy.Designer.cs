namespace CreditCardValidation
{
    partial class Frm_Buy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Buy));
            this.lb_termekek = new System.Windows.Forms.ListBox();
            this.cb_vasarlok = new System.Windows.Forms.ComboBox();
            this.lb_kosar = new System.Windows.Forms.ListBox();
            this.btn_kosarba = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_teljesar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_egyenleg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_kiakosarbol = new System.Windows.Forms.Button();
            this.txt_szuro = new System.Windows.Forms.TextBox();
            this.txt_ar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_kategoriak = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lb_termekek
            // 
            this.lb_termekek.FormattingEnabled = true;
            this.lb_termekek.Location = new System.Drawing.Point(16, 109);
            this.lb_termekek.Name = "lb_termekek";
            this.lb_termekek.Size = new System.Drawing.Size(350, 264);
            this.lb_termekek.TabIndex = 0;
            this.lb_termekek.SelectedIndexChanged += new System.EventHandler(this.lb_termekek_SelectedIndexChanged);
            this.lb_termekek.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_termekek_MouseDoubleClick);
            // 
            // cb_vasarlok
            // 
            this.cb_vasarlok.FormattingEnabled = true;
            this.cb_vasarlok.Location = new System.Drawing.Point(16, 27);
            this.cb_vasarlok.Name = "cb_vasarlok";
            this.cb_vasarlok.Size = new System.Drawing.Size(237, 21);
            this.cb_vasarlok.TabIndex = 1;
            this.cb_vasarlok.Text = "-";
            this.cb_vasarlok.SelectedIndexChanged += new System.EventHandler(this.cb_vasarlok_SelectedIndexChanged);
            // 
            // lb_kosar
            // 
            this.lb_kosar.FormattingEnabled = true;
            this.lb_kosar.Location = new System.Drawing.Point(449, 83);
            this.lb_kosar.Name = "lb_kosar";
            this.lb_kosar.Size = new System.Drawing.Size(350, 290);
            this.lb_kosar.TabIndex = 0;
            this.lb_kosar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_kosar_MouseDoubleClick);
            // 
            // btn_kosarba
            // 
            this.btn_kosarba.Location = new System.Drawing.Point(391, 215);
            this.btn_kosarba.Name = "btn_kosarba";
            this.btn_kosarba.Size = new System.Drawing.Size(28, 28);
            this.btn_kosarba.TabIndex = 2;
            this.btn_kosarba.Text = ">>";
            this.btn_kosarba.UseVisualStyleBackColor = true;
            this.btn_kosarba.Click += new System.EventHandler(this.btn_kosarba_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vásárló";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Termékek:";
            // 
            // txt_teljesar
            // 
            this.txt_teljesar.Enabled = false;
            this.txt_teljesar.Location = new System.Drawing.Point(734, 379);
            this.txt_teljesar.Name = "txt_teljesar";
            this.txt_teljesar.Size = new System.Drawing.Size(65, 20);
            this.txt_teljesar.TabIndex = 5;
            this.txt_teljesar.Text = "0 Ft";
            this.txt_teljesar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(678, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Teljes ár:";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(368, 414);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Vásárlás";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Egyenleg";
            // 
            // txt_egyenleg
            // 
            this.txt_egyenleg.Enabled = false;
            this.txt_egyenleg.Location = new System.Drawing.Point(259, 28);
            this.txt_egyenleg.Name = "txt_egyenleg";
            this.txt_egyenleg.Size = new System.Drawing.Size(65, 20);
            this.txt_egyenleg.TabIndex = 9;
            this.txt_egyenleg.Text = "0 Ft";
            this.txt_egyenleg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(446, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kosár:";
            // 
            // btn_add
            // 
            this.btn_add.Enabled = false;
            this.btn_add.Location = new System.Drawing.Point(330, 26);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "+10000 Ft";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_kiakosarbol
            // 
            this.btn_kiakosarbol.Location = new System.Drawing.Point(391, 249);
            this.btn_kiakosarbol.Name = "btn_kiakosarbol";
            this.btn_kiakosarbol.Size = new System.Drawing.Size(28, 28);
            this.btn_kiakosarbol.TabIndex = 11;
            this.btn_kiakosarbol.Text = "<<";
            this.btn_kiakosarbol.UseVisualStyleBackColor = true;
            this.btn_kiakosarbol.Click += new System.EventHandler(this.btn_kiakosarbol_Click);
            // 
            // txt_szuro
            // 
            this.txt_szuro.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_szuro.Location = new System.Drawing.Point(16, 83);
            this.txt_szuro.Name = "txt_szuro";
            this.txt_szuro.Size = new System.Drawing.Size(350, 20);
            this.txt_szuro.TabIndex = 12;
            this.txt_szuro.Text = "Keresés";
            this.txt_szuro.TextChanged += new System.EventHandler(this.txt_szuro_TextChanged);
            this.txt_szuro.Enter += new System.EventHandler(this.txt_szuro_Enter);
            this.txt_szuro.Leave += new System.EventHandler(this.txt_szuro_Leave);
            // 
            // txt_ar
            // 
            this.txt_ar.Enabled = false;
            this.txt_ar.Location = new System.Drawing.Point(301, 379);
            this.txt_ar.Name = "txt_ar";
            this.txt_ar.Size = new System.Drawing.Size(65, 20);
            this.txt_ar.TabIndex = 13;
            this.txt_ar.Text = "0 Ft";
            this.txt_ar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Termék ára:";
            // 
            // cb_kategoriak
            // 
            this.cb_kategoriak.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.cb_kategoriak.FormattingEnabled = true;
            this.cb_kategoriak.Location = new System.Drawing.Point(77, 60);
            this.cb_kategoriak.Name = "cb_kategoriak";
            this.cb_kategoriak.Size = new System.Drawing.Size(176, 21);
            this.cb_kategoriak.TabIndex = 15;
            this.cb_kategoriak.Text = "Kategóriák";
            this.cb_kategoriak.SelectedIndexChanged += new System.EventHandler(this.cb_kategoriak_SelectedIndexChanged);
            this.cb_kategoriak.Enter += new System.EventHandler(this.cb_kategoriak_Enter);
            // 
            // Frm_Buy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 449);
            this.Controls.Add(this.cb_kategoriak);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_ar);
            this.Controls.Add(this.txt_szuro);
            this.Controls.Add(this.btn_kiakosarbol);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_egyenleg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_teljesar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_kosarba);
            this.Controls.Add(this.cb_vasarlok);
            this.Controls.Add(this.lb_kosar);
            this.Controls.Add(this.lb_termekek);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Buy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Új vásárlás felvétele";
            this.Load += new System.EventHandler(this.Frm_Buy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_termekek;
        private System.Windows.Forms.ComboBox cb_vasarlok;
        private System.Windows.Forms.ListBox lb_kosar;
        private System.Windows.Forms.Button btn_kosarba;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_teljesar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_egyenleg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_kiakosarbol;
        private System.Windows.Forms.TextBox txt_szuro;
        private System.Windows.Forms.TextBox txt_ar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_kategoriak;
    }
}