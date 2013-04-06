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
            this.panelBackground = new System.Windows.Forms.Panel();
            this.groupBoxRemoteGame = new System.Windows.Forms.GroupBox();
            this.groupBoxPlayerGame = new System.Windows.Forms.GroupBox();
            this.menuStripSnakeGame = new System.Windows.Forms.MenuStrip();
            this.scoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.panelBackground.SuspendLayout();
            this.groupBoxPlayerGame.SuspendLayout();
            this.menuStripSnakeGame.SuspendLayout();
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
            this.GamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GamePanel.Location = new System.Drawing.Point(3, 16);
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
            this.statusStrip.Location = new System.Drawing.Point(0, 455);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(932, 22);
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
            this.toolStripStatusLabelCPUdata.AutoSize = false;
            this.toolStripStatusLabelCPUdata.BackColor = System.Drawing.Color.Red;
            this.toolStripStatusLabelCPUdata.Name = "toolStripStatusLabelCPUdata";
            this.toolStripStatusLabelCPUdata.Size = new System.Drawing.Size(60, 17);
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
            // panelBackground
            // 
            this.panelBackground.AutoSize = true;
            this.panelBackground.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelBackground.Controls.Add(this.groupBoxRemoteGame);
            this.panelBackground.Controls.Add(this.groupBoxPlayerGame);
            this.panelBackground.Controls.Add(this.menuStripSnakeGame);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(932, 454);
            this.panelBackground.TabIndex = 2;
            // 
            // groupBoxRemoteGame
            // 
            this.groupBoxRemoteGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRemoteGame.Location = new System.Drawing.Point(612, 258);
            this.groupBoxRemoteGame.Name = "groupBoxRemoteGame";
            this.groupBoxRemoteGame.Size = new System.Drawing.Size(300, 192);
            this.groupBoxRemoteGame.TabIndex = 2;
            this.groupBoxRemoteGame.TabStop = false;
            this.groupBoxRemoteGame.Text = "Remote Game";
            // 
            // groupBoxPlayerGame
            // 
            this.groupBoxPlayerGame.Controls.Add(this.GamePanel);
            this.groupBoxPlayerGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPlayerGame.Location = new System.Drawing.Point(3, 36);
            this.groupBoxPlayerGame.Name = "groupBoxPlayerGame";
            this.groupBoxPlayerGame.Size = new System.Drawing.Size(606, 415);
            this.groupBoxPlayerGame.TabIndex = 0;
            this.groupBoxPlayerGame.TabStop = false;
            this.groupBoxPlayerGame.Text = "Player Game";
            // 
            // menuStripSnakeGame
            // 
            this.menuStripSnakeGame.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scoreToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStripSnakeGame.Location = new System.Drawing.Point(0, 0);
            this.menuStripSnakeGame.Name = "menuStripSnakeGame";
            this.menuStripSnakeGame.Size = new System.Drawing.Size(932, 24);
            this.menuStripSnakeGame.TabIndex = 1;
            this.menuStripSnakeGame.Text = "menuStripSnakeGame";
            // 
            // scoreToolStripMenuItem
            // 
            this.scoreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.scoreToolStripMenuItem.Name = "scoreToolStripMenuItem";
            this.scoreToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.scoreToolStripMenuItem.Text = "Score";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // SnakeGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 477);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.panelBackground);
            this.MainMenuStrip = this.menuStripSnakeGame;
            this.Name = "SnakeGameForm";
            this.ShowIcon = false;
            this.Text = "SnakeGame";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SnakeGameForm_FormClosed);
            this.Resize += new System.EventHandler(this.SnakeGameForm_Resize);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            this.groupBoxPlayerGame.ResumeLayout(false);
            this.menuStripSnakeGame.ResumeLayout(false);
            this.menuStripSnakeGame.PerformLayout();
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
        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.GroupBox groupBoxPlayerGame;
        private System.Windows.Forms.MenuStrip menuStripSnakeGame;
        private System.Windows.Forms.GroupBox groupBoxRemoteGame;
        private System.Windows.Forms.ToolStripMenuItem scoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

