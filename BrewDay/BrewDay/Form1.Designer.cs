namespace BrewDay
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ingredi = new System.Windows.Forms.Button();
            this.reclist = new System.Windows.Forms.Button();
            this.wsibt = new System.Windows.Forms.Button();
            this.brwsrec = new System.Windows.Forms.Button();
            this.curbrewing = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.login = new System.Windows.Forms.LinkLabel();
            this.ExitIcon = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BrowseRecipesPanel = new System.Windows.Forms.Panel();
            this.commentPanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.browseBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.browseDatagrid = new System.Windows.Forms.DataGridView();
            this.recipe_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WhatShouldIBrwPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RecipeListPanel = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fav_recBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new BrewDay.databaseDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.recipenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.addRec = new System.Windows.Forms.Button();
            this.EditFavs = new System.Windows.Forms.Button();
            this.ModRec = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.IngListPanel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.databaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.favrecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fav_recTableAdapter = new BrewDay.databaseDataSetTableAdapters.fav_recTableAdapter();
            this.ingredientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ingredientsTableAdapter = new BrewDay.databaseDataSetTableAdapters.ingredientsTableAdapter();
            this.tableAdapterManager = new BrewDay.databaseDataSetTableAdapters.TableAdapterManager();
            this.userTableAdapter = new BrewDay.databaseDataSetTableAdapters.userTableAdapter();
            this.ingredientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LogoPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitIcon)).BeginInit();
            this.BrowseRecipesPanel.SuspendLayout();
            this.commentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.browseDatagrid)).BeginInit();
            this.WhatShouldIBrwPanel.SuspendLayout();
            this.RecipeListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fav_recBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel6.SuspendLayout();
            this.IngListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.favrecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoPanel
            // 
            this.LogoPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.LogoPanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.LogoPanel.Controls.Add(this.panel5);
            this.LogoPanel.Controls.Add(this.panel3);
            resources.ApplyResources(this.LogoPanel, "LogoPanel");
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.ingredi);
            this.panel5.Controls.Add(this.reclist);
            this.panel5.Controls.Add(this.wsibt);
            this.panel5.Controls.Add(this.brwsrec);
            this.panel5.Controls.Add(this.curbrewing);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // ingredi
            // 
            this.ingredi.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.ingredi, "ingredi");
            this.ingredi.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.ingredi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ingredi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.ingredi.ForeColor = System.Drawing.Color.Khaki;
            this.ingredi.Name = "ingredi";
            this.ingredi.UseVisualStyleBackColor = false;
            this.ingredi.Click += new System.EventHandler(this.ingredi_Click);
            // 
            // reclist
            // 
            this.reclist.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.reclist, "reclist");
            this.reclist.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.reclist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.reclist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.reclist.ForeColor = System.Drawing.Color.Khaki;
            this.reclist.Name = "reclist";
            this.reclist.UseVisualStyleBackColor = false;
            this.reclist.Click += new System.EventHandler(this.reclist_Click);
            // 
            // wsibt
            // 
            this.wsibt.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.wsibt, "wsibt");
            this.wsibt.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.wsibt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.wsibt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.wsibt.ForeColor = System.Drawing.Color.Khaki;
            this.wsibt.Name = "wsibt";
            this.wsibt.UseVisualStyleBackColor = false;
            this.wsibt.Click += new System.EventHandler(this.wsibt_Click);
            // 
            // brwsrec
            // 
            this.brwsrec.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.brwsrec, "brwsrec");
            this.brwsrec.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.brwsrec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.brwsrec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.brwsrec.ForeColor = System.Drawing.Color.Khaki;
            this.brwsrec.Name = "brwsrec";
            this.brwsrec.UseVisualStyleBackColor = false;
            this.brwsrec.Click += new System.EventHandler(this.brwsrec_Click);
            // 
            // curbrewing
            // 
            this.curbrewing.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.curbrewing, "curbrewing");
            this.curbrewing.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.curbrewing.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.curbrewing.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.curbrewing.ForeColor = System.Drawing.Color.Khaki;
            this.curbrewing.Name = "curbrewing";
            this.curbrewing.UseVisualStyleBackColor = false;
            this.curbrewing.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.login);
            this.panel2.Controls.Add(this.ExitIcon);
            this.panel2.Controls.Add(this.label11);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // login
            // 
            resources.ApplyResources(this.login, "login");
            this.login.LinkColor = System.Drawing.Color.Black;
            this.login.Name = "login";
            this.login.TabStop = true;
            this.login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.login_LinkClicked);
            // 
            // ExitIcon
            // 
            resources.ApplyResources(this.ExitIcon, "ExitIcon");
            this.ExitIcon.Name = "ExitIcon";
            this.ExitIcon.TabStop = false;
            this.ExitIcon.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // BrowseRecipesPanel
            // 
            this.BrowseRecipesPanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BrowseRecipesPanel.Controls.Add(this.pictureBox2);
            this.BrowseRecipesPanel.Controls.Add(this.pictureBox3);
            this.BrowseRecipesPanel.Controls.Add(this.button2);
            this.BrowseRecipesPanel.Controls.Add(this.textBox1);
            this.BrowseRecipesPanel.Controls.Add(this.label12);
            this.BrowseRecipesPanel.Controls.Add(this.comboBox1);
            this.BrowseRecipesPanel.Controls.Add(this.browseBox);
            this.BrowseRecipesPanel.Controls.Add(this.button1);
            this.BrowseRecipesPanel.Controls.Add(this.browseDatagrid);
            this.BrowseRecipesPanel.Controls.Add(this.label1);
            this.BrowseRecipesPanel.Controls.Add(this.label3);
            this.BrowseRecipesPanel.Controls.Add(this.label2);
            this.BrowseRecipesPanel.Controls.Add(this.commentPanel);
            resources.ApplyResources(this.BrowseRecipesPanel, "BrowseRecipesPanel");
            this.BrowseRecipesPanel.Name = "BrowseRecipesPanel";
            this.BrowseRecipesPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BrowseRecipesPanel_Paint);
            // 
            // commentPanel
            // 
            this.commentPanel.Controls.Add(this.button3);
            this.commentPanel.Controls.Add(this.textBox3);
            this.commentPanel.Controls.Add(this.label17);
            this.commentPanel.Controls.Add(this.listBox2);
            this.commentPanel.Controls.Add(this.label16);
            this.commentPanel.Controls.Add(this.textBox2);
            this.commentPanel.Controls.Add(this.label15);
            this.commentPanel.Controls.Add(this.listBox1);
            this.commentPanel.Controls.Add(this.label14);
            this.commentPanel.Controls.Add(this.label13);
            resources.ApplyResources(this.commentPanel, "commentPanel");
            this.commentPanel.Name = "commentPanel";
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.WindowFrame;
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.listBox2.ForeColor = System.Drawing.SystemColors.Info;
            this.listBox2.FormattingEnabled = true;
            resources.ApplyResources(this.listBox2, "listBox2");
            this.listBox2.Name = "listBox2";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.WindowFrame;
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.listBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.listBox1.FormattingEnabled = true;
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.Name = "listBox1";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BrewDay.Properties.Resources.info_icon;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BrewDay.Properties.Resources.basket_icon__1_;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.ForeColor = System.Drawing.Color.Silver;
            this.textBox1.Name = "textBox1";
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2"),
            resources.GetString("comboBox1.Items3")});
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // browseBox
            // 
            resources.ApplyResources(this.browseBox, "browseBox");
            this.browseBox.ForeColor = System.Drawing.Color.Silver;
            this.browseBox.Name = "browseBox";
            this.browseBox.TextChanged += new System.EventHandler(this.browseBox_TextChanged);
            this.browseBox.Enter += new System.EventHandler(this.browseBox_Enter);
            this.browseBox.Leave += new System.EventHandler(this.browseBox_Leave);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // browseDatagrid
            // 
            this.browseDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.browseDatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recipe_name,
            this.creator,
            this.time});
            resources.ApplyResources(this.browseDatagrid, "browseDatagrid");
            this.browseDatagrid.Name = "browseDatagrid";
            this.browseDatagrid.ReadOnly = true;
            this.browseDatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.browseDatagrid_CellContentClick);
            // 
            // recipe_name
            // 
            this.recipe_name.DataPropertyName = "recipe_name";
            resources.ApplyResources(this.recipe_name, "recipe_name");
            this.recipe_name.Name = "recipe_name";
            this.recipe_name.ReadOnly = true;
            // 
            // creator
            // 
            this.creator.DataPropertyName = "creator";
            resources.ApplyResources(this.creator, "creator");
            this.creator.Name = "creator";
            this.creator.ReadOnly = true;
            // 
            // time
            // 
            this.time.DataPropertyName = "time";
            resources.ApplyResources(this.time, "time");
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Name = "label1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Name = "label2";
            // 
            // WhatShouldIBrwPanel
            // 
            this.WhatShouldIBrwPanel.BackColor = System.Drawing.Color.Cornsilk;
            this.WhatShouldIBrwPanel.Controls.Add(this.label5);
            this.WhatShouldIBrwPanel.Controls.Add(this.label4);
            resources.ApplyResources(this.WhatShouldIBrwPanel, "WhatShouldIBrwPanel");
            this.WhatShouldIBrwPanel.Name = "WhatShouldIBrwPanel";
            this.WhatShouldIBrwPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.WhatShouldIBrwPanel_Paint);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // RecipeListPanel
            // 
            this.RecipeListPanel.BackColor = System.Drawing.Color.Cornsilk;
            this.RecipeListPanel.Controls.Add(this.dataGridView2);
            this.RecipeListPanel.Controls.Add(this.dataGridView1);
            this.RecipeListPanel.Controls.Add(this.panel6);
            this.RecipeListPanel.Controls.Add(this.label6);
            this.RecipeListPanel.Controls.Add(this.label7);
            resources.ApplyResources(this.RecipeListPanel, "RecipeListPanel");
            this.RecipeListPanel.Name = "RecipeListPanel";
            this.RecipeListPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.RecipeListPanel_Paint);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ColumnHeadersVisible = false;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.fav_recBindingSource;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ButtonShadow;
            resources.ApplyResources(this.dataGridView2, "dataGridView2");
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Cornsilk;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "recipe_name";
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // fav_recBindingSource
            // 
            this.fav_recBindingSource.DataMember = "fav_rec";
            this.fav_recBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "databaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recipenameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fav_recBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonShadow;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Cornsilk;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            // 
            // recipenameDataGridViewTextBoxColumn
            // 
            this.recipenameDataGridViewTextBoxColumn.DataPropertyName = "recipe_name";
            resources.ApplyResources(this.recipenameDataGridViewTextBoxColumn, "recipenameDataGridViewTextBoxColumn");
            this.recipenameDataGridViewTextBoxColumn.Name = "recipenameDataGridViewTextBoxColumn";
            this.recipenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.addRec);
            this.panel6.Controls.Add(this.EditFavs);
            this.panel6.Controls.Add(this.ModRec);
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // addRec
            // 
            this.addRec.BackColor = System.Drawing.SystemColors.ControlDark;
            resources.ApplyResources(this.addRec, "addRec");
            this.addRec.Name = "addRec";
            this.addRec.UseVisualStyleBackColor = false;
            // 
            // EditFavs
            // 
            this.EditFavs.BackColor = System.Drawing.SystemColors.ControlDark;
            resources.ApplyResources(this.EditFavs, "EditFavs");
            this.EditFavs.Name = "EditFavs";
            this.EditFavs.UseVisualStyleBackColor = false;
            // 
            // ModRec
            // 
            this.ModRec.BackColor = System.Drawing.SystemColors.ControlDark;
            resources.ApplyResources(this.ModRec, "ModRec");
            this.ModRec.Name = "ModRec";
            this.ModRec.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // IngListPanel
            // 
            this.IngListPanel.BackColor = System.Drawing.Color.Cornsilk;
            this.IngListPanel.Controls.Add(this.label10);
            this.IngListPanel.Controls.Add(this.label9);
            this.IngListPanel.Controls.Add(this.label8);
            resources.ApplyResources(this.IngListPanel, "IngListPanel");
            this.IngListPanel.Name = "IngListPanel";
            this.IngListPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.IngListPanel_Paint);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // databaseDataSetBindingSource
            // 
            this.databaseDataSetBindingSource.DataSource = this.databaseDataSet;
            this.databaseDataSetBindingSource.Position = 0;
            // 
            // favrecBindingSource
            // 
            this.favrecBindingSource.DataMember = "fav_rec";
            this.favrecBindingSource.DataSource = this.databaseDataSetBindingSource;
            // 
            // fav_recTableAdapter
            // 
            this.fav_recTableAdapter.ClearBeforeFill = true;
            // 
            // ingredientsBindingSource
            // 
            this.ingredientsBindingSource.DataMember = "ingredients";
            this.ingredientsBindingSource.DataSource = this.databaseDataSetBindingSource;
            // 
            // ingredientsTableAdapter
            // 
            this.ingredientsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.fav_recTableAdapter = this.fav_recTableAdapter;
            this.tableAdapterManager.ingredientsTableAdapter = this.ingredientsTableAdapter;
            this.tableAdapterManager.recipe_commentTableAdapter = null;
            this.tableAdapterManager.recipesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BrewDay.databaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = this.userTableAdapter;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // ingredientsBindingSource1
            // 
            this.ingredientsBindingSource1.DataMember = "ingredients";
            this.ingredientsBindingSource1.DataSource = this.databaseDataSet;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.databaseDataSet;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LogoPanel);
            this.Controls.Add(this.BrowseRecipesPanel);
            this.Controls.Add(this.IngListPanel);
            this.Controls.Add(this.RecipeListPanel);
            this.Controls.Add(this.WhatShouldIBrwPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LogoPanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitIcon)).EndInit();
            this.BrowseRecipesPanel.ResumeLayout(false);
            this.BrowseRecipesPanel.PerformLayout();
            this.commentPanel.ResumeLayout(false);
            this.commentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.browseDatagrid)).EndInit();
            this.WhatShouldIBrwPanel.ResumeLayout(false);
            this.WhatShouldIBrwPanel.PerformLayout();
            this.RecipeListPanel.ResumeLayout(false);
            this.RecipeListPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fav_recBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.IngListPanel.ResumeLayout(false);
            this.IngListPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.favrecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ingredi;
        private System.Windows.Forms.Button reclist;
        private System.Windows.Forms.Button wsibt;
        private System.Windows.Forms.Button brwsrec;
        private System.Windows.Forms.Button curbrewing;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel BrowseRecipesPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel WhatShouldIBrwPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel RecipeListPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button addRec;
        private System.Windows.Forms.Button EditFavs;
        private System.Windows.Forms.Button ModRec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel IngListPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox ExitIcon;
        private System.Windows.Forms.LinkLabel login;
        private databaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource databaseDataSetBindingSource;
        private System.Windows.Forms.BindingSource favrecBindingSource;
        private databaseDataSetTableAdapters.fav_recTableAdapter fav_recTableAdapter;
        private System.Windows.Forms.BindingSource ingredientsBindingSource;
        private databaseDataSetTableAdapters.ingredientsTableAdapter ingredientsTableAdapter;
        private System.Windows.Forms.BindingSource ingredientsBindingSource1;
        private System.Windows.Forms.BindingSource fav_recBindingSource;
        private databaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private databaseDataSetTableAdapters.userTableAdapter userTableAdapter;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn recipenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView browseDatagrid;
        private System.Windows.Forms.TextBox browseBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn recipe_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn creator;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel commentPanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
    }
}

