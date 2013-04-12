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
            this.groupBoxIPServer = new System.Windows.Forms.GroupBox();
            this.textBoxIP4 = new System.Windows.Forms.TextBox();
            this.textBoxIP3 = new System.Windows.Forms.TextBox();
            this.textBoxIP2 = new System.Windows.Forms.TextBox();
            this.textBoxIP1 = new System.Windows.Forms.TextBox();
            this.buttonIPok = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.labelPlayerName = new System.Windows.Forms.Label();
            this.textBoxPlayerName = new System.Windows.Forms.TextBox();
            this.buttonMultiPlayer = new System.Windows.Forms.Button();
            this.buttonSinglePlayer = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.groupBoxIPServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackgroundImage = global::snake1._0._2.Properties.Resources.serpent;
            this.panelMenu.Controls.Add(this.buttonBack);
            this.panelMenu.Controls.Add(this.labelMessage);
            this.panelMenu.Controls.Add(this.groupBoxIPServer);
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
            // groupBoxIPServer
            // 
            this.groupBoxIPServer.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxIPServer.Controls.Add(this.textBoxIP4);
            this.groupBoxIPServer.Controls.Add(this.textBoxIP3);
            this.groupBoxIPServer.Controls.Add(this.textBoxIP2);
            this.groupBoxIPServer.Controls.Add(this.textBoxIP1);
            this.groupBoxIPServer.Controls.Add(this.buttonIPok);
            this.groupBoxIPServer.Font = new System.Drawing.Font("SketchFlow Print", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxIPServer.Location = new System.Drawing.Point(3, 111);
            this.groupBoxIPServer.Name = "groupBoxIPServer";
            this.groupBoxIPServer.Size = new System.Drawing.Size(579, 70);
            this.groupBoxIPServer.TabIndex = 5;
            this.groupBoxIPServer.TabStop = false;
            this.groupBoxIPServer.Text = "Server IP Address";
            // 
            // textBoxIP4
            // 
            this.textBoxIP4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxIP4.Font = new System.Drawing.Font("SketchFlow Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIP4.Location = new System.Drawing.Point(342, 27);
            this.textBoxIP4.Name = "textBoxIP4";
            this.textBoxIP4.Size = new System.Drawing.Size(76, 24);
            this.textBoxIP4.TabIndex = 8;
            // 
            // textBoxIP3
            // 
            this.textBoxIP3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxIP3.Font = new System.Drawing.Font("SketchFlow Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIP3.Location = new System.Drawing.Point(260, 27);
            this.textBoxIP3.Name = "textBoxIP3";
            this.textBoxIP3.Size = new System.Drawing.Size(76, 24);
            this.textBoxIP3.TabIndex = 9;
            // 
            // textBoxIP2
            // 
            this.textBoxIP2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxIP2.Font = new System.Drawing.Font("SketchFlow Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIP2.Location = new System.Drawing.Point(178, 27);
            this.textBoxIP2.Name = "textBoxIP2";
            this.textBoxIP2.Size = new System.Drawing.Size(76, 24);
            this.textBoxIP2.TabIndex = 8;
            // 
            // textBoxIP1
            // 
            this.textBoxIP1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxIP1.Font = new System.Drawing.Font("SketchFlow Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIP1.Location = new System.Drawing.Point(96, 27);
            this.textBoxIP1.Name = "textBoxIP1";
            this.textBoxIP1.Size = new System.Drawing.Size(76, 24);
            this.textBoxIP1.TabIndex = 7;
            // 
            // buttonIPok
            // 
            this.buttonIPok.BackColor = System.Drawing.Color.Black;
            this.buttonIPok.Font = new System.Drawing.Font("SketchFlow Print", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIPok.ForeColor = System.Drawing.Color.Green;
            this.buttonIPok.Location = new System.Drawing.Point(466, 16);
            this.buttonIPok.Name = "buttonIPok";
            this.buttonIPok.Size = new System.Drawing.Size(110, 43);
            this.buttonIPok.TabIndex = 6;
            this.buttonIPok.Text = "OK";
            this.buttonIPok.UseVisualStyleBackColor = false;
            // 
            // buttonQuit
            // 
            this.buttonQuit.BackColor = System.Drawing.Color.Red;
            this.buttonQuit.Font = new System.Drawing.Font("SketchFlow Print", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuit.ForeColor = System.Drawing.Color.Black;
            this.buttonQuit.Location = new System.Drawing.Point(3, 9);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(125, 39);
            this.buttonQuit.TabIndex = 4;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = false;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
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
            // buttonMultiPlayer
            // 
            this.buttonMultiPlayer.BackColor = System.Drawing.Color.Black;
            this.buttonMultiPlayer.Font = new System.Drawing.Font("SketchFlow Print", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiPlayer.ForeColor = System.Drawing.Color.Green;
            this.buttonMultiPlayer.Location = new System.Drawing.Point(3, 243);
            this.buttonMultiPlayer.Name = "buttonMultiPlayer";
            this.buttonMultiPlayer.Size = new System.Drawing.Size(579, 49);
            this.buttonMultiPlayer.TabIndex = 1;
            this.buttonMultiPlayer.Text = "Dual Mode";
            this.buttonMultiPlayer.UseVisualStyleBackColor = false;
            this.buttonMultiPlayer.Click += new System.EventHandler(this.buttonMultiPlayer_Click);
            // 
            // buttonSinglePlayer
            // 
            this.buttonSinglePlayer.BackColor = System.Drawing.Color.Black;
            this.buttonSinglePlayer.Font = new System.Drawing.Font("SketchFlow Print", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSinglePlayer.ForeColor = System.Drawing.Color.Green;
            this.buttonSinglePlayer.Location = new System.Drawing.Point(3, 187);
            this.buttonSinglePlayer.Name = "buttonSinglePlayer";
            this.buttonSinglePlayer.Size = new System.Drawing.Size(579, 49);
            this.buttonSinglePlayer.TabIndex = 0;
            this.buttonSinglePlayer.Text = "Solo Mode";
            this.buttonSinglePlayer.UseVisualStyleBackColor = false;
            this.buttonSinglePlayer.Click += new System.EventHandler(this.buttonSinglePlayer_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.BackColor = System.Drawing.Color.Transparent;
            this.labelMessage.Font = new System.Drawing.Font("SketchFlow Print", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.Location = new System.Drawing.Point(207, 303);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(372, 26);
            this.labelMessage.TabIndex = 10;
            this.labelMessage.Text = "Waiting for";
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Black;
            this.buttonBack.Font = new System.Drawing.Font("SketchFlow Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.Green;
            this.buttonBack.Location = new System.Drawing.Point(3, 298);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(125, 30);
            this.buttonBack.TabIndex = 11;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
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
            this.groupBoxIPServer.ResumeLayout(false);
            this.groupBoxIPServer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonMultiPlayer;
        private System.Windows.Forms.Button buttonSinglePlayer;
        private System.Windows.Forms.Label labelPlayerName;
        private System.Windows.Forms.TextBox textBoxPlayerName;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.GroupBox groupBoxIPServer;
        private System.Windows.Forms.Button buttonIPok;
        private System.Windows.Forms.TextBox textBoxIP1;
        private System.Windows.Forms.TextBox textBoxIP4;
        private System.Windows.Forms.TextBox textBoxIP3;
        private System.Windows.Forms.TextBox textBoxIP2;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Button buttonBack;
    }
}