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
            this.SuspendLayout();
            // 
            // sequenceGameTimer
            // 
            this.sequenceGameTimer.Enabled = true;
            this.sequenceGameTimer.Tick += new System.EventHandler(this.sequenceGameTimer_Tick);
            // 
            // GamePanel
            // 
            this.GamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GamePanel.Location = new System.Drawing.Point(0, 0);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(284, 262);
            this.GamePanel.TabIndex = 0;
            // 
            // SnakeGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.GamePanel);
            this.Name = "SnakeGameForm";
            this.Text = "SnakeGame";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SnakeGameForm_FormClosed);
            this.Resize += new System.EventHandler(this.SnakeGameForm_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer sequenceGameTimer;
        private System.Windows.Forms.Panel GamePanel;
    }
}

