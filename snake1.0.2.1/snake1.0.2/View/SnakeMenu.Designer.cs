namespace snake1._0._2.View
{
    partial class SnakeMenu
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonSinglePlayer = new System.Windows.Forms.Button();
            this.buttonMultiPlayer = new System.Windows.Forms.Button();
            this.textBoxPlayerName = new System.Windows.Forms.TextBox();
            this.labelPlayerName = new System.Windows.Forms.Label();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackgroundImage = global::snake1._0._2.Properties.Resources.serpent;
            this.panelMenu.Controls.Add(this.buttonQuit);
            this.panelMenu.Controls.Add(this.labelPlayerName);
            this.panelMenu.Controls.Add(this.textBoxPlayerName);
            this.panelMenu.Controls.Add(this.buttonMultiPlayer);
            this.panelMenu.Controls.Add(this.buttonSinglePlayer);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(585, 336);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonSinglePlayer
            // 
            this.buttonSinglePlayer.BackColor = System.Drawing.Color.Black;
            this.buttonSinglePlayer.Font = new System.Drawing.Font("SketchFlow Print", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSinglePlayer.ForeColor = System.Drawing.Color.Gray;
            this.buttonSinglePlayer.Location = new System.Drawing.Point(3, 187);
            this.buttonSinglePlayer.Name = "buttonSinglePlayer";
            this.buttonSinglePlayer.Size = new System.Drawing.Size(579, 49);
            this.buttonSinglePlayer.TabIndex = 0;
            this.buttonSinglePlayer.Text = "Solo Mode";
            this.buttonSinglePlayer.UseVisualStyleBackColor = false;
            this.buttonSinglePlayer.Click += new System.EventHandler(this.buttonSinglePlayer_Click);
            // 
            // buttonMultiPlayer
            // 
            this.buttonMultiPlayer.BackColor = System.Drawing.Color.Black;
            this.buttonMultiPlayer.Font = new System.Drawing.Font("SketchFlow Print", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiPlayer.ForeColor = System.Drawing.Color.Gray;
            this.buttonMultiPlayer.Location = new System.Drawing.Point(3, 251);
            this.buttonMultiPlayer.Name = "buttonMultiPlayer";
            this.buttonMultiPlayer.Size = new System.Drawing.Size(579, 49);
            this.buttonMultiPlayer.TabIndex = 1;
            this.buttonMultiPlayer.Text = "Dual Mode";
            this.buttonMultiPlayer.UseVisualStyleBackColor = false;
            // 
            // textBoxPlayerName
            // 
            this.textBoxPlayerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxPlayerName.Font = new System.Drawing.Font("SketchFlow Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlayerName.Location = new System.Drawing.Point(433, 28);
            this.textBoxPlayerName.Name = "textBoxPlayerName";
            this.textBoxPlayerName.Size = new System.Drawing.Size(140, 24);
            this.textBoxPlayerName.TabIndex = 2;
            this.textBoxPlayerName.Text = "Solid Snake";
            // 
            // labelPlayerName
            // 
            this.labelPlayerName.AutoSize = true;
            this.labelPlayerName.Font = new System.Drawing.Font("SketchFlow Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerName.Location = new System.Drawing.Point(434, 9);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(139, 17);
            this.labelPlayerName.TabIndex = 3;
            this.labelPlayerName.Text = "Your Nickname";
            // 
            // buttonQuit
            // 
            this.buttonQuit.BackColor = System.Drawing.Color.Red;
            this.buttonQuit.Font = new System.Drawing.Font("SketchFlow Print", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuit.ForeColor = System.Drawing.Color.Black;
            this.buttonQuit.Location = new System.Drawing.Point(12, 9);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(125, 39);
            this.buttonQuit.TabIndex = 4;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = false;
            // 
            // SnakeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 336);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SnakeMenu";
            this.ShowIcon = false;
            this.Text = "Snake Game Menu";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonMultiPlayer;
        private System.Windows.Forms.Button buttonSinglePlayer;
        private System.Windows.Forms.Label labelPlayerName;
        private System.Windows.Forms.TextBox textBoxPlayerName;
        private System.Windows.Forms.Button buttonQuit;
    }
}