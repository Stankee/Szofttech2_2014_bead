namespace CreditCardValidation
{
    partial class Frm_Start
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Start));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_pastbuy = new System.Windows.Forms.Button();
            this.btn_change = new System.Windows.Forms.Button();
            this.btn_sqlDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_sql = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.másolásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_newBuy = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_addSQL = new System.Windows.Forms.Button();
            this.txt_knev = new System.Windows.Forms.TextBox();
            this.txt_vnev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_kartya4 = new System.Windows.Forms.TextBox();
            this.txt_kartya3 = new System.Windows.Forms.TextBox();
            this.txt_kartya2 = new System.Windows.Forms.TextBox();
            this.txt_kartya1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fájlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mentésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.súgóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.névjegyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.timer_save = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tlslabel_connect = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(-1, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(363, 277);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_pastbuy);
            this.tabPage3.Controls.Add(this.btn_change);
            this.tabPage3.Controls.Add(this.btn_sqlDelete);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.lb_sql);
            this.tabPage3.Controls.Add(this.btn_newBuy);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(355, 248);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Adatbázis";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_pastbuy
            // 
            this.btn_pastbuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_pastbuy.Location = new System.Drawing.Point(6, 138);
            this.btn_pastbuy.Name = "btn_pastbuy";
            this.btn_pastbuy.Size = new System.Drawing.Size(75, 23);
            this.btn_pastbuy.TabIndex = 7;
            this.btn_pastbuy.Text = "Vásárlások";
            this.btn_pastbuy.UseVisualStyleBackColor = true;
            this.btn_pastbuy.Click += new System.EventHandler(this.btn_pastbuy_Click);
            // 
            // btn_change
            // 
            this.btn_change.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_change.Location = new System.Drawing.Point(6, 167);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(75, 23);
            this.btn_change.TabIndex = 6;
            this.btn_change.Text = "Módosítás";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // btn_sqlDelete
            // 
            this.btn_sqlDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sqlDelete.Location = new System.Drawing.Point(6, 196);
            this.btn_sqlDelete.Name = "btn_sqlDelete";
            this.btn_sqlDelete.Size = new System.Drawing.Size(75, 23);
            this.btn_sqlDelete.TabIndex = 5;
            this.btn_sqlDelete.Text = "Törlés";
            this.btn_sqlDelete.UseVisualStyleBackColor = true;
            this.btn_sqlDelete.Click += new System.EventHandler(this.btn_sqlDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(187, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Kártyszám:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(89, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Név:";
            // 
            // lb_sql
            // 
            this.lb_sql.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_sql.ContextMenuStrip = this.contextMenuStrip1;
            this.lb_sql.FormattingEnabled = true;
            this.lb_sql.Location = new System.Drawing.Point(90, 19);
            this.lb_sql.Name = "lb_sql";
            this.lb_sql.Size = new System.Drawing.Size(259, 197);
            this.lb_sql.TabIndex = 2;
            this.lb_sql.SelectedIndexChanged += new System.EventHandler(this.lb_sql_SelectedIndexChanged);
            this.lb_sql.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_sql_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.másolásToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(187, 26);
            // 
            // másolásToolStripMenuItem
            // 
            this.másolásToolStripMenuItem.Name = "másolásToolStripMenuItem";
            this.másolásToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.másolásToolStripMenuItem.Text = "Kártyaszám másolása";
            this.másolásToolStripMenuItem.Click += new System.EventHandler(this.másolásToolStripMenuItem_Click);
            // 
            // btn_newBuy
            // 
            this.btn_newBuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_newBuy.Location = new System.Drawing.Point(6, 109);
            this.btn_newBuy.Name = "btn_newBuy";
            this.btn_newBuy.Size = new System.Drawing.Size(75, 23);
            this.btn_newBuy.TabIndex = 1;
            this.btn_newBuy.Text = "Új vásárlás";
            this.btn_newBuy.UseVisualStyleBackColor = true;
            this.btn_newBuy.Click += new System.EventHandler(this.btn_newBuy_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_addSQL);
            this.tabPage1.Controls.Add(this.txt_knev);
            this.tabPage1.Controls.Add(this.txt_vnev);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txt_kartya4);
            this.tabPage1.Controls.Add(this.txt_kartya3);
            this.tabPage1.Controls.Add(this.txt_kartya2);
            this.tabPage1.Controls.Add(this.txt_kartya1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(355, 248);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Új vásárló";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_addSQL
            // 
            this.btn_addSQL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_addSQL.Location = new System.Drawing.Point(140, 133);
            this.btn_addSQL.Name = "btn_addSQL";
            this.btn_addSQL.Size = new System.Drawing.Size(75, 23);
            this.btn_addSQL.TabIndex = 9;
            this.btn_addSQL.Text = "Add to SQL";
            this.btn_addSQL.UseVisualStyleBackColor = true;
            this.btn_addSQL.Click += new System.EventHandler(this.btn_addSQL_Click);
            // 
            // txt_knev
            // 
            this.txt_knev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_knev.Location = new System.Drawing.Point(105, 68);
            this.txt_knev.MaxLength = 50;
            this.txt_knev.Name = "txt_knev";
            this.txt_knev.Size = new System.Drawing.Size(163, 20);
            this.txt_knev.TabIndex = 2;
            this.txt_knev.TextChanged += new System.EventHandler(this.txt_knev_TextChanged);
            // 
            // txt_vnev
            // 
            this.txt_vnev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_vnev.Location = new System.Drawing.Point(105, 42);
            this.txt_vnev.MaxLength = 50;
            this.txt_vnev.Name = "txt_vnev";
            this.txt_vnev.Size = new System.Drawing.Size(163, 20);
            this.txt_vnev.TabIndex = 1;
            this.txt_vnev.TextChanged += new System.EventHandler(this.txt_vnev_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Keresztnév:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vezetéknév:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kártyaszám:";
            // 
            // txt_kartya4
            // 
            this.txt_kartya4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_kartya4.Location = new System.Drawing.Point(273, 94);
            this.txt_kartya4.MaxLength = 4;
            this.txt_kartya4.Name = "txt_kartya4";
            this.txt_kartya4.Size = new System.Drawing.Size(50, 20);
            this.txt_kartya4.TabIndex = 6;
            this.txt_kartya4.TextChanged += new System.EventHandler(this.txt_kartya4_TextChanged);
            // 
            // txt_kartya3
            // 
            this.txt_kartya3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_kartya3.Location = new System.Drawing.Point(217, 94);
            this.txt_kartya3.MaxLength = 4;
            this.txt_kartya3.Name = "txt_kartya3";
            this.txt_kartya3.Size = new System.Drawing.Size(50, 20);
            this.txt_kartya3.TabIndex = 5;
            this.txt_kartya3.TextChanged += new System.EventHandler(this.txt_kartya3_TextChanged);
            // 
            // txt_kartya2
            // 
            this.txt_kartya2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_kartya2.Location = new System.Drawing.Point(161, 94);
            this.txt_kartya2.MaxLength = 4;
            this.txt_kartya2.Name = "txt_kartya2";
            this.txt_kartya2.Size = new System.Drawing.Size(50, 20);
            this.txt_kartya2.TabIndex = 4;
            this.txt_kartya2.TextChanged += new System.EventHandler(this.txt_kartya2_TextChanged);
            // 
            // txt_kartya1
            // 
            this.txt_kartya1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_kartya1.Location = new System.Drawing.Point(105, 94);
            this.txt_kartya1.MaxLength = 4;
            this.txt_kartya1.Name = "txt_kartya1";
            this.txt_kartya1.Size = new System.Drawing.Size(50, 20);
            this.txt_kartya1.TabIndex = 3;
            this.txt_kartya1.TextChanged += new System.EventHandler(this.txt_kartya1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CreditCardValidation.Properties.Resources.red_cross;
            this.pictureBox1.Location = new System.Drawing.Point(329, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fájlToolStripMenuItem,
            this.súgóToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(359, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fájlToolStripMenuItem
            // 
            this.fájlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mentésToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            this.fájlToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fájlToolStripMenuItem.Text = "&Fájl";
            // 
            // mentésToolStripMenuItem
            // 
            this.mentésToolStripMenuItem.Name = "mentésToolStripMenuItem";
            this.mentésToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mentésToolStripMenuItem.Text = "&Mentés";
            this.mentésToolStripMenuItem.Click += new System.EventHandler(this.mentésToolStripMenuItem_Click);
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kilépésToolStripMenuItem.Text = "&Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // súgóToolStripMenuItem
            // 
            this.súgóToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.névjegyToolStripMenuItem});
            this.súgóToolStripMenuItem.Name = "súgóToolStripMenuItem";
            this.súgóToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.súgóToolStripMenuItem.Text = "&Súgó";
            // 
            // névjegyToolStripMenuItem
            // 
            this.névjegyToolStripMenuItem.Name = "névjegyToolStripMenuItem";
            this.névjegyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.névjegyToolStripMenuItem.Text = "&Névjegy";
            this.névjegyToolStripMenuItem.Click += new System.EventHandler(this.névjegyToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 248);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 35);
            this.panel1.TabIndex = 8;
            this.panel1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(110, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sikeresen hozzáadva!";
            // 
            // timer_save
            // 
            this.timer_save.Interval = 1000;
            this.timer_save.Tick += new System.EventHandler(this.timer_save_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlslabel_connect});
            this.statusStrip1.Location = new System.Drawing.Point(0, 282);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(359, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tlslabel_connect
            // 
            this.tlslabel_connect.Name = "tlslabel_connect";
            this.tlslabel_connect.Size = new System.Drawing.Size(68, 17);
            this.tlslabel_connect.Text = "Várakozás...";
            // 
            // Frm_Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 304);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adminisztráció";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Start_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Start_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txt_kartya4;
        private System.Windows.Forms.TextBox txt_kartya3;
        private System.Windows.Forms.TextBox txt_kartya2;
        private System.Windows.Forms.TextBox txt_kartya1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fájlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mentésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox txt_knev;
        private System.Windows.Forms.TextBox txt_vnev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer_save;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox lb_sql;
        private System.Windows.Forms.Button btn_addSQL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem másolásToolStripMenuItem;
        private System.Windows.Forms.Button btn_sqlDelete;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tlslabel_connect;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.ToolStripMenuItem súgóToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem névjegyToolStripMenuItem;
        private System.Windows.Forms.Button btn_newBuy;
        private System.Windows.Forms.Button btn_pastbuy;
    }
}

