namespace vovinam4
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cnctsrvr = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.stopsrvr = new System.Windows.Forms.Button();
            this.logsrvr = new System.Windows.Forms.TextBox();
            this.lblsrvr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Addresse IP";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 20);
            this.textBox1.TabIndex = 1;
            // 
            // cnctsrvr
            // 
            this.cnctsrvr.BackColor = System.Drawing.Color.Lime;
            this.cnctsrvr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cnctsrvr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cnctsrvr.Location = new System.Drawing.Point(201, 51);
            this.cnctsrvr.Name = "cnctsrvr";
            this.cnctsrvr.Size = new System.Drawing.Size(75, 23);
            this.cnctsrvr.TabIndex = 2;
            this.cnctsrvr.Text = "Connect";
            this.cnctsrvr.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(100, 54);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 20);
            this.textBox2.TabIndex = 4;
            // 
            // stopsrvr
            // 
            this.stopsrvr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.stopsrvr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stopsrvr.Location = new System.Drawing.Point(282, 51);
            this.stopsrvr.Name = "stopsrvr";
            this.stopsrvr.Size = new System.Drawing.Size(70, 23);
            this.stopsrvr.TabIndex = 5;
            this.stopsrvr.Text = "Stop";
            this.stopsrvr.UseVisualStyleBackColor = false;
            // 
            // logsrvr
            // 
            this.logsrvr.Location = new System.Drawing.Point(32, 115);
            this.logsrvr.Multiline = true;
            this.logsrvr.Name = "logsrvr";
            this.logsrvr.Size = new System.Drawing.Size(319, 116);
            this.logsrvr.TabIndex = 6;
            // 
            // lblsrvr
            // 
            this.lblsrvr.AutoSize = true;
            this.lblsrvr.Location = new System.Drawing.Point(29, 99);
            this.lblsrvr.Name = "lblsrvr";
            this.lblsrvr.Size = new System.Drawing.Size(88, 13);
            this.lblsrvr.TabIndex = 7;
            this.lblsrvr.Text = "log de connexion";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 255);
            this.Controls.Add(this.lblsrvr);
            this.Controls.Add(this.logsrvr);
            this.Controls.Add(this.stopsrvr);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cnctsrvr);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "configuration de la connexion au serveur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button cnctsrvr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button stopsrvr;
        private System.Windows.Forms.TextBox logsrvr;
        private System.Windows.Forms.Label lblsrvr;
    }
}