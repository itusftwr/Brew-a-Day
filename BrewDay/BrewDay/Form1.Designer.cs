﻿namespace BrewDay
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label maltLabel;
            System.Windows.Forms.Label hopsLabel;
            System.Windows.Forms.Label yeastsLabel;
            System.Windows.Forms.Label sugarsLabel;
            System.Windows.Forms.Label additivesLabel;
            System.Windows.Forms.Label waterLabel;
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
            this.login = new System.Windows.Forms.LinkLabel();
            this.ExitIcon = new System.Windows.Forms.PictureBox();
            this.BrowseRecipesPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WhatShouldIBrwPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RecipeListPanel = new System.Windows.Forms.Panel();
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
            this.databaseDataSet = new BrewDay.databaseDataSet();
            this.databaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.favrecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fav_recTableAdapter = new BrewDay.databaseDataSetTableAdapters.fav_recTableAdapter();
            this.ingredientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ingredientsTableAdapter = new BrewDay.databaseDataSetTableAdapters.ingredientsTableAdapter();
            this.fav_recBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new BrewDay.databaseDataSetTableAdapters.TableAdapterManager();
            this.ingredientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.maltTextBox = new System.Windows.Forms.TextBox();
            this.hopsTextBox = new System.Windows.Forms.TextBox();
            this.yeastsTextBox = new System.Windows.Forms.TextBox();
            this.sugarsTextBox = new System.Windows.Forms.TextBox();
            this.additivesTextBox = new System.Windows.Forms.TextBox();
            this.waterTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            maltLabel = new System.Windows.Forms.Label();
            hopsLabel = new System.Windows.Forms.Label();
            yeastsLabel = new System.Windows.Forms.Label();
            sugarsLabel = new System.Windows.Forms.Label();
            additivesLabel = new System.Windows.Forms.Label();
            waterLabel = new System.Windows.Forms.Label();
            this.LogoPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitIcon)).BeginInit();
            this.BrowseRecipesPanel.SuspendLayout();
            this.WhatShouldIBrwPanel.SuspendLayout();
            this.RecipeListPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.IngListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.favrecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fav_recBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource1)).BeginInit();
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
            this.panel2.Controls.Add(this.login);
            this.panel2.Controls.Add(this.ExitIcon);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
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
            // BrowseRecipesPanel
            // 
            this.BrowseRecipesPanel.BackColor = System.Drawing.Color.Cornsilk;
            this.BrowseRecipesPanel.Controls.Add(this.label1);
            this.BrowseRecipesPanel.Controls.Add(this.label3);
            this.BrowseRecipesPanel.Controls.Add(this.label2);
            resources.ApplyResources(this.BrowseRecipesPanel, "BrowseRecipesPanel");
            this.BrowseRecipesPanel.Name = "BrowseRecipesPanel";
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
            this.RecipeListPanel.Controls.Add(this.panel6);
            this.RecipeListPanel.Controls.Add(this.label6);
            this.RecipeListPanel.Controls.Add(this.label7);
            resources.ApplyResources(this.RecipeListPanel, "RecipeListPanel");
            this.RecipeListPanel.Name = "RecipeListPanel";
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
            this.IngListPanel.Controls.Add(idLabel);
            this.IngListPanel.Controls.Add(this.idTextBox);
            this.IngListPanel.Controls.Add(maltLabel);
            this.IngListPanel.Controls.Add(this.maltTextBox);
            this.IngListPanel.Controls.Add(hopsLabel);
            this.IngListPanel.Controls.Add(this.hopsTextBox);
            this.IngListPanel.Controls.Add(yeastsLabel);
            this.IngListPanel.Controls.Add(this.yeastsTextBox);
            this.IngListPanel.Controls.Add(sugarsLabel);
            this.IngListPanel.Controls.Add(this.sugarsTextBox);
            this.IngListPanel.Controls.Add(additivesLabel);
            this.IngListPanel.Controls.Add(this.additivesTextBox);
            this.IngListPanel.Controls.Add(waterLabel);
            this.IngListPanel.Controls.Add(this.waterTextBox);
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
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "databaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // fav_recBindingSource
            // 
            this.fav_recBindingSource.DataMember = "fav_rec";
            this.fav_recBindingSource.DataSource = this.databaseDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.fav_recTableAdapter = this.fav_recTableAdapter;
            this.tableAdapterManager.ingredientsTableAdapter = this.ingredientsTableAdapter;
            this.tableAdapterManager.recipe_commentTableAdapter = null;
            this.tableAdapterManager.recipesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BrewDay.databaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // ingredientsBindingSource1
            // 
            this.ingredientsBindingSource1.DataMember = "ingredients";
            this.ingredientsBindingSource1.DataSource = this.databaseDataSet;
            // 
            // idLabel
            // 
            resources.ApplyResources(idLabel, "idLabel");
            idLabel.Name = "idLabel";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ingredientsBindingSource1, "id", true));
            resources.ApplyResources(this.idTextBox, "idTextBox");
            this.idTextBox.Name = "idTextBox";
            // 
            // maltLabel
            // 
            resources.ApplyResources(maltLabel, "maltLabel");
            maltLabel.Name = "maltLabel";
            // 
            // maltTextBox
            // 
            this.maltTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ingredientsBindingSource1, "malt", true));
            resources.ApplyResources(this.maltTextBox, "maltTextBox");
            this.maltTextBox.Name = "maltTextBox";
            // 
            // hopsLabel
            // 
            resources.ApplyResources(hopsLabel, "hopsLabel");
            hopsLabel.Name = "hopsLabel";
            // 
            // hopsTextBox
            // 
            this.hopsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ingredientsBindingSource1, "hops", true));
            resources.ApplyResources(this.hopsTextBox, "hopsTextBox");
            this.hopsTextBox.Name = "hopsTextBox";
            // 
            // yeastsLabel
            // 
            resources.ApplyResources(yeastsLabel, "yeastsLabel");
            yeastsLabel.Name = "yeastsLabel";
            // 
            // yeastsTextBox
            // 
            this.yeastsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ingredientsBindingSource1, "yeasts", true));
            resources.ApplyResources(this.yeastsTextBox, "yeastsTextBox");
            this.yeastsTextBox.Name = "yeastsTextBox";
            // 
            // sugarsLabel
            // 
            resources.ApplyResources(sugarsLabel, "sugarsLabel");
            sugarsLabel.Name = "sugarsLabel";
            // 
            // sugarsTextBox
            // 
            this.sugarsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ingredientsBindingSource1, "sugars", true));
            resources.ApplyResources(this.sugarsTextBox, "sugarsTextBox");
            this.sugarsTextBox.Name = "sugarsTextBox";
            // 
            // additivesLabel
            // 
            resources.ApplyResources(additivesLabel, "additivesLabel");
            additivesLabel.Name = "additivesLabel";
            // 
            // additivesTextBox
            // 
            this.additivesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ingredientsBindingSource1, "additives", true));
            resources.ApplyResources(this.additivesTextBox, "additivesTextBox");
            this.additivesTextBox.Name = "additivesTextBox";
            // 
            // waterLabel
            // 
            resources.ApplyResources(waterLabel, "waterLabel");
            waterLabel.Name = "waterLabel";
            // 
            // waterTextBox
            // 
            this.waterTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ingredientsBindingSource1, "water", true));
            resources.ApplyResources(this.waterTextBox, "waterTextBox");
            this.waterTextBox.Name = "waterTextBox";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.IngListPanel);
            this.Controls.Add(this.RecipeListPanel);
            this.Controls.Add(this.WhatShouldIBrwPanel);
            this.Controls.Add(this.BrowseRecipesPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LogoPanel);
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
            this.WhatShouldIBrwPanel.ResumeLayout(false);
            this.WhatShouldIBrwPanel.PerformLayout();
            this.RecipeListPanel.ResumeLayout(false);
            this.RecipeListPanel.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.IngListPanel.ResumeLayout(false);
            this.IngListPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.favrecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fav_recBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource1)).EndInit();
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
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox maltTextBox;
        private System.Windows.Forms.TextBox hopsTextBox;
        private System.Windows.Forms.TextBox yeastsTextBox;
        private System.Windows.Forms.TextBox sugarsTextBox;
        private System.Windows.Forms.TextBox additivesTextBox;
        private System.Windows.Forms.TextBox waterTextBox;
    }
}

