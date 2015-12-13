namespace Client.Formlhm
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbAlpha = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbRush = new System.Windows.Forms.CheckBox();
            this.cbContinuation = new System.Windows.Forms.CheckBox();
            this.tbItineraire = new System.Windows.Forms.TextBox();
            this.tbClasseBag = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbJourExploitation = new System.Windows.Forms.TextBox();
            this.tbLigne = new System.Windows.Forms.TextBox();
            this.tbCompagnie = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxLogs = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(545, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "Rechercher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbAlpha);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 88);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche";
            // 
            // tbAlpha
            // 
            this.tbAlpha.Location = new System.Drawing.Point(99, 33);
            this.tbAlpha.Name = "tbAlpha";
            this.tbAlpha.Size = new System.Drawing.Size(425, 20);
            this.tbAlpha.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(545, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Ajouter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Code Iata :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(15, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(637, 260);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Résultat";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbRush);
            this.groupBox4.Controls.Add(this.cbContinuation);
            this.groupBox4.Controls.Add(this.tbItineraire);
            this.groupBox4.Controls.Add(this.tbClasseBag);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(334, 33);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(289, 206);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bagage";
            // 
            // cbRush
            // 
            this.cbRush.AutoSize = true;
            this.cbRush.Location = new System.Drawing.Point(141, 173);
            this.cbRush.Name = "cbRush";
            this.cbRush.Size = new System.Drawing.Size(51, 17);
            this.cbRush.TabIndex = 7;
            this.cbRush.Text = "Rush";
            this.cbRush.UseVisualStyleBackColor = true;
            // 
            // cbContinuation
            // 
            this.cbContinuation.AutoSize = true;
            this.cbContinuation.Location = new System.Drawing.Point(141, 138);
            this.cbContinuation.Name = "cbContinuation";
            this.cbContinuation.Size = new System.Drawing.Size(85, 17);
            this.cbContinuation.TabIndex = 6;
            this.cbContinuation.Text = "Continuation";
            this.cbContinuation.UseVisualStyleBackColor = true;
            // 
            // tbItineraire
            // 
            this.tbItineraire.Location = new System.Drawing.Point(107, 39);
            this.tbItineraire.Name = "tbItineraire";
            this.tbItineraire.Size = new System.Drawing.Size(126, 20);
            this.tbItineraire.TabIndex = 5;
            // 
            // tbClasseBag
            // 
            this.tbClasseBag.Location = new System.Drawing.Point(107, 98);
            this.tbClasseBag.Name = "tbClasseBag";
            this.tbClasseBag.Size = new System.Drawing.Size(126, 20);
            this.tbClasseBag.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Classe bagage :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Itinéraire :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbJourExploitation);
            this.groupBox3.Controls.Add(this.tbLigne);
            this.groupBox3.Controls.Add(this.tbCompagnie);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(17, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(291, 206);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vol";
            // 
            // tbJourExploitation
            // 
            this.tbJourExploitation.Location = new System.Drawing.Point(118, 152);
            this.tbJourExploitation.Name = "tbJourExploitation";
            this.tbJourExploitation.Size = new System.Drawing.Size(126, 20);
            this.tbJourExploitation.TabIndex = 6;
            // 
            // tbLigne
            // 
            this.tbLigne.Location = new System.Drawing.Point(118, 98);
            this.tbLigne.Name = "tbLigne";
            this.tbLigne.Size = new System.Drawing.Size(126, 20);
            this.tbLigne.TabIndex = 4;
            // 
            // tbCompagnie
            // 
            this.tbCompagnie.Location = new System.Drawing.Point(118, 35);
            this.tbCompagnie.Name = "tbCompagnie";
            this.tbCompagnie.Size = new System.Drawing.Size(126, 20);
            this.tbCompagnie.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Jour d\'exploitation :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ligne :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Compagnie :";
            // 
            // listBoxLogs
            // 
            this.listBoxLogs.FormattingEnabled = true;
            this.listBoxLogs.Location = new System.Drawing.Point(12, 389);
            this.listBoxLogs.Name = "listBoxLogs";
            this.listBoxLogs.Size = new System.Drawing.Size(640, 134);
            this.listBoxLogs.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 530);
            this.Controls.Add(this.listBoxLogs);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }
        

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAlpha;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbJourExploitation;
        private System.Windows.Forms.TextBox tbLigne;
        private System.Windows.Forms.TextBox tbCompagnie;
        private System.Windows.Forms.CheckBox cbRush;
        private System.Windows.Forms.CheckBox cbContinuation;
        private System.Windows.Forms.TextBox tbItineraire;
        private System.Windows.Forms.TextBox tbClasseBag;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBoxLogs;
    }
}

