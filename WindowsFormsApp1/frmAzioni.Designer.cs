namespace WindowsFormsApp1
{
    partial class frmAzioni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAzioni));
            this.btnDisc = new System.Windows.Forms.Button();
            this.btnTre = new System.Windows.Forms.Button();
            this.btnSpia = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnDisc
            // 
            this.btnDisc.Location = new System.Drawing.Point(51, 68);
            this.btnDisc.Name = "btnDisc";
            this.btnDisc.Size = new System.Drawing.Size(119, 57);
            this.btnDisc.TabIndex = 0;
            this.btnDisc.Text = "Ora dei sacrifici";
            this.btnDisc.UseVisualStyleBackColor = true;
            this.btnDisc.Click += new System.EventHandler(this.btnDisc_Click);
            // 
            // btnTre
            // 
            this.btnTre.Location = new System.Drawing.Point(51, 158);
            this.btnTre.Name = "btnTre";
            this.btnTre.Size = new System.Drawing.Size(119, 59);
            this.btnTre.TabIndex = 1;
            this.btnTre.Text = "Sabota linea ferroviaria";
            this.btnTre.UseVisualStyleBackColor = true;
            this.btnTre.Click += new System.EventHandler(this.btnTre_Click);
            // 
            // btnSpia
            // 
            this.btnSpia.Location = new System.Drawing.Point(51, 252);
            this.btnSpia.Name = "btnSpia";
            this.btnSpia.Size = new System.Drawing.Size(119, 58);
            this.btnSpia.TabIndex = 2;
            this.btnSpia.Text = "spionaggio";
            this.btnSpia.UseVisualStyleBackColor = true;
            this.btnSpia.Click += new System.EventHandler(this.btnSpia_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(187, 84);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(209, 41);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "Il discorso patriottico del capo dello stato aumenta la disciplina e combattività" +
    "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Enabled = false;
            this.richTextBox2.Location = new System.Drawing.Point(187, 167);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(209, 50);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "Un gruppo di temerari saboterà la linea nemica, in modo che i loiro rifornimenti " +
    "arrivino in ritardo";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Enabled = false;
            this.richTextBox3.Location = new System.Drawing.Point(187, 269);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(209, 41);
            this.richTextBox3.TabIndex = 5;
            this.richTextBox3.Text = "Le nostre spie cercheranno di ottenere informazioni sull\'esercito nemico";
            // 
            // frmAzioni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(476, 460);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnSpia);
            this.Controls.Add(this.btnTre);
            this.Controls.Add(this.btnDisc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAzioni";
            this.Text = "frmAzioni";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDisc;
        private System.Windows.Forms.Button btnTre;
        private System.Windows.Forms.Button btnSpia;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
    }
}