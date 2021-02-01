namespace WindowsFormsApp1
{
    partial class frmExtra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExtra));
            this.btnAB = new System.Windows.Forms.Button();
            this.btnPlaylist = new System.Windows.Forms.Button();
            this.btnWeb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAB
            // 
            this.btnAB.Location = new System.Drawing.Point(44, 66);
            this.btnAB.Name = "btnAB";
            this.btnAB.Size = new System.Drawing.Size(196, 44);
            this.btnAB.TabIndex = 0;
            this.btnAB.Text = "La Prima Guerra Mondiale di Alessandro Barbero";
            this.btnAB.UseVisualStyleBackColor = true;
            this.btnAB.Click += new System.EventHandler(this.btnAB_Click);
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.Location = new System.Drawing.Point(44, 144);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Size = new System.Drawing.Size(196, 44);
            this.btnPlaylist.TabIndex = 1;
            this.btnPlaylist.Text = "Soundtrack playlist";
            this.btnPlaylist.UseVisualStyleBackColor = true;
            this.btnPlaylist.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // btnWeb
            // 
            this.btnWeb.Location = new System.Drawing.Point(44, 222);
            this.btnWeb.Name = "btnWeb";
            this.btnWeb.Size = new System.Drawing.Size(196, 44);
            this.btnWeb.TabIndex = 2;
            this.btnWeb.Text = "Pagina Web";
            this.btnWeb.UseVisualStyleBackColor = true;
            this.btnWeb.Click += new System.EventHandler(this.btnWeb_Click);
            // 
            // frmExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(285, 325);
            this.Controls.Add(this.btnWeb);
            this.Controls.Add(this.btnPlaylist);
            this.Controls.Add(this.btnAB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmExtra";
            this.Text = "frmExtra";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAB;
        private System.Windows.Forms.Button btnPlaylist;
        private System.Windows.Forms.Button btnWeb;
    }
}