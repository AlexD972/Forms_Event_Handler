namespace TP1
{
    partial class Form3
    {
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
            this.bStart = new System.Windows.Forms.Button();
            this.bStop = new System.Windows.Forms.Button();
            this.bDestroy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(311, 415);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(75, 23);
            this.bStart.TabIndex = 0;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bStop
            // 
            this.bStop.Location = new System.Drawing.Point(405, 415);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(75, 23);
            this.bStop.TabIndex = 1;
            this.bStop.Text = "Stop";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // bDestroy
            // 
            this.bDestroy.Location = new System.Drawing.Point(495, 415);
            this.bDestroy.Name = "bDestroy";
            this.bDestroy.Size = new System.Drawing.Size(75, 23);
            this.bDestroy.TabIndex = 3;
            this.bDestroy.Text = "Destroy";
            this.bDestroy.UseVisualStyleBackColor = true;
            this.bDestroy.Click += new System.EventHandler(this.bDestroy_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bDestroy);
            this.Controls.Add(this.bStop);
            this.Controls.Add(this.bStart);
            this.IsMdiContainer = true;
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Button bDestroy;
    }
}