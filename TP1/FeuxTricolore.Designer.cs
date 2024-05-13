namespace TP1
{
    partial class FeuxTricolore
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

        private void InitializeComponent()
        {
            this.FRouge = new System.Windows.Forms.Label();
            this.FOrange = new System.Windows.Forms.Label();
            this.FVert = new System.Windows.Forms.Label();
            this.bAppel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FRouge
            // 
            this.FRouge.BackColor = System.Drawing.Color.Black;
            this.FRouge.Location = new System.Drawing.Point(12, 9);
            this.FRouge.Name = "FRouge";
            this.FRouge.Size = new System.Drawing.Size(71, 61);
            this.FRouge.TabIndex = 0;
            this.FRouge.Text = "Rouge";
            this.FRouge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FOrange
            // 
            this.FOrange.BackColor = System.Drawing.Color.Black;
            this.FOrange.Location = new System.Drawing.Point(12, 70);
            this.FOrange.Name = "FOrange";
            this.FOrange.Size = new System.Drawing.Size(71, 68);
            this.FOrange.TabIndex = 1;
            this.FOrange.Text = "Orange";
            this.FOrange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FVert
            // 
            this.FVert.BackColor = System.Drawing.Color.Green;
            this.FVert.Location = new System.Drawing.Point(12, 138);
            this.FVert.Name = "FVert";
            this.FVert.Size = new System.Drawing.Size(71, 67);
            this.FVert.TabIndex = 2;
            this.FVert.Text = "Vert";
            this.FVert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bAppel
            // 
            this.bAppel.Location = new System.Drawing.Point(12, 221);
            this.bAppel.Name = "bAppel";
            this.bAppel.Size = new System.Drawing.Size(90, 30);
            this.bAppel.TabIndex = 3;
            this.bAppel.Text = "Appel";
            this.bAppel.UseVisualStyleBackColor = true;
            this.bAppel.Click += new System.EventHandler(this.bAppel_Click);
            // 
            // FeuxTricolore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(132, 289);
            this.Controls.Add(this.bAppel);
            this.Controls.Add(this.FVert);
            this.Controls.Add(this.FOrange);
            this.Controls.Add(this.FRouge);
            this.Name = "FeuxTricolore";
            this.Text = "l";
            this.ResumeLayout(false);

        }


        private System.Windows.Forms.Label FRouge;
        private System.Windows.Forms.Label FOrange;
        private System.Windows.Forms.Label FVert;
        private System.Windows.Forms.Button bAppel;
    }
}

