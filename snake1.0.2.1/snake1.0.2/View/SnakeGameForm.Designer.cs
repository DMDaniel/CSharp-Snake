namespace snake1._0._2.View
{
    partial class SnakeGameForm
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
            this.sequenceGameTimer = new System.Windows.Forms.Timer(this.components);
            this.GamePanel = new System.Windows.Forms.Panel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelCPU = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelCPUdata = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelDATEdata = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // sequenceGameTimer
            // 
            this.sequenceGameTimer.Enabled = true;
            this.sequenceGameTimer.Tick += new System.EventHandler(this.sequenceGameTimer_Tick);
            // 
            // GamePanel
            // 
            this.GamePanel.BackColor = System.Drawing.Color.Black;
            this.GamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GamePanel.Location = new System.Drawing.Point(0, 0);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(600, 396);
            this.GamePanel.TabIndex = 0;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelCPU,
            this.toolStripStatusLabelCPUdata,
            this.toolStripStatusLabelDate,
            this.toolStripStatusLabelDATEdata});
            this.statusStrip.Location = new System.Drawing.Point(0, 399);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(868, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelCPU
            // 
            this.toolStripStatusLabelCPU.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabelCPU.Name = "toolStripStatusLabelCPU";
            this.toolStripStatusLabelCPU.Size = new System.Drawing.Size(59, 17);
            this.toolStripStatusLabelCPU.Text = "CPU Load";
            // 
            // toolStripStatusLabelCPUdata
            // 
            this.toolStripStatusLabelCPUdata.BackColor = System.Drawing.Color.Red;
            this.toolStripStatusLabelCPUdata.Name = "toolStripStatusLabelCPUdata";
            this.toolStripStatusLabelCPUdata.Size = new System.Drawing.Size(29, 17);
            this.toolStripStatusLabelCPUdata.Text = "50%";
            // 
            // toolStripStatusLabelDate
            // 
            this.toolStripStatusLabelDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabelDate.Name = "toolStripStatusLabelDate";
            this.toolStripStatusLabelDate.Size = new System.Drawing.Size(34, 17);
            this.toolStripStatusLabelDate.Text = "Date";
            // 
            // toolStripStatusLabelDATEdata
            // 
            this.toolStripStatusLabelDATEdata.BackColor = System.Drawing.Color.Red;
            this.toolStripStatusLabelDATEdata.Name = "toolStripStatusLabelDATEdata";
            this.toolStripStatusLabelDATEdata.Size = new System.Drawing.Size(83, 17);
            this.toolStripStatusLabelDATEdata.Text = "01/04/13 14:01";
            // 
            // SnakeGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 421);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.GamePanel);
            this.Name = "SnakeGameForm";
            this.ShowIcon = false;
            this.Text = "SnakeGame";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SnakeGameForm_FormClosed);
            this.Resize += new System.EventHandler(this.SnakeGameForm_Resize);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer sequenceGameTimer;
        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCPU;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCPUdata;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDATEdata;
    }
}

