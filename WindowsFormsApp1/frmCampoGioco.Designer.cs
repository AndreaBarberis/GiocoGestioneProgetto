﻿namespace WindowsFormsApp1
{
    partial class frmCampoGioco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCampoGioco));
            this.txtTruppeDisponibili = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Disciplina = new System.Windows.Forms.Label();
            this.txtDisc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtComb = new System.Windows.Forms.TextBox();
            this.lstMessaggi = new System.Windows.Forms.ListBox();
            this.btnAttacca = new System.Windows.Forms.Button();
            this.btnBonus = new System.Windows.Forms.Button();
            this.btnAzioni = new System.Windows.Forms.Button();
            this.btnEsci = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOpzioni = new System.Windows.Forms.Button();
            this.N1 = new System.Windows.Forms.NumericUpDown();
            this.N2 = new System.Windows.Forms.NumericUpDown();
            this.N3 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.N1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTruppeDisponibili
            // 
            this.txtTruppeDisponibili.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtTruppeDisponibili.Enabled = false;
            this.txtTruppeDisponibili.ForeColor = System.Drawing.Color.Red;
            this.txtTruppeDisponibili.Location = new System.Drawing.Point(22, 304);
            this.txtTruppeDisponibili.Name = "txtTruppeDisponibili";
            this.txtTruppeDisponibili.Size = new System.Drawing.Size(127, 20);
            this.txtTruppeDisponibili.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(22, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Truppe disponibili";
            // 
            // Disciplina
            // 
            this.Disciplina.AutoSize = true;
            this.Disciplina.BackColor = System.Drawing.SystemColors.ControlText;
            this.Disciplina.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Disciplina.Location = new System.Drawing.Point(22, 352);
            this.Disciplina.Name = "Disciplina";
            this.Disciplina.Size = new System.Drawing.Size(52, 13);
            this.Disciplina.TabIndex = 3;
            this.Disciplina.Text = "Disciplina";
            // 
            // txtDisc
            // 
            this.txtDisc.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtDisc.Enabled = false;
            this.txtDisc.ForeColor = System.Drawing.SystemColors.Window;
            this.txtDisc.Location = new System.Drawing.Point(22, 371);
            this.txtDisc.Name = "txtDisc";
            this.txtDisc.Size = new System.Drawing.Size(127, 20);
            this.txtDisc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(19, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Combattività";
            // 
            // txtComb
            // 
            this.txtComb.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtComb.Enabled = false;
            this.txtComb.ForeColor = System.Drawing.SystemColors.Window;
            this.txtComb.Location = new System.Drawing.Point(19, 438);
            this.txtComb.Name = "txtComb";
            this.txtComb.Size = new System.Drawing.Size(127, 20);
            this.txtComb.TabIndex = 4;
            // 
            // lstMessaggi
            // 
            this.lstMessaggi.FormattingEnabled = true;
            this.lstMessaggi.Location = new System.Drawing.Point(176, 396);
            this.lstMessaggi.Name = "lstMessaggi";
            this.lstMessaggi.Size = new System.Drawing.Size(578, 95);
            this.lstMessaggi.TabIndex = 6;
            // 
            // btnAttacca
            // 
            this.btnAttacca.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAttacca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttacca.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAttacca.Location = new System.Drawing.Point(200, 330);
            this.btnAttacca.Name = "btnAttacca";
            this.btnAttacca.Size = new System.Drawing.Size(151, 38);
            this.btnAttacca.TabIndex = 7;
            this.btnAttacca.Text = "assalta";
            this.btnAttacca.UseVisualStyleBackColor = false;
            // 
            // btnBonus
            // 
            this.btnBonus.BackColor = System.Drawing.Color.Turquoise;
            this.btnBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBonus.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBonus.Location = new System.Drawing.Point(406, 330);
            this.btnBonus.Name = "btnBonus";
            this.btnBonus.Size = new System.Drawing.Size(137, 38);
            this.btnBonus.TabIndex = 8;
            this.btnBonus.Text = "usa bonus";
            this.btnBonus.UseVisualStyleBackColor = false;
            // 
            // btnAzioni
            // 
            this.btnAzioni.BackColor = System.Drawing.Color.SandyBrown;
            this.btnAzioni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzioni.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAzioni.Location = new System.Drawing.Point(597, 330);
            this.btnAzioni.Name = "btnAzioni";
            this.btnAzioni.Size = new System.Drawing.Size(137, 38);
            this.btnAzioni.TabIndex = 9;
            this.btnAzioni.Text = "azioni";
            this.btnAzioni.UseVisualStyleBackColor = false;
            // 
            // btnEsci
            // 
            this.btnEsci.BackColor = System.Drawing.Color.Red;
            this.btnEsci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEsci.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEsci.Location = new System.Drawing.Point(760, 438);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(125, 61);
            this.btnEsci.TabIndex = 10;
            this.btnEsci.Text = "esci dal gioco";
            this.btnEsci.UseVisualStyleBackColor = false;
            this.btnEsci.Click += new System.EventHandler(this.btnEsci_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox3.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox3.Location = new System.Drawing.Point(200, 304);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(151, 20);
            this.textBox3.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlText;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(197, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Seleziona qta truppe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(177, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Telegrammi dal Fronte";
            // 
            // btnOpzioni
            // 
            this.btnOpzioni.BackColor = System.Drawing.Color.Yellow;
            this.btnOpzioni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpzioni.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOpzioni.Location = new System.Drawing.Point(760, 371);
            this.btnOpzioni.Name = "btnOpzioni";
            this.btnOpzioni.Size = new System.Drawing.Size(125, 49);
            this.btnOpzioni.TabIndex = 14;
            this.btnOpzioni.Text = "Musica si/no";
            this.btnOpzioni.UseVisualStyleBackColor = false;
            this.btnOpzioni.Click += new System.EventHandler(this.btnOpzioni_Click);
            // 
            // N1
            // 
            this.N1.Location = new System.Drawing.Point(209, 98);
            this.N1.Name = "N1";
            this.N1.Size = new System.Drawing.Size(92, 20);
            this.N1.TabIndex = 15;
            // 
            // N2
            // 
            this.N2.Location = new System.Drawing.Point(364, 191);
            this.N2.Name = "N2";
            this.N2.Size = new System.Drawing.Size(74, 20);
            this.N2.TabIndex = 16;
            // 
            // N3
            // 
            this.N3.Location = new System.Drawing.Point(559, 269);
            this.N3.Name = "N3";
            this.N3.Size = new System.Drawing.Size(68, 20);
            this.N3.TabIndex = 17;
            // 
            // frmCampoGioco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.WWOne09;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(915, 518);
            this.Controls.Add(this.N3);
            this.Controls.Add(this.N2);
            this.Controls.Add(this.N1);
            this.Controls.Add(this.btnOpzioni);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btnEsci);
            this.Controls.Add(this.btnAzioni);
            this.Controls.Add(this.btnBonus);
            this.Controls.Add(this.btnAttacca);
            this.Controls.Add(this.lstMessaggi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtComb);
            this.Controls.Add(this.Disciplina);
            this.Controls.Add(this.txtDisc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTruppeDisponibili);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCampoGioco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCampoGioco";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCampoGioco_FormClosing);
            this.Load += new System.EventHandler(this.frmCampoGioco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.N1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTruppeDisponibili;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Disciplina;
        private System.Windows.Forms.TextBox txtDisc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtComb;
        private System.Windows.Forms.ListBox lstMessaggi;
        private System.Windows.Forms.Button btnAttacca;
        private System.Windows.Forms.Button btnBonus;
        private System.Windows.Forms.Button btnAzioni;
        private System.Windows.Forms.Button btnEsci;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOpzioni;
        private System.Windows.Forms.NumericUpDown N1;
        private System.Windows.Forms.NumericUpDown N2;
        private System.Windows.Forms.NumericUpDown N3;
    }
}