namespace vovinam4
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.NumericUpDown numericUpDown1;
            System.Windows.Forms.Timer timer1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Score1 = new System.Windows.Forms.TextBox();
            this.Plus1 = new System.Windows.Forms.Button();
            this.Minus1 = new System.Windows.Forms.Button();
            this.Score2 = new System.Windows.Forms.TextBox();
            this.Minus2 = new System.Windows.Forms.Button();
            this.Plus2 = new System.Windows.Forms.Button();
            this.minus22 = new System.Windows.Forms.Button();
            this.plus22 = new System.Windows.Forms.Button();
            this.plus22b = new System.Windows.Forms.Button();
            this.minus22b = new System.Windows.Forms.Button();
            this.ResetPoints = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.ResetT = new System.Windows.Forms.Button();
            this.win = new System.Windows.Forms.Button();
            this.win1 = new System.Windows.Forms.Button();
            this.rstcolor = new System.Windows.Forms.Button();
            this.restclr = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(numericUpDown1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            numericUpDown1.CausesValidation = false;
            numericUpDown1.Cursor = System.Windows.Forms.Cursors.Default;
            numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numericUpDown1.ImeMode = System.Windows.Forms.ImeMode.Off;
            numericUpDown1.InterceptArrowKeys = false;
            numericUpDown1.Location = new System.Drawing.Point(705, 0);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.ReadOnly = true;
            numericUpDown1.Size = new System.Drawing.Size(42, 53);
            numericUpDown1.TabIndex = 13;
            numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Score1
            // 
            this.Score1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Score1.BackColor = System.Drawing.Color.Blue;
            this.Score1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Score1.Font = new System.Drawing.Font("Microsoft Sans Serif", 460F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.Score1.ForeColor = System.Drawing.SystemColors.Window;
            this.Score1.Location = new System.Drawing.Point(39, 53);
            this.Score1.Multiline = true;
            this.Score1.Name = "Score1";
            this.Score1.ReadOnly = true;
            this.Score1.Size = new System.Drawing.Size(533, 492);
            this.Score1.TabIndex = 0;
            this.Score1.Text = "0";
            this.Score1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Score1.TextChanged += new System.EventHandler(this.Score1_TextChanged);
            // 
            // Plus1
            // 
            this.Plus1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Plus1.Location = new System.Drawing.Point(227, 493);
            this.Plus1.Name = "Plus1";
            this.Plus1.Size = new System.Drawing.Size(75, 23);
            this.Plus1.TabIndex = 1;
            this.Plus1.Text = "+1";
            this.Plus1.UseVisualStyleBackColor = true;
            this.Plus1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Minus1
            // 
            this.Minus1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Minus1.Location = new System.Drawing.Point(131, 493);
            this.Minus1.Name = "Minus1";
            this.Minus1.Size = new System.Drawing.Size(79, 23);
            this.Minus1.TabIndex = 2;
            this.Minus1.Text = "-1";
            this.Minus1.UseVisualStyleBackColor = true;
            this.Minus1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Score2
            // 
            this.Score2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Score2.BackColor = System.Drawing.Color.Red;
            this.Score2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Score2.Font = new System.Drawing.Font("Microsoft Sans Serif", 460F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.Score2.ForeColor = System.Drawing.SystemColors.Window;
            this.Score2.Location = new System.Drawing.Point(666, 56);
            this.Score2.Multiline = true;
            this.Score2.Name = "Score2";
            this.Score2.Size = new System.Drawing.Size(533, 489);
            this.Score2.TabIndex = 3;
            this.Score2.Text = "0";
            this.Score2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Score2.TextChanged += new System.EventHandler(this.Score2_TextChanged);
            // 
            // Minus2
            // 
            this.Minus2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Minus2.Location = new System.Drawing.Point(985, 493);
            this.Minus2.Name = "Minus2";
            this.Minus2.Size = new System.Drawing.Size(75, 23);
            this.Minus2.TabIndex = 4;
            this.Minus2.Text = "-1";
            this.Minus2.UseVisualStyleBackColor = true;
            this.Minus2.Click += new System.EventHandler(this.Minus2_Click);
            // 
            // Plus2
            // 
            this.Plus2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Plus2.Location = new System.Drawing.Point(894, 493);
            this.Plus2.Name = "Plus2";
            this.Plus2.Size = new System.Drawing.Size(75, 23);
            this.Plus2.TabIndex = 5;
            this.Plus2.Text = "+1";
            this.Plus2.UseVisualStyleBackColor = true;
            this.Plus2.Click += new System.EventHandler(this.Plus2_Click);
            // 
            // minus22
            // 
            this.minus22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.minus22.Location = new System.Drawing.Point(985, 522);
            this.minus22.Name = "minus22";
            this.minus22.Size = new System.Drawing.Size(75, 23);
            this.minus22.TabIndex = 6;
            this.minus22.Text = "-2";
            this.minus22.UseVisualStyleBackColor = true;
            this.minus22.Click += new System.EventHandler(this.minus22_Click);
            // 
            // plus22
            // 
            this.plus22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.plus22.Location = new System.Drawing.Point(894, 522);
            this.plus22.Name = "plus22";
            this.plus22.Size = new System.Drawing.Size(75, 23);
            this.plus22.TabIndex = 7;
            this.plus22.Text = "+2";
            this.plus22.UseVisualStyleBackColor = true;
            this.plus22.Click += new System.EventHandler(this.plus22_Click);
            // 
            // plus22b
            // 
            this.plus22b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.plus22b.Location = new System.Drawing.Point(227, 522);
            this.plus22b.Name = "plus22b";
            this.plus22b.Size = new System.Drawing.Size(75, 23);
            this.plus22b.TabIndex = 9;
            this.plus22b.Text = "+2";
            this.plus22b.UseVisualStyleBackColor = true;
            this.plus22b.Click += new System.EventHandler(this.plus22b_Click);
            // 
            // minus22b
            // 
            this.minus22b.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.minus22b.Location = new System.Drawing.Point(131, 522);
            this.minus22b.Name = "minus22b";
            this.minus22b.Size = new System.Drawing.Size(79, 23);
            this.minus22b.TabIndex = 8;
            this.minus22b.Text = "-2";
            this.minus22b.UseVisualStyleBackColor = true;
            this.minus22b.Click += new System.EventHandler(this.minus22b_Click);
            // 
            // ResetPoints
            // 
            this.ResetPoints.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ResetPoints.BackColor = System.Drawing.Color.Yellow;
            this.ResetPoints.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResetPoints.Location = new System.Drawing.Point(567, 510);
            this.ResetPoints.Name = "ResetPoints";
            this.ResetPoints.Size = new System.Drawing.Size(90, 23);
            this.ResetPoints.TabIndex = 10;
            this.ResetPoints.Text = "Reset Score";
            this.ResetPoints.UseVisualStyleBackColor = false;
            this.ResetPoints.Click += new System.EventHandler(this.ResetP_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(511, -5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 58);
            this.label1.TabIndex = 11;
            this.label1.Text = "ROUND";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(540, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 63);
            this.label2.TabIndex = 14;
            this.label2.Text = "00:00";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Start
            // 
            this.Start.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Start.Location = new System.Drawing.Point(488, 541);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(84, 23);
            this.Start.TabIndex = 15;
            this.Start.Text = "Start Time";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Pause
            // 
            this.Pause.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Pause.BackColor = System.Drawing.Color.Red;
            this.Pause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Pause.Location = new System.Drawing.Point(578, 541);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(56, 23);
            this.Pause.TabIndex = 16;
            this.Pause.Text = "Pause";
            this.Pause.UseVisualStyleBackColor = false;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // ResetT
            // 
            this.ResetT.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ResetT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ResetT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResetT.Location = new System.Drawing.Point(640, 541);
            this.ResetT.Name = "ResetT";
            this.ResetT.Size = new System.Drawing.Size(84, 23);
            this.ResetT.TabIndex = 17;
            this.ResetT.Text = "Reset Time";
            this.ResetT.UseVisualStyleBackColor = false;
            this.ResetT.Click += new System.EventHandler(this.ResetT_Click);
            // 
            // win
            // 
            this.win.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.win.Location = new System.Drawing.Point(839, 493);
            this.win.Name = "win";
            this.win.Size = new System.Drawing.Size(49, 23);
            this.win.TabIndex = 18;
            this.win.Text = "win";
            this.win.UseVisualStyleBackColor = true;
            this.win.Click += new System.EventHandler(this.win_Click);
            this.win.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // win1
            // 
            this.win1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.win1.Location = new System.Drawing.Point(308, 493);
            this.win1.Name = "win1";
            this.win1.Size = new System.Drawing.Size(39, 23);
            this.win1.TabIndex = 19;
            this.win1.Text = "win";
            this.win1.UseVisualStyleBackColor = true;
            this.win1.Click += new System.EventHandler(this.win1_Click);
            // 
            // rstcolor
            // 
            this.rstcolor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rstcolor.Location = new System.Drawing.Point(308, 522);
            this.rstcolor.Name = "rstcolor";
            this.rstcolor.Size = new System.Drawing.Size(39, 23);
            this.rstcolor.TabIndex = 20;
            this.rstcolor.Text = "res";
            this.rstcolor.UseVisualStyleBackColor = true;
            this.rstcolor.Click += new System.EventHandler(this.rstcolor_Click);
            // 
            // restclr
            // 
            this.restclr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.restclr.Location = new System.Drawing.Point(839, 522);
            this.restclr.Name = "restclr";
            this.restclr.Size = new System.Drawing.Size(49, 23);
            this.restclr.TabIndex = 21;
            this.restclr.Text = "res";
            this.restclr.UseVisualStyleBackColor = true;
            this.restclr.Click += new System.EventHandler(this.restclr_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.toolStripTextBox1});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem6,
            this.toolStripMenuItem4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1238, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(81, 20);
            this.toolStripMenuItem2.Text = "Paramètres ";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(187, 22);
            this.toolStripMenuItem3.Text = "connexion au serveur";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9});
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(125, 20);
            this.toolStripMenuItem6.Text = "Gestion Des Arbitres";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem7.Image")));
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(480, 22);
            this.toolStripMenuItem7.Text = "Inscription Des Arbitres";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem8.Image")));
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(480, 22);
            this.toolStripMenuItem8.Text = "Configuration de l\'interface utilisateur pour le téléphone Portable des arbitres";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem9.Image")));
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(480, 22);
            this.toolStripMenuItem9.Text = "Configuration de la synchronisation des téléphones et des tablettes";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem10});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem4.Text = "Aide?";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem5.Image")));
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(226, 22);
            this.toolStripMenuItem5.Text = "Comment Utiliser Le Logiciel";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem10.Image")));
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(226, 22);
            this.toolStripMenuItem10.Text = "A propos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 576);
            this.ControlBox = false;
            this.Controls.Add(this.Score2);
            this.Controls.Add(numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.restclr);
            this.Controls.Add(this.rstcolor);
            this.Controls.Add(this.win1);
            this.Controls.Add(this.win);
            this.Controls.Add(this.ResetT);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Score1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResetPoints);
            this.Controls.Add(this.plus22b);
            this.Controls.Add(this.minus22b);
            this.Controls.Add(this.plus22);
            this.Controls.Add(this.minus22);
            this.Controls.Add(this.Plus2);
            this.Controls.Add(this.Minus2);
            this.Controls.Add(this.Minus1);
            this.Controls.Add(this.Plus1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "VVD FIGHTING TOOL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(numericUpDown1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Score1;
        private System.Windows.Forms.Button Plus1;
        private System.Windows.Forms.Button Minus1;
        private System.Windows.Forms.TextBox Score2;
        private System.Windows.Forms.Button Minus2;
        private System.Windows.Forms.Button Plus2;
        private System.Windows.Forms.Button minus22;
        private System.Windows.Forms.Button plus22;
        private System.Windows.Forms.Button plus22b;
        private System.Windows.Forms.Button minus22b;
        private System.Windows.Forms.Button ResetPoints;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Button ResetT;
        private System.Windows.Forms.Button win;
        private System.Windows.Forms.Button win1;
        private System.Windows.Forms.Button rstcolor;
        private System.Windows.Forms.Button restclr;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
    }
}

