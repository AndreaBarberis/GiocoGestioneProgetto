namespace WindowsFormsApp1
{
    partial class frmSelezionePersonaggio
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelezionePersonaggio));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.brnRe = new System.Windows.Forms.Button();
            this.bntKing = new System.Windows.Forms.Button();
            this.btnZar = new System.Windows.Forms.Button();
            this.btnKaiser = new System.Windows.Forms.Button();
            this.btnReAp = new System.Windows.Forms.Button();
            this.pbReAp = new System.Windows.Forms.PictureBox();
            this.pbKaiser = new System.Windows.Forms.PictureBox();
            this.pbZar = new System.Windows.Forms.PictureBox();
            this.pbKing = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExtra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbReAp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKaiser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleziona il tuo comandante:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(330, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Giorgio V: rifornimenti più veloci";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(601, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nicola II: +truppe inziali\r\n-disciplina";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Vittorio Emanuele III: +50.000 truppe ordinabili (x3 volte)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Guglielmo II: combattività +1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(451, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Francesco Giuseppe: +2 punti azione";
            // 
            // brnRe
            // 
            this.brnRe.BackColor = System.Drawing.Color.Transparent;
            this.brnRe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnRe.Location = new System.Drawing.Point(89, 242);
            this.brnRe.Name = "brnRe";
            this.brnRe.Size = new System.Drawing.Size(75, 23);
            this.brnRe.TabIndex = 11;
            this.brnRe.Text = "Scegli il Re";
            this.brnRe.UseVisualStyleBackColor = false;
            this.brnRe.Click += new System.EventHandler(this.brnRe_Click);
            // 
            // bntKing
            // 
            this.bntKing.BackColor = System.Drawing.Color.Transparent;
            this.bntKing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntKing.Location = new System.Drawing.Point(361, 242);
            this.bntKing.Name = "bntKing";
            this.bntKing.Size = new System.Drawing.Size(75, 23);
            this.bntKing.TabIndex = 12;
            this.bntKing.Text = "scegli il King";
            this.bntKing.UseVisualStyleBackColor = false;
            this.bntKing.Click += new System.EventHandler(this.bntKing_Click);
            // 
            // btnZar
            // 
            this.btnZar.BackColor = System.Drawing.Color.Transparent;
            this.btnZar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZar.Location = new System.Drawing.Point(626, 242);
            this.btnZar.Name = "btnZar";
            this.btnZar.Size = new System.Drawing.Size(75, 23);
            this.btnZar.TabIndex = 13;
            this.btnZar.Text = "scegli lo Zar";
            this.btnZar.UseVisualStyleBackColor = false;
            this.btnZar.Click += new System.EventHandler(this.btnZar_Click);
            // 
            // btnKaiser
            // 
            this.btnKaiser.BackColor = System.Drawing.Color.Transparent;
            this.btnKaiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaiser.Location = new System.Drawing.Point(204, 434);
            this.btnKaiser.Name = "btnKaiser";
            this.btnKaiser.Size = new System.Drawing.Size(112, 23);
            this.btnKaiser.TabIndex = 14;
            this.btnKaiser.Text = "scegli il Kaiser";
            this.btnKaiser.UseVisualStyleBackColor = false;
            this.btnKaiser.Click += new System.EventHandler(this.btnKaiser_Click);
            // 
            // btnReAp
            // 
            this.btnReAp.BackColor = System.Drawing.Color.Transparent;
            this.btnReAp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReAp.Location = new System.Drawing.Point(464, 435);
            this.btnReAp.Name = "btnReAp";
            this.btnReAp.Size = new System.Drawing.Size(127, 23);
            this.btnReAp.TabIndex = 15;
            this.btnReAp.Text = "scegli il Re Apostolico";
            this.btnReAp.UseVisualStyleBackColor = false;
            this.btnReAp.Click += new System.EventHandler(this.btnReAp_Click);
            // 
            // pbReAp
            // 
            this.pbReAp.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Emperor_Francis_Joseph;
            this.pbReAp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbReAp.Location = new System.Drawing.Point(473, 253);
            this.pbReAp.Name = "pbReAp";
            this.pbReAp.Size = new System.Drawing.Size(127, 160);
            this.pbReAp.TabIndex = 8;
            this.pbReAp.TabStop = false;
            this.pbReAp.MouseLeave += new System.EventHandler(this.pbReAp_MouseLeave);
            this.pbReAp.MouseHover += new System.EventHandler(this.pbReAp_MouseHover);
            // 
            // pbKaiser
            // 
            this.pbKaiser.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._1200px_Kaiser_Wilhelm_II_of_Germany___1902;
            this.pbKaiser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbKaiser.Location = new System.Drawing.Point(204, 253);
            this.pbKaiser.Name = "pbKaiser";
            this.pbKaiser.Size = new System.Drawing.Size(122, 160);
            this.pbKaiser.TabIndex = 7;
            this.pbKaiser.TabStop = false;
            this.pbKaiser.MouseLeave += new System.EventHandler(this.pbKaiser_MouseLeave);
            this.pbKaiser.MouseHover += new System.EventHandler(this.pbKaiser_MouseHover);
            // 
            // pbZar
            // 
            this.pbZar.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._24f0b2f570780ea9;
            this.pbZar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbZar.Location = new System.Drawing.Point(593, 40);
            this.pbZar.Name = "pbZar";
            this.pbZar.Size = new System.Drawing.Size(135, 168);
            this.pbZar.TabIndex = 2;
            this.pbZar.TabStop = false;
            this.pbZar.MouseLeave += new System.EventHandler(this.pbZar_MouseLeave);
            this.pbZar.MouseHover += new System.EventHandler(this.pbZar_MouseHover);
            // 
            // pbKing
            // 
            this.pbKing.BackColor = System.Drawing.Color.Transparent;
            this.pbKing.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.download;
            this.pbKing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbKing.Location = new System.Drawing.Point(333, 40);
            this.pbKing.Name = "pbKing";
            this.pbKing.Size = new System.Drawing.Size(135, 170);
            this.pbKing.TabIndex = 1;
            this.pbKing.TabStop = false;
            this.pbKing.MouseLeave += new System.EventHandler(this.pbKing_MouseLeave);
            this.pbKing.MouseHover += new System.EventHandler(this.pbKing_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Re_Vittorio_Emanuele_III;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(73, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 168);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.Location = new System.Drawing.Point(12, 402);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(160, 88);
            this.btnInfo.TabIndex = 16;
            this.btnInfo.Text = "Come si gioca";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Consigliato vedere prima di giocare";
            // 
            // btnExtra
            // 
            this.btnExtra.BackColor = System.Drawing.Color.Transparent;
            this.btnExtra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtra.Location = new System.Drawing.Point(679, 414);
            this.btnExtra.Name = "btnExtra";
            this.btnExtra.Size = new System.Drawing.Size(75, 62);
            this.btnExtra.TabIndex = 18;
            this.btnExtra.Text = "extra";
            this.btnExtra.UseVisualStyleBackColor = false;
            this.btnExtra.Click += new System.EventHandler(this.btnExtra_Click);
            // 
            // frmSelezionePersonaggio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.btnExtra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnReAp);
            this.Controls.Add(this.btnKaiser);
            this.Controls.Add(this.btnZar);
            this.Controls.Add(this.bntKing);
            this.Controls.Add(this.brnRe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbReAp);
            this.Controls.Add(this.pbKaiser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbZar);
            this.Controls.Add(this.pbKing);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSelezionePersonaggio";
            this.Text = "frmSelezionePersonaggio";
            this.Load += new System.EventHandler(this.frmSelezionePersonaggio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbReAp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKaiser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbKing;
        private System.Windows.Forms.PictureBox pbZar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbKaiser;
        private System.Windows.Forms.PictureBox pbReAp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button brnRe;
        private System.Windows.Forms.Button bntKing;
        private System.Windows.Forms.Button btnZar;
        private System.Windows.Forms.Button btnKaiser;
        private System.Windows.Forms.Button btnReAp;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExtra;
    }
}

