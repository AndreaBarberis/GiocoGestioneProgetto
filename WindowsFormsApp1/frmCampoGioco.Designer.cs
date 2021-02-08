namespace WindowsFormsApp1
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
            this.btnSposta = new System.Windows.Forms.Button();
            this.btnBonus = new System.Windows.Forms.Button();
            this.btnAzioni = new System.Windows.Forms.Button();
            this.btnEsci = new System.Windows.Forms.Button();
            this.txtSelezRiserve = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOpzioni = new System.Windows.Forms.Button();
            this.txtF1 = new System.Windows.Forms.TextBox();
            this.txtF2 = new System.Windows.Forms.TextBox();
            this.txtF3 = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txtFronte = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAssalta = new System.Windows.Forms.Button();
            this.btnPassa = new System.Windows.Forms.Button();
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
            // btnSposta
            // 
            this.btnSposta.BackColor = System.Drawing.Color.YellowGreen;
            this.btnSposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSposta.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSposta.Location = new System.Drawing.Point(200, 330);
            this.btnSposta.Name = "btnSposta";
            this.btnSposta.Size = new System.Drawing.Size(91, 38);
            this.btnSposta.TabIndex = 7;
            this.btnSposta.Text = "sposta";
            this.btnSposta.UseVisualStyleBackColor = false;
            this.btnSposta.Click += new System.EventHandler(this.btnSposta_Click);
            // 
            // btnBonus
            // 
            this.btnBonus.BackColor = System.Drawing.Color.Turquoise;
            this.btnBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBonus.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBonus.Location = new System.Drawing.Point(597, 339);
            this.btnBonus.Name = "btnBonus";
            this.btnBonus.Size = new System.Drawing.Size(75, 38);
            this.btnBonus.TabIndex = 8;
            this.btnBonus.Text = "usa bonus";
            this.btnBonus.UseVisualStyleBackColor = false;
            this.btnBonus.Click += new System.EventHandler(this.btnBonus_Click);
            // 
            // btnAzioni
            // 
            this.btnAzioni.BackColor = System.Drawing.Color.SandyBrown;
            this.btnAzioni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzioni.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAzioni.Location = new System.Drawing.Point(678, 339);
            this.btnAzioni.Name = "btnAzioni";
            this.btnAzioni.Size = new System.Drawing.Size(76, 38);
            this.btnAzioni.TabIndex = 9;
            this.btnAzioni.Text = "azioni";
            this.btnAzioni.UseVisualStyleBackColor = false;
            this.btnAzioni.Click += new System.EventHandler(this.btnAzioni_Click);
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
            // txtSelezRiserve
            // 
            this.txtSelezRiserve.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtSelezRiserve.ForeColor = System.Drawing.SystemColors.Window;
            this.txtSelezRiserve.Location = new System.Drawing.Point(200, 304);
            this.txtSelezRiserve.Name = "txtSelezRiserve";
            this.txtSelezRiserve.Size = new System.Drawing.Size(91, 20);
            this.txtSelezRiserve.TabIndex = 11;
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
            // txtF1
            // 
            this.txtF1.Enabled = false;
            this.txtF1.Location = new System.Drawing.Point(191, 95);
            this.txtF1.Name = "txtF1";
            this.txtF1.Size = new System.Drawing.Size(100, 20);
            this.txtF1.TabIndex = 15;
            // 
            // txtF2
            // 
            this.txtF2.Enabled = false;
            this.txtF2.Location = new System.Drawing.Point(353, 199);
            this.txtF2.Name = "txtF2";
            this.txtF2.Size = new System.Drawing.Size(100, 20);
            this.txtF2.TabIndex = 16;
            // 
            // txtF3
            // 
            this.txtF3.Enabled = false;
            this.txtF3.Location = new System.Drawing.Point(597, 278);
            this.txtF3.Name = "txtF3";
            this.txtF3.Size = new System.Drawing.Size(100, 20);
            this.txtF3.TabIndex = 17;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(275, 60);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(16, 13);
            this.lbl1.TabIndex = 18;
            this.lbl1.Text = "---";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(403, 159);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(16, 13);
            this.lbl2.TabIndex = 19;
            this.lbl2.Text = "---";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(631, 245);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(16, 13);
            this.lbl3.TabIndex = 20;
            this.lbl3.Text = "---";
            // 
            // txtFronte
            // 
            this.txtFronte.Location = new System.Drawing.Point(300, 345);
            this.txtFronte.Name = "txtFronte";
            this.txtFronte.Size = new System.Drawing.Size(148, 20);
            this.txtFronte.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "fronte dove spostare/assaltare";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(117, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Fronte nord";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(275, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "fronte centrale";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Highlight;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(523, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "fronte sud";
            // 
            // btnAssalta
            // 
            this.btnAssalta.BackColor = System.Drawing.Color.Blue;
            this.btnAssalta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAssalta.Location = new System.Drawing.Point(467, 339);
            this.btnAssalta.Name = "btnAssalta";
            this.btnAssalta.Size = new System.Drawing.Size(124, 38);
            this.btnAssalta.TabIndex = 26;
            this.btnAssalta.Text = "assalta";
            this.btnAssalta.UseVisualStyleBackColor = false;
            // 
            // btnPassa
            // 
            this.btnPassa.BackColor = System.Drawing.Color.Crimson;
            this.btnPassa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPassa.Location = new System.Drawing.Point(760, 318);
            this.btnPassa.Name = "btnPassa";
            this.btnPassa.Size = new System.Drawing.Size(125, 47);
            this.btnPassa.TabIndex = 27;
            this.btnPassa.Text = "passa turno";
            this.btnPassa.UseVisualStyleBackColor = false;
            // 
            // frmCampoGioco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.WWOne09;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(915, 518);
            this.ControlBox = false;
            this.Controls.Add(this.btnPassa);
            this.Controls.Add(this.btnAssalta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFronte);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtF3);
            this.Controls.Add(this.txtF2);
            this.Controls.Add(this.txtF1);
            this.Controls.Add(this.btnOpzioni);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSelezRiserve);
            this.Controls.Add(this.btnEsci);
            this.Controls.Add(this.btnAzioni);
            this.Controls.Add(this.btnBonus);
            this.Controls.Add(this.btnSposta);
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
        private System.Windows.Forms.Button btnSposta;
        private System.Windows.Forms.Button btnBonus;
        private System.Windows.Forms.Button btnAzioni;
        private System.Windows.Forms.Button btnEsci;
        private System.Windows.Forms.TextBox txtSelezRiserve;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOpzioni;
        private System.Windows.Forms.TextBox txtF1;
        private System.Windows.Forms.TextBox txtF2;
        private System.Windows.Forms.TextBox txtF3;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txtFronte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAssalta;
        private System.Windows.Forms.Button btnPassa;
    }
}